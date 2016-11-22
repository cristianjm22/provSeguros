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
        Me.dgvReporte = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte.Location = New System.Drawing.Point(58, 142)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.ReadOnly = True
        Me.dgvReporte.ShowEditingIcon = False
        Me.dgvReporte.ShowRowErrors = False
        Me.dgvReporte.Size = New System.Drawing.Size(1165, 286)
        Me.dgvReporte.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(69, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Reporte diario"
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.logotipo
        Me.pbLogo.Location = New System.Drawing.Point(1100, 36)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(105, 100)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 29
        Me.pbLogo.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.DimGray
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Location = New System.Drawing.Point(1100, 307)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 36)
        Me.btnVolver.TabIndex = 30
        Me.btnVolver.Text = "Menu Principal"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 362)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.dgvReporte)
        Me.Name = "frmReporte"
        Me.Text = "Reporte diario"
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvReporte As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
