<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clinica
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombrePacienteTxt = New System.Windows.Forms.TextBox()
        Me.generoCb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lunesCh = New System.Windows.Forms.CheckBox()
        Me.miercolesCh = New System.Windows.Forms.CheckBox()
        Me.viernesCh = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tipoTerapiaCb = New System.Windows.Forms.ComboBox()
        Me.pacienteLb = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarDatosDeEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tipoTerapiaCb)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.viernesCh)
        Me.GroupBox1.Controls.Add(Me.miercolesCh)
        Me.GroupBox1.Controls.Add(Me.lunesCh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.generoCb)
        Me.GroupBox1.Controls.Add(Me.nombrePacienteTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(991, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Genero"
        '
        'nombrePacienteTxt
        '
        Me.nombrePacienteTxt.Location = New System.Drawing.Point(207, 41)
        Me.nombrePacienteTxt.Name = "nombrePacienteTxt"
        Me.nombrePacienteTxt.Size = New System.Drawing.Size(272, 22)
        Me.nombrePacienteTxt.TabIndex = 2
        '
        'generoCb
        '
        Me.generoCb.FormattingEnabled = True
        Me.generoCb.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.generoCb.Location = New System.Drawing.Point(207, 131)
        Me.generoCb.Name = "generoCb"
        Me.generoCb.Size = New System.Drawing.Size(272, 24)
        Me.generoCb.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(675, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dias de consulta"
        '
        'lunesCh
        '
        Me.lunesCh.AutoSize = True
        Me.lunesCh.Location = New System.Drawing.Point(529, 85)
        Me.lunesCh.Name = "lunesCh"
        Me.lunesCh.Size = New System.Drawing.Size(69, 21)
        Me.lunesCh.TabIndex = 5
        Me.lunesCh.Text = "Lunes"
        Me.lunesCh.UseVisualStyleBackColor = True
        '
        'miercolesCh
        '
        Me.miercolesCh.AutoSize = True
        Me.miercolesCh.Location = New System.Drawing.Point(698, 85)
        Me.miercolesCh.Name = "miercolesCh"
        Me.miercolesCh.Size = New System.Drawing.Size(90, 21)
        Me.miercolesCh.TabIndex = 6
        Me.miercolesCh.Text = "Miercoles"
        Me.miercolesCh.UseVisualStyleBackColor = True
        '
        'viernesCh
        '
        Me.viernesCh.AutoSize = True
        Me.viernesCh.Location = New System.Drawing.Point(870, 85)
        Me.viernesCh.Name = "viernesCh"
        Me.viernesCh.Size = New System.Drawing.Size(78, 21)
        Me.viernesCh.TabIndex = 7
        Me.viernesCh.Text = "Viernes"
        Me.viernesCh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(529, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de terapia"
        '
        'tipoTerapiaCb
        '
        Me.tipoTerapiaCb.FormattingEnabled = True
        Me.tipoTerapiaCb.Location = New System.Drawing.Point(698, 138)
        Me.tipoTerapiaCb.Name = "tipoTerapiaCb"
        Me.tipoTerapiaCb.Size = New System.Drawing.Size(272, 24)
        Me.tipoTerapiaCb.TabIndex = 9
        '
        'pacienteLb
        '
        Me.pacienteLb.FormattingEnabled = True
        Me.pacienteLb.ItemHeight = 16
        Me.pacienteLb.Location = New System.Drawing.Point(12, 264)
        Me.pacienteLb.Name = "pacienteLb"
        Me.pacienteLb.Size = New System.Drawing.Size(991, 164)
        Me.pacienteLb.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.LimpiarDatosDeEntradaToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1023, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'LimpiarDatosDeEntradaToolStripMenuItem
        '
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Name = "LimpiarDatosDeEntradaToolStripMenuItem"
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Text = "Limpiar datos de entrada"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 450)
        Me.Controls.Add(Me.pacienteLb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Clinica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tipoTerapiaCb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents viernesCh As CheckBox
    Friend WithEvents miercolesCh As CheckBox
    Friend WithEvents lunesCh As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents generoCb As ComboBox
    Friend WithEvents nombrePacienteTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pacienteLb As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarDatosDeEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
