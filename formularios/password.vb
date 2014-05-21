Public Class password
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents aceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(password))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.DataSet1 = New System.Data.DataSet
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.aceptar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "data source=PORTATIL;initial catalog=colegio;integrated security=SSPI;persist sec" & _
        "urity info=True;workstation id=PORTATIL;packet size=4096"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "estudiantes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("carnet", "carnet"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("apellido1", "apellido1"), New System.Data.Common.DataColumnMapping("apellido2", "apellido2"), New System.Data.Common.DataColumnMapping("encargado1", "encargado1"), New System.Data.Common.DataColumnMapping("relacion", "relacion"), New System.Data.Common.DataColumnMapping("direccion", "direccion"), New System.Data.Common.DataColumnMapping("telefono", "telefono"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("Encargado2", "Encargado2"), New System.Data.Common.DataColumnMapping("relacion2", "relacion2"), New System.Data.Common.DataColumnMapping("direccion2", "direccion2"), New System.Data.Common.DataColumnMapping("telefono2", "telefono2"), New System.Data.Common.DataColumnMapping("email2", "email2")})})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(200, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(136, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(136, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clave"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cancelar
        '
        Me.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cancelar.Location = New System.Drawing.Point(144, 96)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.TabIndex = 5
        Me.cancelar.Text = "Cancelar"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(136, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aceptar
        '
        Me.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.aceptar.Location = New System.Drawing.Point(224, 96)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.TabIndex = 6
        Me.aceptar.Text = "Aceptar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 176)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'password
        '
        Me.AcceptButton = Me.aceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.cancelar
        Me.ClientSize = New System.Drawing.Size(326, 135)
        Me.ControlBox = False
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Label3.Text = "Consultado..."
        Label3.Visible = True

        SqlDataAdapter1.SelectCommand.Parameters("@nombre").Value = Me.TextBox1.Text
        SqlDataAdapter1.Fill(DataSet1, "usuarios")

        Dim oTabla As DataTable
        Dim valor, valor2 As String
        Dim valor3 As Object

        If DataSet1.Tables("usuarios").Rows.Count > 0 Then
            oTabla = DataSet1.Tables("usuarios")
            Dim oDataRow As DataRow
            oDataRow = oTabla.Rows(0)


            valor = oDataRow("nombre")
            valor3 = oDataRow("clave")

            Dim i As Byte
            For Each i In valor3
                If i > 0 Then
                    valor2 = valor2 + ChrW(i)
                End If
            Next

            If valor2 <> TextBox2.Text Then
                Label3.Text = "Clave Incorrecta"
                Label3.Visible = True
            Else
                ' acceso al sistema
                Me.Close()
            End If

        Else
            Label3.Text = "Usuario NO registrado"
            Label3.Visible = True
        End If

    End Sub



    Private Sub password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
