<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCtrlArchCobros
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CalendarView1 = New DevComponents.DotNetBar.Schedule.CalendarView()
        Me.DateNavigator1 = New DevComponents.DotNetBar.Schedule.DateNavigator()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.GridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.GridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalendarView1
        '
        Me.CalendarView1.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.CalendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CalendarView1.ContainerControlProcessDialogKey = True
        Me.CalendarView1.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalendarView1.ForeColor = System.Drawing.Color.Black
        Me.CalendarView1.HighlightCurrentDay = True
        Me.CalendarView1.LabelTimeSlots = True
        Me.CalendarView1.Location = New System.Drawing.Point(2, 30)
        Me.CalendarView1.MultiUserTabHeight = 21
        Me.CalendarView1.Name = "CalendarView1"
        Me.CalendarView1.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month
        Me.CalendarView1.Size = New System.Drawing.Size(631, 475)
        Me.CalendarView1.TabIndex = 0
        Me.CalendarView1.Text = "CalendarView1"
        Me.CalendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty
        Me.CalendarView1.TimeIndicator.Tag = Nothing
        Me.CalendarView1.TimeIndicator.Visibility = DevComponents.DotNetBar.Schedule.eTimeIndicatorVisibility.AllResources
        Me.CalendarView1.TimeSlotDuration = 30
        Me.CalendarView1.YearViewAppointmentLinkStyle = DevComponents.DotNetBar.Schedule.eYearViewLinkStyle.Style4
        '
        'DateNavigator1
        '
        Me.DateNavigator1.CalendarView = Me.CalendarView1
        Me.DateNavigator1.CanvasColor = System.Drawing.SystemColors.Control
        Me.DateNavigator1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateNavigator1.DisabledBackColor = System.Drawing.Color.Empty
        Me.DateNavigator1.Location = New System.Drawing.Point(2, 2)
        Me.DateNavigator1.Name = "DateNavigator1"
        Me.DateNavigator1.Size = New System.Drawing.Size(555, 28)
        Me.DateNavigator1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateNavigator1.TabIndex = 1
        Me.DateNavigator1.Text = "DateNavigator1"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(563, 4)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(70, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 12.0!
        Me.ButtonX1.TabIndex = 8
        Me.ButtonX1.Text = "Mes"
        '
        'GridViewX1
        '
        Me.GridViewX1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.GridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridViewX1.Location = New System.Drawing.Point(639, 30)
        Me.GridViewX1.Name = "GridViewX1"
        Me.GridViewX1.RowHeadersWidth = 21
        Me.GridViewX1.Size = New System.Drawing.Size(519, 475)
        Me.GridViewX1.TabIndex = 9
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Red
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX2.FadeEffect = False
        Me.ButtonX2.Location = New System.Drawing.Point(1107, 4)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(51, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.SymbolColor = System.Drawing.Color.White
        Me.ButtonX2.TabIndex = 10
        '
        'frmCtrlArchCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 517)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.GridViewX1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.DateNavigator1)
        Me.Controls.Add(Me.CalendarView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCtrlArchCobros"
        Me.Text = "Control Archivos cobros"
        CType(Me.GridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CalendarView1 As DevComponents.DotNetBar.Schedule.CalendarView
    Friend WithEvents DateNavigator1 As DevComponents.DotNetBar.Schedule.DateNavigator
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
