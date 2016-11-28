<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte2
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
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
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
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(30, 66)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 34
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(190, 66)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 33
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(19, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Reporte diario"
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
        Me.dgvReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_COMPROBANTE, Me.E_LAPIZ_OPTICO, Me.FECHA_INGRESO, Me.RM, Me.POLIZA, Me.ENDOSO, Me.NRO_CUOTA, Me.FECHA_VTO, Me.ID_MONEDA, Me.MONEDA, Me.IMPORTE, Me.ID_ESTADO, Me.ESTADO, Me.ELIMINAR})
        Me.dgvReporte.Location = New System.Drawing.Point(9, 112)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.ReadOnly = True
        Me.dgvReporte.ShowEditingIcon = False
        Me.dgvReporte.ShowRowErrors = False
        Me.dgvReporte.Size = New System.Drawing.Size(1025, 199)
        Me.dgvReporte.TabIndex = 31
        '
        'ID_COMPROBANTE
        '
        Me.ID_COMPROBANTE.HeaderText = "ID_COMPROBANTE"
        Me.ID_COMPROBANTE.Name = "ID_COMPROBANTE"
        Me.ID_COMPROBANTE.ReadOnly = True
        Me.ID_COMPROBANTE.Visible = False
        Me.ID_COMPROBANTE.Width = 132
        '
        'E_LAPIZ_OPTICO
        '
        Me.E_LAPIZ_OPTICO.HeaderText = "ENTRADA"
        Me.E_LAPIZ_OPTICO.Name = "E_LAPIZ_OPTICO"
        Me.E_LAPIZ_OPTICO.ReadOnly = True
        Me.E_LAPIZ_OPTICO.Width = 84
        '
        'FECHA_INGRESO
        '
        Me.FECHA_INGRESO.HeaderText = "FECHA DE INGRESO"
        Me.FECHA_INGRESO.Name = "FECHA_INGRESO"
        Me.FECHA_INGRESO.ReadOnly = True
        Me.FECHA_INGRESO.Width = 125
        '
        'RM
        '
        Me.RM.HeaderText = "RM"
        Me.RM.Name = "RM"
        Me.RM.ReadOnly = True
        Me.RM.Width = 49
        '
        'POLIZA
        '
        Me.POLIZA.HeaderText = "POLIZA"
        Me.POLIZA.Name = "POLIZA"
        Me.POLIZA.ReadOnly = True
        Me.POLIZA.Width = 70
        '
        'ENDOSO
        '
        Me.ENDOSO.HeaderText = "ENDOSO"
        Me.ENDOSO.Name = "ENDOSO"
        Me.ENDOSO.ReadOnly = True
        Me.ENDOSO.Width = 78
        '
        'NRO_CUOTA
        '
        Me.NRO_CUOTA.HeaderText = "CUOTA"
        Me.NRO_CUOTA.Name = "NRO_CUOTA"
        Me.NRO_CUOTA.ReadOnly = True
        Me.NRO_CUOTA.Width = 69
        '
        'FECHA_VTO
        '
        Me.FECHA_VTO.HeaderText = "FECHA VENCIMIENTO"
        Me.FECHA_VTO.Name = "FECHA_VTO"
        Me.FECHA_VTO.ReadOnly = True
        Me.FECHA_VTO.Width = 132
        '
        'ID_MONEDA
        '
        Me.ID_MONEDA.HeaderText = "ID_MONEDA"
        Me.ID_MONEDA.Name = "ID_MONEDA"
        Me.ID_MONEDA.ReadOnly = True
        Me.ID_MONEDA.Visible = False
        Me.ID_MONEDA.Width = 96
        '
        'MONEDA
        '
        Me.MONEDA.HeaderText = "MONEDA"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        Me.MONEDA.Width = 79
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "IMPORTE"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        Me.IMPORTE.Width = 81
        '
        'ID_ESTADO
        '
        Me.ID_ESTADO.HeaderText = "ID_ESTADO"
        Me.ID_ESTADO.Name = "ID_ESTADO"
        Me.ID_ESTADO.ReadOnly = True
        Me.ID_ESTADO.Visible = False
        Me.ID_ESTADO.Width = 93
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 76
        '
        'ELIMINAR
        '
        Me.ELIMINAR.HeaderText = "ELIMINAR"
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.ReadOnly = True
        Me.ELIMINAR.Width = 64
        '
        'frmReporte2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 449)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvReporte)
        Me.Name = "frmReporte2"
        Me.Text = "frmReporte2"
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvReporte As System.Windows.Forms.DataGridView
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
End Class
