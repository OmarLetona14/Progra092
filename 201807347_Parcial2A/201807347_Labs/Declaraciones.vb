Module Declaraciones

    Public examenes(5) As Examen

    Public Sub calcTotal(examen As Examen)
        For Each e As String In examen.Examen
            Select Case e
                Case "Electrocardiograma"
                    If (examen.Laboratorio Is "Lab1") Then
                        examen.Subtotal += 100.99
                    Else
                        examen.Subtotal += 125.99
                    End If
                Case "Prueba de esfuerzo"
                    If (examen.Laboratorio Is "Lab1") Then
                        examen.Subtotal += 150.5
                    Else
                        examen.Subtotal += 100.0
                    End If
                Case "Ecocardiograma"
                    If (examen.Laboratorio Is "Lab1") Then
                        examen.Subtotal += 250.0
                    Else
                        examen.Subtotal += 275.0
                    End If
            End Select
        Next
        calcDescuento(examen)
        examen.Total = examen.Subtotal - examen.Descuento
        examenes(calcFreeIndex()) = examen
    End Sub


    Private Sub calcDescuento(examen As Examen)
        Dim descuento = 0
        Select Case examen.Laboratorio
            Case "Lab1"
                If (examen.Pago Is "Efectivo") Then
                    descuento = examen.Subtotal * 0.1
                End If
            Case "Lab2"
                If (examen.Pago Is "Efectivo") Then
                    descuento = examen.Subtotal * 0.2
                End If
        End Select
        examen.Descuento += descuento
    End Sub

    Private Function calcFreeIndex()
        For i As Integer = 0 To examenes.Length - 1
            If examenes(i) Is Nothing Then
                Return i
            End If
        Next
        Return 0
    End Function

    Public Sub limpiarVector()
        For i As Integer = 0 To examenes.Length - 1
            If examenes(i) IsNot Nothing Then
                examenes(i) = Nothing
            End If
        Next
    End Sub

End Module
