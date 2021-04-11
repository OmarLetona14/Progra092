Public Class Form1

    Dim formatt As String = "{0,-5},{1,-10},{2,-15},{3,-20},{4,-25},{5,-30},{6,-32},{7,-34},{8,-36}, {9,-38}"
    Private Sub LimpiarControlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarControlesToolStripMenuItem.Click
        clearControls()
    End Sub

    Private Sub clearControls()
        numeroInscripcionTxt.Text = ""
        horasTxt.Text = ""
        viernesCh.Checked = False
        sabadoCh.Checked = False

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim p As New Pago
        p.Numero = numeroInscripcionTxt.Text
        p.NombreCurso = nombreCursoCb.SelectedItem.ToString()
        p.Fecha = fechaDp.Value.ToShortDateString
        If sabadoCh.Checked And viernesCh.Checked Then
            p.Dosdias = True
            p.Dias = "Viernes y sabado"
        ElseIf sabadoCh.Checked And Not viernesCh.Checked Then
            p.Dias = "Sabado"
        ElseIf viernesCh.Checked And Not sabadoCh.Checked Then
            p.Dias = "Viernes"
        End If
        p.Horas = Convert.ToInt32(horasTxt.Text)
        p.Formapago = pagoCb.SelectedItem.ToString()
        Declaraciones.calcPago(p)
        imprimirVector()
        MessageBox.Show("Registro exitoso" & vbCrLf & "Pago parcial: Q " &
                        p.Parcial & vbCrLf & "Descuento 1: Q " & p.Descuentopago & vbCrLf &
                        "Descuento 2: Q " & p.Descuentodias & vbCrLf & "Total: Q " & p.Total,
                        "Registro exitoso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
        clearControls()
    End Sub

    Private Sub imprimirVector()
        dataLb.Items.Clear()
        dataLb.Items.Add(String.Format(formatt, "Numero", "Curso", "Fecha", "Dias", "Horas", "Pago",
    "Total parcial", "Descuento1", "Descuento2", "Total"))
        For Each e As Pago In Declaraciones.inscripciones
            If e IsNot Nothing Then
                dataLb.Items.Add(String.Format(formatt, e.Numero, e.NombreCurso, e.Fecha, e.Dias, e.Horas, e.Formapago,
                e.Parcial, e.Descuentopago, e.Descuentodias, e.Total))
            End If
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim answer As MsgBoxResult = MsgBox("Esta seguro de salir? ", MsgBoxStyle.YesNo)
        If answer = vbYes Then
            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataLb.Items.Add(String.Format(formatt, "Numero", "Curso", "Fecha", "Dias", "Horas", "Pago",
    "Total parcial", "Descuento1", "Descuento2", "Total"))
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        For i As Integer = 0 To Declaraciones.inscripciones.Length - 1
            If Declaraciones.inscripciones(i) IsNot Nothing Then
                Declaraciones.inscripciones(i) = Nothing
            End If
        Next
        dataLb.Items.Clear()
        dataLb.Items.Add(String.Format(formatt, "Numero", "Curso", "Fecha", "Dias", "Horas", "Pago",
    "Total parcial", "Descuento1", "Descuento2", "Total"))
    End Sub

    Private Sub LimpiarListboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListboxToolStripMenuItem.Click
        dataLb.Items.Clear()
        dataLb.Items.Add(String.Format(formatt, "Numero", "Curso", "Fecha", "Dias", "Horas", "Pago",
    "Total parcial", "Descuento1", "Descuento2", "Total"))
    End Sub
End Class
