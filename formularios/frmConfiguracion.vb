Public Class frmConfiguracion

    Private Sub ValoresConfiguracionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValoresConfiguracionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ValoresConfiguracionBindingSource.EndEdit()
        Me.ValoresConfiguracionTableAdapter.Update(Me.ColegioDataSet.ValoresConfiguracion)

    End Sub

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta l�nea de c�digo carga datos en la tabla 'ColegioDataSet.ValoresConfiguracion' Puede moverla o quitarla seg�n sea necesario.
        Me.ValoresConfiguracionTableAdapter.Fill(Me.ColegioDataSet.ValoresConfiguracion)

    End Sub
End Class