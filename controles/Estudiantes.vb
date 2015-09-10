Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports DevComponents.DotNetBar

Public Class Estudiantes
    Inherits System.Windows.Forms.UserControl

    Public bd As String = "estudiantes"
    Dim WithEvents CM As CurrencyManager
    Private pcarnet As String = ""
    Private Fnuevo As Boolean = False
    Dim anchoDC As Integer
    Public Bvisible As Boolean = True

#Region " Código generado por el Diseñador de Windows Forms "
    Friend WithEvents CNotasEstudiante1 As colegio.CNotasEstudiante
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel6 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem6 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem5 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Dim conn As New conexionSQL
        SqlConnection1.ConnectionString = conn.strConn
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal carnet As String)
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Dim conn As New conexionSQL
        SqlConnection1.ConnectionString = conn.strConn
        pcarnet = carnet
        buscar(pcarnet)
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
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As colegio.DataSet1
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents BuscaEstudiante1 As colegio.BuscaEstud
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CEstadoCuenta1 As colegio.CEstadoCuenta
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsCarnet1 As colegio.dsCarnet


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estudiantes))
        OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        ToolTip1 = New System.Windows.Forms.ToolTip(components)
        PictureBox1 = New System.Windows.Forms.PictureBox()
        TextBox1 = New System.Windows.Forms.TextBox()
        DataSet11 = New colegio.DataSet1()
        Label1 = New System.Windows.Forms.Label()
        TextBox2 = New System.Windows.Forms.TextBox()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        TextBox4 = New System.Windows.Forms.TextBox()
        Label3 = New System.Windows.Forms.Label()
        TextBox3 = New System.Windows.Forms.TextBox()
        TextBox14 = New System.Windows.Forms.TextBox()
        Label18 = New System.Windows.Forms.Label()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        RadioButton1 = New System.Windows.Forms.RadioButton()
        RadioButton2 = New System.Windows.Forms.RadioButton()
        Label16 = New System.Windows.Forms.Label()
        DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Label15 = New System.Windows.Forms.Label()
        ComboBox3 = New System.Windows.Forms.ComboBox()
        Label17 = New System.Windows.Forms.Label()
        GroupBox2 = New System.Windows.Forms.GroupBox()
        Label25 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        TextBox15 = New System.Windows.Forms.TextBox()
        ComboBox9 = New System.Windows.Forms.ComboBox()
        ComboBox8 = New System.Windows.Forms.ComboBox()
        ComboBox7 = New System.Windows.Forms.ComboBox()
        ComboBox6 = New System.Windows.Forms.ComboBox()
        Label20 = New System.Windows.Forms.Label()
        ComboBox5 = New System.Windows.Forms.ComboBox()
        Label19 = New System.Windows.Forms.Label()
        ComboBox4 = New System.Windows.Forms.ComboBox()
        DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Label13 = New System.Windows.Forms.Label()
        TextBox21 = New System.Windows.Forms.TextBox()
        TextBox18 = New System.Windows.Forms.TextBox()
        Label29 = New System.Windows.Forms.Label()
        TextBox17 = New System.Windows.Forms.TextBox()
        Label28 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        TextBox16 = New System.Windows.Forms.TextBox()
        TextBox13 = New System.Windows.Forms.TextBox()
        Label14 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        TextBox7 = New System.Windows.Forms.TextBox()
        TextBox8 = New System.Windows.Forms.TextBox()
        TextBox12 = New System.Windows.Forms.TextBox()
        TextBox9 = New System.Windows.Forms.TextBox()
        TextBox11 = New System.Windows.Forms.TextBox()
        TextBox6 = New System.Windows.Forms.TextBox()
        Label7 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        TextBox10 = New System.Windows.Forms.TextBox()
        TextBox5 = New System.Windows.Forms.TextBox()
        ComboBox2 = New System.Windows.Forms.ComboBox()
        TextBox23 = New System.Windows.Forms.TextBox()
        TextBox22 = New System.Windows.Forms.TextBox()
        Label34 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        ComboBox10 = New System.Windows.Forms.ComboBox()
        CEstadoCuenta1 = New colegio.CEstadoCuenta()
        CNotasEstudiante1 = New colegio.CNotasEstudiante()
        SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        ErrorProvider1 = New System.Windows.Forms.ErrorProvider(components)
        DsCarnet1 = New colegio.dsCarnet()
        UserControl21 = New colegio.UserControl2()
        BuscaEstudiante1 = New colegio.BuscaEstud()
        SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        SuperTabControlPanel6 = New DevComponents.DotNetBar.SuperTabControlPanel()
        SuperTabItem6 = New DevComponents.DotNetBar.SuperTabItem()
        SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        SuperTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
        SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DsCarnet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuperTabControl1.SuspendLayout()
        SuperTabControlPanel1.SuspendLayout()
        SuperTabControlPanel6.SuspendLayout()
        SuperTabControlPanel5.SuspendLayout()
        SuperTabControlPanel4.SuspendLayout()
        SuperTabControlPanel3.SuspendLayout()
        SuperTabControlPanel2.SuspendLayout()
        SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PictureBox1.Location = New System.Drawing.Point(251, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(270, 220)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        '
        'TextBox1
        '
        TextBox1.AllowDrop = True
        TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.carnet", True))
        TextBox1.Location = New System.Drawing.Point(93, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(144, 20)
        TextBox1.TabIndex = 0
        '
        'DataSet11
        '
        DataSet11.DataSetName = "DataSet1"
        DataSet11.Locale = New System.Globalization.CultureInfo("es-CR")
        DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(13, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(72, 16)
        Label1.TabIndex = 34
        Label1.Text = "Nombre"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.nombre", True))
        TextBox2.Location = New System.Drawing.Point(93, 46)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New System.Drawing.Size(144, 20)
        TextBox2.TabIndex = 1
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Location = New System.Drawing.Point(13, 98)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(72, 16)
        Label4.TabIndex = 37
        Label4.Text = "Apellido2"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(15, 22)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(72, 16)
        Label2.TabIndex = 35
        Label2.Text = "Carnet"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.apellido2", True))
        TextBox4.Location = New System.Drawing.Point(93, 96)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New System.Drawing.Size(144, 20)
        TextBox4.TabIndex = 3
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Location = New System.Drawing.Point(13, 72)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(72, 16)
        Label3.TabIndex = 36
        Label3.Text = "Apellido1"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.apellido1", True))
        TextBox3.Location = New System.Drawing.Point(93, 71)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New System.Drawing.Size(144, 20)
        TextBox3.TabIndex = 2
        '
        'TextBox14
        '
        TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.celular", True))
        TextBox14.Location = New System.Drawing.Point(93, 173)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New System.Drawing.Size(144, 20)
        TextBox14.TabIndex = 51
        '
        'Label18
        '
        Label18.BackColor = System.Drawing.Color.Transparent
        Label18.Location = New System.Drawing.Point(13, 174)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(72, 16)
        Label18.TabIndex = 50
        Label18.Text = "Teléfono"
        Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        GroupBox1.BackColor = System.Drawing.Color.Transparent
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Location = New System.Drawing.Point(93, 202)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(144, 56)
        GroupBox1.TabIndex = 47
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo"
        '
        'RadioButton1
        '
        RadioButton1.Location = New System.Drawing.Point(32, 16)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New System.Drawing.Size(104, 16)
        RadioButton1.TabIndex = 44
        RadioButton1.Text = "Masculino"
        '
        'RadioButton2
        '
        RadioButton2.Location = New System.Drawing.Point(32, 32)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New System.Drawing.Size(104, 16)
        RadioButton2.TabIndex = 45
        RadioButton2.Text = "Femenino"
        '
        'Label16
        '
        Label16.BackColor = System.Drawing.Color.Transparent
        Label16.Location = New System.Drawing.Point(13, 126)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(72, 16)
        Label16.TabIndex = 43
        Label16.Text = "Ingreso"
        Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.ingreso", True))
        DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        DateTimePicker2.Location = New System.Drawing.Point(93, 122)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New System.Drawing.Size(144, 20)
        DateTimePicker2.TabIndex = 42
        '
        'Label15
        '
        Label15.BackColor = System.Drawing.Color.Transparent
        Label15.Location = New System.Drawing.Point(13, 152)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(72, 16)
        Label15.TabIndex = 41
        Label15.Text = "Estado"
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox3
        '
        ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.estado", True))
        ComboBox3.Items.AddRange(New Object() {"ACTIVO", "REPROBADO", "TRASLADADO", "EGRESADO", "EXPULSADO"})
        ComboBox3.Location = New System.Drawing.Point(93, 146)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New System.Drawing.Size(144, 21)
        ComboBox3.TabIndex = 40
        '
        'Label17
        '
        Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.sexo", True))
        Label17.Location = New System.Drawing.Point(120, 23)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(16, 17)
        Label17.TabIndex = 49
        Label17.Text = "0"
        '
        'GroupBox2
        '
        GroupBox2.BackColor = System.Drawing.Color.Transparent
        GroupBox2.Controls.Add(Label25)
        GroupBox2.Controls.Add(Label24)
        GroupBox2.Controls.Add(Label23)
        GroupBox2.Controls.Add(Label22)
        GroupBox2.Controls.Add(Label21)
        GroupBox2.Controls.Add(TextBox15)
        GroupBox2.Controls.Add(ComboBox9)
        GroupBox2.Controls.Add(ComboBox8)
        GroupBox2.Controls.Add(ComboBox7)
        GroupBox2.Controls.Add(ComboBox6)
        GroupBox2.Location = New System.Drawing.Point(23, 70)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New System.Drawing.Size(428, 187)
        GroupBox2.TabIndex = 46
        GroupBox2.TabStop = False
        GroupBox2.Text = "Domicilio"
        '
        'Label25
        '
        Label25.BackColor = System.Drawing.Color.Transparent
        Label25.Location = New System.Drawing.Point(23, 134)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(72, 14)
        Label25.TabIndex = 48
        Label25.Text = "Dirección"
        Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Label24.BackColor = System.Drawing.Color.Transparent
        Label24.Location = New System.Drawing.Point(23, 111)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(72, 14)
        Label24.TabIndex = 47
        Label24.Text = "distrito"
        Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Label23.BackColor = System.Drawing.Color.Transparent
        Label23.Location = New System.Drawing.Point(23, 83)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(72, 14)
        Label23.TabIndex = 46
        Label23.Text = "Cantón"
        Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Label22.BackColor = System.Drawing.Color.Transparent
        Label22.Location = New System.Drawing.Point(23, 55)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(72, 14)
        Label22.TabIndex = 45
        Label22.Text = "Provincia"
        Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Label21.BackColor = System.Drawing.Color.Transparent
        Label21.Location = New System.Drawing.Point(23, 27)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(72, 14)
        Label21.TabIndex = 44
        Label21.Text = "País"
        Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox15
        '
        TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.direccion", True))
        TextBox15.Location = New System.Drawing.Point(101, 132)
        TextBox15.Multiline = True
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New System.Drawing.Size(321, 49)
        TextBox15.TabIndex = 4
        '
        'ComboBox9
        '
        ComboBox9.DataSource = DataSet11
        ComboBox9.DisplayMember = "estudiantes.id_distrito"
        ComboBox9.FormattingEnabled = True
        ComboBox9.Location = New System.Drawing.Point(101, 104)
        ComboBox9.Name = "ComboBox9"
        ComboBox9.Size = New System.Drawing.Size(121, 21)
        ComboBox9.TabIndex = 3
        '
        'ComboBox8
        '
        ComboBox8.DataSource = DataSet11
        ComboBox8.DisplayMember = "estudiantes.id_canton"
        ComboBox8.FormattingEnabled = True
        ComboBox8.Location = New System.Drawing.Point(101, 76)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New System.Drawing.Size(121, 21)
        ComboBox8.TabIndex = 2
        '
        'ComboBox7
        '
        ComboBox7.DataSource = DataSet11
        ComboBox7.DisplayMember = "estudiantes.id_provincia"
        ComboBox7.FormattingEnabled = True
        ComboBox7.Location = New System.Drawing.Point(101, 48)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New System.Drawing.Size(121, 21)
        ComboBox7.TabIndex = 1
        '
        'ComboBox6
        '
        ComboBox6.DataSource = DataSet11
        ComboBox6.DisplayMember = "estudiantes.id_pais"
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New System.Drawing.Point(101, 20)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New System.Drawing.Size(121, 21)
        ComboBox6.TabIndex = 0
        '
        'Label20
        '
        Label20.BackColor = System.Drawing.Color.Transparent
        Label20.Location = New System.Drawing.Point(274, 50)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(27, 14)
        Label20.TabIndex = 45
        Label20.Text = "Pais"
        Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox5
        '
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New System.Drawing.Point(307, 43)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New System.Drawing.Size(144, 21)
        ComboBox5.TabIndex = 44
        '
        'Label19
        '
        Label19.BackColor = System.Drawing.Color.Transparent
        Label19.Location = New System.Drawing.Point(46, 50)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(72, 14)
        Label19.TabIndex = 43
        Label19.Text = "Nacionalidad"
        Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox4
        '
        ComboBox4.DataSource = DataSet11
        ComboBox4.DisplayMember = "estudiantes.id_nacionalidad"
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New System.Drawing.Point(124, 43)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New System.Drawing.Size(144, 21)
        ComboBox4.TabIndex = 42
        '
        'DateTimePicker1
        '
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.nacimiento", True))
        DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        DateTimePicker1.Location = New System.Drawing.Point(124, 17)
        DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New System.Drawing.Size(144, 20)
        DateTimePicker1.TabIndex = 40
        '
        'Label13
        '
        Label13.BackColor = System.Drawing.Color.Transparent
        Label13.Location = New System.Drawing.Point(44, 20)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(72, 14)
        Label13.TabIndex = 41
        Label13.Text = "Nacimiento"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox21
        '
        TextBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.trabajo2", True))
        TextBox21.Location = New System.Drawing.Point(268, 128)
        TextBox21.Name = "TextBox21"
        TextBox21.Size = New System.Drawing.Size(194, 20)
        TextBox21.TabIndex = 44
        '
        'TextBox18
        '
        TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.trabajo", True))
        TextBox18.Location = New System.Drawing.Point(274, 17)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New System.Drawing.Size(188, 20)
        TextBox18.TabIndex = 41
        '
        'Label29
        '
        Label29.BackColor = System.Drawing.Color.Transparent
        Label29.Location = New System.Drawing.Point(203, 175)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(59, 23)
        Label29.TabIndex = 39
        Label29.Text = "Celular"
        Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox17
        '
        TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.telefono", True))
        TextBox17.Location = New System.Drawing.Point(262, 176)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New System.Drawing.Size(88, 20)
        TextBox17.TabIndex = 38
        '
        'Label28
        '
        Label28.BackColor = System.Drawing.Color.Transparent
        Label28.Location = New System.Drawing.Point(16, 196)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(59, 23)
        Label28.TabIndex = 37
        Label28.Text = "email"
        Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Label27.BackColor = System.Drawing.Color.Transparent
        Label27.Location = New System.Drawing.Point(16, 91)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(59, 23)
        Label27.TabIndex = 36
        Label27.Text = "email"
        Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Label26.BackColor = System.Drawing.Color.Transparent
        Label26.Location = New System.Drawing.Point(203, 65)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(59, 23)
        Label26.TabIndex = 35
        Label26.Text = "Celular"
        Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox16
        '
        TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.telefono", True))
        TextBox16.Location = New System.Drawing.Point(262, 65)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New System.Drawing.Size(88, 20)
        TextBox16.TabIndex = 34
        '
        'TextBox13
        '
        TextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.familia", True))
        TextBox13.Location = New System.Drawing.Point(78, 225)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New System.Drawing.Size(272, 20)
        TextBox13.TabIndex = 10
        '
        'Label14
        '
        Label14.BackColor = System.Drawing.Color.Transparent
        Label14.Location = New System.Drawing.Point(16, 223)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(59, 23)
        Label14.TabIndex = 33
        Label14.Text = "Familia"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Label9.BackColor = System.Drawing.Color.Transparent
        Label9.Location = New System.Drawing.Point(16, 176)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(59, 23)
        Label9.TabIndex = 31
        Label9.Text = "Teléfono"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Location = New System.Drawing.Point(16, 152)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(59, 23)
        Label10.TabIndex = 30
        Label10.Text = "Dirección"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Label11.BackColor = System.Drawing.Color.Transparent
        Label11.Location = New System.Drawing.Point(16, 128)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(59, 23)
        Label11.TabIndex = 29
        Label11.Text = "Nombre"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Location = New System.Drawing.Point(16, 65)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(59, 23)
        Label8.TabIndex = 28
        Label8.Text = "Teléfono"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox7
        '
        TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.direccion", True))
        TextBox7.Location = New System.Drawing.Point(86, 41)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New System.Drawing.Size(264, 20)
        TextBox7.TabIndex = 2
        '
        'TextBox8
        '
        TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.telefono", True))
        TextBox8.Location = New System.Drawing.Point(86, 65)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New System.Drawing.Size(117, 20)
        TextBox8.TabIndex = 3
        '
        'TextBox12
        '
        TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.email2", True))
        TextBox12.Location = New System.Drawing.Point(78, 201)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New System.Drawing.Size(184, 20)
        TextBox12.TabIndex = 9
        '
        'TextBox9
        '
        TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.direccion2", True))
        TextBox9.Location = New System.Drawing.Point(78, 152)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New System.Drawing.Size(272, 20)
        TextBox9.TabIndex = 7
        '
        'TextBox11
        '
        TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.telefono2", True))
        TextBox11.Location = New System.Drawing.Point(78, 176)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New System.Drawing.Size(125, 20)
        TextBox11.TabIndex = 8
        '
        'TextBox6
        '
        TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.encargado2", True))
        TextBox6.Location = New System.Drawing.Point(78, 128)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New System.Drawing.Size(184, 20)
        TextBox6.TabIndex = 5
        '
        'Label7
        '
        Label7.BackColor = System.Drawing.Color.Transparent
        Label7.Location = New System.Drawing.Point(16, 41)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(59, 23)
        Label7.TabIndex = 27
        Label7.Text = "Dirección"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Location = New System.Drawing.Point(16, 17)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(59, 23)
        Label5.TabIndex = 25
        Label5.Text = "Nombre"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.relacion", True))
        ComboBox1.ItemHeight = 13
        ComboBox1.Items.AddRange(New Object() {"PADRE", "MADRE"})
        ComboBox1.Location = New System.Drawing.Point(356, 43)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(106, 21)
        ComboBox1.TabIndex = 1
        '
        'TextBox10
        '
        TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.email", True))
        TextBox10.Location = New System.Drawing.Point(86, 91)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New System.Drawing.Size(264, 20)
        TextBox10.TabIndex = 4
        '
        'TextBox5
        '
        TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.encargado1", True))
        TextBox5.Location = New System.Drawing.Point(86, 17)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New System.Drawing.Size(184, 20)
        TextBox5.TabIndex = 0
        '
        'ComboBox2
        '
        ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.relacion2", True))
        ComboBox2.ItemHeight = 13
        ComboBox2.Items.AddRange(New Object() {"PADRE", "MADRE"})
        ComboBox2.Location = New System.Drawing.Point(356, 152)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New System.Drawing.Size(106, 21)
        ComboBox2.TabIndex = 6
        '
        'TextBox23
        '
        TextBox23.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.porcentaje", True))
        TextBox23.Location = New System.Drawing.Point(72, 77)
        TextBox23.Name = "TextBox23"
        TextBox23.Size = New System.Drawing.Size(100, 20)
        TextBox23.TabIndex = 5
        '
        'TextBox22
        '
        TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.beca", True))
        TextBox22.Location = New System.Drawing.Point(73, 50)
        TextBox22.Name = "TextBox22"
        TextBox22.Size = New System.Drawing.Size(100, 20)
        TextBox22.TabIndex = 4
        '
        'Label34
        '
        Label34.AutoSize = True
        Label34.BackColor = System.Drawing.Color.Transparent
        Label34.Location = New System.Drawing.Point(9, 77)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(58, 13)
        Label34.TabIndex = 3
        Label34.Text = "Porcentaje"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.BackColor = System.Drawing.Color.Transparent
        Label33.Location = New System.Drawing.Point(35, 50)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(32, 13)
        Label33.TabIndex = 2
        Label33.Text = "Beca"
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.BackColor = System.Drawing.Color.Transparent
        Label32.Location = New System.Drawing.Point(16, 22)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(51, 13)
        Label32.TabIndex = 1
        Label32.Text = "Dia Pago"
        '
        'ComboBox10
        '
        ComboBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSet11, "estudiantes.dia_pago", True))
        ComboBox10.FormattingEnabled = True
        ComboBox10.Location = New System.Drawing.Point(72, 19)
        ComboBox10.Name = "ComboBox10"
        ComboBox10.Size = New System.Drawing.Size(121, 21)
        ComboBox10.TabIndex = 0
        '
        'CEstadoCuenta1
        '
        CEstadoCuenta1.BackColor = System.Drawing.Color.Transparent
        CEstadoCuenta1.Location = New System.Drawing.Point(15, 19)
        CEstadoCuenta1.Name = "CEstadoCuenta1"
        CEstadoCuenta1.Size = New System.Drawing.Size(447, 256)
        CEstadoCuenta1.TabIndex = 100
        '
        'CNotasEstudiante1
        '
        CNotasEstudiante1.BackColor = System.Drawing.Color.Transparent
        CNotasEstudiante1.Location = New System.Drawing.Point(3, 3)
        CNotasEstudiante1.Name = "CNotasEstudiante1"
        CNotasEstudiante1.Size = New System.Drawing.Size(450, 253)
        CNotasEstudiante1.TabIndex = 0
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "Data Source=colegio-server;Initial Catalog=colegio;Persist Security Info=True;Use" & _
    "r ID=sa;Password=123"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand1
        SqlDataAdapter1.InsertCommand = SqlInsertCommand1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "estudiantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("apellido2", "apellido2"), New System.Data.Common.DataColumnMapping("encargado1", "encargado1"), New System.Data.Common.DataColumnMapping("relacion", "relacion"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("trabajo", "trabajo"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("encargado2", "encargado2"), New System.Data.Common.DataColumnMapping("relacion2", "relacion2"), New System.Data.Common.DataColumnMapping("direccion2", "direccion2"), New System.Data.Common.DataColumnMapping("trabajo2", "trabajo2"), New System.Data.Common.DataColumnMapping("telefono2", "telefono2"), New System.Data.Common.DataColumnMapping("email2", "email2"), New System.Data.Common.DataColumnMapping("estado", "estado"), New System.Data.Common.DataColumnMapping("familia", "familia"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellido1", "apellido1"), New System.Data.Common.DataColumnMapping("ingreso", "ingreso"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("id_pais_nacimiento", "id_pais_nacimiento"), New System.Data.Common.DataColumnMapping("id_nacionalidad", "id_nacionalidad"), New System.Data.Common.DataColumnMapping("id_pais", "id_pais"), New System.Data.Common.DataColumnMapping("id_provincia", "id_provincia"), New System.Data.Common.DataColumnMapping("id_canton", "id_canton"), New System.Data.Common.DataColumnMapping("id_distrito", "id_distrito"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("celular1", "celular1"), New System.Data.Common.DataColumnMapping("celular2", "celular2"), New System.Data.Common.DataColumnMapping("beca", "beca"), New System.Data.Common.DataColumnMapping("porcentaje", "porcentaje"), New System.Data.Common.DataColumnMapping("dia_pago", "dia_pago"), New System.Data.Common.DataColumnMapping("procedencia", "procedencia"), New System.Data.Common.DataColumnMapping("enfermedades", "enfermedades"), New System.Data.Common.DataColumnMapping("observaciones", "observaciones")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_encargado1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_encargado1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_relacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_relacion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_trabajo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "trabajo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_trabajo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_encargado2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_encargado2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_relacion2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_relacion2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_direccion2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_direccion2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_trabajo2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "trabajo2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_trabajo2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_email2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_email2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_familia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "familia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nacimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cedula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ingreso", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_sexo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_pais_nacimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_pais_nacimiento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_pais_nacimiento", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_pais_nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_nacionalidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_nacionalidad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_nacionalidad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_nacionalidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_pais", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_pais", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_pais", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_pais", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_provincia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_provincia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_provincia", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_provincia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_canton", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_canton", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_canton", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_canton", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_distrito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_distrito", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_distrito", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_distrito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_beca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_porcentaje", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "porcentaje", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_porcentaje", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(3, Byte), "porcentaje", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_dia_pago", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "dia_pago", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_dia_pago", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dia_pago", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 0, "carnet"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 0, "apellido2"), New System.Data.SqlClient.SqlParameter("@encargado1", System.Data.SqlDbType.VarChar, 0, "encargado1"), New System.Data.SqlClient.SqlParameter("@relacion", System.Data.SqlDbType.VarChar, 0, "relacion"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@trabajo", System.Data.SqlDbType.VarChar, 0, "trabajo"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 0, "email"), New System.Data.SqlClient.SqlParameter("@encargado2", System.Data.SqlDbType.VarChar, 0, "encargado2"), New System.Data.SqlClient.SqlParameter("@relacion2", System.Data.SqlDbType.VarChar, 0, "relacion2"), New System.Data.SqlClient.SqlParameter("@direccion2", System.Data.SqlDbType.VarChar, 0, "direccion2"), New System.Data.SqlClient.SqlParameter("@trabajo2", System.Data.SqlDbType.VarChar, 0, "trabajo2"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.VarChar, 0, "telefono2"), New System.Data.SqlClient.SqlParameter("@email2", System.Data.SqlDbType.VarChar, 0, "email2"), New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 0, "estado"), New System.Data.SqlClient.SqlParameter("@familia", System.Data.SqlDbType.VarChar, 0, "familia"), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 0, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.[Char], 0, "cedula"), New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 0, "apellido1"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 0, "ingreso"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_pais_nacimiento", System.Data.SqlDbType.VarChar, 0, "id_pais_nacimiento"), New System.Data.SqlClient.SqlParameter("@id_nacionalidad", System.Data.SqlDbType.VarChar, 0, "id_nacionalidad"), New System.Data.SqlClient.SqlParameter("@id_pais", System.Data.SqlDbType.VarChar, 0, "id_pais"), New System.Data.SqlClient.SqlParameter("@id_provincia", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_provincia", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_canton", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_canton", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_distrito", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_distrito", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 0, "celular"), New System.Data.SqlClient.SqlParameter("@celular1", System.Data.SqlDbType.VarChar, 0, "celular1"), New System.Data.SqlClient.SqlParameter("@celular2", System.Data.SqlDbType.VarChar, 0, "celular2"), New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.VarChar, 0, "beca"), New System.Data.SqlClient.SqlParameter("@porcentaje", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(3, Byte), "porcentaje", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@dia_pago", System.Data.SqlDbType.VarChar, 0, "dia_pago"), New System.Data.SqlClient.SqlParameter("@procedencia", System.Data.SqlDbType.VarChar, 0, "procedencia"), New System.Data.SqlClient.SqlParameter("@enfermedades", System.Data.SqlDbType.VarChar, 0, "enfermedades"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        SqlSelectCommand1.Connection = SqlConnection1
        SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 0, "carnet"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 0, "nombre"), New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 0, "apellido2"), New System.Data.SqlClient.SqlParameter("@encargado1", System.Data.SqlDbType.VarChar, 0, "encargado1"), New System.Data.SqlClient.SqlParameter("@relacion", System.Data.SqlDbType.VarChar, 0, "relacion"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 0, "direccion"), New System.Data.SqlClient.SqlParameter("@trabajo", System.Data.SqlDbType.VarChar, 0, "trabajo"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 0, "telefono"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 0, "email"), New System.Data.SqlClient.SqlParameter("@encargado2", System.Data.SqlDbType.VarChar, 0, "encargado2"), New System.Data.SqlClient.SqlParameter("@relacion2", System.Data.SqlDbType.VarChar, 0, "relacion2"), New System.Data.SqlClient.SqlParameter("@direccion2", System.Data.SqlDbType.VarChar, 0, "direccion2"), New System.Data.SqlClient.SqlParameter("@trabajo2", System.Data.SqlDbType.VarChar, 0, "trabajo2"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.VarChar, 0, "telefono2"), New System.Data.SqlClient.SqlParameter("@email2", System.Data.SqlDbType.VarChar, 0, "email2"), New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 0, "estado"), New System.Data.SqlClient.SqlParameter("@familia", System.Data.SqlDbType.VarChar, 0, "familia"), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 0, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.[Char], 0, "cedula"), New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 0, "apellido1"), New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 0, "ingreso"), New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_pais_nacimiento", System.Data.SqlDbType.VarChar, 0, "id_pais_nacimiento"), New System.Data.SqlClient.SqlParameter("@id_nacionalidad", System.Data.SqlDbType.VarChar, 0, "id_nacionalidad"), New System.Data.SqlClient.SqlParameter("@id_pais", System.Data.SqlDbType.VarChar, 0, "id_pais"), New System.Data.SqlClient.SqlParameter("@id_provincia", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_provincia", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_canton", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_canton", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@id_distrito", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_distrito", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 0, "celular"), New System.Data.SqlClient.SqlParameter("@celular1", System.Data.SqlDbType.VarChar, 0, "celular1"), New System.Data.SqlClient.SqlParameter("@celular2", System.Data.SqlDbType.VarChar, 0, "celular2"), New System.Data.SqlClient.SqlParameter("@beca", System.Data.SqlDbType.VarChar, 0, "beca"), New System.Data.SqlClient.SqlParameter("@porcentaje", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(3, Byte), "porcentaje", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@dia_pago", System.Data.SqlDbType.VarChar, 0, "dia_pago"), New System.Data.SqlClient.SqlParameter("@procedencia", System.Data.SqlDbType.VarChar, 0, "procedencia"), New System.Data.SqlClient.SqlParameter("@enfermedades", System.Data.SqlDbType.VarChar, 0, "enfermedades"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 0, "observaciones"), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_encargado1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_encargado1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_relacion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_relacion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_trabajo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "trabajo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_trabajo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_encargado2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_encargado2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_relacion2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_relacion2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_direccion2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_direccion2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_trabajo2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "trabajo2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_trabajo2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_telefono2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_email2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_email2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_familia", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "familia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_nacimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_cedula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ingreso", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_sexo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_pais_nacimiento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_pais_nacimiento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_pais_nacimiento", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_pais_nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_nacionalidad", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_nacionalidad", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_nacionalidad", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_nacionalidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_pais", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_pais", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_pais", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_pais", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_provincia", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_provincia", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_provincia", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_provincia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_canton", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_canton", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_canton", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_canton", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_id_distrito", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "id_distrito", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_id_distrito", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(2, Byte), CType(0, Byte), "id_distrito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_celular2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "celular2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_celular2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_beca", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_beca", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "beca", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_porcentaje", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "porcentaje", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_porcentaje", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(3, Byte), "porcentaje", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_dia_pago", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "dia_pago", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_dia_pago", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "dia_pago", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        SqlDataAdapter2.DeleteCommand = SqlDeleteCommand2
        SqlDataAdapter2.InsertCommand = SqlInsertCommand2
        SqlDataAdapter2.SelectCommand = SqlSelectCommand2
        SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "fotos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("foto", "foto")})})
        SqlDataAdapter2.UpdateCommand = SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        SqlDeleteCommand2.CommandText = "DELETE FROM fotos WHERE (carnet = @Original_carnet)"
        SqlDeleteCommand2.Connection = SqlConnection1
        SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        SqlInsertCommand2.CommandText = "INSERT INTO fotos(carnet, foto) VALUES (@carnet, @foto); SELECT carnet, foto FROM" & _
    " fotos WHERE (carnet = @carnet)"
        SqlInsertCommand2.Connection = SqlConnection1
        SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@foto", System.Data.SqlDbType.VarBinary, 2147483647, "foto")})
        '
        'SqlSelectCommand2
        '
        SqlSelectCommand2.CommandText = "SELECT carnet, foto FROM fotos WHERE (carnet = @carnet)"
        SqlSelectCommand2.Connection = SqlConnection1
        SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'SqlUpdateCommand2
        '
        SqlUpdateCommand2.CommandText = "UPDATE fotos SET carnet = @carnet, foto = @foto WHERE (carnet = @Original_carnet)" & _
    "; SELECT carnet, foto FROM fotos WHERE (carnet = @carnet)"
        SqlUpdateCommand2.Connection = SqlConnection1
        SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@foto", System.Data.SqlDbType.VarBinary, 2147483647, "foto"), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ErrorProvider1
        '
        ErrorProvider1.ContainerControl = Me
        '
        'DsCarnet1
        '
        DsCarnet1.DataSetName = "dsCarnet"
        DsCarnet1.Locale = New System.Globalization.CultureInfo("es-CR")
        DsCarnet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserControl21
        '
        UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        UserControl21.Location = New System.Drawing.Point(240, 0)
        UserControl21.Name = "UserControl21"
        UserControl21.Size = New System.Drawing.Size(535, 32)
        UserControl21.TabIndex = 4
        '
        'BuscaEstudiante1
        '
        BuscaEstudiante1.BackColor = System.Drawing.Color.Transparent
        BuscaEstudiante1.Dock = System.Windows.Forms.DockStyle.Left
        BuscaEstudiante1.Location = New System.Drawing.Point(0, 0)
        BuscaEstudiante1.Name = "BuscaEstudiante1"
        BuscaEstudiante1.Size = New System.Drawing.Size(240, 468)
        BuscaEstudiante1.TabIndex = 0
        '
        'SuperTabControl1
        '
        SuperTabControl1.BackColor = System.Drawing.Color.White
        '
        '
        '
        '
        '
        '
        SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        SuperTabControl1.ControlBox.MenuBox.Name = ""
        SuperTabControl1.ControlBox.Name = ""
        SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {SuperTabControl1.ControlBox.MenuBox, SuperTabControl1.ControlBox.CloseBox})
        SuperTabControl1.Controls.Add(SuperTabControlPanel1)
        SuperTabControl1.Controls.Add(SuperTabControlPanel6)
        SuperTabControl1.Controls.Add(SuperTabControlPanel5)
        SuperTabControl1.Controls.Add(SuperTabControlPanel4)
        SuperTabControl1.Controls.Add(SuperTabControlPanel3)
        SuperTabControl1.Controls.Add(SuperTabControlPanel2)
        SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        SuperTabControl1.ForeColor = System.Drawing.Color.Black
        SuperTabControl1.Location = New System.Drawing.Point(240, 32)
        SuperTabControl1.Name = "SuperTabControl1"
        SuperTabControl1.ReorderTabsEnabled = True
        SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        SuperTabControl1.SelectedTabIndex = 0
        SuperTabControl1.Size = New System.Drawing.Size(535, 436)
        SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SuperTabControl1.TabIndex = 41
        SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {SuperTabItem1, SuperTabItem2, SuperTabItem3, SuperTabItem4, SuperTabItem5, SuperTabItem6})
        SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        '
        'SuperTabControlPanel1
        '
        SuperTabControlPanel1.Controls.Add(TextBox14)
        SuperTabControlPanel1.Controls.Add(PictureBox1)
        SuperTabControlPanel1.Controls.Add(TextBox4)
        SuperTabControlPanel1.Controls.Add(Label1)
        SuperTabControlPanel1.Controls.Add(DateTimePicker2)
        SuperTabControlPanel1.Controls.Add(Label18)
        SuperTabControlPanel1.Controls.Add(Label15)
        SuperTabControlPanel1.Controls.Add(TextBox1)
        SuperTabControlPanel1.Controls.Add(Label3)
        SuperTabControlPanel1.Controls.Add(Label2)
        SuperTabControlPanel1.Controls.Add(TextBox2)
        SuperTabControlPanel1.Controls.Add(Label16)
        SuperTabControlPanel1.Controls.Add(GroupBox1)
        SuperTabControlPanel1.Controls.Add(ComboBox3)
        SuperTabControlPanel1.Controls.Add(Label4)
        SuperTabControlPanel1.Controls.Add(TextBox3)
        SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        SuperTabControlPanel1.Location = New System.Drawing.Point(0, 23)
        SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        SuperTabControlPanel1.Size = New System.Drawing.Size(535, 413)
        SuperTabControlPanel1.TabIndex = 0
        SuperTabControlPanel1.TabItem = SuperTabItem1
        '
        'SuperTabItem1
        '
        SuperTabItem1.AttachedControl = SuperTabControlPanel1
        SuperTabItem1.GlobalItem = False
        SuperTabItem1.Name = "SuperTabItem1"
        SuperTabItem1.Text = "Estudiante"
        '
        'SuperTabControlPanel6
        '
        SuperTabControlPanel6.Controls.Add(CNotasEstudiante1)
        SuperTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        SuperTabControlPanel6.Location = New System.Drawing.Point(0, 0)
        SuperTabControlPanel6.Name = "SuperTabControlPanel6"
        SuperTabControlPanel6.Size = New System.Drawing.Size(535, 436)
        SuperTabControlPanel6.TabIndex = 0
        SuperTabControlPanel6.TabItem = SuperTabItem6
        '
        'SuperTabItem6
        '
        SuperTabItem6.AttachedControl = SuperTabControlPanel6
        SuperTabItem6.GlobalItem = False
        SuperTabItem6.Name = "SuperTabItem6"
        SuperTabItem6.Text = "Notas"
        '
        'SuperTabControlPanel5
        '
        SuperTabControlPanel5.Controls.Add(CEstadoCuenta1)
        SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        SuperTabControlPanel5.Location = New System.Drawing.Point(0, 0)
        SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        SuperTabControlPanel5.Size = New System.Drawing.Size(535, 436)
        SuperTabControlPanel5.TabIndex = 0
        SuperTabControlPanel5.TabItem = SuperTabItem5
        '
        'SuperTabItem5
        '
        SuperTabItem5.AttachedControl = SuperTabControlPanel5
        SuperTabItem5.GlobalItem = False
        SuperTabItem5.Name = "SuperTabItem5"
        SuperTabItem5.Text = "Pagos"
        '
        'SuperTabControlPanel4
        '
        SuperTabControlPanel4.Controls.Add(TextBox23)
        SuperTabControlPanel4.Controls.Add(ComboBox10)
        SuperTabControlPanel4.Controls.Add(TextBox22)
        SuperTabControlPanel4.Controls.Add(Label32)
        SuperTabControlPanel4.Controls.Add(Label34)
        SuperTabControlPanel4.Controls.Add(Label33)
        SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        SuperTabControlPanel4.Location = New System.Drawing.Point(0, 0)
        SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        SuperTabControlPanel4.Size = New System.Drawing.Size(535, 436)
        SuperTabControlPanel4.TabIndex = 0
        SuperTabControlPanel4.TabItem = SuperTabItem4
        '
        'SuperTabItem4
        '
        SuperTabItem4.AttachedControl = SuperTabControlPanel4
        SuperTabItem4.GlobalItem = False
        SuperTabItem4.Name = "SuperTabItem4"
        SuperTabItem4.Text = "Pago"
        '
        'SuperTabControlPanel3
        '
        SuperTabControlPanel3.Controls.Add(TextBox21)
        SuperTabControlPanel3.Controls.Add(TextBox9)
        SuperTabControlPanel3.Controls.Add(TextBox18)
        SuperTabControlPanel3.Controls.Add(ComboBox2)
        SuperTabControlPanel3.Controls.Add(Label29)
        SuperTabControlPanel3.Controls.Add(TextBox5)
        SuperTabControlPanel3.Controls.Add(TextBox17)
        SuperTabControlPanel3.Controls.Add(TextBox10)
        SuperTabControlPanel3.Controls.Add(Label28)
        SuperTabControlPanel3.Controls.Add(ComboBox1)
        SuperTabControlPanel3.Controls.Add(Label27)
        SuperTabControlPanel3.Controls.Add(Label5)
        SuperTabControlPanel3.Controls.Add(Label26)
        SuperTabControlPanel3.Controls.Add(Label7)
        SuperTabControlPanel3.Controls.Add(TextBox16)
        SuperTabControlPanel3.Controls.Add(TextBox6)
        SuperTabControlPanel3.Controls.Add(TextBox13)
        SuperTabControlPanel3.Controls.Add(TextBox11)
        SuperTabControlPanel3.Controls.Add(Label14)
        SuperTabControlPanel3.Controls.Add(TextBox12)
        SuperTabControlPanel3.Controls.Add(Label9)
        SuperTabControlPanel3.Controls.Add(TextBox8)
        SuperTabControlPanel3.Controls.Add(Label10)
        SuperTabControlPanel3.Controls.Add(TextBox7)
        SuperTabControlPanel3.Controls.Add(Label11)
        SuperTabControlPanel3.Controls.Add(Label8)
        SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        SuperTabControlPanel3.Location = New System.Drawing.Point(0, 0)
        SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        SuperTabControlPanel3.Size = New System.Drawing.Size(535, 436)
        SuperTabControlPanel3.TabIndex = 0
        SuperTabControlPanel3.TabItem = SuperTabItem3
        '
        'SuperTabItem3
        '
        SuperTabItem3.AttachedControl = SuperTabControlPanel3
        SuperTabItem3.GlobalItem = False
        SuperTabItem3.Name = "SuperTabItem3"
        SuperTabItem3.Text = "Encargados"
        '
        'SuperTabControlPanel2
        '
        SuperTabControlPanel2.Controls.Add(GroupBox2)
        SuperTabControlPanel2.Controls.Add(Label20)
        SuperTabControlPanel2.Controls.Add(Label13)
        SuperTabControlPanel2.Controls.Add(ComboBox5)
        SuperTabControlPanel2.Controls.Add(DateTimePicker1)
        SuperTabControlPanel2.Controls.Add(Label19)
        SuperTabControlPanel2.Controls.Add(ComboBox4)
        SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        SuperTabControlPanel2.Location = New System.Drawing.Point(0, 0)
        SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        SuperTabControlPanel2.Size = New System.Drawing.Size(535, 436)
        SuperTabControlPanel2.TabIndex = 0
        SuperTabControlPanel2.TabItem = SuperTabItem2
        '
        'SuperTabItem2
        '
        SuperTabItem2.AttachedControl = SuperTabControlPanel2
        SuperTabItem2.GlobalItem = False
        SuperTabItem2.Name = "SuperTabItem2"
        SuperTabItem2.Text = "Domicilio"
        '
        'Estudiantes
        '
        Controls.Add(SuperTabControl1)
        Controls.Add(UserControl21)
        Controls.Add(BuscaEstudiante1)
        Name = "Estudiantes"
        Size = New System.Drawing.Size(775, 468)
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DsCarnet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        SuperTabControl1.ResumeLayout(False)
        SuperTabControlPanel1.ResumeLayout(False)
        SuperTabControlPanel1.PerformLayout()
        SuperTabControlPanel6.ResumeLayout(False)
        SuperTabControlPanel5.ResumeLayout(False)
        SuperTabControlPanel4.ResumeLayout(False)
        SuperTabControlPanel4.PerformLayout()
        SuperTabControlPanel3.ResumeLayout(False)
        SuperTabControlPanel3.PerformLayout()
        SuperTabControlPanel2.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region

    'COMENT : Coloca el mensaje para lenguaje
    <Description("Seleccione el formato del control"), Category("Format")> _
    Public Property BuscarVisible() As Boolean
        Get
            Return Bvisible
        End Get
        Set(ByVal Value As Boolean)
            Bvisible = Value
            BuscaEstudiante1.Visible = Bvisible
            Refresh()
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName())
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingContext(DataSet11, bd).AddNew()
        SqlDataAdapter1.Update(DataSet11, bd)
    End Sub

    Public Sub nuevo()
        Try
            'Borrar las ediciones actuales
            ' Me.controlesAbre(True)
            BindingContext(DataSet11, bd).EndCurrentEdit()
            BindingContext(DataSet11, bd).AddNew()
            ComboBox3.Text = "ACTIVO"
            UserControl21.salvar.Enabled = True
            Label17.Text = "1"
            TextBox1.Focus()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Public Sub guardar()
        Try
            If Not (PictureBox1.Image Is Nothing) Then
                SqlDataAdapter2.SelectCommand.Parameters.Item("@carnet").Value = pcarnet
                SqlDataAdapter2.Fill(DataSet11, "fotos")
                If DataSet11.Tables("fotos").Rows.Count > 0 Then
                    CType(BindingContext(DataSet11, "fotos").Current, DataRowView).Row("foto") = LeerImagen(PictureBox1)
                    CType(BindingContext(DataSet11, "fotos").Current, DataRowView).Row("carnet") = TextBox1.Text
                Else
                    BindingContext(DataSet11, "fotos").AddNew()
                    CType(BindingContext(DataSet11, "fotos").Current, DataRowView).Row("foto") = LeerImagen(PictureBox1)
                    CType(BindingContext(DataSet11, "fotos").Current, DataRowView).Row("carnet") = TextBox1.Text
                    Fnuevo = False
                End If
            End If
            BindingContext(DataSet11, bd).EndCurrentEdit()
            BindingContext(DataSet11, "fotos").EndCurrentEdit()

            SqlDataAdapter1.Update(DataSet11, bd)
            SqlDataAdapter2.Update(DataSet11, "fotos")
            UserControl21.salvar.Enabled = False
        Catch ex As SqlClient.SqlException
            Select Case ex.Number
                Case 2627
                    MsgBox("Carnet ya existe en la base de datos", MsgBoxStyle.OkOnly, "Ocurrió un error en Guardar")
                Case Else
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Ocurrió un error en Guardar")
            End Select
            Exit Sub

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales
            Dim Registro As Integer
            Registro = BindingContext(DataSet11, bd).Position
            BindingContext(DataSet11, bd).EndCurrentEdit()
            BindingContext(DataSet11, bd).RemoveAt(Registro)
            SqlDataAdapter1.Update(DataSet11, bd)
            PictureBox1.Image = Nothing
            BindingContext(DataSet11, bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub

    Public Sub buscar(ByVal pcarnet As String)

        If Not (pcarnet Is Nothing) Then

            guardar()
            DataSet11.Tables(bd).Clear()
            DataSet11.Tables("fotos").Clear()

            SqlDataAdapter1.SelectCommand.Parameters.Item("@carnet").Value = pcarnet
            SqlDataAdapter1.Fill(DataSet11, bd)

            SqlDataAdapter2.SelectCommand.Parameters.Item("@carnet").Value = pcarnet
            SqlDataAdapter2.Fill(DataSet11, "fotos")
            mostrar_imagen()

            'CestadoCuenta
            CEstadoCuenta1.buscar(pcarnet)
            SuperTabItem5.PredefinedColor = eTabItemColor.Default

            If CEstadoCuenta1.pendiente Then
                SuperTabItem5.PredefinedColor = eTabItemColor.Red
            End If
            'CNotasEstudiante
            CNotasEstudiante1.buscar(pcarnet)

            UserControl21.salvar.Enabled = True
            'Me.controlesAbre(True)
        End If
    End Sub
    Public Sub buscar()
        Try
            BuscaEstudiante1.Visible = Not Bvisible
            Bvisible = Not Bvisible
            'If Bvisible Then
            '    Me.Width = Me.BuscaEstudiante1.Width + Me.DocumentContainer1.Width
            'Else
            '    Me.Width = Me.DocumentContainer1.Width
            'End If
            Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Sub imprimir()
        Try
            Dim mi_reporte As New DataSet1
            SqlDataAdapter1.Fill(mi_reporte, "estudiantes")
            ' Dim mi_rptEst As New rptEstudiantes
            ' mi_rptEst.SetDataSource(mi_reporte)
            Dim miForma As New frmReporte
            'miForma.CrystalReportViewer1.ReportSource = mi_rptEst
            miForma.Text = "Reporte de Estudiantes"
            miForma.MdiParent = ParentForm
            miForma.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmEstudiantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If DesignMode Then
            ' The component is in design mode

        Else
            Dim conn As New conexionSQL

            SqlConnection1.ConnectionString = conn.strConn
            UserControl21.salvar.Enabled = False

            DataSet11.Clear() 'Limpiar el DataSet
            If Not pcarnet = "" Then
                buscar(pcarnet)
            End If
            ' Me.controlesAbre(False)
        End If


    End Sub

    Public Function LeerImagen(ByVal Picture As PictureBox) As Byte()
        Try
            Dim ms As MemoryStream = New MemoryStream
            Picture.Image.Save(ms, ImageFormat.Jpeg)
            Dim bytBLOBData(CInt(ms.Length) - 1) As Byte
            ms.Position = 0
            ms.Read(bytBLOBData, 0, CInt(ms.Length))
            Return bytBLOBData
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            mostrar_imagen()
        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try

            Dim frmWeb As New frmWebCam2(PictureBox1, Fnuevo)
            frmWeb.MdiParent = ParentForm.ParentForm
            frmWeb.Show()

            'Dim DlgOpenFile As New OpenFileDialog
            'Dim figura As Image

            'DlgOpenFile.ShowReadOnly = True
            'If DlgOpenFile.ShowDialog() = DialogResult.OK Then
            '    figura = Image.FromFile(DlgOpenFile.FileName)
            '    If figura.Size.Height < 320 And figura.Size.Width < 320 Then
            '        PictureBox1.Image = figura
            '        Fnuevo = True
            '        pcarnet = TextBox1.Text
            '    Else
            '        MessageBox.Show("Imagen muy grande , Maxima Resolucion 320x320 ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    End If
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub mostrar_imagen()
        If DataSet11.Tables("fotos").Rows.Count > 0 Then
            Dim DataRowView1 As DataRowView
            DataRowView1 = CType(BindingContext(DataSet11, "fotos").Current, DataRowView)
            Dim bytBLOBData() As Byte = CType(DataRowView1("foto"), Byte())
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            PictureBox1.Image = Image.FromStream(stmBLOBData)
        Else
            PictureBox1.Image = Nothing
        End If
        Fnuevo = False
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If Label17.Text <> "0" Then
            Label17.Text = "0"
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If Label17.Text <> "1" Then
            Label17.Text = "1"
        End If
    End Sub

    Private Sub Label17_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label17.TextChanged

        Select Case Label17.Text
            Case "0"
                RadioButton1.Checked = True
            Case "1"
                RadioButton2.Checked = True
            Case Else
                RadioButton1.Checked = False
                RadioButton2.Checked = False
        End Select
    End Sub

    'Private Sub controlesAbre(ByVal abre As Boolean)

    '    Dim i As Integer
    '    For i = 0 To Me.DockControl1.Controls.Count - 1
    '        If abre Then
    '            Me.DockControl1.Controls(i).Enabled = True
    '        Else
    '            Me.DockControl1.Controls(i).Enabled = False
    '        End If
    '    Next i

    '    For i = 0 To Me.DockControl2.Controls.Count - 1
    '        If abre Then
    '            Me.DockControl2.Controls(i).Enabled = True
    '        Else
    '            Me.DockControl2.Controls(i).Enabled = False
    '        End If
    '    Next i

    '    For i = 0 To Me.DockControl3.Controls.Count - 1
    '        If abre Then
    '            Me.DockControl3.Controls(i).Enabled = True
    '        Else
    '            Me.DockControl3.Controls(i).Enabled = False
    '        End If
    '    Next i
    'End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox13.Text = TextBox3.Text & TextBox4.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox13.Text = TextBox3.Text & TextBox4.Text
    End Sub

    Private Sub BuscaEstudiante1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstudiante1.selecionado
        buscar(BuscaEstudiante1.seleccionado)
    End Sub

End Class
