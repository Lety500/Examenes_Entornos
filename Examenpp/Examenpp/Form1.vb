Public Class Form1
    Private Sub txtSalir_Click(sender As Object, e As EventArgs) Handles txtSalir.Click

        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click

        Dim formulario = New Form2
        formulario.Show()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim formulario = New Form3
        formulario.Show()
    End Sub
End Class
