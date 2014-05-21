Public Class frmRubros
    Inherits System.Windows.Forms.Form
    Dim conn As New conexionSQL
    Dim rnuevo As Boolean
    Dim indices As Integer()
    Dim bd As String = "rubros"
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPlanilla1 As colegio.dsPlanilla
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents XpTaskPanel1 As SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XpTaskBox1 As SteepValley.Windows.Forms.ThemedControls.XPTaskBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRubros))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.DsPlanilla1 = New colegio.dsPlanilla
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XpTaskPanel1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
        Me.XpTaskBox1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.UserControl21 = New colegio.UserControl2
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XpTaskPanel1.SuspendLayout()
        Me.XpTaskBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""SERVIDOR-BD"";packet size=4096;integrated security=SSPI;data sourc" & _
            "e=""SERVIDOR-BD"";persist security info=False;initial catalog=planilla"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "rubros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("formula", "formula")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""SERVIDOR-BD"";packet size=4096;integrated security=SSPI;data sourc" & _
            "e=""SERVIDOR-BD"";persist security info=False;initial catalog=planilla"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO rubros(nombre, categoria, formula) VALUES (@nombre, @categoria, @form" & _
            "ula); SELECT id_rubro, nombre, categoria, formula FROM rubros WHERE (id_rubro = " & _
            "@@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"), New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_rubro, nombre, categoria, formula FROM rubros"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"), New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula"), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id, id_rubro, valor, minimo, maximo FROM dbo.tabla_valores"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO dbo.tabla_valores(id_rubro, valor, minimo, maximo) VALUES (@id_rubro," & _
            " @valor, @minimo, @maximo); SELECT id, id_rubro, valor, minimo, maximo FROM dbo." & _
            "tabla_valores WHERE (id = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tabla_valores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("valor", "valor"), New System.Data.Common.DataColumnMapping("minimo", "minimo"), New System.Data.Common.DataColumnMapping("maximo", "maximo")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Inserta"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Eliminar"
        '
        'XpTaskPanel1
        '
        Me.XpTaskPanel1.AutoScroll = True
        Me.XpTaskPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskPanel1.Controls.Add(Me.XpTaskBox1)
        Me.XpTaskPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.XpTaskPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpTaskPanel1.Name = "XpTaskPanel1"
        Me.XpTaskPanel1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.XpTaskPanel1.Size = New System.Drawing.Size(192, 229)
        Me.XpTaskPanel1.TabIndex = 1
        Me.XpTaskPanel1.ThemeFormat.BottomColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.XpTaskPanel1.ThemeFormat.TopColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(210, Byte), Integer))
        '
        'XpTaskBox1
        '
        Me.XpTaskBox1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskBox1.Controls.Add(Me.ListBox1)
        Me.XpTaskBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpTaskBox1.HeaderText = "Rubros"
        Me.XpTaskBox1.Location = New System.Drawing.Point(8, 0)
        Me.XpTaskBox1.Name = "XpTaskBox1"
        Me.XpTaskBox1.Padding = New System.Windows.Forms.Padding(4, 44, 4, 4)
        Me.XpTaskBox1.Size = New System.Drawing.Size(176, 216)
        Me.XpTaskBox1.TabIndex = 1
        Me.XpTaskBox1.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.XpTaskBox1.ThemeFormat.BodyFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XpTaskBox1.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.XpTaskBox1.ThemeFormat.BorderColor = System.Drawing.Color.White
        Me.XpTaskBox1.ThemeFormat.ChevronDown = CType(resources.GetObject("resource.ChevronDown"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronDownHighlight = CType(resources.GetObject("resource.ChevronDownHighlight"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronUp = CType(resources.GetObject("resource.ChevronUp"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronUpHighlight = CType(resources.GetObject("resource.ChevronUpHighlight"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XpTaskBox1.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.XpTaskBox1.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XpTaskBox1.ThemeFormat.LeftHeaderColor = System.Drawing.Color.White
        Me.XpTaskBox1.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(240, Byte), Integer))
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DsPlanilla1.rubros
        Me.ListBox1.DisplayMember = "nombre"
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Location = New System.Drawing.Point(4, 44)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 160)
        Me.ListBox1.TabIndex = 0
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(195, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(213, 32)
        Me.UserControl21.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(192, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 229)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(195, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 197)
        Me.Panel1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "rubros.formula", True))
        Me.TextBox2.Location = New System.Drawing.Point(72, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Formula"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DsPlanilla1, "rubros.categoria", True))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"Ingreso", "Deducción"})
        Me.ComboBox1.Location = New System.Drawing.Point(72, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Categoria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "rubros.nombre", True))
        Me.TextBox1.Location = New System.Drawing.Point(72, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmRubros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 229)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.XpTaskPanel1)
        Me.Name = "frmRubros"
        Me.Text = "Rubros"
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XpTaskPanel1.ResumeLayout(False)
        Me.XpTaskBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private Sub frmRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.UserControl21.ButtonItem4.Visible = False
            Me.UserControl21.ButtonItem5.Visible = False
            Me.UserControl21.ButtonItem6.Visible = False

            conn.bd = "planilla"
            Me.SqlConnection1.ConnectionString = conn.strConn
            cargarDatos()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub cargarDatos()
        Me.ListBox1.DataSource = Nothing
        Me.ListBox1.DisplayMember = ""

        Me.BindingContext(DsPlanilla1, "rubros").EndCurrentEdit()
        Me.SqlDataAdapter1.Update(Me.DsPlanilla1.rubros)

        Me.DsPlanilla1.rubros.Clear()
        Me.SqlDataAdapter1.Fill(DsPlanilla1.rubros)

        Me.ListBox1.DataSource = DsPlanilla1.rubros
        Me.ListBox1.DisplayMember = "nombre"
    End Sub


    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        rnuevo = True
    End Sub

    Public Sub nuevo()
        Me.ListBox1.DataSource = Nothing
        Me.ListBox1.DisplayMember = ""

        Me.BindingContext(DsPlanilla1.rubros).AddNew()
        Me.ComboBox1.SelectedIndex = 0

        Me.TextBox1.Focus()
        Me.controlesActivo(True)
    End Sub

    Public Sub guardar()
        Try
            cargarDatos()
            
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
        End Try
    End Sub

    Public Sub borrar()

        Me.BindingContext(DsPlanilla1, "rubros").RemoveAt(Me.BindingContext(DsPlanilla1.rubros).Position)
        Me.ComboBox1.SelectedIndex = 0

        cargarDatos()

        Me.TextBox1.Focus()
        Me.controlesActivo(True)
    End Sub

    Sub controlesActivo(ByVal estado As Boolean)
        Me.TextBox1.Enabled = estado
        Me.ComboBox1.Enabled = estado

        Me.UserControl21.ButtonItem1.Enabled = estado
        Me.UserControl21.ButtonItem2.Enabled = estado
        Me.UserControl21.ButtonItem3.Enabled = estado
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
    
            If Me.ListBox1.SelectedIndex >= 0 Then
                Me.BindingContext(DsPlanilla1.rubros).EndCurrentEdit()
                Me.BindingContext(DsPlanilla1.rubros).Position = Me.ListBox1.SelectedIndex
                Me.controlesActivo(True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
