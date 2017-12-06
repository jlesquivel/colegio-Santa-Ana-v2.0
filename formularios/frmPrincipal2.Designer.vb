Imports System.ComponentModel
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal2

    <Description("Seleccione el formato del control"), Category("Format")>
    Public Property impresora() As Printing.PrinterSettings
        Get
            Return AppImp
        End Get
        Set(ByVal Value As Printing.PrinterSettings)
            AppImp = Value
        End Set
    End Property

    <Description("Seleccione el formato del control"), Category("Format")>
    Public Property organizacion() As String
        Get
            Return institucion
        End Get
        Set(ByVal Value As String)
            institucion = Value
        End Set
    End Property


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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal2))
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem17 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem18 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem5 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem39 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem40 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem41 = New DevComponents.DotNetBar.ButtonItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar10 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem33 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar5 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem35 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem37 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem31 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem32 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem30 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer5 = New DevComponents.DotNetBar.ItemContainer()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem19 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem20 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem21 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar6 = New DevComponents.DotNetBar.RibbonBar()
        Me.ServCobros = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar8 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem29 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem42 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem28 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar7 = New DevComponents.DotNetBar.RibbonBar()
        Me.MicroChartItem1 = New DevComponents.DotNetBar.MicroChartItem()
        Me.ButtonItem38 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem25 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem26 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem43 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem44 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem22 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem23 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem34 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem24 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem27 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar9 = New DevComponents.DotNetBar.RibbonBar()
        Me.btCtlPagos = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.ApplicationButton1 = New DevComponents.DotNetBar.ApplicationButton()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.labelItem8 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonMatricula = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonCobros = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonAsistAdm = New DevComponents.DotNetBar.RibbonTabItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.SuperTabControl1.ControlBox.Visible = False
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.ItemPadding.Left = 6
        Me.SuperTabControl1.ItemPadding.Right = 4
        Me.SuperTabControl1.ItemPadding.Top = 4
        Me.SuperTabControl1.Location = New System.Drawing.Point(1, 1)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = False
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SuperTabControl1.SelectedTabIndex = 6
        Me.SuperTabControl1.Size = New System.Drawing.Size(1575, 996)
        Me.SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabHorizontalSpacing = 16
        Me.SuperTabControl1.TabIndex = 1
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem4, Me.ButtonItem16, Me.ButtonItem17, Me.ButtonItem18})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.TabVerticalSpacing = 8
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTabControlPanel1.Controls.Add(Me.LabelX2)
        Me.SuperTabControlPanel1.Controls.Add(Me.LabelX1)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(236, 0)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1339, 996)
        Me.SuperTabControlPanel1.TabIndex = 0
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(37, 32)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(46, 15)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Versión"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(87, 32)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX1.Size = New System.Drawing.Size(74, 15)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "LabelX1"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Información"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.BackgroundImage = CType(resources.GetObject("SuperTabControlPanel4.BackgroundImage"), System.Drawing.Image)
        Me.SuperTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(99, 20)
        Me.SuperTabControlPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(650, 471)
        Me.SuperTabControlPanel4.TabIndex = 4
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem4
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.KeyTips = "H"
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "Ayuda"
        '
        'ButtonItem16
        '
        Me.ButtonItem16.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem16.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem16.Image = CType(resources.GetObject("ButtonItem16.Image"), System.Drawing.Image)
        Me.ButtonItem16.ImagePaddingHorizontal = 18
        Me.ButtonItem16.ImagePaddingVertical = 10
        Me.ButtonItem16.KeyTips = "C"
        Me.ButtonItem16.Name = "ButtonItem16"
        Me.ButtonItem16.Stretch = True
        Me.ButtonItem16.Text = "Impresora"
        '
        'ButtonItem17
        '
        Me.ButtonItem17.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem17.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem17.Image = CType(resources.GetObject("ButtonItem17.Image"), System.Drawing.Image)
        Me.ButtonItem17.ImagePaddingHorizontal = 18
        Me.ButtonItem17.ImagePaddingVertical = 10
        Me.ButtonItem17.KeyTips = "T"
        Me.ButtonItem17.Name = "ButtonItem17"
        Me.ButtonItem17.Stretch = True
        Me.ButtonItem17.Text = "Opciones"
        '
        'ButtonItem18
        '
        Me.ButtonItem18.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem18.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem18.Image = CType(resources.GetObject("ButtonItem18.Image"), System.Drawing.Image)
        Me.ButtonItem18.ImagePaddingHorizontal = 18
        Me.ButtonItem18.ImagePaddingVertical = 10
        Me.ButtonItem18.KeyTips = "X"
        Me.ButtonItem18.Name = "ButtonItem18"
        Me.ButtonItem18.Stretch = True
        Me.ButtonItem18.Text = "Salir"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "ButtonItem1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer)))
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.LabelItem4, Me.LabelItem2, Me.LabelItem5, Me.LabelItem3})
        Me.Bar1.Location = New System.Drawing.Point(5, 736)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(2)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1286, 22)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 3
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Image = CType(resources.GetObject("LabelItem1.Image"), System.Drawing.Image)
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "LabelItem1"
        '
        'LabelItem4
        '
        Me.LabelItem4.Name = "LabelItem4"
        Me.LabelItem4.PaddingLeft = 100
        Me.LabelItem4.Stretch = True
        '
        'LabelItem2
        '
        Me.LabelItem2.Image = CType(resources.GetObject("LabelItem2.Image"), System.Drawing.Image)
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "LabelItem2"
        '
        'LabelItem5
        '
        Me.LabelItem5.Name = "LabelItem5"
        Me.LabelItem5.Stretch = True
        '
        'LabelItem3
        '
        Me.LabelItem3.Image = CType(resources.GetObject("LabelItem3.Image"), System.Drawing.Image)
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "LabelItem3"
        '
        'ButtonItem39
        '
        Me.ButtonItem39.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem39.Icon = CType(resources.GetObject("ButtonItem39.Icon"), System.Drawing.Icon)
        Me.ButtonItem39.Name = "ButtonItem39"
        Me.ButtonItem39.Text = "Notas Anual"
        '
        'ButtonItem40
        '
        Me.ButtonItem40.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem40.Icon = CType(resources.GetObject("ButtonItem40.Icon"), System.Drawing.Icon)
        Me.ButtonItem40.Name = "ButtonItem40"
        Me.ButtonItem40.Text = "Convocatoria 1"
        '
        'ButtonItem41
        '
        Me.ButtonItem41.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem41.Icon = CType(resources.GetObject("ButtonItem41.Icon"), System.Drawing.Icon)
        Me.ButtonItem41.Name = "ButtonItem41"
        Me.ButtonItem41.Text = "Convocatoria 2"
        '
        'BackgroundWorker1
        '
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AutoScroll = True
        Me.RibbonControl1.BackColor = System.Drawing.Color.GhostWhite
        Me.RibbonControl1.BackgroundImage = CType(resources.GetObject("RibbonControl1.BackgroundImage"), System.Drawing.Image)
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.ForeColor = System.Drawing.Color.Black
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ApplicationButton1, Me.RibbonMatricula, Me.RibbonCobros, Me.RibbonAsistAdm})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.QatCustomizeItem1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1286, 156)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.AutoSize = True
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar10)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar5)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar4)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 56)
        Me.RibbonPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.RibbonPanel1.Size = New System.Drawing.Size(1286, 100)
        '
        '
        '
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        '
        'RibbonBar10
        '
        Me.RibbonBar10.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar10.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar10.ContainerControlProcessDialogKey = True
        Me.RibbonBar10.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar10.DragDropSupport = True
        Me.RibbonBar10.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem33})
        Me.RibbonBar10.Location = New System.Drawing.Point(621, 0)
        Me.RibbonBar10.Name = "RibbonBar10"
        Me.RibbonBar10.Size = New System.Drawing.Size(100, 98)
        Me.RibbonBar10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar10.TabIndex = 2
        Me.RibbonBar10.Text = "Parámetros"
        '
        '
        '
        Me.RibbonBar10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar10.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem33
        '
        Me.ButtonItem33.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem33.Name = "ButtonItem33"
        Me.ButtonItem33.SubItemsExpandWidth = 14
        Me.ButtonItem33.Symbol = ""
        Me.ButtonItem33.SymbolSize = 16.0!
        Me.ButtonItem33.Text = "Trimestres"
        '
        'RibbonBar5
        '
        Me.RibbonBar5.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar5.ContainerControlProcessDialogKey = True
        Me.RibbonBar5.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar5.DragDropSupport = True
        Me.RibbonBar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem35, Me.ButtonItem37})
        Me.RibbonBar5.Location = New System.Drawing.Point(489, 0)
        Me.RibbonBar5.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar5.Name = "RibbonBar5"
        Me.RibbonBar5.Size = New System.Drawing.Size(132, 98)
        Me.RibbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar5.TabIndex = 1
        Me.RibbonBar5.Text = "Reportes"
        '
        '
        '
        Me.RibbonBar5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem35
        '
        Me.ButtonItem35.Image = CType(resources.GetObject("ButtonItem35.Image"), System.Drawing.Image)
        Me.ButtonItem35.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem35.Name = "ButtonItem35"
        Me.ButtonItem35.SubItemsExpandWidth = 14
        Me.ButtonItem35.Symbol = ""
        Me.ButtonItem35.Text = "Notas"
        '
        'ButtonItem37
        '
        Me.ButtonItem37.Image = CType(resources.GetObject("ButtonItem37.Image"), System.Drawing.Image)
        Me.ButtonItem37.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem37.Name = "ButtonItem37"
        Me.ButtonItem37.SubItemsExpandWidth = 14
        Me.ButtonItem37.Symbol = ""
        Me.ButtonItem37.Text = "Constancias y Certificados"
        '
        'RibbonBar4
        '
        Me.RibbonBar4.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar4.ContainerControlProcessDialogKey = True
        Me.RibbonBar4.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar4.DragDropSupport = True
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem31, Me.ButtonItem32, Me.ButtonItem30, Me.ItemContainer5})
        Me.RibbonBar4.Location = New System.Drawing.Point(243, 0)
        Me.RibbonBar4.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(246, 98)
        Me.RibbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar4.TabIndex = 0
        Me.RibbonBar4.Text = "Tareas"
        '
        '
        '
        Me.RibbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem31
        '
        Me.ButtonItem31.Image = CType(resources.GetObject("ButtonItem31.Image"), System.Drawing.Image)
        Me.ButtonItem31.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem31.Name = "ButtonItem31"
        Me.ButtonItem31.SubItemsExpandWidth = 14
        Me.ButtonItem31.Symbol = "57408"
        Me.ButtonItem31.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem31.Text = "Registra Notas"
        '
        'ButtonItem32
        '
        Me.ButtonItem32.Image = CType(resources.GetObject("ButtonItem32.Image"), System.Drawing.Image)
        Me.ButtonItem32.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem32.Name = "ButtonItem32"
        Me.ButtonItem32.SubItemsExpandWidth = 14
        Me.ButtonItem32.Symbol = "58405"
        Me.ButtonItem32.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem32.Text = "Ausencias"
        '
        'ButtonItem30
        '
        Me.ButtonItem30.Image = CType(resources.GetObject("ButtonItem30.Image"), System.Drawing.Image)
        Me.ButtonItem30.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem30.Name = "ButtonItem30"
        Me.ButtonItem30.SubItemsExpandWidth = 14
        Me.ButtonItem30.Symbol = ""
        Me.ButtonItem30.Text = "Notas Excel"
        '
        'ItemContainer5
        '
        '
        '
        '
        Me.ItemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer5.Name = "ItemContainer5"
        Me.ItemContainer5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem39, Me.ButtonItem40, Me.ButtonItem41})
        '
        '
        '
        Me.ItemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.DragDropSupport = True
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem19, Me.ButtonItem20, Me.ButtonItem14, Me.ButtonItem21})
        Me.RibbonBar1.Location = New System.Drawing.Point(2, 0)
        Me.RibbonBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(241, 98)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 0
        Me.RibbonBar1.Text = "Pasos para matricular"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem19
        '
        Me.ButtonItem19.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem19.Image = CType(resources.GetObject("ButtonItem19.Image"), System.Drawing.Image)
        Me.ButtonItem19.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem19.Name = "ButtonItem19"
        Me.ButtonItem19.SubItemsExpandWidth = 14
        Me.ButtonItem19.Symbol = ""
        Me.ButtonItem19.SymbolSize = 32.0!
        Me.ButtonItem19.Text = "Estudiantes"
        '
        'ButtonItem20
        '
        Me.ButtonItem20.Image = CType(resources.GetObject("ButtonItem20.Image"), System.Drawing.Image)
        Me.ButtonItem20.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem20.Name = "ButtonItem20"
        Me.ButtonItem20.SubItemsExpandWidth = 14
        Me.ButtonItem20.Symbol = ""
        Me.ButtonItem20.SymbolSize = 32.0!
        Me.ButtonItem20.Text = "Matricula"
        '
        'ButtonItem14
        '
        Me.ButtonItem14.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem14.Image = CType(resources.GetObject("ButtonItem14.Image"), System.Drawing.Image)
        Me.ButtonItem14.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.SubItemsExpandWidth = 14
        Me.ButtonItem14.Symbol = "57675"
        Me.ButtonItem14.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem14.SymbolSize = 32.0!
        Me.ButtonItem14.Text = "Matricula Denegada"
        '
        'ButtonItem21
        '
        Me.ButtonItem21.Image = CType(resources.GetObject("ButtonItem21.Image"), System.Drawing.Image)
        Me.ButtonItem21.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem21.Name = "ButtonItem21"
        Me.ButtonItem21.SubItemsExpandWidth = 14
        Me.ButtonItem21.Symbol = ""
        Me.ButtonItem21.SymbolSize = 32.0!
        Me.ButtonItem21.Text = "Lista de Clases"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar6)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar8)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar7)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar3)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 56)
        Me.RibbonPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.RibbonPanel2.Size = New System.Drawing.Size(1012, 100)
        '
        '
        '
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = False
        '
        'RibbonBar6
        '
        Me.RibbonBar6.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar6.ContainerControlProcessDialogKey = True
        Me.RibbonBar6.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar6.DragDropSupport = True
        Me.RibbonBar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ServCobros})
        Me.RibbonBar6.Location = New System.Drawing.Point(593, 0)
        Me.RibbonBar6.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar6.Name = "RibbonBar6"
        Me.RibbonBar6.Size = New System.Drawing.Size(76, 98)
        Me.RibbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar6.TabIndex = 4
        Me.RibbonBar6.Text = "Indicadores"
        '
        '
        '
        Me.RibbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ServCobros
        '
        Me.ServCobros.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ServCobros.Name = "ServCobros"
        Me.ServCobros.SubItemsExpandWidth = 14
        Me.ServCobros.Symbol = "59447"
        Me.ServCobros.SymbolColor = System.Drawing.Color.Gainsboro
        Me.ServCobros.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ServCobros.SymbolSize = 24.0!
        Me.ServCobros.Text = "Servidor <br/> Cobros"
        '
        'RibbonBar8
        '
        Me.RibbonBar8.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar8.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar8.ContainerControlProcessDialogKey = True
        Me.RibbonBar8.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar8.DragDropSupport = True
        Me.RibbonBar8.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem29, Me.ButtonItem42, Me.ButtonItem28})
        Me.RibbonBar8.Location = New System.Drawing.Point(474, 0)
        Me.RibbonBar8.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar8.Name = "RibbonBar8"
        Me.RibbonBar8.Size = New System.Drawing.Size(119, 98)
        Me.RibbonBar8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar8.TabIndex = 3
        Me.RibbonBar8.Text = "Reportes"
        '
        '
        '
        Me.RibbonBar8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar8.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem29
        '
        Me.ButtonItem29.Image = Global.colegio.My.Resources.Resources.paper_roll
        Me.ButtonItem29.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem29.Name = "ButtonItem29"
        Me.ButtonItem29.SubItemsExpandWidth = 14
        Me.ButtonItem29.Text = "Recibos"
        '
        'ButtonItem42
        '
        Me.ButtonItem42.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem42.Name = "ButtonItem42"
        Me.ButtonItem42.SubItemsExpandWidth = 14
        Me.ButtonItem42.Symbol = ""
        Me.ButtonItem42.SymbolSize = 24.0!
        Me.ButtonItem42.Text = "Estados Cuenta"
        '
        'ButtonItem28
        '
        Me.ButtonItem28.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem28.Name = "ButtonItem28"
        Me.ButtonItem28.SubItemsExpandWidth = 14
        Me.ButtonItem28.Symbol = ""
        Me.ButtonItem28.SymbolSize = 24.0!
        Me.ButtonItem28.Text = "Const Pago"
        '
        'RibbonBar7
        '
        Me.RibbonBar7.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar7.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar7.ContainerControlProcessDialogKey = True
        Me.RibbonBar7.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar7.DragDropSupport = True
        Me.RibbonBar7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MicroChartItem1, Me.ButtonItem38})
        Me.RibbonBar7.Location = New System.Drawing.Point(377, 0)
        Me.RibbonBar7.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Size = New System.Drawing.Size(97, 98)
        Me.RibbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar7.TabIndex = 2
        Me.RibbonBar7.Text = "controles"
        '
        '
        '
        Me.RibbonBar7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar7.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MicroChartItem1
        '
        Me.MicroChartItem1.ChartHeight = 48
        Me.MicroChartItem1.ChartType = DevComponents.DotNetBar.eMicroChartType.Pie
        Me.MicroChartItem1.Name = "MicroChartItem1"
        Me.MicroChartItem1.Text = "cobros"
        Me.MicroChartItem1.TextPosition = DevComponents.DotNetBar.eMicroChartTextPosition.Bottom
        '
        'ButtonItem38
        '
        Me.ButtonItem38.Image = Global.colegio.My.Resources.Resources.mail
        Me.ButtonItem38.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem38.Name = "ButtonItem38"
        Me.ButtonItem38.SubItemsExpandWidth = 14
        Me.ButtonItem38.Symbol = ""
        Me.ButtonItem38.SymbolSize = 24.0!
        Me.ButtonItem38.Text = "Cobros x Correo"
        '
        'RibbonBar3
        '
        Me.RibbonBar3.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar3.ContainerControlProcessDialogKey = True
        Me.RibbonBar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar3.DragDropSupport = True
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem25, Me.ButtonItem26, Me.ButtonItem43, Me.ButtonItem44})
        Me.RibbonBar3.Location = New System.Drawing.Point(205, 0)
        Me.RibbonBar3.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(172, 98)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 1
        Me.RibbonBar3.Text = "Tablas"
        '
        '
        '
        Me.RibbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem25
        '
        Me.ButtonItem25.Image = CType(resources.GetObject("ButtonItem25.Image"), System.Drawing.Image)
        Me.ButtonItem25.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem25.Name = "ButtonItem25"
        Me.ButtonItem25.SubItemsExpandWidth = 14
        Me.ButtonItem25.Symbol = ""
        Me.ButtonItem25.SymbolSize = 24.0!
        Me.ButtonItem25.Text = "Convenios"
        '
        'ButtonItem26
        '
        Me.ButtonItem26.Image = CType(resources.GetObject("ButtonItem26.Image"), System.Drawing.Image)
        Me.ButtonItem26.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem26.Name = "ButtonItem26"
        Me.ButtonItem26.SubItemsExpandWidth = 14
        Me.ButtonItem26.Symbol = ""
        Me.ButtonItem26.SymbolSize = 24.0!
        Me.ButtonItem26.Text = "Tabla cuotas"
        '
        'ButtonItem43
        '
        Me.ButtonItem43.Image = CType(resources.GetObject("ButtonItem43.Image"), System.Drawing.Image)
        Me.ButtonItem43.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem43.Name = "ButtonItem43"
        Me.ButtonItem43.SubItemsExpandWidth = 14
        Me.ButtonItem43.Symbol = ""
        Me.ButtonItem43.Text = "Materias"
        '
        'ButtonItem44
        '
        Me.ButtonItem44.Image = CType(resources.GetObject("ButtonItem44.Image"), System.Drawing.Image)
        Me.ButtonItem44.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem44.Name = "ButtonItem44"
        Me.ButtonItem44.SubItemsExpandWidth = 14
        Me.ButtonItem44.Symbol = ""
        Me.ButtonItem44.Text = "Niveles"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.DragDropSupport = True
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem22, Me.ButtonItem23, Me.ButtonItem34, Me.ButtonItem24, Me.ButtonItem27})
        Me.RibbonBar2.Location = New System.Drawing.Point(2, 0)
        Me.RibbonBar2.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(203, 98)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 0
        Me.RibbonBar2.Text = "Cobros"
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem22
        '
        Me.ButtonItem22.Image = CType(resources.GetObject("ButtonItem22.Image"), System.Drawing.Image)
        Me.ButtonItem22.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem22.Name = "ButtonItem22"
        Me.ButtonItem22.SubItemsExpandWidth = 14
        Me.ButtonItem22.Symbol = ""
        Me.ButtonItem22.SymbolSize = 24.0!
        Me.ButtonItem22.Text = "Genera Cobros"
        '
        'ButtonItem23
        '
        Me.ButtonItem23.Image = CType(resources.GetObject("ButtonItem23.Image"), System.Drawing.Image)
        Me.ButtonItem23.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem23.Name = "ButtonItem23"
        Me.ButtonItem23.SubItemsExpandWidth = 14
        Me.ButtonItem23.Symbol = ""
        Me.ButtonItem23.SymbolSize = 24.0!
        Me.ButtonItem23.Text = "Genera Cobros Matricula"
        '
        'ButtonItem34
        '
        Me.ButtonItem34.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem34.Name = "ButtonItem34"
        Me.ButtonItem34.SubItemsExpandWidth = 14
        Me.ButtonItem34.Symbol = "59403"
        Me.ButtonItem34.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem34.SymbolSize = 26.0!
        Me.ButtonItem34.Text = "CISA"
        '
        'ButtonItem24
        '
        Me.ButtonItem24.Image = CType(resources.GetObject("ButtonItem24.Image"), System.Drawing.Image)
        Me.ButtonItem24.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem24.Name = "ButtonItem24"
        Me.ButtonItem24.SubItemsExpandWidth = 14
        Me.ButtonItem24.Symbol = ""
        Me.ButtonItem24.SymbolSize = 24.0!
        Me.ButtonItem24.Text = "Cobros Cancela"
        '
        'ButtonItem27
        '
        Me.ButtonItem27.Image = CType(resources.GetObject("ButtonItem27.Image"), System.Drawing.Image)
        Me.ButtonItem27.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem27.Name = "ButtonItem27"
        Me.ButtonItem27.SubItemsExpandWidth = 14
        Me.ButtonItem27.Symbol = ""
        Me.ButtonItem27.SymbolSize = 24.0!
        Me.ButtonItem27.Text = "Cobros adelantado"
        Me.ButtonItem27.Visible = False
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar9)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 46)
        Me.RibbonPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.RibbonPanel3.Size = New System.Drawing.Size(1252, 110)
        '
        '
        '
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        Me.RibbonPanel3.Visible = False
        '
        'RibbonBar9
        '
        Me.RibbonBar9.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar9.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar9.ContainerControlProcessDialogKey = True
        Me.RibbonBar9.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar9.DragDropSupport = True
        Me.RibbonBar9.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btCtlPagos, Me.ButtonItem15})
        Me.RibbonBar9.Location = New System.Drawing.Point(2, 0)
        Me.RibbonBar9.Margin = New System.Windows.Forms.Padding(2)
        Me.RibbonBar9.Name = "RibbonBar9"
        Me.RibbonBar9.Size = New System.Drawing.Size(207, 108)
        Me.RibbonBar9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar9.TabIndex = 0
        Me.RibbonBar9.Text = "Controles"
        '
        '
        '
        Me.RibbonBar9.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar9.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btCtlPagos
        '
        Me.btCtlPagos.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btCtlPagos.Name = "btCtlPagos"
        Me.btCtlPagos.SubItemsExpandWidth = 14
        Me.btCtlPagos.Symbol = ""
        Me.btCtlPagos.SymbolSize = 32.0!
        Me.btCtlPagos.Text = "Pagos"
        '
        'ButtonItem15
        '
        Me.ButtonItem15.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.SubItemsExpandWidth = 14
        Me.ButtonItem15.Symbol = ""
        Me.ButtonItem15.SymbolSize = 32.0!
        Me.ButtonItem15.Text = "Arch Banco"
        '
        'ApplicationButton1
        '
        Me.ApplicationButton1.AutoExpandOnClick = True
        Me.ApplicationButton1.BackstageTab = Me.SuperTabControl1
        Me.ApplicationButton1.CanCustomize = False
        Me.ApplicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.ApplicationButton1.Image = CType(resources.GetObject("ApplicationButton1.Image"), System.Drawing.Image)
        Me.ApplicationButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ApplicationButton1.ImagePaddingHorizontal = 0
        Me.ApplicationButton1.ImagePaddingVertical = 1
        Me.ApplicationButton1.Name = "ApplicationButton1"
        Me.ApplicationButton1.ShowSubItems = False
        Me.ApplicationButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.ApplicationButton1.Text = "&Ξ"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2, Me.ItemContainer4})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.ItemSpacing = 0
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3, Me.GalleryContainer1})
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5, Me.ButtonItem6, Me.ButtonItem7})
        '
        '
        '
        Me.ItemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 24
        Me.ButtonItem2.Text = "&New"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 24
        Me.ButtonItem3.Text = "&Open..."
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 24
        Me.ButtonItem4.Text = "&Save..."
        '
        'ButtonItem5
        '
        Me.ButtonItem5.BeginGroup = True
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItemsExpandWidth = 24
        Me.ButtonItem5.Text = "S&hare..."
        '
        'ButtonItem6
        '
        Me.ButtonItem6.BeginGroup = True
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.Image = CType(resources.GetObject("ButtonItem6.Image"), System.Drawing.Image)
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.SubItemsExpandWidth = 24
        Me.ButtonItem6.Text = "&Print..."
        '
        'ButtonItem7
        '
        Me.ButtonItem7.BeginGroup = True
        Me.ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem7.Image = CType(resources.GetObject("ButtonItem7.Image"), System.Drawing.Image)
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.SubItemsExpandWidth = 24
        Me.ButtonItem7.Text = "&Close"
        '
        'GalleryContainer1
        '
        '
        '
        '
        Me.GalleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer"
        Me.GalleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer1.EnableGalleryPopup = False
        Me.GalleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(180, 240)
        Me.GalleryContainer1.MultiLine = False
        Me.GalleryContainer1.Name = "GalleryContainer1"
        Me.GalleryContainer1.PopupUsesStandardScrollbars = False
        Me.GalleryContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem8, Me.ButtonItem8, Me.ButtonItem9, Me.ButtonItem10, Me.ButtonItem11})
        '
        '
        '
        Me.GalleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'labelItem8
        '
        Me.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.labelItem8.CanCustomize = False
        Me.labelItem8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelItem8.Name = "labelItem8"
        Me.labelItem8.PaddingBottom = 2
        Me.labelItem8.PaddingTop = 2
        Me.labelItem8.Stretch = True
        Me.labelItem8.Text = "Recent Documents"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.BeginGroup = True
        Me.ButtonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem8.Image = CType(resources.GetObject("ButtonItem8.Image"), System.Drawing.Image)
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.SubItemsExpandWidth = 24
        Me.ButtonItem8.Text = "&1. Short News 5-7.rtf"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "&2. Prospect Email.rtf"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Text = "&3. Customer Email.rtf"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "&4. example.rtf"
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem12, Me.ButtonItem13})
        '
        '
        '
        Me.ItemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem12
        '
        Me.ButtonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem12.Image = CType(resources.GetObject("ButtonItem12.Image"), System.Drawing.Image)
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.SubItemsExpandWidth = 24
        Me.ButtonItem12.Text = "Opt&ions"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem13.Image = CType(resources.GetObject("ButtonItem13.Image"), System.Drawing.Image)
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.SubItemsExpandWidth = 24
        Me.ButtonItem13.Text = "E&xit"
        '
        'RibbonMatricula
        '
        Me.RibbonMatricula.Checked = True
        Me.RibbonMatricula.Name = "RibbonMatricula"
        Me.RibbonMatricula.Panel = Me.RibbonPanel1
        Me.RibbonMatricula.Text = "Secretaría"
        '
        'RibbonCobros
        '
        Me.RibbonCobros.Name = "RibbonCobros"
        Me.RibbonCobros.Panel = Me.RibbonPanel2
        Me.RibbonCobros.Text = "Administración"
        '
        'RibbonAsistAdm
        '
        Me.RibbonAsistAdm.Name = "RibbonAsistAdm"
        Me.RibbonAsistAdm.Panel = Me.RibbonPanel3
        Me.RibbonAsistAdm.Text = "Asistente Administativa"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'frmPrincipal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1296, 760)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPrincipal2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colegio"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        Me.RibbonPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ApplicationButton1 As DevComponents.DotNetBar.ApplicationButton
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents labelItem8 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonMatricula As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonCobros As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ButtonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem18 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem22 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem23 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem24 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem25 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem26 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem27 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar5 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem35 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem37 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem30 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem31 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem32 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents RibbonBar7 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents MicroChartItem1 As DevComponents.DotNetBar.MicroChartItem
    Friend WithEvents ButtonItem38 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ItemContainer5 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem39 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem40 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem41 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar8 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem29 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem42 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem28 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem43 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem44 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem5 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents RibbonBar6 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ServCobros As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem34 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BackgroundWorker1 As BackgroundWorker
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar9 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btCtlPagos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonAsistAdm As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents RibbonBar10 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem33 As DevComponents.DotNetBar.ButtonItem
End Class
