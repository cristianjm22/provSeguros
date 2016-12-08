Imports System.Data.SqlClient

Public Class frmDeudas

    Private Sub cargarGrilla(ByVal poliza As String)

        Dim dt As DataTable = DeudasDA.obtenerDeudas(poliza)


        dgvDeudas.Rows.Clear()  'para limpiarlo

        dgvDeudas.DataSource = Nothing              'para limpiar cualquier registro internamente y desenlazar el control de la BD

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows

                dgvDeudas.Rows.Add(row("ID_DEUDA").ToString(), row("IMPORTE_DEUDA").ToString(), row("POLIZA").ToString(), row("NRO_CUOTA").ToString(), row("FECHA_INGRESO").ToString(), row("ID_COMPROBANTE").ToString())

            Next
        End If

        If (dt.Rows.Count = 0) Then
            lblSinRegistros.Show()
        Else
            lblSinRegistros.Hide()
        End If
    End Sub

    Private Sub dgvDeudas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDeudas.CellClick
        If e.ColumnIndex = 7 Then
            If dgvDeudas.Rows(e.RowIndex).Cells(0).Value.ToString() <> Nothing Then


                If MessageBox.Show("¿Desea eliminar este registro?" _
 , "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    DeudasDA.deleteDeudas(Convert.ToInt32(dgvDeudas.Rows(dgvDeudas.CurrentRow.Index).Cells("ID_DEUDA").Value)) ' Usuario
                    cargarGrilla(txtPoliza.Text)
                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Aviso")
                End If

            End If
        End If

        If e.ColumnIndex = 6 Then
            If dgvDeudas.Rows(dgvDeudas.CurrentRow.Index).Cells("ID_DEUDA").Value IsNot Nothing Then

                indexdgvdeuda = dgvDeudas.CurrentRow.Index

                idDeuda = dgvDeudas.Rows(indexdgvdeuda).Cells("ID_DEUDA").Value.ToString()
                frmModDeuda.txtidDeuda.Text = idDeuda
                frmModDeuda.txtImporte.Text = dgvDeudas.Rows(indexdgvdeuda).Cells("IMPORTE_DEUDA").Value.ToString()

                ModificacionReporte = True

                frmModDeuda.ShowDialog()

                cargarGrilla(txtPoliza.Text)
            End If

        End If
    End Sub

    Private Sub frmDeudas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarGrilla(txtPoliza.Text)
    End Sub

    Private Sub txtPoliza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoliza.TextChanged
        cargarGrilla(txtPoliza.Text)
    End Sub
End Class