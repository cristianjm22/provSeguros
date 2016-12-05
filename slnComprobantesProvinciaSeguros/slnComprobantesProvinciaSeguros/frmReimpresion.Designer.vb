<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReimpresion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblPoliza = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.dgvReimpresion = New System.Windows.Forms.DataGridView()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblReimpresion = New System.Windows.Forms.Label()
        Me.lblSinRegistros = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvReimpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPoliza
        '
        Me.lblPoliza.AutoSize = True
        Me.lblPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoliza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPoliza.Location = New System.Drawing.Point(62, 179)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(36, 14)
        Me.lblPoliza.TabIndex = 0
        Me.lblPoliza.Text = "Poliza"
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(103, 176)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 1
        '
        'dgvReimpresion
        '
        Me.dgvReimpresion.AllowUserToAddRows = False
        Me.dgvReimpresion.AllowUserToDeleteRows = False
        Me.dgvReimpresion.AllowUserToOrderColumns = True
        Me.dgvReimpresion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReimpresion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReimpresion.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvReimpresion.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReimpresion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReimpresion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReimpresion.Enabled = False
        Me.dgvReimpresion.Location = New System.Drawing.Point(65, 207)
        Me.dgvReimpresion.MultiSelect = False
        Me.dgvReimpresion.Name = "dgvReimpresion"
        Me.dgvReimpresion.ReadOnly = True
        Me.dgvReimpresion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReimpresion.ShowEditingIcon = False
        Me.dgvReimpresion.ShowRowErrors = False
        Me.dgvReimpresion.Size = New System.Drawing.Size(1300, 212)
        Me.dgvReimpresion.TabIndex = 2
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
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1606, 94)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1284, 500)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(1086, -9)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(176, 103)
        '
        'lblReimpresion
        '
        Me.lblReimpresion.AutoSize = True
        Me.lblReimpresion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReimpresion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblReimpresion.Location = New System.Drawing.Point(61, 139)
        Me.lblReimpresion.Name = "lblReimpresion"
        Me.lblReimpresion.Size = New System.Drawing.Size(192, 19)
        Me.lblReimpresion.TabIndex = 29
        Me.lblReimpresion.Text = "Reimpresion de Ticket"
        '
        'lblSinRegistros
        '
        Me.lblSinRegistros.AutoSize = True
        Me.lblSinRegistros.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinRegistros.Location = New System.Drawing.Point(564, 243)
        Me.lblSinRegistros.Name = "lblSinRegistros"
        Me.lblSinRegistros.Size = New System.Drawing.Size(191, 16)
        Me.lblSinRegistros.TabIndex = 39
        Me.lblSinRegistros.Text = "No se encontraron registros"
        Me.lblSinRegistros.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnImprimir.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Very_Basic_Ok_icon_1_
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(1104, 425)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(108, 29)
        Me.btnImprimir.TabIndex = 38
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.appbar_filter
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(209, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 22)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'frmReimpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 500)
        Me.Controls.Add(Me.lblSinRegistros)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblReimpresion)
        Me.Controls.Add(Me.dgvReimpresion)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.lblPoliza)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmReimpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpresion de Ticket"
        CType(Me.dgvReimpresion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPoliza As System.Windows.Forms.Label
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents dgvReimpresion As System.Windows.Forms.DataGridView
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblReimpresion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblSinRegistros As System.Windows.Forms.Label
End Class
