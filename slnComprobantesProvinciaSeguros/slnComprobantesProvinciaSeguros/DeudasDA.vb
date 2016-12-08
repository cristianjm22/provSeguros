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

    Public Shared Function UpdateDeudas(ByVal ID_DEUDA As Integer, ByVal IMPORTE_DEUDA As Decimal)

        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_UPDATE_DEUDAS", conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ID_DEUDA", ID_DEUDA)
            cmd.Parameters.AddWithValue("@IMPORTE_DEUDA", IMPORTE_DEUDA)

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
End Class
