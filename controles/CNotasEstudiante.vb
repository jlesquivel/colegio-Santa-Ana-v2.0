Imports System.Data.SqlClient
Public Class CNotasEstudiante

    Dim conn As New conexionSQL
    Dim carnet As String


    Public Sub buscar(ByVal carnet As String)
        Dim strConn As String = conn.strConn
        Dim conne As New SqlConnection(strConn)
        conne.Open()
        Me.MatriculaTableAdapter.Connection = conne
        Me.MatriculaTableAdapter.FillByCarnet(Me.ColegioDataSet.matricula, carnet)
        conne.Close()
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'MessageBox.Show(Me.DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString)
        Dim strConn As String = conn.strConn

        Dim conne As New SqlConnection(strConn)
        Me.NotasTableAdapter.Connection = conne
        Me.NotasTableAdapter.FillById_mat(Me.ColegioDataSet.notas, Me.DataGridView2.Rows(e.RowIndex).Cells(3).Value)

    End Sub

End Class
