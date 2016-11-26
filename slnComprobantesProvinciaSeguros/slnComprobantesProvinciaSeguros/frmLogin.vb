
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub Aceptar()

        Dim Clave As String
        Dim Clave_old As String = ""

        Usuario = Login_Usr_Txt.Text

        Usuario = Usuario.ToUpper
        Clave = Login_Pass_Txt.Text

        'Ejecuto tareas con el usuario
        Dim sSel As String = "SELECT TOP 1 PASSWORD FROM USUARIOS WHERE  USUARIO='" & Usuario & "'"
        conn = New SqlConnection(sCnn)
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandText = sSel
        cmd.ExecuteNonQuery()
        SQLread = cmd.ExecuteReader
        If SQLread.HasRows = True Then
            SQLread.Read()
            Clave_old = SQLread.GetString(0)
            Clave_old = Trim(Clave_old)
            If Clave_old <> Clave Then
                'Actualizo la clave en BD
                conn.Close()
                cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE USUARIOS SET PASSWORD='" & Clave & "',FECHA_ACT_LOGIN=GETDATE(), FECHA_ULT_LOGIN=GETDATE()"
                cmd.CommandText = cmd.CommandText & "WHERE USUARIO='" & Usuario & "'"
                conn.Open()
                cmd.ExecuteNonQuery()
            Else
                conn.Close()
                cmd = conn.CreateCommand()
                cmd.CommandText = "UPDATE USUARIOS SET FECHA_ULT_LOGIN=GETDATE()"
                cmd.CommandText = cmd.CommandText & "WHERE USUARIO='" & Usuario & "'"
                conn.Open()
                cmd.ExecuteNonQuery()
            End If
            'Permisos(Usuario)
            frmControl.Show()
            Me.Close()
        Else
            MsgBox("El Usuario o contraseña son incorrectos", MsgBoxStyle.Exclamation, "Aviso")
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub lnkChange_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkChange.LinkClicked
        frmChange.Show()
    End Sub
End Class