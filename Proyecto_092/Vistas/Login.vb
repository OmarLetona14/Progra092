Public Class Login
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim p As New Principal()
        p.Show()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        'If usuarioTxt.Text.Equals("201807347") Then
        'If passwordTxt.Text.Equals("admin") Then
        'Me.Hide()
        'Dim admin As New AdminDashboard()
        ' admin.Show()
        '    Else
        '  MessageBox.Show("Password invalido", "Error de login", MessageBoxButtons.OK,
        '  MessageBoxIcon.Error)
        '       clear()
        'End If
        '   Else
        '   MessageBox.Show("Usuario invalido", "Error de login", MessageBoxButtons.OK,
        '                    MessageBoxIcon.Error)
        '    clear()
        '   End If

        Me.Hide()
        Dim admin As New AdminDashboard()
        admin.Show()
    End Sub


    Private Sub clear()
        usuarioTxt.Text = ""
        passwordTxt.Text = ""
    End Sub

End Class