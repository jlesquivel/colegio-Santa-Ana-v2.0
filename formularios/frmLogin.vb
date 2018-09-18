Public Class frmLogin
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    Dim conn As ConexionSQL
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load

        conn = New ConexionSQL("servidor-bd", "colegio", "sa", "123")

        If Not conn.conexionOK Then
            Text = "Sin conexion al servidor"
            TextBoxX1.Enabled = False
            TextBoxX2.Enabled = False
            ButtonX1.Enabled = False
            ButtonX2.Enabled = False
            PictureBox1.Image = colegio.My.Resources.Resources.ndb
        Else
            Dim info As NetworkInformation = NetworkInformation.LocalComputer
            If info.Status = NetworkInformation.JoinStatus.Domain Then
                Me.Hide()
                ' Visible = False
                frmPrincipal2.Show()
                Close()
            End If
        End If
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim sqlcon As New ConexionSQL("SERVIDOR-BD", "colegio", TextBoxX1.Text, TextBoxX2.Text)
        My.Settings.conexionSQL = sqlcon.strConn

        If sqlcon.conexionOK Then
            Me.Hide()
            'Visible = False
            frmPrincipal2.Show()
            Close()
        Else
            MessageBox.Show("Usuario o clave incorrecta", "SQL Error!",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Close()
    End Sub

End Class