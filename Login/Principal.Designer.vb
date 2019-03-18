<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OficinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResponsablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraciónTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreDeDíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaciónDeTicketsRojosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelacionDeTicketsAzulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasRportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteResumenTicketsXFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleTicketsXFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteTicketsCanceladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CatalogoDestinosRojosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDestinosAzulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeAutobusesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalRecaudacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarRecaudacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirReporteRecaudacionTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosToolStripMenuItem, Me.GeneraciónTicket, Me.CierreDeDíaToolStripMenuItem, Me.ConsultasRportesToolStripMenuItem, Me.TotalRecaudacionToolStripMenuItem, Me.PagosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1134, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OficinasToolStripMenuItem, Me.ResponsablesToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.CatalogosToolStripMenuItem.Text = "Catalogos"
        Me.CatalogosToolStripMenuItem.Visible = False
        '
        'OficinasToolStripMenuItem
        '
        Me.OficinasToolStripMenuItem.Name = "OficinasToolStripMenuItem"
        Me.OficinasToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.OficinasToolStripMenuItem.Text = "Oficinas"
        '
        'ResponsablesToolStripMenuItem
        '
        Me.ResponsablesToolStripMenuItem.Name = "ResponsablesToolStripMenuItem"
        Me.ResponsablesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ResponsablesToolStripMenuItem.Text = "Responsables"
        '
        'GeneraciónTicket
        '
        Me.GeneraciónTicket.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuperUsuario, Me.RegistroTicketToolStripMenuItem})
        Me.GeneraciónTicket.Name = "GeneraciónTicket"
        Me.GeneraciónTicket.Size = New System.Drawing.Size(114, 20)
        Me.GeneraciónTicket.Text = "Generación Ticket"
        '
        'SuperUsuario
        '
        Me.SuperUsuario.Name = "SuperUsuario"
        Me.SuperUsuario.Size = New System.Drawing.Size(152, 22)
        Me.SuperUsuario.Text = "Super Usuario"
        Me.SuperUsuario.Visible = False
        '
        'RegistroTicketToolStripMenuItem
        '
        Me.RegistroTicketToolStripMenuItem.Name = "RegistroTicketToolStripMenuItem"
        Me.RegistroTicketToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistroTicketToolStripMenuItem.Text = "Registro Ticket"
        '
        'CierreDeDíaToolStripMenuItem
        '
        Me.CierreDeDíaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelaciónDeTicketsRojosToolStripMenuItem, Me.RelacionDeTicketsAzulesToolStripMenuItem})
        Me.CierreDeDíaToolStripMenuItem.Name = "CierreDeDíaToolStripMenuItem"
        Me.CierreDeDíaToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.CierreDeDíaToolStripMenuItem.Text = "Cierre de Día"
        '
        'RelaciónDeTicketsRojosToolStripMenuItem
        '
        Me.RelaciónDeTicketsRojosToolStripMenuItem.Name = "RelaciónDeTicketsRojosToolStripMenuItem"
        Me.RelaciónDeTicketsRojosToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RelaciónDeTicketsRojosToolStripMenuItem.Text = "Relación deTickets Rojos"
        '
        'RelacionDeTicketsAzulesToolStripMenuItem
        '
        Me.RelacionDeTicketsAzulesToolStripMenuItem.Name = "RelacionDeTicketsAzulesToolStripMenuItem"
        Me.RelacionDeTicketsAzulesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RelacionDeTicketsAzulesToolStripMenuItem.Text = "Relacion de Tickets Azules"
        '
        'ConsultasRportesToolStripMenuItem
        '
        Me.ConsultasRportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteResumenTicketsXFechaToolStripMenuItem, Me.DetalleTicketsXFechaToolStripMenuItem, Me.ReporteTicketsCanceladosToolStripMenuItem, Me.ToolStripSeparator1, Me.CatalogoDestinosRojosToolStripMenuItem, Me.CatalogoDestinosAzulesToolStripMenuItem, Me.CatalogoDeAutobusesToolStripMenuItem})
        Me.ConsultasRportesToolStripMenuItem.Name = "ConsultasRportesToolStripMenuItem"
        Me.ConsultasRportesToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.ConsultasRportesToolStripMenuItem.Text = "Consultas / Reportes"
        '
        'ReporteResumenTicketsXFechaToolStripMenuItem
        '
        Me.ReporteResumenTicketsXFechaToolStripMenuItem.Name = "ReporteResumenTicketsXFechaToolStripMenuItem"
        Me.ReporteResumenTicketsXFechaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ReporteResumenTicketsXFechaToolStripMenuItem.Text = "Resumen Tickets x Fecha"
        '
        'DetalleTicketsXFechaToolStripMenuItem
        '
        Me.DetalleTicketsXFechaToolStripMenuItem.Name = "DetalleTicketsXFechaToolStripMenuItem"
        Me.DetalleTicketsXFechaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.DetalleTicketsXFechaToolStripMenuItem.Text = "Detalle Tickets x Fecha"
        '
        'ReporteTicketsCanceladosToolStripMenuItem
        '
        Me.ReporteTicketsCanceladosToolStripMenuItem.Name = "ReporteTicketsCanceladosToolStripMenuItem"
        Me.ReporteTicketsCanceladosToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ReporteTicketsCanceladosToolStripMenuItem.Text = "Reporte Tickets Cancelados"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(216, 6)
        '
        'CatalogoDestinosRojosToolStripMenuItem
        '
        Me.CatalogoDestinosRojosToolStripMenuItem.Name = "CatalogoDestinosRojosToolStripMenuItem"
        Me.CatalogoDestinosRojosToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CatalogoDestinosRojosToolStripMenuItem.Text = "Catalogo Destinos Rojos"
        '
        'CatalogoDestinosAzulesToolStripMenuItem
        '
        Me.CatalogoDestinosAzulesToolStripMenuItem.Name = "CatalogoDestinosAzulesToolStripMenuItem"
        Me.CatalogoDestinosAzulesToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CatalogoDestinosAzulesToolStripMenuItem.Text = "Catalogo Destinos Azules"
        '
        'CatalogoDeAutobusesToolStripMenuItem
        '
        Me.CatalogoDeAutobusesToolStripMenuItem.Name = "CatalogoDeAutobusesToolStripMenuItem"
        Me.CatalogoDeAutobusesToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CatalogoDeAutobusesToolStripMenuItem.Text = "Catalogo de Autobuses"
        '
        'TotalRecaudacionToolStripMenuItem
        '
        Me.TotalRecaudacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarRecaudacionToolStripMenuItem, Me.ImprimirReporteRecaudacionTotalToolStripMenuItem})
        Me.TotalRecaudacionToolStripMenuItem.Name = "TotalRecaudacionToolStripMenuItem"
        Me.TotalRecaudacionToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.TotalRecaudacionToolStripMenuItem.Text = "Total Recaudacion"
        '
        'AgregarRecaudacionToolStripMenuItem
        '
        Me.AgregarRecaudacionToolStripMenuItem.Name = "AgregarRecaudacionToolStripMenuItem"
        Me.AgregarRecaudacionToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.AgregarRecaudacionToolStripMenuItem.Text = "Agregar Recaudacion"
        '
        'ImprimirReporteRecaudacionTotalToolStripMenuItem
        '
        Me.ImprimirReporteRecaudacionTotalToolStripMenuItem.Name = "ImprimirReporteRecaudacionTotalToolStripMenuItem"
        Me.ImprimirReporteRecaudacionTotalToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.ImprimirReporteRecaudacionTotalToolStripMenuItem.Text = "Imprimir Reporte Recaudacion Total"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaldosToolStripMenuItem})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.PagosToolStripMenuItem.Text = "Pagos "
        '
        'SaldosToolStripMenuItem
        '
        Me.SaldosToolStripMenuItem.Name = "SaldosToolStripMenuItem"
        Me.SaldosToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.SaldosToolStripMenuItem.Text = "Saldos "
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.IMG_2798
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1134, 593)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CatalogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OficinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResponsablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneraciónTicket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuperUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroTicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreDeDíaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelaciónDeTicketsRojosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelacionDeTicketsAzulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasRportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDestinosRojosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDestinosAzulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeAutobusesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalRecaudacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarRecaudacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirReporteRecaudacionTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteResumenTicketsXFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetalleTicketsXFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteTicketsCanceladosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaldosToolStripMenuItem As ToolStripMenuItem
End Class
