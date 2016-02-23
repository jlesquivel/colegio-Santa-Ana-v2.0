Imports System.ComponentModel

Public Class frmCobrosAnual
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        CircularProgress1.Visible = True
        CircularProgress1.Refresh()
        CircularProgress1.IsRunning = True

        If Not bw.IsBusy Then
            bw.RunWorkerAsync()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgress1.Value += 2
    End Sub

    Private Sub CircularProgress1_ValueChanged(sender As Object, e As EventArgs) Handles CircularProgress1.ValueChanged
        CircularProgress1.IsRunning = Not CircularProgress1.IsRunning
    End Sub

    Private Sub frmCobrosAnual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork
        Dim oCobros As cCobros = New cCobros
        If chkMora.CheckState = CheckState.Checked Then
            oCobros.cobros_anual(True)       '  GENERA COBROS ANUAL y CALCULA MOROSIDAD
        Else
            oCobros.cobros_anual(False)       '  GENERA COBROS ANUAL
        End If

    End Sub

    Private Sub bw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
        CircularProgress1.IsRunning = False
        CircularProgress1.Visible = False
    End Sub
End Class