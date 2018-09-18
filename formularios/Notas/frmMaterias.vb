Imports System.Data.SqlClient

Public Class frmMaterias
     Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim bd As String = "materia"
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExplorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents ExplorerBarGroupItem1 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ExplorerBarGroupItem2 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem4 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem5 As DevComponents.DotNetBar.ControlContainerItem


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
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsMaterias1 As colegio.dsMaterias
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterias))
        SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        DsMaterias1 = New colegio.dsMaterias()
        UserControl21 = New colegio.UserControl2()
        ListBox1 = New System.Windows.Forms.ListBox()
        TextBox2 = New System.Windows.Forms.TextBox()
        TextBox1 = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        ListBox2 = New System.Windows.Forms.ListBox()
        SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        PictureBox2 = New System.Windows.Forms.PictureBox()
        SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlCommand2 = New System.Data.SqlClient.SqlCommand()
        SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        LabelX1 = New DevComponents.DotNetBar.LabelX()
        LabelX2 = New DevComponents.DotNetBar.LabelX()
        ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar()
        ExplorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        ExplorerBarGroupItem2 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        ControlContainerItem4 = New DevComponents.DotNetBar.ControlContainerItem()
        ControlContainerItem5 = New DevComponents.DotNetBar.ControlContainerItem()
        CType(DsMaterias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        ExplorerBar1.SuspendLayout()
        SuspendLayout()
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "Data Source=servidor-bd;Initial Catalog=colegio;User ID=sa;Password=123"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT materia, nombre FROM materia WHERE (materia NOT IN (SELECT materia FROM ma" & _
    "terias_nivel WHERE (nivel = @nivel))) ORDER BY materia"
        SqlSelectCommand1.Connection = SqlConnection1
        SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.NVarChar)})
        '
        'DsMaterias1
        '
        DsMaterias1.DataSetName = "dsMaterias"
        DsMaterias1.Locale = New System.Globalization.CultureInfo("es-CR")
        DsMaterias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserControl21
        '
        UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        UserControl21.Location = New System.Drawing.Point(161, 0)
        UserControl21.Name = "UserControl21"
        UserControl21.Size = New System.Drawing.Size(429, 34)
        UserControl21.TabIndex = 0
        '
        'ListBox1
        '
        ListBox1.DataSource = DsMaterias1.materia
        ListBox1.DisplayMember = "nombre"
        ListBox1.Location = New System.Drawing.Point(180, 52)
        ListBox1.Name = "ListBox1"
        ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        ListBox1.Size = New System.Drawing.Size(175, 303)
        ListBox1.TabIndex = 2
        '
        'TextBox2
        '
        TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsMaterias1, "materia.nombre", True))
        TextBox2.Location = New System.Drawing.Point(10, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New System.Drawing.Size(141, 20)
        TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsMaterias1, "materia.materia", True))
        TextBox1.Location = New System.Drawing.Point(10, 114)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(141, 20)
        TextBox1.TabIndex = 0
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(10, 93)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(141, 19)
        Label1.TabIndex = 3
        Label1.Text = "Código Materia"
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(10, 136)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(141, 20)
        Label2.TabIndex = 4
        Label2.Text = "Nombre Materia"
        '
        'ComboBox1
        '
        ComboBox1.DataSource = DsMaterias1.niveles
        ComboBox1.DisplayMember = "nivel"
        ComboBox1.Location = New System.Drawing.Point(10, 29)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(141, 21)
        ComboBox1.TabIndex = 0
        '
        'ListBox2
        '
        ListBox2.DataSource = DsMaterias1.materias_nivel
        ListBox2.DisplayMember = "nombre"
        ListBox2.Location = New System.Drawing.Point(397, 52)
        ListBox2.Name = "ListBox2"
        ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        ListBox2.Size = New System.Drawing.Size(175, 303)
        ListBox2.TabIndex = 6
        '
        'SqlDataAdapter2
        '
        SqlDataAdapter2.DeleteCommand = SqlDeleteCommand2
        SqlDataAdapter2.InsertCommand = SqlInsertCommand2
        SqlDataAdapter2.SelectCommand = SqlSelectCommand2
        SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "niveles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("ciclo", "ciclo"), New System.Data.Common.DataColumnMapping("cobros", "cobros"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        SqlDataAdapter2.UpdateCommand = SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        SqlDeleteCommand2.Connection = SqlConnection1
        SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        SqlInsertCommand2.CommandText = "INSERT INTO niveles(nivel, ciclo, cobros, descripcion) VALUES (@nivel, @ciclo, @c" & _
    "obros, @descripcion); SELECT nivel, ciclo, cobros, descripcion FROM niveles WHER" & _
    "E (nivel = @nivel)"
        SqlInsertCommand2.Connection = SqlConnection1
        SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion")})
        '
        'SqlSelectCommand2
        '
        SqlSelectCommand2.CommandText = "SELECT nivel, ciclo, cobros, descripcion FROM niveles"
        SqlSelectCommand2.Connection = SqlConnection1
        '
        'SqlUpdateCommand2
        '
        SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        SqlUpdateCommand2.Connection = SqlConnection1
        SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'PictureBox1
        '
        PictureBox1.BackColor = System.Drawing.Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        PictureBox1.Location = New System.Drawing.Point(359, 93)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(35, 36)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        PictureBox2.BackColor = System.Drawing.Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        PictureBox2.Location = New System.Drawing.Point(357, 182)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(35, 36)
        PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        '
        'SqlDataAdapter3
        '
        SqlDataAdapter3.SelectCommand = SqlSelectCommand3
        SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materias_nivel", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlSelectCommand3
        '
        SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        SqlSelectCommand3.Connection = SqlConnection1
        SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel")})
        '
        'SqlCommand1
        '
        SqlCommand1.CommandText = "INSERT INTO materias_nivel (nivel, materia, lecciones) VALUES (@nivel, @materia, " & _
    "@lecciones)"
        SqlCommand1.Connection = SqlConnection1
        SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@lecciones", System.Data.SqlDbType.TinyInt, 1, "lecciones")})
        '
        'SqlCommand2
        '
        SqlCommand2.CommandText = "DELETE FROM materias_nivel WHERE (nivel = @nivel) AND (materia = @materia)"
        SqlCommand2.Connection = SqlConnection1
        SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter4
        '
        SqlDataAdapter4.DeleteCommand = SqlDeleteCommand1
        SqlDataAdapter4.InsertCommand = SqlInsertCommand1
        SqlDataAdapter4.SelectCommand = SqlSelectCommand4
        SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        SqlDataAdapter4.UpdateCommand = SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = "DELETE FROM materia WHERE (materia = @Original_materia) AND (nombre = @Original_n" & _
    "ombre OR @Original_nombre IS NULL AND nombre IS NULL)"
        SqlDeleteCommand1.Connection = SqlConnection2
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        SqlConnection2.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
    "_BD;persist security info=False;initial catalog=colegio"
        SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = "INSERT INTO materia(materia, nombre) VALUES (@materia, @nombre); SELECT materia, " & _
    "nombre FROM materia WHERE (materia = @materia) ORDER BY materia"
        SqlInsertCommand1.Connection = SqlConnection2
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlSelectCommand4
        '
        SqlSelectCommand4.CommandText = "SELECT materia, nombre FROM materia ORDER BY materia"
        SqlSelectCommand4.Connection = SqlConnection2
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection2
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'LabelX1
        '
        '
        '
        '
        LabelX1.BackgroundStyle.BackColorGradientAngle = 270
        LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        LabelX1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelX1.Location = New System.Drawing.Point(180, 29)
        LabelX1.Name = "LabelX1"
        LabelX1.Size = New System.Drawing.Size(144, 23)
        LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        LabelX1.TabIndex = 10
        LabelX1.Text = "Materias"
        '
        'LabelX2
        '
        '
        '
        '
        LabelX2.BackgroundStyle.BackColorGradientAngle = 270
        LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        LabelX2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelX2.Location = New System.Drawing.Point(394, 29)
        LabelX2.Name = "LabelX2"
        LabelX2.Size = New System.Drawing.Size(144, 23)
        LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        LabelX2.TabIndex = 11
        LabelX2.Text = "Asignadas"
        '
        'ExplorerBar1
        '
        ExplorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        ExplorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        ExplorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2
        ExplorerBar1.BackStyle.BackColorGradientAngle = 90
        ExplorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground
        ExplorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBar1.Controls.Add(ComboBox1)
        ExplorerBar1.Controls.Add(Label1)
        ExplorerBar1.Controls.Add(TextBox1)
        ExplorerBar1.Controls.Add(Label2)
        ExplorerBar1.Controls.Add(TextBox2)
        ExplorerBar1.Dock = System.Windows.Forms.DockStyle.Left
        ExplorerBar1.GroupImages = Nothing
        ExplorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {ExplorerBarGroupItem1, ExplorerBarGroupItem2})
        ExplorerBar1.Images = Nothing
        ExplorerBar1.Location = New System.Drawing.Point(0, 0)
        ExplorerBar1.Name = "ExplorerBar1"
        ExplorerBar1.Size = New System.Drawing.Size(161, 367)
        ExplorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        ExplorerBar1.TabIndex = 12
        ExplorerBar1.Text = "ExplorerBar1"
        '
        'ExplorerBarGroupItem1
        '
        '
        '
        '
        ExplorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem1.BackStyle.BorderBottomWidth = 1
        ExplorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White
        ExplorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem1.BackStyle.BorderLeftWidth = 1
        ExplorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem1.BackStyle.BorderRightWidth = 1
        ExplorerBarGroupItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default
        ExplorerBarGroupItem1.Expanded = True
        ExplorerBarGroupItem1.Name = "ExplorerBarGroupItem1"
        ExplorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        ExplorerBarGroupItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {ControlContainerItem1})
        ExplorerBarGroupItem1.Text = "Nivel"
        '
        '
        '
        ExplorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.White
        ExplorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3
        ExplorerBarGroupItem1.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        ExplorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.White
        ExplorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem1.TitleStyle.CornerDiameter = 3
        ExplorerBarGroupItem1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ControlContainerItem1
        '
        ControlContainerItem1.AllowItemResize = True
        ControlContainerItem1.Control = ComboBox1
        ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        ControlContainerItem1.Name = "ControlContainerItem1"
        ControlContainerItem1.Text = "ControlContainerItem1"
        '
        'ExplorerBarGroupItem2
        '
        '
        '
        '
        ExplorerBarGroupItem2.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem2.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem2.BackStyle.BorderBottomWidth = 1
        ExplorerBarGroupItem2.BackStyle.BorderColor = System.Drawing.Color.White
        ExplorerBarGroupItem2.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem2.BackStyle.BorderLeftWidth = 1
        ExplorerBarGroupItem2.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem2.BackStyle.BorderRightWidth = 1
        ExplorerBarGroupItem2.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem2.Cursor = System.Windows.Forms.Cursors.Default
        ExplorerBarGroupItem2.Expanded = True
        ExplorerBarGroupItem2.Name = "ExplorerBarGroupItem2"
        ExplorerBarGroupItem2.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        ExplorerBarGroupItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {ControlContainerItem2, ControlContainerItem3, ControlContainerItem4, ControlContainerItem5})
        ExplorerBarGroupItem2.Text = "Materia"
        '
        '
        '
        ExplorerBarGroupItem2.TitleHotStyle.BackColor = System.Drawing.Color.White
        ExplorerBarGroupItem2.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem2.TitleHotStyle.CornerDiameter = 3
        ExplorerBarGroupItem2.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem2.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem2.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem2.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        ExplorerBarGroupItem2.TitleStyle.BackColor = System.Drawing.Color.White
        ExplorerBarGroupItem2.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem2.TitleStyle.CornerDiameter = 3
        ExplorerBarGroupItem2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem2.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem2.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem2.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ControlContainerItem2
        '
        ControlContainerItem2.AllowItemResize = True
        ControlContainerItem2.Control = Label1
        ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        ControlContainerItem2.Name = "ControlContainerItem2"
        ControlContainerItem2.Text = "ControlContainerItem2"
        '
        'ControlContainerItem3
        '
        ControlContainerItem3.AllowItemResize = True
        ControlContainerItem3.Control = TextBox1
        ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        ControlContainerItem3.Name = "ControlContainerItem3"
        ControlContainerItem3.Text = "ControlContainerItem3"
        '
        'ControlContainerItem4
        '
        ControlContainerItem4.AllowItemResize = True
        ControlContainerItem4.Control = Label2
        ControlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        ControlContainerItem4.Name = "ControlContainerItem4"
        ControlContainerItem4.Text = "ControlContainerItem4"
        '
        'ControlContainerItem5
        '
        ControlContainerItem5.AllowItemResize = True
        ControlContainerItem5.Control = TextBox2
        ControlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        ControlContainerItem5.Name = "ControlContainerItem5"
        ControlContainerItem5.Text = "ControlContainerItem5"
        '
        'frmMaterias
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(590, 367)
        Controls.Add(UserControl21)
        Controls.Add(ExplorerBar1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(LabelX2)
        Controls.Add(ListBox2)
        Controls.Add(LabelX1)
        Controls.Add(ListBox1)
        DoubleBuffered = True
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "frmMaterias"
        Text = "Materias"
        CType(DsMaterias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        ExplorerBar1.ResumeLayout(False)
        ExplorerBar1.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region
    Public Sub nuevo()
        Try
            Dim i, x As Integer
            For i = 0 To Controls.Count - 1
                For x = 1 To Controls(i).Controls.Count - 1
                    If TypeOf Controls(i).Controls(x) Is TextBox Then
                        CType(Controls(i).Controls(x), TextBox).Text = ""
                    End If
                Next x
            Next i
            TextBox1.Focus()
            'Borrar las ediciones actuales
            BindingContext(DsMaterias1, bd).EndCurrentEdit()
            BindingContext(DsMaterias1, bd).AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Public Sub guardar()
        Try
            BindingContext(DsMaterias1, bd).EndCurrentEdit()
            SqlDataAdapter1.Update(DsMaterias1, bd)
            DsMaterias1.AcceptChanges()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Ocurrió un error")
        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales

            Dim Registro As Integer
            Registro = BindingContext(DsMaterias1, bd).Position
            BindingContext(DsMaterias1, bd).EndCurrentEdit()
            BindingContext(DsMaterias1, bd).RemoveAt(Registro)
            SqlDataAdapter1.Update(DsMaterias1, bd)
            BindingContext(DsMaterias1, bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            BindingContext(DsMaterias1, bd).EndCurrentEdit()
            Dim prmPos As Integer
            Dim dvCatClientes As DataView = _
            New DataView(DsMaterias1.Tables(0), "", "nivel", DataViewRowState.CurrentRows)
            Dim varID_CLIENTE As String = ""
            varID_CLIENTE = InputBox("Introduce el nivel a buscar", "Buscar")
            If Not varID_CLIENTE = "" Then
                prmPos = dvCatClientes.Find(varID_CLIENTE)
                If prmPos = -1 Then
                    MessageBox.Show("Materia no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                BindingContext(DsMaterias1, bd).Position = prmPos
                Exit Sub
            Else
                MessageBox.Show("La búsqueda no se puede realizar", _
                "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub frmMaterias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conn As New ConexionSQL
        SqlConnection1.ConnectionString = conn.strConn
        SqlConnection2.ConnectionString = conn.strConn

        DsMaterias1.niveles.Clear()
        SqlDataAdapter2.Fill(DsMaterias1, "niveles")

        SqlDataAdapter1.InsertCommand = SqlDataAdapter4.InsertCommand
        SqlDataAdapter1.DeleteCommand = SqlDataAdapter4.DeleteCommand
        SqlDataAdapter1.UpdateCommand = SqlDataAdapter4.UpdateCommand

        UserControl21.Buscar.Visible = False
        UserControl21.Imprimir.Visible = False
    End Sub

    Private Sub frmMaterias_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        guardar()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        'Me.guardar()
        BindingContext(DsMaterias1, bd).Position = ListBox1.SelectedIndex

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            If ComboBox1.Text <> "" And ListBox1.SelectedItems.Count > 0 Then
                SqlConnection1.Open()

                Dim valor1 As DataRowView
                For Each valor1 In ListBox1.SelectedItems
                    SqlCommand1.Parameters.Item("@nivel").Value = ComboBox1.Text
                    SqlCommand1.Parameters.Item("@materia").Value = valor1("materia")

                    SqlCommand1.Parameters.Item("@lecciones").Value = InputBox("Cantidad de Lecciones para " & valor1("nombre"), valor1("nombre"), "1")
                    Dim myReader As Integer = SqlCommand1.ExecuteNonQuery
                Next
                SqlConnection1.Close()
            End If
            ActualizaListbox()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If ComboBox1.Text <> "" And ListBox2.SelectedItems.Count > 0 Then
            SqlConnection1.Open()

            Dim valor1 As DataRowView
            For Each valor1 In ListBox2.SelectedItems
                SqlCommand2.Parameters.Item("@nivel").Value = ComboBox1.Text
                SqlCommand2.Parameters.Item("@materia").Value = valor1("materia")

                Dim myReader As Integer = SqlCommand2.ExecuteNonQuery
            Next
            SqlConnection1.Close()
        End If
        ActualizaListbox()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ActualizaListbox()
    End Sub

    Sub ActualizaListbox()
        Try
            DsMaterias1.Tables("materia").Clear()
            DsMaterias1.Tables("materias_nivel").Clear()

            SqlDataAdapter1.SelectCommand.Parameters.Item("@nivel").Value = ComboBox1.Text
            SqlDataAdapter1.Fill(DsMaterias1, "materia")

            SqlDataAdapter3.SelectCommand.Parameters.Item("@nivel").Value = ComboBox1.Text
            SqlDataAdapter3.Fill(DsMaterias1, "materias_nivel")

            ListBox1.ClearSelected()
            ListBox2.ClearSelected()

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmMaterias_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        guardar()
    End Sub
End Class
