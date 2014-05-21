Imports System.Windows.Forms
Public Class Ventanas
    Enum AeroAction
        Disable
        Enable
    End Enum

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

    Public Sub AeroThemeSetting(ByVal action As AeroAction)
        Dim args As String = ""
        If action = AeroAction.Disable Then 'Rundll32 dwmApi #104
            args = "dwmApi #104"
        Else 'Rundll32 dwmApi #102
            args = "dwmApi #102"
        End If
        Dim process As System.Diagnostics.Process = Nothing
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo
        processStartInfo = New System.Diagnostics.ProcessStartInfo()
        processStartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System).ToString & "\Rundll32.exe"
        If System.Environment.OSVersion.Version.Major >= 6 Then ' Windows Vista or higher
            processStartInfo.Verb = "runas"
        End If
        processStartInfo.Arguments = args
        processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        processStartInfo.UseShellExecute = True
        Try
            process = System.Diagnostics.Process.Start(processStartInfo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not (process Is Nothing) Then
                process.Dispose()
            End If
        End Try
    End Sub

End Class
