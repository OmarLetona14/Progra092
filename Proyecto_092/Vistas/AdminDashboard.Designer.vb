<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tipoTransaccionBtn = New System.Windows.Forms.Button()
        Me.cuentasBtn = New System.Windows.Forms.Button()
        Me.clienteBtn = New System.Windows.Forms.Button()
        Me.tipoUsuarioBtn = New System.Windows.Forms.Button()
        Me.tipoCuentaBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.reportesBtn = New System.Windows.Forms.Button()
        Me.transaccionesBtn = New System.Windows.Forms.Button()
        Me.masDineroBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tipoTransaccionBtn)
        Me.GroupBox1.Controls.Add(Me.cuentasBtn)
        Me.GroupBox1.Controls.Add(Me.clienteBtn)
        Me.GroupBox1.Controls.Add(Me.tipoUsuarioBtn)
        Me.GroupBox1.Controls.Add(Me.tipoCuentaBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administracion"
        '
        'tipoTransaccionBtn
        '
        Me.tipoTransaccionBtn.Location = New System.Drawing.Point(363, 109)
        Me.tipoTransaccionBtn.Name = "tipoTransaccionBtn"
        Me.tipoTransaccionBtn.Size = New System.Drawing.Size(166, 50)
        Me.tipoTransaccionBtn.TabIndex = 4
        Me.tipoTransaccionBtn.Text = "Tipo de transaccion"
        Me.tipoTransaccionBtn.UseVisualStyleBackColor = True
        '
        'cuentasBtn
        '
        Me.cuentasBtn.Location = New System.Drawing.Point(120, 109)
        Me.cuentasBtn.Name = "cuentasBtn"
        Me.cuentasBtn.Size = New System.Drawing.Size(166, 50)
        Me.cuentasBtn.TabIndex = 3
        Me.cuentasBtn.Text = "Cuentas"
        Me.cuentasBtn.UseVisualStyleBackColor = True
        '
        'clienteBtn
        '
        Me.clienteBtn.Location = New System.Drawing.Point(488, 41)
        Me.clienteBtn.Name = "clienteBtn"
        Me.clienteBtn.Size = New System.Drawing.Size(151, 50)
        Me.clienteBtn.TabIndex = 2
        Me.clienteBtn.Text = "Cliente"
        Me.clienteBtn.UseVisualStyleBackColor = True
        '
        'tipoUsuarioBtn
        '
        Me.tipoUsuarioBtn.Location = New System.Drawing.Point(244, 41)
        Me.tipoUsuarioBtn.Name = "tipoUsuarioBtn"
        Me.tipoUsuarioBtn.Size = New System.Drawing.Size(151, 50)
        Me.tipoUsuarioBtn.TabIndex = 1
        Me.tipoUsuarioBtn.Text = "Tipo de usuario"
        Me.tipoUsuarioBtn.UseVisualStyleBackColor = True
        '
        'tipoCuentaBtn
        '
        Me.tipoCuentaBtn.Location = New System.Drawing.Point(28, 41)
        Me.tipoCuentaBtn.Name = "tipoCuentaBtn"
        Me.tipoCuentaBtn.Size = New System.Drawing.Size(135, 50)
        Me.tipoCuentaBtn.TabIndex = 0
        Me.tipoCuentaBtn.Text = "Tipo de cuenta"
        Me.tipoCuentaBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "Acerca de "
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
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.reportesBtn)
        Me.GroupBox2.Controls.Add(Me.transaccionesBtn)
        Me.GroupBox2.Controls.Add(Me.masDineroBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 259)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 205)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes"
        '
        'reportesBtn
        '
        Me.reportesBtn.Location = New System.Drawing.Point(28, 159)
        Me.reportesBtn.Name = "reportesBtn"
        Me.reportesBtn.Size = New System.Drawing.Size(611, 40)
        Me.reportesBtn.TabIndex = 2
        Me.reportesBtn.Text = "Reportes generales"
        Me.reportesBtn.UseVisualStyleBackColor = True
        '
        'transaccionesBtn
        '
        Me.transaccionesBtn.Location = New System.Drawing.Point(28, 98)
        Me.transaccionesBtn.Name = "transaccionesBtn"
        Me.transaccionesBtn.Size = New System.Drawing.Size(611, 40)
        Me.transaccionesBtn.TabIndex = 1
        Me.transaccionesBtn.Text = "Transacciones realizadas de retiro por cliente"
        Me.transaccionesBtn.UseVisualStyleBackColor = True
        '
        'masDineroBtn
        '
        Me.masDineroBtn.Location = New System.Drawing.Point(28, 39)
        Me.masDineroBtn.Name = "masDineroBtn"
        Me.masDineroBtn.Size = New System.Drawing.Size(611, 40)
        Me.masDineroBtn.TabIndex = 0
        Me.masDineroBtn.Text = "Top 5 de clientes Premium con mas dinero"
        Me.masDineroBtn.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 476)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cuentasBtn As Button
    Friend WithEvents clienteBtn As Button
    Friend WithEvents tipoUsuarioBtn As Button
    Friend WithEvents tipoCuentaBtn As Button
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tipoTransaccionBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents reportesBtn As Button
    Friend WithEvents transaccionesBtn As Button
    Friend WithEvents masDineroBtn As Button
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
End Class
