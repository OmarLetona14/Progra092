Public Class PantallaPrincipal

    Private clean As Boolean
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lineaChb_CheckedChanged(sender As Object, e As EventArgs) Handles lineaChb.CheckedChanged

    End Sub

    Private Function checkFields()
        If nombreClienteTxt.Text Is "" Then
            Return False
        End If
        If nitTxt.Text Is "" Then
            Return False
        End If
        If cableChb.Checked Then
            If Not canales_125Rb.Checked And Not canales_250Rb.Checked Then
                Return False
            End If
        End If
        If internetChb.Checked Then
            If Not velocidad_128Rb.Checked And Not velocidad_256Rb.Checked And
                    Not velocidad_512Rb.Checked Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If checkFields() Then
            Dim detail As String = "Cliente: " & nombreClienteTxt.Text & vbCrLf &
        "Nit: " & nitTxt.Text & vbCrLf & "Total por mes: "
            If (lineaChb.Checked) Then
                Declaraciones.lineaFija = True
            End If
            If (cableChb.Checked) Then
                Declaraciones.cable = True
                If (canales_125Rb.Checked) Then
                    Declaraciones.canales_125 = True
                ElseIf (canales_250Rb.Checked) Then
                    Declaraciones.canales_250 = True
                End If
            End If
            If (internetChb.Checked) Then
                Declaraciones.internet = True
                If (velocidad_128Rb.Checked) Then
                    velocidad_128 = True
                ElseIf (velocidad_256Rb.Checked) Then
                    velocidad_256 = True
                ElseIf (velocidad_512Rb.Checked) Then
                    velocidad_512 = True
                End If
            End If
            Dim total As Double = Math.Round(Declaraciones.calcularTotal(), 2)
            MsgBox("Su total es: Q " & total, MsgBoxStyle.Information)
            detail += "Q " & total
            detallelbl.Text = detail
        Else
            MsgBox("No ha llenado los campos de manera correcta ", MsgBoxStyle.Exclamation
                   )
        End If
    End Sub


    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        clean = True
        limpiarCampos()

    End Sub

    Private Sub limpiarCampos()
        lineaFija = False
        cable = False
        internet = False
        velocidad_128 = False
        velocidad_256 = False
        velocidad_512 = False
        canales_125 = False
        canales_250 = False
        lineaChb.Checked = False
        cableChb.Checked = False
        canales_125Rb.Checked = False
        canales_250Rb.Checked = False
        internetChb.Checked = False
        velocidad_128Rb.Checked = False
        velocidad_256Rb.Checked = False
        velocidad_512Rb.Checked = False
        internetFields.Enabled = False
        cableFields.Enabled = False
        If (clean) Then
            totalLbl.Text = ""
            nombreClienteTxt.Text = ""
            nitTxt.Text = ""
            detallelbl.Text = ""
            clean = False
        End If
    End Sub

    Private Sub internetChb_CheckedChanged(sender As Object, e As EventArgs) Handles internetChb.CheckedChanged
        If (internetChb.Checked) Then
            internetFields.Enabled = True
        Else
            internetFields.Enabled = False
            velocidad_128Rb.Checked = False
            velocidad_256Rb.Checked = False
            velocidad_512Rb.Checked = False
        End If
    End Sub

    Private Sub cableChb_CheckedChanged(sender As Object, e As EventArgs) Handles cableChb.CheckedChanged
        If (cableChb.Checked) Then
            cableFields.Enabled = True
        Else
            cableFields.Enabled = False
            canales_125Rb.Checked = False
            canales_250Rb.Checked = False
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim answer As MsgBoxResult = MsgBox("Esta seguro de salir? ", MsgBoxStyle.YesNo)
        If answer = vbYes Then
            End
        End If
    End Sub
End Class
