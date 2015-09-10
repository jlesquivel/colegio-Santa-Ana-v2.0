
Imports camera_net
Imports DirectShowLib

Public Class frmWebCam2

    Dim control As System.Windows.Forms.PictureBox
    Dim Fnuevo As Boolean

    Public Sub New(ByRef Pcontrol As Object, ByRef pFnuevo As Boolean)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        control = Pcontrol
        Fnuevo = pFnuevo
    End Sub

    Private Sub frmWebCam2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim camara As CameraChoice = New CameraChoice
        camara.UpdateDeviceList()

        If (camara.Devices.Count > 0) Then
            Dim camara_seleccionada = camara.Devices(0).Mon
            CameraControl1.SetCamera(camara_seleccionada, Nothing)
        End If
    End Sub

    Private Sub frmWebCam2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CameraControl1.CloseCamera()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        If (Not CameraControl1.CameraCreated) Then
            Return
        End If

        Dim bitmas As Bitmap = CameraControl1.SnapshotOutputImage()

        If (bitmas Is Nothing) Then
            Return
        End If

        control.Image = bitmas
        Fnuevo = True
        Close()
    End Sub


End Class