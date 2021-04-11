Public Class Retiro

    Dim cuenta As Cuenta
    Dim cliente As Cliente
    Dim tipo_transaccion As TipoTransaccion
    Dim transaccion As Transaccion
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cancelarBtn_Click(sender As Object, e As EventArgs) Handles cancelarBtn.Click
        Me.Hide()
        Dim myacc As New MyAccount
        myacc.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Utilities.aboutWindow()
    End Sub

    Private Sub LimpiarCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCamposToolStripMenuItem.Click
        Utilities.clearControls(Me.Controls)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Utilities.exitApplication()
    End Sub

    Private Sub Retiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliente = New Cliente
        tipo_transaccion = New TipoTransaccion
        For Each element As TipoTransaccion In tipo_transaccion.getTipoTransacciones
            If element IsNot Nothing Then
                transaccionCb.Items.Add(element.Tipotransaccion)
            End If
        Next
        For Each element As Cliente In cliente.getClientes
            If element IsNot Nothing Then
                clienteCb.Items.Add(element.Nombre)
            End If
        Next
    End Sub

    Private Sub cuentaCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cuentaCb.SelectedIndexChanged

    End Sub

    Private Sub clienteCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteCb.SelectedIndexChanged
        cuenta = New Cuenta
        For Each element As Cuenta In cuenta.getCuentasPerCliente(clienteCb.SelectedItem.ToString)
            If element IsNot Nothing Then
                cuentaCb.Items.Add(element.Nocuenta)
            End If
        Next
    End Sub

    Private Sub realizarTransaccionBtn_Click(sender As Object, e As EventArgs) Handles realizarTransaccionBtn.Click

    End Sub
End Class