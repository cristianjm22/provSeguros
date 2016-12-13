Public Class frmModDeuda

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtImporte.Text <> Nothing Then
            DeudasDA.UpdateDeudas(idDeuda, txtImporte.Text)
            MsgBox("El importe de la deuda se actualizo con exito", MsgBoxStyle.Information, "Aviso")
            Me.Close()
        Else
            MsgBox("Debe ingresar un importe", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtImporte_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtImporte.TextChanged

    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        ComprobantesAct.NumeroDec(e, Me.txtImporte)
    End Sub

End Class