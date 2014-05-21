Public Class frmPlanilla
    Inherits System.Windows.Forms.Form
    Dim id_dpto As Integer
    Dim id_planilla As Integer
    Dim id_pago As Integer
    Dim conn As New conexionSQL("planilla")

    Dim _deducciones As Integer
    Dim _ingresos As Integer
    Dim filas As Integer = 0

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
    End Sub


    Public Sub New(ByVal pid_dpto As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        id_dpto = pid_dpto
    End Sub
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents SandBarManager1 As TD.SandBar.SandBarManager
    Friend WithEvents leftSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents rightSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents bottomSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents topSandBarDock As TD.SandBar.ToolBarContainer
    Friend WithEvents ToolBar1 As TD.SandBar.ToolBar
    Friend WithEvents ToolBar2 As TD.SandBar.ToolBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Ds2planilla1 As colegio.ds2planilla
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents TextboxFormat1 As colegio.TextboxFormat
    Friend WithEvents TextboxFormat2 As colegio.TextboxFormat
    Friend WithEvents TextboxFormat3 As colegio.TextboxFormat
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Planillas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PlanillaPagosDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataViewIngresos As System.Data.DataView
    Friend WithEvents DataViewDeducciones As System.Data.DataView
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextboxFormat4 As colegio.TextboxFormat
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextboxFormat5 As colegio.TextboxFormat
    Friend WithEvents TextboxFormat6 As colegio.TextboxFormat
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataViewPlanillas As System.Data.DataView
    Friend WithEvents ButtonItem3 As TD.SandBar.ButtonItem
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DropDownMenuItem1 As TD.SandBar.DropDownMenuItem
    Friend WithEvents MenuButtonItem1 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem2 As TD.SandBar.MenuButtonItem
    Friend WithEvents Ge As TD.SandBar.MenuButtonItem
    Friend WithEvents DVPlanillaPagosSelect As System.Data.DataView
    Friend WithEvents PlanillaResumenMonto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SandDockManager1 As TD.SandDock.SandDockManager
    Friend WithEvents DockableWindow1 As TD.SandDock.DockableWindow
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents DockableWindow2 As TD.SandDock.DockableWindow
    Friend WithEvents TextboxFormat7 As colegio.TextboxFormat
    Friend WithEvents TextboxFormat8 As colegio.TextboxFormat
    Friend WithEvents TextboxFormat9 As colegio.TextboxFormat
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid5 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DockContainer2 As TD.SandDock.DockContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPlanilla))
        Me.SandBarManager1 = New TD.SandBar.SandBarManager
        Me.leftSandBarDock = New TD.SandBar.ToolBarContainer
        Me.rightSandBarDock = New TD.SandBar.ToolBarContainer
        Me.bottomSandBarDock = New TD.SandBar.ToolBarContainer
        Me.topSandBarDock = New TD.SandBar.ToolBarContainer
        Me.ToolBar1 = New TD.SandBar.ToolBar
        Me.ButtonItem3 = New TD.SandBar.ButtonItem
        Me.DropDownMenuItem1 = New TD.SandBar.DropDownMenuItem
        Me.MenuButtonItem1 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem2 = New TD.SandBar.MenuButtonItem
        Me.Ge = New TD.SandBar.MenuButtonItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ToolBar2 = New TD.SandBar.ToolBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextboxFormat6 = New colegio.TextboxFormat
        Me.TextboxFormat5 = New colegio.TextboxFormat
        Me.TextboxFormat3 = New colegio.TextboxFormat
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextboxFormat1 = New colegio.TextboxFormat
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DataViewIngresos = New System.Data.DataView
        Me.Ds2planilla1 = New colegio.ds2planilla
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TextboxFormat2 = New colegio.TextboxFormat
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataViewDeducciones = New System.Data.DataView
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextboxFormat4 = New colegio.TextboxFormat
        Me.DataView1 = New System.Data.DataView
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DVPlanillaPagosSelect = New System.Data.DataView
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.DataViewPlanillas = New System.Data.DataView
        Me.Planillas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.PlanillaPagosDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.PlanillaResumenMonto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SandDockManager1 = New TD.SandDock.SandDockManager
        Me.DockableWindow1 = New TD.SandDock.DockableWindow
        Me.TextboxFormat7 = New colegio.TextboxFormat
        Me.TextboxFormat8 = New colegio.TextboxFormat
        Me.TextboxFormat9 = New colegio.TextboxFormat
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.DataGrid4 = New System.Windows.Forms.DataGrid
        Me.DockableWindow2 = New TD.SandDock.DockableWindow
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DataGrid5 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DockContainer2 = New TD.SandDock.DockContainer
        Me.topSandBarDock.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataViewIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataViewDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVPlanillaPagosSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataViewPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockableWindow1.SuspendLayout()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockableWindow2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SandBarManager1
        '
        Me.SandBarManager1.OwnerForm = Me
        '
        'leftSandBarDock
        '
        Me.leftSandBarDock.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftSandBarDock.Guid = New System.Guid("daf86d3a-870a-4331-a421-8f3287facc81")
        Me.leftSandBarDock.Location = New System.Drawing.Point(0, 26)
        Me.leftSandBarDock.Manager = Me.SandBarManager1
        Me.leftSandBarDock.Name = "leftSandBarDock"
        Me.leftSandBarDock.Size = New System.Drawing.Size(0, 518)
        Me.leftSandBarDock.TabIndex = 0
        '
        'rightSandBarDock
        '
        Me.rightSandBarDock.Dock = System.Windows.Forms.DockStyle.Right
        Me.rightSandBarDock.Guid = New System.Guid("74077432-b3bd-466e-b61c-498a357fe485")
        Me.rightSandBarDock.Location = New System.Drawing.Point(738, 26)
        Me.rightSandBarDock.Manager = Me.SandBarManager1
        Me.rightSandBarDock.Name = "rightSandBarDock"
        Me.rightSandBarDock.Size = New System.Drawing.Size(0, 518)
        Me.rightSandBarDock.TabIndex = 1
        '
        'bottomSandBarDock
        '
        Me.bottomSandBarDock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomSandBarDock.Guid = New System.Guid("af7b74e7-3bde-4529-9b6d-9abb29fe7dfe")
        Me.bottomSandBarDock.Location = New System.Drawing.Point(0, 544)
        Me.bottomSandBarDock.Manager = Me.SandBarManager1
        Me.bottomSandBarDock.Name = "bottomSandBarDock"
        Me.bottomSandBarDock.Size = New System.Drawing.Size(738, 0)
        Me.bottomSandBarDock.TabIndex = 2
        '
        'topSandBarDock
        '
        Me.topSandBarDock.Controls.Add(Me.ToolBar1)
        Me.topSandBarDock.Dock = System.Windows.Forms.DockStyle.Top
        Me.topSandBarDock.Guid = New System.Guid("7ab4e894-0d58-4337-bb93-9b93f786ae2f")
        Me.topSandBarDock.Location = New System.Drawing.Point(0, 0)
        Me.topSandBarDock.Manager = Me.SandBarManager1
        Me.topSandBarDock.Name = "topSandBarDock"
        Me.topSandBarDock.Size = New System.Drawing.Size(738, 26)
        Me.topSandBarDock.TabIndex = 3
        '
        'ToolBar1
        '
        Me.ToolBar1.DockLine = 1
        Me.ToolBar1.Guid = New System.Guid("24466f30-a0be-4e1d-b906-a1cb80ac5222")
        Me.ToolBar1.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.ButtonItem3, Me.DropDownMenuItem1})
        Me.ToolBar1.Location = New System.Drawing.Point(2, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(167, 26)
        Me.ToolBar1.TabIndex = 1
        Me.ToolBar1.Text = "ToolBar1"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Icon = CType(resources.GetObject("ButtonItem3.Icon"), System.Drawing.Icon)
        Me.ButtonItem3.Text = "Borra"
        Me.ButtonItem3.ToolTipText = "Borra la planilla"
        '
        'DropDownMenuItem1
        '
        Me.DropDownMenuItem1.Icon = CType(resources.GetObject("DropDownMenuItem1.Icon"), System.Drawing.Icon)
        Me.DropDownMenuItem1.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem1, Me.MenuButtonItem2, Me.Ge})
        Me.DropDownMenuItem1.Text = "Reportes"
        '
        'MenuButtonItem1
        '
        Me.MenuButtonItem1.Icon = CType(resources.GetObject("MenuButtonItem1.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem1.Text = "Resumen de Planilla"
        '
        'MenuButtonItem2
        '
        Me.MenuButtonItem2.Icon = CType(resources.GetObject("MenuButtonItem2.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem2.Text = "Colillas de pagos"
        '
        'Ge
        '
        Me.Ge.Icon = CType(resources.GetObject("Ge.Icon"), System.Drawing.Icon)
        Me.Ge.Text = "Archivo de pago"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(160, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generar"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(24, 32)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 0
        '
        'ToolBar2
        '
        Me.ToolBar2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar2.Guid = New System.Guid("31be68b7-bfdd-4e60-b66b-37b5c2b1f235")
        Me.ToolBar2.Location = New System.Drawing.Point(0, 544)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.Size = New System.Drawing.Size(738, 18)
        Me.ToolBar2.TabIndex = 4
        Me.ToolBar2.Text = "ToolBar2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(15, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 232)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextboxFormat6)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat5)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextboxFormat1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(488, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 216)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resumen Empleado"
        '
        'TextboxFormat6
        '
        Me.TextboxFormat6.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.TextboxFormat6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxFormat6.Formato = "C"
        Me.TextboxFormat6.Location = New System.Drawing.Point(104, 168)
        Me.TextboxFormat6.Name = "TextboxFormat6"
        Me.TextboxFormat6.TabIndex = 10
        Me.TextboxFormat6.Text = ""
        Me.TextboxFormat6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat5
        '
        Me.TextboxFormat5.Formato = "C"
        Me.TextboxFormat5.Location = New System.Drawing.Point(104, 144)
        Me.TextboxFormat5.Name = "TextboxFormat5"
        Me.TextboxFormat5.TabIndex = 9
        Me.TextboxFormat5.Text = ""
        Me.TextboxFormat5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat3
        '
        Me.TextboxFormat3.Formato = "C"
        Me.TextboxFormat3.Location = New System.Drawing.Point(104, 120)
        Me.TextboxFormat3.Name = "TextboxFormat3"
        Me.TextboxFormat3.TabIndex = 8
        Me.TextboxFormat3.Text = ""
        Me.TextboxFormat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Salario Neto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Deducciones"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Salario Bruto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(104, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = ""
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Categoria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor unid."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "(horas/dias/lecciones)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextboxFormat1
        '
        Me.TextboxFormat1.Formato = "C"
        Me.TextboxFormat1.Location = New System.Drawing.Point(104, 48)
        Me.TextboxFormat1.Name = "TextboxFormat1"
        Me.TextboxFormat1.ReadOnly = True
        Me.TextboxFormat1.TabIndex = 7
        Me.TextboxFormat1.Text = ""
        Me.TextboxFormat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DataGrid3)
        Me.GroupBox3.Controls.Add(Me.TextboxFormat2)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 216)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingresos"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(48, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sub total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid3
        '
        Me.DataGrid3.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGrid3.CaptionVisible = False
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.DataSource = Me.DataViewIngresos
        Me.DataGrid3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.RowHeaderWidth = 20
        Me.DataGrid3.Size = New System.Drawing.Size(226, 176)
        Me.DataGrid3.TabIndex = 9
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataViewIngresos
        '
        Me.DataViewIngresos.AllowDelete = False
        Me.DataViewIngresos.AllowNew = False
        Me.DataViewIngresos.RowFilter = "categoria = 'Ingreso'"
        Me.DataViewIngresos.Table = Me.Ds2planilla1.pagos_detalle
        '
        'Ds2planilla1
        '
        Me.Ds2planilla1.DataSetName = "ds2planilla"
        Me.Ds2planilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.DataGrid3
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "pagos_detalle"
        Me.DataGridTableStyle5.RowHeaderWidth = 20
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "nombre"
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 115
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn14.Format = "n"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "monto"
        Me.DataGridTextBoxColumn14.Width = 70
        '
        'TextboxFormat2
        '
        Me.TextboxFormat2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.TextboxFormat2.Formato = "C"
        Me.TextboxFormat2.Location = New System.Drawing.Point(112, 192)
        Me.TextboxFormat2.Name = "TextboxFormat2"
        Me.TextboxFormat2.TabIndex = 8
        Me.TextboxFormat2.Text = ""
        Me.TextboxFormat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextboxFormat4)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(248, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 216)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deducciones"
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.DataSource = Me.DataViewDeducciones
        Me.DataGrid2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.RowHeaderWidth = 20
        Me.DataGrid2.Size = New System.Drawing.Size(226, 176)
        Me.DataGrid2.TabIndex = 0
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataViewDeducciones
        '
        Me.DataViewDeducciones.AllowDelete = False
        Me.DataViewDeducciones.AllowNew = False
        Me.DataViewDeducciones.RowFilter = "categoria = 'Deducción'"
        Me.DataViewDeducciones.Sort = "nombre"
        Me.DataViewDeducciones.Table = Me.Ds2planilla1.pagos_detalle
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "pagos_detalle"
        Me.DataGridTableStyle4.RowHeaderWidth = 20
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "nombre"
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 115
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = "n"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "monto"
        Me.DataGridTextBoxColumn11.Width = 70
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(48, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sub total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextboxFormat4
        '
        Me.TextboxFormat4.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.TextboxFormat4.Formato = "C"
        Me.TextboxFormat4.Location = New System.Drawing.Point(112, 192)
        Me.TextboxFormat4.Name = "TextboxFormat4"
        Me.TextboxFormat4.TabIndex = 11
        Me.TextboxFormat4.Text = ""
        Me.TextboxFormat4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataView1
        '
        Me.DataView1.AllowNew = False
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DVPlanillaPagosSelect
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.Location = New System.Drawing.Point(24, 24)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 150
        Me.DataGrid1.RowHeaderWidth = 15
        Me.DataGrid1.Size = New System.Drawing.Size(448, 288)
        Me.DataGrid1.TabIndex = 6
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DVPlanillaPagosSelect
        '
        Me.DVPlanillaPagosSelect.AllowDelete = False
        Me.DVPlanillaPagosSelect.AllowEdit = False
        Me.DVPlanillaPagosSelect.AllowNew = False
        Me.DVPlanillaPagosSelect.Table = Me.Ds2planilla1.PlanillaPagoSelect
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "PlanillaPagoSelect"
        Me.DataGridTableStyle1.RowHeaderWidth = 15
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cédula"
        Me.DataGridTextBoxColumn1.MappingName = "cedula"
        Me.DataGridTextBoxColumn1.Width = 70
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Apellidos"
        Me.DataGridTextBoxColumn2.MappingName = "apellidos"
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn3.MappingName = "nombre"
        Me.DataGridTextBoxColumn3.Width = 145
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Categoria"
        Me.DataGridTextBoxColumn4.MappingName = "nombreCat"
        Me.DataGridTextBoxColumn4.Width = 55
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EG-PORTATIL"";packet size=4096;integrated security=SSPI;data sourc" & _
        "e=""(local)"";persist security info=False;initial catalog=planilla"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO vPagosxDpto(cedula, Expr1, apellidos, categoria, salario_base, cantid" & _
        "ad, anualidad, salario_bruto, Expr2, id_dpto, nombre) VALUES (@cedula, @Expr1, @" & _
        "apellidos, @categoria, @salario_base, @cantidad, @anualidad, @salario_bruto, @Ex" & _
        "pr2, @id_dpto, @nombre); SELECT cedula, Expr1, apellidos, categoria, salario_bas" & _
        "e, cantidad, anualidad, salario_bruto, Expr2, id_dpto, nombre FROM vPagosxDpto"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.VarChar, 20, "Expr1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 8, "salario_base"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 8, "anualidad"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salario_bruto", System.Data.SqlDbType.Decimal, 17, System.Data.ParameterDirection.Input, False, CType(38, Byte), CType(4, Byte), "salario_bruto", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.VarChar, 50, "Expr2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PlanillaPagoSelect", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato"), New System.Data.Common.DataColumnMapping("id_pagos", "id_pagos"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("id_cat", "id_cat"), New System.Data.Common.DataColumnMapping("nombreCat", "nombreCat"), New System.Data.Common.DataColumnMapping("salario_base", "salario_base"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("id_emp", "id_emp")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "[PlanillaPagoSelect]"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_planilla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""SERVIDOR-BD"";packet size=4096;integrated security=SSPI;data sourc" & _
        "e=""SERVIDOR-BD"";persist security info=False;initial catalog=planilla"
        '
        'DataViewPlanillas
        '
        Me.DataViewPlanillas.AllowDelete = False
        Me.DataViewPlanillas.AllowEdit = False
        Me.DataViewPlanillas.AllowNew = False
        Me.DataViewPlanillas.Table = Me.Ds2planilla1.planillas
        '
        'Planillas
        '
        Me.Planillas.DeleteCommand = Me.SqlDeleteCommand1
        Me.Planillas.InsertCommand = Me.SqlInsertCommand2
        Me.Planillas.SelectCommand = Me.SqlSelectCommand2
        Me.Planillas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "planillas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_planilla", "id_planilla"), New System.Data.Common.DataColumnMapping("fecha_ini", "fecha_ini"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("id_dpto", "id_dpto")})})
        Me.Planillas.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM planillas WHERE (id_planilla = @Original_id_planilla) AND (fecha_fin " & _
        "= @Original_fecha_fin) AND (fecha_ini = @Original_fecha_ini) AND (id_dpto = @Ori" & _
        "ginal_id_dpto)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_planilla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO planillas(fecha_ini, fecha_fin, id_dpto) VALUES (@fecha_ini, @fecha_f" & _
        "in, @id_dpto); SELECT id_planilla, fecha_ini, fecha_fin, id_dpto FROM planillas " & _
        "WHERE (id_planilla = @@IDENTITY) ORDER BY fecha_ini DESC"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 8, "fecha_ini"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 8, "fecha_fin"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_planilla, fecha_ini, fecha_fin, id_dpto FROM planillas WHERE (id_dpto =" & _
        " @id_dpto) ORDER BY fecha_ini DESC"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE planillas SET fecha_ini = @fecha_ini, fecha_fin = @fecha_fin, id_dpto = @i" & _
        "d_dpto WHERE (id_planilla = @Original_id_planilla) AND (fecha_fin = @Original_fe" & _
        "cha_fin) AND (fecha_ini = @Original_fecha_ini) AND (id_dpto = @Original_id_dpto)" & _
        "; SELECT id_planilla, fecha_ini, fecha_fin, id_dpto FROM planillas WHERE (id_pla" & _
        "nilla = @id_planilla) ORDER BY fecha_ini DESC"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 8, "fecha_ini"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 8, "fecha_fin"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_planilla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_planilla", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_planilla", System.Data.DataRowVersion.Current, Nothing))
        '
        'PlanillaPagosDetalle
        '
        Me.PlanillaPagosDetalle.SelectCommand = Me.SqlSelectCommand3
        Me.PlanillaPagosDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PlanillaPagosDetalleSelect", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("valor", "valor"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro")})})
        Me.PlanillaPagosDetalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "[PlanillaPagosDetalleSelect]"
        Me.SqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_pago", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "[PlanillaPagosDetalleUpdate]"
        Me.SqlUpdateCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_pago", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 4, "monto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing))
        '
        'PlanillaResumenMonto
        '
        Me.PlanillaResumenMonto.SelectCommand = Me.SqlSelectCommand4
        Me.PlanillaResumenMonto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PlanillaResumenMontos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("categoria", "categoria")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "[PlanillaResumenMontos]"
        Me.SqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_planilla", System.Data.SqlDbType.Int, 4))
        '
        'SandDockManager1
        '
        Me.SandDockManager1.DockSystemContainer = Me
        Me.SandDockManager1.OwnerForm = Me
        '
        'DockableWindow1
        '
        Me.DockableWindow1.BackColor = System.Drawing.Color.Gainsboro
        Me.DockableWindow1.Controls.Add(Me.TextboxFormat7)
        Me.DockableWindow1.Controls.Add(Me.TextboxFormat8)
        Me.DockableWindow1.Controls.Add(Me.TextboxFormat9)
        Me.DockableWindow1.Controls.Add(Me.Label9)
        Me.DockableWindow1.Controls.Add(Me.Label10)
        Me.DockableWindow1.Controls.Add(Me.Label11)
        Me.DockableWindow1.Controls.Add(Me.DataGrid4)
        Me.DockableWindow1.Guid = New System.Guid("8c7006ab-7dcb-4a31-9f19-88f9a2bc8259")
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 18)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Size = New System.Drawing.Size(250, 476)
        Me.DockableWindow1.TabIndex = 0
        Me.DockableWindow1.Text = "Historico Planillas"
        '
        'TextboxFormat7
        '
        Me.TextboxFormat7.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.TextboxFormat7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxFormat7.Formato = "C"
        Me.TextboxFormat7.Location = New System.Drawing.Point(120, 450)
        Me.TextboxFormat7.Name = "TextboxFormat7"
        Me.TextboxFormat7.TabIndex = 16
        Me.TextboxFormat7.Text = ""
        Me.TextboxFormat7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat8
        '
        Me.TextboxFormat8.Formato = "C"
        Me.TextboxFormat8.Location = New System.Drawing.Point(120, 429)
        Me.TextboxFormat8.Name = "TextboxFormat8"
        Me.TextboxFormat8.TabIndex = 15
        Me.TextboxFormat8.Text = ""
        Me.TextboxFormat8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextboxFormat9
        '
        Me.TextboxFormat9.Formato = "C"
        Me.TextboxFormat9.Location = New System.Drawing.Point(120, 408)
        Me.TextboxFormat9.Name = "TextboxFormat9"
        Me.TextboxFormat9.TabIndex = 14
        Me.TextboxFormat9.Text = ""
        Me.TextboxFormat9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(40, 453)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Salario Neto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(40, 429)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Deducciones"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(40, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Salario Bruto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid4
        '
        Me.DataGrid4.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGrid4.CaptionText = "Histórico de Planillas"
        Me.DataGrid4.CaptionVisible = False
        Me.DataGrid4.DataMember = ""
        Me.DataGrid4.DataSource = Me.DataViewPlanillas
        Me.DataGrid4.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid4.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.RowHeaderWidth = 20
        Me.DataGrid4.Size = New System.Drawing.Size(250, 384)
        Me.DataGrid4.TabIndex = 1
        '
        'DockableWindow2
        '
        Me.DockableWindow2.BackColor = System.Drawing.Color.Gainsboro
        Me.DockableWindow2.Controls.Add(Me.DateTimePicker1)
        Me.DockableWindow2.Controls.Add(Me.Button1)
        Me.DockableWindow2.Controls.Add(Me.DateTimePicker2)
        Me.DockableWindow2.Guid = New System.Guid("b873cce9-495a-48c2-a1d7-410741aea3b1")
        Me.DockableWindow2.Location = New System.Drawing.Point(0, 18)
        Me.DockableWindow2.Name = "DockableWindow2"
        Me.DockableWindow2.Size = New System.Drawing.Size(250, 476)
        Me.DockableWindow2.TabIndex = 1
        Me.DockableWindow2.Text = "Crear Planilla"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGrid5)
        Me.GroupBox4.Location = New System.Drawing.Point(472, 24)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 280)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Resumen Planilla"
        '
        'DataGrid5
        '
        Me.DataGrid5.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGrid5.DataMember = ""
        Me.DataGrid5.DataSource = Me.Ds2planilla1.PlanillaResumenMontos
        Me.DataGrid5.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid5.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid5.Name = "DataGrid5"
        Me.DataGrid5.ReadOnly = True
        Me.DataGrid5.RowHeaderWidth = 15
        Me.DataGrid5.Size = New System.Drawing.Size(258, 264)
        Me.DataGrid5.TabIndex = 0
        Me.DataGrid5.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid5
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "PlanillaResumenMontos"
        Me.DataGridTableStyle2.RowHeaderWidth = 15
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "nombre"
        Me.DataGridTextBoxColumn5.Width = 90
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "n"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "monto"
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "categoria"
        Me.DataGridTextBoxColumn7.Width = 60
        '
        'DockContainer2
        '
        Me.DockContainer2.Controls.Add(Me.DockableWindow1)
        Me.DockContainer2.Controls.Add(Me.DockableWindow2)
        Me.DockContainer2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockContainer2.LayoutSystem = New TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, New TD.SandDock.LayoutSystemBase() {New TD.SandDock.ControlLayoutSystem(250, 518, New TD.SandDock.DockControl() {Me.DockableWindow1, Me.DockableWindow2}, Me.DockableWindow1)})
        Me.DockContainer2.Location = New System.Drawing.Point(0, 26)
        Me.DockContainer2.Manager = Me.SandDockManager1
        Me.DockContainer2.Name = "DockContainer2"
        Me.DockContainer2.Size = New System.Drawing.Size(254, 518)
        Me.DockContainer2.TabIndex = 11
        '
        'frmPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(738, 562)
        Me.Controls.Add(Me.DockContainer2)
        Me.Controls.Add(Me.leftSandBarDock)
        Me.Controls.Add(Me.rightSandBarDock)
        Me.Controls.Add(Me.bottomSandBarDock)
        Me.Controls.Add(Me.topSandBarDock)
        Me.Controls.Add(Me.ToolBar2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPlanilla"
        Me.Text = "Planillas"
        Me.topSandBarDock.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataViewIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataViewDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVPlanillaPagosSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataViewPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockableWindow1.ResumeLayout(False)
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockableWindow2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub cargarPlanillas()
        ' carga la lista de planillas 
        Me.Ds2planilla1.Tables("planillas").Clear()
        Me.Planillas.SelectCommand.Parameters("@id_dpto").Value = id_dpto
        Me.Planillas.Fill(Me.Ds2planilla1, "planillas")
    End Sub

    Sub cargarPlanilla(ByVal pid_planilla As String)
        '
        'CARGAR LA PLANILLA ENVIADA COMO PARAMETRO
        Me.Ds2planilla1.Tables("PlanillaPagoSelect").Clear()
        id_planilla = pid_planilla
        Me.SqlDataAdapter1.SelectCommand.Parameters("@id_planilla").Value = id_planilla
        Me.SqlDataAdapter1.Fill(Me.Ds2planilla1, "PlanillaPagoSelect")
    End Sub

    Private Sub frmPlanilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarPlanillas()
        Me.Text = conn.llena("SELECT nombre FROM departamento WHERE id_dpto=" & id_dpto).Item(0)(0)
        Me.DockableWindow1.Collapsed = True
        Me.DockableWindow2.Collapsed = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'carga 
        Dim conn As New conexionSQL("planilla")
        Dim comando As String
        comando = "exec crea_pagos " & id_dpto & ", '" & Me.DateTimePicker1.Value.Date & "' , '" & Me.DateTimePicker2.Value.Date & "'"
        conn.ejecuta(comando)

        Me.cargarPlanillas()
        Me.cargarPlanilla(conn.llena("SELECT TOP 1 id_planilla FROM planillas ORDER BY id_planilla DESC ").Item(0)(0))
    End Sub

    Private Sub DataGrid4_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid4.MouseUp
        Dim pt As Point = New Point(e.X, e.Y)
        Dim hit As DataGrid.HitTestInfo = DataGrid4.HitTest(pt)

        If hit.Type = Windows.Forms.DataGrid.HitTestType.Cell Then
            DataGrid4.CurrentCell = New DataGridCell(hit.Row, hit.Column)
            DataGrid4.Select(hit.Row)
        End If

        '** carga el registro de la fila seleccionada
        Dim dt As DataView = DataGrid4.DataSource
        Dim dr As Object = dt.Table.Rows(DataGrid4.CurrentRowIndex).ItemArray
        id_planilla = dr(0)

        Me.cargarPlanilla(id_planilla)
        Me.DataGrid1.CaptionText = " Planilla : " & dr(1) & " - " & dr(2)
        Me.resumen_planilla(id_planilla)
    End Sub

    Private Sub DataGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseUp
        'guarda los cambios
        If filas > 0 Then
            Me.BindingContext(Me.Ds2planilla1).EndCurrentEdit()
            Me.PlanillaPagosDetalle.UpdateCommand.Parameters("@id_pago").Value = id_pago
            Me.PlanillaPagosDetalle.Update(Me.Ds2planilla1, "pagos_detalle")
        End If

        Dim pt As Point = New Point(e.X, e.Y)
        Dim hit As DataGrid.HitTestInfo = DataGrid1.HitTest(pt)

        If hit.Type = Windows.Forms.DataGrid.HitTestType.Cell Then
            DataGrid1.CurrentCell = New DataGridCell(hit.Row, hit.Column)
            DataGrid1.Select(hit.Row)
        End If

        ' Get the Currency Manager by using the BindingContext of the DataGrid
        Dim cm As CurrencyManager = CType(Me.BindingContext(DataGrid1.DataSource, DataGrid1.DataMember), CurrencyManager)

        ' Retrieve the default DataView of the DataGrid
        Dim dv As DataView = CType(cm.List, DataView)

        Dim dr As Object
        dr = dv.Item(cm.Position).Row.ItemArray

        id_pago = dr(1)
        Me.TextBox1.Text = dr(6)
        Me.TextboxFormat1.Text = dr(7)
        Me.TextBox3.Text = dr(8)

        ' cargas los otros pagos y dividirlos en los dataview
        Me.Ds2planilla1.Tables("pagos_detalle").Clear()
        Me.PlanillaPagosDetalle.SelectCommand.Parameters("@id_pago").Value = id_pago
        filas = Me.PlanillaPagosDetalle.Fill(Me.Ds2planilla1, "pagos_detalle")
        totaliza()
    End Sub

    Private Sub DataGrid2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.CurrentCellChanged
        totaliza()
    End Sub
    Private Sub DataGrid3_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid3.CurrentCellChanged
        totaliza()
    End Sub

    Private Sub totaliza()
        If filas > 0 Then

            Me.BindingContext(Me.Ds2planilla1).EndCurrentEdit()
            Me.PlanillaPagosDetalle.UpdateCommand.Parameters("@id_pago").Value = id_pago
            Me.PlanillaPagosDetalle.Update(Me.Ds2planilla1, "pagos_detalle")

            _ingresos = Me.Ds2planilla1.Tables("pagos_detalle").Compute("Sum(monto)", _
                    "categoria = 'Ingreso' and monto > 0")
            Me.TextboxFormat2.Text = Format(CStr(_ingresos), "Currency")
            Me.TextboxFormat3.Text = Format(CStr(_ingresos), "Currency")

            CalculaPorcentajeDeducciones(_ingresos)

            _deducciones = Me.Ds2planilla1.Tables("pagos_detalle").Compute("Sum(monto)", _
                    "categoria = 'Deducción' and monto > 0")
            Me.TextboxFormat4.Text = Format(CStr(_deducciones), "Currency")
            Me.TextboxFormat5.Text = Format(CStr(_deducciones), "Currency")

            'salario neto
            Me.TextboxFormat6.Text = Format(CStr(_ingresos - _deducciones), "Currency")
            resumen_planilla(id_planilla)
        Else
            Me.TextboxFormat2.Text = Format(CStr(0), "Currency")
            Me.TextboxFormat3.Text = Format(CStr(0), "Currency")

            Me.TextboxFormat4.Text = Format(CStr(0), "Currency")
            Me.TextboxFormat5.Text = Format(CStr(0), "Currency")

            Me.TextboxFormat6.Text = Format(CStr(0), "Currency")
        End If
    End Sub

    Private Sub CalculaPorcentajeDeducciones(ByVal pIngreso As Decimal)
        Dim result As ArrayList
        Dim id_contrato As Integer
        Dim formu, proce As String

        result = conn.llena("select id_contrato from pagos where id_pagos=" & id_pago)
        id_contrato = result(0)(0)

        For Each fila As DataRow In Me.Ds2planilla1.Tables("pagos_detalle").Rows
            formu = UCase(fila.Item("formula"))
            If InStr(formu, "SB") Or InStr(formu, "AN") Or InStr(formu, "CANT") Or InStr(formu, "TSB") Then
                proce = "exec formula_calcula2 " & id_contrato & "," & id_pago & "," & fila.Item("id_rubro")
                result = conn.llena(proce)
                fila.Item("monto") = result(0)(0)
            End If
        Next
        Me.DataGrid2.Refresh()
        Me.DataGrid3.Refresh()
    End Sub

    Private Sub resumen_planilla(ByVal pid_planilla As Integer)
        Dim res As Integer
        Dim Tingresos, TDeducciones As Decimal

        Me.Ds2planilla1.Tables("PlanillaResumenMontos").Clear()
        Me.PlanillaResumenMonto.SelectCommand.Parameters("@id_planilla").Value = pid_planilla
        res = Me.PlanillaResumenMonto.Fill(Me.Ds2planilla1, "PlanillaResumenMontos")


        Tingresos = Me.Ds2planilla1.Tables("PlanillaResumenMontos").Compute("Sum(monto)", _
                   "categoria = 'Ingreso' ")
        TDeducciones = Me.Ds2planilla1.Tables("PlanillaResumenMontos").Compute("Sum(monto)", _
                   "categoria = 'Deducción' ")

        Me.TextboxFormat9.Text = Tingresos
        Me.TextboxFormat8.Text = TDeducciones
        Me.TextboxFormat7.Text = Tingresos - TDeducciones
    End Sub

    Private Sub ButtonItem3_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Activate
        conn.ejecuta("delete from planillas where id_planilla =" & id_planilla)
        Me.cargarPlanillas()
        Me.cargarPlanilla(conn.llena("SELECT TOP 1 id_planilla FROM planillas ORDER BY id_planilla DESC ").Item(0)(0))
        Me.DataGrid4.Refresh()
    End Sub

    Private Sub MenuButtonItem1_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem1.Activate
        ' reporte de Planilla Resumido
        Dim rep As New Reportes
        Dim orptPlanilla As New rptPlanilla
        orptPlanilla.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
        orptPlanilla.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

        orptPlanilla.SetParameterValue("@planilla", id_planilla)
        rep.imprimir(orptPlanilla, False, Me.ParentForm)
    End Sub

    Private Sub MenuButtonItem2_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem2.Activate
        '  reporte de colillas de Pago
        Dim rep As New Reportes
        Dim orptPlanilla As New rptPlanilla
        orptPlanilla.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperLegal
        orptPlanilla.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.Landscape

        orptPlanilla.SetParameterValue("@planilla", id_planilla)
        rep.imprimir(orptPlanilla, False, Me.ParentForm)
    End Sub
End Class
