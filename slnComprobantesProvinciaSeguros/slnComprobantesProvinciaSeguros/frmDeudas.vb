Imports System.Data.SqlClient

Public Class frmDeudas
    Public Shared table

    Private Sub frmDeudas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargargrilla()
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


    Private Sub dgvReimpresion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReimpresion.CellClick
        If e.ColumnIndex = 7 Then
            If dgvReimpresion.Rows(e.RowIndex).Cells(0).Value.ToString() <> Nothing Then


                If MessageBox.Show("Desea eliminar este registro?" _
 , "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    DeudasDA.deleteDeudas(Convert.ToInt32(dgvReimpresion.Rows(dgvReimpresion.CurrentRow.Index).Cells("ID_DEUDA").Value)) ' Usuario
                    cargarGrilla()
                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Aviso")
                End If

            End If
        End If

        If e.ColumnIndex = 6 Then
            If dgvReimpresion.Rows(dgvReimpresion.CurrentRow.Index).Cells("ID_DEUDA").Value IsNot Nothing Then

                indexdgvdeuda = dgvReimpresion.CurrentRow.Index


                idDeuda = dgvReimpresion.Rows(indexdgvdeuda).Cells("ID_DEUDA").Value.ToString()
                frmModDeuda.txtidDeuda.Text = idDeuda
                frmModDeuda.txtImporte.Text = dgvReimpresion.Rows(indexdgvdeuda).Cells("IMPORTE_DEUDA").Value.ToString()



                ModificacionReporte = True

                frmModDeuda.ShowDialog()

            End If

        End If

    End Sub

    Private Sub cargarGrilla()
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


        dgvReimpresion.Rows.Clear()  'para limpiarlo

        dgvReimpresion.DataSource = Nothing              'para limpiar cualquier registro internamente y desenlazar el control de la BD

        If table.Rows.Count > 0 Then
            For Each row As DataRow In table.Rows

                dgvReimpresion.Rows.Add(row("ID_DEUDA").ToString(), row("IMPORTE_DEUDA").ToString(), row("POLIZA").ToString(), row("FECHA_INGRESO").ToString(), row("ID_COMPROBANTE").ToString())

            Next
        End If



        If (table.Rows.Count = 0) Then
            lblSinRegistros.Show()
        Else
            lblSinRegistros.Hide()
        End If
    End Sub
End Class