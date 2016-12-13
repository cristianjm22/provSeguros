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

    Private Sub txtMenu_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMenu.TextChanged

    End Sub

    Private Sub txtMenu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMenu.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If



        Me.txtMenu.Text = Trim(Replace(Me.txtMenu.Text, " ", ""))

        txtMenu.Select(txtMenu.Text.Length, 0)
    End Sub

  
    Private Sub txtMenuDesc_TextChanged(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtMenuDesc.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If



        Me.txtMenuDesc.Text = Trim(Replace(Me.txtMenuDesc.Text, " ", ""))

        txtMenuDesc.Select(txtMenuDesc.Text.Length, 0)
    End Sub
End Class