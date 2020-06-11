<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SINAGER"
        '
        'btncrear
        '
        Me.btncrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.Location = New System.Drawing.Point(117, 142)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(83, 48)
        Me.btncrear.TabIndex = 1
        Me.btncrear.Text = "Crear Usuario"
        Me.btncrear.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(274, 142)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(74, 48)
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Iniciar Sesion"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'txtSalir
        '
        Me.txtSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalir.Location = New System.Drawing.Point(387, 259)
        Me.txtSalir.Name = "txtSalir"
        Me.txtSalir.Size = New System.Drawing.Size(79, 44)
        Me.txtSalir.TabIndex = 3
        Me.txtSalir.Text = "Salir"
        Me.txtSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = Global.Examenpp.My.Resources.Resources.descarga
        Me.Label2.Location = New System.Drawing.Point(33, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Examenpp.My.Resources.Resources._33334051_diseño_elegante_diseño_de_fondo_color_beige_blanco_con_textura_de_pergamino_de_la_vendimia_el_pie_de_página_
        Me.ClientSize = New System.Drawing.Size(500, 331)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSalir)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SINAGER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncrear As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtSalir As Button
    Friend WithEvents Label2 As Label
End Class
