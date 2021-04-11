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
        Me.electroCh = New System.Windows.Forms.CheckBox()
        Me.ecoCh = New System.Windows.Forms.CheckBox()
        Me.pruebaCh = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.laboratorioCb = New System.Windows.Forms.ComboBox()
        Me.pagoCb = New System.Windows.Forms.ComboBox()
        Me.datosGv = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datosGv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pagoCb)
        Me.GroupBox1.Controls.Add(Me.laboratorioCb)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pruebaCh)
        Me.GroupBox1.Controls.Add(Me.ecoCh)
        Me.GroupBox1.Controls.Add(Me.electroCh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 209)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Examenes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de examen"
        '
        'electroCh
        '
        Me.electroCh.AutoSize = True
        Me.electroCh.Location = New System.Drawing.Point(19, 152)
        Me.electroCh.Name = "electroCh"
        Me.electroCh.Size = New System.Drawing.Size(153, 21)
        Me.electroCh.TabIndex = 1
        Me.electroCh.Text = "Electrocardiograma"
        Me.electroCh.UseVisualStyleBackColor = True
        '
        'ecoCh
        '
        Me.ecoCh.AutoSize = True
        Me.ecoCh.Location = New System.Drawing.Point(19, 72)
        Me.ecoCh.Name = "ecoCh"
        Me.ecoCh.Size = New System.Drawing.Size(133, 21)
        Me.ecoCh.TabIndex = 2
        Me.ecoCh.Text = "Ecocardiograma"
        Me.ecoCh.UseVisualStyleBackColor = True
        '
        'pruebaCh
        '
        Me.pruebaCh.AutoSize = True
        Me.pruebaCh.Location = New System.Drawing.Point(19, 112)
        Me.pruebaCh.Name = "pruebaCh"
        Me.pruebaCh.Size = New System.Drawing.Size(155, 21)
        Me.pruebaCh.TabIndex = 3
        Me.pruebaCh.Text = "Prueba de esfuerzo"
        Me.pruebaCh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Laboratorio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Forma de pago"
        '
        'laboratorioCb
        '
        Me.laboratorioCb.FormattingEnabled = True
        Me.laboratorioCb.Location = New System.Drawing.Point(491, 33)
        Me.laboratorioCb.Name = "laboratorioCb"
        Me.laboratorioCb.Size = New System.Drawing.Size(242, 24)
        Me.laboratorioCb.TabIndex = 6
        '
        'pagoCb
        '
        Me.pagoCb.FormattingEnabled = True
        Me.pagoCb.Location = New System.Drawing.Point(491, 110)
        Me.pagoCb.Name = "pagoCb"
        Me.pagoCb.Size = New System.Drawing.Size(242, 24)
        Me.pagoCb.TabIndex = 7
        '
        'datosGv
        '
        Me.datosGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosGv.Location = New System.Drawing.Point(12, 273)
        Me.datosGv.Name = "datosGv"
        Me.datosGv.RowHeadersWidth = 51
        Me.datosGv.RowTemplate.Height = 24
        Me.datosGv.Size = New System.Drawing.Size(761, 165)
        Me.datosGv.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.LimpiarGridToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'LimpiarGridToolStripMenuItem
        '
        Me.LimpiarGridToolStripMenuItem.Name = "LimpiarGridToolStripMenuItem"
        Me.LimpiarGridToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.LimpiarGridToolStripMenuItem.Text = "Limpiar grid"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.datosGv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datosGv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pagoCb As ComboBox
    Friend WithEvents laboratorioCb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pruebaCh As CheckBox
    Friend WithEvents ecoCh As CheckBox
    Friend WithEvents electroCh As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents datosGv As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarGridToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
