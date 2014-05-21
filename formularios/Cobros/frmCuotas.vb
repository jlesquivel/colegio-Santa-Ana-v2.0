Public Class frmCuotas
    Inherits System.Windows.Forms.Form
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.UserControl21 = New colegio.UserControl2
        Me.DsCuotas1 = New colegio.dsCuotas
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.MonedaTextBox1 = New colegio.MonedaTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsCuotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT descripcion, monto FROM cuotas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=PORTATIL;initial catalog=colegio;integrated security=SSPI;persist sec" & _
        "urity info=False;workstation id=PORTATIL;packet size=4096"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cuotas(descripcion, monto) VALUES (@descripcion, @monto); SELECT desc" & _
        "ripcion, monto FROM cuotas WHERE (descripcion = @descripcion)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 10, "descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cuotas SET descripcion = @descripcion, monto = @monto WHERE (descripcion =" & _
        " @Original_descripcion) AND (monto = @Original_monto OR @Original_monto IS NULL " & _
        "AND monto IS NULL); SELECT descripcion, monto FROM cuotas WHERE (descripcion = @" & _
        "descripcion)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 10, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@monto", System.Data.SqlDbType.Money, 8, "monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cuotas WHERE (descripcion = @Original_descripcion) AND (monto = @Orig" & _
        "inal_monto OR @Original_monto IS NULL AND monto IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_monto", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "monto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cuotas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("monto", "monto")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(0, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(320, 32)
        Me.UserControl21.TabIndex = 0
        '
        'DsCuotas1
        '
        Me.DsCuotas1.DataSetName = "dsCuotas"
        Me.DsCuotas1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DsCuotas1.cuotas
        Me.ListBox1.DisplayMember = "descripcion"
        Me.ListBox1.Location = New System.Drawing.Point(184, 48)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(128, 186)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "descripcion"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCuotas1, "cuotas.descripcion"))
        Me.TextBox1.Location = New System.Drawing.Point(72, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'MonedaTextBox1
        '
        Me.MonedaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCuotas1, "cuotas.monto"))
        Me.MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.MonedaTextBox1.Location = New System.Drawing.Point(72, 96)
        Me.MonedaTextBox1.Name = "MonedaTextBox1"
        Me.MonedaTextBox1.TabIndex = 6
        Me.MonedaTextBox1.Text = "¢0,00"
        Me.MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cuota"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "monto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlCommand1
        '
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'frmCuotas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 254)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonedaTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.UserControl21)
        Me.Name = "frmCuotas"
        Me.Text = "Tabla Cuotas"
        CType(Me.DsCuotas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub nuevo()
        Try
            'Borrar las ediciones actuales
            Me.BindingContext(DsCuotas1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsCuotas1, Me.bd).AddNew()

            TextBox1.Text = ""
            TextBox1.Focus()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Public Sub guardar()
        Try
            Me.BindingContext(DsCuotas1, Me.bd).EndCurrentEdit()
            SqlDataAdapter1.Update(DsCuotas1, Me.bd)
            DsCuotas1.AcceptChanges()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, "Ocurrió un error")
        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales

            Dim Registro As Integer

            Registro = Me.BindingContext(DsCuotas1, Me.bd).Position
            Me.BindingContext(DsCuotas1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsCuotas1, Me.bd).RemoveAt(Registro)
            Me.SqlDataAdapter1.Update(DsCuotas1, Me.bd)
            Me.BindingContext(DsCuotas1, Me.bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try

            Me.BindingContext(DsCuotas1, Me.bd).EndCurrentEdit()
            Dim prmPos As Integer
            Dim dvCatClientes As DataView = _
            New DataView(DsCuotas1.Tables(Me.bd), "", "descripcion", DataViewRowState.CurrentRows)
            Dim varID_CLIENTE As String = ""
            varID_CLIENTE = InputBox("Introduce la cuota a buscar", "Buscar")
            If Not varID_CLIENTE = "" Then
                prmPos = dvCatClientes.Find(varID_CLIENTE)
                If prmPos = -1 Then
                    MessageBox.Show("cuota no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Me.BindingContext(DsCuotas1, Me.bd).Position = prmPos
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
            Me.SqlConnection1.ConnectionString = conn.strConn

            Me.UserControl21.Imprimir.Visible = False
            Me.SqlDataAdapter1.Fill(DsCuotas1, "cuotas")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
      

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.BindingContext(DsCuotas1, Me.bd).Position = ListBox1.SelectedIndex
    End Sub


    Private Sub MonedaTextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonedaTextBox1.Validated
        Me.guardar()
    End Sub
End Class
