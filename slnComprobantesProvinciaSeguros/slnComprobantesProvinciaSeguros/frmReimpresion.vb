Imports System.Data.SqlClient

Public Class frmReimpresion
    Public Shared table

    Private Sub frmReimpresion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        table = New DataTable
        conn = New SqlConnection(sCnn)
        Dim cmd As New SqlCommand("dbo.SP_FIND_COMPROBANTES_REIMPRESION", conn)
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
            btnImprimir.Hide()
        Else
            lblSinRegistros.Hide()
            btnImprimir.Show()
        End If

    End Sub

    Private Sub txtPoliza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoliza.TextChanged
        Dim dv As DataView
        dv = New DataView(table, "POLIZA like '%" + txtPoliza.Text + "%'", "POLIZA Desc", DataViewRowState.CurrentRows)
        dgvReimpresion.DataSource = dv
        If (dv.Count = 0) Then
            lblSinRegistros.Show()
            btnImprimir.Hide()
        Else
            lblSinRegistros.Hide()
            btnImprimir.Show()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim listSelected = dgvReimpresion.SelectedRows
        If (listSelected.Count > 0) Then
            Dim row = listSelected(0).Cells()
            Dim comprobante = row.Item(0)
            Dim ramo = row.Item(3)
            Dim poliza = row.Item(4)
            Dim cuota = row.Item(6)
            Dim moneda = ComprobantesAct.getCodMonedaByDescription(row.Item(8).Value)
            Dim importe = row.Item(9)
            ComprobantesAct.PrintTicket(poliza.Value, cuota.Value, moneda, importe.Value, comprobante.Value, ramo.Value)
        Else
            MsgBox("Debe seleccionar un registro para poder imprimir", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class