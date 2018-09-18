Imports System
Imports System.Net.Mail 'referencia

Public Class CCorreo
    Dim servidor As String = "smtp.gmail.com"
    Dim puerto As Integer = 587
    Dim ssl As Boolean = True
    Dim credenciales As Boolean = True

    Dim cuenta As String = "joseluis.esquivelgarnier@gmail.com"
    Dim contrasena As String = "5269349"

    Public Sub New(pDe As String, pPara As String, pasunto As String, pmsj As String)
        Enviar_mail(pDe, pPara, pasunto, pmsj)
    End Sub

    Sub New()

    End Sub

    Public Sub Enviar_mail(ByVal i_de As String, ByVal i_para As String, ByVal asunto As String, ByVal mensaje As String)

        Dim insMail As New MailMessage(i_de, i_para)

        With insMail
            .Subject = asunto
            .IsBodyHtml = True 'envia el mensaje como html
            .Body = mensaje
            .IsBodyHtml = True
            .From = New MailAddress(i_de, "COLEGIO SANTA ANA")
            .ReplyToList.Add(i_de)

        End With

        Dim smtp As New SmtpClient With {
            .Host = servidor,
            .Port = puerto,
            .EnableSsl = ssl,
            .UseDefaultCredentials = credenciales,
            .Credentials = New System.Net.NetworkCredential(cuenta, contrasena)
        }

        Try
            smtp.Send(insMail)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Public Sub Enviar_Cobros_correo()

        Dim Administrador As String = "Hna Dinora"

        Dim conn As New ConexionSQL
        Dim dataset1 As New DataSet()
        dataset1.Tables.Add("Morosos")
        conn.llena(dataset1, "Morosos", "select carnet,id_mat,pendientes from estudiantes_morosos")

        Dim body As String = String.Empty
        Dim contacto As DataRow

        Dim bodyOriginal As String = String.Empty
        Dim reader As IO.StreamReader = New IO.StreamReader("repNotaCobro.html")
        bodyOriginal = reader.ReadToEnd

        Dim contador As Integer = 1

        For Each row As DataRow In dataset1.Tables(0).Rows
            contacto = ContactoPadres(row("carnet"))

            body = bodyOriginal
            body = body.Replace("{fecha}", DateTime.Now().ToString("dd/MM/yyyy"))
            body = body.Replace("{padre}", contacto("encargado1"))
            body = body.Replace("{reporte}", ReporteMorosidad(row("carnet")))
            body = body.Replace("{administrador}", Administrador)

            Enviar_mail("joseluis.esquivelgarnier@gmail.com", "joseluis@esquivel.com", "CSA aviso", body)

            If contador = 2 Then ' control para que solo envie 2 correos ya salga
                Exit For
            End If
            contador = contador + 1

            Threading.Thread.Sleep(500) ' espera para no saturar servidor
        Next
    End Sub


    Function ReporteMorosidad(vcarnet As String) As String
        Dim conn As New ConexionSQL
        Dim resultado As String = ""

        Dim dataset1 As New DataSet()
        dataset1.Tables.Add("tmp")
        conn.llena(dataset1, "tmp", "EXEC MorosidadEstudiante " & vcarnet)

        For Each row As DataRow In dataset1.Tables(0).Rows
            resultado = resultado & row("resultado") & vbCrLf
        Next

        Return resultado
    End Function

    Function ContactoPadres(vcarnet As String) As DataRow
        Dim conn As New ConexionSQL

        Dim dataset1 As New DataSet()
        dataset1.Tables.Add("tmp")
        conn.llena(dataset1, "tmp", "EXEC correo_contactoPadres " & vcarnet)

        Return dataset1.Tables(0).Rows.Item(0)
    End Function

End Class
