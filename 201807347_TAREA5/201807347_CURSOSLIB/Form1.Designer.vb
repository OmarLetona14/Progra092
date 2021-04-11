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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fechaDp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numeroInscripcionTxt = New System.Windows.Forms.TextBox()
        Me.nombreCursoCb = New System.Windows.Forms.ComboBox()
        Me.viernesCh = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sabadoCh = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.horasTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pagoCb = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarControlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dataLb = New System.Windows.Forms.ListBox()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pagoCb)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.horasTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.sabadoCh)
        Me.GroupBox1.Controls.Add(Me.viernesCh)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.nombreCursoCb)
        Me.GroupBox1.Controls.Add(Me.numeroInscripcionTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fechaDp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1153, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inscripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de inscripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del curso"
        '
        'fechaDp
        '
        Me.fechaDp.Location = New System.Drawing.Point(188, 115)
        Me.fechaDp.Name = "fechaDp"
        Me.fechaDp.Size = New System.Drawing.Size(260, 22)
        Me.fechaDp.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de inscripcion"
        '
        'numeroInscripcionTxt
        '
        Me.numeroInscripcionTxt.Location = New System.Drawing.Point(188, 30)
        Me.numeroInscripcionTxt.Name = "numeroInscripcionTxt"
        Me.numeroInscripcionTxt.Size = New System.Drawing.Size(260, 22)
        Me.numeroInscripcionTxt.TabIndex = 5
        '
        'nombreCursoCb
        '
        Me.nombreCursoCb.FormattingEnabled = True
        Me.nombreCursoCb.Items.AddRange(New Object() {"Visual basic", "Windows", "Flash"})
        Me.nombreCursoCb.Location = New System.Drawing.Point(188, 72)
        Me.nombreCursoCb.Name = "nombreCursoCb"
        Me.nombreCursoCb.Size = New System.Drawing.Size(260, 24)
        Me.nombreCursoCb.TabIndex = 6
        '
        'viernesCh
        '
        Me.viernesCh.AutoSize = True
        Me.viernesCh.Location = New System.Drawing.Point(625, 25)
        Me.viernesCh.Name = "viernesCh"
        Me.viernesCh.Size = New System.Drawing.Size(78, 21)
        Me.viernesCh.TabIndex = 0
        Me.viernesCh.Text = "Viernes"
        Me.viernesCh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(468, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dias del curso"
        '
        'sabadoCh
        '
        Me.sabadoCh.AutoSize = True
        Me.sabadoCh.Location = New System.Drawing.Point(806, 25)
        Me.sabadoCh.Name = "sabadoCh"
        Me.sabadoCh.Size = New System.Drawing.Size(79, 21)
        Me.sabadoCh.TabIndex = 8
        Me.sabadoCh.Text = "Sabado"
        Me.sabadoCh.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(468, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cantidad de horas por dia"
        '
        'horasTxt
        '
        Me.horasTxt.Location = New System.Drawing.Point(650, 72)
        Me.horasTxt.Name = "horasTxt"
        Me.horasTxt.Size = New System.Drawing.Size(342, 22)
        Me.horasTxt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(471, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Forma de pago"
        '
        'pagoCb
        '
        Me.pagoCb.FormattingEnabled = True
        Me.pagoCb.Items.AddRange(New Object() {"Efectivo", "Cheque"})
        Me.pagoCb.Location = New System.Drawing.Point(625, 123)
        Me.pagoCb.Name = "pagoCb"
        Me.pagoCb.Size = New System.Drawing.Size(367, 24)
        Me.pagoCb.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarControlesToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarListboxToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1177, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarControlesToolStripMenuItem
        '
        Me.LimpiarControlesToolStripMenuItem.Name = "LimpiarControlesToolStripMenuItem"
        Me.LimpiarControlesToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.LimpiarControlesToolStripMenuItem.Text = "Limpiar controles"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar vectores"
        '
        'LimpiarListboxToolStripMenuItem
        '
        Me.LimpiarListboxToolStripMenuItem.Name = "LimpiarListboxToolStripMenuItem"
        Me.LimpiarListboxToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.LimpiarListboxToolStripMenuItem.Text = "Limpiar listbox"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'dataLb
        '
        Me.dataLb.FormattingEnabled = True
        Me.dataLb.ItemHeight = 16
        Me.dataLb.Location = New System.Drawing.Point(12, 249)
        Me.dataLb.Name = "dataLb"
        Me.dataLb.Size = New System.Drawing.Size(1153, 164)
        Me.dataLb.TabIndex = 2
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 451)
        Me.Controls.Add(Me.dataLb)
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

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pagoCb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents horasTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sabadoCh As CheckBox
    Friend WithEvents viernesCh As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nombreCursoCb As ComboBox
    Friend WithEvents numeroInscripcionTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents fechaDp As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarControlesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dataLb As ListBox
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
End Class
