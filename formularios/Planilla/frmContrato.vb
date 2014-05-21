Public Class frmContrato

    Inherits System.Windows.Forms.Form

    Dim id_emp, id_pto As String
    Dim id_contrato As String
    Dim borra As Boolean
    Dim conn As New conexionSQL
    Dim nuevor As Boolean = True
    Dim clista As New CargarLista
    Dim cargado As Boolean = False  ' para saber que no es la primera vez


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByVal pptos As String, ByVal pid_emp As String, ByVal pborra As Boolean)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        id_emp = pid_emp
        id_pto = pptos
        borra = pborra
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
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents TabControl1 As TD.SandDock.TabControl
    Friend WithEvents TabPage1 As TD.SandDock.TabPage
    Friend WithEvents TabPage2 As TD.SandDock.TabPage
    Friend WithEvents Ds2planilla1 As colegio.ds2planilla
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As TD.SandDock.TabPage
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents sexo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BorraPuesto As System.Data.SqlClient.SqlCommand
    Friend WithEvents Puestos As System.Data.SqlClient.SqlCommand
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TabPage4 As TD.SandDock.TabPage
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MonedaTextBox1 As colegio.MonedaTextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Contratos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DvContratos As System.Data.DataView
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContrato))
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.UserControl21 = New colegio.UserControl2
        Me.TabControl1 = New TD.SandDock.TabControl
        Me.TabPage1 = New TD.SandDock.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.sexo = New System.Windows.Forms.TextBox
        Me.Ds2planilla1 = New colegio.ds2planilla
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TabPage3 = New TD.SandDock.TabPage
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TabPage2 = New TD.SandDock.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TabPage4 = New TD.SandDock.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.MonedaTextBox1 = New colegio.MonedaTextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DvContratos = New System.Data.DataView
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.BorraPuesto = New System.Data.SqlClient.SqlCommand
        Me.Puestos = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Contratos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.SqlDataAdapter6 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("cedula", "cedula"), New System.Data.Common.DataColumnMapping("apellidos", "apellidos"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("nacimiento", "nacimiento"), New System.Data.Common.DataColumnMapping("cuenta", "cuenta"), New System.Data.Common.DataColumnMapping("ingreso", "ingreso"), New System.Data.Common.DataColumnMapping("banco", "banco"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("celular", "celular"), New System.Data.Common.DataColumnMapping("sexo", "sexo"), New System.Data.Common.DataColumnMapping("anualidadReconocida", "anualidadReconocida")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM empleados WHERE (id_emp = @Original_id_emp) AND (anualidadReconocida " & _
        "= @Original_anualidadReconocida OR @Original_anualidadReconocida IS NULL AND anu" & _
        "alidadReconocida IS NULL) AND (apellidos = @Original_apellidos) AND (banco = @Or" & _
        "iginal_banco) AND (categoria = @Original_categoria OR @Original_categoria IS NUL" & _
        "L AND categoria IS NULL) AND (cedula = @Original_cedula) AND (celular = @Origina" & _
        "l_celular OR @Original_celular IS NULL AND celular IS NULL) AND (cuenta = @Origi" & _
        "nal_cuenta) AND (direccion = @Original_direccion OR @Original_direccion IS NULL " & _
        "AND direccion IS NULL) AND (ingreso = @Original_ingreso OR @Original_ingreso IS " & _
        "NULL AND ingreso IS NULL) AND (nacimiento = @Original_nacimiento) AND (nombre = " & _
        "@Original_nombre) AND (sexo = @Original_sexo) AND (telefono = @Original_telefono" & _
        " OR @Original_telefono IS NULL AND telefono IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""SERVIDOR-BD"";packet size=4096;integrated security=SSPI;data sourc" & _
        "e=""SERVIDOR-BD"";persist security info=False;initial catalog=planilla"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO empleados(cedula, apellidos, nombre, categoria, nacimiento, cuenta, i" & _
        "ngreso, banco, direccion, telefono, celular, sexo, anualidadReconocida) VALUES (" & _
        "@cedula, @apellidos, @nombre, @categoria, @nacimiento, @cuenta, @ingreso, @banco" & _
        ", @direccion, @telefono, @celular, @sexo, @anualidadReconocida); SELECT id_emp, " & _
        "cedula, apellidos, nombre, categoria, nacimiento, cuenta, ingreso, banco, direcc" & _
        "ion, telefono, celular, sexo, anualidadReconocida FROM empleados WHERE (id_emp =" & _
        " @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_emp, cedula, apellidos, nombre, categoria, nacimiento, cuenta, ingreso," & _
        " banco, direccion, telefono, celular, sexo, anualidadReconocida FROM empleados W" & _
        "HERE (id_emp = @id_emp)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE empleados SET cedula = @cedula, apellidos = @apellidos, nombre = @nombre, " & _
        "categoria = @categoria, nacimiento = @nacimiento, cuenta = @cuenta, ingreso = @i" & _
        "ngreso, banco = @banco, direccion = @direccion, telefono = @telefono, celular = " & _
        "@celular, sexo = @sexo, anualidadReconocida = @anualidadReconocida WHERE (id_emp" & _
        " = @Original_id_emp) AND (anualidadReconocida = @Original_anualidadReconocida OR" & _
        " @Original_anualidadReconocida IS NULL AND anualidadReconocida IS NULL) AND (ape" & _
        "llidos = @Original_apellidos) AND (banco = @Original_banco) AND (categoria = @Or" & _
        "iginal_categoria OR @Original_categoria IS NULL AND categoria IS NULL) AND (cedu" & _
        "la = @Original_cedula) AND (celular = @Original_celular OR @Original_celular IS " & _
        "NULL AND celular IS NULL) AND (cuenta = @Original_cuenta) AND (direccion = @Orig" & _
        "inal_direccion OR @Original_direccion IS NULL AND direccion IS NULL) AND (ingres" & _
        "o = @Original_ingreso OR @Original_ingreso IS NULL AND ingreso IS NULL) AND (nac" & _
        "imiento = @Original_nacimiento) AND (nombre = @Original_nombre) AND (sexo = @Ori" & _
        "ginal_sexo) AND (telefono = @Original_telefono OR @Original_telefono IS NULL AND" & _
        " telefono IS NULL); SELECT id_emp, cedula, apellidos, nombre, categoria, nacimie" & _
        "nto, cuenta, ingreso, banco, direccion, telefono, celular, sexo, anualidadRecono" & _
        "cida FROM empleados WHERE (id_emp = @id_emp)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 20, "cedula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@apellidos", System.Data.SqlDbType.VarChar, 30, "apellidos"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nacimiento", System.Data.SqlDbType.DateTime, 8, "nacimiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cuenta", System.Data.SqlDbType.VarChar, 30, "cuenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ingreso", System.Data.SqlDbType.DateTime, 8, "ingreso"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@banco", System.Data.SqlDbType.VarChar, 15, "banco"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 50, "direccion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar, 10, "telefono"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@celular", System.Data.SqlDbType.VarChar, 10, "celular"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sexo", System.Data.SqlDbType.TinyInt, 1, "sexo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, "anualidadReconocida"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anualidadReconocida", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidadReconocida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_apellidos", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "apellidos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_banco", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "banco", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_celular", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "celular", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cuenta", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sexo", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sexo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing))
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(0, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(432, 32)
        Me.UserControl21.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Renderer = New TD.SandDock.Rendering.WhidbeyRenderer
        Me.TabControl1.Size = New System.Drawing.Size(432, 284)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.sexo)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(424, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Nacimiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Banco"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cuenta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nombre"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellidos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cédula"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 56)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'RadioButton2
        '
        Me.RadioButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton2.Location = New System.Drawing.Point(3, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Femenino"
        '
        'RadioButton1
        '
        Me.RadioButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioButton1.Location = New System.Drawing.Point(3, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Masculino"
        '
        'sexo
        '
        Me.sexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.sexo"))
        Me.sexo.Location = New System.Drawing.Point(8, 184)
        Me.sexo.Name = "sexo"
        Me.sexo.TabIndex = 9
        Me.sexo.Text = ""
        Me.sexo.Visible = False
        '
        'Ds2planilla1
        '
        Me.Ds2planilla1.DataSetName = "ds2planilla"
        Me.Ds2planilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.banco"))
        Me.TextBox5.Location = New System.Drawing.Point(80, 128)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(128, 20)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "TEXTBOX5"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.nacimiento"))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 152)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.cuenta"))
        Me.TextBox4.Location = New System.Drawing.Point(80, 101)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 20)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "TextBox4"
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.nombre"))
        Me.TextBox3.Location = New System.Drawing.Point(80, 78)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "TEXTBOX3"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.apellidos"))
        Me.TextBox2.Location = New System.Drawing.Point(80, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "TEXTBOX2"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.cedula"))
        Me.TextBox1.Location = New System.Drawing.Point(80, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "TextBox1"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(424, 256)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Localización"
        Me.TabPage3.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(32, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Dirección"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(32, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Celular"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(32, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Teléfono"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.direccion"))
        Me.TextBox8.Location = New System.Drawing.Point(104, 96)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(184, 80)
        Me.TextBox8.TabIndex = 2
        Me.TextBox8.Text = "TextBox8"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.celular"))
        Me.TextBox7.Location = New System.Drawing.Point(104, 64)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(136, 20)
        Me.TextBox7.TabIndex = 1
        Me.TextBox7.Text = "TextBox7"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.telefono"))
        Me.TextBox6.Location = New System.Drawing.Point(104, 32)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(136, 20)
        Me.TextBox6.TabIndex = 0
        Me.TextBox6.Text = "TextBox6"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.CheckedListBox1)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.NumericUpDown1)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(424, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Puesto"
        Me.TabPage2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(242, 8)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(152, 244)
        Me.CheckedListBox1.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 32)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Perfiles de rebajos"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(192, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Rubros"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(88, 112)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(104, 134)
        Me.ListBox1.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Anualidad Reconocidas"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(88, 72)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown1.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha Ingreso"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Categoria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.ingreso"))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(88, 40)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Ds2planilla1, "empleados.categoria"))
        Me.ComboBox1.DataSource = Me.Ds2planilla1.categorias
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.Location = New System.Drawing.Point(88, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.ValueMember = "id_cat"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.DataGrid1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(424, 256)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Contratos"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(16, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Nuevo Contrato"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.MonedaTextBox1)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(192, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 218)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contratar"
        Me.GroupBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(112, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Contratar"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Ds2planilla1, "empleados.categoria"))
        Me.ComboBox3.DataSource = Me.Ds2planilla1.categorias
        Me.ComboBox3.DisplayMember = "nombre"
        Me.ComboBox3.Location = New System.Drawing.Point(120, 184)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox3.TabIndex = 27
        Me.ComboBox3.ValueMember = "id_cat"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker4.Location = New System.Drawing.Point(112, 56)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker4.TabIndex = 1
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker3.Location = New System.Drawing.Point(112, 88)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker3.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Horas o lecciones "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(32, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Fecha Fin"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(40, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Puesto"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(32, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Fecha Inicio"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.Ds2planilla1.categorias
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.Location = New System.Drawing.Point(112, 152)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.ValueMember = "id_cat"
        '
        'MonedaTextBox1
        '
        Me.MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Numero
        Me.MonedaTextBox1.Location = New System.Drawing.Point(112, 120)
        Me.MonedaTextBox1.Name = "MonedaTextBox1"
        Me.MonedaTextBox1.Size = New System.Drawing.Size(88, 20)
        Me.MonedaTextBox1.TabIndex = 3
        Me.MonedaTextBox1.Text = "0,00"
        Me.MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(32, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Categoria"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ds2planilla1, "empleados.categoria"))
        Me.TextBox9.Location = New System.Drawing.Point(112, 24)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(88, 20)
        Me.TextBox9.TabIndex = 0
        Me.TextBox9.Text = ""
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGrid1.CaptionBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGrid1.CaptionText = "Contratos"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DvContratos
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RowHeaderWidth = 20
        Me.DataGrid1.Size = New System.Drawing.Size(392, 216)
        Me.DataGrid1.TabIndex = 15
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DvContratos
        '
        Me.DvContratos.AllowEdit = False
        Me.DvContratos.AllowNew = False
        Me.DvContratos.Table = Me.Ds2planilla1.contratos
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "contratos"
        Me.DataGridTableStyle1.RowHeaderWidth = 20
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Contrato"
        Me.DataGridTextBoxColumn1.MappingName = "id_contrato"
        Me.DataGridTextBoxColumn1.Width = 35
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Inicio"
        Me.DataGridTextBoxColumn2.MappingName = "fecha_ini"
        Me.DataGridTextBoxColumn2.Width = 65
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "fin"
        Me.DataGridTextBoxColumn3.MappingName = "fecha_fin"
        Me.DataGridTextBoxColumn3.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridTextBoxColumn4.MappingName = "cantidad"
        Me.DataGridTextBoxColumn4.Width = 40
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Categoria"
        Me.DataGridTextBoxColumn5.MappingName = "NombCat"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Vigente"
        Me.DataGridTextBoxColumn6.MappingName = "DiasVigente"
        Me.DataGridTextBoxColumn6.Width = 50
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "categorias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_cat", "id_cat"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("salario_base", "salario_base"), New System.Data.Common.DataColumnMapping("anualidad", "anualidad")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM categorias WHERE (id_cat = @Original_id_cat) AND (anualidad = @Origin" & _
        "al_anualidad) AND (nombre = @Original_nombre) AND (salario_base = @Original_sala" & _
        "rio_base)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cat", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anualidad", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_salario_base", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "salario_base", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO categorias(nombre, salario_base, anualidad) VALUES (@nombre, @salario" & _
        "_base, @anualidad); SELECT id_cat, nombre, salario_base, anualidad FROM categori" & _
        "as WHERE (id_cat = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 8, "salario_base"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 8, "anualidad"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_cat, nombre, salario_base, anualidad FROM categorias"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE categorias SET nombre = @nombre, salario_base = @salario_base, anualidad =" & _
        " @anualidad WHERE (id_cat = @Original_id_cat) AND (anualidad = @Original_anualid" & _
        "ad) AND (nombre = @Original_nombre) AND (salario_base = @Original_salario_base);" & _
        " SELECT id_cat, nombre, salario_base, anualidad FROM categorias WHERE (id_cat = " & _
        "@id_cat)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@salario_base", System.Data.SqlDbType.Money, 8, "salario_base"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@anualidad", System.Data.SqlDbType.Money, 8, "anualidad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cat", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_anualidad", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anualidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_salario_base", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "salario_base", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_cat", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cat", System.Data.DataRowVersion.Current, Nothing))
        '
        'BorraPuesto
        '
        Me.BorraPuesto.CommandText = "DELETE FROM puesto_empleado WHERE (id_puesto = @id_puesto) AND (id_emp = @id_emp)" & _
        ""
        Me.BorraPuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.BorraPuesto.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing))
        '
        'Puestos
        '
        Me.Puestos.CommandText = "SELECT COUNT(id_puesto) AS Expr1 FROM puesto_empleado GROUP BY id_emp HAVING (id_" & _
        "emp = @id_emp)"
        Me.Puestos.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDataAdapter3
        '
        Me.SqlDataAdapter3.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter3.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter3.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "rubros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("categoria", "categoria"), New System.Data.Common.DataColumnMapping("formula", "formula")})})
        Me.SqlDataAdapter3.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDataAdapter4
        '
        Me.SqlDataAdapter4.DeleteCommand = Me.SqlDeleteCommand4
        Me.SqlDataAdapter4.InsertCommand = Me.SqlInsertCommand4
        Me.SqlDataAdapter4.SelectCommand = Me.SqlSelectCommand4
        Me.SqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "perfil_rubros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.SqlDataAdapter4.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM perfil_rubros WHERE (id = @Original_id) AND (nombre = @Original_nombr" & _
        "e)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO perfil_rubros(nombre) VALUES (@nombre); SELECT id, nombre FROM perfil" & _
        "_rubros WHERE (id = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id, nombre FROM perfil_rubros"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE perfil_rubros SET nombre = @nombre WHERE (id = @Original_id) AND (nombre =" & _
        " @Original_nombre); SELECT id, nombre FROM perfil_rubros WHERE (id = @id)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 50, "nombre"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDataAdapter5
        '
        Me.SqlDataAdapter5.DeleteCommand = Me.SqlDeleteCommand5
        Me.SqlDataAdapter5.InsertCommand = Me.SqlInsertCommand5
        Me.SqlDataAdapter5.SelectCommand = Me.SqlSelectCommand5
        Me.SqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "empleado_rubro", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("id_rubro", "id_rubro"), New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato")})})
        Me.SqlDataAdapter5.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM empleado_rubro WHERE (id = @Original_id) AND (id_contrato = @Original" & _
        "_id_contrato) AND (id_rubro = @Original_id_rubro)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO empleado_rubro(id_rubro, id_contrato) VALUES (@id_rubro, @id_contrato" & _
        "); SELECT id, id_rubro, id_contrato FROM empleado_rubro WHERE (id = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection2
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id, id_rubro, id_contrato FROM empleado_rubro WHERE (id_contrato = @id_con" & _
        "trato)"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection2
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE empleado_rubro SET id_rubro = @id_rubro, id_contrato = @id_contrato WHERE " & _
        "(id = @Original_id) AND (id_contrato = @Original_id_contrato) AND (id_rubro = @O" & _
        "riginal_id_rubro); SELECT id, id_rubro, id_contrato FROM empleado_rubro WHERE (i" & _
        "d = @id)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing))
        '
        'Contratos
        '
        Me.Contratos.SelectCommand = Me.SqlSelectCommand6
        Me.Contratos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "contratos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato"), New System.Data.Common.DataColumnMapping("fecha_ini", "fecha_ini"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("NombCat", "NombCat"), New System.Data.Common.DataColumnMapping("DiasVigente", "DiasVigente"), New System.Data.Common.DataColumnMapping("id_cat", "id_cat")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT contratos.id_contrato, contratos.fecha_ini, contratos.fecha_fin, contratos" & _
        ".cantidad, categorias.nombre AS NombCat, CASE WHEN fecha_fin IS NULL THEN '' WHE" & _
        "N datediff(day , getdate() , fecha_fin) > 0 THEN datediff(day , getdate() , fech" & _
        "a_fin) ELSE 0 END AS DiasVigente, categorias.id_cat FROM contratos INNER JOIN ca" & _
        "tegorias ON contratos.id_categoria = categorias.id_cat WHERE (contratos.id_emp =" & _
        " @id_emp) ORDER BY contratos.fecha_ini DESC"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection2
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SqlDataAdapter6
        '
        Me.SqlDataAdapter6.DeleteCommand = Me.SqlDeleteCommand6
        Me.SqlDataAdapter6.InsertCommand = Me.SqlInsertCommand6
        Me.SqlDataAdapter6.SelectCommand = Me.SqlSelectCommand7
        Me.SqlDataAdapter6.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "contratos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_puesto", "id_puesto"), New System.Data.Common.DataColumnMapping("id_emp", "id_emp"), New System.Data.Common.DataColumnMapping("fecha_ini", "fecha_ini"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("cantidad", "cantidad"), New System.Data.Common.DataColumnMapping("id_categoria", "id_categoria"), New System.Data.Common.DataColumnMapping("id_contrato", "id_contrato")})})
        Me.SqlDataAdapter6.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "[ContratoDelete]"
        Me.SqlDeleteCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "[ContratoInsert]"
        Me.SqlInsertCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlInsertCommand6.Connection = Me.SqlConnection2
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 4, "fecha_ini"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 4, "fecha_fin"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "[ContratoSelect]"
        Me.SqlSelectCommand7.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand7.Connection = Me.SqlConnection2
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "[ContratoUpdate]"
        Me.SqlUpdateCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_ini", System.Data.SqlDbType.DateTime, 4, "fecha_ini"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.DateTime, 4, "fecha_fin"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cantidad", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "cantidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_ini", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_ini", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_categoria", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_categoria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_emp", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_emp", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_contrato", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_contrato", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_rubro, nombre, categoria, formula FROM rubros"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO rubros(nombre, categoria, formula) VALUES (@nombre, @categoria, @form" & _
        "ula); SELECT id_rubro, nombre, categoria, formula FROM rubros WHERE (id_rubro = " & _
        "@@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection2
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE rubros SET nombre = @nombre, categoria = @categoria, formula = @formula WH" & _
        "ERE (id_rubro = @Original_id_rubro) AND (categoria = @Original_categoria) AND (f" & _
        "ormula = @Original_formula OR @Original_formula IS NULL AND formula IS NULL) AND" & _
        " (nombre = @Original_nombre); SELECT id_rubro, nombre, categoria, formula FROM r" & _
        "ubros WHERE (id_rubro = @id_rubro)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@categoria", System.Data.SqlDbType.VarChar, 15, "categoria"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@formula", System.Data.SqlDbType.VarChar, 100, "formula"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM rubros WHERE (id_rubro = @Original_id_rubro) AND (categoria = @Origin" & _
        "al_categoria) AND (formula = @Original_formula OR @Original_formula IS NULL AND " & _
        "formula IS NULL) AND (nombre = @Original_nombre)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_rubro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_rubro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_categoria", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "categoria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_formula", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "formula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmContrato
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 316)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.UserControl21)
        Me.Name = "frmContrato"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Ds2planilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmContrato_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.UserControl21.ButtonItem1.Visible = False
            Me.UserControl21.ButtonItem3.Visible = False
            Me.UserControl21.ButtonItem4.Visible = False
            Me.UserControl21.ButtonItem5.Visible = False
            Me.UserControl21.ButtonItem6.Visible = False

            conn.bd = "planilla"
            Me.SqlConnection2.ConnectionString = conn.strConn

            Me.SqlDataAdapter2.Fill(Ds2planilla1, "categorias")
            Me.SqlDataAdapter3.Fill(Ds2planilla1, "rubros")
            Me.SqlDataAdapter4.Fill(Ds2planilla1, "perfil_rubros")

            clista.DatosLista(Me.Ds2planilla1.Tables("perfil_rubros"), Me.ListBox1, "id", "nombre")
            clista.DatosLista(Me.Ds2planilla1.Tables("rubros"), Me.CheckedListBox1, "id_rubro", "nombre")
            cargado = True

            If id_emp = "" Then
                Me.BindingContext(Ds2planilla1, "empleados").CancelCurrentEdit()
                Me.BindingContext(Ds2planilla1, "empleados").AddNew()
                nuevor = True
                TextBox1.Focus()
            Else
                nuevor = False
                busca(id_emp)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub guardar()
        Try
            Dim nuevoReg As DataRowView = BindingContext(Ds2planilla1, "empleados").Current
            Me.BindingContext(Ds2planilla1, "empleados").EndCurrentEdit()
            Me.SqlDataAdapter1.Update(Ds2planilla1, "empleados")
            Me.SqlDataAdapter5.Update(Ds2planilla1, "empleado_rubro")

            If nuevor Then
                Me.id_emp = nuevoReg.Row.ItemArray(0)
                Dim inst As String = "insert contratos(id_puesto,id_emp) values(" & Me.id_pto & "," & Me.id_emp & ")"
                conn.ejecuta(inst)
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub busca(ByVal pvalor As String)
        Try
            Dim lista As ArrayList

            Me.Ds2planilla1.Tables("empleado_rubro").Clear()
            Me.Ds2planilla1.Tables("empleados").Clear()

            lista = conn.llena("select id_emp from contratos where id_contrato = " & pvalor)
            id_contrato = pvalor
            id_emp = lista(0)(0)

            Me.SqlDataAdapter1.SelectCommand.Parameters.Item("@id_emp").Value = id_emp
            Me.SqlDataAdapter5.SelectCommand.Parameters.Item("@id_contrato").Value = pvalor
            Me.SqlDataAdapter1.Fill(Ds2planilla1)
            Me.SqlDataAdapter5.Fill(Ds2planilla1)
            Me.Text = Me.TextBox2.Text & " " & Me.TextBox3.Text

            cargado = False
            Dim dvLista As DataView = Ds2planilla1.Tables("empleado_rubro").DefaultView
            clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)

            cargarContratos(id_emp)   ' carga los contratos
            cargado = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
   
    Private Sub sexo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sexo.TextChanged
        If sexo.Text = "0" Then
            Me.RadioButton1.Checked = True
        Else
            Me.RadioButton2.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.sexo.Text = IIf(RadioButton1.Checked, "0", "1")
    End Sub

    Private Sub TabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedPageChanged
        '*
        '*  Actuliza el checkedlistbox cuando entra al tab2 que lo contiene
        '*

        Select Case TabControl1.SelectedIndex
            Case 2
                cargado = False
                Dim dvLista As DataView = Ds2planilla1.Tables("empleado_rubro").DefaultView
                clista.MarcarLista(dvLista, Me.CheckedListBox1, 1)
                cargado = True
            Case 3

        End Select

    End Sub

    Private Sub cargarContratos(ByVal pid_emp As Integer)
        Me.Contratos.SelectCommand.Parameters("@id_emp").Value = pid_emp
        Me.Contratos.Fill(Me.Ds2planilla1, "contratos")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ' asigna los rubros de un PERFIL al empleado 
        Dim cmd As String = "exec crea_rubros_empleado " & id_contrato & "," & ListBox1.SelectedItem.codigo
        conn.ejecuta(cmd)
        busca(Me.id_contrato)

    End Sub

    Private Sub CheckedListBox1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        ' asigna una rubro personalizado para cada empleado 
        If cargado Then
            If e.NewValue = CheckState.Checked Then
                Dim inst As String
                inst = "insert empleado_rubro(id_contrato,id_rubro) values(" & Me.id_contrato & "," & Me.CheckedListBox1.Items(e.Index).codigo & ")"
                conn.ejecuta(inst)
            Else
                Dim inst As String
                inst = "delete from empleado_rubro  where id_contrato = " & Me.id_contrato & " and id_rubro = " & Me.CheckedListBox1.Items(e.Index).codigo
                conn.ejecuta(inst)
            End If
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim lista As ArrayList
        lista = conn.llena("select id_contrato from contratosActivos where id_emp = " & id_emp)

        If lista.Count = 0 Then
            If Me.GroupBox2.Visible = False Then
                Me.GroupBox2.Visible = True
                Me.DataGrid1.Enabled = False
            Else
                Me.GroupBox2.Visible = False
                Me.DataGrid1.Enabled = True
            End If
            'Me.GroupBox2.Location = Me.DataGrid1.Location

            Me.DateTimePicker4.Focus()
        Else
            MsgBox("Existe contrato vigente", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim lista As ArrayList
        lista = conn.llena("select fecha_ini, fecha_fin from contratos where id_contrato = " & id_contrato)
        If In_rango_fecha(lista, Me.DateTimePicker4.Value, DateTimePicker3.Value) Or validad_cantidad() Then
            MsgBox("Ya existe pagos en este rango " & vbCr & " ó no hay cantidad", MsgBoxStyle.Critical)
        Else
            conn.ejecuta("exec ContratoInsert " & id_pto & "," & id_emp & "," & Me.DateTimePicker4.Value & _
                        "," & DateTimePicker3.Value & "," & MonedaTextBox1.Text & "," & Me.ComboBox2.SelectedValue)

            Me.GroupBox2.Visible = False
            Me.DataGrid1.Enabled = True
        End If
    End Sub

    Private Sub GroupBox2_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox2.VisibleChanged
        Me.TextBox9.Text = ComboBox3.Text
    End Sub

    Function In_rango_fecha(ByVal lista As ArrayList, ByVal fini As Date, ByVal ffin As Date) As Boolean

        Dim bien As Boolean = False
        Dim pos As Integer = lista.Count - 1
        Dim lini, lfin As Date

        While (Not bien) And (pos >= 0)
            lini = lista(pos)(0)
            lfin = lista(pos)(1)

            If fini >= lini And fini <= lfin Then
                bien = True
            End If
            If ffin >= lini And ffin <= lfin Then
                bien = True
            End If
            pos -= 1
        End While

        Return bien
    End Function

    Private Sub DateTimePicker4_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker4.ValueChanged
        Me.DateTimePicker3.Value = DateTimePicker4.Value
    End Sub

    Private Sub MonedaTextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MonedaTextBox1.Validating
        validad_cantidad()
    End Sub

    Function validad_cantidad() As Boolean
        If CInt(Me.MonedaTextBox1.Text) <= 0 Then
            ErrorProvider1.SetError(Me.MonedaTextBox1, "Debe tener un valor")
            Return True
        Else
            ErrorProvider1.SetError(Me.MonedaTextBox1, "")
            Return False
        End If
    End Function

    Private Sub DateTimePicker3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker3.Validating
        If DateTimePicker3.Value < DateTimePicker4.Value Then
            ErrorProvider1.SetError(Me.DateTimePicker3, "Fecha final deber ser mayor que la de inicio")
        Else
            ErrorProvider1.SetError(Me.DateTimePicker3, "")
        End If
    End Sub

End Class
