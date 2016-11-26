Imports System.Data.SqlClient

Public Class UsuarioDA

    Public Shared Function base64Encode(ByVal sData As String) As String
        Try
            Dim encData_byte As Byte() = New Byte(sData.Length - 1) {}
            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData)
            Dim encodedData As String = Convert.ToBase64String(encData_byte)
            Return (encodedData)
        Catch ex As Exception
            Throw (New Exception("Error in base64Encode" & ex.Message))
        End Try
    End Function

    Public Shared Function base64Decode(ByVal sData As String) As String
        Dim encoder As New System.Text.UTF8Encoding()
        Dim utf8Decode As System.Text.Decoder = encoder.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(sData)
        Dim charCount As Integer = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        Dim result As String = New [String](decoded_char)
        Return result
    End Function

    Public Shared Function getPassword(ByVal sUser As String)
        Dim result As String = ""
        Dim sSel As String = "SELECT TOP 1 PASSWORD FROM USUARIOS WHERE  USUARIO='" & sUser & "'"
        conn = New SqlConnection(sCnn)
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandText = sSel
        cmd.ExecuteNonQuery()
        SQLread = cmd.ExecuteReader
        If SQLread.HasRows = True Then
            SQLread.Read()
            result = SQLread.GetString(0)
        End If
        Return result
    End Function

    Public Shared Function getUsuario(ByVal sUser As String)
        Dim result As String = ""
        Dim sSel As String = "SELECT TOP 1 USUARIO FROM USUARIOS WHERE  USUARIO='" & sUser & "'"
        conn = New SqlConnection(sCnn)
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandText = sSel
        cmd.ExecuteNonQuery()
        SQLread = cmd.ExecuteReader
        If SQLread.HasRows = True Then
            SQLread.Read()
            result = SQLread.GetString(0)
        End If
        Return result
    End Function

    Public Shared Sub insertarUsuario(ByVal sUser As String, ByVal sPass As String)
        Try
            conn = New SqlConnection(sCnn)
            conn.Open()
            Dim cmd As New SqlCommand("SP_INSERT_USUARIOS", conn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim param As New SqlParameter

            cmd.Parameters.AddWithValue("@USUARIO", sUser)
            cmd.Parameters.AddWithValue("@PASSWORD", sPass)

            cmd.ExecuteNonQuery()

            conn.Close()
        Catch e As SqlException
            MsgBox("Mensaje: " & e.Message)

        End Try
    End Sub

End Class
