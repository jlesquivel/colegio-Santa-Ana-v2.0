Imports colegioReportes

Public Class CEstadoCuenta
    Inherits System.Windows.Forms.UserControl

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Dim conn As New conexionSQL
        SqlConnection1.ConnectionString = conn.strConn

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GenCobro1 As colegio.genCobro
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CEstadoCuenta))
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        SqlConnection2 = New System.Data.SqlClient.SqlConnection
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        GenCobro1 = New colegio.genCobro
        ListView1 = New System.Windows.Forms.ListView
        ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        ImageList1 = New System.Windows.Forms.ImageList(components)
        MainMenu1 = New System.Windows.Forms.MainMenu(components)
        ComboBox1 = New System.Windows.Forms.ComboBox
        Label1 = New System.Windows.Forms.Label
        TextBox1 = New System.Windows.Forms.TextBox
        Panel1 = New System.Windows.Forms.Panel
        Button1 = New System.Windows.Forms.Button
        CType(GenCobro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=colegio;Integrated Security=True"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.SelectCommand = SqlSelectCommand2
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cobros", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("mes", "mes"), New System.Data.Common.DataColumnMapping("recibo", "recibo"), New System.Data.Common.DataColumnMapping("fecha_recibo", "fecha_recibo"), New System.Data.Common.DataColumnMapping("monto", "monto"), New System.Data.Common.DataColumnMapping("generado", "generado"), New System.Data.Common.DataColumnMapping("id_cobro", "id_cobro"), New System.Data.Common.DataColumnMapping("multa", "multa"), New System.Data.Common.DataColumnMapping("id_mat", "id_mat"), New System.Data.Common.DataColumnMapping("concepto", "concepto")})})
        '
        'SqlSelectCommand2
        '
        SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        SqlSelectCommand2.Connection = SqlConnection1
        SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'SqlConnection2
        '
        SqlConnection2.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;Integrated Security=True"
        SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_multa", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "multa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@multa", System.Data.SqlDbType.Money, 8, "multa")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT carnet, mes, recibo, fecha_recibo, monto, generado, id_cobro, multa FROM c" & _
            "obros WHERE (carnet = @carnet) AND (recibo IS NULL) ORDER BY mes"
        SqlSelectCommand1.Connection = SqlConnection1
        SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet")})
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@mes", System.Data.SqlDbType.Int, 4, "mes"), New System.Data.SqlClient.SqlParameter("@recibo", System.Data.SqlDbType.VarChar, 15, "recibo"), New System.Data.SqlClient.SqlParameter("@fecha_recibo", System.Data.SqlDbType.DateTime, 8, "fecha_recibo"), New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"), New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"), New System.Data.SqlClient.SqlParameter("@multa", System.Data.SqlDbType.Money, 8, "multa"), New System.Data.SqlClient.SqlParameter("@Original_id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_carnet", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "carnet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_recibo", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_generado", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "generado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_multa", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "multa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_recibo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_cobro", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_cobro", System.Data.DataRowVersion.Current, Nothing)})
        '
        'GenCobro1
        '
        GenCobro1.DataSetName = "genCobro"
        GenCobro1.Locale = New System.Globalization.CultureInfo("es-CR")
        GenCobro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListView1
        '
        ListView1.CheckBoxes = True
        ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1, ColumnHeader4, ColumnHeader2, ColumnHeader6, ColumnHeader3, ColumnHeader5})
        ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListView1.LargeImageList = ImageList1
        ListView1.Location = New System.Drawing.Point(0, 40)
        ListView1.Name = "ListView1"
        ListView1.Size = New System.Drawing.Size(448, 200)
        ListView1.Sorting = System.Windows.Forms.SortOrder.Descending
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "Factura"
        ColumnHeader1.Width = 80
        '
        'ColumnHeader4
        '
        ColumnHeader4.Text = "Monto"
        ColumnHeader4.Width = 80
        '
        'ColumnHeader2
        '
        ColumnHeader2.Text = "Multa"
        ColumnHeader2.Width = 65
        '
        'ColumnHeader6
        '
        ColumnHeader6.Text = "Factura"
        ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader3
        '
        ColumnHeader3.Text = "Recibo Pago"
        ColumnHeader3.Width = 75
        '
        'ColumnHeader5
        '
        ColumnHeader5.Text = "Fecha Pago"
        ColumnHeader5.Width = 70
        '
        'ImageList1
        '
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        ImageList1.TransparentColor = System.Drawing.Color.Transparent
        ImageList1.Images.SetKeyName(0, "")
        '
        'ComboBox1
        '
        ComboBox1.Items.AddRange(New Object() {"Iconos", "Detalles"})
        ComboBox1.Location = New System.Drawing.Point(184, 8)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(80, 21)
        ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(8, 8)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 23)
        Label1.TabIndex = 0
        Label1.Text = "Carnet"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        TextBox1.Location = New System.Drawing.Point(64, 8)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(114, 20)
        TextBox1.TabIndex = 1
        '
        'Panel1
        '
        Panel1.BackColor = System.Drawing.Color.Transparent
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(448, 40)
        Panel1.TabIndex = 4
        '
        'Button1
        '
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Button1.Location = New System.Drawing.Point(280, 8)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(72, 24)
        Button1.TabIndex = 4
        Button1.Text = "Imprimir"
        '
        'CEstadoCuenta
        '
        BackColor = System.Drawing.Color.Transparent
        Controls.Add(ListView1)
        Controls.Add(Panel1)
        Name = "CEstadoCuenta"
        Size = New System.Drawing.Size(448, 240)
        CType(GenCobro1, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region
    Dim conn As New conexionSQL
    Dim carnet As String
    Public pendiente As Boolean = False


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListView1.View = View.LargeIcon
        Else
            ListView1.View = View.Details
        End If
    End Sub

    Sub buscar(ByVal pcarnet As String)
        SqlConnection1.ConnectionString = conn.strConn
        SqlConnection2.ConnectionString = conn.strConn
        carnet = pcarnet
        TextBox1.Text = pcarnet
        GenCobro1.Tables("pendientes").Rows.Clear()
        SqlDataAdapter1.SelectCommand.Parameters("@carnet").Value = TextBox1.Text
        SqlDataAdapter1.Fill(GenCobro1, "pendientes")
        pendiente = False
        ListView1.Items.Clear()
        Dim fila As DataRow
        Dim etiqueta As String
        For Each fila In GenCobro1.Tables("pendientes").Rows
            If fila("mes") > 0 Then
                etiqueta = Year(fila("generado")) & "." & rellena(fila("mes")) & " " & MonthName(fila("mes"))
            Else
                etiqueta = Year(fila("generado")) & ".12 " & fila("concepto") ' & (Year(fila("generado")) + 1)
            End If

            Dim nuevo As New ListViewItem(etiqueta, 0)
            nuevo.Checked = False
            nuevo.SubItems.Add(Format(fila("monto"), "C"))
            nuevo.SubItems.Add(Format(fila("multa"), "C"))
            nuevo.SubItems.Add(fila("id_cobro"))
            If fila("recibo") Is DBNull.Value Then
                nuevo.SubItems.Add("")
                nuevo.SubItems.Add("")

                If (fila("mes") = 0) Then
                    pendiente = True
                End If

                If (DateDiff(DateInterval.Day, fila("generado"), Date.Now) > 15) And (fila("mes") > 0) Then
                    pendiente = True
                End If

            Else
                nuevo.SubItems.Add(fila("recibo"))
                nuevo.SubItems.Add(Format(fila("fecha_recibo"), "d"))
            End If
            ListView1.Items.Add(nuevo)
        Next
        ComboBox1.SelectedIndex = 1
    End Sub

    Function rellena(ByVal val As String) As String
        If val.Length = 1 Then
            Return "0" & val
        Else
            Return val
        End If
    End Function

    Private Sub CEstadoCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = conn.strConn
        SqlConnection2.ConnectionString = conn.strConn

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oReporte As New Reportes
        Dim reporte As New rptEstadoCuenta
        Dim impresora As String

        If Not HayMarcados() Then  'imprime Estado Cuenta
            oReporte.inserta_parametro(reporte, "@carnet", carnet)
            reporte.SummaryInfo.ReportComments = "Estado de Cuenta"
            oReporte.imprimir(reporte, False, ParentForm.ParentForm)
        Else
            ' Imprime recibos seleccionados
            impresora = oReporte.BuscarImpresora("TM-U")

            If impresora <> "" Then
                For Each item As ListViewItem In ListView1.Items
                    If item.Checked Then
                        Dim repRecibo As New CrystalReport1
                        oReporte.inserta_parametro(repRecibo, "@factura", CInt(item.SubItems(3).Text))
                        oReporte.imprimir(repRecibo, impresora)
                    End If
                Next
            Else
                MsgBox("impresora TM-U no detectada")
            End If
        End If
    End Sub

    Private Function HayMarcados() As Boolean
        For Each item As ListViewItem In ListView1.Items
            If item.Checked Then
                Return True
            End If
        Next
        Return False
    End Function

End Class
