
Public Class frmEstudiantes
    Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim pcarnet As String


#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal carnet As String)
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()
        Estudiantes1.BuscarVisible = False
        pcarnet = carnet
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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents Estudiantes1 As colegio.Estudiantes
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Estudiantes1 = New colegio.Estudiantes()
        SuspendLayout()
        '
        'Estudiantes1
        '
        Estudiantes1.BuscarVisible = True
        Estudiantes1.Dock = System.Windows.Forms.DockStyle.Fill
        Estudiantes1.Location = New System.Drawing.Point(0, 0)
        Estudiantes1.Name = "Estudiantes1"
        Estudiantes1.Size = New System.Drawing.Size(768, 459)
        Estudiantes1.TabIndex = 0
        '
        'frmEstudiantes
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(768, 459)
        Controls.Add(Estudiantes1)
        DoubleBuffered = True
        Name = "frmEstudiantes"
        Text = "Estudiantes"
        ResumeLayout(False)

    End Sub

#End Region

    'Private Sub Estudiantes1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Estudiantes1.SizeChanged
    '    Me.Width = Estudiantes1.Width
    'End Sub

    Private Sub frmEstudiantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If DesignMode Then
            ' The component is in design mode

        Else
            If Not pcarnet = "" Then
                Estudiantes1.buscar(pcarnet)
            End If
        End If

    End Sub

    Public Sub buscar(ByVal pcarnet As String)
        If Not pcarnet = "" Then
            Estudiantes1.buscar(pcarnet)
        End If
    End Sub


    Private Sub frmEstudiantes_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class
