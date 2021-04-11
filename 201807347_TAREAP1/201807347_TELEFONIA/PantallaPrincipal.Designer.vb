<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreClienteTxt = New System.Windows.Forms.TextBox()
        Me.nitTxt = New System.Windows.Forms.TextBox()
        Me.internetFields = New System.Windows.Forms.GroupBox()
        Me.internetChb = New System.Windows.Forms.CheckBox()
        Me.velocidad_128Rb = New System.Windows.Forms.RadioButton()
        Me.velocidad_256Rb = New System.Windows.Forms.RadioButton()
        Me.velocidad_512Rb = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cableChb = New System.Windows.Forms.CheckBox()
        Me.cableFields = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.canales_125Rb = New System.Windows.Forms.RadioButton()
        Me.canales_250Rb = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lineaChb = New System.Windows.Forms.CheckBox()
        Me.totalLbl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.detallelbl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.internetFields.SuspendLayout()
        Me.cableFields.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nitTxt)
        Me.GroupBox1.Controls.Add(Me.nombreClienteTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT "
        '
        'nombreClienteTxt
        '
        Me.nombreClienteTxt.Location = New System.Drawing.Point(161, 28)
        Me.nombreClienteTxt.Name = "nombreClienteTxt"
        Me.nombreClienteTxt.Size = New System.Drawing.Size(351, 22)
        Me.nombreClienteTxt.TabIndex = 2
        '
        'nitTxt
        '
        Me.nitTxt.Location = New System.Drawing.Point(161, 64)
        Me.nitTxt.Name = "nitTxt"
        Me.nitTxt.Size = New System.Drawing.Size(351, 22)
        Me.nitTxt.TabIndex = 3
        '
        'internetFields
        '
        Me.internetFields.Controls.Add(Me.Label3)
        Me.internetFields.Controls.Add(Me.velocidad_512Rb)
        Me.internetFields.Controls.Add(Me.velocidad_256Rb)
        Me.internetFields.Controls.Add(Me.velocidad_128Rb)
        Me.internetFields.Enabled = False
        Me.internetFields.Location = New System.Drawing.Point(12, 226)
        Me.internetFields.Name = "internetFields"
        Me.internetFields.Size = New System.Drawing.Size(562, 103)
        Me.internetFields.TabIndex = 2
        Me.internetFields.TabStop = False
        Me.internetFields.Text = "Internet"
        '
        'internetChb
        '
        Me.internetChb.AutoSize = True
        Me.internetChb.Location = New System.Drawing.Point(12, 199)
        Me.internetChb.Name = "internetChb"
        Me.internetChb.Size = New System.Drawing.Size(156, 21)
        Me.internetChb.TabIndex = 0
        Me.internetChb.Text = "Servicio de internet "
        Me.internetChb.UseVisualStyleBackColor = True
        '
        'velocidad_128Rb
        '
        Me.velocidad_128Rb.AutoSize = True
        Me.velocidad_128Rb.Location = New System.Drawing.Point(41, 64)
        Me.velocidad_128Rb.Name = "velocidad_128Rb"
        Me.velocidad_128Rb.Size = New System.Drawing.Size(53, 21)
        Me.velocidad_128Rb.TabIndex = 1
        Me.velocidad_128Rb.TabStop = True
        Me.velocidad_128Rb.Text = "128"
        Me.velocidad_128Rb.UseVisualStyleBackColor = True
        '
        'velocidad_256Rb
        '
        Me.velocidad_256Rb.AutoSize = True
        Me.velocidad_256Rb.Location = New System.Drawing.Point(234, 64)
        Me.velocidad_256Rb.Name = "velocidad_256Rb"
        Me.velocidad_256Rb.Size = New System.Drawing.Size(53, 21)
        Me.velocidad_256Rb.TabIndex = 2
        Me.velocidad_256Rb.TabStop = True
        Me.velocidad_256Rb.Text = "256"
        Me.velocidad_256Rb.UseVisualStyleBackColor = True
        '
        'velocidad_512Rb
        '
        Me.velocidad_512Rb.AutoSize = True
        Me.velocidad_512Rb.Location = New System.Drawing.Point(450, 64)
        Me.velocidad_512Rb.Name = "velocidad_512Rb"
        Me.velocidad_512Rb.Size = New System.Drawing.Size(53, 21)
        Me.velocidad_512Rb.TabIndex = 3
        Me.velocidad_512Rb.TabStop = True
        Me.velocidad_512Rb.Text = "512"
        Me.velocidad_512Rb.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seleccione la velocidad:"
        '
        'cableChb
        '
        Me.cableChb.AutoSize = True
        Me.cableChb.Location = New System.Drawing.Point(12, 362)
        Me.cableChb.Name = "cableChb"
        Me.cableChb.Size = New System.Drawing.Size(138, 21)
        Me.cableChb.TabIndex = 3
        Me.cableChb.Text = "Servicio de cable"
        Me.cableChb.UseVisualStyleBackColor = True
        '
        'cableFields
        '
        Me.cableFields.Controls.Add(Me.canales_250Rb)
        Me.cableFields.Controls.Add(Me.canales_125Rb)
        Me.cableFields.Controls.Add(Me.Label4)
        Me.cableFields.Enabled = False
        Me.cableFields.Location = New System.Drawing.Point(12, 389)
        Me.cableFields.Name = "cableFields"
        Me.cableFields.Size = New System.Drawing.Size(562, 118)
        Me.cableFields.TabIndex = 4
        Me.cableFields.TabStop = False
        Me.cableFields.Text = "Cable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Seleccione el numero de canales"
        '
        'canales_125Rb
        '
        Me.canales_125Rb.AutoSize = True
        Me.canales_125Rb.Location = New System.Drawing.Point(145, 73)
        Me.canales_125Rb.Name = "canales_125Rb"
        Me.canales_125Rb.Size = New System.Drawing.Size(53, 21)
        Me.canales_125Rb.TabIndex = 1
        Me.canales_125Rb.TabStop = True
        Me.canales_125Rb.Text = "125"
        Me.canales_125Rb.UseVisualStyleBackColor = True
        '
        'canales_250Rb
        '
        Me.canales_250Rb.AutoSize = True
        Me.canales_250Rb.Location = New System.Drawing.Point(365, 73)
        Me.canales_250Rb.Name = "canales_250Rb"
        Me.canales_250Rb.Size = New System.Drawing.Size(53, 21)
        Me.canales_250Rb.TabIndex = 2
        Me.canales_250Rb.TabStop = True
        Me.canales_250Rb.Text = "250"
        Me.canales_250Rb.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Calculo parcial por mes: "
        '
        'lineaChb
        '
        Me.lineaChb.AutoSize = True
        Me.lineaChb.Location = New System.Drawing.Point(12, 153)
        Me.lineaChb.Name = "lineaChb"
        Me.lineaChb.Size = New System.Drawing.Size(156, 21)
        Me.lineaChb.TabIndex = 7
        Me.lineaChb.Text = "Servicio de linea fija"
        Me.lineaChb.UseVisualStyleBackColor = True
        '
        'totalLbl
        '
        Me.totalLbl.AutoSize = True
        Me.totalLbl.Location = New System.Drawing.Point(412, 534)
        Me.totalLbl.Name = "totalLbl"
        Me.totalLbl.Size = New System.Drawing.Size(0, 17)
        Me.totalLbl.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.detallelbl)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(598, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 460)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Factura"
        '
        'detallelbl
        '
        Me.detallelbl.AutoSize = True
        Me.detallelbl.Location = New System.Drawing.Point(20, 82)
        Me.detallelbl.Name = "detallelbl"
        Me.detallelbl.Size = New System.Drawing.Size(0, 17)
        Me.detallelbl.TabIndex = 6
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 541)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.totalLbl)
        Me.Controls.Add(Me.lineaChb)
        Me.Controls.Add(Me.cableFields)
        Me.Controls.Add(Me.cableChb)
        Me.Controls.Add(Me.internetFields)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.internetChb)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PantallaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.internetFields.ResumeLayout(False)
        Me.internetFields.PerformLayout()
        Me.cableFields.ResumeLayout(False)
        Me.cableFields.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nitTxt As TextBox
    Friend WithEvents nombreClienteTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents internetFields As GroupBox
    Friend WithEvents velocidad_512Rb As RadioButton
    Friend WithEvents velocidad_256Rb As RadioButton
    Friend WithEvents velocidad_128Rb As RadioButton
    Friend WithEvents internetChb As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cableChb As CheckBox
    Friend WithEvents cableFields As GroupBox
    Friend WithEvents canales_250Rb As RadioButton
    Friend WithEvents canales_125Rb As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lineaChb As CheckBox
    Friend WithEvents totalLbl As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents detallelbl As Label
End Class
