<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobrosAnual
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.chkMora = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'CircularProgress1
        '
        Me.CircularProgress1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(10, 10)
        Me.CircularProgress1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
        Me.CircularProgress1.ProgressColor = System.Drawing.Color.SteelBlue
        Me.CircularProgress1.ProgressText = "Generando"
        Me.CircularProgress1.Size = New System.Drawing.Size(83, 83)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 0
        Me.CircularProgress1.Value = 100
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(117, 11)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(185, 73)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.SymbolSize = 36.0!
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Generar <br/> cobros"
        '
        'Timer1
        '
        '
        'bw
        '
        '
        'chkMora
        '
        '
        '
        '
        Me.chkMora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkMora.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMora.Location = New System.Drawing.Point(117, 88)
        Me.chkMora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkMora.Name = "chkMora"
        Me.chkMora.Size = New System.Drawing.Size(83, 19)
        Me.chkMora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkMora.TabIndex = 2
        Me.chkMora.Text = "Mora"
        '
        'frmCobrosAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(374, 157)
        Me.Controls.Add(Me.chkMora)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.CircularProgress1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCobrosAnual"
        Me.Text = "Cobros Anual"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents chkMora As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
