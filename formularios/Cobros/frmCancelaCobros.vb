
Public Class frmCancelaCobros
    Inherits DevComponents.DotNetBar.Metro.MetroForm
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
        Me.components = New System.ComponentModel.Container
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GenCobro1 = New colegio.genCobro
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.BuscaEstud1 = New colegio.BuscaEstud
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        CType(Me.GenCobro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(224, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=HP_PAVILION5500;packet size=4096;user id=jose;data source=SERVIDOR" & _
        "_BD;persist security info=False;initial catalog=colegio"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cobros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("mes", "mes"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("fecha_recibo", "fecha_recibo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("generado", "generado"), New System.Data.Common.DataColumnMapping("id_cobro", "id_cobro")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cobros WHERE (id_cobro = @Original_id_cobro) AND (carnet = @Original_" & _
        "carnet) AND (fecha_recibo = @Original_fecha_recibo OR @Original_fecha_recibo IS " & _
        "NULL AND fecha_recibo IS NULL) AND (generado = @Original_generado) AND (mes = @O" & _
        "riginal_mes) AND (monto = @Original_monto OR @Original_monto IS NULL AND monto I" & _
        "S NULL) AND (recibo = @Original_recibo OR @Original_recibo IS NULL AND recibo IS" & _
        " NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cobros(carnet, mes, recibo, fecha_recibo, monto, generado) VALUES (@c" & _
        "arnet, @mes, @recibo, @fecha_recibo, @monto, @generado); SELECT carnet, mes, rec" & _
        "ibo, fecha_recibo, monto, generado, id_cobro FROM cobros WHERE (id_cobro = @@IDE" & _
        "NTITY) ORDER BY mes"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT carnet, mes, recibo, fecha_recibo, monto, generado, id_cobro FROM cobros W" & _
        "HERE (carnet = @carnet) AND (recibo IS NULL) ORDER BY mes"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cobros SET carnet = @carnet, mes = @mes, recibo = @recibo, fecha_recibo = " & _
        "@fecha_recibo, monto = @monto, generado = @generado WHERE (id_cobro = @Original_" & _
        "id_cobro) AND (carnet = @Original_carnet) AND (fecha_recibo = @Original_fecha_re" & _
        "cibo OR @Original_fecha_recibo IS NULL AND fecha_recibo IS NULL) AND (generado =" & _
        " @Original_generado) AND (mes = @Original_mes) AND (monto = @Original_monto OR @" & _
        "Original_monto IS NULL AND monto IS NULL) AND (recibo = @Original_recibo OR @Ori" & _
        "ginal_recibo IS NULL AND recibo IS NULL); SELECT carnet, mes, recibo, fecha_reci" & _
        "bo, monto, generado, id_cobro FROM cobros WHERE (id_cobro = @id_cobro) ORDER BY " & _
        "mes"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Current, Nothing))
        '
        'GenCobro1
        '
        Me.GenCobro1.DataSetName = "genCobro"
        Me.GenCobro1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader4})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(216, 64)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(248, 174)
        Me.ListView1.SmallImageList = Me.ImageList2
        Me.ListView1.TabIndex = 2
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Recibo"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Monto"
        Me.ColumnHeader4.Width = 110
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Iconos", "Detalles"})
        Me.ComboBox1.Location = New System.Drawing.Point(352, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(224, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(232, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Location = New System.Drawing.Point(376, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 279)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(216, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Volver    "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Recibo Banco"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(216, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Actualizar  "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 112)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(96, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = ""
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(224, 248)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cancela recibo"
        '
        'BuscaEstud1
        '
        Me.BuscaEstud1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BuscaEstud1.Location = New System.Drawing.Point(0, 0)
        Me.BuscaEstud1.Name = "BuscaEstud1"
        Me.BuscaEstud1.Size = New System.Drawing.Size(184, 279)
        Me.BuscaEstud1.TabIndex = 0
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cobros.carnet, cobros.mes, cobros.recibo, cobros.fecha_recibo, cobros.mont" & _
        "o, cobros.generado, cobros.id_cobro FROM cobros INNER JOIN matricula ON cobros.i" & _
        "d_mat = matricula.id_mat WHERE (matricula.carnet = @carnet) AND (cobros.recibo I" & _
        "S NULL) ORDER BY cobros.mes"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO cobros(carnet, mes, recibo, fecha_recibo, monto, generado) VALUES (@c" & _
        "arnet, @mes, @recibo, @fecha_recibo, @monto, @generado)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE cobros SET carnet = @carnet, mes = @mes, recibo = @recibo, fecha_recibo = " & _
        "@fecha_recibo, monto = @monto, generado = @generado WHERE (id_cobro = @Original_" & _
        "id_cobro) AND (carnet = @Original_carnet) AND (fecha_recibo = @Original_fecha_re" & _
        "cibo OR @Original_fecha_recibo IS NULL AND fecha_recibo IS NULL) AND (generado =" & _
        " @Original_generado OR @Original_generado IS NULL AND generado IS NULL) AND (mes" & _
        " = @Original_mes OR @Original_mes IS NULL AND mes IS NULL) AND (monto = @Origina" & _
        "l_monto OR @Original_monto IS NULL AND monto IS NULL) AND (recibo = @Original_re" & _
        "cibo OR @Original_recibo IS NULL AND recibo IS NULL)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM cobros WHERE (id_cobro = @Original_id_cobro) AND (carnet = @Original_" & _
        "carnet) AND (fecha_recibo = @Original_fecha_recibo OR @Original_fecha_recibo IS " & _
        "NULL AND fecha_recibo IS NULL) AND (generado = @Original_generado OR @Original_g" & _
        "enerado IS NULL AND generado IS NULL) AND (mes = @Original_mes OR @Original_mes " & _
        "IS NULL AND mes IS NULL) AND (monto = @Original_monto OR @Original_monto IS NULL" & _
        " AND monto IS NULL) AND (recibo = @Original_recibo OR @Original_recibo IS NULL A" & _
        "ND recibo IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""EG-HPZE5547"";packet size=4096;integrated security=SSPI;data sourc" & _
        "e=SERVIDOR_BD;persist security info=False;initial catalog=colegio"
        '
        'frmCancelaCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 279)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BuscaEstud1)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmCancelaCobros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancela Cobros"
        CType(Me.GenCobro1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

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

            Me.SqlConnection1.ConnectionString = conn.strConn
            Me.SqlConnection2.ConnectionString = conn.strConn
            ComboBox1.SelectedIndex = 0
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

                oDataRow("recibo") = Me.TextBox3.Text
                oDataRow("fecha_recibo") = Me.DateTimePicker1.Value
            Next

            Me.SqlDataAdapter1.Update(GenCobro1, "pendientes")
            Me.Panel1.Visible = False
            Me.AcceptButton = Nothing
            TextBox1.Focus()
            Me.buscar(TextBox1.Text)
        Else
            MessageBox.Show("LLene el número de recibo")
            TextBox3.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Panel1.Visible = False
        Me.AcceptButton = Nothing
        TextBox1.Focus()
        SendKeys.Send("{enter}")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Dock = DockStyle.Fill
        Me.AcceptButton = Me.Button2
        Panel1.Visible = True
    End Sub

    Sub buscar(ByVal pcarnet As String)
        Me.TextBox1.Text = pcarnet
        GenCobro1.Tables("pendientes").Rows.Clear()
        Me.SqlDataAdapter1.SelectCommand.Parameters("@carnet").Value = TextBox1.Text
        Me.SqlDataAdapter1.Fill(GenCobro1, "pendientes")

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
        Me.ComboBox1.SelectedIndex = 1
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel1.Dock = DockStyle.Fill
        Me.AcceptButton = Me.Button2
        Panel1.Visible = True

    End Sub

    Private Sub BuscaEstud1_selecionado(ByVal sender As Object, ByVal e As SeleccionadoEventArgs) Handles BuscaEstud1.selecionado
        buscar(Me.BuscaEstud1.seleccionado)
    End Sub

End Class
