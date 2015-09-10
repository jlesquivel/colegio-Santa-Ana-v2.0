
Public Class cWord

    Dim wdApp As Object
    Dim wdDoc As Object
    Dim wdArch As String = ""


    Sub New(pArch As String)
        wdArch = pArch
        wdApp = CreateObject("Word.Application")
        wdDoc = wdApp.Documents.Open(FileName:=wdArch)
        wdApp.visible = True
    End Sub

    Sub SustituyeValores(wdPara As ArrayList)
        If wdPara.Count > 0 Then
            For Each wdValor As Object In wdPara
                With wdDoc.Bookmarks
                    If .Exists(wdValor(0)) Then
                        .Item(wdValor(0)).Range.Text = wdValor(1)
                    End If
                End With
            Next
        End If
    End Sub


    Sub llenaTabla(pTabla As ArrayList)
        'FALTA:  llenar tabla Arraylist con las nota del estudiante para el reporte de certificado notas
        Dim x, y As Integer

        For Each materia As Object In pTabla
            x = pTabla.IndexOf(materia) + 2
            y = 1
            For Each valor As Object In materia
                With wdDoc.Tables.Item(1)
                    .Cell(x, y).Range.Text = valor
                End With
                y = y + 1
            Next
        Next

    End Sub


    Sub guarda(ByVal arch As String)
        Dim escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        Dim fileName As String = String.Format("{0:yyyyMMdd_HHmm}", DateTime.Now) & " = " & arch
        Dim nombreArch As String = fileName & ".docx"
        Dim documentFile As String = String.Format("{0}\{1}", escritorio, nombreArch)
        wdDoc.SaveAs(documentFile)
    End Sub

#Region " IDisposable Support "
    
    Protected Overrides Sub Finalize()

        wdDoc = Nothing
        wdApp = Nothing
        MyBase.Finalize()
    End Sub
#End Region

End Class
