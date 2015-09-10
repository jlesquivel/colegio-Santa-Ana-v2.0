
Public Class frmMatriculaV
     Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim dvLista As DataView
    Dim carnet As String
    Friend WithEvents ExplorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents ExplorerBarGroupItem1 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ExplorerBarGroupItem2 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ExplorerBarGroupItem3 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem


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
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents busca As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSet11 As colegio.DataSet1
    Friend WithEvents CMatricula1 As colegio.CMatricula
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Estudiantes1 As colegio.Estudiantes
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMatriculaV))
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        ListBox1 = New System.Windows.Forms.ListBox
        DataSet11 = New colegio.DataSet1
        ComboBox1 = New System.Windows.Forms.ComboBox
        NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        busca = New System.Data.SqlClient.SqlCommand
        CMatricula1 = New colegio.CMatricula
        Estudiantes1 = New colegio.Estudiantes
        ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar
        ExplorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem
        ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem
        ExplorerBarGroupItem2 = New DevComponents.DotNetBar.ExplorerBarGroupItem
        ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem
        ExplorerBarGroupItem3 = New DevComponents.DotNetBar.ExplorerBarGroupItem
        ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem
        CType(DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        ExplorerBar1.SuspendLayout()
        SuspendLayout()
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 30, "apellido1"), New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 30, "apellido2"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@encargado1", System.Data.SqlDbType.VarChar, 50, "encargado1"), New System.Data.SqlClient.SqlParameter("@relacion", System.Data.SqlDbType.VarChar, 10, "relacion"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@trabajo", System.Data.SqlDbType.VarChar, 50, "trabajo"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"), New System.Data.SqlClient.SqlParameter("@encargado2", System.Data.SqlDbType.VarChar, 50, "encargado2"), New System.Data.SqlClient.SqlParameter("@relacion2", System.Data.SqlDbType.VarChar, 10, "relacion2"), New System.Data.SqlClient.SqlParameter("@direccion2", System.Data.SqlDbType.VarChar, 50, "direccion2"), New System.Data.SqlClient.SqlParameter("@trabajo2", System.Data.SqlDbType.VarChar, 50, "trabajo2"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.VarChar, 10, "telefono2"), New System.Data.SqlClient.SqlParameter("@email2", System.Data.SqlDbType.VarChar, 50, "email2"), New System.Data.SqlClient.SqlParameter("@foto", System.Data.SqlDbType.VarBinary, 2147483647, "foto"), New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 10, "estado"), New System.Data.SqlClient.SqlParameter("@familia", System.Data.SqlDbType.VarChar, 40, "familia"), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 11, "cedula")})
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" & _
            "scritorio;persist security info=False;initial catalog=colegio"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand1
        SqlDataAdapter1.InsertCommand = SqlInsertCommand1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "estudiantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("apellido1", "apellido1"), New System.Data.Common.DataColumnMapping("apellido2", "apellido2"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("encargado1", "encargado1"), New System.Data.Common.DataColumnMapping("relacion", "relacion"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("trabajo", "trabajo"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("encargado2", "encargado2"), New System.Data.Common.DataColumnMapping("relacion2", "relacion2"), New System.Data.Common.DataColumnMapping("direccion2", "direccion2"), New System.Data.Common.DataColumnMapping("trabajo2", "trabajo2"), New System.Data.Common.DataColumnMapping("telefono2", "telefono2"), New System.Data.Common.DataColumnMapping("email2", "email2"), New System.Data.Common.DataColumnMapping("foto", "foto"), New System.Data.Common.DataColumnMapping("estado", "estado"), New System.Data.Common.DataColumnMapping("familia", "familia"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cedula", "cedula")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido1", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido2", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_email2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_encargado1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_encargado2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_familia", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "familia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_relacion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_relacion2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_trabajo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_trabajo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        SqlSelectCommand1.Connection = SqlConnection1
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 30, "apellido1"), New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 30, "apellido2"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"), New System.Data.SqlClient.SqlParameter("@encargado1", System.Data.SqlDbType.VarChar, 50, "encargado1"), New System.Data.SqlClient.SqlParameter("@relacion", System.Data.SqlDbType.VarChar, 10, "relacion"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"), New System.Data.SqlClient.SqlParameter("@trabajo", System.Data.SqlDbType.VarChar, 50, "trabajo"), New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"), New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"), New System.Data.SqlClient.SqlParameter("@encargado2", System.Data.SqlDbType.VarChar, 50, "encargado2"), New System.Data.SqlClient.SqlParameter("@relacion2", System.Data.SqlDbType.VarChar, 10, "relacion2"), New System.Data.SqlClient.SqlParameter("@direccion2", System.Data.SqlDbType.VarChar, 50, "direccion2"), New System.Data.SqlClient.SqlParameter("@trabajo2", System.Data.SqlDbType.VarChar, 50, "trabajo2"), New System.Data.SqlClient.SqlParameter("@telefono2", System.Data.SqlDbType.VarChar, 10, "telefono2"), New System.Data.SqlClient.SqlParameter("@email2", System.Data.SqlDbType.VarChar, 50, "email2"), New System.Data.SqlClient.SqlParameter("@foto", System.Data.SqlDbType.VarBinary, 2147483647, "foto"), New System.Data.SqlClient.SqlParameter("@estado", System.Data.SqlDbType.VarChar, 10, "estado"), New System.Data.SqlClient.SqlParameter("@familia", System.Data.SqlDbType.VarChar, 40, "familia"), New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 11, "cedula"), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido1", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_apellido2", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellido2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_email2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_encargado1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_encargado2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "encargado2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_estado", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_familia", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "familia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_relacion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_relacion2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "relacion2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono2", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_trabajo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_trabajo2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "trabajo2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ListBox1
        '
        ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DataSet11, "estud.carnet", True))
        ListBox1.DataSource = DataSet11.estud
        ListBox1.DisplayMember = "nombre"
        ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListBox1.Location = New System.Drawing.Point(10, 303)
        ListBox1.MultiColumn = True
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New System.Drawing.Size(174, 121)
        ListBox1.TabIndex = 0
        ListBox1.ValueMember = "carnet"
        '
        'DataSet11
        '
        DataSet11.DataSetName = "DataSet1"
        DataSet11.Locale = New System.Globalization.CultureInfo("es-CR")
        DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        ComboBox1.DataSource = DataSet11.TApellidos
        ComboBox1.DisplayMember = "apellidos"
        ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComboBox1.Location = New System.Drawing.Point(10, 92)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(174, 168)
        ComboBox1.TabIndex = 0
        '
        'NumericUpDown1
        '
        NumericUpDown1.Location = New System.Drawing.Point(10, 29)
        NumericUpDown1.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New System.Drawing.Size(174, 20)
        NumericUpDown1.TabIndex = 0
        NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        NumericUpDown1.Value = New Decimal(New Integer() {2010, 0, 0, 0})
        '
        'SqlDataAdapter2
        '
        SqlDataAdapter2.SelectCommand = SqlSelectCommand2
        SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Table", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("apellidos", "apellidos")})})
        '
        'SqlSelectCommand2
        '
        SqlSelectCommand2.CommandText = "SELECT DISTINCT apellido1 + ' ' + apellido2 AS apellidos FROM estudiantes ORDER B" & _
            "Y apellido1 + ' ' + apellido2"
        SqlSelectCommand2.Connection = SqlConnection1
        '
        'busca
        '
        busca.CommandText = "SELECT DISTINCT apellido1 + ' ' + apellido2 AS apellidos, nombre, carnet FROM est" & _
            "udiantes WHERE (apellido1 + ' ' + apellido2 = @apellidos)"
        busca.Connection = SqlConnection1
        busca.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar)})
        '
        'CMatricula1
        '
        CMatricula1.BackColor = System.Drawing.SystemColors.Control
        CMatricula1.Location = New System.Drawing.Point(207, -1)
        CMatricula1.Name = "CMatricula1"
        CMatricula1.Size = New System.Drawing.Size(501, 169)
        CMatricula1.TabIndex = 1
        '
        'Estudiantes1
        '
        Estudiantes1.BuscarVisible = False
        Estudiantes1.Location = New System.Drawing.Point(200, 168)
        Estudiantes1.Name = "Estudiantes1"
        Estudiantes1.Size = New System.Drawing.Size(508, 316)
        Estudiantes1.TabIndex = 2
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
        ExplorerBar1.Controls.Add(NumericUpDown1)
        ExplorerBar1.Controls.Add(ComboBox1)
        ExplorerBar1.Controls.Add(ListBox1)
        ExplorerBar1.Dock = System.Windows.Forms.DockStyle.Left
        ExplorerBar1.GroupImages = Nothing
        ExplorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {ExplorerBarGroupItem1, ExplorerBarGroupItem2, ExplorerBarGroupItem3})
        ExplorerBar1.Images = Nothing
        ExplorerBar1.Location = New System.Drawing.Point(0, 0)
        ExplorerBar1.Name = "ExplorerBar1"
        ExplorerBar1.Size = New System.Drawing.Size(194, 485)
        ExplorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        ExplorerBar1.TabIndex = 3
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
        ExplorerBarGroupItem1.Text = "Año"
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
        ControlContainerItem1.Control = NumericUpDown1
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
        ExplorerBarGroupItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {ControlContainerItem2})
        ExplorerBarGroupItem2.Text = "Familia"
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
        ControlContainerItem2.Control = ComboBox1
        ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        ControlContainerItem2.Name = "ControlContainerItem2"
        ControlContainerItem2.Text = "ControlContainerItem2"
        '
        'ExplorerBarGroupItem3
        '
        '
        '
        '
        ExplorerBarGroupItem3.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem3.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem3.BackStyle.BorderBottomWidth = 1
        ExplorerBarGroupItem3.BackStyle.BorderColor = System.Drawing.Color.White
        ExplorerBarGroupItem3.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem3.BackStyle.BorderLeftWidth = 1
        ExplorerBarGroupItem3.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        ExplorerBarGroupItem3.BackStyle.BorderRightWidth = 1
        ExplorerBarGroupItem3.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem3.Cursor = System.Windows.Forms.Cursors.Default
        ExplorerBarGroupItem3.Expanded = True
        ExplorerBarGroupItem3.Name = "ExplorerBarGroupItem3"
        ExplorerBarGroupItem3.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        ExplorerBarGroupItem3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {ControlContainerItem3})
        ExplorerBarGroupItem3.Text = "Estudiantes"
        '
        '
        '
        ExplorerBarGroupItem3.TitleHotStyle.BackColor = System.Drawing.Color.White
        ExplorerBarGroupItem3.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem3.TitleHotStyle.CornerDiameter = 3
        ExplorerBarGroupItem3.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem3.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem3.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem3.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        ExplorerBarGroupItem3.TitleStyle.BackColor = System.Drawing.Color.White
        ExplorerBarGroupItem3.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        ExplorerBarGroupItem3.TitleStyle.CornerDiameter = 3
        ExplorerBarGroupItem3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        ExplorerBarGroupItem3.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem3.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        ExplorerBarGroupItem3.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ControlContainerItem3
        '
        ControlContainerItem3.AllowItemResize = True
        ControlContainerItem3.Control = ListBox1
        ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        ControlContainerItem3.Name = "ControlContainerItem3"
        ControlContainerItem3.Text = "ControlContainerItem3"
        '
        'frmMatriculaV
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(715, 485)
        Controls.Add(ExplorerBar1)
        Controls.Add(Estudiantes1)
        Controls.Add(CMatricula1)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Name = "frmMatriculaV"
        Text = "Matricula Regulares"
        CType(DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        ExplorerBar1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMatriculaV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New conexionSQL
        If Now.Month <= 8 Then
            NumericUpDown1.Text = Now.Year
        Else
            NumericUpDown1.Text = Now.Year + 1
        End If
        SqlConnection1.ConnectionString = conn.strConn
        DataSet11.Tables("TApellidos").Clear()
        SqlDataAdapter2.Fill(DataSet11, "TApellidos")
        BindingContext(DataSet11, "TApellidos").EndCurrentEdit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim tempo As SqlClient.SqlCommand = SqlDataAdapter2.SelectCommand

        DataSet11.Tables("estud").Clear()
        busca.Parameters.Item("@apellidos").Value = ComboBox1.Text
        SqlDataAdapter2.SelectCommand = busca
        Dim RES As Int16 = SqlDataAdapter2.Fill(DataSet11, "estud")
        BindingContext(DataSet11, "estud").EndCurrentEdit()

        SqlDataAdapter2.SelectCommand = tempo
        ListBox1.Enabled = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        CMatricula1.BackColor = System.Drawing.SystemColors.Control

        If ListBox1.SelectedIndex >= 0 Then
            carnet = ListBox1.SelectedValue
            Estudiantes1.buscar(carnet)
            Select Case Estudiantes1.ComboBox3.Text
                Case "TRASLADADO", "REPROBADO", "EXPULSADO"
                    MessageBox.Show("Estudiante " & Estudiantes1.ComboBox3.Text, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case Else
                    Dim cestado As CEstadoCuenta = Estudiantes1.CEstadoCuenta1
                    If cestado.pendiente Then
                        CMatricula1.BackColor = System.Drawing.Color.MistyRose
                    End If
                    CMatricula1.Enabled = True
                    CMatricula1.buscar(carnet, NumericUpDown1.Text)
            End Select
        End If
    End Sub

    Private Sub CMatricula1_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMatricula1.EnabledChanged
        If CMatricula1.Enabled = False Then
            ListBox1.Enabled = False
        End If

    End Sub
End Class
