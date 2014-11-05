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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobroAdelantado))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Estudiante = New System.Data.SqlClient.SqlCommand
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.meses_cobro = New System.Data.SqlClient.SqlCommand
        Me.BuscaEstud1 = New colegio.BuscaEstud
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.MonedaTextBox1 = New colegio.MonedaTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.MonedaTextBox2 = New colegio.MonedaTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.AñosMatriculados = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DsCobrosAdelantado1 = New colegio.dsCobrosAdelantado
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCobrosAdelantado1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;integrated security=SSPI;data sourc" & _
            "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cobros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_cobro", "id_cobro"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat"), New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("concepto", "concepto"), New System.Data.Common.DataColumnMapping("mes", "mes"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("fecha_recibo", "fecha_recibo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("generado", "generado"), New System.Data.Common.DataColumnMapping("multa", "multa")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_concepto", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_multa", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "multa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 15, "concepto"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@multa", System.Data.SqlDbType.Money, 8, "multa")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_cobro, id_mat, carnet, concepto, mes, recibo, fecha_recibo, monto, gene" & _
            "rado, multa FROM cobros"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@concepto", System.Data.SqlDbType.VarChar, 15, "concepto"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@multa", System.Data.SqlDbType.Money, 8, "multa"), New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_concepto", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id_mat", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_mat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_multa", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "multa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Current, Nothing)})
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(64, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(224, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Carnet"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(424, 136)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 154)
        Me.CheckedListBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(408, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Meses"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(300, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generar Cobros"
        '
        'Estudiante
        '
        Me.Estudiante.CommandText = resources.GetString("Estudiante.CommandText")
        Me.Estudiante.Connection = Me.SqlConnection1
        Me.Estudiante.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@ano", System.Data.SqlDbType.VarChar, 4, "ano")})
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(184, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.Location = New System.Drawing.Point(320, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(80, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Año"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'meses_cobro
        '
        Me.meses_cobro.CommandText = "SELECT cobros.mes FROM cobros INNER JOIN matricula ON cobros.id_mat = matricula.i" & _
            "d_mat WHERE (YEAR(cobros.generado) = @anno) AND (matricula.carnet = @carnet)"
        Me.meses_cobro.Connection = Me.SqlConnection1
        Me.meses_cobro.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@anno", System.Data.SqlDbType.[Decimal]), New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'BuscaEstud1
        '
        Me.BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BuscaEstud1.Location = New System.Drawing.Point(0, 0)
        Me.BuscaEstud1.Name = "BuscaEstud1"
        Me.BuscaEstud1.Size = New System.Drawing.Size(224, 350)
        Me.BuscaEstud1.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.Location = New System.Drawing.Point(312, 192)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(88, 20)
        Me.TextBox4.TabIndex = 2
        '
        'MonedaTextBox1
        '
        Me.MonedaTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.MonedaTextBox1.Location = New System.Drawing.Point(312, 240)
        Me.MonedaTextBox1.Name = "MonedaTextBox1"
        Me.MonedaTextBox1.Size = New System.Drawing.Size(88, 20)
        Me.MonedaTextBox1.TabIndex = 4
        Me.MonedaTextBox1.Text = "¢0.00"
        Me.MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(224, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Monto por mes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(224, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Recibo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MonedaTextBox2
        '
        Me.MonedaTextBox2.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.MonedaTextBox2.Location = New System.Drawing.Point(312, 264)
        Me.MonedaTextBox2.Name = "MonedaTextBox2"
        Me.MonedaTextBox2.ReadOnly = True
        Me.MonedaTextBox2.Size = New System.Drawing.Size(88, 20)
        Me.MonedaTextBox2.TabIndex = 16
        Me.MonedaTextBox2.Text = "¢0.00"
        Me.MonedaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Nivel"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(64, 64)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(312, 216)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'AñosMatriculados
        '
        Me.AñosMatriculados.CommandText = "SELECT ano FROM matricula WHERE (ano >= YEAR(GETDATE())) AND (carnet = @carnet)"
        Me.AñosMatriculados.Connection = Me.SqlConnection1
        Me.AñosMatriculados.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(224, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 100)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estudiante"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(224, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Fecha recibo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DsCobrosAdelantado1
        '
        Me.DsCobrosAdelantado1.DataSetName = "dsCobrosAdelantado"
        Me.DsCobrosAdelantado1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsCobrosAdelantado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmCobroAdelantado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 350)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MonedaTextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MonedaTextBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.BuscaEstud1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "frmCobroAdelantado"
        Me.Text = "Cobro Adelantado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCobrosAdelantado1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub frmCobroAdelantado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = conn.strConn
    End Sub

    Public Sub buscar(ByVal id As String)
        llena_anos(id)

        Me.TextBox4.Text = ""
        Me.DateTimePicker1.Value = Now

        If Not (Me.ComboBox1.SelectedItem Is Nothing) Then
            Dim dsAdelanto As New DataSet
            Me.Estudiante.Parameters("@carnet").Value = id
            Me.Estudiante.Parameters("@ano").Value = Me.ComboBox1.Text
            conn.llena(dsAdelanto, "Table1", Me.Estudiante)

            If dsAdelanto.Tables("Table1").Rows.Count > 0 Then
                Dim fila As DataRow = dsAdelanto.Tables("Table1").Rows.Item(0)
                Me.TextBox1.Text = fila.Item("carnet")
                Me.TextBox2.Text = fila.Item("nombre")
                Me.TextBox3.Text = fila.Item("id_mat")
                Me.TextBox5.Text = fila.Item("nivel")
                Me.MonedaTextBox1.Text = fila.Item("cobros")
            End If

            Me.AñosMatriculados.Parameters("@carnet").Value = id
            conn.llena(dsAdelanto, "Table3", Me.AñosMatriculados)

            actualiza_meses()
        End If
    End Sub

    Private Sub llena_anos(ByVal id As String)
        Dim dsAdelanto As New DataSet
        Dim fila As DataRow

        Me.AñosMatriculados.Parameters("@carnet").Value = id
        conn.llena(dsAdelanto, "Table3", Me.AñosMatriculados)
        Me.ComboBox1.Items.Clear()
        For Each fila In dsAdelanto.Tables("Table3").Rows
            Me.ComboBox1.Items.Add(fila("ano"))
        Next
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub actualiza_meses()

        Dim mesesI As New ArrayList(10)
        Dim mes As String = ""

        Dim i As Integer
        For i = 0 To 9
            mesesI.Add(lmeses(i))
        Next
        Me.CheckedListBox1.DataSource = Nothing
        Dim dsAdelanto As New DataSet
        Me.meses_cobro.Parameters("@carnet").Value = Me.TextBox1.Text
        Me.meses_cobro.Parameters("@anno").Value = Me.ComboBox1.SelectedItem
        conn.llena(dsAdelanto, "Table2", Me.meses_cobro)
        If dsAdelanto.Tables("Table2").Rows.Count > 0 Then   'elimina los meses pagados al dia
            Dim fila As DataRow
            Dim pos As Integer
            For Each fila In dsAdelanto.Tables("Table2").Rows
                mes = StrConv(MonthName(fila("mes")), VbStrConv.ProperCase)
                pos = mesesI.IndexOf(mes)
                mesesI.RemoveAt(pos)
            Next
        End If
        Me.CheckedListBox1.DataSource = mesesI
    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Me.Button1.Enabled = Me.CheckedListBox1.CheckedItems.Count > 0
        Me.MonedaTextBox2.Text = Me.MonedaTextBox1.Text * Me.CheckedListBox1.CheckedItems.Count
    End Sub

    Private Sub BuscaEstud1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        Try
            Me.buscar(Me.BuscaEstud1.seleccionado)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.actualiza_meses()
    End Sub

    Function error_blanco(ByVal control As Object) As Boolean
        If control.Text = "" Then
            Me.ErrorProvider1.SetError(control, "llenar por favor")
            Return False
        Else
            Me.ErrorProvider1.SetError(control, "")
            Return True
        End If
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (error_blanco(Me.TextBox4) And error_blanco(Me.DateTimePicker1) And _
                 error_blanco(Me.MonedaTextBox1)) Then

            Me.DsCobrosAdelantado1.Tables("cobros").Clear()
            Dim mes As Object
            Dim fila As dsCobrosAdelantado.cobrosRow

            For Each mes In Me.CheckedListBox1.CheckedItems
                fila = DsCobrosAdelantado1.Tables("cobros").NewRow()
                With fila
                    .carnet = Me.TextBox1.Text
                    .concepto = "Pago Adelantado"
                    .id_mat = Me.TextBox3.Text
                    .mes = pos_mes(lmeses, mes)
                    .recibo = Me.TextBox4.Text
                    .fecha_recibo = Me.DateTimePicker1.Value
                    .monto = Me.MonedaTextBox1.Text
                    .multa = 0
                    .generado = Date.Now
                End With
                Me.DsCobrosAdelantado1.cobros.AddcobrosRow(fila)
            Next
            Me.SqlDataAdapter1.Update(Me.DsCobrosAdelantado1)
            Me.buscar(Me.TextBox1.Text)
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
