<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetRegTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetRegTicket))
        Me.chkContinua = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Controles = New System.Windows.Forms.Panel()
        Me.chkMediaVuelta = New System.Windows.Forms.CheckBox()
        Me.chkViajesEspeciales = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnImporte = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImpote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcveAutobus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbdestino = New System.Windows.Forms.ComboBox()
        Me.QrCodeImgControl1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.Controles.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkContinua
        '
        Me.chkContinua.AutoSize = True
        Me.chkContinua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContinua.Location = New System.Drawing.Point(26, 308)
        Me.chkContinua.Name = "chkContinua"
        Me.chkContinua.Size = New System.Drawing.Size(129, 20)
        Me.chkContinua.TabIndex = 73
        Me.chkContinua.Text = "Captura Continua"
        Me.chkContinua.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(659, 308)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(531, 308)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Controles
        '
        Me.Controles.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controles.Controls.Add(Me.chkMediaVuelta)
        Me.Controles.Controls.Add(Me.chkViajesEspeciales)
        Me.Controles.Controls.Add(Me.Label7)
        Me.Controles.Controls.Add(Me.Panel1)
        Me.Controles.Controls.Add(Me.btnImporte)
        Me.Controles.Controls.Add(Me.Label4)
        Me.Controles.Controls.Add(Me.txtImpote)
        Me.Controles.Controls.Add(Me.Label3)
        Me.Controles.Controls.Add(Me.txtcveAutobus)
        Me.Controles.Controls.Add(Me.Label2)
        Me.Controles.Controls.Add(Me.cmbdestino)
        Me.Controles.Location = New System.Drawing.Point(12, 23)
        Me.Controles.Name = "Controles"
        Me.Controles.Size = New System.Drawing.Size(797, 253)
        Me.Controles.TabIndex = 72
        '
        'chkMediaVuelta
        '
        Me.chkMediaVuelta.AutoSize = True
        Me.chkMediaVuelta.Enabled = False
        Me.chkMediaVuelta.Location = New System.Drawing.Point(655, 207)
        Me.chkMediaVuelta.Name = "chkMediaVuelta"
        Me.chkMediaVuelta.Size = New System.Drawing.Size(88, 17)
        Me.chkMediaVuelta.TabIndex = 32
        Me.chkMediaVuelta.Text = "Media Vuelta"
        Me.chkMediaVuelta.UseVisualStyleBackColor = True
        '
        'chkViajesEspeciales
        '
        Me.chkViajesEspeciales.AutoSize = True
        Me.chkViajesEspeciales.Location = New System.Drawing.Point(646, 136)
        Me.chkViajesEspeciales.Name = "chkViajesEspeciales"
        Me.chkViajesEspeciales.Size = New System.Drawing.Size(108, 17)
        Me.chkViajesEspeciales.TabIndex = 31
        Me.chkViajesEspeciales.Text = "Viajes Especiales"
        Me.chkViajesEspeciales.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(631, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 56)
        Me.Label7.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtHora)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Location = New System.Drawing.Point(3, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 220)
        Me.Panel1.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(120, 26)
        Me.txtFecha.MaxLength = 50
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(106, 20)
        Me.txtFecha.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Hora"
        '
        'txtHora
        '
        Me.txtHora.Enabled = False
        Me.txtHora.Location = New System.Drawing.Point(120, 64)
        Me.txtHora.MaxLength = 50
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(106, 20)
        Me.txtHora.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Responsable"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(120, 111)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(194, 20)
        Me.txtNombre.TabIndex = 3
        '
        'btnImporte
        '
        Me.btnImporte.Image = Global.Login.My.Resources.Resources.calculator
        Me.btnImporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImporte.Location = New System.Drawing.Point(447, 124)
        Me.btnImporte.Name = "btnImporte"
        Me.btnImporte.Size = New System.Drawing.Size(116, 38)
        Me.btnImporte.TabIndex = 5
        Me.btnImporte.Text = "Calcular Importe"
        Me.btnImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImporte.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Importe"
        '
        'txtImpote
        '
        Me.txtImpote.Enabled = False
        Me.txtImpote.Location = New System.Drawing.Point(447, 207)
        Me.txtImpote.MaxLength = 50
        Me.txtImpote.Name = "txtImpote"
        Me.txtImpote.Size = New System.Drawing.Size(194, 20)
        Me.txtImpote.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(442, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Autobus"
        '
        'txtcveAutobus
        '
        Me.txtcveAutobus.Location = New System.Drawing.Point(503, 26)
        Me.txtcveAutobus.MaxLength = 50
        Me.txtcveAutobus.Name = "txtcveAutobus"
        Me.txtcveAutobus.Size = New System.Drawing.Size(118, 20)
        Me.txtcveAutobus.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(442, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Destino"
        '
        'cmbdestino
        '
        Me.cmbdestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdestino.FormattingEnabled = True
        Me.cmbdestino.Location = New System.Drawing.Point(445, 84)
        Me.cmbdestino.Name = "cmbdestino"
        Me.cmbdestino.Size = New System.Drawing.Size(318, 21)
        Me.cmbdestino.TabIndex = 4
        '
        'QrCodeImgControl1
        '
        Me.QrCodeImgControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrCodeImgControl1.Image = CType(resources.GetObject("QrCodeImgControl1.Image"), System.Drawing.Image)
        Me.QrCodeImgControl1.Location = New System.Drawing.Point(296, 23)
        Me.QrCodeImgControl1.Name = "QrCodeImgControl1"
        Me.QrCodeImgControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrCodeImgControl1.Size = New System.Drawing.Size(231, 207)
        Me.QrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QrCodeImgControl1.TabIndex = 74
        Me.QrCodeImgControl1.TabStop = False
        Me.QrCodeImgControl1.Text = "QrCodeImgControl1"
        '
        'frmDetRegTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 351)
        Me.Controls.Add(Me.chkContinua)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Controles)
        Me.Controls.Add(Me.QrCodeImgControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDetRegTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ticket [Detalle]"
        Me.Controles.ResumeLayout(False)
        Me.Controles.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkContinua As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Controles As System.Windows.Forms.Panel
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImpote As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcveAutobus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbdestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnImporte As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkViajesEspeciales As System.Windows.Forms.CheckBox
    Friend WithEvents chkMediaVuelta As System.Windows.Forms.CheckBox
    Friend WithEvents QrCodeImgControl1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
End Class
