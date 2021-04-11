Imports System.Reflection

Public Class Form1

    Dim pacientes As New List(Of Paciente)
    Dim formatt As String = "{0,-5},{1,-10},{2,-15},{3,-20},{4,-25},{5,-30},{6,-35},{7,-40}"
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Dim paciente As New Paciente()
        paciente.Nombre = nombreTxt.Text
        paciente.Nit = nitTxt.Text
        paciente.Dias = Convert.ToInt64(diasTxt.Text)
        paciente.Pago = pagoCb.SelectedItem.ToString()
        paciente.Habitacion = habitacionCb.SelectedItem.ToString()
        If (Procedimientos.calcTotal(paciente) IsNot Nothing) Then
            pacientes.Add(paciente)
            datosLb.Items.Add(String.Format(formatt, paciente.Nombre, paciente.Nit, paciente.Dias, paciente.Habitacion, paciente.Pago,
                                            Math.Round(paciente.Subtotal, 2), Math.Round(paciente.Descuento, 2),
                                            Math.Round(paciente.Total), 2))

            MessageBox.Show("Registro exitoso", "Registro exitoso", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information)
            clearFields()
        Else
            MessageBox.Show("Ocurrio un error al ingresar el registro", "Error de registro", MessageBoxButtons.OK,
                                                           MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datosLb.Items.Add(String.Format(formatt, "Nombre", "NIT", "Dias", "Tipo de habitacion",
                                        "Forma de pago", "Subtotal", "Descuento", "Total"))
        habitacionCb.Items.Add("Habitacion privada")
        habitacionCb.Items.Add("Habitacion semiprivada")
        habitacionCb.Items.Add("Habitacion no privada")
        pagoCb.Items.Add("Efectivo")
        pagoCb.Items.Add("Cheque")
        pagoCb.Items.Add("Tarjeta de credito")
        pagoCb.Items.Add("Tarjeta de debito")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim answer As MsgBoxResult = MsgBox("Esta seguro de salir? ", MsgBoxStyle.YesNo)
        If answer = vbYes Then
            End
        End If
    End Sub

    Private Sub clearFields()
        nombreTxt.Text = ""
        nitTxt.Text = ""
        diasTxt.Text = ""
    End Sub

    Private Sub clearListBox()
        datosLb.Items.Clear()
        datosLb.Items.Add(String.Format(formatt, "Nombre", "NIT", "Dias", "Tipo de habitacion",
                                        "Forma de pago", "Subtotal", "Descuento", "Total"))
    End Sub

    Private Sub LimpiarDatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDatosDeEntradaToolStripMenuItem.Click
        clearFields()
    End Sub

    Private Sub LimpiarListboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListboxToolStripMenuItem.Click
        clearListBox()
    End Sub
End Class
