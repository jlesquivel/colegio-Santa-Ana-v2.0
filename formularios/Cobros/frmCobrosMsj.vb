Public Class frmCobrosMsj
    Private Sub frmCobrosMsj_Load(sender As Object, e As EventArgs) Handles Me.Load
        admin.Text = My.Settings.Admin
        msj1.Rtf = My.Settings.msj1Cobro
        msj2.Rtf = My.Settings.msj2Cobro

    End Sub
    Private Sub frmCobrosMsj_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Admin = admin.Text
        My.Settings.msj1Cobro = msj1.Rtf.ToString
        My.Settings.msj2Cobro = msj2.Rtf.ToString
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles Impreso.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles correo.Click

    End Sub
End Class