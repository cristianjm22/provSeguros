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
        AcomodarBotones()
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

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        Actualizar()
    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        If Not bs.Current Is Nothing Then
            ' eliminar   
            bs.RemoveCurrent()

            'Guardar los cambios y recargar   
            Actualizar()
        Else
            MsgBox("No hay un registro actual para eliminar", MsgBoxStyle.Exclamation, "Eliminar")
        End If
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
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click, btn_last.Click, btn_next.Click, btn_Previous.Click
        If sender Is btn_Previous Then
            bs.MovePrevious()
        ElseIf sender Is btn_first Then
            bs.MoveFirst()
        ElseIf sender Is btn_next Then
            bs.MoveNext()
        ElseIf sender Is btn_last Then
            bs.MoveLast()
        End If

    End Sub
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PermisosDGV.CellEndEdit
        bEdit = True
    End Sub
    Private Sub AcomodarBotones()
        btn_Update.Location = New Point(Me.Width - 100, 10)
        btn_delete.Location = New Point(btn_Update.Location.X - 100, 10)
        btn_new.Location = New Point(btn_delete.Location.X - 100, 10)
        btn_last.Location = New Point(btn_new.Location.X - 100, 10)
        btn_next.Location = New Point(btn_last.Location.X - 40, 10)
        btn_Previous.Location = New Point(btn_next.Location.X - 40, 10)
        btn_first.Location = New Point(btn_Previous.Location.X - 40, 10)

    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        bs.AddNew()
    End Sub



    Private Sub User_Txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User_Txt.TextChanged
        Actualizar()
    End Sub
    Private Sub Permisos_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'MsgBox("Cambiando")
        Dim Alto = Me.Height
        Dim Ancho = Me.Width
        Dim AltoGrid = Alto - 100
        Dim AnchoGrid = Ancho - 100
        PermisosDGV.Height = AltoGrid
        PermisosDGV.Width = AnchoGrid
        AcomodarBotones()
    End Sub
End Class