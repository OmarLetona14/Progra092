<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountTypeAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountTypeAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cuentaCb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.eliminarBtn = New System.Windows.Forms.Button()
        Me.modificarBtn = New System.Windows.Forms.Button()
        Me.agregarBtn = New System.Windows.Forms.Button()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Controls.Add(Me.cuentaCb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.eliminarBtn)
        Me.GroupBox1.Controls.Add(Me.modificarBtn)
        Me.GroupBox1.Controls.Add(Me.agregarBtn)
        Me.GroupBox1.Controls.Add(Me.nombreTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administracion de tipos de cuentas"
        '
        'cuentaCb
        '
        Me.cuentaCb.FormattingEnabled = True
        Me.cuentaCb.Location = New System.Drawing.Point(440, 32)
        Me.cuentaCb.Name = "cuentaCb"
        Me.cuentaCb.Size = New System.Drawing.Size(248, 24)
        Me.cuentaCb.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cuenta "
        '
        'eliminarBtn
        '
        Me.eliminarBtn.Location = New System.Drawing.Point(527, 142)
        Me.eliminarBtn.Name = "eliminarBtn"
        Me.eliminarBtn.Size = New System.Drawing.Size(172, 26)
        Me.eliminarBtn.TabIndex = 5
        Me.eliminarBtn.Text = "Eliminar"
        Me.eliminarBtn.UseVisualStyleBackColor = True
        '
        'modificarBtn
        '
        Me.modificarBtn.Location = New System.Drawing.Point(325, 142)
        Me.modificarBtn.Name = "modificarBtn"
        Me.modificarBtn.Size = New System.Drawing.Size(172, 26)
        Me.modificarBtn.TabIndex = 4
        Me.modificarBtn.Text = "Modificar"
        Me.modificarBtn.UseVisualStyleBackColor = True
        '
        'agregarBtn
        '
        Me.agregarBtn.Location = New System.Drawing.Point(125, 142)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(172, 26)
        Me.agregarBtn.TabIndex = 2
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = True
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(100, 35)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(232, 22)
        Me.nombreTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(649, 36)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(121, 30)
        Me.backBtn.TabIndex = 3
        Me.backBtn.Text = "Regresar"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(89, 26)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LimpiarCamposToolStripMenuItem
        '
        Me.LimpiarCamposToolStripMenuItem.Name = "LimpiarCamposToolStripMenuItem"
        Me.LimpiarCamposToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.LimpiarCamposToolStripMenuItem.Text = "Limpiar campos"
        '
        'AccountTypeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 304)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AccountTypeAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x`"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents agregarBtn As Button
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents modificarBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cuentaCb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
End Class
