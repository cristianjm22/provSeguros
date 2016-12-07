Imports System.Data.SqlClient

Public Class frmDeudas


    Private Sub frmDeudas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Cargargrilla()
    End Sub




    Private Sub dgvReimpresion_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReimpresion.CellClick
        If e.ColumnIndex = 7 Then
            If dgvReimpresion.Rows(e.RowIndex).Cells(0).Value.ToString() <> Nothing Then


                If MessageBox.Show("Desea eliminar este registro?" _
 , "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    DeudasDA.deleteDeudas(Convert.ToInt32(dgvReimpresion.Rows(dgvReimpresion.CurrentRow.Index).Cells("ID_DEUDA").Value)) ' Usuario
                    cargarGrilla(txtPoliza.Text)
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

    Private Sub cargarGrilla(ByVal poliza As String)

        Dim dt As DataTable = DeudasDA.obtenerDeudas(poliza)


        dgvReimpresion.Rows.Clear()  'para limpiarlo

        dgvReimpresion.DataSource = Nothing              'para limpiar cualquier registro internamente y desenlazar el control de la BD

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows

                dgvReimpresion.Rows.Add(row("ID_DEUDA").ToString(), row("IMPORTE_DEUDA").ToString(), row("POLIZA").ToString(), row("NRO_CUOTA").ToString(), row("FECHA_INGRESO").ToString(), row("ID_COMPROBANTE").ToString())

            Next
        End If



        If (dt.Rows.Count = 0) Then
            lblSinRegistros.Show()
        Else
            lblSinRegistros.Hide()
        End If
    End Sub


    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If txtPoliza.Text <> Nothing Then
            cargarGrilla(txtPoliza.Text)
        Else
            MsgBox("Debe ingresar un numero de poliza", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
End Class