<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Login_Usr_Txt = New System.Windows.Forms.TextBox()
        Me.User_Lbl = New System.Windows.Forms.Label()
        Me.Pass_Lbl = New System.Windows.Forms.Label()
        Me.Login_Pass_Txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkChange = New System.Windows.Forms.LinkLabel()
        Me.lnkRegistrar = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(391, 383)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(205, -3)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(176, 103)
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
        Me.RectangleShape1.Location = New System.Drawing.Point(1, 1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(388, 94)
        '
        'Login_Usr_Txt
        '
        Me.Login_Usr_Txt.Location = New System.Drawing.Point(89, 181)
        Me.Login_Usr_Txt.MaxLength = 50
        Me.Login_Usr_Txt.Name = "Login_Usr_Txt"
        Me.Login_Usr_Txt.Size = New System.Drawing.Size(226, 20)
        Me.Login_Usr_Txt.TabIndex = 9
        '
        'User_Lbl
        '
        Me.User_Lbl.AutoSize = True
        Me.User_Lbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.User_Lbl.Location = New System.Drawing.Point(89, 163)
        Me.User_Lbl.Name = "User_Lbl"
        Me.User_Lbl.Size = New System.Drawing.Size(46, 14)
        Me.User_Lbl.TabIndex = 11
        Me.User_Lbl.Text = "Usuario"
        '
        'Pass_Lbl
        '
        Me.Pass_Lbl.AutoSize = True
        Me.Pass_Lbl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pass_Lbl.Location = New System.Drawing.Point(86, 215)
        Me.Pass_Lbl.Name = "Pass_Lbl"
        Me.Pass_Lbl.Size = New System.Drawing.Size(68, 14)
        Me.Pass_Lbl.TabIndex = 12
        Me.Pass_Lbl.Text = "Contraseña"
        '
        'Login_Pass_Txt
        '
        Me.Login_Pass_Txt.Location = New System.Drawing.Point(89, 231)
        Me.Login_Pass_Txt.MaxLength = 50
        Me.Login_Pass_Txt.Name = "Login_Pass_Txt"
        Me.Login_Pass_Txt.Size = New System.Drawing.Size(226, 20)
        Me.Login_Pass_Txt.TabIndex = 10
        Me.Login_Pass_Txt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ingreso"
        '
        'lnkChange
        '
        Me.lnkChange.AutoSize = True
        Me.lnkChange.Location = New System.Drawing.Point(52, 266)
        Me.lnkChange.Name = "lnkChange"
        Me.lnkChange.Size = New System.Drawing.Size(102, 13)
        Me.lnkChange.TabIndex = 19
        Me.lnkChange.TabStop = True
        Me.lnkChange.Text = "Cambiar Contraseña"
        '
        'lnkRegistrar
        '
        Me.lnkRegistrar.AutoSize = True
        Me.lnkRegistrar.Location = New System.Drawing.Point(52, 290)
        Me.lnkRegistrar.Name = "lnkRegistrar"
        Me.lnkRegistrar.Size = New System.Drawing.Size(60, 13)
        Me.lnkRegistrar.TabIndex = 20
        Me.lnkRegistrar.TabStop = True
        Me.lnkRegistrar.Text = "Registrarse"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.appbar_lock
        Me.PictureBox2.Location = New System.Drawing.Point(55, 225)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.appbar_user
        Me.PictureBox1.Location = New System.Drawing.Point(55, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.Control
        Me.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnIngresar.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.right
        Me.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresar.Location = New System.Drawing.Point(206, 299)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(109, 29)
        Me.btnIngresar.TabIndex = 15
        Me.btnIngresar.Text = "   Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 383)
        Me.Controls.Add(Me.lnkRegistrar)
        Me.Controls.Add(Me.lnkChange)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pass_Lbl)
        Me.Controls.Add(Me.User_Lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Login_Usr_Txt)
        Me.Controls.Add(Me.Login_Pass_Txt)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Login_Usr_Txt As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents User_Lbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pass_Lbl As System.Windows.Forms.Label
    Friend WithEvents Login_Pass_Txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lnkChange As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkRegistrar As System.Windows.Forms.LinkLabel
End Class
