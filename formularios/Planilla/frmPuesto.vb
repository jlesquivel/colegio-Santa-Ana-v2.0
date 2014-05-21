Public Class frmPuesto
    Inherits System.Windows.Forms.Form
    Dim puesto As String
    Dim borra As Boolean
    Dim id_planilla As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal P_id As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        id_planilla = P_id
    End Sub

    Public Sub New(ByVal ppuesto As String, ByVal pborra As Boolean)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        puesto = ppuesto
        borra = pborra

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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DsPlanilla1 As colegio.dsPlanilla
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPuesto))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataView1 = New System.Data.DataView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DsPlanilla1 = New colegio.dsPlanilla
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_puesto, id_dpto, nombre, forma_pago FROM dbo.puestos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SERVIDOR_BD;packet size=4096;user id=marlene;data source=SERVIDOR_" & _
        "BD;persist security info=False;initial catalog=planilla"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO dbo.puestos(id_dpto, nombre, forma_pago) VALUES (@id_dpto, @nombre, @" & _
        "forma_pago); SELECT id_puesto, id_dpto, nombre, forma_pago FROM dbo.puestos WHER" & _
        "E (id_puesto = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.VarChar, 50, "forma_pago"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE dbo.puestos SET id_dpto = @id_dpto, nombre = @nombre, forma_pago = @forma_" & _
        "pago WHERE (id_puesto = @Original_id_puesto) AND (forma_pago = @Original_forma_p" & _
        "ago) AND (id_dpto = @Original_id_dpto) AND (nombre = @Original_nombre); SELECT i" & _
        "d_puesto, id_dpto, nombre, forma_pago FROM dbo.puestos WHERE (id_puesto = @id_pu" & _
        "esto)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@forma_pago", System.Data.SqlDbType.VarChar, 50, "forma_pago"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_forma_pago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "forma_pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM dbo.puestos WHERE (id_puesto = @Original_id_puesto) AND (forma_pago =" & _
        " @Original_forma_pago) AND (id_dpto = @Original_id_dpto) AND (nombre = @Original" & _
        "_nombre)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_puesto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_forma_pago", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "forma_pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_dpto", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "id_dpto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "puestos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_puesto", "id_puesto"), New System.Data.Common.DataColumnMapping("id_dpto", "id_dpto"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("forma_pago", "forma_pago")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "nombre"))
        Me.TextBox1.Location = New System.Drawing.Point(128, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsPlanilla1.puestos
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Forma Pago"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "forma_pago"))
        Me.ComboBox1.Items.AddRange(New Object() {"Semanal", "Quincenal", "Bisemanal", "Mensual"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Guardar"
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(208, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 40)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(256, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(16, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Puesto"
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'frmPuesto
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(304, 174)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmPuesto"
        Me.Text = "Puesto"
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPuesto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New conexionSQL
        conn.bd = "planilla"
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlDataAdapter1.Fill(DsPlanilla1)

        If puesto = "" Then
            Me.BindingContext(Me.DataView1).AddNew()
            Dim nuevo As DataRowView = Me.BindingContext(Me.DataView1).Current()
            nuevo.Item("id_dpto") = id_planilla
        Else
            Me.buscar(puesto)
            If borra Then
                Dim registro As Integer = Me.BindingContext(DataView1).Position
                Me.BindingContext(Me.DataView1).RemoveAt(registro)
                Me.SqlDataAdapter1.Update(Me.DsPlanilla1, "puestos")
            Else
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub buscar(ByVal nombre As String)
        Me.DataView1.RowFilter = "nombre = '" & nombre & "'"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BindingContext(DataView1).EndCurrentEdit()
        Me.SqlDataAdapter1.Update(Me.DsPlanilla1, "puestos")
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub borrap()
        Dim conn As New conexionSQL
        conn.bd = "planilla"
        Me.SqlConnection1.ConnectionString = conn.strConn
        Me.SqlDataAdapter1.Fill(DsPlanilla1)

        Me.buscar(puesto)
        If borra Then
            Dim registro As Integer = Me.BindingContext(DataView1).Position
            Me.BindingContext(Me.DataView1).RemoveAt(registro)
            Me.SqlDataAdapter1.Update(Me.DsPlanilla1, "puestos")
        Else
            Me.Refresh()
        End If
    End Sub
End Class
