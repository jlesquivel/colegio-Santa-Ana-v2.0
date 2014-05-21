Public Class frmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sqlcon As New conexionSQL
        If sqlcon.conexionOK Then
            Me.Visible = False
            frmPrincipal2.Show()
        Else
            MessageBox.Show("No se pudo conectar al servido SQL", "SQL Error!", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Dim dominio As NetworkInformation = NetworkInformation.LocalComputer

        If dominio.Status = NetworkInformation.JoinStatus.Domain Then
            Me.Visible = False
            frmPrincipal2.Show()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim conn As New conexionSQL

        If Not conn.conexionOK Then
            Me.Text = "Sin conexion al servidor"
            Me.TextBoxX1.Enabled = False
            Me.TextBoxX2.Enabled = False
            Me.Button1.Enabled = False
            Me.Button2.Enabled = False

            Me.PictureBox1.Image = colegio.My.Resources.Resources.ndb
        End If
    End Sub
End Class