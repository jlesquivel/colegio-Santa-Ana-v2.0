Public Class frmConvenios

    Private Sub ConveniosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveniosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ConveniosBindingSource.EndEdit()
        Me.ConveniosTableAdapter.Update(Me.DataSet1.convenios)

    End Sub

    Private Sub frmConvenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.convenios' Puede moverla o quitarla según sea necesario.
        Me.ConveniosTableAdapter.Fill(Me.DataSet1.convenios)

    End Sub
End Class