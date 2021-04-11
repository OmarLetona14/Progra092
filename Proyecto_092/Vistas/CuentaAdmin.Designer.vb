<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuentaAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CuentaAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numeroCuentaTxt = New System.Windows.Forms.TextBox()
        Me.saldoTxt = New System.Windows.Forms.TextBox()
        Me.descripcionTxt = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.noCuentaCb = New System.Windows.Forms.ComboBox()
        Me.editarBtn = New System.Windows.Forms.Button()
        Me.eliminarBtn = New System.Windows.Forms.Button()
        Me.agregarBtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LimpiarCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tipocuentaCb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clienteCb = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clienteCb)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tipocuentaCb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.agregarBtn)
        Me.GroupBox1.Controls.Add(Me.eliminarBtn)
        Me.GroupBox1.Controls.Add(Me.editarBtn)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.descripcionTxt)
        Me.GroupBox1.Controls.Add(Me.saldoTxt)
        Me.GroupBox1.Controls.Add(Me.numeroCuentaTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 321)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripcion"
        '
        'numeroCuentaTxt
        '
        Me.numeroCuentaTxt.Location = New System.Drawing.Point(176, 33)
        Me.numeroCuentaTxt.Name = "numeroCuentaTxt"
        Me.numeroCuentaTxt.Size = New System.Drawing.Size(201, 22)
        Me.numeroCuentaTxt.TabIndex = 3
        '
        'saldoTxt
        '
        Me.saldoTxt.Location = New System.Drawing.Point(176, 83)
        Me.saldoTxt.Name = "saldoTxt"
        Me.saldoTxt.Size = New System.Drawing.Size(201, 22)
        Me.saldoTxt.TabIndex = 4
        '
        'descripcionTxt
        '
        Me.descripcionTxt.Location = New System.Drawing.Point(176, 141)
        Me.descripcionTxt.Name = "descripcionTxt"
        Me.descripcionTxt.Size = New System.Drawing.Size(201, 54)
        Me.descripcionTxt.TabIndex = 5
        Me.descripcionTxt.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.noCuentaCb)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(423, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 125)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eliminar y editar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Numero de cuenta"
        '
        'noCuentaCb
        '
        Me.noCuentaCb.FormattingEnabled = True
        Me.noCuentaCb.Location = New System.Drawing.Point(24, 82)
        Me.noCuentaCb.Name = "noCuentaCb"
        Me.noCuentaCb.Size = New System.Drawing.Size(265, 24)
        Me.noCuentaCb.TabIndex = 1
        '
        'editarBtn
        '
        Me.editarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.editarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.editarBtn.Location = New System.Drawing.Point(432, 179)
        Me.editarBtn.Name = "editarBtn"
        Me.editarBtn.Size = New System.Drawing.Size(129, 34)
        Me.editarBtn.TabIndex = 7
        Me.editarBtn.Text = "Editar"
        Me.editarBtn.UseVisualStyleBackColor = False
        '
        'eliminarBtn
        '
        Me.eliminarBtn.BackColor = System.Drawing.Color.Tomato
        Me.eliminarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.eliminarBtn.Location = New System.Drawing.Point(601, 179)
        Me.eliminarBtn.Name = "eliminarBtn"
        Me.eliminarBtn.Size = New System.Drawing.Size(129, 34)
        Me.eliminarBtn.TabIndex = 8
        Me.eliminarBtn.Text = "Eliminar"
        Me.eliminarBtn.UseVisualStyleBackColor = False
        '
        'agregarBtn
        '
        Me.agregarBtn.BackColor = System.Drawing.Color.LightGreen
        Me.agregarBtn.Location = New System.Drawing.Point(481, 243)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(201, 38)
        Me.agregarBtn.TabIndex = 9
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(586, 45)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(186, 39)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Regresar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(115, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 58)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'LimpiarCamposToolStripMenuItem
        '
        Me.LimpiarCamposToolStripMenuItem.Name = "LimpiarCamposToolStripMenuItem"
        Me.LimpiarCamposToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.LimpiarCamposToolStripMenuItem.Text = "Limpiar campos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo de cuenta"
        '
        'tipocuentaCb
        '
        Me.tipocuentaCb.FormattingEnabled = True
        Me.tipocuentaCb.Location = New System.Drawing.Point(176, 230)
        Me.tipocuentaCb.Name = "tipocuentaCb"
        Me.tipocuentaCb.Size = New System.Drawing.Size(201, 24)
        Me.tipocuentaCb.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cliente"
        '
        'clienteCb
        '
        Me.clienteCb.FormattingEnabled = True
        Me.clienteCb.Location = New System.Drawing.Point(176, 273)
        Me.clienteCb.Name = "clienteCb"
        Me.clienteCb.Size = New System.Drawing.Size(201, 24)
        Me.clienteCb.TabIndex = 13
        '
        'CuentaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CuentaAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CuentaAdmin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents descripcionTxt As RichTextBox
    Friend WithEvents saldoTxt As TextBox
    Friend WithEvents numeroCuentaTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents agregarBtn As Button
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents editarBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents noCuentaCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tipocuentaCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents clienteCb As ComboBox
    Friend WithEvents Label6 As Label
End Class
