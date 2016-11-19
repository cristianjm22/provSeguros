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
        Me.txtFechaVto = New System.Windows.Forms.TextBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnComprobantes
        '
        Me.btnComprobantes.Location = New System.Drawing.Point(180, 325)
        Me.btnComprobantes.Name = "btnComprobantes"
        Me.btnComprobantes.Size = New System.Drawing.Size(95, 36)
        Me.btnComprobantes.TabIndex = 3
        Me.btnComprobantes.Text = "Ver Comprobantes"
        Me.btnComprobantes.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(325, 325)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(95, 36)
        Me.btnPagar.TabIndex = 2
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(16, 57)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(404, 20)
        Me.txtEntrada.TabIndex = 4
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(13, 29)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(44, 13)
        Me.lblEntrada.TabIndex = 5
        Me.lblEntrada.Text = "Entrada"
        '
        'txtRM
        '
        Me.txtRM.Enabled = False
        Me.txtRM.Location = New System.Drawing.Point(73, 115)
        Me.txtRM.Name = "txtRM"
        Me.txtRM.Size = New System.Drawing.Size(100, 20)
        Me.txtRM.TabIndex = 6
        '
        'lblRM
        '
        Me.lblRM.AutoSize = True
        Me.lblRM.Location = New System.Drawing.Point(13, 115)
        Me.lblRM.Name = "lblRM"
        Me.lblRM.Size = New System.Drawing.Size(24, 13)
        Me.lblRM.TabIndex = 7
        Me.lblRM.Text = "RM"
        '
        'lblPoliza
        '
        Me.lblPoliza.AutoSize = True
        Me.lblPoliza.Location = New System.Drawing.Point(200, 115)
        Me.lblPoliza.Name = "lblPoliza"
        Me.lblPoliza.Size = New System.Drawing.Size(35, 13)
        Me.lblPoliza.TabIndex = 9
        Me.lblPoliza.Text = "Poliza"
        '
        'txtPoliza
        '
        Me.txtPoliza.Enabled = False
        Me.txtPoliza.Location = New System.Drawing.Point(306, 115)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Endoso"
        '
        'txtEndoso
        '
        Me.txtEndoso.Enabled = False
        Me.txtEndoso.Location = New System.Drawing.Point(73, 155)
        Me.txtEndoso.Name = "txtEndoso"
        Me.txtEndoso.Size = New System.Drawing.Size(100, 20)
        Me.txtEndoso.TabIndex = 10
        '
        'lblNroCuota
        '
        Me.lblNroCuota.AutoSize = True
        Me.lblNroCuota.Location = New System.Drawing.Point(200, 158)
        Me.lblNroCuota.Name = "lblNroCuota"
        Me.lblNroCuota.Size = New System.Drawing.Size(75, 13)
        Me.lblNroCuota.TabIndex = 13
        Me.lblNroCuota.Text = "Numero Cuota"
        '
        'txtNroCuota
        '
        Me.txtNroCuota.Enabled = False
        Me.txtNroCuota.Location = New System.Drawing.Point(306, 155)
        Me.txtNroCuota.Name = "txtNroCuota"
        Me.txtNroCuota.Size = New System.Drawing.Size(100, 20)
        Me.txtNroCuota.TabIndex = 12
        '
        'lblFechaVto
        '
        Me.lblFechaVto.AutoSize = True
        Me.lblFechaVto.Location = New System.Drawing.Point(13, 199)
        Me.lblFechaVto.Name = "lblFechaVto"
        Me.lblFechaVto.Size = New System.Drawing.Size(98, 13)
        Me.lblFechaVto.TabIndex = 15
        Me.lblFechaVto.Text = "Fecha Vencimiento"
        '
        'txtFechaVto
        '
        Me.txtFechaVto.Enabled = False
        Me.txtFechaVto.Location = New System.Drawing.Point(128, 199)
        Me.txtFechaVto.Name = "txtFechaVto"
        Me.txtFechaVto.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaVto.TabIndex = 14
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(246, 199)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(46, 13)
        Me.lblMoneda.TabIndex = 17
        Me.lblMoneda.Text = "Moneda"
        '
        'txtMoneda
        '
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(306, 199)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtMoneda.TabIndex = 16
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(13, 247)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 19
        Me.lblImporte.Text = "Importe"
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(73, 247)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(97, 280)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(309, 20)
        Me.txtObservaciones.TabIndex = 20
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 392)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.txtMoneda)
        Me.Controls.Add(Me.lblFechaVto)
        Me.Controls.Add(Me.txtFechaVto)
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
        Me.Name = "frmControl"
        Me.Text = "Formulario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComprobantes As System.Windows.Forms.Button
    Friend WithEvents btnPagar As System.Windows.Forms.Button
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
    Friend WithEvents txtFechaVto As System.Windows.Forms.TextBox
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox

End Class
