<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvReporte = New System.Windows.Forms.DataGridView()
        Me.lblReporte = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblTotalDia = New System.Windows.Forms.Label()
        Me.lblTotalQuincena = New System.Windows.Forms.Label()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReporte
        '
        Me.dgvReporte.AllowUserToAddRows = False
        Me.dgvReporte.AllowUserToDeleteRows = False
        Me.dgvReporte.AllowUserToOrderColumns = True
        Me.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReporte.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte.Location = New System.Drawing.Point(58, 216)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.ReadOnly = True
        Me.dgvReporte.ShowEditingIcon = False
        Me.dgvReporte.ShowRowErrors = False
        Me.dgvReporte.Size = New System.Drawing.Size(1165, 212)
        Me.dgvReporte.TabIndex = 0
        '
        'lblReporte
        '
        Me.lblReporte.AutoSize = True
        Me.lblReporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblReporte.Location = New System.Drawing.Point(54, 176)
        Me.lblReporte.Name = "lblReporte"
        Me.lblReporte.Size = New System.Drawing.Size(127, 19)
        Me.lblReporte.TabIndex = 28
        Me.lblReporte.Text = "Reporte diario"
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
        Me.RectangleShape1.Size = New System.Drawing.Size(1284, 94)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1284, 500)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(1095, -5)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(176, 103)
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.Control
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnExport.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.downwards_arrow
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(1085, 434)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(138, 29)
        Me.btnExport.TabIndex = 37
        Me.btnExport.Text = "Exportar"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'lblTotalDia
        '
        Me.lblTotalDia.AutoSize = True
        Me.lblTotalDia.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblTotalDia.Location = New System.Drawing.Point(54, 444)
        Me.lblTotalDia.Name = "lblTotalDia"
        Me.lblTotalDia.Size = New System.Drawing.Size(118, 19)
        Me.lblTotalDia.TabIndex = 38
        Me.lblTotalDia.Text = "Total del dia:"
        '
        'lblTotalQuincena
        '
        Me.lblTotalQuincena.AutoSize = True
        Me.lblTotalQuincena.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuincena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblTotalQuincena.Location = New System.Drawing.Point(374, 444)
        Me.lblTotalQuincena.Name = "lblTotalQuincena"
        Me.lblTotalQuincena.Size = New System.Drawing.Size(161, 19)
        Me.lblTotalQuincena.TabIndex = 39
        Me.lblTotalQuincena.Text = "Total de quincena:"
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 500)
        Me.Controls.Add(Me.lblTotalQuincena)
        Me.Controls.Add(Me.lblTotalDia)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblReporte)
        Me.Controls.Add(Me.dgvReporte)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte diario"
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReporte As System.Windows.Forms.DataGridView
    Friend WithEvents lblReporte As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblTotalDia As System.Windows.Forms.Label
    Friend WithEvents lblTotalQuincena As System.Windows.Forms.Label
End Class
