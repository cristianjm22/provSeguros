Imports System.Data.SqlClient

Public Class frmDeudas
    Public Shared table

    Private Sub frmDeudas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        table = New DataTable
        conn = New SqlConnection(sCnn)
        Dim cmd As New SqlCommand("dbo.SP_FIND_DEUDAS", conn)
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
        Else
            lblSinRegistros.Hide()
        End If
    End Sub

    Private Sub txtPoliza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoliza.TextChanged
        Dim dv As DataView
        dv = New DataView(table, "POLIZA like '%" + txtPoliza.Text + "%'", "POLIZA Desc", DataViewRowState.CurrentRows)
        dgvReimpresion.DataSource = dv
        If (dv.Count = 0) Then
            lblSinRegistros.Show()
        Else
            lblSinRegistros.Hide()
        End If
    End Sub
End Class