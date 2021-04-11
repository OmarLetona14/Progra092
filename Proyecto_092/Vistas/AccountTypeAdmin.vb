Public Class AccountTypeAdmin

    Private tiposcuentas As List(Of TipoCuenta)
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim admin As New AdminDashboard()
        admin.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        If (Not nombreTxt.Text.Length = 0) Then
            Dim tipocuenta As New TipoCuenta()
            tipocuenta.Nombretipo = nombreTxt.Text
            If (tipocuenta.insertTipoCuenta(tipocuenta)) Then
                clear()
                MessageBox.Show("Registro exitoso", "Registro exitoso", MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
                updateList()
            Else
                MessageBox.Show("Ocurrio un error al ingresar el registro", "Error de registro", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub clear()
        nombreTxt.Text = ""

    End Sub

    Private Sub modificarBtn_Click(sender As Object, e As EventArgs) Handles modificarBtn.Click
        If cuentaCb.SelectedItem IsNot Nothing Then
            Dim selected As TipoCuenta = getTipoCuenta()
            If Not nombreTxt.Text.Length = 0 Then
                Dim edit As New TipoCuenta()
                edit.Nombretipo = nombreTxt.Text
                edit.Idtipo = selected.Idtipo
                If edit.updateTipoCuenta(edit) Then
                    clear()
                    MessageBox.Show("Modificacion exitosa", "Registro exitoso", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
                    Me.Hide()
                    Dim acc As New AccountTypeAdmin
                    acc.Show()
                Else
                    MessageBox.Show("Ocurrio un error al modificar el registro", "Error de registro", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error)
                End If
            End If
            End If
    End Sub

    Private Function getTipoCuenta()
        For Each element As TipoCuenta In tiposcuentas
            If element IsNot Nothing Then
                If cuentaCb.SelectedItem.ToString().Equals(element.Nombretipo) Then
                    Return element
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub AccountTypeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateList()
    End Sub

    Private Sub cuentaCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cuentaCb.SelectedIndexChanged
        clear()
        Dim tipo As TipoCuenta = getTipoCuenta()
        nombreTxt.Text = tipo.Nombretipo
    End Sub

    Private Sub updateList()
        cuentaCb.Items.Clear()
        Dim tipos As New TipoCuenta
        tiposcuentas = tipos.getTipoCuentas()
        For Each element As TipoCuenta In tiposcuentas
            If element IsNot Nothing Then
                cuentaCb.Items.Add(element.Nombretipo)
            End If
        Next

    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        Dim tipo As TipoCuenta = getTipoCuenta()
        If (tipo.deleteTipoCuenta(tipo.Idtipo)) Then
            MessageBox.Show("Eliminacion exitosa", "Eliminacion exitosa", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
            Me.Hide()
            Dim w As New AccountTypeAdmin()
            w.Show()
        Else
            MessageBox.Show("Ocurrio un error al modificar el registro", "Error de registro", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error)
        End If

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
End Class