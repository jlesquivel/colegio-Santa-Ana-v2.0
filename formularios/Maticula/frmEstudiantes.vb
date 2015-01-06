
Public Class frmEstudiantes
    Inherits DevComponents.DotNetBar.Metro.MetroForm
    Dim pcarnet As String


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal carnet As String)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Estudiantes1.BuscarVisible = False
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Estudiantes1 As colegio.Estudiantes
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Estudiantes1 = New colegio.Estudiantes()
        Me.SuspendLayout()
        '
        'Estudiantes1
        '
        Me.Estudiantes1.BuscarVisible = True
        Me.Estudiantes1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Estudiantes1.Location = New System.Drawing.Point(0, 0)
        Me.Estudiantes1.Name = "Estudiantes1"
        Me.Estudiantes1.Size = New System.Drawing.Size(768, 459)
        Me.Estudiantes1.TabIndex = 0
        '
        'frmEstudiantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 459)
        Me.Controls.Add(Me.Estudiantes1)
        Me.DoubleBuffered = True
        Me.Name = "frmEstudiantes"
        Me.Text = "Estudiantes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Sub Estudiantes1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Estudiantes1.SizeChanged
    '    Me.Width = Estudiantes1.Width
    'End Sub

    Private Sub frmEstudiantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.DesignMode Then
            ' The component is in design mode

        Else
            If Not pcarnet = "" Then
                Me.Estudiantes1.buscar(pcarnet)
            End If
        End If

    End Sub

    Public Sub buscar(ByVal pcarnet As String)
        If Not pcarnet = "" Then
            Me.Estudiantes1.buscar(pcarnet)
        End If
    End Sub


    Private Sub frmEstudiantes_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class
