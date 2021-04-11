Public Class Clinica

    Dim formatt As String = "{0,-15},{1,-20},{2,-25},{3,-30},{4,-35},{5,-40},{6,-45}"
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Dim paciente As New Paciente
        paciente.Nombrepaciente = nombrePacienteTxt.Text
        paciente.Genero = generoCb.SelectedItem.ToString()
        paciente.Dias = calcDays()
        paciente.Tipoterapia = tipoTerapiaCb.SelectedItem.ToString()
        Procedimientos.calcTotal(paciente)
        imprimirVector()
        MessageBox.Show("Registro exitoso" & vbCrLf & "Subtotal: Q " &
                        paciente.Subtotal & vbCrLf & "Descuento: Q " & paciente.Descuento & vbCrLf &
                        "Total: Q " & paciente.Total,
                        "Registro exitoso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
        clearControls(Me.Controls)
    End Sub


    Private Sub imprimirVector()
        limpiarListbox()
        For Each e As Paciente In Procedimientos.pacientes
            If e IsNot Nothing Then
                pacienteLb.Items.Add(String.Format(formatt,
                                                   e.Nombrepaciente, e.Genero, e.Dias, e.Tipoterapia, e.Subtotal, e.Descuento, e.Total))
            End If
        Next
    End Sub

    Private Sub limpiarListbox()
        pacienteLb.Items.Clear()
        pacienteLb.Items.Add(String.Format(formatt, "Nombre del paciente", "Genero", "Dias", "Tipo", "Subtotal", "Descuento",
        "Total"))
    End Sub
    Private Function calcDays()
        If (lunesCh.Checked And viernesCh.Checked And miercolesCh.Checked) Then
            Return 3
        ElseIf (lunesCh.Checked And viernesCh.Checked Or viernesCh.Checked And miercolesCh.Checked Or lunesCh.Checked And miercolesCh.Checked) Then
            Return 2
        ElseIf (lunesCh.Checked Or viernesCh.Checked Or miercolesCh.Checked) Then
            Return 1
        Else
            Return 0
        End If
    End Function

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

    Private Sub LimpiarDatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDatosDeEntradaToolStripMenuItem.Click
        clearControls(Me.Controls)
    End Sub

    Private Sub Clinica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tipoTerapiaCb.Items.Add("Individual")
        tipoTerapiaCb.Items.Add("Familiar")
        limpiarListbox()
    End Sub

    Private Sub limpiarVector()
        For i As Integer = 0 To Procedimientos.pacientes.Length - 1
            If Procedimientos.pacientes(i) IsNot Nothing Then
                Procedimientos.pacientes(i) = Nothing
            End If
        Next
        limpiarListbox()
    End Sub
    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiarVector()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim answer As MsgBoxResult = MsgBox("Esta seguro de salir? ", MsgBoxStyle.YesNo)
        If answer = vbYes Then
            End
        End If
    End Sub
End Class
