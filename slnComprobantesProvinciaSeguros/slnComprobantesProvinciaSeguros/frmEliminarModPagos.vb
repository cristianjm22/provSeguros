Public Class frmEliminarModPagos


    Private Sub frmReporte2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'conn = New SqlConnection(sCnn)
        'Dim cmd As New SqlCommand("dbo.SP_FIND_COMPROBANTES_NO_INFORMADOS", conn)
        'cmd.CommandType = CommandType.StoredProcedure
        'Dim Adpt As New SqlDataAdapter(cmd)
        'Dim table As New DataTable
        'conn.Open()
        'Try
        '    Adpt.Fill(table)
        'Catch ex As Exception
        '    Dim sr As String
        '    sr = ex.Message
        'End Try

        'dgvReporte.DataSource = table
        CargarCombo()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub dgvReporte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReporte.CellContentClick

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

        'If e.ColumnIndex = 14 Then
        '    If dgvReporte.Rows(dgvReporte.CurrentRow.Index).Cells("ID_COMPROBANTE").Value IsNot Nothing Then

        '        indexdgvReporte = dgvReporte.CurrentRow.Index

        '        ModificacionReporte = True

        '        frmModificarComprobantes.ShowDialog()

        '    End If

        'End If

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
                For Each row As DataRow In dtART.Rows

                    dgvReporte.Rows.Add(row("ID_COMPROBANTE").ToString(), row("E_LAPIZ_OPTICO").ToString(), row("FECHA_INGRESO").ToString(), row("RM").ToString(), row("POLIZA").ToString(), row("ENDOSO").ToString(), row("NRO_CUOTA").ToString(), row("FECHA_VTO").ToString(), row("ID_MONEDA").ToString(), row("MONEDA").ToString(), row("IMPORTE").ToString(), row("ID_ESTADO").ToString(), row("ESTADO").ToString())

                Next
            End If


            SetearGrilla(dgvReporte)



        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "se produjo un error")
        End Try

    End Sub

    Public Sub SetearGrilla(ByRef grid As DataGridView)

        With grid

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            .DefaultCellStyle.BackColor = Color.Beige

        End With

    End Sub


    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        cargarGrillaReporte(RTrim(LTrim(cboEstado.SelectedValue)), txtPoliza.Text)

    End Sub

    Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEstado.SelectedIndexChanged

    End Sub
End Class