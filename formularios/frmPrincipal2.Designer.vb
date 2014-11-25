Imports System.ComponentModel
Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal2

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
            Return institucion
        End Get
        Set(ByVal Value As String)
            institucion = Value
        End Set
    End Property


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal2))
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem17 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem18 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar6 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem33 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem34 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar5 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem35 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem36 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem37 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar4 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem29 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem30 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem31 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem32 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem19 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem20 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem21 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar7 = New DevComponents.DotNetBar.RibbonBar()
        Me.MicroChartItem1 = New DevComponents.DotNetBar.MicroChartItem()
        Me.ButtonItem38 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar3 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem25 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem26 = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.ButtonItem22 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem23 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem24 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem27 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem28 = New DevComponents.DotNetBar.ButtonItem()
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
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.Black
        Me.SuperTabControl1.ItemPadding.Left = 6
        Me.SuperTabControl1.ItemPadding.Right = 4
        Me.SuperTabControl1.ItemPadding.Top = 4
        Me.SuperTabControl1.Location = New System.Drawing.Point(1, 1)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = False
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SuperTabControl1.SelectedTabIndex = 6
        Me.SuperTabControl1.Size = New System.Drawing.Size(1234, 709)
        Me.SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabHorizontalSpacing = 16
        Me.SuperTabControl1.TabIndex = 1
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem14, Me.ButtonItem15, Me.ButtonItem16, Me.SuperTabItem1, Me.SuperTabItem2, Me.SuperTabItem3, Me.SuperTabItem4, Me.ButtonItem17, Me.ButtonItem18})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.TabVerticalSpacing = 8
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.BackgroundImage = CType(resources.GetObject("SuperTabControlPanel1.BackgroundImage"), System.Drawing.Image)
        Me.SuperTabControlPanel1.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(236, 0)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(998, 709)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.KeyTips = "R"
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Recent"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.BackgroundImage = CType(resources.GetObject("SuperTabControlPanel2.BackgroundImage"), System.Drawing.Image)
        Me.SuperTabControlPanel2.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(236, 0)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(998, 709)
        Me.SuperTabControlPanel2.TabIndex = 2
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.KeyTips = "N"
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "New"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.BackgroundImage = CType(resources.GetObject("SuperTabControlPanel3.BackgroundImage"), System.Drawing.Image)
        Me.SuperTabControlPanel3.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(236, 0)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(998, 709)
        Me.SuperTabControlPanel3.TabIndex = 3
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.KeyTips = "P"
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Print"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.BackgroundImage = CType(resources.GetObject("SuperTabControlPanel4.BackgroundImage"), System.Drawing.Image)
        Me.SuperTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(236, 0)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(998, 709)
        Me.SuperTabControlPanel4.TabIndex = 4
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem4
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.KeyTips = "H"
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "Help"
        '
        'ButtonItem14
        '
        Me.ButtonItem14.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem14.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem14.Image = CType(resources.GetObject("ButtonItem14.Image"), System.Drawing.Image)
        Me.ButtonItem14.ImagePaddingHorizontal = 18
        Me.ButtonItem14.ImagePaddingVertical = 10
        Me.ButtonItem14.KeyTips = "S"
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.Stretch = True
        Me.ButtonItem14.Text = "Save"
        '
        'ButtonItem15
        '
        Me.ButtonItem15.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem15.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.ButtonItem15.Image = CType(resources.GetObject("ButtonItem15.Image"), System.Drawing.Image)
        Me.ButtonItem15.ImagePaddingHorizontal = 18
        Me.ButtonItem15.ImagePaddingVertical = 10
        Me.ButtonItem15.KeyTips = "O"
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.Stretch = True
        Me.ButtonItem15.Text = "Open"
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
        Me.ButtonItem17.Text = "Options"
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
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
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
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.LabelItem2, Me.LabelItem3})
        Me.Bar1.Location = New System.Drawing.Point(5, 687)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1226, 22)
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
        'LabelItem2
        '
        Me.LabelItem2.Image = CType(resources.GetObject("LabelItem2.Image"), System.Drawing.Image)
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "LabelItem2"
        '
        'LabelItem3
        '
        Me.LabelItem3.Image = CType(resources.GetObject("LabelItem3.Image"), System.Drawing.Image)
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "LabelItem3"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.BackColor = System.Drawing.Color.GhostWhite
        Me.RibbonControl1.BackgroundImage = CType(resources.GetObject("RibbonControl1.BackgroundImage"), System.Drawing.Image)
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CanCustomize = False
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.ForeColor = System.Drawing.Color.Black
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ApplicationButton1, Me.RibbonMatricula, Me.RibbonCobros})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(1226, 149)
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
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar6)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar5)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar4)
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 54)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.RibbonPanel1.Size = New System.Drawing.Size(1226, 95)
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
        Me.RibbonBar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem33, Me.ButtonItem34})
        Me.RibbonBar6.Location = New System.Drawing.Point(559, 0)
        Me.RibbonBar6.Name = "RibbonBar6"
        Me.RibbonBar6.Size = New System.Drawing.Size(147, 93)
        Me.RibbonBar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar6.TabIndex = 2
        Me.RibbonBar6.Text = "Ajustes"
        '
        '
        '
        Me.RibbonBar6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem33
        '
        Me.ButtonItem33.Image = CType(resources.GetObject("ButtonItem33.Image"), System.Drawing.Image)
        Me.ButtonItem33.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem33.Name = "ButtonItem33"
        Me.ButtonItem33.SubItemsExpandWidth = 14
        Me.ButtonItem33.Text = "Materias"
        '
        'ButtonItem34
        '
        Me.ButtonItem34.Image = CType(resources.GetObject("ButtonItem34.Image"), System.Drawing.Image)
        Me.ButtonItem34.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem34.Name = "ButtonItem34"
        Me.ButtonItem34.SubItemsExpandWidth = 14
        Me.ButtonItem34.Text = "Niveles"
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
        Me.RibbonBar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem35, Me.ButtonItem36, Me.ButtonItem37})
        Me.RibbonBar5.Location = New System.Drawing.Point(388, 0)
        Me.RibbonBar5.Name = "RibbonBar5"
        Me.RibbonBar5.Size = New System.Drawing.Size(171, 93)
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
        Me.ButtonItem35.Text = "Notas"
        '
        'ButtonItem36
        '
        Me.ButtonItem36.Image = CType(resources.GetObject("ButtonItem36.Image"), System.Drawing.Image)
        Me.ButtonItem36.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem36.Name = "ButtonItem36"
        Me.ButtonItem36.SubItemsExpandWidth = 14
        Me.ButtonItem36.Text = "Traslado"
        '
        'ButtonItem37
        '
        Me.ButtonItem37.Image = CType(resources.GetObject("ButtonItem37.Image"), System.Drawing.Image)
        Me.ButtonItem37.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem37.Name = "ButtonItem37"
        Me.ButtonItem37.SubItemsExpandWidth = 14
        Me.ButtonItem37.Text = "Constancia"
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
        Me.RibbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem29, Me.ButtonItem30, Me.ButtonItem31, Me.ButtonItem32})
        Me.RibbonBar4.Location = New System.Drawing.Point(178, 0)
        Me.RibbonBar4.Name = "RibbonBar4"
        Me.RibbonBar4.Size = New System.Drawing.Size(210, 93)
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
        'ButtonItem29
        '
        Me.ButtonItem29.Image = CType(resources.GetObject("ButtonItem29.Image"), System.Drawing.Image)
        Me.ButtonItem29.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem29.Name = "ButtonItem29"
        Me.ButtonItem29.SubItemsExpandWidth = 14
        Me.ButtonItem29.Text = "Genera Notas"
        '
        'ButtonItem30
        '
        Me.ButtonItem30.Image = CType(resources.GetObject("ButtonItem30.Image"), System.Drawing.Image)
        Me.ButtonItem30.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem30.Name = "ButtonItem30"
        Me.ButtonItem30.SubItemsExpandWidth = 14
        Me.ButtonItem30.Text = "Notas Excel"
        '
        'ButtonItem31
        '
        Me.ButtonItem31.Image = CType(resources.GetObject("ButtonItem31.Image"), System.Drawing.Image)
        Me.ButtonItem31.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem31.Name = "ButtonItem31"
        Me.ButtonItem31.SubItemsExpandWidth = 14
        Me.ButtonItem31.Text = "Registra Notas"
        '
        'ButtonItem32
        '
        Me.ButtonItem32.Image = CType(resources.GetObject("ButtonItem32.Image"), System.Drawing.Image)
        Me.ButtonItem32.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem32.Name = "ButtonItem32"
        Me.ButtonItem32.SubItemsExpandWidth = 14
        Me.ButtonItem32.Text = "Ausencias"
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
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem19, Me.ButtonItem20, Me.ButtonItem21})
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(175, 93)
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
        Me.ButtonItem19.Text = "Estudiantes"
        '
        'ButtonItem20
        '
        Me.ButtonItem20.Image = CType(resources.GetObject("ButtonItem20.Image"), System.Drawing.Image)
        Me.ButtonItem20.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem20.Name = "ButtonItem20"
        Me.ButtonItem20.SubItemsExpandWidth = 14
        Me.ButtonItem20.Text = "Matricula"
        '
        'ButtonItem21
        '
        Me.ButtonItem21.Image = CType(resources.GetObject("ButtonItem21.Image"), System.Drawing.Image)
        Me.ButtonItem21.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem21.Name = "ButtonItem21"
        Me.ButtonItem21.SubItemsExpandWidth = 14
        Me.ButtonItem21.Text = "Lista de Clases"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar7)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar3)
        Me.RibbonPanel2.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 54)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.RibbonPanel2.Size = New System.Drawing.Size(1226, 95)
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
        Me.RibbonBar7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MicroChartItem1, Me.ButtonItem38})
        Me.RibbonBar7.Location = New System.Drawing.Point(515, 0)
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Size = New System.Drawing.Size(155, 93)
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
        Me.RibbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem25, Me.ButtonItem26})
        Me.RibbonBar3.Location = New System.Drawing.Point(328, 0)
        Me.RibbonBar3.Name = "RibbonBar3"
        Me.RibbonBar3.Size = New System.Drawing.Size(187, 93)
        Me.RibbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar3.TabIndex = 1
        Me.RibbonBar3.Text = "Ajustes"
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
        Me.ButtonItem25.Text = "Convenios"
        '
        'ButtonItem26
        '
        Me.ButtonItem26.Image = CType(resources.GetObject("ButtonItem26.Image"), System.Drawing.Image)
        Me.ButtonItem26.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem26.Name = "ButtonItem26"
        Me.ButtonItem26.SubItemsExpandWidth = 14
        Me.ButtonItem26.Text = "Tabla cuotas"
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
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem22, Me.ButtonItem23, Me.ButtonItem24, Me.ButtonItem27, Me.ButtonItem28})
        Me.RibbonBar2.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(325, 93)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 0
        Me.RibbonBar2.Text = "Tareas"
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
        Me.ButtonItem22.Text = "Genera Cobros"
        '
        'ButtonItem23
        '
        Me.ButtonItem23.Image = CType(resources.GetObject("ButtonItem23.Image"), System.Drawing.Image)
        Me.ButtonItem23.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem23.Name = "ButtonItem23"
        Me.ButtonItem23.SubItemsExpandWidth = 14
        Me.ButtonItem23.Text = "Genera Cobros Matricula"
        '
        'ButtonItem24
        '
        Me.ButtonItem24.Image = CType(resources.GetObject("ButtonItem24.Image"), System.Drawing.Image)
        Me.ButtonItem24.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem24.Name = "ButtonItem24"
        Me.ButtonItem24.SubItemsExpandWidth = 14
        Me.ButtonItem24.Text = "Cobros Cancela"
        '
        'ButtonItem27
        '
        Me.ButtonItem27.Image = CType(resources.GetObject("ButtonItem27.Image"), System.Drawing.Image)
        Me.ButtonItem27.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem27.Name = "ButtonItem27"
        Me.ButtonItem27.SubItemsExpandWidth = 14
        Me.ButtonItem27.Text = "Cobros adelantado"
        '
        'ButtonItem28
        '
        Me.ButtonItem28.Image = CType(resources.GetObject("ButtonItem28.Image"), System.Drawing.Image)
        Me.ButtonItem28.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem28.Name = "ButtonItem28"
        Me.ButtonItem28.SubItemsExpandWidth = 14
        Me.ButtonItem28.Text = "Estados cuenta"
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
        'frmPrincipal2
        '
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1236, 711)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colegio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
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
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
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
    Friend WithEvents ButtonItem28 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar6 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonBar5 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonBar4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ButtonItem33 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem34 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem35 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem36 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem37 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem29 As DevComponents.DotNetBar.ButtonItem
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
End Class
