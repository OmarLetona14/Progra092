Module Procedimientos

    Public pacientes(8) As Paciente
    Public Sub calcTotal(paciente As Paciente)
        paciente.Subtotal = paciente.Dias * 150
        Select Case paciente.Tipoterapia
            Case "Individual"
                paciente.Subtotal += 200
            Case "Familiar"
                paciente.Subtotal += 300
        End Select
        calcDescuento(paciente)
        pacientes(calcFreeIndex()) = paciente
    End Sub

    Private Sub calcDescuento(paciente As Paciente)
        If (100 < paciente.Subtotal And paciente.Subtotal < 300) Then
            Dim descuento = paciente.Subtotal * 0.05
            paciente.Descuento = descuento
            paciente.Total = Math.Round(paciente.Subtotal - descuento, 2)
        ElseIf (300 < paciente.Subtotal And paciente.Subtotal < 550) Then
            Dim descuento = paciente.Subtotal * 0.07
            paciente.Descuento = descuento
            paciente.Total = Math.Round(paciente.Subtotal - descuento, 2)
        Else
            Dim descuento = paciente.Subtotal * 0.1
            paciente.Descuento = descuento
            paciente.Total = Math.Round(paciente.Subtotal - descuento, 2)
        End If
    End Sub

    Private Function calcFreeIndex()
        For i As Integer = 0 To pacientes.Length - 1
            If pacientes(i) Is Nothing Then
                Return i
            End If
        Next
        Return 0
    End Function


End Module
