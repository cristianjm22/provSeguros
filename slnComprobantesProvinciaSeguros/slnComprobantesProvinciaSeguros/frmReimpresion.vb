Imports System.Data.SqlClient

Public Class frmReimpresion
    Public Shared table As New DataTable

    Private Sub frmReimpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub txtPoliza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoliza.TextChanged
        Dim dv As DataView
        dv = New DataView(table, "POLIZA like '%" + txtPoliza.Text + "%'", "POLIZA Desc", DataViewRowState.CurrentRows)
        dgvReimpresion.DataSource = dv
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim listSelected = dgvReimpresion.SelectedRows
        If (listSelected.Count > 0) Then
            Dim row = listSelected(0).Cells()
            Dim comprobante = row.Item(0)
            Dim ramo = row.Item(3)
            Dim poliza = row.Item(4)
            Dim cuota = row.Item(6)
            Dim moneda = row.Item(8)
            Dim importe = row.Item(9)
            ComprobantesAct.PrintTicket(poliza.Value, cuota.Value, moneda.Value, importe.Value, comprobante.Value, ramo.Value)
        Else
            MsgBox("Debe seleccionar un registro para poder imprimir", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
End Class