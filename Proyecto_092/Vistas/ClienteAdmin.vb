Public Class ClienteAdmin

    Dim cliente As Cliente
    Dim tipou As TipoUsuario
    Dim id As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim admin As New AdminDashboard()
        admin.Show()
    End Sub

    Private Sub LimpiarCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCamposToolStripMenuItem.Click
        Utilities.clearControls(Me.Controls)
    End Sub

    Private Sub ClienteAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cliente = New Cliente()
        tipou = New TipoUsuario()
        For Each element As Cliente In cliente.getClientes()
            If element IsNot Nothing Then
                clientesCb.Items.Add(element.Nombre)
            End If
        Next
        For Each element As TipoUsuario In tipou.getTipoUsuario()
            If element IsNot Nothing Then
                tipousuarioCb.Items.Add(element.Tipousuario)
            End If
        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Utilities.exitApplication()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Utilities.aboutWindow()
    End Sub

    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        cliente = getCliente()
        If cliente.insertCliente(cliente) Then
            MessageBox.Show("Se agrego correctamente el usuario", "Agregado exitosamente ", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al ingresar el usuario", "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
        End If
        Me.Hide()
        Dim ca As New ClienteAdmin()
        ca.Show()
    End Sub

    Private Sub editarBtn_Click(sender As Object, e As EventArgs) Handles editarBtn.Click
        cliente = getCliente()
        For Each element As Cliente In cliente.getClientes()
            If element IsNot Nothing Then
                If element.Nombre.Equals(clientesCb.SelectedItem.ToString().Trim()) Then
                    id = element.Idcliente
                End If
            End If
        Next
        cliente.Idcliente = id
        If cliente.updateCliente(cliente) Then
            MessageBox.Show("Se edito correctamente el usuario", "Editado exitosamente ", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al editar el usuario", "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error)
        End If
        Me.Hide()
        Dim ca As New ClienteAdmin()
        ca.Show()
    End Sub

    Private Function getCliente()
        Dim c As New Cliente
        c.Nombre = nombreTxt.Text
        c.Direccion = direccionTxt.Text
        c.Telefono = telefonoTxt.Text
        For Each element As TipoUsuario In tipou.getTipoUsuario()
            If element IsNot Nothing Then
                If element.Tipousuario.ToString().Trim().Equals(tipousuarioCb.SelectedItem.ToString().Trim()) Then
                    c.Idtipousuario = element.Idtipousuario
                End If
            End If
        Next
        Return c
    End Function

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        cliente = New Cliente()
        For Each element As Cliente In cliente.getClientes()
            If element IsNot Nothing Then
                If element.Nombre.Equals(clientesCb.SelectedItem.ToString().Trim()) Then
                    id = element.Idcliente
                End If
            End If
        Next
        If cliente.deleteCliente(id) Then
            MessageBox.Show("Se elimino correctamente el usuario", "Eliminado exitosamente ", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("Ocurrio un error al eliminar el usuario", "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error)

        End If
        Me.Hide()
        Dim ca As New ClienteAdmin()
        ca.Show()
    End Sub

    Private Sub clientesCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clientesCb.SelectedIndexChanged
        If clientesCb.SelectedItem IsNot Nothing Then
            cliente = New Cliente()
            For Each element As Cliente In cliente.getClientes()
                If element IsNot Nothing Then
                    If element.Nombre.Equals(clientesCb.SelectedItem.ToString().Trim()) Then
                        cliente = element
                    End If
                End If
            Next
            nombreTxt.Text = cliente.Nombre
            direccionTxt.Text = cliente.Direccion
            telefonoTxt.Text = cliente.Telefono
            For Each element As TipoUsuario In New TipoUsuario().getTipoUsuario()
                If element IsNot Nothing Then
                    If element.Idtipousuario = cliente.Idtipousuario Then
                        tipousuarioCb.SelectedItem = element.Tipousuario
                    End If
                End If
            Next
        End If
    End Sub
End Class