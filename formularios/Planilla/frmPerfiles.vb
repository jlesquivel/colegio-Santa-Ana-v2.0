Public Class frmPerfiles
    Inherits System.Windows.Forms.Form
    Dim conn As New conexionSQL
    Dim rnuevo As Boolean
    Dim indices As Integer()
    Dim bd As String = "rubros"
    Dim clista As New CargarLista
    Dim id_perfil As Integer

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
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPlanilla1 As colegio.dsPlanilla
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TreeViewSQL1 As colegio.TreeViewSQL
    Friend WithEvents XpTaskPanel1 As SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XpTaskBox1 As SteepValley.Windows.Forms.ThemedControls.XPTaskBox
    Friend WithEvents XpTaskBoxSpecial1 As SteepValley.Windows.Forms.ThemedControls.XPTaskBoxSpecial
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel_Rubros As System.Windows.Forms.Panel
    Friend WithEvents Panel_Perfiles As System.Windows.Forms.Panel
    Friend WithEvents Lbl_perfil As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfiles))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perfiles")
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsPlanilla1 = New colegio.dsPlanilla
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TreeViewSQL1 = New colegio.TreeViewSQL
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.XpTaskPanel1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskPanel
        Me.XpTaskBoxSpecial1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskBoxSpecial
        Me.XpTaskBox1 = New SteepValley.Windows.Forms.ThemedControls.XPTaskBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.UserControl21 = New colegio.UserControl2
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel_Rubros = New System.Windows.Forms.Panel
        Me.Panel_Perfiles = New System.Windows.Forms.Panel
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Lbl_perfil = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XpTaskPanel1.SuspendLayout()
        Me.XpTaskBoxSpecial1.SuspendLayout()
        Me.XpTaskBox1.SuspendLayout()
        Me.Panel_Rubros.SuspendLayout()
        Me.Panel_Perfiles.SuspendLayout()
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
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO rubros(nombre, categoria, formula) VALUES (@nombre, @categoria, @form" & _
            "ula); SELECT id_rubro, nombre, categoria, formula FROM rubros WHERE (id_rubro = " & _
            "@@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"), New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_rubro, nombre, categoria, formula FROM rubros"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"), New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula"), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tabla_valores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("valor", "valor"), New System.Data.Common.DataColumnMapping("minimo", "minimo"), New System.Data.Common.DataColumnMapping("maximo", "maximo")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO tabla_valores(id_rubro, valor, minimo, maximo) VALUES (@id_rubro, @va" & _
            "lor, @minimo, @maximo); SELECT id, id_rubro, valor, minimo, maximo FROM tabla_va" & _
            "lores WHERE (id = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id, id_rubro, valor, minimo, maximo FROM tabla_valores"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_maximo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "maximo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_minimo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "minimo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_valor", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "valor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT nombre FROM perfil_rubros"
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
        'TreeViewSQL1
        '
        Me.TreeViewSQL1.ContextMenu = Me.ContextMenu1
        Me.TreeViewSQL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewSQL1.Etiquetas = "Perfiles,,"
        Me.TreeViewSQL1.ImageIndex = 0
        Me.TreeViewSQL1.ImageList = Me.ImageList1
        Me.TreeViewSQL1.InstruccionSQL = Me.SqlCommand1
        Me.TreeViewSQL1.Location = New System.Drawing.Point(4, 44)
        Me.TreeViewSQL1.Name = "TreeViewSQL1"
        TreeNode1.Name = ""
        TreeNode1.Text = "Perfiles"
        Me.TreeViewSQL1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeViewSQL1.SelectedImageIndex = 0
        Me.TreeViewSQL1.Size = New System.Drawing.Size(206, 139)
        Me.TreeViewSQL1.TabIndex = 0
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
        Me.XpTaskPanel1.Controls.Add(Me.XpTaskBoxSpecial1)
        Me.XpTaskPanel1.Controls.Add(Me.XpTaskBox1)
        Me.XpTaskPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.XpTaskPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpTaskPanel1.Name = "XpTaskPanel1"
        Me.XpTaskPanel1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.XpTaskPanel1.Size = New System.Drawing.Size(230, 374)
        Me.XpTaskPanel1.TabIndex = 1
        Me.XpTaskPanel1.ThemeFormat.BottomColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.XpTaskPanel1.ThemeFormat.TopColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(210, Byte), Integer))
        '
        'XpTaskBoxSpecial1
        '
        Me.XpTaskBoxSpecial1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskBoxSpecial1.Controls.Add(Me.TreeViewSQL1)
        Me.XpTaskBoxSpecial1.Dock = System.Windows.Forms.DockStyle.Top
        Me.XpTaskBoxSpecial1.HeaderText = "Perfiles"
        Me.XpTaskBoxSpecial1.Location = New System.Drawing.Point(8, 173)
        Me.XpTaskBoxSpecial1.Name = "XpTaskBoxSpecial1"
        Me.XpTaskBoxSpecial1.Padding = New System.Windows.Forms.Padding(4, 44, 4, 4)
        Me.XpTaskBoxSpecial1.Size = New System.Drawing.Size(214, 187)
        Me.XpTaskBoxSpecial1.TabIndex = 2
        Me.XpTaskBoxSpecial1.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XpTaskBoxSpecial1.ThemeFormat.BodyFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XpTaskBoxSpecial1.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.XpTaskBoxSpecial1.ThemeFormat.BorderColor = System.Drawing.Color.White
        Me.XpTaskBoxSpecial1.ThemeFormat.ChevronDown = CType(resources.GetObject("resource.ChevronDown"), System.Drawing.Bitmap)
        Me.XpTaskBoxSpecial1.ThemeFormat.ChevronDownHighlight = CType(resources.GetObject("resource.ChevronDownHighlight"), System.Drawing.Bitmap)
        Me.XpTaskBoxSpecial1.ThemeFormat.ChevronUp = CType(resources.GetObject("resource.ChevronUp"), System.Drawing.Bitmap)
        Me.XpTaskBoxSpecial1.ThemeFormat.ChevronUpHighlight = CType(resources.GetObject("resource.ChevronUpHighlight"), System.Drawing.Bitmap)
        Me.XpTaskBoxSpecial1.ThemeFormat.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XpTaskBoxSpecial1.ThemeFormat.HeaderTextColor = System.Drawing.Color.White
        Me.XpTaskBoxSpecial1.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XpTaskBoxSpecial1.ThemeFormat.LeftHeaderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.XpTaskBoxSpecial1.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(197, Byte), Integer))
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
        Me.XpTaskBox1.Size = New System.Drawing.Size(214, 173)
        Me.XpTaskBox1.TabIndex = 1
        Me.XpTaskBox1.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.XpTaskBox1.ThemeFormat.BodyFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XpTaskBox1.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.XpTaskBox1.ThemeFormat.BorderColor = System.Drawing.Color.White
        Me.XpTaskBox1.ThemeFormat.ChevronDown = CType(resources.GetObject("resource.ChevronDown1"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronDownHighlight = CType(resources.GetObject("resource.ChevronDownHighlight1"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronUp = CType(resources.GetObject("resource.ChevronUp1"), System.Drawing.Bitmap)
        Me.XpTaskBox1.ThemeFormat.ChevronUpHighlight = CType(resources.GetObject("resource.ChevronUpHighlight1"), System.Drawing.Bitmap)
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
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(4, 44)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(206, 116)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "id_rubro"
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(234, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(259, 37)
        Me.UserControl21.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(230, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 374)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'Panel_Rubros
        '
        Me.Panel_Rubros.Controls.Add(Me.Panel_Perfiles)
        Me.Panel_Rubros.Controls.Add(Me.Label3)
        Me.Panel_Rubros.Controls.Add(Me.Label4)
        Me.Panel_Rubros.Controls.Add(Me.ComboBox2)
        Me.Panel_Rubros.Controls.Add(Me.TextBox1)
        Me.Panel_Rubros.Controls.Add(Me.Label1)
        Me.Panel_Rubros.Controls.Add(Me.TextBox2)
        Me.Panel_Rubros.Controls.Add(Me.Label2)
        Me.Panel_Rubros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Rubros.Location = New System.Drawing.Point(234, 37)
        Me.Panel_Rubros.Name = "Panel_Rubros"
        Me.Panel_Rubros.Size = New System.Drawing.Size(259, 337)
        Me.Panel_Rubros.TabIndex = 4
        '
        'Panel_Perfiles
        '
        Me.Panel_Perfiles.Controls.Add(Me.CheckedListBox1)
        Me.Panel_Perfiles.Controls.Add(Me.Lbl_perfil)
        Me.Panel_Perfiles.Location = New System.Drawing.Point(29, 148)
        Me.Panel_Perfiles.Name = "Panel_Perfiles"
        Me.Panel_Perfiles.Size = New System.Drawing.Size(173, 184)
        Me.Panel_Perfiles.TabIndex = 22
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBox1.Location = New System.Drawing.Point(0, 28)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(173, 140)
        Me.CheckedListBox1.TabIndex = 1
        '
        'Lbl_perfil
        '
        Me.Lbl_perfil.BackColor = System.Drawing.SystemColors.Desktop
        Me.Lbl_perfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_perfil.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_perfil.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_perfil.Name = "Lbl_perfil"
        Me.Lbl_perfil.Size = New System.Drawing.Size(173, 28)
        Me.Lbl_perfil.TabIndex = 0
        Me.Lbl_perfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Categoria"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 27)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fórmula"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DsPlanilla1, "rubros.categoria", True))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Items.AddRange(New Object() {"Ingreso", "Deducción"})
        Me.ComboBox2.Location = New System.Drawing.Point(83, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(125, 24)
        Me.ComboBox2.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "rubros.nombre", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(83, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 22)
        Me.TextBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 26)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "rubros.formula", True))
        Me.TextBox2.Location = New System.Drawing.Point(83, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(163, 22)
        Me.TextBox2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(29, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 27)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Variables "
        '
        'frmPerfiles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(493, 374)
        Me.Controls.Add(Me.Panel_Rubros)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.XpTaskPanel1)
        Me.Name = "frmPerfiles"
        Me.Text = "Perfiles"
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XpTaskPanel1.ResumeLayout(False)
        Me.XpTaskBoxSpecial1.ResumeLayout(False)
        Me.XpTaskBox1.ResumeLayout(False)
        Me.Panel_Rubros.ResumeLayout(False)
        Me.Panel_Rubros.PerformLayout()
        Me.Panel_Perfiles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.UserControl21.ButtonItem1.Enabled = False
            Me.UserControl21.ButtonItem2.Enabled = False
            Me.UserControl21.ButtonItem3.Enabled = False

            Me.UserControl21.ButtonItem4.Visible = False
            Me.UserControl21.ButtonItem5.Visible = False
            Me.UserControl21.ButtonItem6.Visible = False

            conn.bd = "planilla"
            Me.SqlConnection1.ConnectionString = conn.strConn
            Me.TreeViewSQL1.llenar("planilla")
            Me.SqlDataAdapter1.Fill(DsPlanilla1, "rubros")
            clista.DatosLista(DsPlanilla1.Tables("rubros"), Me.CheckedListBox1, "id_rubro", "nombre")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.TreeViewSQL1.LabelEdit = True
        Dim nuevo_nodo As TreeNode = Me.TreeViewSQL1.Nodes.Item(0).Nodes.Add("")
        nuevo_nodo.ImageIndex = 1
        Me.TreeViewSQL1.Nodes.Item(0).Expand()
        nuevo_nodo.Checked = True
        nuevo_nodo.BeginEdit()
        rnuevo = True
    End Sub

    Private Sub TreeViewSQL1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewSQL1.AfterSelect
        Me.controlesActivo(False)
        If e.Node.FullPath.Split("\").Length = 2 Then
            Dim cmd As String
            Dim tabla As ArrayList
            cmd = "select * from perfil_rubros where nombre= '" & e.Node.Text & "'"
            tabla = conn.llena(cmd)
            id_perfil = tabla(0)(0)

            Dim ds As New DataSet
            conn.llena(ds, "tabla1", "select * from rubros_perfil where id = " & id_perfil)
            Dim dvLista As DataView = ds.Tables("tabla1").DefaultView
            clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)

            Me.Lbl_perfil.Text = e.Node.Text
        Else
            Me.UserControl21.ButtonItem1.Enabled = False
            Me.UserControl21.ButtonItem2.Enabled = False
            Me.UserControl21.ButtonItem3.Enabled = False
        End If
    End Sub

    Private Sub TreeViewSQL1_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeViewSQL1.BeforeSelect
        If Me.CheckedListBox1.CheckedItems.Count > 0 Then
            Me.guarda_rubros(id_perfil)
        End If
    End Sub

    Private Sub guarda_rubros(ByVal id_perfil As Integer)
        Dim inst As String
        conn.ejecuta("delete rubros_perfil where id=" & id_perfil)
        For Each pos As Object In Me.CheckedListBox1.CheckedItems
            inst = "insert rubros_perfil values(" & id_perfil & "," & pos.codigo & ")"
            conn.ejecuta(inst)
        Next
    End Sub

    Private Sub TreeViewSQL1_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeViewSQL1.AfterLabelEdit
        If rnuevo Then
            Dim inst As String = "insert perfil_rubros(nombre) values('" & e.Label & "')"
            conn.ejecuta(inst)
            rnuevo = False
            Me.TreeViewSQL1.LabelEdit = False
        End If
    End Sub

    Public Sub nuevo()
        Me.ListBox1.DataSource = Nothing
        Me.ListBox1.DisplayMember = ""

        Me.BindingContext(DsPlanilla1, "rubros").AddNew()
        Me.ComboBox2.SelectedIndex = 0

        Me.TextBox1.Focus()
        Me.controlesActivo(True)
    End Sub

    Public Sub guardar()
        Try
            cargarDatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub borrar()
        Me.BindingContext(DsPlanilla1, "rubros").RemoveAt(Me.BindingContext(DsPlanilla1, "rubros").Position)
        Me.ComboBox2.SelectedIndex = 0

        cargarDatos()

        Me.TextBox1.Focus()
        Me.controlesActivo(True)
    End Sub

    Sub controlesActivo(ByVal estado As Boolean)
        Me.TextBox1.Enabled = estado
        Me.ComboBox2.Enabled = estado
        Me.Panel_Perfiles.Visible = Not estado
        Me.Panel_Perfiles.Dock = DockStyle.Fill

        Me.UserControl21.ButtonItem1.Enabled = estado
        Me.UserControl21.ButtonItem2.Enabled = estado
        Me.UserControl21.ButtonItem3.Enabled = estado
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Me.ListBox1.SelectedIndex >= 0 Then
            Me.BindingContext(DsPlanilla1, Me.bd).EndCurrentEdit()
            If Me.BindingContext(DsPlanilla1, Me.bd).Position <> ListBox1.SelectedIndex Then
                Me.BindingContext(DsPlanilla1, Me.bd).Position = ListBox1.SelectedIndex
            End If
            Me.controlesActivo(True)
            Me.TextBox1.Focus()
        End If
    End Sub

    Sub cargarDatos()
        Me.ListBox1.DataSource = Nothing
        Me.ListBox1.DisplayMember = ""

        Me.BindingContext(DsPlanilla1, "rubros").EndCurrentEdit()
        Me.SqlDataAdapter1.Update(Me.DsPlanilla1.rubros)

        Me.DsPlanilla1.rubros.Clear()
        Me.SqlDataAdapter1.Fill(DsPlanilla1, "rubros")

        Me.ListBox1.DataSource = DsPlanilla1.rubros
        Me.ListBox1.DisplayMember = "nombre"
    End Sub
End Class
