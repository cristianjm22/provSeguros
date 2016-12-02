Imports System.Data.SqlClient
Public Class frmPermisos
    Private WithEvents bs As New BindingSource
    Private SqlDataAdapter As SqlDataAdapter
    Private bEdit As Boolean

    Private Sub Permisos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bEdit Then
            'preguntar si se desea guardar   
            If (MsgBox("Guardar cambios ?", MsgBoxStyle.YesNo, "Guardar")) = MsgBoxResult.Yes Then
                Actualizar(False)
            End If
        End If

    End Sub

    Private Sub Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' propiedades del datagrid   
        ' '''''''''''''''''''''''''''''''''''''   
        With PermisosDGV
            ' alternar color de filas   
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite
            .DefaultCellStyle.BackColor = Color.Beige
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With
        ' cagar los datos   
        cargar_registros("SELECT  USUARIO, MENU, LTRIM(RTRIM(MENU_DESCRIPCION)) AS MENU_DESCRIPCION, HABILITADO FROM PERMISOS ORDER BY USUARIO,MENU_DESCRIPCION", PermisosDGV)
    End Sub
    Private Sub cargar_registros( _
    ByVal sql As String, _
    ByVal dv As DataGridView)

        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
            SqlDataAdapter = New SqlDataAdapter(sql, sCnn)

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable   
            Dim dt As New DataTable()
            SqlDataAdapter.Fill(dt)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs.DataSource = dt

            With dv
                .Refresh()
                ' coloca el registro arriba de todo   
                .FirstDisplayedScrollingRowIndex = bs.Position
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Actualizar(Optional ByVal bCargar As Boolean = True)
        ' Actualizar y guardar cambios   
        If Not bs.DataSource Is Nothing Then
            SqlDataAdapter.Update(CType(bs.DataSource, DataTable))
            If bCargar Then
                cargar_registros("SELECT  USUARIO, MENU,MENU_DESCRIPCION, HABILITADO FROM PERMISOS WHERE USUARIO LIKE '%" & User_Txt.Text & "%'ORDER BY USUARIO,MENU_DESCRIPCION", PermisosDGV)
            End If
        End If

    End Sub



    Private Sub User_Txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User_Txt.TextChanged
        Actualizar()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        bs.AddNew()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Not bs.Current Is Nothing Then
            ' eliminar   
            bs.RemoveCurrent()

            'Guardar los cambios y recargar   
            Actualizar()
        Else
            MsgBox("No hay un registro actual para eliminar", MsgBoxStyle.Exclamation, "Eliminar")
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Actualizar()
    End Sub

    Private Sub PermisosDGV_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PermisosDGV.CellEndEdit
        bEdit = True
    End Sub
End Class