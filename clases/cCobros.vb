Imports System.Data.SqlClient
Public Class cCobros
    Dim conn As New conexionSQL
    Dim arch As String
    Dim GenCobro1 As colegio.genCobro = New colegio.genCobro()

    Private Function MesVal(ByVal mes As String) As Integer
        Dim meses As String() = {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Dim pos As Integer = 1
        While mes <> meses(pos) And pos < 13
            pos = pos + 1
        End While
        MesVal = pos
    End Function
    Function rell(ByVal parame As String) As String
        If parame.Length = 1 Then
            Return "0" & parame
        Else
            Return parame
        End If
    End Function
    Sub cobros_30(pmes As String, pMora As Boolean)
        Try
            ' Genera los cobros  llamando al  procedimiento almacenado "cobro"
            ' y los actualiza en la tabla cobros a traves del SQLAdapter2

            Dim anno, mes, concepto As String

            anno = Now.Year
            mes = MesVal(pmes)
            concepto = "Mensualidad"

            'consulta los registro en la bd para verificar si se generaron los cobros
            Dim commando As String =
                          "select * from cobros where mes=" & mes & " and year(generado)=" & anno.ToString
            Dim da As New SqlDataAdapter(commando, conn.conexion)
            GenCobro1.Tables("registros").Clear()
            da.Fill(GenCobro1, "registros")

            Dim registros As Integer = GenCobro1.Tables("registros").Rows.Count

            'If registros = 0 Then

            commando = "EXECUTE cobro '" & anno & "','" & mes & "' ,'" & concepto & "'"
            conn.ejecuta(commando)

            If Not pMora Then
                commando = "EXECUTE actualiza_multas"
                conn.ejecuta(commando)
            End If

            commando = "EXECUTE cancela_becados_totales"
            conn.ejecuta(commando)

            GeneraArchivo(anno, mes, concepto)

        Catch ex As Exception
            MessageBox.Show("cCobro: cobro_3" & ex.Message)
        End Try
    End Sub

    Sub cobros_15(pmes As String, pMora As Boolean)
        Dim commando As String = ""
        Dim da As New SqlDataAdapter(commando, conn.conexion)
        GenCobro1.Tables("registros").Clear()

        Dim anno As Integer = Now.Year
        Dim mes As String = pmes
        Dim concepto As String = "Mensualidad"
        mes = MesVal(pmes)

        commando = "EXECUTE cobro '" & anno & "','" & mes & "' ,'" & concepto & "'"
        conn.ejecuta(commando)

        If Not pMora Then
            commando = "EXECUTE actualiza_multas"
            conn.ejecuta(commando)
        End If

        GeneraArchivo(anno, mes, concepto)
    End Sub

    ''' <summary>
    ''' Genera cobros ANUAL en la base de datos
    ''' </summary>
    ''' <param name="pMora">True si requiere generar mora false no generea mora</param>
    Sub cobros_anual(pMora As Boolean)
        Try
            ' Genera los cobros  llamando al  procedimiento almacenado "cobro"
            ' y los actualiza en la tabla cobros a traves del SQLAdapter2

            Dim anno, mes, concepto As String
            Dim commando As String

            anno = Now.Year
            mes = Now.Month

            concepto = "Mensualidad"
            Select Case mes
                Case 1
                    mes = 2
                Case 12
                    mes = 11
                Case Else
                    mes = IIf(Now.Day <= 15, Now.Month, Now.Month + 1)
            End Select

            For Cmes As Integer = mes To 11
                commando = "EXECUTE cobro '" & anno & "','" & Cmes.ToString & "' ,'" & concepto & "'"
                conn.ejecuta(commando)
            Next

            commando = "EXECUTE cancela_becados_totales"
            conn.ejecuta(commando)

            If pMora Then
                commando = "EXECUTE actualiza_multas"
                conn.ejecuta(commando)
            End If
            GeneraArchivo(anno, mes, concepto)  'genera Archivo en escritorio

        Catch ex As Exception
            MessageBox.Show("cCobro: cobro_anual" & ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Genera Archivo de cobro en el escritorio
    ''' </summary>
    ''' <param name="pano"></param>
    ''' <param name="pmes"></param>
    ''' <param name="pconcepto"></param>
    Private Sub GeneraArchivo(pano As String, pmes As String, pconcepto As String)
        Dim escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)

        Dim fechaHora As String = DateTime.Now.ToString("yyyy-MM-dd H-mm-ss")

        arch = escritorio & "\CSA_" & pconcepto.ToUpper & "_" & fechaHora & ".txt"

        conn.llena(GenCobro1, "bncr", "select * from bncr")
        conn.GeneraArchivo(arch, GenCobro1.Tables("bncr"))
    End Sub
    Sub cobros_Matricula(ByVal anno As String, ByVal monto As Decimal, ByVal concepto As String, ByVal convenio As Decimal)
        Try
            ' Genera los cobros  llamando al  procedimiento almacenado "cobro"
            ' y los actualiza en la tabla cobros a traves del SQLAdapter2

            If monto > 0 Then
                Dim mes As String = 0

                'consulta los registro en la bd para verificar si se generaron los cobros
                Dim commando As String =
                          "select * from cobros where mes=" & mes & " and year(generado)=" & anno.ToString
                Dim da As New SqlDataAdapter(commando, conn.conexion)
                GenCobro1.Tables("registros").Clear()
                da.Fill(GenCobro1, "registros")


                Dim montoSTR As String = ""
                montoSTR = monto.ToString(System.Globalization.CultureInfo.InvariantCulture)

                commando = "EXECUTE cobroMatricula '" & anno & "','" & mes & "' ,'" & concepto & "' ," & montoSTR & " ," & convenio
                conn.ejecuta(commando)

                Dim escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                Dim fechaHora As String = DateTime.Now.ToString("yyyy-MM-dd H-mm-ss")
                arch = escritorio & "\CSA_" & concepto.ToUpper & "_" & fechaHora & ".txt"
                conn.llena(GenCobro1, "bncr", "select * from bncrMatricula where convenio=00" & convenio.ToString)

                Dim res As String = conn.GeneraArchivo(arch, GenCobro1.Tables("bncr"))
            Else
                MessageBox.Show("Seleccione un mes", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub cobros_Matricula(ByVal anno As String, ByVal monto As Decimal, ByVal concepto As String, ByVal convenio As Decimal, carnet As String)
        Try
            ' Genera los cobros  llamando al  procedimiento almacenado "cobro"
            ' y los actualiza en la tabla cobros a traves del SQLAdapter2

            If monto > 0 Then
                Dim mes As String = 0

                'consulta los registro en la bd para verificar si se generaron los cobros
                Dim commando As String =
                          "select * from cobros where mes=" & mes & " and year(generado)=" & anno.ToString
                Dim da As New SqlDataAdapter(commando, conn.conexion)
                GenCobro1.Tables("registros").Clear()
                da.Fill(GenCobro1, "registros")

                Dim montoSTR As String = ""
                montoSTR = monto.ToString(System.Globalization.CultureInfo.InvariantCulture)

                commando = "EXECUTE cobroMatriculaXcarnet '" & anno & "'," & mes & " ,'" & concepto _
                            & "' ," & montoSTR & " ," & convenio & " , '" & carnet & "'"

                conn.ejecuta(commando)

            Else
                MessageBox.Show("Seleccione un mes", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
