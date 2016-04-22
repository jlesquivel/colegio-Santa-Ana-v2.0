Imports System.Collections

Public Class frmConstEstud

    Dim ciclo As String = ""
    Dim año As String = ""
    Dim nivel As String = ""
    Dim ano As String = ""
    Dim pendiente As Boolean


    Private Sub frmConstEstud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ColegioDataSet.Trasladados' Puede moverla o quitarla según sea necesario.
        TrasladadosTableAdapter.Fill(Me.ColegioDataSet.Trasladados)
        dir.Text = My.Settings.Directora
        cargo.Text = My.Settings.cargo
        slogan.Text = My.Settings.Slogan

        cambiaBotones(False)
    End Sub

    Private Sub frmConstEstud_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Directora = dir.Text
        My.Settings.cargo = cargo.Text
        My.Settings.Slogan = slogan.Text
    End Sub

    Public Function añoCursa(carnet As String) As String
        añoCursa = ""

        Dim conn As New conexionSQL
        Dim res As New ArrayList

        res = conn.llena("exec annoCursa " & carnet)
        If res.Count > 0 Then
            añoCursa = res(0)(0)
            ciclo = res(0)(1)
        Else
            añoCursa = "0000"
            ciclo = "00"
        End If
    End Function
    Private Sub BuscaEstud1_selecionado(sender As Object, e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        pendiente = False
        cambiaBotones(False)
        If BuscaEstud1.seleccionado <> "" Then
            Dim est As New cEstudiantes(BuscaEstud1.seleccionado)
            If Not est.RPendientes Then
                TextBoxX1.Focus()
                llenaAñosCombobox()
            Else
                pendiente = True
                MsgBox("Estudiante con recibos pendiente = " & est.RecibosPendientes.Rows.Count.ToString,)

            End If
        End If
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged
        If Not pendiente Then
            cambiaBotones(True)
        End If
    End Sub

    Private Sub cambiaBotones(valor As Boolean)
        contancia.Enabled = valor
        certificacion.Enabled = valor
        traslado.Enabled = valor
    End Sub

    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

    End Function

    Private Sub contancia_Click(sender As Object, e As EventArgs) Handles contancia.Click

        Dim wdDoc As New cWord(My.Application.Info.DirectoryPath & "\constEstud.docx")

        Dim param As New ArrayList                    ' valora e sustituir en el documento , deben esta los bookmarks
        param.Add({"NO", TextBoxX1.Text})
        param.Add({"slogan", slogan.Text})
        param.Add({"firma", dir.Text})
        param.Add({"suscribe", dir.Text})
        param.Add({"cargo", cargo.Text})
        param.Add({"cargo2", cargo.Text})
        param.Add({"dia", Num2Text(Now.Day).ToLower})
        param.Add({"año", Now.Year.ToString})
        param.Add({"anno", Now.Year.ToString})
        param.Add({"mes", MonthName(Now.Month, False)})
        param.Add({"estudiante", BuscaEstud1.nombre})
        param.Add({"cedula", BuscaEstud1.seleccionado})
        param.Add({"grado", añoCursa(BuscaEstud1.seleccionado)})
        param.Add({"ciclo", ciclo})

        wdDoc.SustituyeValores(param)

        Dim nombreArch As String = "Constancia (" & TextBoxX1.Text & ")" & BuscaEstud1.nombre
        wdDoc.guarda(nombreArch)

        cambiaBotones(False)
    End Sub

    Private Sub certificacion_Click(sender As Object, e As EventArgs) Handles certificacion.Click

        Dim wdDoc As New cWord(My.Application.Info.DirectoryPath & "\certNotas.docx")

        Dim param As New ArrayList                    ' valora e sustituir en el documento , deben esta los bookmarks
        param.Add({"NO", TextBoxX1.Text})
        param.Add({"slogan", slogan.Text})
        param.Add({"firma", dir.Text})
        param.Add({"suscribe", dir.Text})
        param.Add({"cargo", cargo.Text})
        param.Add({"cargo2", cargo.Text})
        param.Add({"dia", Num2Text(Now.Day).ToLower})
        param.Add({"año", año})
        param.Add({"anno", Now.Year.ToString})
        param.Add({"mes", MonthName(Now.Month, False)})
        param.Add({"estudiante", BuscaEstud1.nombre})
        param.Add({"cedula", BuscaEstud1.seleccionado})
        param.Add({"grado", nivel})
        param.Add({"ciclo", ciclo})
        param.Add({"minima", "70"})  'nota minima
        param.Add({"condfinal", "APROBADO"}) 'condicion final

        wdDoc.SustituyeValores(param)

        wdDoc.llenaTabla(tablaNotas(BuscaEstud1.seleccionado))

        Dim nombreArch As String = "CertNotas(" & TextBoxX1.Text & ")" & BuscaEstud1.nombre
        wdDoc.guarda(nombreArch)

        contancia.Enabled = False
    End Sub

    Private Sub traslado_Click(sender As Object, e As EventArgs) Handles traslado.Click


        Dim wdDoc As New cWord(My.Application.Info.DirectoryPath & "\certTraslado.docx")

        Dim param As New ArrayList                    ' valora e sustituir en el documento , deben esta los bookmarks
        param.Add({"NO", TextBoxX1.Text})
        param.Add({"slogan", slogan.Text})
        param.Add({"firma", dir.Text})
        param.Add({"suscribe", dir.Text})
        param.Add({"cargo", cargo.Text})
        param.Add({"cargo2", cargo.Text})
        param.Add({"dia", Num2Text(Now.Day).ToLower})
        param.Add({"año", año})
        param.Add({"anno", Now.Year.ToString})
        param.Add({"mes", MonthName(Now.Month, False)})
        param.Add({"estudiante", BuscaEstud1.nombre})
        param.Add({"cedula", BuscaEstud1.seleccionado})
        param.Add({"grado", nivel})
        param.Add({"ciclo", ciclo})
        param.Add({"notaMin", IIf(CInt(ano) >= 10, "75", "70")})  'nota minima
        param.Add({"condFinal", "APROBADO"}) 'condicion final

        wdDoc.SustituyeValores(param)

        wdDoc.llenaTabla(tablaNotas(BuscaEstud1.seleccionado))

        Dim nombreArch As String = "CertTraslado(" & TextBoxX1.Text & ")" & BuscaEstud1.nombre
        wdDoc.guarda(nombreArch)

        'TODO: Cambiar estado del estudiante a traladado y regisrar en CRM el traslado
        'TODO: Marcar todo los cobros a partir de esta fecha en adelante como cancelado 
        '       y se reintegra volverlos a activar para seguir cobrando

        cambiaEstadoEstud()

        contancia.Enabled = False
    End Sub
    ''' <summary>
    ''' Devuelve un arraylis con las notas del esstudiante con carnte -xxxx
    ''' </summary>
    ''' <param name="carnet"> string carnet a buscar en la base de datos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function tablaNotas(carnet As String) As ArrayList
        tablaNotas = New ArrayList

        Dim conn As New conexionSQL
        tablaNotas = conn.llena("EXEC NotasEstudAño " & BuscaEstud1.seleccionado & "," & año)

    End Function

    Private Sub llenaAñosCombobox()
        If BuscaEstud1.seleccionado <> "" Then
            Dim conn As New conexionSQL
            Dim res As ArrayList = conn.llena("exec matriculasEst " & BuscaEstud1.seleccionado)

            ComboBoxEx1.Items.Clear()
            For Each oAño As Object In res
                ComboBoxEx1.Items.Add(oAño(0) & " :" & oAño(2))
            Next

            ComboBoxEx1.Tag = res
            ComboBoxEx1.SelectedIndex = 0
        End If

    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        nivel = ComboBoxEx1.SelectedItem.ToString.Substring(6, ComboBoxEx1.SelectedItem.ToString.Length - 6)
        año = ComboBoxEx1.SelectedItem.ToString.Substring(0, 4)
        ciclo = ComboBoxEx1.Tag(ComboBoxEx1.SelectedIndex)(3)
        ano = ComboBoxEx1.Tag(ComboBoxEx1.SelectedIndex)(1)
    End Sub

    Sub cambiaEstadoEstud()
        Dim conn As New conexionSQL

        Dim inst As String = String.Format("exec InsertaTraslado '{0}','{1}'", BuscaEstud1.seleccionado, TextBoxX1.Text)
        conn.ejecuta(inst)
    End Sub
End Class