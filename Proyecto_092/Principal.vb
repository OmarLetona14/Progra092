Imports Proyecto_092.Connector
Public Class Principal
    Private Sub myAccountBtn_Click(sender As Object, e As EventArgs) Handles myAccountBtn.Click
        Dim acc As New MyAccount()
        acc.Show()
        Me.Hide()
    End Sub

    Private Sub adminBtn_Click(sender As Object, e As EventArgs) Handles adminBtn.Click
        Dim login As New Login()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As New Connector()
        c.connect()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Utilities.exitApplication()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Utilities.aboutWindow()
    End Sub
End Class
