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
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnPermisos = New System.Windows.Forms.Button()
        Me.btnModificarPagos = New System.Windows.Forms.Button()
        Me.BtnReimpresion = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeuda = New System.Windows.Forms.TextBox()
        Me.btnDeudas = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnInformarPagos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEntrada
        '
        resources.ApplyResources(Me.txtEntrada, "txtEntrada")
        Me.txtEntrada.Name = "txtEntrada"
        '
        'lblEntrada
        '
        resources.ApplyResources(Me.lblEntrada, "lblEntrada")
        Me.lblEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEntrada.Name = "lblEntrada"
        '
        'txtRM
        '
        resources.ApplyResources(Me.txtRM, "txtRM")
        Me.txtRM.Name = "txtRM"
        '
        'lblRM
        '
        resources.ApplyResources(Me.lblRM, "lblRM")
        Me.lblRM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRM.Name = "lblRM"
        '
        'lblPoliza
        '
        resources.ApplyResources(Me.lblPoliza, "lblPoliza")
        Me.lblPoliza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPoliza.Name = "lblPoliza"
        '
        'txtPoliza
        '
        resources.ApplyResources(Me.txtPoliza, "txtPoliza")
        Me.txtPoliza.Name = "txtPoliza"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'txtEndoso
        '
        resources.ApplyResources(Me.txtEndoso, "txtEndoso")
        Me.txtEndoso.Name = "txtEndoso"
        '
        'lblNroCuota
        '
        resources.ApplyResources(Me.lblNroCuota, "lblNroCuota")
        Me.lblNroCuota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNroCuota.Name = "lblNroCuota"
        '
        'txtNroCuota
        '
        resources.ApplyResources(Me.txtNroCuota, "txtNroCuota")
        Me.txtNroCuota.Name = "txtNroCuota"
        '
        'lblFechaVto
        '
        resources.ApplyResources(Me.lblFechaVto, "lblFechaVto")
        Me.lblFechaVto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFechaVto.Name = "lblFechaVto"
        '
        'lblMoneda
        '
        resources.ApplyResources(Me.lblMoneda, "lblMoneda")
        Me.lblMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMoneda.Name = "lblMoneda"
        '
        'txtMoneda
        '
        resources.ApplyResources(Me.txtMoneda, "txtMoneda")
        Me.txtMoneda.Name = "txtMoneda"
        '
        'lblImporte
        '
        resources.ApplyResources(Me.lblImporte, "lblImporte")
        Me.lblImporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblImporte.Name = "lblImporte"
        '
        'txtImporte
        '
        resources.ApplyResources(Me.txtImporte, "txtImporte")
        Me.txtImporte.Name = "txtImporte"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Name = "Label2"
        '
        'txtObservaciones
        '
        resources.ApplyResources(Me.txtObservaciones, "txtObservaciones")
        Me.txtObservaciones.Name = "txtObservaciones"
        '
        'dtpFechaVencimiento
        '
        resources.ApplyResources(Me.dtpFechaVencimiento, "dtpFechaVencimiento")
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'RectangleShape1
        '
        resources.ApplyResources(Me.RectangleShape1, "RectangleShape1")
        Me.RectangleShape1.Name = "RectangleShape1"
        '
        'ShapeContainer1
        '
        resources.ApplyResources(Me.ShapeContainer1, "ShapeContainer1")
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.Sin
        resources.ApplyResources(Me.RectangleShape3, "RectangleShape3")
        Me.RectangleShape3.Name = "RectangleShape3"
        '
        'btnPermisos
        '
        Me.btnPermisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        resources.ApplyResources(Me.btnPermisos, "btnPermisos")
        Me.btnPermisos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.TabStop = False
        Me.btnPermisos.UseVisualStyleBackColor = False
        '
        'btnModificarPagos
        '
        Me.btnModificarPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        resources.ApplyResources(Me.btnModificarPagos, "btnModificarPagos")
        Me.btnModificarPagos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnModificarPagos.Name = "btnModificarPagos"
        Me.btnModificarPagos.TabStop = False
        Me.btnModificarPagos.UseVisualStyleBackColor = False
        '
        'BtnReimpresion
        '
        Me.BtnReimpresion.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        resources.ApplyResources(Me.BtnReimpresion, "BtnReimpresion")
        Me.BtnReimpresion.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnReimpresion.Name = "BtnReimpresion"
        Me.BtnReimpresion.TabStop = False
        Me.BtnReimpresion.UseVisualStyleBackColor = False
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        resources.ApplyResources(Me.btnReporte, "btnReporte")
        Me.btnReporte.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.TabStop = False
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'txtDeuda
        '
        resources.ApplyResources(Me.txtDeuda, "txtDeuda")
        Me.txtDeuda.Name = "txtDeuda"
        '
        'btnDeudas
        '
        Me.btnDeudas.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        resources.ApplyResources(Me.btnDeudas, "btnDeudas")
        Me.btnDeudas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeudas.Name = "btnDeudas"
        Me.btnDeudas.TabStop = False
        Me.btnDeudas.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnLimpiar, "btnLimpiar")
        Me.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnLimpiar.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.cancelar
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnGuardar.Image = Global.slnComprobantesProvinciaSeguros.My.Resources.Resources.aceptar
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnInformarPagos
        '
        Me.btnInformarPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(131, Byte), Integer))
        resources.ApplyResources(Me.btnInformarPagos, "btnInformarPagos")
        Me.btnInformarPagos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInformarPagos.Name = "btnInformarPagos"
        Me.btnInformarPagos.TabStop = False
        Me.btnInformarPagos.UseVisualStyleBackColor = False
        '
        'frmControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.btnInformarPagos)
        Me.Controls.Add(Me.btnDeudas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDeuda)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.BtnReimpresion)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnModificarPagos)
        Me.Controls.Add(Me.btnPermisos)
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
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btnPermisos As System.Windows.Forms.Button
    Friend WithEvents btnModificarPagos As System.Windows.Forms.Button
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents BtnReimpresion As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeuda As System.Windows.Forms.TextBox
    Friend WithEvents btnDeudas As System.Windows.Forms.Button
    Friend WithEvents btnInformarPagos As System.Windows.Forms.Button

End Class
