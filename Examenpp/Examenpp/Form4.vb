Imports System.ComponentModel

Public Class Form4

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        Try

            Dim estado As String
            Dim prueba As String
            Dim positivo As Integer
            Dim activo As Integer
            Dim recuperado As Integer
            Dim muerto As Integer
            positivo = 0
            activo = 0
            recuperado = 0
            muerto = 0

            If Me.ValidateChildren And txtnombre.Text <> String.Empty And txtmunicipio.Text <> String.Empty And txtdescripcion.Text <> String.Empty And Val(txtedad.Text) - Int(Val(txtedad.Text)) = 0 Then
                MessageBox.Show("Datos registrados correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Select Case ComboBox2.SelectedIndex

                    Case = 0
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If

                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Atlantida " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 1
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If

                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Choluteca " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 2
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Colon  " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 3
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Comayagua " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 4
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Copan " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 5
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Cortes " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 6
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: El Paraiso " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 7
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Francisco Morazan " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 8
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Gracias a Dios " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 9
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Intibuca " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)


                    Case = 10
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Islas de la Bahia " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 11
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: La PAz " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 12
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Lempira " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 13
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Ocotepeque" & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 14
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Olancho " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 15
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Santa Barbara " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 16
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Valle" & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)

                    Case = 17
                        If CheckBox1.Checked = True Then
                            prueba = "Positivo"
                            positivo = positivo + 1
                        End If

                        If CheckBox2.Checked = True Then
                            prueba = "Negativo"
                        End If

                        If CheckBox3.Checked = True Then
                            estado = "Activo"
                            activo = activo + 1
                        End If

                        If CheckBox4.Checked = True Then
                            estado = "Recuperado"
                            recuperado = recuperado + 1
                        End If

                        If CheckBox5.Checked = True Then
                            estado = "Muerto"
                            muerto = muerto + 1
                        End If
                        lstHistorial.Items.Add("Nombre: " & txtnombre.Text & " Edad:" & txtedad.Text & " Departamento: Yoro " & " Municipio:" & txtmunicipio.Text & " Prueba: " & prueba & " Estado: " & estado & " Descripcion: " & txtdescripcion.Text)





                End Select

            Else
                MessageBox.Show("Ingrese correctamente los datos", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnombre.Clear()
                txtmunicipio.Clear()
                txtdescripcion.Clear()
                txtedad.Clear()


            End If

        Catch ex As Exception

        End Try




        txtnombre.Clear()
        txtmunicipio.Clear()
        txtdescripcion.Clear()
        txtedad.Clear()


    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
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

    Private Sub txtmunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtmunicipio.TextChanged

    End Sub

    Private Sub txtmunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtmunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtdescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtdescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        mensaje.SetToolTip(txtnombre, "Ingrese su nombre del paciente")
        mensaje.ToolTipTitle = "Nombre"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtedad_MouseHover(sender As Object, e As EventArgs) Handles txtedad.MouseHover
        mensaje.SetToolTip(txtedad, "Ingrese  edad del paciente")
        mensaje.ToolTipTitle = "Edad"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        mensaje.SetToolTip(ComboBox2, "Seleccione el departamente  de donde es el paciente")
        mensaje.ToolTipTitle = "Departamento"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtmunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtmunicipio.MouseHover
        mensaje.SetToolTip(txtmunicipio, "Ingrese el municipio de donde es el paciente")
        mensaje.ToolTipTitle = "Municipio"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtdescripcion.MouseHover
        mensaje.SetToolTip(txtdescripcion, "Ingrese la descripcion del paciente")
        mensaje.ToolTipTitle = "Descripcion"
        mensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False

        End If
        If CheckBox1.Checked = False Then
            CheckBox2.Checked = True

        End If

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtreporte_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class

