<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobrosMsjCorreo
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
        Me.Administradora = New DevComponents.DotNetBar.LabelX()
        Me.admin = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.msj1 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.msj2 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.Impreso = New DevComponents.DotNetBar.ButtonX()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Administradora
        '
        '
        '
        '
        Me.Administradora.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Administradora.Location = New System.Drawing.Point(26, 21)
        Me.Administradora.Name = "Administradora"
        Me.Administradora.Size = New System.Drawing.Size(75, 23)
        Me.Administradora.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Administradora.TabIndex = 0
        Me.Administradora.Text = "Administradora"
        '
        'admin
        '
        Me.admin.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.admin.Border.Class = "TextBoxBorder"
        Me.admin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.admin.ButtonCustom.Tooltip = ""
        Me.admin.ButtonCustom2.Tooltip = ""
        Me.admin.DisabledBackColor = System.Drawing.Color.White
        Me.admin.ForeColor = System.Drawing.Color.Black
        Me.admin.Location = New System.Drawing.Point(119, 23)
        Me.admin.Name = "admin"
        Me.admin.PreventEnterBeep = True
        Me.admin.Size = New System.Drawing.Size(268, 22)
        Me.admin.TabIndex = 2
        '
        'msj1
        '
        '
        '
        '
        Me.msj1.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.msj1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.msj1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msj1.Location = New System.Drawing.Point(3, 3)
        Me.msj1.Name = "msj1"
        Me.msj1.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\la" & _
    "ng2058\f0\fs20 Mensaje de aviso\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.msj1.Size = New System.Drawing.Size(647, 260)
        Me.msj1.TabIndex = 8
        Me.msj1.Text = "Mensaje de aviso"
        '
        'msj2
        '
        '
        '
        '
        Me.msj2.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.msj2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.msj2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msj2.Location = New System.Drawing.Point(3, 3)
        Me.msj2.Name = "msj2"
        Me.msj2.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\la" & _
    "ng2058\f0\fs20 Mensaje de cobro formal\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.msj2.Size = New System.Drawing.Size(647, 260)
        Me.msj2.TabIndex = 9
        Me.msj2.Text = "Mensaje de cobro formal"
        '
        'Impreso
        '
        Me.Impreso.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Impreso.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Impreso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impreso.Location = New System.Drawing.Point(521, 362)
        Me.Impreso.Name = "Impreso"
        Me.Impreso.Size = New System.Drawing.Size(149, 39)
        Me.Impreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Impreso.TabIndex = 10
        Me.Impreso.Text = "OK"
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.Location = New System.Drawing.Point(20, 62)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(653, 293)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 11
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.msj1)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(653, 266)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Advertencia"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.msj2)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(653, 266)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Cobro Formal"
        '
        'frmCobrosMsjCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 413)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.Impreso)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.Administradora)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCobrosMsjCorreo"
        Me.Text = "Notas de Cobros via Correo"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Administradora As DevComponents.DotNetBar.LabelX
    Friend WithEvents admin As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents msj1 As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents msj2 As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents Impreso As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
End Class
