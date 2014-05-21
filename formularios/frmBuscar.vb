Public Class frmBuscar
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
    Friend WithEvents Buscar1 As colegio.buscar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Buscar1 = New colegio.buscar
        Me.SuspendLayout()
        '
        'Buscar1
        '
        Me.Buscar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Buscar1.Location = New System.Drawing.Point(0, 0)
        Me.Buscar1.Name = "Buscar1"
        Me.Buscar1.Size = New System.Drawing.Size(336, 438)
        Me.Buscar1.TabIndex = 0
        '
        'frmBuscar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 438)
        Me.Controls.Add(Me.Buscar1)
        Me.Name = "frmBuscar"
        Me.Text = "Buscar"
        Me.ResumeLayout(False)

    End Sub

#End Region

   
End Class
