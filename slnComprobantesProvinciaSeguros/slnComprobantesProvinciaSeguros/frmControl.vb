
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frmControl

    Dim errores As New Dictionary(Of String, String)

    ''' <summary>
    ''' Autor: Morales Cristian
    ''' Desgloso el codigo obtenido del lector, para obtener todos los demas datos
    ''' </summary>
    ''' <param name="entrada"></param>
    ''' <remarks></remarks>
    Private Sub DesgloseCodigoComprobante(ByVal entrada As String)
        Dim importe As Decimal
        Dim rm, cuota, endoso As Integer

        txtRM.Text = entrada.Substring(4, 2)
        rm = Convert.ToInt16(txtRM.Text)

        rm = rm * 1

        txtRM.Text = rm.ToString()

        txtPoliza.Text = entrada.Substring(6, 7)

        txtEndoso.Text = entrada.Substring(13, 7)

        endoso = Convert.ToInt16(txtEndoso.Text)

        endoso = endoso * 1

        txtEndoso.Text = endoso.ToString()

        If (ComprobantesDA.verificaPagoAnticipado(txtEndoso.Text) > 0) Then

            habilitarControles(True)

        End If

        txtNroCuota.Text = entrada.Substring(20, 2)
        cuota = Convert.ToInt16(txtNroCuota.Text)

        cuota = cuota * 1

        txtNroCuota.Text = rm.ToString()
        Dim provider As CultureInfo = CultureInfo.InvariantCulture
        Dim fechaVtoString As String = entrada.Substring(31, 6)
        If (fechaVtoString = "000000") Then
            dtpFechaVencimiento.Value = DateTime.Now
        Else
            dtpFechaVencimiento.Text = Date.ParseExact(fechaVtoString, "ddMMyy", CultureInfo.InvariantCulture)
        End If

        txtMoneda.Text = ComprobantesAct.getMonedaById(entrada.Substring(3, 1))

        txtImporte.Text = entrada.Substring(22, 9)

        importe = Convert.ToDecimal(txtImporte.Text)
        importe = importe / 100

        txtImporte.Text = importe.ToString()
    End Sub

    ''' <summary>
    ''' Autor: Cristian Morales
    ''' Habilita o deshabilita los controles
    ''' </summary>
    ''' <param name="estado"></param>
    ''' <remarks></remarks>
    Private Sub habilitarControles(ByVal estado As String)

        dtpFechaVencimiento.Enabled = estado

        txtImporte.Enabled = estado

        txtNroCuota.Enabled = estado

        txtRM.Enabled = estado

    End Sub

    Public Sub VerificarPermisos()
        If ComprobantesAct.AccesoMenu(Usuario, "PERMISOS") Then
            btnPermisos.Show()
        Else
            btnPermisos.Hide()
        End If

        If ComprobantesAct.AccesoMenu(Usuario, "MODIFICACION") Then
            btnModificarPagos.Show()
        Else
            btnModificarPagos.Hide()
        End If
    End Sub

    Private Sub frmControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComprobantesDA.ActualizarEstadoPagoFuturo()
        VerificarPermisos()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim tipomoneda As String
        Dim idComprobante As Integer
        Dim repeticion As String = ""
        If errores.Count = 0 Then

            If txtEntrada.Text = String.Empty Then
                MsgBox("Ingrese el codigo de barras", MsgBoxStyle.Exclamation, "Aviso")
            ElseIf (txtEntrada.Text.Length = 38) Then
                Dim cantPagos = ComprobantesDA.verificarExistenciaPago(txtEntrada.Text)
                If (cantPagos <> 0) Then
                    repeticion = ComprobantesAct.getDetalleRepeticion(cantPagos)
                    MsgBox("Este pago ya ha sido realizado " + cantPagos.ToString + " vez/veces." + vbCrLf + "El mismo será marcado como " + repeticion, MsgBoxStyle.Information, "Informacion")
                End If

                tipomoneda = ComprobantesAct.getIdMonedaByDescription(txtMoneda.Text)

                Dim codigoMoneda = ComprobantesAct.getCodMonedaByDescription(txtMoneda.Text)
                idComprobante = ComprobantesDA.InsertarDetalleComprobante(txtEntrada.Text, txtRM.Text, txtPoliza.Text, txtEndoso.Text, txtNroCuota.Text, dtpFechaVencimiento.Text, tipomoneda, Convert.ToDecimal(txtImporte.Text), txtObservaciones.Text, Usuario, repeticion)

                If txtDeuda.Text <> String.Empty Then
                    ComprobantesDA.InsertDeuda(idComprobante, txtPoliza.Text, txtNroCuota.Text, txtDeuda.Text)
                End If
                If MsgBox("El pago ha sido registrado correctamente." + vbCrLf + "¿Desea imprimir el comprobante?", MsgBoxStyle.YesNo, "Pago Registrado") = MsgBoxResult.Yes Then
                    ComprobantesAct.PrintTicket(txtPoliza.Text, txtNroCuota.Text, codigoMoneda, txtImporte.Text, idComprobante, txtRM.Text)
                End If
                Me.btnLimpiar_Click(sender, e)
            Else
                MsgBox("El codigo de barra ingresado es invalido", MsgBoxStyle.Exclamation, "Aviso")
            End If

            txtEntrada.Focus()
        Else
            MsgBox("No es posible registrar el pago." + vbCrLf + "Por favor verifique los datos ingresados", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub BtnReimpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReimpresion.Click
        frmReimpresion.Show()
    End Sub

    Private Sub btnPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermisos.Click
        frmPermisos.Show()
    End Sub

    Private Sub txtEntrada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrada.KeyPress

        If (e.KeyChar = ChrW(13)) Then
            If txtEntrada.Text = String.Empty Then
                MsgBox("Ingrese el codigo", MsgBoxStyle.Exclamation, "Aviso")
            ElseIf (txtEntrada.Text.Length = 38) Then
                DesgloseCodigoComprobante(txtEntrada.Text)
                txtObservaciones.Enabled = True
                txtDeuda.Enabled = True
                Dim dt As DataTable = DeudasDA.obtenerDeudas(txtPoliza.Text.ToString)
                If dt.Rows.Count > 0 Then
                    MsgBox("Tenga en cuenta que esta poliza posee deudas. (ver menu Deudas)", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("El codigo ingresado no es correcto", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        frmReporte.Show()
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        clean()
        txtEntrada.Text = ""
        txtEntrada.Focus()
    End Sub

    Private Sub clean()
        txtEndoso.Text = ""
        txtImporte.Text = ""
        txtMoneda.Text = ""
        txtNroCuota.Text = ""
        txtObservaciones.Text = ""
        txtDeuda.Text = ""
        txtObservaciones.Enabled = False
        txtDeuda.Enabled = False
        txtPoliza.Text = ""
        txtRM.Text = ""
        dtpFechaVencimiento.ResetText()
        dtpFechaVencimiento.Enabled = False
        txtImporte.Enabled = False
        txtNroCuota.Enabled = False
        txtRM.Enabled = False
    End Sub

    Private Sub txtEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntrada.TextChanged
        clean()
        If Not Regex.Match(txtEntrada.Text, "^\d+$", RegexOptions.IgnoreCase).Success Then
            txtEntrada.ForeColor = Color.Red

        Else
            txtEntrada.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnDeudas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeudas.Click
        frmDeudas.Show()
    End Sub

    Private Sub btnInformarPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformarPagos.Click
        frmInforme.Show()
    End Sub

    Private Sub btnModificarPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPagos.Click
        frmEliminarModPagos.Show()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub txtDeuda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeuda.TextChanged
        If Not Regex.Match(txtDeuda.Text, "^\d+(\,\d{1,2})?$", RegexOptions.IgnoreCase).Success Then
            txtDeuda.ForeColor = Color.Red
            If Not errores.ContainsKey("txtDeuda") Then
                errores.Add("txtDeuda", "error")
            End If
        Else
            txtDeuda.ForeColor = Color.Black
            If errores.ContainsKey("txtDeuda") Then
                errores.Remove("txtDeuda")
            End If

        End If
    End Sub

    Private Sub txtRM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRM.TextChanged
        If Not Regex.Match(txtRM.Text, "^([0-9][0-9]+|[1-9])$", RegexOptions.IgnoreCase).Success Then
            txtRM.ForeColor = Color.Red
            If Not errores.ContainsKey("txtRM") Then
                errores.Add("txtRM", "error")
            End If
        Else
            txtRM.ForeColor = Color.Black
            If errores.ContainsKey("txtRM") Then
                errores.Remove("txtRM")
            End If
        End If
    End Sub

    Private Sub txtNroCuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroCuota.TextChanged
        If Not Regex.Match(txtNroCuota.Text, "^([0-9][0-9]+|[1-9])$", RegexOptions.IgnoreCase).Success Then
            txtNroCuota.ForeColor = Color.Red
            If Not errores.ContainsKey("txtNroCuota") Then
                errores.Add("txtNroCuota", "error")
            End If
        Else
            txtNroCuota.ForeColor = Color.Black
            If errores.ContainsKey("txtNroCuota") Then
                errores.Remove("txtNroCuota")
            End If
        End If
    End Sub

    Private Sub txtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged
        If Not Regex.Match(txtImporte.Text, "^\d+(\,\d{1,2})?$", RegexOptions.IgnoreCase).Success Then
            txtImporte.ForeColor = Color.Red
            If Not errores.ContainsKey("txtImporte") Then
                errores.Add("txtImporte", "error")
            End If
        Else
            txtImporte.ForeColor = Color.Black
            If errores.ContainsKey("txtImporte") Then
                errores.Remove("txtImporte")
            End If
        End If
    End Sub
End Class
