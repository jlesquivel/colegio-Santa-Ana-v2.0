Public Class frmCobroAdelantado
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Dim conn As New conexionSQL
    Dim lmeses As String() = {"Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", _
                                            "Agosto", "Septiembre", "Octubre", "Noviembre"}

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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Estudiante As System.Data.SqlClient.SqlCommand
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents meses_cobro As System.Data.SqlClient.SqlCommand
    Friend WithEvents BuscaEstud1 As colegio.BuscaEstud
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents MonedaTextBox1 As colegio.MonedaTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MonedaTextBox2 As colegio.MonedaTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AñosMatriculados As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsCobrosAdelantado1 As colegio.dsCobrosAdelantado
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobroAdelantado))
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        TextBox1 = New System.Windows.Forms.TextBox
        TextBox2 = New System.Windows.Forms.TextBox
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Label3 = New System.Windows.Forms.Label
        Button1 = New System.Windows.Forms.Button
        Estudiante = New System.Data.SqlClient.SqlCommand
        TextBox3 = New System.Windows.Forms.TextBox
        ComboBox1 = New System.Windows.Forms.ComboBox
        Label4 = New System.Windows.Forms.Label
        meses_cobro = New System.Data.SqlClient.SqlCommand
        BuscaEstud1 = New colegio.BuscaEstud
        TextBox4 = New System.Windows.Forms.TextBox
        MonedaTextBox1 = New colegio.MonedaTextBox
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        MonedaTextBox2 = New colegio.MonedaTextBox
        Label7 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        TextBox5 = New System.Windows.Forms.TextBox
        DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        AñosMatriculados = New System.Data.SqlClient.SqlCommand
        GroupBox1 = New System.Windows.Forms.GroupBox
        Label9 = New System.Windows.Forms.Label
        ErrorProvider1 = New System.Windows.Forms.ErrorProvider(components)
        DsCobrosAdelantado1 = New colegio.dsCobrosAdelantado
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(DsCobrosAdelantado1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;integrated security=SSPI;data sourc" & _
            "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand1
        SqlDataAdapter1.InsertCommand = SqlInsertCommand1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cobros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_cobro", "id_cobro"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("concepto", "concepto"), New System.Data.Common.DataColumnMapping("mes", "mes"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("fecha_recibo", "fecha_recibo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("generado", "generado"), New System.Data.Common.DataColumnMapping("multa", "multa")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_concepto", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_multa", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "multa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 15, "concepto"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@multa", System.Data.SqlDbType.Money, 8, "multa")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT id_cobro, id_mat, carnet, concepto, mes, recibo, fecha_recibo, monto, gene" & _
            "rado, multa FROM cobros"
        SqlSelectCommand1.Connection = SqlConnection1
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 15, "concepto"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@multa", System.Data.SqlDbType.Money, 8, "multa"), New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_concepto", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_multa", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "multa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Current, Nothing)})
        '
        'TextBox1
        '
        TextBox1.Location = New System.Drawing.Point(64, 16)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New System.Drawing.Size(100, 20)
        TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        TextBox2.Location = New System.Drawing.Point(64, 40)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New System.Drawing.Size(224, 20)
        TextBox2.TabIndex = 2
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(8, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 24)
        Label1.TabIndex = 3
        Label1.Text = "Carnet"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(8, 40)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(56, 24)
        Label2.TabIndex = 4
        Label2.Text = "Nombre"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckedListBox1
        '
        CheckedListBox1.BackColor = System.Drawing.SystemColors.Window
        CheckedListBox1.CheckOnClick = True
        CheckedListBox1.Location = New System.Drawing.Point(424, 136)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New System.Drawing.Size(120, 154)
        CheckedListBox1.TabIndex = 1
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(408, 112)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(56, 24)
        Label3.TabIndex = 6
        Label3.Text = "Meses"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Button1.Enabled = False
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button1.Location = New System.Drawing.Point(300, 296)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(100, 32)
        Button1.TabIndex = 5
        Button1.Text = "Generar Cobros"
        '
        'Estudiante
        '
        Estudiante.CommandText = resources.GetString("Estudiante.CommandText")
        Estudiante.Connection = SqlConnection1
        Estudiante.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano")})
        '
        'TextBox3
        '
        TextBox3.Location = New System.Drawing.Point(184, 64)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New System.Drawing.Size(100, 20)
        TextBox3.TabIndex = 8
        '
        'ComboBox1
        '
        ComboBox1.BackColor = System.Drawing.SystemColors.Window
        ComboBox1.Location = New System.Drawing.Point(320, 136)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(80, 21)
        ComboBox1.TabIndex = 0
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(248, 136)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(56, 24)
        Label4.TabIndex = 10
        Label4.Text = "Año"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'meses_cobro
        '
        meses_cobro.CommandText = "SELECT cobros.mes FROM cobros INNER JOIN matricula ON cobros.id_mat = matricula.i" & _
            "d_mat WHERE (YEAR(cobros.generado) = @anno) AND (matricula.carnet = @carnet)"
        meses_cobro.Connection = SqlConnection1
        meses_cobro.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.[Decimal]), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'BuscaEstud1
        '
        BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Left
        BuscaEstud1.Location = New System.Drawing.Point(0, 0)
        BuscaEstud1.Name = "BuscaEstud1"
        BuscaEstud1.Size = New System.Drawing.Size(224, 350)
        BuscaEstud1.TabIndex = 11
        '
        'TextBox4
        '
        TextBox4.BackColor = System.Drawing.SystemColors.Window
        TextBox4.Location = New System.Drawing.Point(312, 192)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New System.Drawing.Size(88, 20)
        TextBox4.TabIndex = 2
        '
        'MonedaTextBox1
        '
        MonedaTextBox1.BackColor = System.Drawing.SystemColors.Window
        MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        MonedaTextBox1.Location = New System.Drawing.Point(312, 240)
        MonedaTextBox1.Name = "MonedaTextBox1"
        MonedaTextBox1.Size = New System.Drawing.Size(88, 20)
        MonedaTextBox1.TabIndex = 4
        MonedaTextBox1.Text = "¢0.00"
        MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(224, 244)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(80, 16)
        Label5.TabIndex = 14
        Label5.Text = "Monto por mes"
        Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(224, 196)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(80, 16)
        Label6.TabIndex = 15
        Label6.Text = "Recibo"
        Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MonedaTextBox2
        '
        MonedaTextBox2.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        MonedaTextBox2.Location = New System.Drawing.Point(312, 264)
        MonedaTextBox2.Name = "MonedaTextBox2"
        MonedaTextBox2.ReadOnly = True
        MonedaTextBox2.Size = New System.Drawing.Size(88, 20)
        MonedaTextBox2.TabIndex = 16
        MonedaTextBox2.Text = "¢0.00"
        MonedaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(256, 268)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(48, 16)
        Label7.TabIndex = 17
        Label7.Text = "Total"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Label8.Location = New System.Drawing.Point(8, 64)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(56, 24)
        Label8.TabIndex = 19
        Label8.Text = "Nivel"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        TextBox5.Location = New System.Drawing.Point(64, 64)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New System.Drawing.Size(100, 20)
        TextBox5.TabIndex = 18
        '
        'DateTimePicker1
        '
        DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        DateTimePicker1.Location = New System.Drawing.Point(312, 216)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        DateTimePicker1.TabIndex = 3
        '
        'AñosMatriculados
        '
        AñosMatriculados.CommandText = "SELECT ano FROM matricula WHERE (ano >= YEAR(GETDATE())) AND (carnet = @carnet)"
        AñosMatriculados.Connection = SqlConnection1
        AñosMatriculados.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        GroupBox1.Location = New System.Drawing.Point(224, 8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(328, 100)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Estudiante"
        '
        'Label9
        '
        Label9.Location = New System.Drawing.Point(224, 220)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(80, 16)
        Label9.TabIndex = 22
        Label9.Text = "Fecha recibo"
        Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ErrorProvider1
        '
        ErrorProvider1.ContainerControl = Me
        '
        'DsCobrosAdelantado1
        '
        DsCobrosAdelantado1.DataSetName = "dsCobrosAdelantado"
        DsCobrosAdelantado1.Locale = New System.Globalization.CultureInfo("es-CR")
        DsCobrosAdelantado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmCobroAdelantado
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(560, 350)
        Controls.Add(Label9)
        Controls.Add(GroupBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label7)
        Controls.Add(MonedaTextBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(MonedaTextBox1)
        Controls.Add(TextBox4)
        Controls.Add(BuscaEstud1)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(CheckedListBox1)
        Name = "frmCobroAdelantado"
        Text = "Cobro Adelantado"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(DsCobrosAdelantado1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region
    Private Sub frmCobroAdelantado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = conn.strConn
    End Sub

    Public Sub buscar(ByVal id As String)
        llena_anos(id)

        TextBox4.Text = ""
        DateTimePicker1.Value = Now

        If Not (ComboBox1.SelectedItem Is Nothing) Then
            Dim dsAdelanto As New DataSet
            Estudiante.Parameters("@carnet").Value = id
            Estudiante.Parameters("@ano").Value = ComboBox1.Text
            conn.llena(dsAdelanto, "Table1", Estudiante)

            If dsAdelanto.Tables("Table1").Rows.Count > 0 Then
                Dim fila As DataRow = dsAdelanto.Tables("Table1").Rows.Item(0)
                TextBox1.Text = fila.Item("carnet")
                TextBox2.Text = fila.Item("nombre")
                TextBox3.Text = fila.Item("id_mat")
                TextBox5.Text = fila.Item("nivel")
                MonedaTextBox1.Text = fila.Item("cobros")
            End If

            AñosMatriculados.Parameters("@carnet").Value = id
            conn.llena(dsAdelanto, "Table3", AñosMatriculados)

            actualiza_meses()
        End If
    End Sub

    Private Sub llena_anos(ByVal id As String)
        Dim dsAdelanto As New DataSet
        Dim fila As DataRow

        AñosMatriculados.Parameters("@carnet").Value = id
        conn.llena(dsAdelanto, "Table3", AñosMatriculados)
        ComboBox1.Items.Clear()
        For Each fila In dsAdelanto.Tables("Table3").Rows
            ComboBox1.Items.Add(fila("ano"))
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub actualiza_meses()

        Dim mesesI As New ArrayList(10)
        Dim mes As String = ""

        Dim i As Integer
        For i = 0 To 9
            mesesI.Add(lmeses(i))
        Next
        CheckedListBox1.DataSource = Nothing
        Dim dsAdelanto As New DataSet
        meses_cobro.Parameters("@carnet").Value = TextBox1.Text
        meses_cobro.Parameters("@anno").Value = ComboBox1.SelectedItem
        conn.llena(dsAdelanto, "Table2", meses_cobro)
        If dsAdelanto.Tables("Table2").Rows.Count > 0 Then   'elimina los meses pagados al dia
            Dim fila As DataRow
            Dim pos As Integer
            For Each fila In dsAdelanto.Tables("Table2").Rows
                mes = StrConv(MonthName(fila("mes")), VbStrConv.ProperCase)
                pos = mesesI.IndexOf(mes)
                mesesI.RemoveAt(pos)
            Next
        End If
        CheckedListBox1.DataSource = mesesI
    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Button1.Enabled = CheckedListBox1.CheckedItems.Count > 0
        MonedaTextBox2.Text = MonedaTextBox1.Text * CheckedListBox1.CheckedItems.Count
    End Sub

    Private Sub BuscaEstud1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        Try
            If BuscaEstud1.seleccionado <> "" Then
                buscar(BuscaEstud1.seleccionado)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        actualiza_meses()
    End Sub

    Function error_blanco(ByVal control As Object) As Boolean
        If control.Text = "" Then
            ErrorProvider1.SetError(control, "llenar por favor")
            Return False
        Else
            ErrorProvider1.SetError(control, "")
            Return True
        End If
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (error_blanco(TextBox4) And error_blanco(DateTimePicker1) And _
                 error_blanco(MonedaTextBox1)) Then

            DsCobrosAdelantado1.Tables("cobros").Clear()
            Dim mes As Object
            Dim fila As dsCobrosAdelantado.cobrosRow

            For Each mes In CheckedListBox1.CheckedItems
                fila = DsCobrosAdelantado1.Tables("cobros").NewRow()
                With fila
                    .carnet = TextBox1.Text
                    .concepto = "Pago Adelantado"
                    .id_mat = TextBox3.Text
                    .mes = pos_mes(lmeses, mes)
                    .recibo = TextBox4.Text
                    .fecha_recibo = DateTimePicker1.Value
                    .monto = MonedaTextBox1.Text
                    .multa = 0
                    .generado = Date.Now
                End With
                DsCobrosAdelantado1.cobros.AddcobrosRow(fila)
            Next
            SqlDataAdapter1.Update(DsCobrosAdelantado1)
            buscar(TextBox1.Text)
        End If
    End Sub

    Function pos_mes(ByVal arreglo As Array, ByVal val As String) As Integer
        Dim pos As Integer = 0
        While pos <= arreglo.Length And val <> arreglo(pos)
            pos = pos + 1
        End While
        If pos > arreglo.Length Then
            Return -1
        Else
            Return (pos + 2)
        End If
    End Function
End Class
