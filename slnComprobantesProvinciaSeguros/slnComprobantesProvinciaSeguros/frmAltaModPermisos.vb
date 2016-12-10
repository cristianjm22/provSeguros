Public Class frmAltaModPermisos

    Private Function validarControles()

        If txtMenu.Text.Trim = String.Empty Or txtMenuDesc.Text.Trim = String.Empty Then
            MsgBox("Los campos Menu y Descripcion son obligatorios", MsgBoxStyle.Exclamation, "Aviso")
            Return False

        End If

        Return True

    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If modificarPermisos Then
            If validarControles() Then
                ComprobantesDA.updatePermisos(iDPermiso, cboUsuario.SelectedValue, txtMenu.Text, txtMenuDesc.Text, chbHabilitado.Checked)
                MsgBox("Se guardaron los datos con exito.", MsgBoxStyle.Information, "Aviso")
            End If
        Else

            If validarControles() Then
                ComprobantesDA.InsertPermisos(cboUsuario.SelectedValue, txtMenu.Text, txtMenuDesc.Text, chbHabilitado.Checked)
                MsgBox("Se insertaron los datos con exito.", MsgBoxStyle.Information, "Aviso")
            End If

        End If
        frmPermisos.cargarGrilla()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class