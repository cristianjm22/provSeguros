<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPermisos))
        Me.PermisosDGV = New System.Windows.Forms.DataGridView()
        Me.User_Lbl = New System.Windows.Forms.Label()
        Me.User_Txt = New System.Windows.Forms.TextBox()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_Previous = New System.Windows.Forms.Button()
        Me.btn_first = New System.Windows.Forms.Button()
        CType(Me.PermisosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PermisosDGV
        '
        Me.PermisosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PermisosDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.PermisosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PermisosDGV.Location = New System.Drawing.Point(12, 60)
        Me.PermisosDGV.Name = "PermisosDGV"
        Me.PermisosDGV.Size = New System.Drawing.Size(892, 187)
        Me.PermisosDGV.TabIndex = 0
        '
        'User_Lbl
        '
        Me.User_Lbl.AutoSize = True
        Me.User_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Lbl.Location = New System.Drawing.Point(21, 17)
        Me.User_Lbl.Name = "User_Lbl"
        Me.User_Lbl.Size = New System.Drawing.Size(58, 16)
        Me.User_Lbl.TabIndex = 8
        Me.User_Lbl.Text = "Usuario:"
        '
        'User_Txt
        '
        Me.User_Txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.User_Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Txt.Location = New System.Drawing.Point(85, 11)
        Me.User_Txt.MaxLength = 30
        Me.User_Txt.Name = "User_Txt"
        Me.User_Txt.Size = New System.Drawing.Size(117, 22)
        Me.User_Txt.TabIndex = 9
        '
        'btn_Update
        '
        Me.btn_Update.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.database_save
        Me.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Update.Location = New System.Drawing.Point(829, 17)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(75, 25)
        Me.btn_Update.TabIndex = 7
        Me.btn_Update.Text = "   Guardar"
        Me.btn_Update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.database_delete
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(748, 17)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 25)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "  Eliminar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.database_add
        Me.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new.Location = New System.Drawing.Point(667, 17)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 25)
        Me.btn_new.TabIndex = 5
        Me.btn_new.Text = "  Nuevo"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_last
        '
        Me.btn_last.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.doblerightarrow
        Me.btn_last.Location = New System.Drawing.Point(493, 253)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(37, 25)
        Me.btn_last.TabIndex = 4
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.rightarrow
        Me.btn_next.Location = New System.Drawing.Point(450, 253)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(37, 25)
        Me.btn_next.TabIndex = 3
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_Previous
        '
        Me.btn_Previous.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.leftarrow
        Me.btn_Previous.Location = New System.Drawing.Point(407, 253)
        Me.btn_Previous.Name = "btn_Previous"
        Me.btn_Previous.Size = New System.Drawing.Size(37, 25)
        Me.btn_Previous.TabIndex = 2
        Me.btn_Previous.UseVisualStyleBackColor = True
        '
        'btn_first
        '
        Me.btn_first.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.dobleleftarrow
        Me.btn_first.Location = New System.Drawing.Point(364, 253)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(37, 25)
        Me.btn_first.TabIndex = 1
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'frmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(916, 313)
        Me.Controls.Add(Me.User_Txt)
        Me.Controls.Add(Me.User_Lbl)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_Previous)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.PermisosDGV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPermisos"
        Me.Text = "Permisos"
        CType(Me.PermisosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PermisosDGV As System.Windows.Forms.DataGridView
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents btn_Previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_Update As System.Windows.Forms.Button
    Friend WithEvents User_Lbl As System.Windows.Forms.Label
    Friend WithEvents User_Txt As System.Windows.Forms.TextBox
End Class
