Imports System.Data.SqlClient

Public Class frmGenNotas
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
    Friend WithEvents XpGradientPanel1 As SteepValley.Windows.Forms.XPGradientPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XpGradientPanel1 = New SteepValley.Windows.Forms.XPGradientPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.XpGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.Controls.Add(Me.Label1)
        Me.XpGradientPanel1.Controls.Add(Me.Button2)
        Me.XpGradientPanel1.Controls.Add(Me.ComboBox1)
        Me.XpGradientPanel1.Controls.Add(Me.Button1)
        Me.XpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(232, 142)
        Me.XpGradientPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(32, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancelar "
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(120, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aceptar  "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_mat, periodo, materia, nota, profesora, fecha_nota, generado FROM notas" & _
        ""
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ESCRITORIO;packet size=4096;integrated security=SSPI;data source=e" & _
        "scritorio;persist security info=False;initial catalog=colegio"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO notas(id_mat, periodo, materia, nota, profesora, fecha_nota, generado" & _
        ") VALUES (@id_mat, @periodo, @materia, @nota, @profesora, @fecha_nota, @generado" & _
        "); SELECT id_mat, periodo, materia, nota, profesora, fecha_nota, generado FROM n" & _
        "otas"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_mat", System.Data.SqlDbType.VarChar, 31, "id_mat"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@periodo", System.Data.SqlDbType.VarChar, 1, "periodo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@materia", System.Data.SqlDbType.VarChar, 15, "materia"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nota", System.Data.SqlDbType.Int, 4, "nota"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@profesora", System.Data.SqlDbType.VarChar, 15, "profesora"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fecha_nota", System.Data.SqlDbType.DateTime, 8, "fecha_nota"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@generado", System.Data.SqlDbType.DateTime, 8, "generado"))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "notas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_mat", "id_mat"), New System.Data.Common.DataColumnMapping("periodo", "periodo"), New System.Data.Common.DataColumnMapping("materia", "materia"), New System.Data.Common.DataColumnMapping("nota", "nota"), New System.Data.Common.DataColumnMapping("profesora", "profesora"), New System.Data.Common.DataColumnMapping("fecha_nota", "fecha_nota"), New System.Data.Common.DataColumnMapping("generado", "generado")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT DISTINCT periodo FROM notas WHERE (YEAR(generado) = YEAR({ fn NOW() }))"
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'frmGenNotas
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(232, 142)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "frmGenNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Genera Notas"
        Me.XpGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmGenNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New conexionSQL
        Me.SqlConnection1.ConnectionString = conn.strConn

        Me.SqlConnection1.Open()
        Dim myReader As SqlDataReader = SqlCommand1.ExecuteReader  'lee los periodos de notas generados
        While myReader.Read
            ComboBox1.Items.Remove(myReader.GetString(0))   'y los elimina del combobox , para no
        End While                                           ' volverlos a generar
        Me.SqlConnection1.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedIndex > -1 Then
                Dim comando2 As New SqlCommand
                comando2.Connection = Me.SqlConnection1
                comando2.CommandText = "EXEC crea_notas '" & ComboBox1.Text & "' , '" & Year(Now) & "'"

                Me.SqlConnection1.Open()
                Dim myReader As Integer = comando2.ExecuteNonQuery
                Me.SqlConnection1.Close()
                MessageBox.Show("Notas Generadas, favor llenar las notas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
