<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccesoMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccesoMenu))
        Me.btnModComprobantes = New System.Windows.Forms.Button()
        Me.Permisos = New System.Windows.Forms.Button()
        Me.btnDetalleComprobantes = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnModComprobantes
        '
        Me.btnModComprobantes.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.kedit
        Me.btnModComprobantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModComprobantes.Location = New System.Drawing.Point(179, 145)
        Me.btnModComprobantes.Name = "btnModComprobantes"
        Me.btnModComprobantes.Size = New System.Drawing.Size(90, 68)
        Me.btnModComprobantes.TabIndex = 3
        Me.btnModComprobantes.Text = "Modificar Comprobantes"
        Me.btnModComprobantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModComprobantes.UseVisualStyleBackColor = True
        '
        'Permisos
        '
        Me.Permisos.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.edit_group
        Me.Permisos.Location = New System.Drawing.Point(55, 145)
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(89, 68)
        Me.Permisos.TabIndex = 2
        Me.Permisos.Text = "Permisos"
        Me.Permisos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Permisos.UseVisualStyleBackColor = True
        '
        'btnDetalleComprobantes
        '
        Me.btnDetalleComprobantes.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.kdvi
        Me.btnDetalleComprobantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDetalleComprobantes.Location = New System.Drawing.Point(179, 52)
        Me.btnDetalleComprobantes.Name = "btnDetalleComprobantes"
        Me.btnDetalleComprobantes.Size = New System.Drawing.Size(90, 68)
        Me.btnDetalleComprobantes.TabIndex = 1
        Me.btnDetalleComprobantes.Text = "Detalle Comprobantes"
        Me.btnDetalleComprobantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalleComprobantes.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.lassists
        Me.btnPagos.Location = New System.Drawing.Point(55, 52)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(90, 68)
        Me.btnPagos.TabIndex = 0
        Me.btnPagos.Text = "Cobrar"
        Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'frmAccesoMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 279)
        Me.Controls.Add(Me.btnModComprobantes)
        Me.Controls.Add(Me.Permisos)
        Me.Controls.Add(Me.btnDetalleComprobantes)
        Me.Controls.Add(Me.btnPagos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccesoMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents btnDetalleComprobantes As System.Windows.Forms.Button
    Friend WithEvents Permisos As System.Windows.Forms.Button
    Friend WithEvents btnModComprobantes As System.Windows.Forms.Button
End Class
