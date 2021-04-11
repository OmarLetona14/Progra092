Public Class Form1

    Dim ex(3) As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laboratorioCb.Items.AddRange({"Lab1", "Lab2"})
        pagoCb.Items.AddRange({"Efectivo", "Tarjeta"})
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
            End If
        Next
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        limpiarVectorStrings()
        If electroCh.Checked Then
            ex(calcFreeIndexEx) = "Electrocardiograma"
        End If
        If ecoCh.Checked Then
            ex(calcFreeIndexEx) = "Ecocardiograma"
        End If
        If pruebaCh.Checked Then
            ex(calcFreeIndexEx) = "Prueba de esfuerzo"
        End If
        Dim examen As New Examen
        examen.Examen = ex
        examen.Laboratorio = laboratorioCb.SelectedItem.ToString
        examen.Pago = pagoCb.SelectedItem.ToString
        Declaraciones.calcTotal(examen)
        datosGv.Update()
        datosGv.DataSource = Declaraciones.examenes
        clearControls(Me.Controls)
    End Sub

    Private Sub limpiarVectorStrings()
        For i As Integer = 0 To ex.Length - 1
            If ex(i) IsNot Nothing Then
                ex(i) = Nothing
            End If
        Next
    End Sub
    Private Function calcFreeIndexEx()
        For i As Integer = 0 To ex.Length - 1
            If ex(i) Is Nothing Then
                Return i
            End If
        Next
        Return 0
    End Function

    Private Sub LimpiarGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarGridToolStripMenuItem.Click
        datosGv.DataSource = Nothing

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Declaraciones.limpiarVector()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim answer As MsgBoxResult = MsgBox("Esta seguro de salir? ", MsgBoxStyle.YesNo)
        If answer = vbYes Then
            End
        End If
    End Sub
End Class
