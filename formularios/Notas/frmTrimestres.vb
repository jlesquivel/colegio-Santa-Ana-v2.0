Public Class frmTrimestres
    Private Sub frmTrimestres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.vTrimestres' Puede moverla o quitarla según sea necesario.
        Me.VTrimestresTableAdapter.Fill(Me.DataSet1.vTrimestres)

    End Sub
End Class