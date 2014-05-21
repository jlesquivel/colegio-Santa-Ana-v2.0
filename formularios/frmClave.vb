Imports System.Security
Imports System.Threading
Imports System.Security.Principal
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports SteepValley.Windows.Forms.ThemedControls

Public Class frmClave
    Inherits System.Windows.Forms.Form

    Public WithEvents listener As New ThemeListener(Me)

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
    Friend WithEvents XpLetterBox1 As SteepValley.Windows.Forms.ThemedControls.XPLetterBox
    Friend WithEvents XpLoginEntry1 As SteepValley.Windows.Forms.XPLoginEntry
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmClave))
        Me.XpLetterBox1 = New SteepValley.Windows.Forms.ThemedControls.XPLetterBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.XpLoginEntry1 = New SteepValley.Windows.Forms.XPLoginEntry
        Me.XpLetterBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpLetterBox1
        '
        Me.XpLetterBox1.BackColor = System.Drawing.Color.Transparent
        Me.XpLetterBox1.Controls.Add(Me.Label3)
        Me.XpLetterBox1.Controls.Add(Me.PictureBox2)
        Me.XpLetterBox1.Controls.Add(Me.Label2)
        Me.XpLetterBox1.Controls.Add(Me.Label1)
        Me.XpLetterBox1.Controls.Add(Me.PictureBox1)
        Me.XpLetterBox1.Controls.Add(Me.XpLoginEntry1)
        Me.XpLetterBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XpLetterBox1.DockPadding.Bottom = 48
        Me.XpLetterBox1.DockPadding.Top = 48
        Me.XpLetterBox1.DrawVerticalSplitLine = True
        Me.XpLetterBox1.Location = New System.Drawing.Point(0, 0)
        Me.XpLetterBox1.Name = "XpLetterBox1"
        Me.XpLetterBox1.Size = New System.Drawing.Size(432, 264)
        Me.XpLetterBox1.TabIndex = 0
        Me.XpLetterBox1.ThemeFormat.BottomBodyColor = System.Drawing.Color.RoyalBlue
        Me.XpLetterBox1.ThemeFormat.FooterColor = System.Drawing.Color.DarkBlue
        Me.XpLetterBox1.ThemeFormat.HeaderColor = System.Drawing.Color.DarkBlue
        Me.XpLetterBox1.ThemeFormat.HeaderTextColor = System.Drawing.Color.DarkBlue
        Me.XpLetterBox1.ThemeFormat.HeaderTextFont = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XpLetterBox1.ThemeFormat.TopBodyColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(64, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Salir"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(32, 224)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(8, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hermanas de la Caridad de Santa Ana"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Colegio Santa Ana"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'XpLoginEntry1
        '
        Me.XpLoginEntry1.BackColor = System.Drawing.Color.Transparent
        Me.XpLoginEntry1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.XpLoginEntry1.HasPassword = True
        Me.XpLoginEntry1.HelpString = "Digite su clave"
        Me.XpLoginEntry1.Icon = CType(resources.GetObject("XpLoginEntry1.Icon"), System.Drawing.Icon)
        Me.XpLoginEntry1.Location = New System.Drawing.Point(224, 104)
        Me.XpLoginEntry1.Name = "XpLoginEntry1"
        Me.XpLoginEntry1.Size = New System.Drawing.Size(200, 60)
        Me.XpLoginEntry1.TabIndex = 0
        Me.XpLoginEntry1.UserName = "Administrador"
        '
        'frmClave
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 264)
        Me.Controls.Add(Me.XpLetterBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clave"
        Me.XpLetterBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub XpLoginEntry1_Login(ByVal sender As Object, ByVal e As SteepValley.Windows.Forms.LoginEventArgs) Handles XpLoginEntry1.Login
        Dim conn As New conexionSQL("192.168.0.1", "colegio", e.User, e.Password)
        If conn.conexionOK Then
            ' crea el archivo de password general
            Serialize(e.User, e.Password)
        End If
        Me.Close()
    End Sub

    Sub Serialize(ByVal v1 As String, ByVal v2 As String)
        ' Create a hashtable of values that will eventually be serialized.
        Dim addresses As New Hashtable
        addresses.Add(v1, v2)
        Dim fs As New FileStream("DataFile.dat", FileMode.Create)
        Dim formatter As New BinaryFormatter
        Try
            formatter.Serialize(fs, addresses)
        Catch e As SerializationException
            Console.WriteLine("Failed to serialize. Reason: " & e.Message)
            Throw
        Finally
            fs.Close()
        End Try
    End Sub

    Private Sub frmClave_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyIdentity As WindowsIdentity = WindowsIdentity.GetCurrent()

        Dim cuentas As String() = MyIdentity.Name.Split("\")
        Me.XpLoginEntry1.UserName = cuentas(1)
        Me.XpLoginEntry1.ShowPasswordBox()

        If cuentas(1) = "Jose Luis" Then
            Serialize(cuentas(1), "123")
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class
