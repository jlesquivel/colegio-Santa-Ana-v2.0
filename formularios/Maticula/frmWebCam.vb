Public Class frmWebCam
    Dim control As System.Windows.Forms.PictureBox
    Dim Fnuevo As Boolean


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WebCam1.Start()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        control.Image = WebCam1.Imagen()
        Fnuevo = True
    End Sub

    Public Sub New(ByRef Pcontrol As Object, ByRef pFnuevo As Boolean)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        control = Pcontrol
        Fnuevo = pFnuevo
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


   
    Private Sub frmWebCam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        WebCam1.Stop()
    End Sub
End Class