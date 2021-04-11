Module Declaraciones

    Public empleados(9) As Empleado

    Public Sub calcSueldo(empleado As Empleado)
        Select Case empleado.Descuento
            Case "IGSS"
                Dim descuento = empleado.Sueldobruto * 0.15
                empleado.Totaldescuento = descuento
            Case "ISR"
                Dim descuento = empleado.Sueldobruto * 0.06
                empleado.Totaldescuento = descuento
        End Select
        calcBono(empleado)
        empleado.Sueldototal = empleado.Sueldobruto - empleado.Totaldescuento + empleado.Bono
        empleados(calcFreeIndex()) = empleado
    End Sub

    Private Sub calcBono(empleado As Empleado)
        Dim bono As Double
        If (1 < empleado.Sueldobruto And empleado.Sueldobruto < 1000) Then
            bono = empleado.Sueldobruto * 0.03
        ElseIf (1001 < empleado.Sueldobruto And empleado.Sueldobruto < 1500) Then
            bono = empleado.Sueldobruto * 0.04
        ElseIf (1501 < empleado.Sueldobruto And empleado.Sueldobruto < 2000) Then
            bono = empleado.Sueldobruto * 0.05
        ElseIf (2001 < empleado.Sueldobruto And empleado.Sueldobruto < 2500) Then
            bono = empleado.Sueldobruto * 0.06
        ElseIf (empleado.Sueldobruto > 2501) Then
            bono = empleado.Sueldobruto * 0.07
        End If
        empleado.Bono = bono
    End Sub

    Private Function calcFreeIndex()
        For i As Integer = 0 To empleados.Length - 1
            If empleados(i) Is Nothing Then
                Return i
            End If
        Next
        Return 0
    End Function

End Module
