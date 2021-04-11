<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClienteAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.editarBtn = New System.Windows.Forms.Button()
        Me.eliminarBtn = New System.Windows.Forms.Button()
        Me.agregarBtn = New System.Windows.Forms.Button()
        Me.telefonoTxt = New System.Windows.Forms.TextBox()
        Me.clientesCb = New System.Windows.Forms.ComboBox()
        Me.direccionTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tipousuarioCb = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tipousuarioCb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.editarBtn)
        Me.GroupBox1.Controls.Add(Me.eliminarBtn)
        Me.GroupBox1.Controls.Add(Me.agregarBtn)
        Me.GroupBox1.Controls.Add(Me.telefonoTxt)
        Me.GroupBox1.Controls.Add(Me.clientesCb)
        Me.GroupBox1.Controls.Add(Me.direccionTxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.nombreTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 341)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 253)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 71)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'editarBtn
        '
        Me.editarBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.editarBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.editarBtn.FlatAppearance.BorderSize = 5
        Me.editarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.editarBtn.Location = New System.Drawing.Point(406, 278)
        Me.editarBtn.Name = "editarBtn"
        Me.editarBtn.Size = New System.Drawing.Size(134, 46)
        Me.editarBtn.TabIndex = 7
        Me.editarBtn.Text = "Editar"
        Me.editarBtn.UseVisualStyleBackColor = False
        '
        'eliminarBtn
        '
        Me.eliminarBtn.BackColor = System.Drawing.Color.Tomato
        Me.eliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.eliminarBtn.FlatAppearance.BorderSize = 5
        Me.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminarBtn.Location = New System.Drawing.Point(438, 45)
        Me.eliminarBtn.Name = "eliminarBtn"
        Me.eliminarBtn.Size = New System.Drawing.Size(102, 39)
        Me.eliminarBtn.TabIndex = 2
        Me.eliminarBtn.Text = "Eliminar"
        Me.eliminarBtn.UseVisualStyleBackColor = False
        '
        'agregarBtn
        '
        Me.agregarBtn.BackColor = System.Drawing.Color.LimeGreen
        Me.agregarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.agregarBtn.FlatAppearance.BorderSize = 5
        Me.agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.agregarBtn.Location = New System.Drawing.Point(253, 278)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(134, 46)
        Me.agregarBtn.TabIndex = 6
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = False
        '
        'telefonoTxt
        '
        Me.telefonoTxt.Location = New System.Drawing.Point(115, 202)
        Me.telefonoTxt.Name = "telefonoTxt"
        Me.telefonoTxt.Size = New System.Drawing.Size(135, 22)
        Me.telefonoTxt.TabIndex = 5
        '
        'clientesCb
        '
        Me.clientesCb.FormattingEnabled = True
        Me.clientesCb.Location = New System.Drawing.Point(171, 53)
        Me.clientesCb.Name = "clientesCb"
        Me.clientesCb.Size = New System.Drawing.Size(240, 24)
        Me.clientesCb.TabIndex = 1
        '
        'direccionTxt
        '
        Me.direccionTxt.Location = New System.Drawing.Point(115, 148)
        Me.direccionTxt.Name = "direccionTxt"
        Me.direccionTxt.Size = New System.Drawing.Size(425, 22)
        Me.direccionTxt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre del cliente"
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(115, 98)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(425, 22)
        Me.nombreTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(456, 40)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(129, 35)
        Me.backBtn.TabIndex = 1
        Me.backBtn.Text = "Atras"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(595, 28)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo de usuario"
        '
        'tipousuarioCb
        '
        Me.tipousuarioCb.FormattingEnabled = True
        Me.tipousuarioCb.Location = New System.Drawing.Point(406, 202)
        Me.tipousuarioCb.Name = "tipousuarioCb"
        Me.tipousuarioCb.Size = New System.Drawing.Size(134, 24)
        Me.tipousuarioCb.TabIndex = 10
        '
        'ClienteAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 445)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClienteAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClienteAdmin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents editarBtn As Button
    Friend WithEvents eliminarBtn As Button
    Friend WithEvents agregarBtn As Button
    Friend WithEvents telefonoTxt As TextBox
    Friend WithEvents clientesCb As ComboBox
    Friend WithEvents direccionTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents backBtn As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tipousuarioCb As ComboBox
    Friend WithEvents Label5 As Label
End Class
