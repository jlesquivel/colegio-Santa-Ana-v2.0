Imports System.Data.SqlClient

Public Class Notas
    Dim conn As New conexionSQL

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

    Public Sub CreaNotasExt()
        Try
            conn.ejecuta(("EXEC crea_notas '4', '" & Year(Now) & "'"))
            conn.ejecuta(("EXEC crea_notas '4', '" & Year(Now) & "'"))

            MessageBox.Show(" Notas Presentación Generadas ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
