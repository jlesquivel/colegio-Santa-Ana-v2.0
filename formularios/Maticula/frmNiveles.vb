Public Class frmNiveles
     Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim bd As String = "niveles"

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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MonedaTextBox1 As colegio.MonedaTextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsNiveles1 As colegio.DsNiveles
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNiveles))
        UserControl21 = New colegio.UserControl2()
        ListBox1 = New System.Windows.Forms.ListBox()
        DsNiveles1 = New colegio.DsNiveles()
        TextBox1 = New System.Windows.Forms.TextBox()
        TextBox2 = New System.Windows.Forms.TextBox()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        MonedaTextBox1 = New colegio.MonedaTextBox()
        SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(DsNiveles1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'UserControl21
        '
        UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        UserControl21.Location = New System.Drawing.Point(0, 0)
        UserControl21.Name = "UserControl21"
        UserControl21.Size = New System.Drawing.Size(344, 32)
        UserControl21.TabIndex = 0
        '
        'ListBox1
        '
        ListBox1.DataSource = DsNiveles1.niveles
        ListBox1.DisplayMember = "nivel"
        ListBox1.Location = New System.Drawing.Point(266, 64)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New System.Drawing.Size(70, 160)
        ListBox1.TabIndex = 1
        '
        'DsNiveles1
        '
        DsNiveles1.DataSetName = "DsNiveles"
        DsNiveles1.Locale = New System.Globalization.CultureInfo("es-CR")
        DsNiveles1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsNiveles1, "niveles.nivel", True))
        TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox1.Location = New System.Drawing.Point(80, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(163, 22)
        TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsNiveles1, "niveles.descripcion", True))
        TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox2.Location = New System.Drawing.Point(80, 120)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New System.Drawing.Size(163, 32)
        TextBox2.TabIndex = 3
        '
        'ComboBox1
        '
        ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsNiveles1, "niveles.ciclo", True))
        ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComboBox1.Items.AddRange(New Object() {"Educación General Básica", "Educacion Diversificada"})
        ComboBox1.Location = New System.Drawing.Point(80, 91)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(163, 24)
        ComboBox1.TabIndex = 8
        '
        'MonedaTextBox1
        '
        MonedaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsNiveles1, "niveles.cobros", True))
        MonedaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        MonedaTextBox1.Location = New System.Drawing.Point(80, 160)
        MonedaTextBox1.Name = "MonedaTextBox1"
        MonedaTextBox1.Size = New System.Drawing.Size(120, 22)
        MonedaTextBox1.TabIndex = 12
        MonedaTextBox1.Text = "¢0,00"
        MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SqlConnection1
        '
        SqlConnection1.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" & _
    "scritorio;persist security info=False;initial catalog=colegio"
        SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        SqlDataAdapter1.DeleteCommand = SqlDeleteCommand1
        SqlDataAdapter1.InsertCommand = SqlInsertCommand1
        SqlDataAdapter1.SelectCommand = SqlSelectCommand1
        SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "niveles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("ciclo", "ciclo"), New System.Data.Common.DataColumnMapping("cobros", "cobros"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        SqlDataAdapter1.UpdateCommand = SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        SqlDeleteCommand1.Connection = SqlConnection1
        SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        SqlInsertCommand1.CommandText = "INSERT INTO niveles(nivel, ciclo, cobros, descripcion) VALUES (@nivel, @ciclo, @c" & _
    "obros, @descripcion); SELECT nivel, ciclo, cobros, descripcion FROM niveles WHER" & _
    "E (nivel = @nivel)"
        SqlInsertCommand1.Connection = SqlConnection1
        SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion")})
        '
        'SqlSelectCommand1
        '
        SqlSelectCommand1.CommandText = "SELECT nivel, ciclo, cobros, descripcion FROM niveles"
        SqlSelectCommand1.Connection = SqlConnection1
        '
        'SqlUpdateCommand1
        '
        SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        SqlUpdateCommand1.Connection = SqlConnection1
        SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"), New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"), New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"), New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Label1
        '
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(8, 64)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(63, 23)
        Label1.TabIndex = 13
        Label1.Text = "Nivel"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Location = New System.Drawing.Point(8, 96)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(63, 24)
        Label3.TabIndex = 15
        Label3.Text = "Ciclo"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(16, 128)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 23)
        Label2.TabIndex = 14
        Label2.Text = "Descripción"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Location = New System.Drawing.Point(24, 160)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(48, 23)
        Label5.TabIndex = 17
        Label5.Text = "Cobro"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Location = New System.Drawing.Point(236, 41)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 20)
        Label4.TabIndex = 16
        Label4.Text = "Niveles Creados"
        '
        'frmNiveles
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(344, 237)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(MonedaTextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(UserControl21)
        DoubleBuffered = True
        Name = "frmNiveles"
        Text = "Niveles"
        CType(DsNiveles1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region
    Public Sub nuevo()
        Try
            Dim i, x As Integer
            For i = 0 To Controls.Count - 1
                For x = 1 To Controls(i).Controls.Count - 1
                    If TypeOf Controls(i).Controls(x) Is TextBox Then
                        CType(Controls(i).Controls(x), TextBox).Text = ""
                    End If
                Next x
            Next i
            TextBox1.Focus()
            'Borrar las ediciones actuales
            BindingContext(DsNiveles1, bd).EndCurrentEdit()
            BindingContext(DsNiveles1, bd).AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Public Sub guardar()
        Try
            BindingContext(DsNiveles1, bd).EndCurrentEdit()
            SqlDataAdapter1.Update(DsNiveles1, bd)
            DsNiveles1.AcceptChanges()
            SqlDataAdapter1.Fill(DsNiveles1, "niveles")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, "Ocurrió un error")
        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales

            Dim Registro As Integer

            Registro = BindingContext(DsNiveles1, bd).Position
            BindingContext(DsNiveles1, bd).EndCurrentEdit()
            BindingContext(DsNiveles1, bd).RemoveAt(Registro)
            SqlDataAdapter1.Update(DsNiveles1, bd)
            BindingContext(DsNiveles1, bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            BindingContext(DsNiveles1, bd).EndCurrentEdit()
            Dim prmPos As Integer
            Dim dvCatClientes As DataView = _
            New DataView(DsNiveles1.Tables(0), "", "nivel", DataViewRowState.CurrentRows)
            Dim varID_CLIENTE As String = ""
            varID_CLIENTE = InputBox("Introduce el nivel a buscar", "Buscar")
            If Not varID_CLIENTE = "" Then
                prmPos = dvCatClientes.Find(varID_CLIENTE)
                If prmPos = -1 Then
                    MessageBox.Show("nivel no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                BindingContext(DsNiveles1, bd).Position = prmPos
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
   
    Private Sub frmNiveles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New conexionSQL
        SqlConnection1.ConnectionString = conn.strConn

        UserControl21.Imprimir.Visible = False
        SqlDataAdapter1.Fill(DsNiveles1, "niveles")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'Me.guardar()
        BindingContext(DsNiveles1, bd).Position = ListBox1.SelectedIndex
        BindingContext(DsNiveles1, bd).EndCurrentEdit()
    End Sub

    Private Sub frmNiveles_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        guardar()
    End Sub
End Class
