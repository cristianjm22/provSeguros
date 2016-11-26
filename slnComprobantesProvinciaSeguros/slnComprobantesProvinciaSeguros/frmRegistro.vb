Public Class frmRegistro

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If ((txtUser.Text <> "") And (txtClave.Text <> "")) Then
            Dim Usuario As String = txtUser.Text
            Dim UsuarioFounded = UsuarioDA.getUsuario(Usuario)
            If (UsuarioFounded = "") Then
                UsuarioDA.insertarUsuario(txtUser.Text, txtClave.Text)
                MsgBox("Usuario creado correctamente", MsgBoxStyle.Information, "Success")
                Me.Close()
            Else
                MsgBox("El nombre de usuario ya existe", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("Todos los datos son requeridos", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class