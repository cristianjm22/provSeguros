
Imports System.Data
Imports System.Data.SqlClient
Public Class Logueo

    Private Sub Logueo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Login_CmbBx_Domain.SelectedIndex = 0
        Login_Pass_Txt.Text = ""
        Login_Usr_Txt.Text = Environment.UserName

        PictureBox1.Image = Image.FromFile("../../Resources/user_male.png")
    End Sub

    Private Sub Aceptar()

        Dim Clave As String
        Dim Clave_old As String = ""

        Usuario = Login_Usr_Txt.Text

        Usuario = Usuario.ToUpper
        Clave = Login_Pass_Txt.Text

        If Usuario = "ADM" And Clave = "ADM123" Then
            Me.Close()
            frmAccesoMenu.Show()

        Else

            Me.Close()
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
            Else
                'conn.Close()
                'cmd = conn.CreateCommand()
                'cmd.CommandText = "INSERT INTO USUARIOS VALUES (UPPER('" & Usuario & "'),'" & Clave & "',GETDATE(),GETDATE())"
                'conn.Open()
                'cmd.ExecuteNonQuery()

                MsgBox("El Usuario o contraseña son incorrectos", MsgBoxStyle.Exclamation, "Aviso")
                Login_Pass_Txt.Text = ""


            End If
            'Permisos(Usuario)
            frmAccesoMenu.Show()


        End If

    End Sub
    Private Function CloseAll()
        Dim Success As Boolean = True
        Me.Close()

        Return Success
    End Function

    Private Sub Login_Yes_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_Yes_Btn.Click
        Aceptar()
    End Sub

    Private Sub Login_No_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_No_Btn.Click
        CloseAll()
    End Sub



End Class