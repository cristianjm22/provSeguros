Imports System.Data.SqlClient
Public Class frmPermisos
    Private WithEvents bs As New BindingSource
    Private SqlDataAdapter As SqlDataAdapter
    Private bEdit As Boolean

    Private Sub Permisos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            If bEdit Then
                'preguntar si se desea guardar   
                If (MsgBox("Guardar cambios ?", MsgBoxStyle.YesNo, "Guardar")) = MsgBoxResult.Yes Then
                    Actualizar(False)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
       

    End Sub

    Private Sub Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            cargarGrilla()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        ' propiedades del datagrid   
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

        Try
            ' Actualizar y guardar cambios   
            If Not bs.DataSource Is Nothing Then
                SqlDataAdapter.Update(CType(bs.DataSource, DataTable))
                If bCargar Then
                    cargar_registros("SELECT  USUARIO, MENU,MENU_DESCRIPCION, HABILITADO FROM PERMISOS", PermisosDGV)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


    End Sub



    Private Sub User_Txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Actualizar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try
            'bs.AddNew()
            frmAltaModPermisos.ShowDialog()
            modificarPermisos = False



        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            If Not bs.Current Is Nothing Then
                ' eliminar   
                bs.RemoveCurrent()

                'Guardar los cambios y recargar   
                Actualizar()
            Else
                MsgBox("No hay un registro actual para eliminar", MsgBoxStyle.Exclamation, "Eliminar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Actualizar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub PermisosDGV_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PermisosDGV.CellEndEdit
        Try
            bEdit = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub


    Private Sub cargarGrilla()

        Dim dt As DataTable = ComprobantesDA.obtenerPermisos()


        PermisosDGV.Rows.Clear()  'para limpiarlo

        PermisosDGV.DataSource = Nothing              'para limpiar cualquier registro internamente y desenlazar el control de la BD

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows

                PermisosDGV.Rows.Add(row("ID_PERMISO").ToString(), row("USUARIO").ToString(), row("NOMBRE_MENU").ToString(), row("MENU_DESCRIPCION").ToString(), row("HABILITADO").ToString())

            Next
        End If


    End Sub

    Private Sub PermisosDGV_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PermisosDGV.CellContentClick
        If e.ColumnIndex = 5 Then
            If PermisosDGV.Rows(PermisosDGV.CurrentRow.Index).Cells("USUARIO").Value IsNot Nothing Then

                indexPermisos = PermisosDGV.CurrentRow.Index

                iDPermiso = PermisosDGV.Rows(indexPermisos).Cells("ID_PERMISO").Value.ToString()
                frmAltaModPermisos.cboUsuario.SelectedValue = PermisosDGV.Rows(indexPermisos).Cells("USUARIO").Value.ToString()
                frmAltaModPermisos.txtMenu.Text = PermisosDGV.Rows(indexPermisos).Cells("NOMBRE_MENU").Value.ToString()
                frmAltaModPermisos.txtMenuDesc.Text = PermisosDGV.Rows(indexPermisos).Cells("MENU_DESCRIPCION").Value.ToString()
                frmAltaModPermisos.chbHabilitado.Checked = PermisosDGV.Rows(indexPermisos).Cells("HABILITADO").Value.ToString()

                modificarPermisos = True

                frmAltaModPermisos.ShowDialog()

                cargarGrilla()
            End If

        End If


        If e.ColumnIndex = 6 Then
            If PermisosDGV.Rows(PermisosDGV.CurrentRow.Index).Cells("USUARIO").Value IsNot Nothing Then


                If MessageBox.Show("¿Desea eliminar este registro?" _
 , "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    ComprobantesDA.deletePermisos(Convert.ToInt32(PermisosDGV.Rows(PermisosDGV.CurrentRow.Index).Cells("ID_PERMISO").Value)) ' Usuario
                    cargarGrilla()
                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Aviso")
                End If

            End If
        End If
    End Sub
End Class