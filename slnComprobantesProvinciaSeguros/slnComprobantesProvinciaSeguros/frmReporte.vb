Imports System.Data.SqlClient

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


        lblTotalDia.Text = lblTotalDia.Text + " $" + ComprobantesAct.ObtenerTotaldeldia()

        lblTotalQuincena.Text = lblTotalQuincena.Text + " $" + ComprobantesAct.ObtenerTotalporQuincena()

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        ComprobantesAct.GridAExcel(dgvReporte)
    End Sub

    Private Sub dgvReporte_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvReporte.CellContentClick

    End Sub
End Class