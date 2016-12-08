<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeudas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeudas))
        Me.lblDeudas = New System.Windows.Forms.Label()
        Me.dgvDeudas = New System.Windows.Forms.DataGridView()
        Me.ID_DEUDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE_DEUDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POLIZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_COMPROBANTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODIFICAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ELIMINAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.lblPoliza = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblSinRegistros = New System.Windows.Forms.Label()
        CType(Me.dgvDeudas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDeudas
        '
        Me.lblDeudas.AutoSize = True
        Me.lblDeudas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeudas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblDeudas.Location = New System.Drawing.Point(52, 154)
        Me.lblDeudas.Name = "lblDeudas"
        Me.lblDeudas.Size = New System.Drawing.Size(69, 19)
        Me.lblDeudas.TabIndex = 34
        Me.lblDeudas.Text = "Deudas"
        '
        'dgvDeudas
        '
        Me.dgvDeudas.AllowUserToAddRows = False
        Me.dgvDeudas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDeudas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDeudas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDeudas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDeudas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDeudas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDeudas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDeudas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDeudas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeudas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_DEUDA, Me.IMPORTE_DEUDA, Me.POLIZA, Me.NRO_CUOTA, Me.FECHA_INGRESO, Me.ID_COMPROBANTE, Me.MODIFICAR, Me.ELIMINAR})
        Me.dgvDeudas.EnableHeadersVisualStyles = False
        Me.dgvDeudas.Location = New System.Drawing.Point(56, 234)
        Me.dgvDeudas.MultiSelect = False
        Me.dgvDeudas.Name = "dgvDeudas"
        Me.dgvDeudas.ReadOnly = True
        Me.dgvDeudas.ShowEditingIcon = False
        Me.dgvDeudas.ShowRowErrors = False
        Me.dgvDeudas.Size = New System.Drawing.Size(874, 212)
        Me.dgvDeudas.TabIndex = 33
        '
        'ID_DEUDA
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ID_DEUDA.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID_DEUDA.HeaderText = "NUMERO DE DEUDA"
        Me.ID_DEUDA.Name = "ID_DEUDA"
        Me.ID_DEUDA.ReadOnly = True
        Me.ID_DEUDA.Width = 86
        '
        'IMPORTE_DEUDA
        '
        Me.IMPORTE_DEUDA.HeaderText = "IMPORTE DEUDA"
        Me.IMPORTE_DEUDA.Name = "IMPORTE_DEUDA"
        Me.IMPORTE_DEUDA.ReadOnly = True
        Me.IMPORTE_DEUDA.Width = 104
        '
        'POLIZA
        '
        Me.POLIZA.HeaderText = "POLIZA"
        Me.POLIZA.Name = "POLIZA"
        Me.POLIZA.ReadOnly = True
        Me.POLIZA.Width = 67
        '
        'NRO_CUOTA
        '
        Me.NRO_CUOTA.HeaderText = "NRO CUOTA"
        Me.NRO_CUOTA.Name = "NRO_CUOTA"
        Me.NRO_CUOTA.ReadOnly = True
        Me.NRO_CUOTA.Width = 84
        '
        'FECHA_INGRESO
        '
        Me.FECHA_INGRESO.HeaderText = "FECHA DEUDA"
        Me.FECHA_INGRESO.Name = "FECHA_INGRESO"
        Me.FECHA_INGRESO.ReadOnly = True
        Me.FECHA_INGRESO.Width = 93
        '
        'ID_COMPROBANTE
        '
        Me.ID_COMPROBANTE.HeaderText = "ID COMPROBANTE"
        Me.ID_COMPROBANTE.Name = "ID_COMPROBANTE"
        Me.ID_COMPROBANTE.ReadOnly = True
        Me.ID_COMPROBANTE.Width = 111
        '
        'MODIFICAR
        '
        Me.MODIFICAR.HeaderText = "MODIFICAR"
        Me.MODIFICAR.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.pencil
        Me.MODIFICAR.Name = "MODIFICAR"
        Me.MODIFICAR.ReadOnly = True
        Me.MODIFICAR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MODIFICAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MODIFICAR.Width = 89
        '
        'ELIMINAR
        '
        Me.ELIMINAR.HeaderText = "ELIMINAR"
        Me.ELIMINAR.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.cancelar
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.ReadOnly = True
        Me.ELIMINAR.Width = 60
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(94, 191)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 32
        '
        'lblPoliza
        '
        Me.lblPoliza.AutoSize = True
        Me.lblPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoliza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPoliza.Location = New System.Drawing.Point(53, 194)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(36, 14)
        Me.lblPoliza.TabIndex = 31
        Me.lblPoliza.Text = "Poliza"
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
        Me.RectangleShape1.Location = New System.Drawing.Point(-1, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(903, 94)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(903, 478)
        Me.ShapeContainer1.TabIndex = 41
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        Me.RectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Location = New System.Drawing.Point(707, -4)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(176, 103)
        '
        'lblSinRegistros
        '
        Me.lblSinRegistros.AutoSize = True
        Me.lblSinRegistros.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinRegistros.Location = New System.Drawing.Point(352, 271)
        Me.lblSinRegistros.Name = "lblSinRegistros"
        Me.lblSinRegistros.Size = New System.Drawing.Size(191, 16)
        Me.lblSinRegistros.TabIndex = 40
        Me.lblSinRegistros.Text = "No se encontraron registros"
        Me.lblSinRegistros.Visible = False
        '
        'frmDeudas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 478)
        Me.Controls.Add(Me.lblSinRegistros)
        Me.Controls.Add(Me.lblDeudas)
        Me.Controls.Add(Me.dgvDeudas)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.lblPoliza)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDeudas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deudas"
        CType(Me.dgvDeudas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDeudas As System.Windows.Forms.Label
    Friend WithEvents dgvDeudas As System.Windows.Forms.DataGridView
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents lblPoliza As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblSinRegistros As System.Windows.Forms.Label
    Friend WithEvents ID_DEUDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE_DEUDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POLIZA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_CUOTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_INGRESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_COMPROBANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODIFICAR As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ELIMINAR As System.Windows.Forms.DataGridViewImageColumn
End Class
