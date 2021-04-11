Public Class AdminDashboard
    Private Sub tipoCuentaBtn_Click(sender As Object, e As EventArgs) Handles tipoCuentaBtn.Click
        Me.Hide()
        Dim acc As New AccountTypeAdmin()
        acc.Show()
    End Sub

    Private Sub tipoUsuarioBtn_Click(sender As Object, e As EventArgs) Handles tipoUsuarioBtn.Click
        Me.Hide()
        Dim user As New UserTypeAdmin()
        user.Show()
    End Sub

    Private Sub clienteBtn_Click(sender As Object, e As EventArgs) Handles clienteBtn.Click
        Me.Hide()
        Dim cliente As New ClienteAdmin()
        cliente.Show()
    End Sub

    Private Sub cuentasBtn_Click(sender As Object, e As EventArgs) Handles cuentasBtn.Click
        Me.Hide()
        Dim cuenta As New CuentaAdmin()
        cuenta.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        Dim login As New Login()
        login.Show()
    End Sub

    Private Sub tipoTransaccionBtn_Click(sender As Object, e As EventArgs) Handles tipoTransaccionBtn.Click
        Me.Hide()
        Dim transaction As New TransactionTypeAdmin()
        transaction.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Utilities.exitApplication()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Utilities.aboutWindow()
    End Sub
End Class