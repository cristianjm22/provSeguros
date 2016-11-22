Public Class frmAccesoMenu

    Private Sub btnPagos_Click(sender As System.Object, e As System.EventArgs) Handles btnPagos.Click


        If ComprobantesAct.AccesoMenu(Usuario, "frmControl") Then

            frmControl.Show()
        Else
            MsgBox("No tiene permisos para realizar esta accion", MsgBoxStyle.Exclamation, "Aviso")

        End If


    End Sub

    Private Sub Permisos_Click(sender As System.Object, e As System.EventArgs) Handles Permisos.Click


        If ComprobantesAct.AccesoMenu(Usuario, "frmPermisos") Then

            frmPermisos.Show()
        Else
            MsgBox("No tiene permisos para realizar esta accion", MsgBoxStyle.Exclamation, "Aviso")

        End If

    End Sub

    Private Sub btnDetalleComprobantes_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalleComprobantes.Click
        Dim form As New frmReporte
        form.Show()
    End Sub

    Private Sub frmAccesoMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Logueo.Close()
    End Sub
End Class