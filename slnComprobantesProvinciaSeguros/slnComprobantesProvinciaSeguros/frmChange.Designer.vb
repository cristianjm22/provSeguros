﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChange))
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblClaveOld = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.lblClaveNew = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(1, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(361, 94)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(355, 348)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(170, 0)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(176, 103)
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(34, 174)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(46, 14)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Usuario"
        '
        'lblClaveOld
        '
        Me.lblClaveOld.AutoSize = True
        Me.lblClaveOld.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblClaveOld.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClaveOld.Location = New System.Drawing.Point(34, 200)
        Me.lblClaveOld.Name = "lblClaveOld"
        Me.lblClaveOld.Size = New System.Drawing.Size(71, 14)
        Me.lblClaveOld.TabIndex = 2
        Me.lblClaveOld.Text = "Clave actual"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(119, 172)
        Me.txtUser.MaxLength = 15
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(177, 20)
        Me.txtUser.TabIndex = 1
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(119, 200)
        Me.txtOldPass.MaxLength = 15
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(177, 20)
        Me.txtOldPass.TabIndex = 2
        Me.txtOldPass.UseSystemPasswordChar = True
        '
        'lblClaveNew
        '
        Me.lblClaveNew.AutoSize = True
        Me.lblClaveNew.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblClaveNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClaveNew.Location = New System.Drawing.Point(34, 230)
        Me.lblClaveNew.Name = "lblClaveNew"
        Me.lblClaveNew.Size = New System.Drawing.Size(72, 14)
        Me.lblClaveNew.TabIndex = 5
        Me.lblClaveNew.Text = "Nueva clave"
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(119, 228)
        Me.txtNewPass.MaxLength = 15
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(177, 20)
        Me.txtNewPass.TabIndex = 3
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cambio de Clave "
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnCancelar.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.cancelar
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(214, 282)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 29)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.SystemColors.Control
        Me.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnChange.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChange.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnChange.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.aceptar
        Me.btnChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChange.Location = New System.Drawing.Point(126, 282)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(82, 29)
        Me.btnChange.TabIndex = 4
        Me.btnChange.Text = "Cambiar"
        Me.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'frmChange
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(355, 348)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.lblClaveNew)
        Me.Controls.Add(Me.txtOldPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblClaveOld)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblClaveOld As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents lblClaveNew As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
End Class
