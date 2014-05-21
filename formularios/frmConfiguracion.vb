Public Class frmConfiguracion

    Private Sub ValoresConfiguracionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValoresConfiguracionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ValoresConfiguracionBindingSource.EndEdit()
        Me.ValoresConfiguracionTableAdapter.Update(Me.ColegioDataSet.ValoresConfiguracion)

    End Sub

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ColegioDataSet.ValoresConfiguracion' Puede moverla o quitarla según sea necesario.
        Me.ValoresConfiguracionTableAdapter.Fill(Me.ColegioDataSet.ValoresConfiguracion)

    End Sub
End Class