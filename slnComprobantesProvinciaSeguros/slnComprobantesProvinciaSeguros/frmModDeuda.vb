Public Class frmModDeuda



    Private Sub frmModDeuda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If txtImporte.Text <> Nothing Then
            DeudasDA.UpdateDeudas(idDeuda, txtImporte.Text)
            MsgBox("El importe se actualizo con exito", MsgBoxStyle.Information, "Aviso")
        Else
            MsgBox("Debe ingresar un importe", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class