Module Utilities

    Public Sub clearControls(controles As Control.ControlCollection)
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

    Public Sub aboutWindow()
        Dim message As String = "Desarrollador: Diego Alejandro Merida Mendoza" & vbCrLf & "Carnet: 201807347"
        MsgBox(message, MsgBoxStyle.Information)
    End Sub
    Public Sub exitApplication()
        Dim answer As MsgBoxResult = MsgBox("Esta seguro de salir? ", MsgBoxStyle.YesNo)
        If answer = vbYes Then
            End
        End If
    End Sub
End Module
