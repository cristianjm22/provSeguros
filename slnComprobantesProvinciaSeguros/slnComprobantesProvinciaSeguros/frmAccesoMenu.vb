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

    Private Sub frmAccesoMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Logueo.ShowDialog()
        'Informacion()
    End Sub

    Private Sub btnDetalleComprobantes_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalleComprobantes.Click

    End Sub
End Class