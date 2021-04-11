Public Class Form1

    Dim formatt As String = "{0,-15},{1,-20},{2,-25},{3,-30},{4,-35},{5,-40}"
    Private Sub LimpiarEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradaToolStripMenuItem.Click
        clearControls(Me.Controls)
    End Sub

    Private Sub clearControls(controles As Control.ControlCollection)
        For Each control As Control In controles
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is PictureBox Then
                DirectCast(control, PictureBox).Image = Nothing
            ElseIf TypeOf control Is ComboBox Then
                DirectCast(control, ComboBox).SelectedIndex = -1
            ElseIf TypeOf control Is NumericUpDown Then
                DirectCast(control, NumericUpDown).Value = 0
            ElseIf TypeOf control Is CheckBox Then
                DirectCast(control, CheckBox).Checked = False
            ElseIf TypeOf control Is GroupBox Or TypeOf control Is Panel Then
                clearControls(control.Controls)
            ElseIf TypeOf control Is DataGridView Then
                DirectCast(control, DataGridView).Rows.Clear()
                DirectCast(control, DataGridView).DataSource = Nothing
            End If
        Next
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim empleado As New Empleado
        empleado.Nombre = nombreTxt.Text
        empleado.Sueldobruto = Convert.ToDouble(sueldoTxt.Text)
        empleado.Descuento = descuentoCb.SelectedItem.ToString()
        Declaraciones.calcSueldo(empleado)
        imprimirVector()
        clearControls(Me.Controls)
    End Sub

    Private Sub limpiarListbox()
        empleadosLb.Items.Clear()
        empleadosLb.Items.Add(String.Format(formatt, "Nombre", "Sueldo base",
                                            "Descuento", "Total descuento", "Bono", "Sueldo total",
        "Total"))
    End Sub
    Private Sub imprimirVector()
        limpiarListbox()
        For Each e As Empleado In empleados
            If e IsNot Nothing Then
                empleadosLb.Items.Add(String.Format(formatt, e.Nombre, e.Sueldobruto, e.Descuento,
                                                    e.Totaldescuento, e.Bono, e.Sueldototal))
            End If
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        descuentoCb.Items.AddRange({"IGSS", "ISR"})
        limpiarListbox()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiarListbox()
    End Sub
End Class
