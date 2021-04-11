<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.nitTxt = New System.Windows.Forms.TextBox()
        Me.diasTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarDatosDeEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.habitacionCb = New System.Windows.Forms.ComboBox()
        Me.pagoCb = New System.Windows.Forms.ComboBox()
        Me.datosLb = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pagoCb)
        Me.GroupBox1.Controls.Add(Me.habitacionCb)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.diasTxt)
        Me.GroupBox1.Controls.Add(Me.nitTxt)
        Me.GroupBox1.Controls.Add(Me.nombreTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(954, 247)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(110, 48)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(266, 22)
        Me.nombreTxt.TabIndex = 2
        '
        'nitTxt
        '
        Me.nitTxt.Location = New System.Drawing.Point(110, 117)
        Me.nitTxt.Name = "nitTxt"
        Me.nitTxt.Size = New System.Drawing.Size(266, 22)
        Me.nitTxt.TabIndex = 3
        '
        'diasTxt
        '
        Me.diasTxt.Location = New System.Drawing.Point(183, 189)
        Me.diasTxt.Name = "diasTxt"
        Me.diasTxt.Size = New System.Drawing.Size(193, 22)
        Me.diasTxt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dias hospitalizado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de habitacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(458, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tipo de pago por habitacion"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarDatosDeEntradaToolStripMenuItem, Me.LimpiarListboxToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(983, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarDatosDeEntradaToolStripMenuItem
        '
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Name = "LimpiarDatosDeEntradaToolStripMenuItem"
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Size = New System.Drawing.Size(190, 24)
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Text = "Limpiar datos de entrada"
        '
        'LimpiarListboxToolStripMenuItem
        '
        Me.LimpiarListboxToolStripMenuItem.Name = "LimpiarListboxToolStripMenuItem"
        Me.LimpiarListboxToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.LimpiarListboxToolStripMenuItem.Text = "Limpiar listbox"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'habitacionCb
        '
        Me.habitacionCb.FormattingEnabled = True
        Me.habitacionCb.Location = New System.Drawing.Point(635, 44)
        Me.habitacionCb.Name = "habitacionCb"
        Me.habitacionCb.Size = New System.Drawing.Size(281, 24)
        Me.habitacionCb.TabIndex = 8
        '
        'pagoCb
        '
        Me.pagoCb.FormattingEnabled = True
        Me.pagoCb.Location = New System.Drawing.Point(660, 117)
        Me.pagoCb.Name = "pagoCb"
        Me.pagoCb.Size = New System.Drawing.Size(256, 24)
        Me.pagoCb.TabIndex = 9
        '
        'datosLb
        '
        Me.datosLb.FormattingEnabled = True
        Me.datosLb.ItemHeight = 16
        Me.datosLb.Location = New System.Drawing.Point(17, 327)
        Me.datosLb.MultiColumn = True
        Me.datosLb.Name = "datosLb"
        Me.datosLb.Size = New System.Drawing.Size(954, 132)
        Me.datosLb.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 477)
        Me.Controls.Add(Me.datosLb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pagoCb As ComboBox
    Friend WithEvents habitacionCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents diasTxt As TextBox
    Friend WithEvents nitTxt As TextBox
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarDatosDeEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents datosLb As ListBox
End Class
