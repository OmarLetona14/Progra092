Public Class CuentaAdmin

    Private id As Integer
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim admin As New AdminDashboard()
        admin.Show()
    End Sub

    Private Sub LimpiarCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCamposToolStripMenuItem.Click
        Utilities.clearControls(Me.Controls)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Utilities.exitApplication()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Utilities.aboutWindow()
    End Sub

    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        Dim c As Cuenta = getCuenta()
        If c.insertCuenta(c) Then
            MessageBox.Show("Se agrego correctamente la cuenta", "Agregado exitosamente ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al ingresar la cuenta", "Error de cuenta", MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
        End If
        Me.Hide()
        Dim ca As New CuentaAdmin
        ca.Show()
    End Sub

    Private Function getCuenta()
        Dim cuenta As New Cuenta
        Dim tc As New TipoCuenta
        Dim c As New Cliente
        cuenta.Nocuenta = numeroCuentaTxt.Text
        cuenta.Total = saldoTxt.Text
        cuenta.Descripcion = descripcionTxt.Text
        For Each element As Cliente In c.getClientes()
            If element IsNot Nothing Then
                If element.Nombre.Equals(clienteCb.SelectedItem.ToString()) Then
                    cuenta.Idcliente = element.Idcliente
                End If
            End If
        Next

        For Each element As TipoCuenta In tc.getTipoCuentas()
            If element IsNot Nothing Then
                If element.Nombretipo.Equals(tipocuentaCb.SelectedItem.ToString()) Then
                    cuenta.Idtipo = element.Idtipo
                End If
            End If
        Next
        Return cuenta
    End Function

    Private Sub CuentaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tc As New TipoCuenta
        Dim c As New Cliente
        Dim cuenta As New Cuenta
        For Each element As TipoCuenta In tc.getTipoCuentas()
            If element IsNot Nothing Then
                tipocuentaCb.Items.Add(element.Nombretipo)
            End If
        Next
        For Each element As Cliente In c.getClientes()
            If element IsNot Nothing Then
                clienteCb.Items.Add(element.Nombre)
            End If
        Next
        For Each element As Cuenta In cuenta.getCuentas()
            If element IsNot Nothing Then
                noCuentaCb.Items.Add(element.Nocuenta)
            End If
        Next
    End Sub

    Private Sub editarBtn_Click(sender As Object, e As EventArgs) Handles editarBtn.Click
        Dim c As Cuenta = getCuenta()
        c.Idcuenta = id
        If c.updateCuenta(c) Then
            MessageBox.Show("Se edito correctamente la cuenta", "Editado exitosamente ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al editar la cuenta", "Error de cuenta", MessageBoxButtons.OK,
                           MessageBoxIcon.Error)

        End If
        Me.Hide()
        Dim ca As New CuentaAdmin
        ca.Show()
    End Sub

    Private Sub noCuentaCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles noCuentaCb.SelectedIndexChanged
        Dim cuenta As New Cuenta
        Dim tc As New TipoCuenta
        Dim c As New Cliente
        For Each element As Cuenta In cuenta.getCuentas()
            If element IsNot Nothing Then
                If noCuentaCb.SelectedItem IsNot Nothing Then
                    If element.Nocuenta.ToString().Trim().Equals(noCuentaCb.SelectedItem.ToString().Trim()) Then
                        cuenta.Idcuenta = element.Idcuenta
                    End If
                End If
            End If
        Next
        cuenta = cuenta.getOneCuenta(cuenta.Idcuenta)
        numeroCuentaTxt.Text = cuenta.Nocuenta
        saldoTxt.Text = cuenta.Total
        descripcionTxt.Text = cuenta.Descripcion
        For Each element As TipoCuenta In tc.getTipoCuentas()
            If element IsNot Nothing Then
                If element.Idtipo = cuenta.Idtipo Then
                    tipocuentaCb.SelectedItem = element.Nombretipo
                End If
            End If
        Next
        For Each element As Cliente In c.getClientes()
            If element IsNot Nothing Then
                If element.Idcliente = cuenta.Idcliente Then
                    clienteCb.SelectedItem = element.Nombre
                End If
            End If
        Next
        id = cuenta.Idcuenta
    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        Dim c As New Cuenta
        If c.deleteCuenta(id) Then
            MessageBox.Show("Se elimino correctamente la cuenta", "Eliminado exitosamente ", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al eliminar la cuenta", "Error de cuenta", MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
        End If
        Me.Hide()
        Dim ca As New CuentaAdmin
        ca.Show()
    End Sub
End Class