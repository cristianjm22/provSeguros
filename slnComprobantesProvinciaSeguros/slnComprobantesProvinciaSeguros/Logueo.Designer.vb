<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logueo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logueo))
        Me.Pass_Lbl = New System.Windows.Forms.Label()
        Me.User_Lbl = New System.Windows.Forms.Label()
        Me.Login_Pass_Txt = New System.Windows.Forms.TextBox()
        Me.Login_Usr_Txt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Login_No_Btn = New System.Windows.Forms.Button()
        Me.Login_Yes_Btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pass_Lbl
        '
        Me.Pass_Lbl.AutoSize = True
        Me.Pass_Lbl.Location = New System.Drawing.Point(64, 62)
        Me.Pass_Lbl.Name = "Pass_Lbl"
        Me.Pass_Lbl.Size = New System.Drawing.Size(64, 13)
        Me.Pass_Lbl.TabIndex = 12
        Me.Pass_Lbl.Text = "Contraseña:"
        '
        'User_Lbl
        '
        Me.User_Lbl.AutoSize = True
        Me.User_Lbl.Location = New System.Drawing.Point(64, 13)
        Me.User_Lbl.Name = "User_Lbl"
        Me.User_Lbl.Size = New System.Drawing.Size(46, 13)
        Me.User_Lbl.TabIndex = 11
        Me.User_Lbl.Text = "Usuario:"
        '
        'Login_Pass_Txt
        '
        Me.Login_Pass_Txt.Location = New System.Drawing.Point(67, 78)
        Me.Login_Pass_Txt.MaxLength = 50
        Me.Login_Pass_Txt.Name = "Login_Pass_Txt"
        Me.Login_Pass_Txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Login_Pass_Txt.Size = New System.Drawing.Size(141, 20)
        Me.Login_Pass_Txt.TabIndex = 10
        '
        'Login_Usr_Txt
        '
        Me.Login_Usr_Txt.Location = New System.Drawing.Point(67, 29)
        Me.Login_Usr_Txt.MaxLength = 50
        Me.Login_Usr_Txt.Name = "Login_Usr_Txt"
        Me.Login_Usr_Txt.Size = New System.Drawing.Size(141, 20)
        Me.Login_Usr_Txt.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.appbar_user
        Me.PictureBox1.Location = New System.Drawing.Point(1, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Login_No_Btn
        '
        Me.Login_No_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Login_No_Btn.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.button_cancel
        Me.Login_No_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Login_No_Btn.Location = New System.Drawing.Point(128, 118)
        Me.Login_No_Btn.Name = "Login_No_Btn"
        Me.Login_No_Btn.Size = New System.Drawing.Size(80, 22)
        Me.Login_No_Btn.TabIndex = 14
        Me.Login_No_Btn.Text = "   Cancelar"
        Me.Login_No_Btn.UseVisualStyleBackColor = True
        '
        'Login_Yes_Btn
        '
        Me.Login_Yes_Btn.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.button_ok
        Me.Login_Yes_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Login_Yes_Btn.Location = New System.Drawing.Point(39, 118)
        Me.Login_Yes_Btn.Name = "Login_Yes_Btn"
        Me.Login_Yes_Btn.Size = New System.Drawing.Size(71, 22)
        Me.Login_Yes_Btn.TabIndex = 13
        Me.Login_Yes_Btn.Text = "  Aceptar"
        Me.Login_Yes_Btn.UseVisualStyleBackColor = True
        '
        'Logueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 154)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Login_No_Btn)
        Me.Controls.Add(Me.Login_Yes_Btn)
        Me.Controls.Add(Me.Pass_Lbl)
        Me.Controls.Add(Me.User_Lbl)
        Me.Controls.Add(Me.Login_Pass_Txt)
        Me.Controls.Add(Me.Login_Usr_Txt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Logueo"
        Me.Text = "Logueo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Login_No_Btn As System.Windows.Forms.Button
    Friend WithEvents Login_Yes_Btn As System.Windows.Forms.Button
    Friend WithEvents Pass_Lbl As System.Windows.Forms.Label
    Friend WithEvents User_Lbl As System.Windows.Forms.Label
    Friend WithEvents Login_Pass_Txt As System.Windows.Forms.TextBox
    Friend WithEvents Login_Usr_Txt As System.Windows.Forms.TextBox
End Class
