<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyAccount))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.transactionBtn = New System.Windows.Forms.Button()
        Me.tUserCb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.accountStateBtn = New System.Windows.Forms.Button()
        Me.eUserCb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataGv = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.retirarBtn = New System.Windows.Forms.Button()
        Me.depositarBtn = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.transactionBtn)
        Me.GroupBox1.Controls.Add(Me.tUserCb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transacciones"
        '
        'transactionBtn
        '
        Me.transactionBtn.Location = New System.Drawing.Point(358, 53)
        Me.transactionBtn.Name = "transactionBtn"
        Me.transactionBtn.Size = New System.Drawing.Size(92, 33)
        Me.transactionBtn.TabIndex = 2
        Me.transactionBtn.Text = "Cargar"
        Me.transactionBtn.UseVisualStyleBackColor = True
        '
        'tUserCb
        '
        Me.tUserCb.FormattingEnabled = True
        Me.tUserCb.Location = New System.Drawing.Point(116, 58)
        Me.tUserCb.Name = "tUserCb"
        Me.tUserCb.Size = New System.Drawing.Size(222, 24)
        Me.tUserCb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.accountStateBtn)
        Me.GroupBox2.Controls.Add(Me.eUserCb)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de cuenta"
        '
        'accountStateBtn
        '
        Me.accountStateBtn.Location = New System.Drawing.Point(358, 53)
        Me.accountStateBtn.Name = "accountStateBtn"
        Me.accountStateBtn.Size = New System.Drawing.Size(92, 41)
        Me.accountStateBtn.TabIndex = 2
        Me.accountStateBtn.Text = "Cargar"
        Me.accountStateBtn.UseVisualStyleBackColor = True
        '
        'eUserCb
        '
        Me.eUserCb.FormattingEnabled = True
        Me.eUserCb.Location = New System.Drawing.Point(116, 53)
        Me.eUserCb.Name = "eUserCb"
        Me.eUserCb.Size = New System.Drawing.Size(222, 24)
        Me.eUserCb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        '
        'dataGv
        '
        Me.dataGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGv.Location = New System.Drawing.Point(12, 334)
        Me.dataGv.Name = "dataGv"
        Me.dataGv.RowHeadersWidth = 51
        Me.dataGv.RowTemplate.Height = 24
        Me.dataGv.Size = New System.Drawing.Size(663, 162)
        Me.dataGv.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.retirarBtn)
        Me.GroupBox3.Controls.Add(Me.depositarBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(503, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(172, 201)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestiones de cuenta"
        '
        'retirarBtn
        '
        Me.retirarBtn.Location = New System.Drawing.Point(33, 126)
        Me.retirarBtn.Name = "retirarBtn"
        Me.retirarBtn.Size = New System.Drawing.Size(110, 48)
        Me.retirarBtn.TabIndex = 1
        Me.retirarBtn.Text = "Retirar"
        Me.retirarBtn.UseVisualStyleBackColor = True
        '
        'depositarBtn
        '
        Me.depositarBtn.Location = New System.Drawing.Point(33, 46)
        Me.depositarBtn.Name = "depositarBtn"
        Me.depositarBtn.Size = New System.Drawing.Size(110, 47)
        Me.depositarBtn.TabIndex = 0
        Me.depositarBtn.Text = "Depositar"
        Me.depositarBtn.UseVisualStyleBackColor = True
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(503, 267)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(172, 42)
        Me.backBtn.TabIndex = 4
        Me.backBtn.Text = "Regresar"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 30)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarCamposToolStripMenuItem
        '
        Me.LimpiarCamposToolStripMenuItem.Name = "LimpiarCamposToolStripMenuItem"
        Me.LimpiarCamposToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.LimpiarCamposToolStripMenuItem.Text = "Limpiar campos"
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
        'MyAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 524)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dataGv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MyAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyAccount"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataGv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents transactionBtn As Button
    Friend WithEvents tUserCb As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents accountStateBtn As Button
    Friend WithEvents eUserCb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dataGv As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents retirarBtn As Button
    Friend WithEvents depositarBtn As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
