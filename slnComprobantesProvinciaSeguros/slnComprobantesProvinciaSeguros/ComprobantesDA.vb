Imports System.Data.SqlClient
Public Class ComprobantesDA

    ''' <summary>
    ''' Autor:Cristian Morales
    ''' Inserta el detalle de los comprobantes cobrados de provincia seguros
    ''' </summary>
    ''' <param name="ENTRADA"></param>
    ''' <param name="RM"></param>
    ''' <param name="POLIZA"></param>
    ''' <param name="ENDOSO"></param>
    ''' <param name="NROCUENTA"></param>
    ''' <param name="FECHAVTO"></param>
    ''' <param name="MONEDA"></param>
    ''' <param name="IMPORTE"></param>
    ''' <param name="OBSERVACIONES"></param>
    ''' <param name="USR_ALTA"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function InsertarDetalleComprobante(
           ByVal ENTRADA As String,
           ByVal RM As String,
           ByVal POLIZA As String,
           ByVal ENDOSO As String,
           ByVal NROCUENTA As String,
           ByVal FECHAVTO As Date,
           ByVal MONEDA As String,
           ByVal IMPORTE As Decimal,
           ByVal OBSERVACIONES As String,
           ByVal USR_ALTA As String)


        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_INSERT_DETALLE_COMPROBANTE", conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim param As New SqlParameter


            cmd.Parameters.AddWithValue("@E_LAPIZ_OPTICO", ENTRADA)
            cmd.Parameters.AddWithValue("@RM", RM)
            cmd.Parameters.AddWithValue("@POLIZA", POLIZA)
            cmd.Parameters.AddWithValue("@ENDOSO", ENDOSO)
            cmd.Parameters.AddWithValue("@NRO_CUOTA", NROCUENTA)
            cmd.Parameters.AddWithValue("@FECHA_VTO", FECHAVTO)
            cmd.Parameters.AddWithValue("@MONEDA", MONEDA)
            cmd.Parameters.AddWithValue("@IMPORTE", IMPORTE)
            cmd.Parameters.AddWithValue("@USUARIO_ALTA", USR_ALTA)
            cmd.Parameters.AddWithValue("@OBSERVACIONES", OBSERVACIONES)

            'param.ParameterName = "@EXISTE"
            'param.SqlDbType = SqlDbType.Int
            'param.Direction = ParameterDirection.Output
            'cmd.Parameters.Add(param)



            cmd.ExecuteNonQuery()
            'val = cmd.Parameters("@EXISTE").Value
            'Return (val)

            conn.Close()
        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)

        End Try

    End Function

    ''' <summary>
    ''' Autor: Morales Cristian
    ''' Verifica si un pago es anticipado
    ''' </summary>
    ''' <param name="ENDOSO"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function verificaPagoAnticipado(ByVal ENDOSO As String)

        Dim dt As New DataTable


        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_VERIFICA_PAGO_ANTICIPADO", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 300
            cmd.Parameters.AddWithValue("@ENDOSO", ENDOSO)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            conn.Close()


        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
        End Try

        Return dt.Rows(0)(0)

    End Function


    ''' <summary>
    ''' Autor: Morales Cristian
    ''' Obtiene el detalle de todos los comprobantes
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function obtenerDetalleComprobantes()

        Dim dt As New DataTable

        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_OBTENER_DETALLE_COMPROBANTES", conn)
            cmd.CommandTimeout = 300 'Especifico que lance un error de time out  despues de 5 min.
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            conn.Close()

        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
        End Try

        Return dt

    End Function


    Public Shared Function verificaPermisos(ByVal USUARIO As String, ByVal MENU As String)

        Dim dt As New DataTable


        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_VERIFICAR_PERMISO", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 300
            cmd.Parameters.AddWithValue("@USUARIO", USUARIO)
            cmd.Parameters.AddWithValue("@MENU", MENU)

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            conn.Close()


        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)
        End Try

        Return dt

    End Function
End Class
