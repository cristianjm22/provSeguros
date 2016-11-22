<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcBar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcBar))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Top_Lbl = New System.Windows.Forms.Label
        Me.HiloBackgroundWorker = New System.ComponentModel.BackgroundWorker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(370, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'Top_Lbl
        '
        Me.Top_Lbl.AutoSize = True
        Me.Top_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Top_Lbl.Location = New System.Drawing.Point(16, 47)
        Me.Top_Lbl.Name = "Top_Lbl"
        Me.Top_Lbl.Size = New System.Drawing.Size(0, 16)
        Me.Top_Lbl.TabIndex = 2
        Me.Top_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HiloBackgroundWorker
        '
        Me.HiloBackgroundWorker.WorkerReportsProgress = True
        Me.HiloBackgroundWorker.WorkerSupportsCancellation = True
        '
        'ProcBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 70)
        Me.ControlBox = False
        Me.Controls.Add(Me.Top_Lbl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcBar"
        Me.Text = "Progreso de Trabajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Top_Lbl As System.Windows.Forms.Label
    Friend WithEvents HiloBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
