Public Class frmTrimestres
    Private Sub frmTrimestres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta l�nea de c�digo carga datos en la tabla 'DataSet1.vTrimestres' Puede moverla o quitarla seg�n sea necesario.
        Me.VTrimestresTableAdapter.Fill(Me.DataSet1.vTrimestres)

    End Sub
End Class