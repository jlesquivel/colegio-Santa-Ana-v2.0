Imports colegioReportes

Public Class frmRecibos

    Private Sub frmRecibos_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ButtonX1.Enabled = False

        Dim mesLista As Integer = (Now.Month - 2)
        Dim objlista As DevComponents.DotNetBar.ListBoxItem = ListBoxAdv1.Items(mesLista)
        objlista.IsSelected = True

        ' Actualiza_niveles()

        ButtonX1.Enabled = True

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Cursor = Cursors.WaitCursor

        Dim mes As String = ListBoxAdv1.SelectedItem.Tag
        Dim niveles As String = ""

        For Each ele As Object In ListBoxAdv2.SelectedItems
            niveles += " '" & ele.ToString.Substring(0, 2) & "' ,"
        Next
        If niveles.Length > 0 Then
            niveles = Trim(niveles.Substring(0, niveles.Length - 1))
        Else
            MsgBox("Favor Seleccionar niveles a imprimir")
            Return
        End If

        Dim oReporte As New Reportes
        Dim reporte As New rptRecibos
        Dim impresora As String

        If ListBoxAdv2.SelectedItems.Count > 0 Then  'si hay niveles seleccionados
            ' Imprime niveles seleccionados
            impresora = oReporte.BuscarImpresora("TM-U")

            If impresora <> "" Then
                oReporte.inserta_parametro(reporte, "pano", Now.Year)
                oReporte.inserta_parametro(reporte, "pmes", CInt(mes))
                oReporte.inserta_parametro(reporte, "pniveles", niveles)

                If CheckBoxX1.Checked Then
                    reporte.PrintOptions.PrinterName = impresora
                    oReporte.imprimir(reporte, False, ParentForm)  ' prueba pantalla
                Else
                    oReporte.imprimir(reporte, impresora) ' impresora rollo
                End If
            Else
                MsgBox("impresora TM-U no detectada")
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Sub Actualiza_niveles()

        ListBoxAdv2.Items.Clear()
        Dim conn As New ConexionSQL
        Dim resultado As New ArrayList
        Dim año As String = Now.Year.ToString
        Dim mes As String = ListBoxAdv1.SelectedItem.Tag
        Dim cant As Integer = 0

        resultado = conn.llena("exec NivelesRecibos '" & año & "','" & mes & "'")
        If resultado IsNot Nothing Then
            For Each elemento As Object In resultado
                ListBoxAdv2.Items.Add(elemento(0) & "   (" & elemento(1) & ")")
            Next
        End If
    End Sub

    Private Sub ListBoxAdv1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAdv1.SelectedIndexChanged
        Actualiza_niveles()
    End Sub
End Class