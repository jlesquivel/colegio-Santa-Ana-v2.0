Public Class frmAusencias
    Inherits System.Windows.Forms.Form

    Dim afectadas As Integer
    Dim conn As New conexionSQL

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
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsNotas1 As colegio.dsNotas
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox3 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BuscaEstud1 As colegio.BuscaEstud
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents CheckedListBox4 As System.Windows.Forms.CheckedListBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAusencias))
        Me.DsNotas1 = New colegio.dsNotas
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataView1 = New System.Data.DataView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.UserControl21 = New colegio.UserControl2
        Me.BuscaEstud1 = New colegio.BuscaEstud
        CType(Me.DsNotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsNotas1
        '
        Me.DsNotas1.DataSetName = "dsNotas"
        Me.DsNotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsNotas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
            "_BD;persist security info=True;initial catalog=colegio;password=123"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ausencias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("leccion", "leccion"), New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("observacion", "observacion"), New System.Data.Common.DataColumnMapping("fecha_motivacion", "fecha_motivacion")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_motivacion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_motivacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_leccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "leccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observacion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"), New System.Data.SqlClient.SqlParameter("@leccion", System.Data.SqlDbType.VarChar, 2, "leccion"), New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.VarChar, 10, "tipo"), New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.VarChar, 50, "observacion"), New System.Data.SqlClient.SqlParameter("@fecha_motivacion", System.Data.SqlDbType.DateTime, 8, "fecha_motivacion")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id, carnet, fecha, leccion, tipo, observacion, fecha_motivacion FROM Ausen" & _
            "cias WHERE (carnet = @carnet) AND (fecha_motivacion IS NULL)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"), New System.Data.SqlClient.SqlParameter("@leccion", System.Data.SqlDbType.VarChar, 2, "leccion"), New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.VarChar, 10, "tipo"), New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.VarChar, 50, "observacion"), New System.Data.SqlClient.SqlParameter("@fecha_motivacion", System.Data.SqlDbType.DateTime, 8, "fecha_motivacion"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_motivacion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_motivacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_leccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "leccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observacion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ausencias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("leccion", "leccion"), New System.Data.Common.DataColumnMapping("tipo", "tipo"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("fecha", "fecha"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("observacion", "observacion"), New System.Data.Common.DataColumnMapping("fecha_motivacion", "fecha_motivacion")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_motivacion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_motivacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_leccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "leccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observacion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@leccion", System.Data.SqlDbType.VarChar, 2, "leccion"), New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.VarChar, 10, "tipo"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.VarChar, 50, "observacion"), New System.Data.SqlClient.SqlParameter("@fecha_motivacion", System.Data.SqlDbType.DateTime, 8, "fecha_motivacion")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT leccion, tipo, id, fecha, carnet, observacion, fecha_motivacion FROM Ausen" & _
            "cias WHERE (carnet = @carnet) AND (fecha = @fecha) AND (fecha_motivacion IS NULL" & _
            ") ORDER BY leccion"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@leccion", System.Data.SqlDbType.VarChar, 2, "leccion"), New System.Data.SqlClient.SqlParameter("@tipo", System.Data.SqlDbType.VarChar, 10, "tipo"), New System.Data.SqlClient.SqlParameter("@fecha", System.Data.SqlDbType.DateTime, 8, "fecha"), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@observacion", System.Data.SqlDbType.VarChar, 50, "observacion"), New System.Data.SqlClient.SqlParameter("@fecha_motivacion", System.Data.SqlDbType.DateTime, 8, "fecha_motivacion"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_motivacion", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_motivacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_leccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "leccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observacion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Current, Nothing)})
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.CheckedListBox3)
        Me.Panel2.Controls.Add(Me.CheckedListBox2)
        Me.Panel2.Controls.Add(Me.CheckedListBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(232, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 184)
        Me.Panel2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 149)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "1234567890"
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.BackColor = System.Drawing.Color.Red
        Me.CheckedListBox3.CheckOnClick = True
        Me.CheckedListBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CheckedListBox3.Location = New System.Drawing.Point(113, 19)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(19, 154)
        Me.CheckedListBox3.TabIndex = 9
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.DarkOrange
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(71, 19)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(19, 154)
        Me.CheckedListBox2.TabIndex = 8
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.Gold
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckedListBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(29, 19)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(19, 154)
        Me.CheckedListBox1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(108, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Escap"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(68, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tarde"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ausente"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(232, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Carnet"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNotas1, "Ausencias.fecha", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(286, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNotas1, "Ausencias.carnet", True))
        Me.TextBox1.Location = New System.Drawing.Point(286, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckedListBox4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(267, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 440)
        Me.Panel1.TabIndex = 25
        Me.Panel1.Visible = False
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.CheckOnClick = True
        Me.CheckedListBox4.Location = New System.Drawing.Point(48, 96)
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(72, 184)
        Me.CheckedListBox4.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 40)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 48)
        Me.TextBox2.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(16, 8)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Justifica"
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsNotas1.Ausencias
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(264, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Orange
        Me.Button3.Location = New System.Drawing.Point(304, 304)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 24)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(208, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Justifica"
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(208, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(240, 32)
        Me.UserControl21.TabIndex = 1
        '
        'BuscaEstud1
        '
        Me.BuscaEstud1.BackColor = System.Drawing.Color.Transparent
        Me.BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BuscaEstud1.Location = New System.Drawing.Point(0, 0)
        Me.BuscaEstud1.Name = "BuscaEstud1"
        Me.BuscaEstud1.Size = New System.Drawing.Size(208, 342)
        Me.BuscaEstud1.TabIndex = 22
        '
        'frmAusencias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 342)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.UserControl21)
        Me.Controls.Add(Me.BuscaEstud1)
        Me.Name = "frmAusencias"
        Me.Text = "Ausencias"
        CType(Me.DsNotas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub frmAusencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = conn.strConn

            Me.UserControl21.Nuevo.Visible = False
            Me.UserControl21.Borrar.Visible = False
            Me.UserControl21.Buscar.Visible = False
            'Me.UserControl21.ButtonItem5.Visible = False
            Me.UserControl21.Salir.Visible = False
            Me.UserControl21.salvar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub guardar()
        Try
            Me.BindingContext(Me.DsNotas1, "Ausencias").EndCurrentEdit()
            Me.guardarAusencias(Me.TextBox1.Text, Me.DateTimePicker1.Value) 'guardar ausencias 
            Me.SqlDataAdapter1.Update(DsNotas1, "Ausencias")
            Me.UserControl21.salvar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub imprimir()
        Try
            Dim ventana As New frmAusenciasRep
            ventana.MdiParent = Me.ParentForm
            ventana.Show()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub CheckedListBox3_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        Dim chk1 As Boolean = Me.CheckedListBox1.GetItemChecked(e.Index)
        Dim chk2 As Boolean = Me.CheckedListBox2.GetItemChecked(e.Index)
        If chk1 Or chk2 Then
            e.NewValue = CheckState.Unchecked
        End If
    End Sub

    Private Sub CheckedListBox2_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        Dim chk1 As Boolean = Me.CheckedListBox1.GetItemChecked(e.Index)
        Dim chk2 As Boolean = Me.CheckedListBox3.GetItemChecked(e.Index)
        If chk1 Or chk2 Then
            e.NewValue = CheckState.Unchecked
        End If
    End Sub

    Private Sub CheckedListBox1_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        Dim chk1 As Boolean = Me.CheckedListBox2.GetItemChecked(e.Index)
        Dim chk2 As Boolean = Me.CheckedListBox3.GetItemChecked(e.Index)
        If chk1 Or chk2 Then
            e.NewValue = CheckState.Unchecked
        End If
    End Sub
    Sub limpiasCheck(ByVal obj As Object)
        Dim n As Integer
        For n = 0 To obj.Items.Count - 1
            obj.SetItemChecked(n, False)
        Next
        obj.refresh()
    End Sub

    Sub LimpiaTodosChecks()
        limpiasCheck(Me.CheckedListBox1)
        limpiasCheck(Me.CheckedListBox2)
        limpiasCheck(Me.CheckedListBox3)
    End Sub

    Sub DesplegarAusencias()
        LimpiaTodosChecks()
        For Each reg As DataRow In DsNotas1.Tables("Ausencias").Rows
            Select Case reg.Item("tipo")
                Case "A"
                    Me.CheckedListBox1.SetItemChecked(CInt(reg.Item("leccion")) - 1, True)
                Case "T"
                    Me.CheckedListBox2.SetItemChecked(CInt(reg.Item("leccion")) - 1, True)
                Case "E"
                    Me.CheckedListBox3.SetItemChecked(CInt(reg.Item("leccion")) - 1, True)
            End Select
        Next
    End Sub

    Function ExisteReg(ByVal pcar As String, ByVal pfecha As String, ByVal plecc As String, ByVal ptipo As String) As Boolean
        For Each regist As DataRow In DsNotas1.Tables("ausencias").Rows
            If regist.Item("carnet") = pcar And regist.Item("fecha") = pfecha And _
                regist.Item("leccion") = plecc And regist.Item("tipo") = ptipo Then
                Return True
            End If
        Next
        Return False
    End Function
    Sub guardarAusencias(ByVal pcarnet As String, ByVal pfecha As Date)
        Dim comando As String = "INSERT INTO Ausencias (carnet, fecha, leccion, tipo) VALUES( @1 , @2 @3 , @4 , @5 )"
        Try
            For Each itm As Object In Me.CheckedListBox1.CheckedItems
                If Not ExisteReg(pcarnet, pfecha, itm, "A") Then
                    comando.Replace("@1", pcarnet)
                    Me.BindingContext(Me.DsNotas1, "Ausencias").AddNew()
                    Dim nuevo As DataRowView = BindingContext(Me.DsNotas1, "Ausencias").Current
                    nuevo.Item("carnet") = pcarnet
                    nuevo.Item("fecha") = pfecha
                    nuevo.Item("leccion") = itm
                    nuevo.Item("tipo") = "A"
                End If
            Next

            For Each itm As Object In Me.CheckedListBox2.CheckedItems
                If Not ExisteReg(pcarnet, pfecha, itm, "T") Then
                    Me.BindingContext(Me.DsNotas1, "Ausencias").AddNew()
                    Dim nuevo As DataRowView = BindingContext(Me.DsNotas1, "Ausencias").Current
                    nuevo.Item("carnet") = pcarnet
                    nuevo.Item("fecha") = pfecha
                    nuevo.Item("leccion") = itm
                    nuevo.Item("tipo") = "T"
                End If
            Next
            For Each itm As Object In Me.CheckedListBox3.CheckedItems
                If Not ExisteReg(pcarnet, pfecha, itm, "E") Then
                    Me.BindingContext(Me.DsNotas1, "Ausencias").AddNew()
                    Dim nuevo As DataRowView = BindingContext(Me.DsNotas1, "Ausencias").Current
                    nuevo.Item("carnet") = pcarnet
                    nuevo.Item("fecha") = pfecha
                    nuevo.Item("leccion") = itm
                    nuevo.Item("tipo") = "E"
                End If
            Next
            Me.BindingContext(Me.DsNotas1, "Ausencias").EndCurrentEdit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BuscaEstud1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        llena_check()
    End Sub
    Sub llena_check()
        Try
            Me.BindingContext(Me.DsNotas1, "Ausencias").EndCurrentEdit()

            Dim fecha As Date
            fecha = DateTimePicker1.Value.Date

            DsNotas1.Tables("Ausencias").Clear()
            Me.SqlDataAdapter2.SelectCommand.Parameters.Item("@carnet").Value = BuscaEstud1.seleccionado
            Me.SqlDataAdapter2.SelectCommand.Parameters.Item("@fecha").Value = fecha
            afectadas = Me.SqlDataAdapter2.Fill(DsNotas1, "Ausencias")
            LimpiaTodosChecks()
            If afectadas > 0 Then
                DesplegarAusencias()
                Me.UserControl21.salvar.Enabled = True
            Else
                Me.DateTimePicker1.Value = fecha
                Me.UserControl21.salvar.Enabled = True
            End If
            Me.TextBox1.Text = BuscaEstud1.seleccionado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Me.Label4.Text = Format(Me.DateTimePicker1.Value, "D")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim comando As String
        For Each items As Object In Me.CheckedListBox4.CheckedItems
            comando = "update Ausencias SET observacion='" & Me.TextBox2.Text & "', fecha_motivacion= '" & Me.DateTimePicker2.Value.Date & "' WHERE id=" & items.codigo
            conn.ejecuta(comando)
        Next
        llena_check()
        Me.Panel1.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        justifica("A")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        justifica("T")
    End Sub
    Sub justifica(ByVal tipo As String)
        Me.Panel1.Visible = True
        Me.Panel1.Dock = DockStyle.Fill
        Me.DataView1.RowFilter = "tipo = '" & tipo & "'"

        Dim CargarList As New CargarLista
        CargarList.DatosListadeView(DataView1, Me.CheckedListBox4, "Id", "leccion")
    End Sub

End Class
