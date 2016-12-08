Public Class frmAltaModPermisos

    Private Sub frmAltaModPermisos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Cargarusuario()

        If Not modificarPermisos Then
            limpiarControles()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
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
    End Sub


    Private Sub Cargarusuario()

        Dim Query As String
        Dim Resultado As String

        Resultado = String.Empty

        Dim dt As DataTable

        Query = "SELECT  [USUARIO] FROM [dbPoyCPS].[dbo].[USUARIOS]"

        dt = ComprobantesDA.EjecutaQuery(Query)

        cboUsuario.DataSource = dt

        cboUsuario.DisplayMember = "USUARIO"
        cboUsuario.ValueMember = "USUARIO"

    End Sub

    Private Sub limpiarControles()
        txtMenu.Text = ""
        txtMenuDesc.Text = ""

    End Sub

    Private Function validarControles()

        If txtMenu.Text = Nothing Then
            MsgBox("Debe ingresar un nombre de un menu", MsgBoxStyle.Exclamation, "Aviso")
            Return False

        End If

        Return True

    End Function

End Class