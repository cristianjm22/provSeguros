Imports System.Data.SqlClient

Public Class DeudasDA

    Public Shared Function deleteDeudas(ByVal ID_DEUDA As String)

        Dim dt As New DataTable
        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_DELETE_DEUDAS", conn)
            cmd.CommandTimeout = 300 'Especifico que lance un error de time out  despues de 5 min.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 300
            cmd.Parameters.AddWithValue("@ID_DEUDA", ID_DEUDA)


            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            conn.Close()

        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
        End Try

        Return dt

    End Function

    Public Shared Function UpdateDeudas(ByVal ID_DEUDA As Integer, ByVal ULTIMO_PAGO As Decimal, ByVal PENDIENTE As Decimal)

        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_UPDATE_DEUDAS", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID_DEUDA", ID_DEUDA)
            cmd.Parameters.AddWithValue("@ULTIMO_PAGO", ULTIMO_PAGO)
            cmd.Parameters.AddWithValue("@PENDIENTE", PENDIENTE)

            Return cmd.ExecuteNonQuery()
            conn.Close()
        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
            Return 0
        End Try

    End Function



    ''' <summary>
    ''' Autor: Morales Cristian
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function obtenerDeudas(ByVal Poliza As String)

        Dim dt As New DataTable

        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_FIND_DEUDAS", conn)
            cmd.CommandTimeout = 300 'Especifico que lance un error de time out  despues de 5 min.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@POLIZA", Poliza)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            conn.Close()

        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
        End Try

        Return dt

    End Function

    Public Shared Function CancelarDeuda(ByVal idDeuda As Integer)
        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_DELETE_DEUDAS", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID_DEUDA", idDeuda)

            Return cmd.ExecuteNonQuery()
            conn.Close()
        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
            Return 0
        End Try
    End Function

    Public Shared Function FindDeudaById(ByVal idDeuda As Integer)
        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_FIND_DEUDAS_BY_ID", conn)
            cmd.CommandType = CommandType.StoredProcedure


            cmd.Parameters.AddWithValue("@ID_DEUDA", idDeuda)
            Dim reader = cmd.ExecuteReader()
            reader.Read()
            Dim ticketDeuda = New TicketDeuda
            ticketDeuda.setComprobante(reader(5).ToString)
            ticketDeuda.setCuota(reader(2).ToString.Trim)
            ticketDeuda.setDeudaInicial(reader(7).ToString)
            ticketDeuda.setDeudaPendiente(reader(8).ToString)
            ticketDeuda.setFechaIngreso(reader(4).ToString)
            ticketDeuda.setMoneda(reader(3).ToString.Trim)
            ticketDeuda.setPoliza(reader(1).ToString.Trim)
            ticketDeuda.setRamo(reader(6).ToString.Trim)
            ticketDeuda.setUltimoPago(reader(0).ToString)

            Return ticketDeuda
            conn.Close()
        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
            Return Nothing
        End Try
    End Function



End Class
