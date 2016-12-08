
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub Aceptar()

        Dim Clave As String
        Dim ClaveFounded As String = ""

        Clave = Login_Pass_Txt.Text
        Usuario = Login_Usr_Txt.Text
        ClaveFounded = UsuarioDA.getPassword(Usuario).ToString.Trim
        If (ClaveFounded <> "") Then
            If (ClaveFounded <> Clave) Then
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Exclamation, "Aviso")
                Login_Pass_Txt.Text = ""
            Else
                conn.Close()
                cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE USUARIOS SET FECHA_ULT_LOGIN=GETDATE()"
                cmd.CommandText = cmd.CommandText & "WHERE USUARIO='" & Usuario & "'"
                conn.Open()
                cmd.ExecuteNonQuery()
                frmControl.Show()
                Me.Close()
            End If
        Else
            MsgBox("Usuario inexistente", MsgBoxStyle.Exclamation, "Aviso")
            Login_Pass_Txt.Text = ""
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login_Pass_Txt.Text = ""
        Login_Usr_Txt.Text = Environment.UserName
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Aceptar()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub lnkChange_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkChange.LinkClicked
        frmChange.Show()
    End Sub

    Private Sub lnkRegistrar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRegistrar.LinkClicked
        frmRegistro.Show()
    End Sub
End Class