Public Class frmConvenios

    Private Sub ConveniosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveniosBindingNavigatorSaveItem.Click
        Validate()
        ConveniosBindingSource.EndEdit()
        ConveniosTableAdapter.Update(DataSet1.convenios)

    End Sub

    Private Sub frmConvenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConveniosTableAdapter.Fill(DataSet1.convenios)

    End Sub
End Class