Imports System.Data.SqlClient

Public Class frmMaterias
    Inherits System.Windows.Forms.Form
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
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsMaterias1 = New colegio.dsMaterias
        Me.UserControl21 = New colegio.UserControl2
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar
        Me.ExplorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.ExplorerBarGroupItem2 = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem
        Me.ControlContainerItem4 = New DevComponents.DotNetBar.ControlContainerItem
        Me.ControlContainerItem5 = New DevComponents.DotNetBar.ControlContainerItem
        CType(Me.DsMaterias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExplorerBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
            "_BD;persist security info=True;initial catalog=colegio;password=123"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT materia, nombre FROM materia WHERE (materia NOT IN (SELECT materia FROM ma" & _
            "terias_nivel WHERE (nivel = @nivel))) ORDER BY materia"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.NVarChar)})
        '
        'DsMaterias1
        '
        Me.DsMaterias1.DataSetName = "dsMaterias"
        Me.DsMaterias1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsMaterias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(161, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(429, 34)
        Me.UserControl21.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DsMaterias1.materia
        Me.ListBox1.DisplayMember = "nombre"
        Me.ListBox1.Location = New System.Drawing.Point(180, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(175, 303)
        Me.ListBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsMaterias1, "materia.nombre", True))
        Me.TextBox2.Location = New System.Drawing.Point(10, 158)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsMaterias1, "materia.materia", True))
        Me.TextBox1.Location = New System.Drawing.Point(10, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código Materia"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre Materia"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DsMaterias1.niveles
        Me.ComboBox1.DisplayMember = "nivel"
        Me.ComboBox1.Location = New System.Drawing.Point(10, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.DsMaterias1.materias_nivel
        Me.ListBox2.DisplayMember = "nombre"
        Me.ListBox2.Location = New System.Drawing.Point(397, 52)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(175, 303)
        Me.ListBox2.TabIndex = 6
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "niveles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("ciclo", "ciclo"), New System.Data.Common.DataColumnMapping("cobros", "cobros"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO niveles(nivel, ciclo, cobros, descripcion) VALUES (@nivel, @ciclo, @c" & _
            "obros, @descripcion); SELECT nivel, ciclo, cobros, descripcion FROM niveles WHER" & _
            "E (nivel = @nivel)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT nivel, ciclo, cobros, descripcion FROM niveles"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(359, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(357, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materias_nivel", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        Me.SqlSelectCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel")})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "INSERT INTO materias_nivel (nivel, materia, lecciones) VALUES (@nivel, @materia, " & _
            "@lecciones)"
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@lecciones", System.Data.SqlDbType.TinyInt, 1, "lecciones")})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "DELETE FROM materias_nivel WHERE (nivel = @nivel) AND (materia = @materia)"
        Me.SqlCommand2.Connection = Me.SqlConnection1
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "materia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM materia WHERE (materia = @Original_materia) AND (nombre = @Original_n" & _
            "ombre OR @Original_nombre IS NULL AND nombre IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
            "_BD;persist security info=False;initial catalog=colegio"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO materia(materia, nombre) VALUES (@materia, @nombre); SELECT materia, " & _
            "nombre FROM materia WHERE (materia = @materia) ORDER BY materia"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT materia, nombre FROM materia ORDER BY materia"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@Original_materia", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "materia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.BackColorGradientAngle = 270
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(180, 29)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(144, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Materias"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.BackColorGradientAngle = 270
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(394, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(144, 23)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX2.TabIndex = 11
        Me.LabelX2.Text = "Asignadas"
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ExplorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ExplorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2
        Me.ExplorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.ExplorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground
        Me.ExplorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBar1.Controls.Add(Me.ComboBox1)
        Me.ExplorerBar1.Controls.Add(Me.Label1)
        Me.ExplorerBar1.Controls.Add(Me.TextBox1)
        Me.ExplorerBar1.Controls.Add(Me.Label2)
        Me.ExplorerBar1.Controls.Add(Me.TextBox2)
        Me.ExplorerBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExplorerBar1.GroupImages = Nothing
        Me.ExplorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ExplorerBarGroupItem1, Me.ExplorerBarGroupItem2})
        Me.ExplorerBar1.Images = Nothing
        Me.ExplorerBar1.Location = New System.Drawing.Point(0, 0)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(161, 367)
        Me.ExplorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBar1.TabIndex = 12
        Me.ExplorerBar1.Text = "ExplorerBar1"
        '
        'ExplorerBarGroupItem1
        '
        '
        '
        '
        Me.ExplorerBarGroupItem1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottomColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeftColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderRightColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderTopColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderTopWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItem1.Expanded = True
        Me.ExplorerBarGroupItem1.Name = "ExplorerBarGroupItem1"
        Me.ExplorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem1})
        Me.ExplorerBarGroupItem1.Text = "Nivel"
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.SystemColors.InactiveCaption
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExplorerBarGroupItem1.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.SystemColors.ControlText
        '
        'ExplorerBarGroupItem2
        '
        '
        '
        '
        Me.ExplorerBarGroupItem2.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExplorerBarGroupItem2.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem2.BackStyle.BorderBottomColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem2.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItem2.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem2.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem2.BackStyle.BorderLeftColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem2.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItem2.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem2.BackStyle.BorderRightColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem2.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItem2.BackStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem2.BackStyle.BorderTopColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem2.BackStyle.BorderTopWidth = 1
        Me.ExplorerBarGroupItem2.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItem2.Expanded = True
        Me.ExplorerBarGroupItem2.Name = "ExplorerBarGroupItem2"
        Me.ExplorerBarGroupItem2.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem2, Me.ControlContainerItem3, Me.ControlContainerItem4, Me.ControlContainerItem5})
        Me.ExplorerBarGroupItem2.Text = "Materia"
        '
        '
        '
        Me.ExplorerBarGroupItem2.TitleHotStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem2.TitleHotStyle.BackColor2 = System.Drawing.SystemColors.InactiveCaption
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleHotStyle.TextColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.ExplorerBarGroupItem2.TitleStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem2.TitleStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExplorerBarGroupItem2.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem2.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem2.TitleStyle.TextColor = System.Drawing.SystemColors.ControlText
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = True
        Me.ControlContainerItem1.Control = Me.ComboBox1
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        Me.ControlContainerItem1.Text = "ControlContainerItem1"
        '
        'ControlContainerItem2
        '
        Me.ControlContainerItem2.AllowItemResize = True
        Me.ControlContainerItem2.Control = Me.Label1
        Me.ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem2.Name = "ControlContainerItem2"
        Me.ControlContainerItem2.Text = "ControlContainerItem2"
        '
        'ControlContainerItem3
        '
        Me.ControlContainerItem3.AllowItemResize = True
        Me.ControlContainerItem3.Control = Me.TextBox1
        Me.ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem3.Name = "ControlContainerItem3"
        Me.ControlContainerItem3.Text = "ControlContainerItem3"
        '
        'ControlContainerItem4
        '
        Me.ControlContainerItem4.AllowItemResize = True
        Me.ControlContainerItem4.Control = Me.Label2
        Me.ControlContainerItem4.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem4.Name = "ControlContainerItem4"
        Me.ControlContainerItem4.Text = "ControlContainerItem4"
        '
        'ControlContainerItem5
        '
        Me.ControlContainerItem5.AllowItemResize = True
        Me.ControlContainerItem5.Control = Me.TextBox2
        Me.ControlContainerItem5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem5.Name = "ControlContainerItem5"
        Me.ControlContainerItem5.Text = "ControlContainerItem5"
        '
        'frmMaterias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(590, 367)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.ExplorerBar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMaterias"
        Me.Text = "Materias"
        CType(Me.DsMaterias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExplorerBar1.ResumeLayout(False)
        Me.ExplorerBar1.PerformLayout()
        Me.ResumeLayout(False)

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
            Me.BindingContext(DsMaterias1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsMaterias1, Me.bd).AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Public Sub guardar()
        Try
            Me.BindingContext(DsMaterias1, Me.bd).EndCurrentEdit()
            SqlDataAdapter1.Update(DsMaterias1, Me.bd)
            DsMaterias1.AcceptChanges()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Ocurrió un error")
        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales

            Dim Registro As Integer
            Registro = Me.BindingContext(DsMaterias1, Me.bd).Position
            Me.BindingContext(DsMaterias1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsMaterias1, Me.bd).RemoveAt(Registro)
            Me.SqlDataAdapter1.Update(DsMaterias1, Me.bd)
            Me.BindingContext(DsMaterias1, Me.bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            Me.BindingContext(DsMaterias1, Me.bd).EndCurrentEdit()
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
                Me.BindingContext(DsMaterias1, Me.bd).Position = prmPos
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

        Dim conn As New conexionSQL
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlConnection2.ConnectionString = conn.strConn

        Me.SqlDataAdapter2.Fill(DsMaterias1, "niveles")

        Me.SqlDataAdapter1.InsertCommand = Me.SqlDataAdapter4.InsertCommand
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDataAdapter4.DeleteCommand
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlDataAdapter4.UpdateCommand

        Me.UserControl21.Buscar.Visible = False
        Me.UserControl21.Imprimir.Visible = False
    End Sub

    Private Sub frmMaterias_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.guardar()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        'Me.guardar()
        Me.BindingContext(DsMaterias1, Me.bd).Position = ListBox1.SelectedIndex

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            If Me.ComboBox1.Text <> "" And ListBox1.SelectedItems.Count > 0 Then
                Me.SqlConnection1.Open()

                Dim valor1 As DataRowView
                For Each valor1 In ListBox1.SelectedItems
                    Me.SqlCommand1.Parameters.Item("@nivel").Value = ComboBox1.Text
                    Me.SqlCommand1.Parameters.Item("@materia").Value = valor1("materia")

                    Me.SqlCommand1.Parameters.Item("@lecciones").Value = InputBox("Cantidad de Lecciones para " & valor1("nombre"), valor1("nombre"), "1")
                    Dim myReader As Integer = SqlCommand1.ExecuteNonQuery
                Next
                Me.SqlConnection1.Close()
            End If
            Me.ActualizaListbox()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Me.ComboBox1.Text <> "" And ListBox2.SelectedItems.Count > 0 Then
            Me.SqlConnection1.Open()

            Dim valor1 As DataRowView
            For Each valor1 In ListBox2.SelectedItems
                Me.SqlCommand2.Parameters.Item("@nivel").Value = ComboBox1.Text
                Me.SqlCommand2.Parameters.Item("@materia").Value = valor1("materia")

                Dim myReader As Integer = SqlCommand2.ExecuteNonQuery
            Next
            Me.SqlConnection1.Close()
        End If
        Me.ActualizaListbox()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.ActualizaListbox()
    End Sub

    Sub ActualizaListbox()
        Try
            DsMaterias1.Tables("materia").Clear()
            DsMaterias1.Tables("materias_nivel").Clear()

            Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@nivel").Value = ComboBox1.Text
            Me.SqlDataAdapter1.Fill(DsMaterias1, "materia")

            Me.SqlDataAdapter3.SelectCommand.Parameters.Item("@nivel").Value = ComboBox1.Text
            Me.SqlDataAdapter3.Fill(DsMaterias1, "materias_nivel")

            ListBox1.ClearSelected()
            ListBox2.ClearSelected()

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmMaterias_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.guardar()
    End Sub
End Class
