Module Declaraciones

    Public lineaFija, internet, cable,
    velocidad_128, velocidad_256, velocidad_512,
    canales_125, canales_250, descuento_5, descuento_8 As Boolean
    Public Function calcularTotal()
        Dim total As Double
        descuento_5 = False
        descuento_8 = False
        If (lineaFija) Then
            total += 99.0
        End If
        If internet Then
            If (velocidad_128) Then
                total += 75.5
            ElseIf (velocidad_256) Then
                total += 140.5
                If (lineaFija) Then
                    descuento_5 = True
                End If
            ElseIf (velocidad_512) Then
                total += 175.5
            End If
        End If
        If cable Then
            If (canales_125) Then
                total += 100
            ElseIf (canales_250) Then
                total += 175
                If (lineaFija And velocidad_512) Then
                    descuento_8 = True
                End If
            End If
        End If
        If (descuento_5) Then
            Dim desc As Double = ((total * 5) / 100)
            total -= desc
        End If
        If (descuento_8) Then
            Dim desc As Double = ((total * 8) / 100)
            total -= desc
        End If
        Return total
    End Function


End Module
