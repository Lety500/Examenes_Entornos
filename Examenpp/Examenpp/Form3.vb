Imports System.ComponentModel

Public Class Form3
    Private Sub btncontinuar_Click(sender As Object, e As EventArgs) Handles btncontinuar.Click
        Dim formulario = New Form4


        Try
            Dim contraseña As String
            contraseña = txtcontraseña.Text

            If Me.ValidateChildren And txtusuario.Text <> String.Empty And txtcontraseña.Text <> String.Empty Then

                If contraseña = "SinHacer2020" Then

                    MessageBox.Show("Contraseña Correcta", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formulario.Show()
                    Me.Close()

                Else
                    MessageBox.Show("Contraseña Incorrecta", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtusuario.Clear()
                    txtcontraseña.Clear()
                End If

            Else
                MessageBox.Show("Debe ingresar datos ", "Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtusuario.Clear()
                txtcontraseña.Clear()


            End If

        Catch ex As Exception

        End Try

        txtusuario.Clear()
        txtcontraseña.Clear()


    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtusuario_Validating(sender As Object, e As CancelEventArgs) Handles txtusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged

    End Sub

    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtusuario_MouseHover(sender As Object, e As EventArgs) Handles txtusuario.MouseHover
        mensaje.SetToolTip(txtusuario, "Ingrese usuario")
        mensaje.ToolTipTitle = "Usuario"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontraseña_MouseHover(sender As Object, e As EventArgs) Handles txtcontraseña.MouseHover
        mensaje.SetToolTip(txtcontraseña, "Ingrese su contraseña")
        mensaje.ToolTipTitle = "Contraseña"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class