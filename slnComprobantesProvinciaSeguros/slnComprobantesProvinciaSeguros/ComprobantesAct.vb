Imports System.Drawing.Printing

Public Class ComprobantesAct

    Public Shared printFont As Font
    Public Shared printFontBold As Font
    Public Shared poliza As String
    Public Shared nroCuota As String
    Public Shared moneda As String
    Public Shared importe As String

    Public Shared Sub printTicket(
           ByVal poliza As String,
           ByVal nroCuota As String,
           ByVal moneda As Decimal,
           ByVal importe As String)
        Try
            Try
                buildTicket(poliza, nroCuota, moneda, importe)
                printFont = New Font("Arial", 9)
                printFontBold = New Font("Arial", 8, FontStyle.Bold)
                Dim printDoc As New PrintDocument()
                AddHandler printDoc.PrintPage, AddressOf print
                printDoc.Print()
            Finally
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Shared Sub buildTicket(ByVal pPoliza As String,
           ByVal pCuota As String,
           ByVal pMoneda As Decimal,
           ByVal pImportePagado As String)
        Dim fecha As New Date
        fecha = Date.Now
        Dim id As Long
        id = 1023424342333242423

        If (pMoneda = 1) Then
            moneda = "$"
        Else
            moneda = "US$"
        End If

        importe = moneda + pImportePagado
        poliza = pPoliza
        nroCuota = pCuota

    End Sub

    Private Shared Sub print(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim fecha As New Date
        fecha = Date.Now
        Dim id As Long
        id = 1023424342333242423
        ' Create image.
        Dim newImage As Image = Image.FromFile("C:/imagenn.png")

        ' Create rectangle for displaying image.
        Dim destRect As New Rectangle(15, 0, 250, 100)

        ' Draw image to screen.
        e.Graphics.DrawImage(newImage, destRect)

        e.Graphics.DrawString("FECHA: " + fecha.ToString("dd/MM/yyyy"), printFont, Brushes.Black, 15, 120, New StringFormat())
        e.Graphics.DrawString("HORA: " + fecha.ToString("HH:mm:ss"), printFont, Brushes.Black, 160, 120, New StringFormat())
        e.Graphics.DrawString("IDENTIFICACION: " + id.ToString, printFont, Brushes.Black, 15, 140, New StringFormat())
        e.Graphics.DrawString("CUOTA: " + nroCuota.ToString, printFont, Brushes.Black, 15, 160, New StringFormat())
        e.Graphics.DrawString("IMPORTE PAGADO: " + importe, printFont, Brushes.Black, 15, 180, New StringFormat())
        e.Graphics.DrawString("POLIZA: " + poliza, printFont, Brushes.Black, 15, 200, New StringFormat())
        e.Graphics.DrawString("VALIDO COMO COMPROBANTE DE PAGO", printFontBold, Brushes.Black, 15, 230, New StringFormat())
        e.Graphics.DrawString("---------------------------------------------------------------", printFontBold, Brushes.Black, 15, 250, New StringFormat())

        e.HasMorePages = False
    End Sub

End Class
