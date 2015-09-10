Public Class frmCuotas
     Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim bd As String = "cuotas"

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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents UserControl21 As colegio.UserControl2
    Friend WithEvents DsCuotas1 As colegio.dsCuotas
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MonedaTextBox1 As colegio.MonedaTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        SqlConnection1 = New System.Data.SqlClient.SqlConnection
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        UserControl21 = New colegio.UserControl2
        DsCuotas1 = New colegio.dsCuotas
        ListBox1 = New System.Windows.Forms.ListBox
        TextBox1 = New System.Windows.Forms.TextBox
        MonedaTextBox1 = New colegio.MonedaTextBox
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        SqlCommand1 = New System.Data.SqlClient.SqlCommand
        CType(DsCuotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT descripcion, monto FROM cuotas"
        SqlSelectCommand1.Connection = SqlConnection1
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "data source=PORTATIL;initial catalog=colegio;integrated security=SSPI;persist sec" & _
        "urity info=False;workstation id=PORTATIL;packet size=4096"
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = "INSERT INTO cuotas(descripcion, monto) VALUES (@descripcion, @monto); SELECT desc" & _
        "ripcion, monto FROM cuotas WHERE (descripcion = @descripcion)"
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 10, "descripcion"))
        SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = "UPDATE cuotas SET descripcion = @descripcion, monto = @monto WHERE (descripcion =" & _
        " @Original_descripcion) AND (monto = @Original_monto OR @Original_monto IS NULL " & _
        "AND monto IS NULL); SELECT descripcion, monto FROM cuotas WHERE (descripcion = @" & _
        "descripcion)"
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 10, "descripcion"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = "DELETE FROM cuotas WHERE (descripcion = @Original_descripcion) AND (monto = @Orig" & _
        "inal_monto OR @Original_monto IS NULL AND monto IS NULL)"
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand1
        SqlDataAdapter1.InsertCommand = SqlInsertCommand1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cuotas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("monto", "monto")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand1
        '
        'UserControl21
        '
        UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        UserControl21.Location = New System.Drawing.Point(0, 0)
        UserControl21.Name = "UserControl21"
        UserControl21.Size = New System.Drawing.Size(320, 32)
        UserControl21.TabIndex = 0
        '
        'DsCuotas1
        '
        DsCuotas1.DataSetName = "dsCuotas"
        DsCuotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'ListBox1
        '
        ListBox1.DataSource = DsCuotas1.cuotas
        ListBox1.DisplayMember = "descripcion"
        ListBox1.Location = New System.Drawing.Point(184, 48)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New System.Drawing.Size(128, 186)
        ListBox1.TabIndex = 1
        ListBox1.ValueMember = "descripcion"
        '
        'TextBox1
        '
        TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsCuotas1, "cuotas.descripcion"))
        TextBox1.Location = New System.Drawing.Point(72, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.TabIndex = 2
        TextBox1.Text = ""
        '
        'MonedaTextBox1
        '
        MonedaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsCuotas1, "cuotas.monto"))
        MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        MonedaTextBox1.Location = New System.Drawing.Point(72, 96)
        MonedaTextBox1.Name = "MonedaTextBox1"
        MonedaTextBox1.TabIndex = 6
        MonedaTextBox1.Text = "¢0,00"
        MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(16, 64)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 23)
        Label1.TabIndex = 7
        Label1.Text = "Cuota"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(16, 96)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(48, 23)
        Label2.TabIndex = 8
        Label2.Text = "monto"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlCommand1
        '
        SqlCommand1.Connection = SqlConnection1
        '
        'frmCuotas
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(320, 254)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(MonedaTextBox1)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(UserControl21)
        Name = "frmCuotas"
        Text = "Tabla Cuotas"
        CType(DsCuotas1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

#End Region

    Public Sub nuevo()
        Try
            'Borrar las ediciones actuales
            BindingContext(DsCuotas1, bd).EndCurrentEdit()
            BindingContext(DsCuotas1, bd).AddNew()

            TextBox1.Text = ""
            TextBox1.Focus()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Public Sub guardar()
        Try
            BindingContext(DsCuotas1, bd).EndCurrentEdit()
            SqlDataAdapter1.Update(DsCuotas1, bd)
            DsCuotas1.AcceptChanges()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, "Ocurrió un error")
        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales

            Dim Registro As Integer

            Registro = BindingContext(DsCuotas1, bd).Position
            BindingContext(DsCuotas1, bd).EndCurrentEdit()
            BindingContext(DsCuotas1, bd).RemoveAt(Registro)
            SqlDataAdapter1.Update(DsCuotas1, bd)
            BindingContext(DsCuotas1, bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try

            BindingContext(DsCuotas1, bd).EndCurrentEdit()
            Dim prmPos As Integer
            Dim dvCatClientes As DataView = _
            New DataView(DsCuotas1.Tables(bd), "", "descripcion", DataViewRowState.CurrentRows)
            Dim varID_CLIENTE As String = ""
            varID_CLIENTE = InputBox("Introduce la cuota a buscar", "Buscar")
            If Not varID_CLIENTE = "" Then
                prmPos = dvCatClientes.Find(varID_CLIENTE)
                If prmPos = -1 Then
                    MessageBox.Show("cuota no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                BindingContext(DsCuotas1, bd).Position = prmPos
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

    Private Sub frmCuotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim conn As New conexionSQL
            SqlConnection1.ConnectionString = conn.strConn

            UserControl21.Imprimir.Visible = False
            SqlDataAdapter1.Fill(DsCuotas1, "cuotas")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
      

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        BindingContext(DsCuotas1, bd).Position = ListBox1.SelectedIndex
    End Sub


    Private Sub MonedaTextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonedaTextBox1.Validated
        guardar()
    End Sub
End Class
