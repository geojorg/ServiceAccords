<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NuevaContraseña = New System.Windows.Forms.TextBox()
        Me.NuevoUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Inicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Confirmar = New System.Windows.Forms.TextBox()
        Me.Mensaje = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AreaDM = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Usuario:"
        '
        'NuevaContraseña
        '
        Me.NuevaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NuevaContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NuevaContraseña.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaContraseña.Location = New System.Drawing.Point(146, 230)
        Me.NuevaContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.NuevaContraseña.MaxLength = 4
        Me.NuevaContraseña.Multiline = True
        Me.NuevaContraseña.Name = "NuevaContraseña"
        Me.NuevaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.NuevaContraseña.Size = New System.Drawing.Size(165, 25)
        Me.NuevaContraseña.TabIndex = 2
        '
        'NuevoUsuario
        '
        Me.NuevoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NuevoUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NuevoUsuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoUsuario.Location = New System.Drawing.Point(146, 178)
        Me.NuevoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.NuevoUsuario.Multiline = True
        Me.NuevoUsuario.Name = "NuevoUsuario"
        Me.NuevoUsuario.Size = New System.Drawing.Size(165, 25)
        Me.NuevoUsuario.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(142, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Registrate"
        '
        'Inicio
        '
        Me.Inicio.BackColor = System.Drawing.Color.White
        Me.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Inicio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Inicio.Location = New System.Drawing.Point(146, 455)
        Me.Inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(122, 30)
        Me.Inicio.TabIndex = 5
        Me.Inicio.Text = "Crear"
        Me.Inicio.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 45)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Confirmar Contraseña:"
        '
        'Confirmar
        '
        Me.Confirmar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Confirmar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Confirmar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirmar.Location = New System.Drawing.Point(146, 285)
        Me.Confirmar.Margin = New System.Windows.Forms.Padding(2)
        Me.Confirmar.MaxLength = 4
        Me.Confirmar.Multiline = True
        Me.Confirmar.Name = "Confirmar"
        Me.Confirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Confirmar.Size = New System.Drawing.Size(165, 25)
        Me.Confirmar.TabIndex = 3
        '
        'Mensaje
        '
        Me.Mensaje.AutoSize = True
        Me.Mensaje.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensaje.ForeColor = System.Drawing.Color.White
        Me.Mensaje.Location = New System.Drawing.Point(65, 392)
        Me.Mensaje.Name = "Mensaje"
        Me.Mensaje.Size = New System.Drawing.Size(0, 21)
        Me.Mensaje.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Registrate con tu usuario de EPICOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(48, 115)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Selecciona una contraseña numerica"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(48, 340)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 21)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Area:"
        '
        'AreaDM
        '
        Me.AreaDM.BackColor = System.Drawing.Color.White
        Me.AreaDM.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.AreaDM.FormattingEnabled = True
        Me.AreaDM.Items.AddRange(New Object() {"CALIDAD", "COMERCIAL", "PRODUCCION", "INGENIERIA", "COMPRAS", "FINANCIERA", "PROYECTOS", "GH", "DESPACHOS", "GERENCIA"})
        Me.AreaDM.Location = New System.Drawing.Point(146, 340)
        Me.AreaDM.Name = "AreaDM"
        Me.AreaDM.Size = New System.Drawing.Size(165, 25)
        Me.AreaDM.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(48, 136)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 21)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "que no inicie con cero."
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AreaDM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mensaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Confirmar)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NuevaContraseña)
        Me.Controls.Add(Me.NuevoUsuario)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NewUser"
        Me.Size = New System.Drawing.Size(393, 604)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NuevaContraseña As TextBox
    Friend WithEvents NuevoUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Inicio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Confirmar As TextBox
    Friend WithEvents Mensaje As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AreaDM As ComboBox
    Friend WithEvents Label8 As Label
End Class
