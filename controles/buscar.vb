Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing

Public Class buscar
    Inherits System.Windows.Forms.UserControl
    Private tabla As String = "estudiantes"
    '  Private campos As String = "carnet,nombre,apellido1,apellido2"
    Private orden As String = ""
    Dim filtro As String
    Dim comboIndex As Integer = 1
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Dim dv As DataView
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridComboBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents da As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PrintGrid As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buscar))
        DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        DataGridComboBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        TextBox1 = New System.Windows.Forms.TextBox
        ComboBox1 = New System.Windows.Forms.ComboBox
        DataGrid1 = New System.Windows.Forms.DataGrid
        ContextMenu1 = New System.Windows.Forms.ContextMenu
        MenuItem1 = New System.Windows.Forms.MenuItem
        PrintGrid = New System.Windows.Forms.Button
        ToolTip1 = New System.Windows.Forms.ToolTip(components)
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        da = New System.Data.SqlClient.SqlDataAdapter
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Panel1 = New System.Windows.Forms.Panel
        CType(DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        '
        'DataGridTextBoxColumn1
        '
        DataGridTextBoxColumn1.Format = ""
        DataGridTextBoxColumn1.FormatInfo = Nothing
        DataGridTextBoxColumn1.Width = 20
        '
        'DataGridComboBoxColumn2
        '
        DataGridComboBoxColumn2.Format = ""
        DataGridComboBoxColumn2.FormatInfo = Nothing
        DataGridComboBoxColumn2.Width = 75
        '
        'TextBox1
        '
        TextBox1.Location = New System.Drawing.Point(115, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(152, 20)
        TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        ComboBox1.ItemHeight = 13
        ComboBox1.Location = New System.Drawing.Point(3, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(104, 21)
        ComboBox1.TabIndex = 1
        '
        'DataGrid1
        '
        DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        DataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGrid1.BackgroundColor = System.Drawing.Color.LightGray
        DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        DataGrid1.ContextMenu = ContextMenu1
        DataGrid1.DataMember = ""
        DataGrid1.FlatMode = True
        DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGrid1.ForeColor = System.Drawing.Color.MidnightBlue
        DataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
        DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        DataGrid1.LinkColor = System.Drawing.Color.Teal
        DataGrid1.Location = New System.Drawing.Point(0, 40)
        DataGrid1.Name = "DataGrid1"
        DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        DataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        DataGrid1.ParentRowsVisible = False
        DataGrid1.ReadOnly = True
        DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGrid1.Size = New System.Drawing.Size(384, 400)
        DataGrid1.TabIndex = 0
        '
        'ContextMenu1
        '
        ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {MenuItem1})
        '
        'MenuItem1
        '
        MenuItem1.Index = 0
        MenuItem1.Text = "Editar"
        '
        'PrintGrid
        '
        PrintGrid.Location = New System.Drawing.Point(291, 3)
        PrintGrid.Name = "PrintGrid"
        PrintGrid.Size = New System.Drawing.Size(56, 24)
        PrintGrid.TabIndex = 18
        PrintGrid.Text = "Imprime"
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "Data Source=SERVIDOR-BD;Initial Catalog=colegio;Integrated Security=True"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'da
        '
        da.InsertCommand = SqlInsertCommand1
        da.SelectCommand = SqlSelectCommand1
        da.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "estudiantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("apellido1", "apellido1"), New System.Data.Common.DataColumnMapping("apellido2", "apellido2"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("grupo", "grupo")})})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = "INSERT INTO estudiantes(carnet, apellido1, apellido2, nombre) VALUES (@carnet, @a" &
            "pellido1, @apellido2, @nombre)"
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@carnet", System.Data.SqlDbType.VarChar, 10, "carnet"), New System.Data.SqlClient.SqlParameter("@apellido1", System.Data.SqlDbType.VarChar, 30, "apellido1"), New System.Data.SqlClient.SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 30, "apellido2"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        SqlSelectCommand1.Connection = SqlConnection1
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Panel1.Controls.Add(PrintGrid)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(392, 37)
        Panel1.TabIndex = 1
        '
        'buscar
        '
        Controls.Add(Panel1)
        Controls.Add(DataGrid1)
        Name = "buscar"
        Size = New System.Drawing.Size(392, 448)
        CType(DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'Realizar la búsqueda según la columna
        If dv.Table.Columns(ComboBox1.Text).DataType.Name.ToLower = "string" Then
            filtro = ComboBox1.Text & " like '" & TextBox1.Text & "%'"
        Else
            If TextBox1.Text.Trim.Length > 0 Then
                filtro = ComboBox1.Text & " = " & TextBox1.Text
            End If
        End If
        dv.RowFilter = filtro
    End Sub

    Private Sub DataGrid1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseDown
        '  Dim valor As String = DataGrid1.Item(DataGrid1.CurrentCell)
        '        Clipboard.SetDataObject(valor)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If dv.Table.Columns(ComboBox1.Text).DataType.Name.ToLower = "string" Then
            filtro = ComboBox1.Text & " like '" & TextBox1.Text & "%'"
        Else
            If TextBox1.Text.Trim.Length > 0 Then
                filtro = ComboBox1.Text & " = " & TextBox1.Text
            End If
        End If
        dv.RowFilter = filtro
        comboIndex = ComboBox1.SelectedIndex
    End Sub

    ' Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
    '     Dim valor As String = DataGrid1.Item(DataGrid1.CurrentCell)
    '     Clipboard.SetDataObject(valor)
    ' End Sub

    Private Sub DataGrid1_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.Validated
        Dim valor As String = DataGrid1.Item(DataGrid1.CurrentCell)
        Clipboard.SetDataObject(valor)
    End Sub

    Private Sub buscar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim alto As Integer = Height

        Dim altopanel As Integer = Panel1.Height
        Dim altogrid As Integer = DataGrid1.Height

        DataGrid1.Height = (alto - altopanel)
        DataGrid1.Width = Width
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim carnet As String = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)
        Dim ventana As New frmEstudiantes(carnet)

        ventana.MdiParent = ParentForm
        'ventana.BuscaEstudiante1.Visible = False
        ventana.Show()
        ventana.Focus()
    End Sub

    Sub cargar_datos()
        Try
            Dim alto As Integer = Height
            Dim altopanel As Integer = Panel1.Height
            Dim altogrid As Integer = DataGrid1.Height

            DataGrid1.Height = (alto - altopanel)
            DataGrid1.Width = Width

            'Parámetros para la consulta
            Dim conn As New conexionSQL
            Dim conexion As New SqlConnection
            conexion = conn.conexion
            conexion.Open()
            SqlConnection1.ConnectionString = conn.strConn

            Dim ds As New DataSet             'Definimos el dataset y el dataadapter
            'Dim da As New SqlDataAdapter("select " & campos & " from " & tabla & _
            '              IIf(orden.Length > 0, " order by " & orden, ""), conexion)
            'Llenamos al dataset con el resultado de la consulta
            da.Fill(ds)
            'Asignamos la tabla que utiliza el dataview
            dv = ds.Tables(0).DefaultView
            'Asignar las restricciones al dataview
            'dv.AllowDelete = False
            'dv.AllowEdit = False
            'dv.AllowNew = False

            'Enlazamos el datagrid con el dataview
            DataGrid1.DataSource = dv
            'Llenamos el combo con el listado de campos
            ComboBox1.Items.Clear()
            Dim c As DataColumn
            For Each c In ds.Tables(0).Columns
                ComboBox1.Items.Add(c.ColumnName)
            Next

            ComboBox1.SelectedIndex = comboIndex  'Asignar el primer elemento como seleccionado
            conexion.Close()
            dv.RowFilter = filtro

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        cargar_datos()
    End Sub

    Private Sub buscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.cargar_datos()
    End Sub

    Private Sub buscar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        cargar_datos()
    End Sub

    Private Sub PrintGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintGrid.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object,
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim myPaintArgs As New PaintEventArgs(e.Graphics, New Rectangle(New _
           Point(0, 0), Size))
        InvokePaint(DataGrid1, myPaintArgs)
    End Sub

End Class
