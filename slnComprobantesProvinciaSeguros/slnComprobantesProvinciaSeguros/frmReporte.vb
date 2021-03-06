﻿Imports System.Data.SqlClient

Public Class frmReporte

    Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn = New SqlConnection(sCnn)
        Dim cmd As New SqlCommand("dbo.SP_FIND_COMPROBANTES_NO_INFORMADOS", conn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim Adpt As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        conn.Open()
        Try
            Adpt.Fill(table)
        Catch ex As Exception
            Dim sr As String
            sr = ex.Message
        End Try

        dgvReporte.DataSource = table

        If (table.Rows.Count = 0) Then
            lblSinRegistros.Show()
            btnExport.Hide()
            lblTotalDia.Hide()
            dgvReporte.Hide()
            totalDia.Hide()

            lblTotalPagoAnticipado.Hide()
            lblPagoAnticipado.Hide()
            lblPagosTarjetas.Hide()
            totalpagosTarjeta.Hide()

        Else
            lblSinRegistros.Hide()
            btnExport.Show()
            totalDia.Text = "$" + ComprobantesAct.ObtenerTotaldeldia()
            dgvReporte.Show()
            lblTotalPagoAnticipado.Text = "$" + ComprobantesAct.obtenerTotalPagosAnticipados()
            totalpagosTarjeta.Text = "$" + ComprobantesAct.obtenerTotalpagosTarjeta()
            lblTotalDia.Show()
   
            totalDia.Show()

            lblPagoAnticipado.Show()
            lblTotalPagoAnticipado.Show()
            lblPagosTarjetas.Show()
            totalpagosTarjeta.Show()
        End If

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

        Dim result = False
        If (MsgBox("¿Desea exportar los pagos? " + vbCrLf + "Tenga en cuenta que esta accion modifica el estado de los mismos.", MsgBoxStyle.YesNo, "Exportar")) = MsgBoxResult.Yes Then

            If dgvReporte.Rows.Count = 0 Then
                MsgBox("No hay información para exportar.", MsgBoxStyle.Information)
            Else
                ' Object to mark the times for each process
                Dim stopwatch As New Stopwatch()
                Me.UseWaitCursor = True
                stopwatch.Start()
                result = ComprobantesAct.GridAExcel555(dgvReporte, ComprobantesAct.ObtenerTotaldeldia())

                stopwatch.Stop()
                Me.UseWaitCursor = False

            End If

            If (result) Then
                ComprobantesDA.InformarPago()
                Me.frmReporte_Load(sender, e)
            End If
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class