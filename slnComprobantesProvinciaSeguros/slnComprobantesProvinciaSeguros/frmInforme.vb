Imports System.Data.SqlClient

Public Class frmInforme
    Public Shared table As New DataTable

    Private Sub frmInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        table = New DataTable
        conn = New SqlConnection(sCnn)
        Dim cmd As New SqlCommand("dbo.SP_FIND_COMPROBANTES_INFORMADOS", conn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Adpt As New SqlDataAdapter(cmd)
        conn.Open()
        Try
            Adpt.Fill(table)
        Catch ex As Exception
            Dim sr As String
            sr = ex.Message
        End Try

        dgvReimpresion.DataSource = table
        If (table.Rows.Count = 0) Then
            lblSinRegistros.Show()
            btnInformar.Hide()
        End If
    End Sub

    Private Sub btnInformar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformar.Click
        ComprobantesDA.ActualizarToPagoFinalizado()
        MsgBox("El pago realizado a Provincia Seguros fue informado correctamente", MsgBoxStyle.Information, "OK")
        Me.frmInforme_Load(sender, e)
    End Sub
End Class