Public Class frmConfiguracion

    Private Sub ValoresConfiguracionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValoresConfiguracionBindingNavigatorSaveItem.Click
        Validate()
        ValoresConfiguracionBindingSource.EndEdit()
        ValoresConfiguracionTableAdapter.Update(ColegioDataSet.ValoresConfiguracion)

    End Sub

    Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValoresConfiguracionTableAdapter.Fill(ColegioDataSet.ValoresConfiguracion)

    End Sub
End Class