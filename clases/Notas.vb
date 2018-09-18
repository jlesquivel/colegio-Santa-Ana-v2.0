Imports System.Data.SqlClient

Public Class Notas
    Dim conn As New ConexionSQL

    Public Sub CreaNotasBD()
        Try
            conn.ejecuta(("EXEC crea_notas '1', '" & Year(Now) & "'"))
            conn.ejecuta(("EXEC crea_notas '2', '" & Year(Now) & "'"))
            conn.ejecuta(("EXEC crea_notas '3', '" & Year(Now) & "'"))
            MessageBox.Show(" Notas Generadas ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CreaNotasConv1()
        Try
            conn.ejecuta(("EXEC crea_notas '4', '" & Year(Now) & "'"))
            MessageBox.Show(" Notas Presentación Generadas ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub CreaNotasConv2()
        Try
            Dim año As String = ""
            Select Case Month(Now)
                Case 1, 2, 3, 4
                    año = Year(Now) - 1
                Case Else
                    año = Year(Now)
            End Select
            conn.ejecuta(("EXEC crea_notas '5', '" & año & "'"))
            MessageBox.Show(" Notas Presentación Generadas ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
