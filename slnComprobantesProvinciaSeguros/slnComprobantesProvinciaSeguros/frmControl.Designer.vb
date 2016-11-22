<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControl))
        Me.btnComprobantes = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.txtRM = New System.Windows.Forms.TextBox()
        Me.lblRM = New System.Windows.Forms.Label()
        Me.lblPoliza = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEndoso = New System.Windows.Forms.TextBox()
        Me.lblNroCuota = New System.Windows.Forms.Label()
        Me.txtNroCuota = New System.Windows.Forms.TextBox()
        Me.lblFechaVto = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbPagos = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnModComprobantes = New System.Windows.Forms.Button()
        Me.Permisos = New System.Windows.Forms.Button()
        Me.btnDetalleComprobantes = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComprobantes
        '
        Me.btnComprobantes.BackColor = System.Drawing.Color.DimGray
        Me.btnComprobantes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprobantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobantes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnComprobantes.Location = New System.Drawing.Point(200, 410)
        Me.btnComprobantes.Name = "btnComprobantes"
        Me.btnComprobantes.Size = New System.Drawing.Size(125, 36)
        Me.btnComprobantes.TabIndex = 3
        Me.btnComprobantes.Text = "Ver Comprobantes"
        Me.btnComprobantes.UseVisualStyleBackColor = False
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.DimGray
        Me.btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPagar.Location = New System.Drawing.Point(345, 410)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(95, 36)
        Me.btnPagar.TabIndex = 2
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(24, 158)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(404, 20)
        Me.txtEntrada.TabIndex = 4
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(24, 139)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(44, 13)
        Me.lblEntrada.TabIndex = 5
        Me.lblEntrada.Text = "Entrada"
        '
        'txtRM
        '
        Me.txtRM.Enabled = False
        Me.txtRM.Location = New System.Drawing.Point(24, 203)
        Me.txtRM.Name = "txtRM"
        Me.txtRM.Size = New System.Drawing.Size(44, 20)
        Me.txtRM.TabIndex = 6
        '
        'lblRM
        '
        Me.lblRM.AutoSize = True
        Me.lblRM.Location = New System.Drawing.Point(24, 187)
        Me.lblRM.Name = "lblRM"
        Me.lblRM.Size = New System.Drawing.Size(24, 13)
        Me.lblRM.TabIndex = 7
        Me.lblRM.Text = "RM"
        '
        'lblPoliza
        '
        Me.lblPoliza.AutoSize = True
        Me.lblPoliza.Location = New System.Drawing.Point(197, 234)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(35, 13)
        Me.lblPoliza.TabIndex = 9
        Me.lblPoliza.Text = "Poliza"
        '
        'txtPoliza
        '
        Me.txtPoliza.Enabled = False
        Me.txtPoliza.Location = New System.Drawing.Point(198, 250)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Endoso"
        '
        'txtEndoso
        '
        Me.txtEndoso.Enabled = False
        Me.txtEndoso.Location = New System.Drawing.Point(24, 250)
        Me.txtEndoso.Name = "txtEndoso"
        Me.txtEndoso.Size = New System.Drawing.Size(100, 20)
        Me.txtEndoso.TabIndex = 10
        '
        'lblNroCuota
        '
        Me.lblNroCuota.AutoSize = True
        Me.lblNroCuota.Location = New System.Drawing.Point(197, 283)
        Me.lblNroCuota.Name = "lblNroCuota"
        Me.lblNroCuota.Size = New System.Drawing.Size(75, 13)
        Me.lblNroCuota.TabIndex = 13
        Me.lblNroCuota.Text = "Numero Cuota"
        '
        'txtNroCuota
        '
        Me.txtNroCuota.Enabled = False
        Me.txtNroCuota.Location = New System.Drawing.Point(198, 299)
        Me.txtNroCuota.Name = "txtNroCuota"
        Me.txtNroCuota.Size = New System.Drawing.Size(100, 20)
        Me.txtNroCuota.TabIndex = 12
        '
        'lblFechaVto
        '
        Me.lblFechaVto.AutoSize = True
        Me.lblFechaVto.Location = New System.Drawing.Point(21, 283)
        Me.lblFechaVto.Name = "lblFechaVto"
        Me.lblFechaVto.Size = New System.Drawing.Size(98, 13)
        Me.lblFechaVto.TabIndex = 15
        Me.lblFechaVto.Text = "Fecha Vencimiento"
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(195, 336)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(46, 13)
        Me.lblMoneda.TabIndex = 17
        Me.lblMoneda.Text = "Moneda"
        '
        'txtMoneda
        '
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(198, 352)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtMoneda.TabIndex = 16
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(19, 336)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 19
        Me.lblImporte.Text = "Importe"
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(22, 352)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(198, 203)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(228, 20)
        Me.txtObservaciones.TabIndex = 20
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(22, 299)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaVencimiento.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Entrada de pagos"
        '
        'gbPagos
        '
        Me.gbPagos.Location = New System.Drawing.Point(13, 117)
        Me.gbPagos.Name = "gbPagos"
        Me.gbPagos.Size = New System.Drawing.Size(430, 276)
        Me.gbPagos.TabIndex = 26
        Me.gbPagos.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(646, 492)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 14
        Me.LineShape3.X2 = 439
        Me.LineShape3.Y1 = 106
        Me.LineShape3.Y2 = 106
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 16
        Me.LineShape2.X2 = 441
        Me.LineShape2.Y1 = 246
        Me.LineShape2.Y2 = 246
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 14
        Me.LineShape1.X2 = 439
        Me.LineShape1.Y1 = 99
        Me.LineShape1.Y2 = 99
        '
        'btnModComprobantes
        '
        Me.btnModComprobantes.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.kedit
        Me.btnModComprobantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModComprobantes.Location = New System.Drawing.Point(487, 297)
        Me.btnModComprobantes.Name = "btnModComprobantes"
        Me.btnModComprobantes.Size = New System.Drawing.Size(90, 68)
        Me.btnModComprobantes.TabIndex = 33
        Me.btnModComprobantes.Text = "Modificar Comprobantes"
        Me.btnModComprobantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModComprobantes.UseVisualStyleBackColor = True
        '
        'Permisos
        '
        Me.Permisos.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.edit_group
        Me.Permisos.Location = New System.Drawing.Point(487, 117)
        Me.Permisos.Name = "Permisos"
        Me.Permisos.Size = New System.Drawing.Size(89, 68)
        Me.Permisos.TabIndex = 32
        Me.Permisos.Text = "Permisos"
        Me.Permisos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Permisos.UseVisualStyleBackColor = True
        '
        'btnDetalleComprobantes
        '
        Me.btnDetalleComprobantes.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.kdvi
        Me.btnDetalleComprobantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDetalleComprobantes.Location = New System.Drawing.Point(487, 209)
        Me.btnDetalleComprobantes.Name = "btnDetalleComprobantes"
        Me.btnDetalleComprobantes.Size = New System.Drawing.Size(90, 68)
        Me.btnDetalleComprobantes.TabIndex = 31
        Me.btnDetalleComprobantes.Text = "Detalle Comprobantes"
        Me.btnDetalleComprobantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDetalleComprobantes.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.lassists
        Me.btnPagos.Location = New System.Drawing.Point(486, 31)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(90, 68)
        Me.btnPagos.TabIndex = 30
        Me.btnPagos.Text = "Cobrar"
        Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.fileprint
        Me.Button1.Location = New System.Drawing.Point(486, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 68)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.logotipo
        Me.pbLogo.Location = New System.Drawing.Point(335, 3)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(105, 100)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 27
        Me.pbLogo.TabStop = False
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(646, 492)
        Me.Controls.Add(Me.btnModComprobantes)
        Me.Controls.Add(Me.Permisos)
        Me.Controls.Add(Me.btnDetalleComprobantes)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaVencimiento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.txtMoneda)
        Me.Controls.Add(Me.lblFechaVto)
        Me.Controls.Add(Me.lblNroCuota)
        Me.Controls.Add(Me.txtNroCuota)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEndoso)
        Me.Controls.Add(Me.lblPoliza)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.lblRM)
        Me.Controls.Add(Me.txtRM)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.btnComprobantes)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.gbPagos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmControl"
        Me.Text = "Formulario"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComprobantes As System.Windows.Forms.Button
    Friend WithEvents txtEntrada As System.Windows.Forms.TextBox
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents txtRM As System.Windows.Forms.TextBox
    Friend WithEvents lblRM As System.Windows.Forms.Label
    Friend WithEvents lblPoliza As System.Windows.Forms.Label
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEndoso As System.Windows.Forms.TextBox
    Friend WithEvents lblNroCuota As System.Windows.Forms.Label
    Friend WithEvents txtNroCuota As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaVto As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbPagos As System.Windows.Forms.GroupBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnModComprobantes As System.Windows.Forms.Button
    Friend WithEvents Permisos As System.Windows.Forms.Button
    Friend WithEvents btnDetalleComprobantes As System.Windows.Forms.Button
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
