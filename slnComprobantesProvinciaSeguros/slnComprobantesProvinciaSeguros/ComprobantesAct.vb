Imports System.Drawing.Printing

Public Class ComprobantesAct

    Public Shared PrintFont As Font = New Font("Arial", 9)
    Public Shared PrintFontBold As Font = New Font("Arial", 8, FontStyle.Bold)
    Public Shared Poliza As String
    Public Shared Cuota As String
    Public Shared Moneda As String
    Public Shared Importe As String
    Public Shared FechaPago As Date
    Public Shared NroComprobante As String
    Public Shared Ramo As String

    ''' <summary>
    ''' Autor:Walter Morales
    ''' Imprime el ticket
    ''' </summary>
    ''' <param name="pPoliza"></param>
    ''' <param name="pCuota"></param>
    ''' <param name="pMoneda"></param>
    ''' <param name="pImporte"></param>
    ''' <param name="pNroComprobante"></param>
    ''' <remarks></remarks>
    Public Shared Sub PrintTicket(
           ByVal pPoliza As String,
           ByVal pCuota As String,
           ByVal pMoneda As String,
           ByVal pImporte As String,
           ByVal pNroComprobante As String,
           ByVal pRamo As String)

        Try
            Try
                SetData(pPoliza, pCuota, pMoneda, pImporte, pNroComprobante, pRamo)
                Dim PrintDoc As New PrintDocument()
                AddHandler PrintDoc.PrintPage, AddressOf BuildData
                PrintDoc.Print()
            Finally
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Autor:Walter Morales
    ''' Carga los datos a imprimir
    ''' </summary>
    ''' <param name="pPoliza"></param>
    ''' <param name="pCuota"></param>
    ''' <param name="pMoneda"></param>
    ''' <param name="pImporte"></param>
    ''' <param name="pNroComprobante"></param>
    ''' <remarks></remarks>
    Public Shared Sub SetData(
           ByVal pPoliza As String,
           ByVal pCuota As String,
           ByVal pMoneda As String,
           ByVal pImporte As String,
           ByVal pNroComprobante As String,
           ByVal pRamo As String)

        FechaPago = Date.Now
        NroComprobante = pNroComprobante

        If (pMoneda = "1") Then
            pMoneda = "$"
        Else
            pMoneda = "US$"
        End If

        Importe = pMoneda + pImporte
        Poliza = pPoliza
        Cuota = pCuota
        Ramo = pRamo

    End Sub

    ''' <summary>
    ''' Autor:Walter Morales
    ''' Construye los datos que seran impresos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Shared Sub BuildData(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim newImage = My.Resources.ResourceManager.GetObject("logo")
        Dim destRect As New Rectangle(15, 0, 250, 100)
        e.Graphics.DrawImage(newImage, destRect)
        e.Graphics.DrawString("FECHA: " + FechaPago.ToString("dd/MM/yyyy"), PrintFont, Brushes.Black, 15, 120, New StringFormat())
        e.Graphics.DrawString("HORA: " + FechaPago.ToString("HH:mm:ss"), PrintFont, Brushes.Black, 160, 120, New StringFormat())
        e.Graphics.DrawString("NRO COMPROBANTE: " + NroComprobante, PrintFont, Brushes.Black, 15, 140, New StringFormat())
        e.Graphics.DrawString("CUOTA: " + Cuota, PrintFont, Brushes.Black, 15, 160, New StringFormat())
        e.Graphics.DrawString("IMPORTE PAGADO: " + Importe, PrintFont, Brushes.Black, 15, 180, New StringFormat())
        e.Graphics.DrawString("POLIZA: " + Poliza, PrintFont, Brushes.Black, 15, 200, New StringFormat())
        e.Graphics.DrawString("RAMO: " + Poliza, PrintFont, Brushes.Black, 15, 220, New StringFormat())
        e.Graphics.DrawString("---------------------------------------------------------------", PrintFontBold, Brushes.Black, 15, 250, New StringFormat())

        e.HasMorePages = False
    End Sub


    ''' <summary>
    ''' Autor: Cristian Morales
    ''' Exporta un grid a un excel
    ''' </summary>
    ''' <param name="ConsultaDGW"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GridAExcel(ByVal ConsultaDGW As DataGridView) As Boolean


        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ConsultaDGW.ColumnCount
            Dim NRow As Integer = ConsultaDGW.RowCount
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim colu, row As Integer
            Dim rawData(ConsultaDGW.Rows.Count, ConsultaDGW.Columns.Count) As Object

            'Copy the column names to the first row of the object array
            For colu = 0 To ConsultaDGW.Columns.Count - 1
                rawData(0, colu) = ConsultaDGW.Columns(colu).HeaderText
            Next
            ' Inicio Barra de Progreso
            ProcBar.Visible = True
            ProcBar.Enabled = True
            ProcBar.Show()
            ProcBar.ProgressBar1.Maximum = NRow
            ProcBar.Update()

            For row = 0 To ConsultaDGW.Rows.Count - 1
                ProcBar.ProgressBar1.Value = row
                ProcBar.Top_Lbl.Text = "Total: " & row & "/" & NRow
                ProcBar.Update()
                For colu = 0 To ConsultaDGW.Columns.Count - 1
                    rawData(row + 1, colu) = System.Convert.ToString(ConsultaDGW.Rows(row).Cells(colu).Value)
                Next
            Next

            ProcBar.Visible = False

            ' Calculate the final column letter
            Dim finalColLetter As String = String.Empty
            Dim colCharset As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Dim colCharsetLen As Integer = colCharset.Length

            If ConsultaDGW.Columns.Count > colCharsetLen Then
                finalColLetter = colCharset.Substring( _
                 (ConsultaDGW.Columns.Count - 1) \ colCharsetLen - 1, 1)
            End If

            finalColLetter += colCharset.Substring( _
              (ConsultaDGW.Columns.Count - 1) Mod colCharsetLen, 1)

            ' Fast data export to Excel
            Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, ConsultaDGW.Rows.Count)
            exHoja.Range(excelRange, Type.Missing).Value2 = rawData
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()


            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True


    End Function


    ''' <summary>
    ''' Autor: Cristian Morales
    ''' Determina el permiso de acceso para el usuario logueado.
    ''' </summary>
    ''' <param name="UserName"></param>
    ''' <param name="MenuName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function AccesoMenu(ByVal UserName As String, ByVal MenuName As String) As Boolean
        Try
            Dim dtPermiso As DataTable = ComprobantesDA.verificaPermisos(UserName, MenuName)

            If dtPermiso.Rows.Count > 0 Then
                Return Convert.ToBoolean(dtPermiso.Rows.Item(0)(0))
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function


    Public Shared Function ObtenerTotaldeldia() As String
        Try
            Dim dt As DataTable
            dt = ComprobantesDA.obtenerTotalporDia()
            If dt.Rows.Count > 0 Then

                Return dt.Rows(0)(0).ToString

            End If

            Return "0"


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function


    Public Shared Function ObtenerTotalporQuincena() As String
        Try
            Dim dt As DataTable
            dt = ComprobantesDA.obtenerTotalporQuincena()
            If dt.Rows.Count > 0 Then

                Return dt.Rows(0)(0).ToString

            End If

            Return "0"


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function

End Class
