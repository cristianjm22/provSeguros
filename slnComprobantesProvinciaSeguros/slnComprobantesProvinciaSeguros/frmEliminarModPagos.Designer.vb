﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarModPagos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminarModPagos))
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.dgvReporte = New System.Windows.Forms.DataGridView()
        Me.ID_COMPROBANTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_LAPIZ_OPTICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POLIZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENDOSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_VTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ELIMINAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblPoliza = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSinRegistros = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(91, 169)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 1
        '
        'dgvReporte
        '
        Me.dgvReporte.AllowUserToAddRows = False
        Me.dgvReporte.AllowUserToDeleteRows = False
        Me.dgvReporte.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_COMPROBANTE, Me.E_LAPIZ_OPTICO, Me.FECHA_INGRESO, Me.RM, Me.POLIZA, Me.ENDOSO, Me.NRO_CUOTA, Me.FECHA_VTO, Me.ID_MONEDA, Me.MONEDA, Me.IMPORTE, Me.ID_ESTADO, Me.ESTADO, Me.ELIMINAR})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReporte.EnableHeadersVisualStyles = False
        Me.dgvReporte.Location = New System.Drawing.Point(44, 208)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReporte.RowHeadersWidth = 21
        Me.dgvReporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReporte.ShowEditingIcon = False
        Me.dgvReporte.ShowRowErrors = False
        Me.dgvReporte.Size = New System.Drawing.Size(1261, 152)
        Me.dgvReporte.TabIndex = 31
        '
        'ID_COMPROBANTE
        '
        Me.ID_COMPROBANTE.HeaderText = "COMPROBANTE"
        Me.ID_COMPROBANTE.Name = "ID_COMPROBANTE"
        Me.ID_COMPROBANTE.ReadOnly = True
        Me.ID_COMPROBANTE.Width = 107
        '
        'E_LAPIZ_OPTICO
        '
        Me.E_LAPIZ_OPTICO.HeaderText = "ENTRADA (LAPIZ OPTICO)"
        Me.E_LAPIZ_OPTICO.Name = "E_LAPIZ_OPTICO"
        Me.E_LAPIZ_OPTICO.ReadOnly = True
        Me.E_LAPIZ_OPTICO.Width = 159
        '
        'FECHA_INGRESO
        '
        Me.FECHA_INGRESO.HeaderText = "FECHA DE INGRESO"
        Me.FECHA_INGRESO.Name = "FECHA_INGRESO"
        Me.FECHA_INGRESO.ReadOnly = True
        Me.FECHA_INGRESO.Width = 128
        '
        'RM
        '
        Me.RM.HeaderText = "RAMO"
        Me.RM.Name = "RM"
        Me.RM.ReadOnly = True
        Me.RM.Width = 61
        '
        'POLIZA
        '
        Me.POLIZA.HeaderText = "POLIZA"
        Me.POLIZA.Name = "POLIZA"
        Me.POLIZA.ReadOnly = True
        Me.POLIZA.Width = 67
        '
        'ENDOSO
        '
        Me.ENDOSO.HeaderText = "ENDOSO"
        Me.ENDOSO.Name = "ENDOSO"
        Me.ENDOSO.ReadOnly = True
        Me.ENDOSO.Width = 73
        '
        'NRO_CUOTA
        '
        Me.NRO_CUOTA.HeaderText = "CUOTA"
        Me.NRO_CUOTA.Name = "NRO_CUOTA"
        Me.NRO_CUOTA.ReadOnly = True
        Me.NRO_CUOTA.Width = 66
        '
        'FECHA_VTO
        '
        Me.FECHA_VTO.HeaderText = "FECHA DE VENCIMIENTO"
        Me.FECHA_VTO.Name = "FECHA_VTO"
        Me.FECHA_VTO.ReadOnly = True
        Me.FECHA_VTO.Width = 152
        '
        'ID_MONEDA
        '
        Me.ID_MONEDA.HeaderText = "MONEDA"
        Me.ID_MONEDA.Name = "ID_MONEDA"
        Me.ID_MONEDA.ReadOnly = True
        Me.ID_MONEDA.Visible = False
        Me.ID_MONEDA.Width = 74
        '
        'MONEDA
        '
        Me.MONEDA.HeaderText = "MONEDA"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        Me.MONEDA.Width = 74
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        Me.IMPORTE.Width = 76
        '
        'ID_ESTADO
        '
        Me.ID_ESTADO.HeaderText = "ID_ESTADO"
        Me.ID_ESTADO.Name = "ID_ESTADO"
        Me.ID_ESTADO.ReadOnly = True
        Me.ID_ESTADO.Visible = False
        Me.ID_ESTADO.Width = 88
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 71
        '
        'ELIMINAR
        '
        Me.ELIMINAR.HeaderText = "ELIMINAR"
        Me.ELIMINAR.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.remove
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.ReadOnly = True
        Me.ELIMINAR.Width = 60
        '
        'lblPoliza
        '
        Me.lblPoliza.AutoSize = True
        Me.lblPoliza.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoliza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPoliza.Location = New System.Drawing.Point(276, 174)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(36, 14)
        Me.lblPoliza.TabIndex = 37
        Me.lblPoliza.Text = "Poliza"
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(318, 170)
        Me.txtPoliza.MaxLength = 15
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 2
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(41, 174)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(44, 14)
        Me.lblEstado.TabIndex = 39
        Me.lblEstado.Text = "Estado"
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
        Me.RectangleShape1.Size = New System.Drawing.Size(1303, 97)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1287, 466)
        Me.ShapeContainer1.TabIndex = 40
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        Me.RectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Location = New System.Drawing.Point(1102, -5)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(176, 103)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(40, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Detalle de Pagos"
        '
        'lblSinRegistros
        '
        Me.lblSinRegistros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSinRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSinRegistros.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinRegistros.Location = New System.Drawing.Point(44, 208)
        Me.lblSinRegistros.Name = "lblSinRegistros"
        Me.lblSinRegistros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSinRegistros.Size = New System.Drawing.Size(1207, 26)
        Me.lblSinRegistros.TabIndex = 42
        Me.lblSinRegistros.Text = "No se encontraron registros"
        Me.lblSinRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnCerrar.Location = New System.Drawing.Point(44, 412)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 29)
        Me.btnCerrar.TabIndex = 47
        Me.btnCerrar.Text = "Volver"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.appbar_filter
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(424, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 22)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.appbar_filter
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(218, 168)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 22)
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
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
        Me.btnExport.Location = New System.Drawing.Point(1126, 412)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(125, 29)
        Me.btnExport.TabIndex = 50
        Me.btnExport.Text = "Exportar"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.total.Location = New System.Drawing.Point(826, 422)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(19, 19)
        Me.total.TabIndex = 54
        Me.total.Text = "$"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(757, 422)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 19)
        Me.lblTotal.TabIndex = 52
        Me.lblTotal.Text = "Total :"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(529, 170)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(110, 20)
        Me.dtpFechaDesde.TabIndex = 55
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(710, 170)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(110, 20)
        Me.dtpFechaHasta.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(478, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 14)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(659, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Hasta"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.appbar_filter
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(826, 168)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 22)
        Me.PictureBox3.TabIndex = 59
        Me.PictureBox3.TabStop = False
        '
        'frmEliminarModPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(1287, 466)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblSinRegistros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.lblPoliza)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.dgvReporte)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEliminarModPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Pagos"
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents dgvReporte As System.Windows.Forms.DataGridView
    Friend WithEvents lblPoliza As System.Windows.Forms.Label
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblSinRegistros As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ID_COMPROBANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E_LAPIZ_OPTICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_INGRESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POLIZA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENDOSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_CUOTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_VTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ELIMINAR As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
