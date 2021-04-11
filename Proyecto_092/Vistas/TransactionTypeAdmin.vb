Public Class TransactionTypeAdmin

    Private tipotransacciones As List(Of TipoTransaccion)
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        Dim d As New AdminDashboard()
        d.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not nombreTxt.Text.Length = 0) Then
            Dim tipotransaccion As New TipoTransaccion()
            tipotransaccion.Tipotransaccion = nombreTxt.Text
            If (tipotransaccion.insertTipoTransaccion(tipotransaccion)) Then
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

    Private Sub updateList()
        transaccionCb.Items.Clear()
        Dim tipos As New TipoTransaccion
        tipotransacciones = tipos.getTipoTransacciones()
        For Each element As TipoTransaccion In tipotransacciones
            If element IsNot Nothing Then
                transaccionCb.Items.Add(element.Tipotransaccion)
            End If
        Next

    End Sub
    Private Function getTipoTransaccion()
        For Each element As TipoTransaccion In tipotransacciones
            If element IsNot Nothing Then
                If transaccionCb.SelectedItem.ToString().Equals(element.Tipotransaccion) Then
                    Return element
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If transaccionCb.SelectedItem IsNot Nothing Then
            Dim selected As TipoTransaccion = getTipoTransaccion()
            If Not nombreTxt.Text.Length = 0 Then
                Dim edit As New TipoTransaccion()
                edit.Tipotransaccion = nombreTxt.Text
                edit.Idtipotran = selected.Idtipotran
                If edit.updateTipoTransaccion(edit) Then
                    clear()
                    MessageBox.Show("Modificacion exitosa", "Registro exitoso", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
                    Me.Hide()
                    Dim acc As New TransactionTypeAdmin()
                    acc.Show()
                Else
                    MessageBox.Show("Ocurrio un error al modificar el registro", "Error de registro", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub TransactionTypeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tipo As TipoTransaccion = getTipoTransaccion()
        If (tipo.deleteTipoTransaccion(tipo.Idtipotran)) Then
            MessageBox.Show("Eliminacion exitosa", "Eliminacion exitosa", MessageBoxButtons.OK,
                                           MessageBoxIcon.Information)
            Me.Hide()
            Dim w As New TransactionTypeAdmin()
            w.Show()
        Else
            MessageBox.Show("Ocurrio un error al modificar el registro", "Error de registro", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub transaccionCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles transaccionCb.SelectedIndexChanged
        clear()
        Dim tipo As TipoTransaccion = getTipoTransaccion()
        nombreTxt.Text = tipo.Tipotransaccion
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