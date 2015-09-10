Public Class frmReporte
     Inherits DevComponents.DotNetBar.Metro.MetroForm

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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        SuspendLayout()
        '
        'CrystalReportViewer1
        '
        CrystalReportViewer1.ActiveViewIndex = -1
        CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        CrystalReportViewer1.Name = "CrystalReportViewer1"
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.Size = New System.Drawing.Size(631, 445)
        CrystalReportViewer1.TabIndex = 0
        '
        'frmReporte
        '
        AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        ClientSize = New System.Drawing.Size(631, 445)
        Controls.Add(CrystalReportViewer1)
        Name = "frmReporte"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Text = "frmReporte"
        ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CrystalReportViewer1.Zoom(1)

    End Sub

    Private Sub frmReporte_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        CrystalReportViewer1.Dispose()
    End Sub
End Class
