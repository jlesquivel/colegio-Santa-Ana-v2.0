
Imports DevComponents.DotNetBar.Schedule
Imports DevComponents.Schedule.Model

Public Class frmCtrlArchCobros

    Dim _Model As New CalendarModel()
    Dim conn As New conexionSQL

    Dim fechaAno As Integer = Now.Year
    Dim fechaMes As Integer = Now.Month


    Private Sub frmCtrlArchCobros_Load(sender As Object, e As EventArgs) Handles Me.Load
        CalendarView1.TimeLineShowPageNavigation = True
        CalendarView1.YearViewStartDate = Now.AddMonths(-11)
        CalendarView1.YearViewEndDate = Now
        archivos_Calendario(fechaAno, fechaMes)
    End Sub



    Sub archivos_Calendario(anno As Integer, mes As Integer)

        'Cargar datos de BD
        Dim dbArch As ArrayList
        dbArch = conn.llena("EXEC CobrosArchivos " & anno.ToString & "," & mes.ToString)

        _Model.Appointments.Clear()

        If dbArch.Count > 0 Then
            Dim fechaCont As Integer = 1
            Dim fechaAnt As Date = dbArch(0)(1)

            'Agregar apuntes al modelo del calendario

            For Each fila As Object In dbArch
                Dim appointment As New Appointment()
                If fila(1) = fechaAnt Then
                    fechaCont += 1
                Else
                    fechaCont = 0
                    fechaAnt = fila(1)
                End If
                appointment.Subject = fila(0)
                appointment.StartTime = fila(1).AddMinutes(30 * fechaCont)
                appointment.EndTime = appointment.StartTime.AddMinutes(30)
                appointment.CategoryColor = Appointment.CategoryGreen
                appointment.TimeMarkedAs = Appointment.TimerMarkerDefault
                _Model.Appointments.Add(appointment)
            Next

            'actualizar calendario
            CalendarView1.CalendarModel = _Model

        End If

    End Sub

    Private Sub DateNavigator1_DateChanged(sender As Object, e As DateNavigator.DateChangedEventArgs) Handles DateNavigator1.DateChanged

        If fechaAno <> e.NewStartDate.Year Or fechaMes <> e.NewStartDate.Month Then
            fechaAno = e.NewStartDate.Year
            fechaMes = e.NewStartDate.Month
            archivos_Calendario(fechaAno, fechaMes)
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        CalendarView1.SelectedView = eCalendarView.Month
    End Sub

    Private Sub CalendarView1_ItemClick(sender As Object, e As EventArgs) Handles CalendarView1.ItemClick
        If CalendarView1.SelectedAppointments.Count = 1 Then
            Dim arch As String = CalendarView1.SelectedAppointments.Item(0).Appointment.Subject
            Dim dt As New DataTable

            dt = conn.llenaTabla("EXEC CobrosArchivosDetalle '" & arch & "'")
            GridViewX1.DataSource = dt

            GridViewX1.AutoResizeColumns()
        Else
            GridViewX1.DataSource = Nothing
        End If

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub
End Class