
Public Class frmCancelaCobros
    Inherits DevComponents.DotNetBar.Metro.MetroForm


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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GenCobro1 As colegio.genCobro
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BuscaEstud1 As colegio.BuscaEstud
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        TextBox1 = New System.Windows.Forms.TextBox
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        GenCobro1 = New colegio.genCobro
        ListView1 = New System.Windows.Forms.ListView
        ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        ImageList1 = New System.Windows.Forms.ImageList(components)
        ImageList2 = New System.Windows.Forms.ImageList(components)
        MainMenu1 = New System.Windows.Forms.MainMenu
        ComboBox1 = New System.Windows.Forms.ComboBox
        TextBox2 = New System.Windows.Forms.TextBox
        Panel1 = New System.Windows.Forms.Panel
        Button2 = New System.Windows.Forms.Button
        Label3 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Button1 = New System.Windows.Forms.Button
        DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        TextBox3 = New System.Windows.Forms.TextBox
        Button3 = New System.Windows.Forms.Button
        BuscaEstud1 = New colegio.BuscaEstud
        SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        SqlConnection2 = New System.Data.SqlClient.SqlConnection
        CType(GenCobro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        '
        'TextBox1
        '
        TextBox1.Location = New System.Drawing.Point(224, 16)
        TextBox1.Name = "TextBox1"
        TextBox1.TabIndex = 1
        TextBox1.Text = ""
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
        "_BD;persist security info=False;initial catalog=colegio"
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand2
        SqlDataAdapter1.InsertCommand = SqlInsertCommand2
        SqlDataAdapter1.SelectCommand = SqlSelectCommand2
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cobros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("mes", "mes"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("fecha_recibo", "fecha_recibo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("generado", "generado"), New System.Data.Common.DataColumnMapping("id_cobro", "id_cobro")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand2
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = "DELETE FROM cobros WHERE (id_cobro = @Original_id_cobro) AND (carnet = @Original_" & _
        "carnet) AND (fecha_recibo = @Original_fecha_recibo OR @Original_fecha_recibo IS " & _
        "NULL AND fecha_recibo IS NULL) AND (generado = @Original_generado) AND (mes = @O" & _
        "riginal_mes) AND (monto = @Original_monto OR @Original_monto IS NULL AND monto I" & _
        "S NULL) AND (recibo = @Original_recibo OR @Original_recibo IS NULL AND recibo IS" & _
        " NULL)"
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = "INSERT INTO cobros(carnet, mes, recibo, fecha_recibo, monto, generado) VALUES (@c" & _
        "arnet, @mes, @recibo, @fecha_recibo, @monto, @generado); SELECT carnet, mes, rec" & _
        "ibo, fecha_recibo, monto, generado, id_cobro FROM cobros WHERE (id_cobro = @@IDE" & _
        "NTITY) ORDER BY mes"
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT carnet, mes, recibo, fecha_recibo, monto, generado, id_cobro FROM cobros W" & _
        "HERE (carnet = @carnet) AND (recibo IS NULL) ORDER BY mes"
        SqlSelectCommand1.Connection = SqlConnection1
        SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = "UPDATE cobros SET carnet = @carnet, mes = @mes, recibo = @recibo, fecha_recibo = " & _
        "@fecha_recibo, monto = @monto, generado = @generado WHERE (id_cobro = @Original_" & _
        "id_cobro) AND (carnet = @Original_carnet) AND (fecha_recibo = @Original_fecha_re" & _
        "cibo OR @Original_fecha_recibo IS NULL AND fecha_recibo IS NULL) AND (generado =" & _
        " @Original_generado) AND (mes = @Original_mes) AND (monto = @Original_monto OR @" & _
        "Original_monto IS NULL AND monto IS NULL) AND (recibo = @Original_recibo OR @Ori" & _
        "ginal_recibo IS NULL AND recibo IS NULL); SELECT carnet, mes, recibo, fecha_reci" & _
        "bo, monto, generado, id_cobro FROM cobros WHERE (id_cobro = @id_cobro) ORDER BY " & _
        "mes"
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Current, Nothing))
        '
        'GenCobro1
        '
        GenCobro1.DataSetName = "genCobro"
        GenCobro1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'ListView1
        '
        ListView1.CheckBoxes = True
        ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, ColumnHeader4})
        ListView1.LargeImageList = ImageList1
        ListView1.Location = New System.Drawing.Point(216, 64)
        ListView1.Name = "ListView1"
        ListView1.Size = New System.Drawing.Size(248, 174)
        ListView1.SmallImageList = ImageList2
        ListView1.TabIndex = 2
        ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "Recibo"
        ColumnHeader1.Width = 108
        '
        'ColumnHeader4
        '
        ColumnHeader4.Text = "Monto"
        ColumnHeader4.Width = 110
        '
        'ImageList1
        '
        ImageList1.ImageSize = New System.Drawing.Size(24, 24)
        ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ComboBox1
        '
        ComboBox1.Items.AddRange(New Object() {"Iconos", "Detalles"})
        ComboBox1.Location = New System.Drawing.Point(352, 16)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(104, 21)
        ComboBox1.TabIndex = 3
        '
        'TextBox2
        '
        TextBox2.Location = New System.Drawing.Point(224, 40)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New System.Drawing.Size(232, 20)
        TextBox2.TabIndex = 4
        TextBox2.Text = ""
        '
        'Panel1
        '
        Panel1.BackColor = System.Drawing.SystemColors.Control
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Location = New System.Drawing.Point(376, 104)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(480, 279)
        Panel1.TabIndex = 5
        Panel1.Visible = False
        '
        'Button2
        '
        Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button2.Location = New System.Drawing.Point(216, 112)
        Button2.Name = "Button2"
        Button2.Size = New System.Drawing.Size(72, 24)
        Button2.TabIndex = 5
        Button2.Text = "Volver    "
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(32, 112)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(64, 23)
        Label3.TabIndex = 4
        Label3.Text = "Fecha"
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(8, 72)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(80, 23)
        Label2.TabIndex = 3
        Label2.Text = "Recibo Banco"
        '
        'Button1
        '
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button1.Location = New System.Drawing.Point(216, 72)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(72, 24)
        Button1.TabIndex = 2
        Button1.Text = "Actualizar  "
        '
        'DateTimePicker1
        '
        DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        DateTimePicker1.Location = New System.Drawing.Point(96, 112)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        DateTimePicker1.TabIndex = 1
        '
        'TextBox3
        '
        TextBox3.Location = New System.Drawing.Point(96, 72)
        TextBox3.Name = "TextBox3"
        TextBox3.TabIndex = 0
        TextBox3.Text = ""
        '
        'Button3
        '
        Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button3.Location = New System.Drawing.Point(224, 248)
        Button3.Name = "Button3"
        Button3.Size = New System.Drawing.Size(88, 24)
        Button3.TabIndex = 8
        Button3.Text = "Cancela recibo"
        '
        'BuscaEstud1
        '
        BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Left
        BuscaEstud1.Location = New System.Drawing.Point(0, 0)
        BuscaEstud1.Name = "BuscaEstud1"
        BuscaEstud1.Size = New System.Drawing.Size(184, 279)
        BuscaEstud1.TabIndex = 0
        '
        'SqlSelectCommand2
        '
        SqlSelectCommand2.CommandText = "SELECT cobros.carnet, cobros.mes, cobros.recibo, cobros.fecha_recibo, cobros.mont" & _
        "o, cobros.generado, cobros.id_cobro FROM cobros INNER JOIN matricula ON cobros.i" & _
        "d_mat = matricula.id_mat WHERE (matricula.carnet = @carnet) AND (cobros.recibo I" & _
        "S NULL) ORDER BY cobros.mes"
        SqlSelectCommand2.Connection = SqlConnection2
        SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        '
        'SqlInsertCommand2
        '
        SqlInsertCommand2.CommandText = "INSERT INTO cobros(carnet, mes, recibo, fecha_recibo, monto, generado) VALUES (@c" & _
        "arnet, @mes, @recibo, @fecha_recibo, @monto, @generado)"
        SqlInsertCommand2.Connection = SqlConnection2
        SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        '
        'SqlUpdateCommand2
        '
        SqlUpdateCommand2.CommandText = "UPDATE cobros SET carnet = @carnet, mes = @mes, recibo = @recibo, fecha_recibo = " & _
        "@fecha_recibo, monto = @monto, generado = @generado WHERE (id_cobro = @Original_" & _
        "id_cobro) AND (carnet = @Original_carnet) AND (fecha_recibo = @Original_fecha_re" & _
        "cibo OR @Original_fecha_recibo IS NULL AND fecha_recibo IS NULL) AND (generado =" & _
        " @Original_generado OR @Original_generado IS NULL AND generado IS NULL) AND (mes" & _
        " = @Original_mes OR @Original_mes IS NULL AND mes IS NULL) AND (monto = @Origina" & _
        "l_monto OR @Original_monto IS NULL AND monto IS NULL) AND (recibo = @Original_re" & _
        "cibo OR @Original_recibo IS NULL AND recibo IS NULL)"
        SqlUpdateCommand2.Connection = SqlConnection2
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        SqlDeleteCommand2.CommandText = "DELETE FROM cobros WHERE (id_cobro = @Original_id_cobro) AND (carnet = @Original_" & _
        "carnet) AND (fecha_recibo = @Original_fecha_recibo OR @Original_fecha_recibo IS " & _
        "NULL AND fecha_recibo IS NULL) AND (generado = @Original_generado OR @Original_g" & _
        "enerado IS NULL AND generado IS NULL) AND (mes = @Original_mes OR @Original_mes " & _
        "IS NULL AND mes IS NULL) AND (monto = @Original_monto OR @Original_monto IS NULL" & _
        " AND monto IS NULL) AND (recibo = @Original_recibo OR @Original_recibo IS NULL A" & _
        "ND recibo IS NULL)"
        SqlDeleteCommand2.Connection = SqlConnection2
        SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        SqlConnection2.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;integrated security=SSPI;data sourc" & _
        "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        '
        'frmCancelaCobros
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(536, 279)
        Controls.Add(Panel1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(ListView1)
        Controls.Add(Button3)
        Controls.Add(BuscaEstud1)
        Menu = MainMenu1
        Name = "frmCancelaCobros"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Cancela Cobros"
        CType(GenCobro1, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If e.KeyChar = ControlChars.Cr Then
                buscar(TextBox1.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListView1.View = View.LargeIcon
        Else
            ListView1.View = View.Details
        End If
    End Sub

    Private Sub frmCancelaCobros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim conn As New conexionSQL
            SqlConnection1.ConnectionString = conn.strConn
            SqlConnection2.ConnectionString = conn.strConn
            ComboBox1.SelectedIndex = 0
            buscar(BuscaEstud1.seleccionado)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox3.Text <> "" Then
            Dim i, f As Integer
            Dim oDataRow As DataRow

            For i = 0 To ListView1.CheckedItems.Count - 1
                f = 0
                oDataRow = GenCobro1.Tables("pendientes").Rows(f)
                While CStr(oDataRow("id_cobro")) <> ListView1.CheckedItems(i).SubItems(2).Text
                    f = f + 1
                    oDataRow = GenCobro1.Tables("pendientes").Rows(f)
                End While

                oDataRow("recibo") = TextBox3.Text
                oDataRow("fecha_recibo") = DateTimePicker1.Value
            Next

            SqlDataAdapter1.Update(GenCobro1, "pendientes")
            Panel1.Visible = False
            AcceptButton = Nothing
            TextBox1.Focus()
            buscar(TextBox1.Text)
        Else
            MessageBox.Show("LLene el número de recibo")
            TextBox3.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Visible = False
        AcceptButton = Nothing
        TextBox1.Focus()
        SendKeys.Send("{enter}")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Dock = DockStyle.Fill
        AcceptButton = Button2
        Panel1.Visible = True
    End Sub

    Sub buscar(ByVal pcarnet As String)
        TextBox1.Text = pcarnet
        GenCobro1.Tables("pendientes").Rows.Clear()
        SqlDataAdapter1.SelectCommand.Parameters("@carnet").Value = TextBox1.Text

        Dim conn As New conexionSQL
        SqlDataAdapter1.SelectCommand.Connection = conn.conexion

        SqlDataAdapter1.Fill(GenCobro1, "pendientes")

        Dim conex As New conexionSQL  ' busca el nombre en estudiantes
        Dim SQLInst As String = "select carnet,(nombre+' '+apellido1+' '+apellido2)as nombre from estudiantes where carnet='" & TextBox1.Text & "'"
        conex.llena(GenCobro1, "estud", SQLInst)
        TextBox2.Text = GenCobro1.Tables("estud").Rows(0).Item("nombre")

        ListView1.Items.Clear()
        Dim etiqueta As String
        Dim fila As DataRow
        For Each fila In GenCobro1.Tables("pendientes").Rows

            If fila("mes") = 0 Then
                etiqueta = "MATRICULA"
            Else
                etiqueta = MonthName(fila("mes"))
            End If

            Dim nuevo As New ListViewItem(etiqueta, 0)
            nuevo.Checked = True
            nuevo.SubItems.Add(Format(fila("monto"), "C"))
            nuevo.SubItems.Add(fila("id_cobro"))

            ListView1.Items.Add(nuevo)
        Next
        ComboBox1.SelectedIndex = 1
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel1.Dock = DockStyle.Fill
        AcceptButton = Button2
        Panel1.Visible = True

    End Sub

    Private Sub BuscaEstud1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        buscar(BuscaEstud1.seleccionado)
    End Sub

End Class
