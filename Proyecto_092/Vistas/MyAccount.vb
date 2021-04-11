Public Class MyAccount
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim p As New Principal()
        p.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Utilities.exitApplication()
    End Sub

    Private Sub LimpiarCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCamposToolStripMenuItem.Click
        Utilities.clearControls(Me.Controls)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Utilities.aboutWindow()
    End Sub

    Private Sub transactionBtn_Click(sender As Object, e As EventArgs) Handles transactionBtn.Click
        Dim t As New TransaccionView
        dataGv.Update()
        dataGv.DataSource = t.getClientRecord(tUserCb.SelectedItem.ToString())
    End Sub

    Private Sub MyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As New Cliente
        For Each element As Cliente In c.getClientes()
            If element IsNot Nothing Then
                tUserCb.Items.Add(element.Nombre)
                eUserCb.Items.Add(element.Nombre)
            End If
        Next
    End Sub

    Private Sub accountStateBtn_Click(sender As Object, e As EventArgs) Handles accountStateBtn.Click
        Dim c As New CuentaView
        dataGv.Update()
        dataGv.DataSource = c.getClientAccount(eUserCb.SelectedItem.ToString())
    End Sub

    Private Sub depositarBtn_Click(sender As Object, e As EventArgs) Handles depositarBtn.Click
        Me.Hide()
        Dim r As New Retiro
        r.Show()
    End Sub

    Private Sub retirarBtn_Click(sender As Object, e As EventArgs) Handles retirarBtn.Click
        Me.Hide()
        Dim r As New Retiro
        r.Show()
    End Sub
End Class