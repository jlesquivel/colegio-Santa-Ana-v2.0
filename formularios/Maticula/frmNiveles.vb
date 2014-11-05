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
        Me.UserControl21 = New colegio.UserControl2
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.DsNiveles1 = New colegio.DsNiveles
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.MonedaTextBox1 = New colegio.MonedaTextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.DsNiveles1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserControl21
        '
        Me.UserControl21.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.UserControl21.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserControl21.Location = New System.Drawing.Point(0, 0)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(344, 32)
        Me.UserControl21.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DsNiveles1.niveles
        Me.ListBox1.DisplayMember = "nivel"
        Me.ListBox1.Location = New System.Drawing.Point(208, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(128, 160)
        Me.ListBox1.TabIndex = 1
        '
        'DsNiveles1
        '
        Me.DsNiveles1.DataSetName = "DsNiveles"
        Me.DsNiveles1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNiveles1, "niveles.nivel"))
        Me.TextBox1.Location = New System.Drawing.Point(80, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNiveles1, "niveles.descripcion"))
        Me.TextBox2.Location = New System.Drawing.Point(80, 120)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 32)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNiveles1, "niveles.ciclo"))
        Me.ComboBox1.Items.AddRange(New Object() {"1er ciclo", "2do ciclo", "3er ciclo", "4to ciclo"})
        Me.ComboBox1.Location = New System.Drawing.Point(80, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'MonedaTextBox1
        '
        Me.MonedaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNiveles1, "niveles.cobros"))
        Me.MonedaTextBox1.FormatoText = colegio.MonedaTextBox.formatos.Moneda
        Me.MonedaTextBox1.Location = New System.Drawing.Point(80, 160)
        Me.MonedaTextBox1.Name = "MonedaTextBox1"
        Me.MonedaTextBox1.Size = New System.Drawing.Size(120, 20)
        Me.MonedaTextBox1.TabIndex = 12
        Me.MonedaTextBox1.Text = "¢0,00"
        Me.MonedaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" & _
        "scritorio;persist security info=False;initial catalog=colegio"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "niveles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nivel", "nivel"), New System.Data.Common.DataColumnMapping("ciclo", "ciclo"), New System.Data.Common.DataColumnMapping("cobros", "cobros"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM niveles WHERE (nivel = @Original_nivel) AND (ciclo = @Original_ciclo " & _
        "OR @Original_ciclo IS NULL AND ciclo IS NULL) AND (cobros = @Original_cobros OR " & _
        "@Original_cobros IS NULL AND cobros IS NULL) AND (descripcion = @Original_descri" & _
        "pcion OR @Original_descripcion IS NULL AND descripcion IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO niveles(nivel, ciclo, cobros, descripcion) VALUES (@nivel, @ciclo, @c" & _
        "obros, @descripcion); SELECT nivel, ciclo, cobros, descripcion FROM niveles WHER" & _
        "E (nivel = @nivel)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT nivel, ciclo, cobros, descripcion FROM niveles"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE niveles SET nivel = @nivel, ciclo = @ciclo, cobros = @cobros, descripcion " & _
        "= @descripcion WHERE (nivel = @Original_nivel) AND (ciclo = @Original_ciclo OR @" & _
        "Original_ciclo IS NULL AND ciclo IS NULL) AND (cobros = @Original_cobros OR @Ori" & _
        "ginal_cobros IS NULL AND cobros IS NULL) AND (descripcion = @Original_descripcio" & _
        "n OR @Original_descripcion IS NULL AND descripcion IS NULL); SELECT nivel, ciclo" & _
        ", cobros, descripcion FROM niveles WHERE (nivel = @nivel)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nivel", System.Data.SqlDbType.VarChar, 15, "nivel"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ciclo", System.Data.SqlDbType.VarChar, 15, "ciclo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cobros", System.Data.SqlDbType.Money, 8, "cobros"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nivel", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ciclo", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ciclo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cobros", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cobros", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nivel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Ciclo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(24, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cobro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(216, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Niveles Creados"
        '
        'frmNiveles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 237)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MonedaTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.UserControl21)
        Me.Name = "frmNiveles"
        Me.Text = "Niveles"
        CType(Me.DsNiveles1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
            Me.BindingContext(DsNiveles1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsNiveles1, Me.bd).AddNew()
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Public Sub guardar()
        Try
            Me.BindingContext(DsNiveles1, Me.bd).EndCurrentEdit()
            SqlDataAdapter1.Update(DsNiveles1, Me.bd)
            DsNiveles1.AcceptChanges()
            Me.SqlDataAdapter1.Fill(DsNiveles1, "niveles")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OKOnly, "Ocurrió un error")
        End Try
    End Sub
    Public Sub borrar()
        Try
            'Borrar las ediciones actuales

            Dim Registro As Integer

            Registro = Me.BindingContext(DsNiveles1, Me.bd).Position
            Me.BindingContext(DsNiveles1, Me.bd).EndCurrentEdit()
            Me.BindingContext(DsNiveles1, Me.bd).RemoveAt(Registro)
            Me.SqlDataAdapter1.Update(DsNiveles1, Me.bd)
            Me.BindingContext(DsNiveles1, Me.bd).Position = 0
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub buscar()
        Try
            Me.BindingContext(DsNiveles1, Me.bd).EndCurrentEdit()
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
                Me.BindingContext(DsNiveles1, Me.bd).Position = prmPos
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
        Me.SqlConnection1.ConnectionString = conn.strConn

        Me.UserControl21.Imprimir.Visible = False
        Me.SqlDataAdapter1.Fill(DsNiveles1, "niveles")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'Me.guardar()
        Me.BindingContext(DsNiveles1, Me.bd).Position = ListBox1.SelectedIndex
        Me.BindingContext(DsNiveles1, Me.bd).EndCurrentEdit()
    End Sub

    Private Sub frmNiveles_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.guardar()
    End Sub
End Class
