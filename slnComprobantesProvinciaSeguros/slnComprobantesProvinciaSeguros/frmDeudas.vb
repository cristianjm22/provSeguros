Imports System.Data.SqlClient

Public Class frmDeudas

    Private Sub cargarGrilla(ByVal poliza As String)

        Dim dt As DataTable = DeudasDA.obtenerDeudas(poliza)


        dgvDeudas.Rows.Clear()  'para limpiarlo

        dgvDeudas.DataSource = Nothing              'para limpiar cualquier registro internamente y desenlazar el control de la BD

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                dgvDeudas.Rows.Add(row("ID_DEUDA").ToString(), row("IMPORTE_DEUDA").ToString(), row("POLIZA").ToString(), row("NRO_CUOTA").ToString(), row("FECHA_INGRESO").ToString(), row("ID_COMPROBANTE").ToString(), row("ULTIMO_PAGO").ToString, row("FECHA_ULTIMO_PAGO").ToString, row("DEUDA_PENDIENTE").ToString)
            Next
        End If

        If (dt.Rows.Count = 0) Then
            lblSinRegistros.Show()
        Else
            lblSinRegistros.Hide()
        End If
    End Sub

    Private Sub frmDeudas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarGrilla(txtPoliza.Text)
    End Sub

    Private Sub txtPoliza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoliza.TextChanged
        cargarGrilla(txtPoliza.Text)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgvDeudas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDeudas.CellContentClick
        If e.ColumnIndex = 10 Then
            If e.RowIndex >= 0 AndAlso dgvDeudas.Rows(e.RowIndex).Cells(0).Value.ToString() <> Nothing Then


                If MessageBox.Show("¿Desea eliminar este registro?" _
 , "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    DeudasDA.deleteDeudas(Convert.ToInt32(dgvDeudas.Rows(dgvDeudas.CurrentRow.Index).Cells("ID_DEUDA").Value)) ' Usuario
                    cargarGrilla(txtPoliza.Text)
                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Aviso")
                End If

            End If
        End If

        If e.ColumnIndex = 9 Then
            If e.RowIndex >= 0 AndAlso dgvDeudas.Rows(dgvDeudas.CurrentRow.Index).Cells("ID_DEUDA").Value IsNot Nothing Then

                indexdgvdeuda = dgvDeudas.CurrentRow.Index

                idDeuda = dgvDeudas.Rows(indexdgvdeuda).Cells("ID_DEUDA").Value.ToString()
                frmModDeuda.txtidDeuda.Text = idDeuda
                frmModDeuda.txtImporte.Text = dgvDeudas.Rows(indexdgvdeuda).Cells("IMPORTE_DEUDA").Value.ToString()
                frmModDeuda.txtPendiente.Text = dgvDeudas.Rows(dgvDeudas.CurrentRow.Index).Cells(8).Value.ToString()
                ModificacionReporte = True

                frmModDeuda.ShowDialog()

                cargarGrilla(txtPoliza.Text)
            End If

        End If
    End Sub

    Private Sub txtPoliza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPoliza.KeyPress



        If Char.IsDigit(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSymbol(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsSeparator(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = False

        Else

            e.Handled = True

        End If



        Me.txtPoliza.Text = Trim(Replace(Me.txtPoliza.Text, "  ", " "))

        txtPoliza.Select(txtPoliza.Text.Length, 0)



    End Sub
End Class