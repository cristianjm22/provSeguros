
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmControl

    Private Sub txtEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntrada.TextChanged
        If txtEntrada.Text = String.Empty Then
            MsgBox("Ingrese el codigo", MsgBoxStyle.Exclamation, "Aviso")
        ElseIf (txtEntrada.Text.Length = 38) Then
            DesgloseCodigoComprobante(txtEntrada.Text)
        Else
            MsgBox("El codigo ingresado no es correcto", MsgBoxStyle.Exclamation, "Aviso")
        End If

    End Sub

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

        If (ComprontesDA.verificaPagoAnticipado(txtEndoso.Text) > 0) Then

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

        txtMoneda.Text = entrada.Substring(3, 1)

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

    End Sub

    Private Sub frmControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ComprobantesAct.AccesoMenu(Usuario, "frmPermisos") Then

            btnPermisos.Show()
            btnModificarPagos.Show()
        Else
            btnPermisos.Hide()
            btnModificarPagos.Hide()
        End If
    End Sub

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click
        frmReporte.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtEntrada.Text = String.Empty Then
            MsgBox("Ingrese el codigo", MsgBoxStyle.Exclamation, "Aviso")
        Else
            ComprontesDA.InsertarDetalleComprobante(txtEntrada.Text, txtRM.Text, txtPoliza.Text, txtEndoso.Text, txtNroCuota.Text, dtpFechaVencimiento.Text, txtMoneda.Text, Convert.ToDecimal(txtImporte.Text), txtObservaciones.Text, "Pepito")
            'ComprobantesAct.PrintTicket(txtPoliza.Text, txtNroCuota.Text, txtMoneda.Text, txtImporte.Text, "12313123132")
        End If

        txtEntrada.Focus()
    End Sub
End Class
