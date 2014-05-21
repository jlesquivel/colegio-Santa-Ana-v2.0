Imports System.Data.SqlClient
Imports TD.SandBar
Imports TD.SandDock
Imports System.ComponentModel
Imports System.IO
Imports System.Security.Principal


Public Class frmPrincipal
    Inherits System.Windows.Forms.Form

    Public AppImp As Printing.PrinterSettings
    Public empresa As String
    Public vusuario As String
    Public vpass As String
    Friend WithEvents MenuButtonItem6 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem10 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem21 As TD.SandBar.MenuButtonItem
    Dim oVentana As New Ventanas

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        Application.EnableVisualStyles()
        Application.DoEvents()

        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents MenuBar1 As TD.SandBar.MenuBar
    Friend WithEvents MenuBarItem1 As TD.SandBar.MenuBarItem
    Friend WithEvents MenuBarItem2 As TD.SandBar.MenuBarItem
    Friend WithEvents MenuBarItem3 As TD.SandBar.MenuBarItem
    Friend WithEvents MenuBarItem4 As TD.SandBar.MenuBarItem
    Friend WithEvents ToolBar1 As TD.SandBar.ToolBar
    Friend WithEvents DropDownMenuItem1 As TD.SandBar.DropDownMenuItem
    Friend WithEvents MenuButtonItem1 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem2 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem3 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem7 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem8 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem11 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem13 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem14 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem16 As TD.SandBar.MenuButtonItem
    Friend WithEvents Buscar1 As colegio.buscar
    Friend WithEvents MenuButtonItem4 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem9 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem12 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem15 As TD.SandBar.MenuButtonItem
    Friend WithEvents DropDownMenuItem4 As TD.SandBar.DropDownMenuItem
    Friend WithEvents MenuButtonItem17 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem18 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem19 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem20 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem23 As TD.SandBar.MenuButtonItem
    Friend WithEvents XpLetterBox1 As SteepValley.Windows.Forms.ThemedControls.XPLetterBox
    Friend WithEvents ContainerBar1 As TD.SandBar.ContainerBar
    Friend WithEvents ContainerBarClientPanel1 As TD.SandBar.ContainerBarClientPanel
    Friend WithEvents MenuButtonItem28 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem29 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem30 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem31 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem32 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem33 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem34 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem35 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem36 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem37 As TD.SandBar.MenuButtonItem
    Friend WithEvents MenuButtonItem38 As TD.SandBar.MenuButtonItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents usuario As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ButtonItem1 As TD.SandBar.ButtonItem
    Friend WithEvents SandDockManager1 As TD.SandDock.SandDockManager
    Friend WithEvents DockContainer1 As TD.SandDock.DockContainer
    Friend WithEvents DockableWindow1 As TD.SandDock.DockableWindow
    Friend WithEvents Buscar2 As colegio.buscar
    Friend WithEvents MenuButtonItem5 As TD.SandBar.MenuButtonItem
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.SandBarManager1 = New TD.SandBar.SandBarManager(Me.components)
        Me.leftSandBarDock = New TD.SandBar.ToolBarContainer
        Me.rightSandBarDock = New TD.SandBar.ToolBarContainer
        Me.bottomSandBarDock = New TD.SandBar.ToolBarContainer
        Me.topSandBarDock = New TD.SandBar.ToolBarContainer
        Me.MenuBar1 = New TD.SandBar.MenuBar
        Me.MenuBarItem1 = New TD.SandBar.MenuBarItem
        Me.MenuButtonItem38 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem10 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem16 = New TD.SandBar.MenuButtonItem
        Me.MenuBarItem2 = New TD.SandBar.MenuBarItem
        Me.MenuBarItem3 = New TD.SandBar.MenuBarItem
        Me.MenuButtonItem28 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem32 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem33 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem34 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem35 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem36 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem37 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem29 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem30 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem31 = New TD.SandBar.MenuButtonItem
        Me.MenuBarItem4 = New TD.SandBar.MenuBarItem
        Me.MenuButtonItem4 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem9 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem12 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem15 = New TD.SandBar.MenuButtonItem
        Me.ToolBar1 = New TD.SandBar.ToolBar
        Me.DropDownMenuItem1 = New TD.SandBar.DropDownMenuItem
        Me.MenuButtonItem1 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem2 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem3 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem20 = New TD.SandBar.MenuButtonItem
        Me.DropDownMenuItem4 = New TD.SandBar.DropDownMenuItem
        Me.MenuButtonItem21 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem23 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem5 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem17 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem6 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem18 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem19 = New TD.SandBar.MenuButtonItem
        Me.ButtonItem1 = New TD.SandBar.ButtonItem
        Me.MenuButtonItem11 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem13 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem14 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem7 = New TD.SandBar.MenuButtonItem
        Me.MenuButtonItem8 = New TD.SandBar.MenuButtonItem
        Me.XpLetterBox1 = New SteepValley.Windows.Forms.ThemedControls.XPLetterBox
        Me.ContainerBar1 = New TD.SandBar.ContainerBar
        Me.ContainerBarClientPanel1 = New TD.SandBar.ContainerBarClientPanel
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.usuario = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.SandDockManager1 = New TD.SandDock.SandDockManager
        Me.DockContainer1 = New TD.SandDock.DockContainer
        Me.DockableWindow1 = New TD.SandDock.DockableWindow
        Me.Buscar2 = New colegio.buscar
        Me.Buscar1 = New colegio.buscar
        Me.topSandBarDock.SuspendLayout()
        Me.ContainerBar1.SuspendLayout()
        CType(Me.usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockContainer1.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SandBarManager1
        '
        Me.SandBarManager1.OwnerForm = Me
        '
        'leftSandBarDock
        '
        Me.leftSandBarDock.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftSandBarDock.Guid = New System.Guid("c3120f92-16b1-479c-9a98-df32af20a29e")
        Me.leftSandBarDock.Location = New System.Drawing.Point(0, 57)
        Me.leftSandBarDock.Manager = Me.SandBarManager1
        Me.leftSandBarDock.Name = "leftSandBarDock"
        Me.leftSandBarDock.Size = New System.Drawing.Size(0, 625)
        Me.leftSandBarDock.TabIndex = 1
        '
        'rightSandBarDock
        '
        Me.rightSandBarDock.Dock = System.Windows.Forms.DockStyle.Right
        Me.rightSandBarDock.Guid = New System.Guid("08fb9186-4e2d-4d6a-b25b-e64bc8342323")
        Me.rightSandBarDock.Location = New System.Drawing.Point(1016, 57)
        Me.rightSandBarDock.Manager = Me.SandBarManager1
        Me.rightSandBarDock.Name = "rightSandBarDock"
        Me.rightSandBarDock.Size = New System.Drawing.Size(0, 625)
        Me.rightSandBarDock.TabIndex = 2
        '
        'bottomSandBarDock
        '
        Me.bottomSandBarDock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomSandBarDock.Guid = New System.Guid("afb4ba69-9fef-4256-8308-f301a0c3c18c")
        Me.bottomSandBarDock.Location = New System.Drawing.Point(0, 682)
        Me.bottomSandBarDock.Manager = Me.SandBarManager1
        Me.bottomSandBarDock.Name = "bottomSandBarDock"
        Me.bottomSandBarDock.Size = New System.Drawing.Size(1016, 0)
        Me.bottomSandBarDock.TabIndex = 3
        '
        'topSandBarDock
        '
        Me.topSandBarDock.Controls.Add(Me.MenuBar1)
        Me.topSandBarDock.Controls.Add(Me.ToolBar1)
        Me.topSandBarDock.Dock = System.Windows.Forms.DockStyle.Top
        Me.topSandBarDock.Guid = New System.Guid("6a9d0706-146b-4c0c-bd10-a7c3ae59703d")
        Me.topSandBarDock.Location = New System.Drawing.Point(0, 0)
        Me.topSandBarDock.Manager = Me.SandBarManager1
        Me.topSandBarDock.Name = "topSandBarDock"
        Me.topSandBarDock.Size = New System.Drawing.Size(1016, 57)
        Me.topSandBarDock.TabIndex = 4
        '
        'MenuBar1
        '
        Me.MenuBar1.AllowMerge = True
        Me.MenuBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuBar1.Guid = New System.Guid("aab7bbbc-1350-4ec7-84f0-26286a4b9cde")
        Me.MenuBar1.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuBarItem1, Me.MenuBarItem2, Me.MenuBarItem3, Me.MenuBarItem4})
        Me.MenuBar1.Location = New System.Drawing.Point(2, 0)
        Me.MenuBar1.Name = "MenuBar1"
        Me.MenuBar1.OwnerForm = Me
        Me.MenuBar1.Size = New System.Drawing.Size(1014, 23)
        Me.MenuBar1.TabIndex = 0
        Me.MenuBar1.Text = "MenuBar1"
        '
        'MenuBarItem1
        '
        Me.MenuBarItem1.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem38, Me.MenuButtonItem10, Me.MenuButtonItem16})
        Me.MenuBarItem1.Text = "&Archivo"
        '
        'MenuButtonItem38
        '
        Me.MenuButtonItem38.Icon = CType(resources.GetObject("MenuButtonItem38.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem38.Text = "Impresora"
        '
        'MenuButtonItem10
        '
        Me.MenuButtonItem10.Text = "Configuración"
        '
        'MenuButtonItem16
        '
        Me.MenuButtonItem16.BeginGroup = True
        Me.MenuButtonItem16.Icon = CType(resources.GetObject("MenuButtonItem16.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem16.Text = "Salir"
        '
        'MenuBarItem2
        '
        Me.MenuBarItem2.Text = "&Editar"
        '
        'MenuBarItem3
        '
        Me.MenuBarItem3.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem28, Me.MenuButtonItem29, Me.MenuButtonItem30, Me.MenuButtonItem31})
        Me.MenuBarItem3.Text = "&Ver"
        '
        'MenuButtonItem28
        '
        Me.MenuButtonItem28.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem32, Me.MenuButtonItem33, Me.MenuButtonItem36, Me.MenuButtonItem37})
        Me.MenuButtonItem28.Text = "Matricula"
        '
        'MenuButtonItem32
        '
        Me.MenuButtonItem32.Text = "Estudiantes"
        '
        'MenuButtonItem33
        '
        Me.MenuButtonItem33.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem34, Me.MenuButtonItem35})
        Me.MenuButtonItem33.Text = "Matricula"
        '
        'MenuButtonItem34
        '
        Me.MenuButtonItem34.Text = "Nuevos"
        '
        'MenuButtonItem35
        '
        Me.MenuButtonItem35.Text = "Regulares"
        '
        'MenuButtonItem36
        '
        Me.MenuButtonItem36.Text = "Listas de Clase"
        '
        'MenuButtonItem37
        '
        Me.MenuButtonItem37.Text = "Niveles"
        '
        'MenuButtonItem29
        '
        Me.MenuButtonItem29.Text = "Cobros"
        '
        'MenuButtonItem30
        '
        Me.MenuButtonItem30.Text = "Notas"
        '
        'MenuButtonItem31
        '
        Me.MenuButtonItem31.Text = "Personal"
        '
        'MenuBarItem4
        '
        Me.MenuBarItem4.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem4, Me.MenuButtonItem9, Me.MenuButtonItem12, Me.MenuButtonItem15})
        Me.MenuBarItem4.MdiWindowList = True
        Me.MenuBarItem4.Text = "&Ventana"
        '
        'MenuButtonItem4
        '
        Me.MenuButtonItem4.Icon = CType(resources.GetObject("MenuButtonItem4.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem4.Text = "Cascada"
        '
        'MenuButtonItem9
        '
        Me.MenuButtonItem9.Icon = CType(resources.GetObject("MenuButtonItem9.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem9.Text = "Mosaico Horizontal"
        '
        'MenuButtonItem12
        '
        Me.MenuButtonItem12.Icon = CType(resources.GetObject("MenuButtonItem12.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem12.Text = "Mosaico Vertical"
        '
        'MenuButtonItem15
        '
        Me.MenuButtonItem15.Icon = CType(resources.GetObject("MenuButtonItem15.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem15.Text = "Organizar Iconos"
        '
        'ToolBar1
        '
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolBar1.DockLine = 1
        Me.ToolBar1.Guid = New System.Guid("d81d8b51-abbe-490e-9f59-57feae538d89")
        Me.ToolBar1.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.DropDownMenuItem1, Me.DropDownMenuItem4, Me.ButtonItem1})
        Me.ToolBar1.Location = New System.Drawing.Point(2, 23)
        Me.ToolBar1.MenuAnimation = TD.SandBar.TopLevelMenuItemBase.MenuAnimation.None
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(244, 34)
        Me.ToolBar1.TabIndex = 1
        Me.ToolBar1.Text = "Barra Opciones"
        '
        'DropDownMenuItem1
        '
        Me.DropDownMenuItem1.Icon = CType(resources.GetObject("DropDownMenuItem1.Icon"), System.Drawing.Icon)
        Me.DropDownMenuItem1.IconSize = New System.Drawing.Size(24, 24)
        Me.DropDownMenuItem1.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem1, Me.MenuButtonItem2, Me.MenuButtonItem3, Me.MenuButtonItem20})
        Me.DropDownMenuItem1.Text = "Matricula"
        Me.DropDownMenuItem1.ToolTipText = "Matricula"
        '
        'MenuButtonItem1
        '
        Me.MenuButtonItem1.Icon = CType(resources.GetObject("MenuButtonItem1.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem1.Text = "Estudiantes"
        '
        'MenuButtonItem2
        '
        Me.MenuButtonItem2.Icon = CType(resources.GetObject("MenuButtonItem2.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem2.Text = "Matricula"
        '
        'MenuButtonItem3
        '
        Me.MenuButtonItem3.Icon = CType(resources.GetObject("MenuButtonItem3.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem3.Text = "Lista de Clase"
        '
        'MenuButtonItem20
        '
        Me.MenuButtonItem20.Text = "Niveles"
        '
        'DropDownMenuItem4
        '
        Me.DropDownMenuItem4.Icon = CType(resources.GetObject("DropDownMenuItem4.Icon"), System.Drawing.Icon)
        Me.DropDownMenuItem4.IconSize = New System.Drawing.Size(24, 24)
        Me.DropDownMenuItem4.Items.AddRange(New TD.SandBar.ToolbarItemBase() {Me.MenuButtonItem21, Me.MenuButtonItem23, Me.MenuButtonItem5, Me.MenuButtonItem17, Me.MenuButtonItem6, Me.MenuButtonItem18, Me.MenuButtonItem19})
        Me.DropDownMenuItem4.Text = "Cobro"
        '
        'MenuButtonItem21
        '
        Me.MenuButtonItem21.Text = "Convenios"
        '
        'MenuButtonItem23
        '
        Me.MenuButtonItem23.Icon = CType(resources.GetObject("MenuButtonItem23.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem23.Text = "Cancelar Cobro"
        '
        'MenuButtonItem5
        '
        Me.MenuButtonItem5.Text = "Cobro por Adelantado"
        '
        'MenuButtonItem17
        '
        Me.MenuButtonItem17.BeginGroup = True
        Me.MenuButtonItem17.Icon = CType(resources.GetObject("MenuButtonItem17.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem17.Text = "Generar Cobros"
        '
        'MenuButtonItem6
        '
        Me.MenuButtonItem6.Text = "Generar Cobro Matricula"
        '
        'MenuButtonItem18
        '
        Me.MenuButtonItem18.Text = "Estados de Cuenta"
        '
        'MenuButtonItem19
        '
        Me.MenuButtonItem19.BeginGroup = True
        Me.MenuButtonItem19.Text = "Tabla de Cuota"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Icon = CType(resources.GetObject("ButtonItem1.Icon"), System.Drawing.Icon)
        Me.ButtonItem1.IconSize = New System.Drawing.Size(24, 24)
        Me.ButtonItem1.Text = "Notas"
        '
        'MenuButtonItem11
        '
        Me.MenuButtonItem11.Text = "Informe"
        '
        'MenuButtonItem13
        '
        Me.MenuButtonItem13.Icon = CType(resources.GetObject("MenuButtonItem13.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem13.Text = "Traslados"
        '
        'MenuButtonItem14
        '
        Me.MenuButtonItem14.Icon = CType(resources.GetObject("MenuButtonItem14.Icon"), System.Drawing.Icon)
        Me.MenuButtonItem14.Text = "Constancias"
        '
        'MenuButtonItem8
        '
        Me.MenuButtonItem8.Text = "Deducciones"
        '
        'XpLetterBox1
        '
        Me.XpLetterBox1.BackColor = System.Drawing.Color.Transparent
        Me.XpLetterBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpLetterBox1.Location = New System.Drawing.Point(0, 0)
        Me.XpLetterBox1.Name = "XpLetterBox1"
        Me.XpLetterBox1.Padding = New System.Windows.Forms.Padding(0, 48, 0, 48)
        Me.XpLetterBox1.Size = New System.Drawing.Size(436, 478)
        Me.XpLetterBox1.TabIndex = 0
        Me.XpLetterBox1.ThemeFormat.BottomBodyColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.XpLetterBox1.ThemeFormat.FooterColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.XpLetterBox1.ThemeFormat.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.XpLetterBox1.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.XpLetterBox1.ThemeFormat.HeaderTextFont = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XpLetterBox1.ThemeFormat.TopBodyColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(210, Byte), Integer))
        '
        'ContainerBar1
        '
        Me.ContainerBar1.Controls.Add(Me.ContainerBarClientPanel1)
        Me.ContainerBar1.DockLine = 2
        Me.ContainerBar1.Flow = TD.SandBar.ToolBarLayout.Horizontal
        Me.ContainerBar1.Guid = New System.Guid("5ba24204-2465-4b76-ace4-864a51201dc0")
        Me.ContainerBar1.Location = New System.Drawing.Point(2, 58)
        Me.ContainerBar1.Name = "ContainerBar1"
        Me.ContainerBar1.SelectedClientPanel = Me.ContainerBarClientPanel1
        Me.ContainerBar1.Size = New System.Drawing.Size(778, 284)
        Me.ContainerBar1.TabIndex = 2
        Me.ContainerBar1.Text = "ContainerBar1"
        '
        'ContainerBarClientPanel1
        '
        Me.ContainerBarClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ContainerBarClientPanel1.Name = "ContainerBarClientPanel1"
        Me.ContainerBarClientPanel1.Size = New System.Drawing.Size(0, 0)
        Me.ContainerBarClientPanel1.TabIndex = 0
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 682)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.usuario, Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1016, 24)
        Me.StatusBar1.TabIndex = 11
        Me.StatusBar1.Text = "StatusBar1"
        '
        'usuario
        '
        Me.usuario.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.usuario.Icon = CType(resources.GetObject("usuario.Icon"), System.Drawing.Icon)
        Me.usuario.Name = "usuario"
        Me.usuario.Width = 349
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "fecha"
        Me.StatusBarPanel1.Width = 349
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Icon = CType(resources.GetObject("StatusBarPanel2.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 300
        '
        'SandDockManager1
        '
        Me.SandDockManager1.DockSystemContainer = Me
        Me.SandDockManager1.OwnerForm = Me
        Me.SandDockManager1.Renderer = New TD.SandDock.Rendering.Office2003Renderer
        '
        'DockContainer1
        '
        Me.DockContainer1.Controls.Add(Me.DockableWindow1)
        Me.DockContainer1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockContainer1.LayoutSystem = New TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, New TD.SandDock.LayoutSystemBase() {CType(New TD.SandDock.ControlLayoutSystem(412, 625, New TD.SandDock.DockControl() {CType(Me.DockableWindow1, TD.SandDock.DockControl)}, Me.DockableWindow1), TD.SandDock.LayoutSystemBase)})
        Me.DockContainer1.Location = New System.Drawing.Point(600, 57)
        Me.DockContainer1.Manager = Me.SandDockManager1
        Me.DockContainer1.Name = "DockContainer1"
        Me.DockContainer1.Size = New System.Drawing.Size(416, 625)
        Me.DockContainer1.TabIndex = 13
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.Buscar2)
        Me.DockableWindow1.Guid = New System.Guid("3cbc0c6d-0ea0-4dbe-8bf2-30d943e0856e")
        Me.DockableWindow1.Location = New System.Drawing.Point(4, 25)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Size = New System.Drawing.Size(412, 577)
        Me.DockableWindow1.TabIndex = 0
        Me.DockableWindow1.Text = "Estudiantes"
        '
        'Buscar2
        '
        Me.Buscar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Buscar2.Location = New System.Drawing.Point(0, 0)
        Me.Buscar2.Name = "Buscar2"
        Me.Buscar2.Size = New System.Drawing.Size(412, 577)
        Me.Buscar2.TabIndex = 0
        '
        'Buscar1
        '
        Me.Buscar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Buscar1.Location = New System.Drawing.Point(1, 1)
        Me.Buscar1.Name = "Buscar1"
        Me.Buscar1.Size = New System.Drawing.Size(434, 476)
        Me.Buscar1.TabIndex = 0
        '
        'frmPrincipal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1016, 706)
        Me.Controls.Add(Me.DockContainer1)
        Me.Controls.Add(Me.leftSandBarDock)
        Me.Controls.Add(Me.rightSandBarDock)
        Me.Controls.Add(Me.bottomSandBarDock)
        Me.Controls.Add(Me.topSandBarDock)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximumSize = New System.Drawing.Size(1600, 1200)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.topSandBarDock.ResumeLayout(False)
        Me.ContainerBar1.ResumeLayout(False)
        CType(Me.usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockContainer1.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Código generado por el Diseñador de Windows Forms "
    <Description("Seleccione el formato del control"), Category("Format")> _
    Public Property impresora() As Printing.PrinterSettings
        Get
            Return AppImp
        End Get
        Set(ByVal Value As Printing.PrinterSettings)
            AppImp = Value
        End Set
    End Property

    <Description("Seleccione el formato del control"), Category("Format")> _
Public Property organizacion() As String
        Get
            Return empresa
        End Get
        Set(ByVal Value As String)
            empresa = Value
        End Set
    End Property
#End Region

    Private Sub frmPrincipal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmLogin.Close()
    End Sub


    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        empresa = My.Settings.institucion
        Me.Text = empresa
        oVentana.cambia_fondoMDI(Me)

        Me.DockableWindow1.Collapsed = True
        Me.StatusBar1.Panels(0).Text = WindowsIdentity.GetCurrent.Name
        Me.StatusBar1.Panels(1).Text = Format(Now.Date, "D")
        Me.StatusBar1.Panels(2).Text = ""


        Me.AppImp = New Printing.PrinterSettings
        Dim sqlcon As New conexionSQL

        Me.DockableWindow1.Collapsed = True
        Me.StatusBar1.Panels(0).Text = WindowsIdentity.GetCurrent.Name
        Me.StatusBar1.Panels(1).Text = Format(Now.Date, "D")
        Me.StatusBar1.Panels(2).Text = sqlcon.servidor


        If Not sqlcon.conexionOK Then
            MessageBox.Show("No se pudo conectar al servido SQL, Intente luego", "SQL Error!", _
             MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        SandBarLanguage.AddRemoveButtonsText = "Agregar o quitar botones"
        SandDockLanguage.AutoHideText = "Auto ocultar"
        SandDockLanguage.CloseText = "cerrar"

        Me.DropDownMenuItem4.Visible = sqlcon.verifica_seguridad("colegio", "bncr")
        MenuButtonItem2.Enabled = sqlcon.verifica_seguridad("colegio", "cuotas")
    End Sub
    Private Sub MenuButtonItem1_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem1.Activate
        oVentana.cargarVentana(New frmEstudiantes, Me)
    End Sub

    Private Sub MenuButtonItem16_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem16.Activate
        Application.Exit()
    End Sub
    Private Sub MenuButtonItem4_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem4.Activate
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MenuButtonItem9_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem9.Activate
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub MenuButtonItem12_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem12.Activate
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MenuButtonItem15_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem15.Activate
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub MenuButtonItem3_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem3.Activate
        oVentana.cargarVentana(New frmListaClase, Me)
    End Sub
    Private Sub MenuButtonItem20_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem20.Activate
        oVentana.cargarVentana(New frmNiveles, Me)
    End Sub
    Private Sub MenuButtonItem19_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem19.Activate
        oVentana.cargarVentana(New frmCuotas, Me)
    End Sub
    Private Sub MenuButtonItem18_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem18.Activate
        oVentana.cargarVentana(New frmCobros, Me)
    End Sub
    Private Sub MenuButtonItem23_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem23.Activate
        oVentana.cargarVentana(New frmCancelaCobros, Me)
    End Sub
    Private Sub MenuButtonItem24_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVentana.cargarVentana(New frmMaterias, Me)
    End Sub
    Private Sub MenuButtonItem38_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem38.Activate
        PrintDialog1.Document = New Printing.PrintDocument
        Dim result As DialogResult = PrintDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            AppImp = PrintDialog1.PrinterSettings
        End If
    End Sub
    Private Sub MenuButtonItem2_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem2.Activate
        oVentana.cargarVentana(New frmMatriculaV, Me)
    End Sub
    Private Sub MenuButtonItem5_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVentana.cargarVentana(New frmNomina, Me)
    End Sub
    Private Sub DropDownMenuItem2_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVentana.cargarVentana(New frmNomina, Me)
    End Sub
    Private Sub MenuButtonItem21_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVentana.cargarVentana(New frmAusencias, Me)
    End Sub
    Private Sub MenuButtonItem17_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem17.Activate
        oVentana.cargarVentana(New frmGenCobro, Me)
    End Sub
    Private Sub MenuButtonItem25_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVentana.cargarVentana(New frmRegistraNotas, Me)
    End Sub
    Private Sub ButtonItem2_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVentana.cargarVentana(New frmNomina, Me)
    End Sub
    Private Sub ButtonItem1_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Activate
        oVentana.cargarVentana(New frmRegistraNotas, Me)
    End Sub
    Private Sub MenuButtonItem5_Activate_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem5.Activate
        oVentana.cargarVentana(New frmCobroAdelantado, Me)
    End Sub
    Private Sub MenuButtonItem6_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem6.Activate
        oVentana.cargarVentana(New frmGenCobroMatricula, Me)
    End Sub
    Private Sub MenuButtonItem10_Activate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem10.Activate
        oVentana.cargarVentana(New frmConfiguracion, Me)
    End Sub

    Private Sub MenuButtonItem21_Activate_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButtonItem21.Activate
        oVentana.cargarVentana(New frmConvenios, Me)
    End Sub
End Class
