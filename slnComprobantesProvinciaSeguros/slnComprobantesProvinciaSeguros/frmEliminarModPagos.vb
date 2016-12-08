﻿Public Class frmEliminarModPagos


    Private Sub frmReporte2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombo()
        cargarGrillaReporte(RTrim(LTrim(cboEstado.SelectedValue)), txtPoliza.Text)
    End Sub

    Private Sub dgvReporte_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReporte.CellClick
        If e.ColumnIndex = 13 Then
            If dgvReporte.Rows(e.RowIndex).Cells(0).Value.ToString() <> Nothing Then


                If MessageBox.Show("Desea eliminar este registro?" _
 , "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    ComprobantesDA.deleteComprobantesPagos(Convert.ToInt32(dgvReporte.Rows(dgvReporte.CurrentRow.Index).Cells("ID_COMPROBANTE").Value), Usuario) ' Usuario
                    cargarGrillaReporte(cboEstado.SelectedValue, txtPoliza.Text)
                End If

            End If
        End If

    End Sub
    ''' <summary>
    ''' Cristian Morales
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCombo()
        Dim ds As New DataTable
        Dim Query As String = "Select [ID_ESTADO],[ESTADO] FROM [dbo].[TIPOS_ESTADOS]"

        ds = ComprobantesDA.EjecutaQuery(Query)
        If ds.Rows.Count > 0 Then
            cboEstado.DataSource = ds

            cboEstado.ValueMember = "ID_ESTADO"
            cboEstado.DisplayMember = "ESTADO"
        End If
    End Sub

    ''' <summary>
    ''' Autor:Cristian Morales
    ''' </summary>
    ''' <param name="estado"></param>
    ''' <remarks></remarks>
    Public Sub cargarGrillaReporte(ByVal estado As Integer, ByVal poliza As String)

        Try

            Dim dtART As DataTable
            dtART = ComprobantesDA.obtenerDetalleComprobantesPorEstado(estado, poliza)

            dgvReporte.Rows.Clear()  'para limpiarlo

            dgvReporte.DataSource = Nothing              'para limpiar cualquier registro internamente y desenlazar el control de la BD

            If dtART.Rows.Count > 0 Then
                lblSinRegistros.Hide()
                For Each row As DataRow In dtART.Rows

                    dgvReporte.Rows.Add(row("ID_COMPROBANTE").ToString(), row("E_LAPIZ_OPTICO").ToString(), row("FECHA_INGRESO").ToString(), row("RM").ToString(), row("POLIZA").ToString(), row("ENDOSO").ToString(), row("NRO_CUOTA").ToString(), row("FECHA_VTO").ToString(), row("ID_MONEDA").ToString(), row("MONEDA").ToString(), row("IMPORTE").ToString(), row("ID_ESTADO").ToString(), row("ESTADO").ToString())

                Next
            Else
                lblSinRegistros.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "se produjo un error")
        End Try

    End Sub

    Private Sub cboEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.SelectedIndexChanged
        If cboEstado.SelectedValue.ToString <> "System.Data.DataRowView" Then
            cargarGrillaReporte(RTrim(LTrim(cboEstado.SelectedValue)), txtPoliza.Text)
        End If
    End Sub

    Private Sub txtPoliza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPoliza.TextChanged
        cargarGrillaReporte(RTrim(LTrim(cboEstado.SelectedValue)), txtPoliza.Text)
    End Sub
End Class