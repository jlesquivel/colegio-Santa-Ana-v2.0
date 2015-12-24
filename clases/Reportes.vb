Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System
Imports System.Drawing.Printing

Public Class Reportes

    Dim conn As New conexionSQL
    Public Sub inserta_parametro(ByRef reporte As Object, ByVal param As String, ByVal valor As String)
        Try
            Dim pvCollection As New CrystalDecisions.Shared.ParameterValues
            Dim pdvCustomerName As New CrystalDecisions.Shared.ParameterDiscreteValue

            ' Set the discreet value to the customers name.
            pdvCustomerName.Value = valor
            ' Add it to the parameter collection.
            pvCollection.Add(pdvCustomerName)

            ' Apply the current parameter values.
            reporte.DataDefinition.ParameterFields(param).ApplyCurrentValues(pvCollection)

        Catch Exp As LoadSaveReportException
            MsgBox("Incorrect path for loading report.", _
                    MsgBoxStyle.Critical, "Load Report Error")

        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "Error General")

        End Try
    End Sub


    Public Sub imprimir(ByVal oreporte As Object, ByVal impresora As Boolean, ByRef padre As frmPrincipal2)
        Try
            Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
            Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo

            For Each tbCurrent In oreporte.Database.Tables
                tliCurrent = tbCurrent.LogOnInfo
                With tliCurrent.ConnectionInfo
                    .ServerName = conn.servidor
                    .UserID = conn.vusuario
                    .Password = conn.vpassword
                    '.DatabaseName = conn.bd
                    If conn.vusuario <> "" Then
                        .IntegratedSecurity = False
                    End If

                End With
                tbCurrent.ApplyLogOnInfo(tliCurrent)
            Next tbCurrent

            oreporte.SummaryInfo.ReportTitle = padre.organizacion
            oreporte.PrintOptions.PrinterName = padre.impresora.PrinterName

            If impresora Then
                oreporte.PrintToPrinter(1, False, 0, 0)
            Else  ' pantalla

                Dim miForma As New frmReporte
                miForma.CrystalReportViewer1.ReportSource = oreporte
                miForma.MdiParent = padre
                miForma.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub imprimir(ByVal oreporte As Object, ByVal impresora As String)
        Try
            Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
            Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo

            For Each tbCurrent In oreporte.Database.Tables
                tliCurrent = tbCurrent.LogOnInfo
                With tliCurrent.ConnectionInfo
                    .ServerName = conn.servidor
                    .UserID = conn.vusuario
                    .Password = conn.vpassword
                    .DatabaseName = conn.bd
                    If conn.vusuario <> "" Then
                        .IntegratedSecurity = False
                    End If

                End With
                tbCurrent.ApplyLogOnInfo(tliCurrent)
            Next tbCurrent


            oreporte.PrintOptions.PrinterName = impresora

            If impresora <> "" Then
                oreporte.PrintToPrinter(1, False, 0, 0)
            Else  ' pantalla

                Dim miForma As New frmReporte
                miForma.CrystalReportViewer1.ReportSource = oreporte
                miForma.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Imprimir",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function BuscarImpresora(ByVal buscar As String) As String
        Dim Impresoras As String
        For Each Impresoras In PrinterSettings.InstalledPrinters
            If Impresoras.Contains(buscar) Then
                Return Impresoras.ToString
            End If
        Next
        Return ""
    End Function


End Class
