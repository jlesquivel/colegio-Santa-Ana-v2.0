Imports System.ComponentModel
Imports colegio

Public Class frmMatriculaBloquea


    Private Sub frmMatriculaBloquea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet2.bloqueados_ver' Puede moverla o quitarla según sea necesario.
        Me.Bloqueados_verTableAdapter.Fill(Me.DataSet2.bloqueados_ver)
        'TODO: esta línea de código carga datos en la tabla 'DataSet2.matricula_bloqueados' Puede moverla o quitarla según sea necesario.
        Me.Matricula_bloqueadosTableAdapter.Fill(Me.DataSet2.matricula_bloqueados)



    End Sub

    Private Sub frmMatriculaBloquea_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        guarda()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim existe As Boolean = CheckValue(DataSet2.matricula_bloqueados, Function(x) x("carnet") = BuscaEstud1.seleccionado)
        If Not existe Then
            Dim usuario As String = System.Security.Principal.WindowsIdentity.GetCurrent().Name

            Matricula_bloqueadosTableAdapter.Insert(BuscaEstud1.seleccionado, "", Now.Date, usuario)
            guarda()
            Me.Bloqueados_verTableAdapter.Fill(Me.DataSet2.bloqueados_ver)
        End If
    End Sub

    Sub guarda()
        Me.Validate()
        Me.Matricula_bloqueadosBindingSource.EndEdit()
        Me.Matricula_bloqueadosTableAdapter.Update(Me.DataSet2.matricula_bloqueados)
    End Sub


    Private Sub Bloqueados_verDataGridViewX_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Bloqueados_verDataGridViewX.RowHeaderMouseDoubleClick
        Dim id As Object = sender.Rows(e.RowIndex).Cells(0).Value

        Dim regis As DataSet2.matricula_bloqueadosRow
        regis = DataSet2.matricula_bloqueados.FindByid_mat_bloq(id)

        If regis IsNot Nothing Then
            regis.Delete()
            guarda()

            Me.Bloqueados_verTableAdapter.Fill(Me.DataSet2.bloqueados_ver)
        End If

    End Sub


    Shared Function CheckValue(myTable As DataTable, checkFunc As Func(Of DataRow, Boolean)) As Boolean
        For Each row As DataRow In myTable.Rows
            If checkFunc(row) Then Return True
        Next
        Return False
    End Function
End Class