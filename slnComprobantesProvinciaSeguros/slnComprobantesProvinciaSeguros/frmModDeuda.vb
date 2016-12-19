Imports System.Text.RegularExpressions

Public Class frmModDeuda
    Dim errores As New Dictionary(Of String, String)
    Shared Pendiente As String

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If errores.Count = 0 Then
            If txtImporte.Text <> Nothing Then
                DeudasDA.UpdateDeudas(idDeuda, txtUltimoPago.Text, txtPendiente.Text)
                Dim print = False

                If MsgBox("El importe de la deuda se actualizo con exito." + vbCrLf + "¿Desea imprimir el comprobante?", MsgBoxStyle.YesNo, "Pago registrado") = MsgBoxResult.Yes Then
                    Dim ticketDeuda As TicketDeuda = DeudasDA.FindDeudaById(idDeuda)
                    ComprobantesAct.PrintTicket(ticketDeuda.getPoliza,
                                                ticketDeuda.getCuota,
                                                ComprobantesAct.getCodMonedaById(ticketDeuda.getMoneda),
                                                ticketDeuda.getUltimoPago,
                                                ticketDeuda.getComprobante,
                                                ticketDeuda.getRamo, "DEUDA",
                                                ticketDeuda.getDeudaInicial,
                                                ticketDeuda.getDeudaPendiente)
                End If
                If (Decimal.Parse(txtPendiente.Text) = 0) Then
                    DeudasDA.CancelarDeuda(idDeuda)
                End If
            Else
                MsgBox("Debe ingresar un importe", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("No es posible actualizar la deuda." + vbCrLf + "Por favor verifique los datos ingresados", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtUltimoPago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUltimoPago.TextChanged
        If Not Regex.Match(txtUltimoPago.Text, "^\d+(\,\d{1,2})?$", RegexOptions.IgnoreCase).Success Then
            txtUltimoPago.ForeColor = Color.Red
            If Not errores.ContainsKey("txtUltimoPago") Then
                errores.Add("txtUltimoPago", "error")
            End If
            txtPendiente.Text = Pendiente
        Else
            txtUltimoPago.ForeColor = Color.Black
            If errores.ContainsKey("txtUltimoPago") Then
                errores.Remove("txtUltimoPago")
            End If
            Dim totalPendiente = Decimal.Parse(Pendiente) - Decimal.Parse(txtUltimoPago.Text)
            If (totalPendiente < 0) Then
                totalPendiente = 0
            End If
            txtPendiente.Text = totalPendiente
        End If
    End Sub

    Private Sub frmModDeuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ni bien se carga el formulario guardo la deuda pendiente original en una variable para no perderla
        Pendiente = txtPendiente.Text
        txtUltimoPago.Text = ""
        txtUltimoPago.Focus()
    End Sub
End Class