Imports System.ComponentModel

Public Class Form2
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged

    End Sub

    Private Sub btncontinuar_Click(sender As Object, e As EventArgs) Handles btncontinuar.Click
        Me.Close()
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        Try

            If Me.ValidateChildren And txtnombre.Text <> String.Empty And txtapellido.Text <> String.Empty And txtcontraseña.Text <> String.Empty And Val(txtIdentidad.Text) - Int(Val(txtIdentidad.Text)) = 0 And Val(txtedad.Text) - Int(Val(txtedad.Text)) = 0 Then
                MessageBox.Show("Datos registrados correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Else
                MessageBox.Show("Ingrese correctamente los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnombre.Clear()
                txtapellido.Clear()
                txtIdentidad.Clear()
                txtedad.Clear()
                txtcontraseña.Clear()

            End If

        Catch ex As Exception

        End Try

        txtnombre.Clear()
        txtapellido.Clear()
        txtIdentidad.Clear()
        txtedad.Clear()
        txtcontraseña.Clear()
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged

    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtedad_TextChanged(sender As Object, e As EventArgs) Handles txtedad.TextChanged

    End Sub

    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating

        If Val(txtedad.Text) - Int(Val(txtedad.Text)) = 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged

    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover

        mensaje.SetToolTip(txtnombre, "Ingrese su nombre")
        mensaje.ToolTipTitle = "Nombre"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        mensaje.SetToolTip(txtapellido, "Ingrese su apellido")
        mensaje.ToolTipTitle = "Apellido"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtedad_MouseHover(sender As Object, e As EventArgs) Handles txtedad.MouseHover
        mensaje.SetToolTip(txtedad, "Ingrese su edad")
        mensaje.ToolTipTitle = "Edad"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_MouseHover(sender As Object, e As EventArgs) Handles ComboBox1.MouseHover
        mensaje.SetToolTip(ComboBox1, "Seleccione su sexo")
        mensaje.ToolTipTitle = "Sexo"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        mensaje.SetToolTip(txtIdentidad, "Ingrese su numero de identidad")
        mensaje.ToolTipTitle = "Identidad"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontraseña_MouseHover(sender As Object, e As EventArgs) Handles txtcontraseña.MouseHover
        mensaje.SetToolTip(txtcontraseña, "Ingrese su contraseña")
        mensaje.ToolTipTitle = "Contraseña"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class