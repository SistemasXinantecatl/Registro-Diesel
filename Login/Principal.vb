Imports System.Data.SqlClient
Public Class Principal
    Dim conn As New SqlConnection(connStringSql)
    Dim Condicion As String
    Dim Rol As String
    Dim Destino, encabezado As String
    Dim reader As SqlDataReader
    Dim cmd As New SqlCommand()
    Dim sql As String
    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ObtenerOficina()
        MyBase.Text = "SISTEMA REGISTRO DE TICKETS DIESEL  " + "USUARIO : [" + UsuarioLogin + "] " + "  OFICINA : [" + Oficina + "]"
        If Su = True Then
            SuperUsuario.Visible = True
            CatalogosToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub ObtenerOficina()
        Sql = " SELECT * from CatOficinasDtvax WHERE Nombre = @clave"

        cmd.CommandText = Sql
        cmd.Parameters.AddWithValue("@clave", Oficina)
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            cveOficina = reader("clave")
        End If
        conn.Close()
        reader.Close()
        cmd.Parameters.Clear()
    End Sub
    Private Sub OficinasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OficinasToolStripMenuItem.Click
        frmCatOficinas.MdiParent = Me
        frmCatOficinas.Show()
    End Sub

    Private Sub ResponsablesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResponsablesToolStripMenuItem.Click
        frmCatResponsables.MdiParent = Me
        frmCatResponsables.Show()
    End Sub

    Private Sub RegistroTicketToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroTicketToolStripMenuItem.Click
        frmRegTicket.MdiParent = Me
        frmRegTicket.Show()
    End Sub

    Private Sub SuperUsuario_Click(sender As System.Object, e As System.EventArgs) Handles SuperUsuario.Click
        frmSuperUsuario.MdiParent = Me
        frmSuperUsuario.Show()
    End Sub

    Private Sub RelaciónDeTicketsRojosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RelaciónDeTicketsRojosToolStripMenuItem.Click
        Rol = "Rol de Excelencia"
        Condicion = "where (cveautobus<800 and cveautobus<>4) and Fecha ='" & Date.Now.ToString("dd/MM/yyyy") & "' and Status<>'C' and cveOficina='" & cveOficina & "' order by cveAutobus"
        Call Relacion()
    End Sub

    Private Sub RelacionDeTicketsAzulesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionDeTicketsAzulesToolStripMenuItem.Click
        Rol = "Rol de Autobuses Azules"
        Condicion = "where (cveautobus>800 or cveautobus=4) and Fecha ='" & Date.Now.ToString("dd/MM/yyyy") & "'  and Status<>'C' and cveOficina='" & cveOficina & "' order by cveAutobus"
        Call Relacion()
    End Sub

    Private Sub Relacion()
        Dim dt As New DataTable
        Dim cr As New RelacionxDia
        Dim R As New Reporte
        Dim DataSet1 = New DataSet()
        Dim conn As New SqlConnection(connStringSql)


        sql = "SELECT '" & Oficina & "' as Oficina, " & _
        "'" & cveOficina & "' as cveOficina, " & _
        "'" & Responsable & "' as Recaudador,'" & cveResponsable & "' as cveRecaudador ,cveautobus,Importe " & _
        " FROM MovDiesel  "

        sql = sql + Condicion

        Dim mda2 = New SqlClient.SqlDataAdapter(sql, conn)
        mda2.Fill(DataSet1, "RelacionxDia")


        cr.DataDefinition.FormulaFields("NombreEmpresa").Text = "'Servicios Urbanos y Sub-Urbanos Xinantecatl S.A. de C.V.'"
        cr.DataDefinition.FormulaFields("RFC").Text = "'SUS 810803 QN0'"
        cr.DataDefinition.FormulaFields("dirCalle").Text = "'Cristobal Colon #212, Barrio de San Miguel Zinacantepec,'"
        cr.DataDefinition.FormulaFields("dirColonia").Text = "'Estado de México C.P. 51350'"
        cr.DataDefinition.FormulaFields("Rol").Text = "'" & Rol & "'"
        cr.SetDataSource(DataSet1)
        R.CrystalReportViewer1.ReportSource = cr
        'cr.PrintToPrinter(1, False, 0, 0)
        R.MdiParent = Me
        R.WindowState = FormWindowState.Maximized
        R.Show()
    End Sub

    Private Sub CatalogoDeAutobusesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDeAutobusesToolStripMenuItem.Click
        Dim dt As New DataTable
        Dim cr As New CatAutobuses
        Dim R As New Reporte
        Dim DataSet1 = New DataSet()
        Dim conn As New SqlConnection(connStringSql)
        Dim cmd As New SqlCommand()

        Dim sql As String

        sql = "SELECT cveautobus,Permisionario,P.ApPaterno,P.ApMaterno,P.Nombre, " & _
        "Case WHEN cveautobus > 800 or cveautobus=4 THEN 'Rol Azul' ELSE 'Rol de Excelencia' END AS TipoRol " & _
        "FROM catAutobuses A left outer join CatPermisionarios P on A.cvePermisionario=P.Permisionario " & _
        "order by A.cveAutobus "

        sql = sql + Condicion

        Dim mda2 = New SqlClient.SqlDataAdapter(sql, conn)
        mda2.Fill(DataSet1, "Autobuses")
        cr.SetDataSource(DataSet1)
        R.CrystalReportViewer1.ReportSource = cr
        R.MdiParent = Me
        R.WindowState = FormWindowState.Maximized
        R.Show()
    End Sub

    Private Sub destinos()
        Dim dt As New DataTable
        Dim cr As New CatDestinos
        Dim R As New Reporte
        Dim DataSet1 = New DataSet()
        Dim conn As New SqlConnection(connStringSql)
        Dim cmd As New SqlCommand()

        Dim sql As String

        sql = "SELECT cveDestino,Descripcion,Diesel1,Diesel2,Diesel3,Diesel4 " & _
        "FROM " & Destino & "  " & _
        "order by cveDestino "

        sql = sql + Condicion

        Dim mda2 = New SqlClient.SqlDataAdapter(sql, conn)
        mda2.Fill(DataSet1, "Destinos")

        cr.SetDataSource(DataSet1)
        cr.DataDefinition.FormulaFields("Destino").Text = "'" & encabezado & "'"
        R.CrystalReportViewer1.ReportSource = cr
        R.MdiParent = Me
        R.WindowState = FormWindowState.Maximized
        R.Show()
    End Sub

    Private Sub CatalogoDestinosRojosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDestinosRojosToolStripMenuItem.Click
        Destino = "catDestinosCr"
        encabezado = "Catalogo de Destino de Autobuses Azules"
        Call destinos()
    End Sub

    Private Sub CatalogoDestinosAzulesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatalogoDestinosAzulesToolStripMenuItem.Click
        Destino = "catDestinosAzules"
        encabezado = "Catalogo de Destino de Autobuses de Excelencia"
        Call destinos()
    End Sub

    Private Sub EnviarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EnviarCorreo.ShowDialog()
    End Sub

    Private Sub GenerarExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGeneraExcel.ShowDialog()
    End Sub

    Private Sub AgregarRecaudacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarRecaudacionToolStripMenuItem.Click
        frmRecaudacion.ShowDialog()
    End Sub

    Private Sub ImprimirReporteRecaudacionTotalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirReporteRecaudacionTotalToolStripMenuItem.Click
        Dim dt As New DataTable
        Dim cr As New rptRecaudaciones
        Dim R As New Reporte
        Dim DataSet1 = New DataSet()

        sql = "SELECT Fecha,cveOficina,(SELECT Nombre FROM CatOficinasDtVax where Clave = cveoficina) as NombreOficina," & _
        "cveResponsable,(SELECT NomDtVax FROM CatResponsablesDtvax where Clave = cveResponsable) as NombreResponsable," & _
        "ImporteDepositado, ImporteEfectivo FROM MovRecaudaciones WHERE Fecha='" & Date.Now.ToString("dd/MM/yyyy") & "' AND cveOficina=" & cveOficina & ""

        Dim connSub As New SqlConnection(connStringSql)
        connSub.Open()
        cmd = New SqlCommand(sql, connSub)
        reader = cmd.ExecuteReader
        If reader.HasRows = False Then
            MessageBox.Show("No se ha Generado la Recaudacion del Día", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            reader.Close()
            connSub.Close()
            Exit Sub
        End If
        reader.Close()
        connSub.Close()

        Dim mda2 = New SqlDataAdapter(sql, conn)
        mda2.Fill(DataSet1, "MovRecaudaciones")


        cr.DataDefinition.FormulaFields("NombreEmpresa").Text = "'Servicios Urbanos y Sub-Urbanos Xinantecatl S.A. de C.V.'"
        cr.DataDefinition.FormulaFields("RFC").Text = "'SUS 810803 QN0'"
        cr.DataDefinition.FormulaFields("dirCalle").Text = "'Cristobal Colon #212, Barrio de San Miguel Zinacantepec,'"
        cr.DataDefinition.FormulaFields("dirColonia").Text = "'Estado de México C.P. 51350'"
        cr.SetDataSource(DataSet1)
        R.CrystalReportViewer1.ReportSource = cr
        'cr.PrintToPrinter(1, False, 0, 0)
        R.MdiParent = Me
        R.WindowState = FormWindowState.Maximized
        R.Show()
    End Sub

    Private Sub ReporteResumenTicketsXFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteResumenTicketsXFechaToolStripMenuItem.Click
        frmReporte.MdiParent = Me
        frmReporte.Text = "Resumen de tickets x Día"
        frmReporte.reporte = "RESUMEN"
        frmReporte.Show()
    End Sub

    Private Sub DetalleTicketsXFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalleTicketsXFechaToolStripMenuItem.Click
        frmReporte.MdiParent = Me
        frmReporte.Text = "Detalle de tickets x Día"
        frmReporte.reporte = "DETALLE"
        frmReporte.Show()
    End Sub

    Private Sub ReporteTicketsCanceladosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteTicketsCanceladosToolStripMenuItem.Click
        frmReporte.MdiParent = Me
        frmReporte.Text = "Tickets Cancelados"
        frmReporte.txtcveautobus.Enabled = False
        frmReporte.reporte = "CANCELADOS"
        frmReporte.Show()
    End Sub
End Class