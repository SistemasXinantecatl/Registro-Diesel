<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetCatOficinas
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
        Me.Controles = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOficinaDtVax = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClaveOficina = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.chkContinua = New System.Windows.Forms.CheckBox()
        Me.Controles.SuspendLayout()
        Me.SuspendLayout()
        '
        'Controles
        '
        Me.Controles.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controles.Controls.Add(Me.Label2)
        Me.Controles.Controls.Add(Me.cmbOficinaDtVax)
        Me.Controles.Controls.Add(Me.Label1)
        Me.Controles.Controls.Add(Me.txtClaveOficina)
        Me.Controles.Controls.Add(Me.Label8)
        Me.Controles.Controls.Add(Me.txtNombre)
        Me.Controles.Location = New System.Drawing.Point(12, 12)
        Me.Controles.Name = "Controles"
        Me.Controles.Size = New System.Drawing.Size(367, 197)
        Me.Controles.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre Oficina DtVax"
        '
        'cmbOficinaDtVax
        '
        Me.cmbOficinaDtVax.FormattingEnabled = True
        Me.cmbOficinaDtVax.Location = New System.Drawing.Point(40, 150)
        Me.cmbOficinaDtVax.Name = "cmbOficinaDtVax"
        Me.cmbOficinaDtVax.Size = New System.Drawing.Size(269, 21)
        Me.cmbOficinaDtVax.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre Oficina"
        '
        'txtClaveOficina
        '
        Me.txtClaveOficina.Location = New System.Drawing.Point(40, 30)
        Me.txtClaveOficina.MaxLength = 50
        Me.txtClaveOficina.Name = "txtClaveOficina"
        Me.txtClaveOficina.Size = New System.Drawing.Size(269, 20)
        Me.txtClaveOficina.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Clave Oficina"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(40, 91)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(269, 20)
        Me.txtNombre.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(284, 228)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 23)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(174, 228)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 23)
        Me.btnAceptar.TabIndex = 31
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'chkContinua
        '
        Me.chkContinua.AutoSize = True
        Me.chkContinua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContinua.Location = New System.Drawing.Point(12, 231)
        Me.chkContinua.Name = "chkContinua"
        Me.chkContinua.Size = New System.Drawing.Size(129, 20)
        Me.chkContinua.TabIndex = 65
        Me.chkContinua.Text = "Captura Continua"
        Me.chkContinua.UseVisualStyleBackColor = True
        '
        'frmDetCatOficinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 270)
        Me.Controls.Add(Me.chkContinua)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Controles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetCatOficinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catlogo de Oficinas [Detalle]"
        Me.Controles.ResumeLayout(False)
        Me.Controles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Controles As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOficinaDtVax As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClaveOficina As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents chkContinua As System.Windows.Forms.CheckBox
End Class
