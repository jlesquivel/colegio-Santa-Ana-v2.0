Imports System.Windows.Forms
Public Class Ventanas

    Public Sub cambia_fondoMDI(ByVal vnt As Form)
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        For Each ctl In vnt.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = vnt.BackColor
            Catch ex As Exception

            End Try
        Next
    End Sub
    Public Sub cargarVentana(ByRef pfrm As Object, ByVal base As Form)
        GC.Collect()
        Dim existe As Boolean = False
        Dim oFormHijos() As Form = base.MdiChildren
        Dim oForm As Form

        For Each oForm In oFormHijos        'busca una ventana abierta
            If oForm.Text = pfrm.Text Then
                existe = True
            End If
        Next

        If Not existe Then          'carga la ventana
            Dim frm As New Form
            frm = pfrm
            frm.BackColor = base.BackColor

            frm.MdiParent = base
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.MaximizeBox = False
            frm.Show()
        Else
            MessageBox.Show("La ventana " & UCase(pfrm.Text) & " ya esta cargada" _
            , "Ventana", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
