<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retiro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.transaccionCb = New System.Windows.Forms.ComboBox()
        Me.clienteCb = New System.Windows.Forms.ComboBox()
        Me.cuentaCb = New System.Windows.Forms.ComboBox()
        Me.montoTxt = New System.Windows.Forms.TextBox()
        Me.conceptoTxt = New System.Windows.Forms.RichTextBox()
        Me.realizarTransaccionBtn = New System.Windows.Forms.Button()
        Me.cancelarBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cancelarBtn)
        Me.GroupBox1.Controls.Add(Me.realizarTransaccionBtn)
        Me.GroupBox1.Controls.Add(Me.conceptoTxt)
        Me.GroupBox1.Controls.Add(Me.montoTxt)
        Me.GroupBox1.Controls.Add(Me.cuentaCb)
        Me.GroupBox1.Controls.Add(Me.clienteCb)
        Me.GroupBox1.Controls.Add(Me.transaccionCb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la transaccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Monto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Transaccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Concepto"
        '
        'transaccionCb
        '
        Me.transaccionCb.FormattingEnabled = True
        Me.transaccionCb.Location = New System.Drawing.Point(131, 30)
        Me.transaccionCb.Name = "transaccionCb"
        Me.transaccionCb.Size = New System.Drawing.Size(197, 24)
        Me.transaccionCb.TabIndex = 9
        '
        'clienteCb
        '
        Me.clienteCb.FormattingEnabled = True
        Me.clienteCb.Location = New System.Drawing.Point(131, 81)
        Me.clienteCb.Name = "clienteCb"
        Me.clienteCb.Size = New System.Drawing.Size(197, 24)
        Me.clienteCb.TabIndex = 10
        '
        'cuentaCb
        '
        Me.cuentaCb.FormattingEnabled = True
        Me.cuentaCb.Location = New System.Drawing.Point(423, 30)
        Me.cuentaCb.Name = "cuentaCb"
        Me.cuentaCb.Size = New System.Drawing.Size(173, 24)
        Me.cuentaCb.TabIndex = 11
        '
        'montoTxt
        '
        Me.montoTxt.Location = New System.Drawing.Point(423, 78)
        Me.montoTxt.Name = "montoTxt"
        Me.montoTxt.Size = New System.Drawing.Size(173, 22)
        Me.montoTxt.TabIndex = 12
        '
        'conceptoTxt
        '
        Me.conceptoTxt.Location = New System.Drawing.Point(131, 124)
        Me.conceptoTxt.Name = "conceptoTxt"
        Me.conceptoTxt.Size = New System.Drawing.Size(197, 96)
        Me.conceptoTxt.TabIndex = 13
        Me.conceptoTxt.Text = ""
        '
        'realizarTransaccionBtn
        '
        Me.realizarTransaccionBtn.Location = New System.Drawing.Point(375, 124)
        Me.realizarTransaccionBtn.Name = "realizarTransaccionBtn"
        Me.realizarTransaccionBtn.Size = New System.Drawing.Size(221, 41)
        Me.realizarTransaccionBtn.TabIndex = 14
        Me.realizarTransaccionBtn.Text = "Realizar Transaccion"
        Me.realizarTransaccionBtn.UseVisualStyleBackColor = True
        '
        'cancelarBtn
        '
        Me.cancelarBtn.Location = New System.Drawing.Point(375, 179)
        Me.cancelarBtn.Name = "cancelarBtn"
        Me.cancelarBtn.Size = New System.Drawing.Size(221, 41)
        Me.cancelarBtn.TabIndex = 15
        Me.cancelarBtn.Text = "Cancelar"
        Me.cancelarBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LimpiarCamposToolStripMenuItem
        '
        Me.LimpiarCamposToolStripMenuItem.Name = "LimpiarCamposToolStripMenuItem"
        Me.LimpiarCamposToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.LimpiarCamposToolStripMenuItem.Text = "Limpiar campos"
        '
        'Retiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 293)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Retiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cancelarBtn As Button
    Friend WithEvents realizarTransaccionBtn As Button
    Friend WithEvents conceptoTxt As RichTextBox
    Friend WithEvents montoTxt As TextBox
    Friend WithEvents cuentaCb As ComboBox
    Friend WithEvents clienteCb As ComboBox
    Friend WithEvents transaccionCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
End Class
