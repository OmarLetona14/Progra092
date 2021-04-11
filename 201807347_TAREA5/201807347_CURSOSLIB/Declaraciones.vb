Module Declaraciones

    Public inscripciones(5) As Pago

    Public Sub calcPago(pago As Pago)
        Select Case pago.NombreCurso
            Case "Visual basic"
                pago.Parcial = 150 * pago.Horas
            Case "Windows"
                pago.Parcial = 80 * pago.Horas
            Case "Flash"
                pago.Parcial = 125 * pago.Horas
        End Select
        descuento(pago)
        pago.Total = pago.Parcial - pago.Descuentodias - pago.Descuentopago
        inscripciones(calcFreeIndex()) = pago
    End Sub

    Public Sub descuento(pago As Pago)
        Select Case pago.Formapago
            Case "Efectivo"
                Dim descuento = pago.Parcial * 0.02
                pago.Descuentopago = descuento
            Case "Cheque"
                Dim descuento = pago.Parcial * 0.015
                pago.Descuentopago = descuento
        End Select
        If (pago.Dosdias) Then
            Dim descuento = pago.Parcial * 0.05
            pago.Descuentodias = descuento
        End If
    End Sub

    Public Function calcFreeIndex()
        For i As Integer = 0 To inscripciones.Length - 1
            If inscripciones(i) Is Nothing Then
                Return i
            End If
        Next
        Return 0
    End Function
End Module
