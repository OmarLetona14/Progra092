Module Procedimientos


    Public Function calcTotal(paciente As Paciente)
        Select Case paciente.Pago
            Case "Efectivo"
                Dim t = calcHabitacion(paciente.Habitacion, paciente.Dias)
                paciente.Subtotal = t
                Dim descuento = t * 0.15
                paciente.Descuento = descuento
                paciente.Total = t - descuento
            Case "Cheque"
                Dim t = calcHabitacion(paciente.Habitacion, paciente.Dias)
                paciente.Subtotal = t
                Dim descuento = t * 0.15
                paciente.Descuento = descuento
                paciente.Total = t - descuento
            Case "Tarjeta de credito"
                Dim t = calcHabitacion(paciente.Habitacion, paciente.Dias)
                paciente.Subtotal = t
                Dim descuento = t * 0
                paciente.Descuento = descuento
                paciente.Total = t - descuento
            Case "Tarjeta de debito"
                Dim t = calcHabitacion(paciente.Habitacion, paciente.Dias)
                paciente.Subtotal = t
                Dim descuento = t * 0.08
                paciente.Descuento = descuento
                paciente.Total = t - descuento
        End Select
        Return paciente
    End Function
    Public Function calcHabitacion(habitacion As String, dias As Integer)
        Select Case habitacion
            Case "Habitacion privada"
                Return dias * 350
            Case "Habitacion semiprivada"
                Return dias * 250
            Case "Habitacion no privada"
                Return dias * 150
        End Select
        Return 0
    End Function

End Module
