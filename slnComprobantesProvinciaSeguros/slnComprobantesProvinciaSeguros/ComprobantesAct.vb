Imports System.Drawing.Printing

Public Class ComprobantesAct

    Public Shared PrintFont As Font = New Font("Arial", 9)
    Public Shared PrintFontBold As Font = New Font("Arial", 8, FontStyle.Bold)
    Public Shared Poliza As String
    Public Shared Cuota As String
    Public Shared Moneda As String
    Public Shared Importe As String
    Public Shared FechaPago As Date
    Public Shared NroComprobante As Integer
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
           ByVal pNroComprobante As Integer,
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
           ByVal pNroComprobante As Integer,
           ByVal pRamo As String)

        FechaPago = Date.Now
        NroComprobante = pNroComprobante

        Importe = pMoneda + pImporte
        Poliza = pPoliza
        Cuota = pCuota
        Ramo = pRamo

    End Sub

    ''' <summary>
    ''' Autor:Walter Morales
    ''' Devuelve el valor de la moneda
    ''' </summary>
    ''' <param name="idMoneda"></param>
    ''' <remarks></remarks>
    Public Shared Function getMonedaById(ByVal idMoneda As String)
        Dim moneda As String
        If (idMoneda = "1") Then
            moneda = "PESOS"
        Else
            moneda = "DOLAR"
        End If
        Return moneda
    End Function

    ''' <summary>
    ''' Autor:Walter Morales
    ''' Devuelve el id de la moneda
    ''' </summary>
    ''' <param name="moneda"></param>
    ''' <remarks></remarks>
    Public Shared Function getIdMonedaByDescription(ByVal moneda As String)
        Dim codMoneda As String
        If (moneda = "PESOS") Then
            codMoneda = "1"
        Else
            codMoneda = "2"
        End If
        Return codMoneda
    End Function

    ''' <summary>
    ''' Autor:Walter Morales
    ''' Devuelve el codigo de la moneda
    ''' </summary>
    ''' <param name="moneda"></param>
    ''' <remarks></remarks>
    Public Shared Function getCodMonedaByDescription(ByVal moneda As String)
        Dim codMoneda As String
        If (moneda = "PESOS") Then
            codMoneda = "$"
        Else
            codMoneda = "US$"
        End If
        Return codMoneda
    End Function


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
        e.Graphics.DrawString("NRO COMPROBANTE: " + NroComprobante.ToString, PrintFont, Brushes.Black, 15, 140, New StringFormat())
        e.Graphics.DrawString("CUOTA: " + Cuota, PrintFont, Brushes.Black, 15, 160, New StringFormat())
        e.Graphics.DrawString("IMPORTE PAGADO: " + Importe, PrintFont, Brushes.Black, 15, 180, New StringFormat())
        e.Graphics.DrawString("POLIZA: " + Poliza, PrintFont, Brushes.Black, 15, 200, New StringFormat())
        e.Graphics.DrawString("RAMO: " + Ramo, PrintFont, Brushes.Black, 15, 220, New StringFormat())
        e.Graphics.DrawString("---------------------------------------------------------------", PrintFontBold, Brushes.Black, 15, 250, New StringFormat())

        e.HasMorePages = False
    End Sub

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


    Public Shared Function obtenerTotalPagosFuturos() As String
        Try
            Dim dt As DataTable
            dt = ComprobantesDA.obtenerTotalPagosFuturos()
            If dt.Rows.Count > 0 Then

                Return dt.Rows(0)(0).ToString

            End If

            Return "0"


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Shared Function obtenerTotalPagosInformados() As String
        Try
            Dim dt As DataTable
            dt = ComprobantesDA.obtenerTotalPagosInformados()
            If dt.Rows.Count > 0 Then

                Return dt.Rows(0)(0).ToString

            End If

            Return "0"


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function


    Public Shared Function obtenerTotalPagosAnticipados() As String
        Try
            Dim dt As DataTable
            dt = ComprobantesDA.obtenerTotalPagosAnticipados()
            If dt.Rows.Count > 0 Then

                Return dt.Rows(0)(0).ToString

            End If

            Return "0"


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function








    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="DGV"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GridAExcel555(ByVal DGV As DataGridView, ByVal importeDia As String, ByVal importeQuincena As String, ByVal importePagosFuturo As String) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets(1)
            Dim Fila As Integer
            Dim Col As Integer
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DGV.ColumnCount
            Dim NRow As Integer = DGV.RowCount
            Dim styleHeader As Microsoft.Office.Interop.Excel.Style

            styleHeader = exLibro.Styles.Add("StyleHeader")
            styleHeader.Interior.Color = Color.FromArgb(1, 56, 131)
            styleHeader.Font.Color = Color.White

            Dim styleTotal As Microsoft.Office.Interop.Excel.Style

            styleTotal = exLibro.Styles.Add("StyleTotal")
            styleTotal.Interior.Color = Color.FromArgb(191, 191, 191)
            styleTotal.Font.Color = Color.Red
            styleTotal.Font.Bold = True



            Dim stylePagoInformado As Microsoft.Office.Interop.Excel.Style

            stylePagoInformado = exLibro.Styles.Add("stylePagoInformado")
            stylePagoInformado.Interior.Color = Color.FromArgb(192, 255, 192)


            Dim stylePagoFuturo As Microsoft.Office.Interop.Excel.Style

            stylePagoFuturo = exLibro.Styles.Add("stylePagoFuturo")
            stylePagoFuturo.Interior.Color = Color.FromArgb(128, 128, 255)


            Dim stylePagoPendiente As Microsoft.Office.Interop.Excel.Style

            stylePagoPendiente = exLibro.Styles.Add("stylePagoPendiente")
            stylePagoPendiente.Interior.Color = Color.FromArgb(255, 255, 128)




            'recorremos todas las filas, y por cada fila todas las columnas
            'y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DGV.Columns(i - 1).Name.ToString
                exHoja.Cells.Item(1, i).Style = "StyleHeader"
            Next

            For Fila = 0 To NRow - 1
                For Col = 0 To NCol - 1
                    Dim value As String

                    'Problema con formato entrada (lapiz optico)
                    If Col = 1 Then

                        value = "'" + DGV.Rows(Fila).Cells(Col).Value().ToString.Trim + "'"
                    Else
                        value = DGV.Rows(Fila).Cells(Col).Value()
                    End If


                    If (DGV.Rows(Fila).Cells(10).Value().ToString() = "PAGO INFORMADO") Then
                        exHoja.Cells.Item(Fila + 2, Col + 1) = value
                        exHoja.Cells.Item(Fila + 2, Col + 1).Style = "stylePagoInformado"

                    ElseIf (DGV.Rows(Fila).Cells(10).Value().ToString() = "PAGO FUTURO") Then
                        exHoja.Cells.Item(Fila + 2, Col + 1) = value
                        exHoja.Cells.Item(Fila + 2, Col + 1).Style = "stylePagoFuturo"

                    Else
                        exHoja.Cells.Item(Fila + 2, Col + 1) = value
                    End If


                    'exHoja.Cells.Item(Fila + 2, Col + 1).Style = "Text"
                Next

            Next

            exHoja.Cells.Item(Fila + 3, Col - 2) = "TOTAL DEL DIA"
            exHoja.Cells.Item(Fila + 3, Col - 2).Style = "StyleTotal"

            exHoja.Cells.Item(Fila + 3, Col - 1).Style = "StyleTotal"

            exHoja.Cells.Item(Fila + 5, Col - 2) = "TOTAL DE QUINCENA"
            exHoja.Cells.Item(Fila + 5, Col - 2).Style = "StyleTotal"

            exHoja.Cells.Item(Fila + 5, Col - 1).Style = "StyleTotal"


            exHoja.Cells.Item(Fila + 7, Col - 2) = "TOTAL PROXIMA QUINCENA"
            exHoja.Cells.Item(Fila + 7, Col - 2).Style = "StyleTotal"

            exHoja.Cells.Item(Fila + 7, Col - 1).Style = "StyleTotal"



            exHoja.Cells.Item(Fila + 3, Col) = "$" + importeDia
            exHoja.Cells.Item(Fila + 3, Col).Style = "StyleTotal"

            exHoja.Cells.Item(Fila + 5, Col) = "$" + importeQuincena
            exHoja.Cells.Item(Fila + 5, Col).Style = "StyleTotal"


            exHoja.Cells.Item(Fila + 7, Col) = "$" + importePagosFuturo
            exHoja.Cells.Item(Fila + 7, Col).Style = "StyleTotal"


            'Titulo en negrita, Alineado
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'para visualizar el libro
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

    Shared Function getDetalleRepeticion(ByVal cantPagos As Integer) As String
        Dim result As String = ""
        Select Case (cantPagos)
            Case 1
                result = "duplicado"
            Case 2
                result = "triplicado"
            Case 3
                result = "cuadruplicado"
            Case 4
                result = "quintuplicado"
        End Select
        Return result
    End Function


    Public Shared Function NumeroDec(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal Text As TextBox) As Integer

        Dim dig As Integer = Len(Text.Text & e.KeyChar)
        Dim a, esDecimal, NumDecimales As Integer
        Dim esDec As Boolean
        ' se verifica si es un digito o un punto 
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "," Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return a
        Else
            e.Handled = True
        End If
        ' se verifica que el primer digito ingresado no sea un punto al seleccionar
        If Text.SelectedText <> "" Then
            If e.KeyChar = "," Then
                e.Handled = True
                Return a
            End If
        End If
        If dig = 1 And e.KeyChar = "," Then
            e.Handled = True
            Return a
        End If
        'aqui se hace la verificacion cuando es seleccionado el valor del texto
        'y no sea considerado como la adicion de un digito mas al valor ya contenido en el textbox
        If Text.SelectedText = "" Then
            ' aqui se hace el for para controlar que el numero sea de dos digitos - contadose a partir del punto decimal.
            For a = 0 To dig - 1
                Dim car As String = CStr(Text.Text & e.KeyChar)
                If car.Substring(a, 1) = "," Then
                    esDecimal = esDecimal + 1
                    esDec = True
                End If
                If esDec = True Then
                    NumDecimales = NumDecimales + 1
                End If
                ' aqui se controla los digitos a partir del punto numdecimales = 4 si es de dos decimales 
                If NumDecimales >= 4 Or esDecimal >= 2 Then
                    e.Handled = True
                End If
            Next
        End If
        Return 0
    End Function
End Class
