<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetCatResponsables
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.chkContinua = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Controles = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApMaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApPaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbResponsableDtVax = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClaveResponsable = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.chkSU = New System.Windows.Forms.CheckBox()
        Me.bImporte = New System.Windows.Forms.CheckBox()
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.Controles.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkContinua
        '
        Me.chkContinua.AutoSize = True
        Me.chkContinua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContinua.Location = New System.Drawing.Point(23, 315)
        Me.chkContinua.Name = "chkContinua"
        Me.chkContinua.Size = New System.Drawing.Size(129, 20)
        Me.chkContinua.TabIndex = 69
        Me.chkContinua.Text = "Captura Continua"
        Me.chkContinua.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(584, 312)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(360, 312)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Controles
        '
        Me.Controles.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controles.Controls.Add(Me.chkPassword)
        Me.Controles.Controls.Add(Me.bImporte)
        Me.Controles.Controls.Add(Me.chkSU)
        Me.Controles.Controls.Add(Me.Label5)
        Me.Controles.Controls.Add(Me.txtpassword)
        Me.Controles.Controls.Add(Me.Label4)
        Me.Controles.Controls.Add(Me.txtApMaterno)
        Me.Controles.Controls.Add(Me.Label3)
        Me.Controles.Controls.Add(Me.txtApPaterno)
        Me.Controles.Controls.Add(Me.Label2)
        Me.Controles.Controls.Add(Me.cmbResponsableDtVax)
        Me.Controles.Controls.Add(Me.Label1)
        Me.Controles.Controls.Add(Me.txtClaveResponsable)
        Me.Controles.Controls.Add(Me.Label8)
        Me.Controles.Controls.Add(Me.txtNombre)
        Me.Controles.Location = New System.Drawing.Point(12, 12)
        Me.Controles.Name = "Controles"
        Me.Controles.Size = New System.Drawing.Size(686, 267)
        Me.Controles.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Ap. Materno Responsable"
        '
        'txtApMaterno
        '
        Me.txtApMaterno.Location = New System.Drawing.Point(40, 152)
        Me.txtApMaterno.MaxLength = 50
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(194, 20)
        Me.txtApMaterno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Ap. Paterno Responsable"
        '
        'txtApPaterno
        '
        Me.txtApPaterno.Location = New System.Drawing.Point(271, 80)
        Me.txtApPaterno.MaxLength = 50
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(194, 20)
        Me.txtApPaterno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre Responsable DtVax"
        '
        'cmbResponsableDtVax
        '
        Me.cmbResponsableDtVax.FormattingEnabled = True
        Me.cmbResponsableDtVax.Location = New System.Drawing.Point(271, 152)
        Me.cmbResponsableDtVax.Name = "cmbResponsableDtVax"
        Me.cmbResponsableDtVax.Size = New System.Drawing.Size(269, 21)
        Me.cmbResponsableDtVax.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre Responsable"
        '
        'txtClaveResponsable
        '
        Me.txtClaveResponsable.Enabled = False
        Me.txtClaveResponsable.Location = New System.Drawing.Point(171, 11)
        Me.txtClaveResponsable.MaxLength = 50
        Me.txtClaveResponsable.Name = "txtClaveResponsable"
        Me.txtClaveResponsable.Size = New System.Drawing.Size(106, 20)
        Me.txtClaveResponsable.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Clave Responsable"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(40, 80)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(194, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Contraseña"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(40, 221)
        Me.txtpassword.MaxLength = 50
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(194, 20)
        Me.txtpassword.TabIndex = 25
        '
        'chkSU
        '
        Me.chkSU.AutoSize = True
        Me.chkSU.Location = New System.Drawing.Point(505, 83)
        Me.chkSU.Name = "chkSU"
        Me.chkSU.Size = New System.Drawing.Size(93, 17)
        Me.chkSU.TabIndex = 27
        Me.chkSU.Text = "Super Usuario"
        Me.chkSU.UseVisualStyleBackColor = True
        '
        'bImporte
        '
        Me.bImporte.AutoSize = True
        Me.bImporte.Location = New System.Drawing.Point(505, 33)
        Me.bImporte.Name = "bImporte"
        Me.bImporte.Size = New System.Drawing.Size(150, 17)
        Me.bImporte.TabIndex = 28
        Me.bImporte.Text = "Permitir Cambiar el Importe"
        Me.bImporte.UseVisualStyleBackColor = True
        '
        'chkPassword
        '
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Location = New System.Drawing.Point(271, 221)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(118, 17)
        Me.chkPassword.TabIndex = 29
        Me.chkPassword.Text = "Mostrar Contraseña"
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'frmDetCatResponsables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 346)
        Me.Controls.Add(Me.chkContinua)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Controles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetCatResponsables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Responsables [Detalle]"
        Me.Controles.ResumeLayout(False)
        Me.Controles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkContinua As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Controles As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbResponsableDtVax As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClaveResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents chkPassword As System.Windows.Forms.CheckBox
    Friend WithEvents bImporte As System.Windows.Forms.CheckBox
    Friend WithEvents chkSU As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
End Class
