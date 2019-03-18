<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoOperadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagoOperadores))
        Me.txtCobAcc = New System.Windows.Forms.TextBox()
        Me.cmbOper = New System.Windows.Forms.ComboBox()
        Me.labCobOper = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCobVid = New System.Windows.Forms.TextBox()
        Me.txtCobInf = New System.Windows.Forms.TextBox()
        Me.txtCobFian = New System.Windows.Forms.TextBox()
        Me.txtCobInfo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCobPend = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPagPend = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPagInfo = New System.Windows.Forms.TextBox()
        Me.txtPagFian = New System.Windows.Forms.TextBox()
        Me.txtPagInf = New System.Windows.Forms.TextBox()
        Me.txtPagVid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPagAcc = New System.Windows.Forms.TextBox()
        Me.txtXpPen = New System.Windows.Forms.TextBox()
        Me.txtXpInfo = New System.Windows.Forms.TextBox()
        Me.txtXpFia = New System.Windows.Forms.TextBox()
        Me.txtXpInf = New System.Windows.Forms.TextBox()
        Me.txtXpVid = New System.Windows.Forms.TextBox()
        Me.txtXpAcc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCobAcc
        '
        Me.txtCobAcc.Location = New System.Drawing.Point(52, 170)
        Me.txtCobAcc.Name = "txtCobAcc"
        Me.txtCobAcc.Size = New System.Drawing.Size(65, 20)
        Me.txtCobAcc.TabIndex = 0
        '
        'cmbOper
        '
        Me.cmbOper.FormattingEnabled = True
        Me.cmbOper.Location = New System.Drawing.Point(96, 73)
        Me.cmbOper.Name = "cmbOper"
        Me.cmbOper.Size = New System.Drawing.Size(408, 21)
        Me.cmbOper.TabIndex = 1
        '
        'labCobOper
        '
        Me.labCobOper.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.labCobOper.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labCobOper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labCobOper.Location = New System.Drawing.Point(129, 20)
        Me.labCobOper.Name = "labCobOper"
        Me.labCobOper.Size = New System.Drawing.Size(351, 23)
        Me.labCobOper.TabIndex = 2
        Me.labCobOper.Text = "Saldos de Operadores"
        Me.labCobOper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(159, 404)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(367, 404)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(216, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Deuda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(49, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Accidentes"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(131, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Vidrios"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(218, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Infracciones"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(304, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fianza"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(382, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Infonavit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCobVid
        '
        Me.txtCobVid.Location = New System.Drawing.Point(134, 170)
        Me.txtCobVid.Name = "txtCobVid"
        Me.txtCobVid.Size = New System.Drawing.Size(65, 20)
        Me.txtCobVid.TabIndex = 11
        '
        'txtCobInf
        '
        Me.txtCobInf.Location = New System.Drawing.Point(221, 170)
        Me.txtCobInf.Name = "txtCobInf"
        Me.txtCobInf.Size = New System.Drawing.Size(65, 20)
        Me.txtCobInf.TabIndex = 12
        '
        'txtCobFian
        '
        Me.txtCobFian.Location = New System.Drawing.Point(307, 170)
        Me.txtCobFian.Name = "txtCobFian"
        Me.txtCobFian.Size = New System.Drawing.Size(65, 20)
        Me.txtCobFian.TabIndex = 13
        '
        'txtCobInfo
        '
        Me.txtCobInfo.Location = New System.Drawing.Point(385, 170)
        Me.txtCobInfo.Name = "txtCobInfo"
        Me.txtCobInfo.Size = New System.Drawing.Size(65, 20)
        Me.txtCobInfo.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(466, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Pendientes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCobPend
        '
        Me.txtCobPend.Location = New System.Drawing.Point(469, 170)
        Me.txtCobPend.Name = "txtCobPend"
        Me.txtCobPend.Size = New System.Drawing.Size(65, 20)
        Me.txtCobPend.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(184, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 30)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Pagos a Efectuar"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPagPend
        '
        Me.txtPagPend.Location = New System.Drawing.Point(469, 265)
        Me.txtPagPend.Name = "txtPagPend"
        Me.txtPagPend.Size = New System.Drawing.Size(65, 20)
        Me.txtPagPend.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(443, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 23)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Pago Pendientes"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPagInfo
        '
        Me.txtPagInfo.Location = New System.Drawing.Point(385, 265)
        Me.txtPagInfo.Name = "txtPagInfo"
        Me.txtPagInfo.Size = New System.Drawing.Size(65, 20)
        Me.txtPagInfo.TabIndex = 29
        '
        'txtPagFian
        '
        Me.txtPagFian.Location = New System.Drawing.Point(307, 265)
        Me.txtPagFian.Name = "txtPagFian"
        Me.txtPagFian.Size = New System.Drawing.Size(65, 20)
        Me.txtPagFian.TabIndex = 28
        '
        'txtPagInf
        '
        Me.txtPagInf.Location = New System.Drawing.Point(221, 265)
        Me.txtPagInf.Name = "txtPagInf"
        Me.txtPagInf.Size = New System.Drawing.Size(65, 20)
        Me.txtPagInf.TabIndex = 27
        '
        'txtPagVid
        '
        Me.txtPagVid.Location = New System.Drawing.Point(134, 265)
        Me.txtPagVid.Name = "txtPagVid"
        Me.txtPagVid.Size = New System.Drawing.Size(65, 20)
        Me.txtPagVid.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(359, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Pago Infonavit"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(286, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 23)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Pago Fianza"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(186, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 23)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Pago Infracciones"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(113, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 23)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Pago Vidrios"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(11, 239)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 23)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Pago Accidentes"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPagAcc
        '
        Me.txtPagAcc.Location = New System.Drawing.Point(51, 265)
        Me.txtPagAcc.Name = "txtPagAcc"
        Me.txtPagAcc.Size = New System.Drawing.Size(65, 20)
        Me.txtPagAcc.TabIndex = 20
        '
        'txtXpPen
        '
        Me.txtXpPen.Location = New System.Drawing.Point(469, 355)
        Me.txtXpPen.Name = "txtXpPen"
        Me.txtXpPen.Size = New System.Drawing.Size(65, 20)
        Me.txtXpPen.TabIndex = 45
        '
        'txtXpInfo
        '
        Me.txtXpInfo.Location = New System.Drawing.Point(385, 355)
        Me.txtXpInfo.Name = "txtXpInfo"
        Me.txtXpInfo.Size = New System.Drawing.Size(65, 20)
        Me.txtXpInfo.TabIndex = 43
        '
        'txtXpFia
        '
        Me.txtXpFia.Location = New System.Drawing.Point(307, 355)
        Me.txtXpFia.Name = "txtXpFia"
        Me.txtXpFia.Size = New System.Drawing.Size(65, 20)
        Me.txtXpFia.TabIndex = 42
        '
        'txtXpInf
        '
        Me.txtXpInf.Location = New System.Drawing.Point(221, 355)
        Me.txtXpInf.Name = "txtXpInf"
        Me.txtXpInf.Size = New System.Drawing.Size(65, 20)
        Me.txtXpInf.TabIndex = 41
        '
        'txtXpVid
        '
        Me.txtXpVid.Location = New System.Drawing.Point(134, 355)
        Me.txtXpVid.Name = "txtXpVid"
        Me.txtXpVid.Size = New System.Drawing.Size(65, 20)
        Me.txtXpVid.TabIndex = 40
        '
        'txtXpAcc
        '
        Me.txtXpAcc.Location = New System.Drawing.Point(52, 355)
        Me.txtXpAcc.Name = "txtXpAcc"
        Me.txtXpAcc.Size = New System.Drawing.Size(65, 20)
        Me.txtXpAcc.TabIndex = 34
        '
        'Label24
        '
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label24.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(216, 300)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(156, 30)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Por Pagar"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPagoOperadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(559, 441)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtXpPen)
        Me.Controls.Add(Me.txtXpInfo)
        Me.Controls.Add(Me.txtXpFia)
        Me.Controls.Add(Me.txtXpInf)
        Me.Controls.Add(Me.txtXpVid)
        Me.Controls.Add(Me.txtXpAcc)
        Me.Controls.Add(Me.txtPagPend)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPagInfo)
        Me.Controls.Add(Me.txtPagFian)
        Me.Controls.Add(Me.txtPagInf)
        Me.Controls.Add(Me.txtPagVid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtPagAcc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCobPend)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCobInfo)
        Me.Controls.Add(Me.txtCobFian)
        Me.Controls.Add(Me.txtCobInf)
        Me.Controls.Add(Me.txtCobVid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.labCobOper)
        Me.Controls.Add(Me.cmbOper)
        Me.Controls.Add(Me.txtCobAcc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPagoOperadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldos de Operadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCobAcc As TextBox
    Friend WithEvents cmbOper As ComboBox
    Friend WithEvents labCobOper As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCobVid As TextBox
    Friend WithEvents txtCobInf As TextBox
    Friend WithEvents txtCobFian As TextBox
    Friend WithEvents txtCobInfo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCobPend As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPagPend As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPagInfo As TextBox
    Friend WithEvents txtPagFian As TextBox
    Friend WithEvents txtPagInf As TextBox
    Friend WithEvents txtPagVid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPagAcc As TextBox
    Friend WithEvents txtXpPen As TextBox
    Friend WithEvents txtXpInfo As TextBox
    Friend WithEvents txtXpFia As TextBox
    Friend WithEvents txtXpInf As TextBox
    Friend WithEvents txtXpVid As TextBox
    Friend WithEvents txtXpAcc As TextBox
    Friend WithEvents Label24 As Label
End Class
