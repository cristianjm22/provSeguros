Imports System.Data.SqlClient

Public Class frmChange

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If (txtUser.Text <> "" Or txtOldPass.Text <> "" Or txtNewPass.Text <> "") Then
            Dim Usuario As String = txtUser.Text
            Dim ClaveUsuario = UsuarioDA.getPassword(Usuario).ToString.Trim
            If (ClaveUsuario <> "") Then
                If (ClaveUsuario = txtOldPass.Text) Then
                    conn = New SqlConnection(sCnn)
                    cmd = conn.CreateCommand()
                    cmd.CommandText = "UPDATE USUARIOS SET PASSWORD='" & txtNewPass.Text & "',FECHA_ACT_LOGIN=GETDATE(), FECHA_ULT_LOGIN=GETDATE()"
                    cmd.CommandText = cmd.CommandText & "WHERE USUARIO='" & Usuario & "'"
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Clave cambiada exitosamente", MsgBoxStyle.Information, "Success")
                    Me.Close()
                Else
                    MsgBox("La clave proporcionada no corresponde al usuario", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("El Usuario ingresado no existe", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("Todos los datos son requeridos", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class