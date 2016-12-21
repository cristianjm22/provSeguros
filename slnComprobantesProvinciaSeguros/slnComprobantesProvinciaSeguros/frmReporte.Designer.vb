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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporte))
        Me.dgvReporte = New System.Windows.Forms.DataGridView()
        Me.lblReporte = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblTotalDia = New System.Windows.Forms.Label()
        Me.lblTotalQuincena = New System.Windows.Forms.Label()
        Me.lblSinRegistros = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblproximaquincena = New System.Windows.Forms.Label()
        Me.totalDia = New System.Windows.Forms.Label()
        Me.totalQuincena = New System.Windows.Forms.Label()
        Me.totalProx = New System.Windows.Forms.Label()
        Me.lblTotalPagoAnticipado = New System.Windows.Forms.Label()
        Me.lblPagoAnticipado = New System.Windows.Forms.Label()
        Me.totalpagosTarjeta = New System.Windows.Forms.Label()
        Me.lblPagosTarjetas = New System.Windows.Forms.Label()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReporte
        '
        Me.dgvReporte.AllowUserToAddRows = False
        Me.dgvReporte.AllowUserToDeleteRows = False
        Me.dgvReporte.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReporte.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReporte.ColumnHeadersHeight = 30
        Me.dgvReporte.EnableHeadersVisualStyles = False
        Me.dgvReporte.Location = New System.Drawing.Point(58, 157)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.ReadOnly = True
        Me.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReporte.ShowEditingIcon = False
        Me.dgvReporte.ShowRowErrors = False
        Me.dgvReporte.Size = New System.Drawing.Size(1214, 253)
        Me.dgvReporte.TabIndex = 0
        '
        'lblReporte
        '
        Me.lblReporte.AutoSize = True
        Me.lblReporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblReporte.Location = New System.Drawing.Point(54, 117)
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
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(1315, 94)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1315, 510)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(1121, -4)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
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
        Me.btnExport.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.download
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
        Me.lblTotalDia.Location = New System.Drawing.Point(54, 434)
        Me.lblTotalDia.Name = "lblTotalDia"
        Me.lblTotalDia.Size = New System.Drawing.Size(88, 19)
        Me.lblTotalDia.TabIndex = 38
        Me.lblTotalDia.Text = "Total dia:"
        '
        'lblTotalQuincena
        '
        Me.lblTotalQuincena.AutoSize = True
        Me.lblTotalQuincena.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuincena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblTotalQuincena.Location = New System.Drawing.Point(411, 434)
        Me.lblTotalQuincena.Name = "lblTotalQuincena"
        Me.lblTotalQuincena.Size = New System.Drawing.Size(136, 19)
        Me.lblTotalQuincena.TabIndex = 39
        Me.lblTotalQuincena.Text = "Total quincena:"
        '
        'lblSinRegistros
        '
        Me.lblSinRegistros.AutoSize = True
        Me.lblSinRegistros.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinRegistros.Location = New System.Drawing.Point(544, 201)
        Me.lblSinRegistros.Name = "lblSinRegistros"
        Me.lblSinRegistros.Size = New System.Drawing.Size(191, 16)
        Me.lblSinRegistros.TabIndex = 40
        Me.lblSinRegistros.Text = "No se encontraron registros"
        Me.lblSinRegistros.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnCerrar.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.back_1_
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(1085, 468)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(138, 29)
        Me.btnCerrar.TabIndex = 47
        Me.btnCerrar.Text = "Volver"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblproximaquincena
        '
        Me.lblproximaquincena.AutoSize = True
        Me.lblproximaquincena.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproximaquincena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblproximaquincena.Location = New System.Drawing.Point(411, 462)
        Me.lblproximaquincena.Name = "lblproximaquincena"
        Me.lblproximaquincena.Size = New System.Drawing.Size(208, 19)
        Me.lblproximaquincena.TabIndex = 48
        Me.lblproximaquincena.Text = "Total proxima quincena:"
        '
        'totalDia
        '
        Me.totalDia.AutoSize = True
        Me.totalDia.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.totalDia.Location = New System.Drawing.Point(148, 434)
        Me.totalDia.Name = "totalDia"
        Me.totalDia.Size = New System.Drawing.Size(19, 19)
        Me.totalDia.TabIndex = 49
        Me.totalDia.Text = "$"
        '
        'totalQuincena
        '
        Me.totalQuincena.AutoSize = True
        Me.totalQuincena.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalQuincena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.totalQuincena.Location = New System.Drawing.Point(553, 434)
        Me.totalQuincena.Name = "totalQuincena"
        Me.totalQuincena.Size = New System.Drawing.Size(19, 19)
        Me.totalQuincena.TabIndex = 50
        Me.totalQuincena.Text = "$"
        '
        'totalProx
        '
        Me.totalProx.AutoSize = True
        Me.totalProx.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalProx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.totalProx.Location = New System.Drawing.Point(625, 462)
        Me.totalProx.Name = "totalProx"
        Me.totalProx.Size = New System.Drawing.Size(19, 19)
        Me.totalProx.TabIndex = 51
        Me.totalProx.Text = "$"
        '
        'lblTotalPagoAnticipado
        '
        Me.lblTotalPagoAnticipado.AutoSize = True
        Me.lblTotalPagoAnticipado.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPagoAnticipado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblTotalPagoAnticipado.Location = New System.Drawing.Point(247, 462)
        Me.lblTotalPagoAnticipado.Name = "lblTotalPagoAnticipado"
        Me.lblTotalPagoAnticipado.Size = New System.Drawing.Size(19, 19)
        Me.lblTotalPagoAnticipado.TabIndex = 53
        Me.lblTotalPagoAnticipado.Text = "$"
        '
        'lblPagoAnticipado
        '
        Me.lblPagoAnticipado.AutoSize = True
        Me.lblPagoAnticipado.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagoAnticipado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblPagoAnticipado.Location = New System.Drawing.Point(54, 462)
        Me.lblPagoAnticipado.Name = "lblPagoAnticipado"
        Me.lblPagoAnticipado.Size = New System.Drawing.Size(193, 19)
        Me.lblPagoAnticipado.TabIndex = 52
        Me.lblPagoAnticipado.Text = "Total pago anticipado:"
        '
        'totalpagosTarjeta
        '
        Me.totalpagosTarjeta.AutoSize = True
        Me.totalpagosTarjeta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalpagosTarjeta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.totalpagosTarjeta.Location = New System.Drawing.Point(923, 434)
        Me.totalpagosTarjeta.Name = "totalpagosTarjeta"
        Me.totalpagosTarjeta.Size = New System.Drawing.Size(19, 19)
        Me.totalpagosTarjeta.TabIndex = 55
        Me.totalpagosTarjeta.Text = "$"
        '
        'lblPagosTarjetas
        '
        Me.lblPagosTarjetas.AutoSize = True
        Me.lblPagosTarjetas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagosTarjetas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblPagosTarjetas.Location = New System.Drawing.Point(744, 434)
        Me.lblPagosTarjetas.Name = "lblPagosTarjetas"
        Me.lblPagosTarjetas.Size = New System.Drawing.Size(173, 19)
        Me.lblPagosTarjetas.TabIndex = 54
        Me.lblPagosTarjetas.Text = "Total pagos tarjeta:"
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(1315, 510)
        Me.Controls.Add(Me.totalpagosTarjeta)
        Me.Controls.Add(Me.lblPagosTarjetas)
        Me.Controls.Add(Me.lblTotalPagoAnticipado)
        Me.Controls.Add(Me.lblPagoAnticipado)
        Me.Controls.Add(Me.totalProx)
        Me.Controls.Add(Me.totalQuincena)
        Me.Controls.Add(Me.totalDia)
        Me.Controls.Add(Me.lblproximaquincena)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblSinRegistros)
        Me.Controls.Add(Me.lblTotalQuincena)
        Me.Controls.Add(Me.lblTotalDia)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblReporte)
        Me.Controls.Add(Me.dgvReporte)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Diario"
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
    Friend WithEvents lblSinRegistros As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblproximaquincena As System.Windows.Forms.Label
    Friend WithEvents totalDia As System.Windows.Forms.Label
    Friend WithEvents totalQuincena As System.Windows.Forms.Label
    Friend WithEvents totalProx As System.Windows.Forms.Label
    Friend WithEvents lblTotalPagoAnticipado As System.Windows.Forms.Label
    Friend WithEvents lblPagoAnticipado As System.Windows.Forms.Label
    Friend WithEvents totalpagosTarjeta As System.Windows.Forms.Label
    Friend WithEvents lblPagosTarjetas As System.Windows.Forms.Label
End Class
