Imports System.Data.SqlClient
Public Class frmReporte
    Dim sql As String
    Dim conn As New SqlConnection(connStringSql)
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Public reporte As String

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If reporte = "RESUMEN" Then
            Dim dt As New DataTable
            Dim cr As New rptResumenTickets
            Dim R As New Reporte
            Dim DataSet1 = New DataSet()
            sql = "SELECT Fecha,cveautobus, SUM(IMPORTE) as DieselTotal, SUM(NoVuelta) AS TotalVueltas " & _
            "FROM MovDiesel "

            If txtcveautobus.Text <> "" Then
                sql = sql + "where Fecha>='" & dtpFechaIni.Value.ToString("dd/MM/yyyy") & "' and Fecha<='" & dptFechaFin.Value.ToString("dd/MM/yyyy") & "' and Status<>'C' and cveautobus= " & txtcveautobus.Text & " " & _
            "GROUP BY Fecha,cveautobus ORDER BY cveautobus"
            Else
                sql = sql + "where Fecha>='" & dtpFechaIni.Value.ToString("dd/MM/yyyy") & "' and Fecha<='" & dptFechaFin.Value.ToString("dd/MM/yyyy") & "' and Status<>'C' " & _
            "GROUP BY Fecha,cveautobus ORDER BY cveautobus"
            End If

            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read = False Then
                MessageBox.Show("No hay Datos en es Rango de Fechas", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                reader.Close()
                Exit Sub
            End If
            conn.Close()
            reader.Close()


            Dim mda2 = New SqlDataAdapter(sql, conn)
            mda2.Fill(DataSet1, "ResumenTickets")


            cr.DataDefinition.FormulaFields("Rango").Text = "'Resumen de Tickets del " & dtpFechaIni.Value.ToString("dd/MM/yyyy") & " al " & dptFechaFin.Value.ToString("dd/MM/yyyy") & " '"
            cr.SetDataSource(DataSet1)
            R.CrystalReportViewer1.ReportSource = cr
            Me.Close()
            R.MdiParent = Principal
            R.WindowState = FormWindowState.Maximized
            R.Show()


        ElseIf reporte = "DETALLE" Then
            Dim dt As New DataTable
            Dim cr As New rptDetalleTickets
            Dim R As New Reporte
            Dim DataSet1 = New DataSet()
            sql = "SELECT Identificador,Fecha,cveautobus,Importe, NoVuelta as cantidadVueltas," & _
            "CASE WHEN cveautobus > 800 or cveautobus=4 " & _
            "THEN (SELECT  Descripcion FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " & _
            "ELSE (SELECT  Descripcion FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) END AS Destino, " & _
            "(SELECT NomDtVax FROM CatResponsablesDtVax WHERE Clave = cveRecaudador) as recaudador " & _
            "FROM MovDiesel "

            If txtcveautobus.Text <> "" Then
                sql = sql + "where Fecha>='" & dtpFechaIni.Value.ToString("dd/MM/yyyy") & "' and Fecha<='" & dptFechaFin.Value.ToString("dd/MM/yyyy") & "' and cveautobus= " & txtcveautobus.Text & " " & _
            "ORDER BY cveautobus"
            Else
                sql = sql + "where Fecha>='" & dtpFechaIni.Value.ToString("dd/MM/yyyy") & "' and Fecha<='" & dptFechaFin.Value.ToString("dd/MM/yyyy") & "' " & _
            "ORDER BY cveautobus"
            End If


            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read = False Then
                MessageBox.Show("No hay Datos en es Rango de Fechas", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                reader.Close()
                Exit Sub
            End If
            conn.Close()
            reader.Close()


            Dim mda2 = New SqlDataAdapter(sql, conn)
            mda2.Fill(DataSet1, "DetalleTickets")

            cr.DataDefinition.FormulaFields("Rango").Text = "'Detalle de Tickets del " & dtpFechaIni.Value.ToString("dd/MM/yyyy") & " al " & dptFechaFin.Value.ToString("dd/MM/yyyy") & " '"
            cr.SetDataSource(DataSet1)
            R.CrystalReportViewer1.ReportSource = cr
            Me.Close()
            R.MdiParent = Principal
            R.WindowState = FormWindowState.Maximized
            R.Show()

        ElseIf reporte = "CANCELADOS" Then
            txtcveautobus.Text = ""
            Dim dt As New DataTable
            Dim cr As New rptTicketsCancelados
            Dim R As New Reporte
            Dim DataSet1 = New DataSet()
            sql = "SELECT Identificador,Fecha,cveautobus,Importe, NoVuelta as cantidadVueltas," & _
            "CASE WHEN cveautobus > 800 or cveautobus=4 " & _
            "THEN (SELECT  Descripcion FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " & _
            "ELSE (SELECT  Descripcion FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) END AS Destino, " & _
            "(SELECT NomDtVax FROM CatResponsablesDtVax WHERE Clave = cveRecaudador) as recaudador " & _
            "FROM MovDiesel "

            If txtcveautobus.Text <> "" Then
                sql = sql + "where Fecha>='" & dtpFechaIni.Value.ToString("dd/MM/yyyy") & "' and Fecha<='" & dptFechaFin.Value.ToString("dd/MM/yyyy") & "' and cveautobus= " & txtcveautobus.Text & " " & _
            "ORDER BY cveautobus"
            Else
                sql = sql + "where Fecha>='" & dtpFechaIni.Value.ToString("dd/MM/yyyy") & "' and Fecha<='" & dptFechaFin.Value.ToString("dd/MM/yyyy") & "' AND status='C' " & _
            "ORDER BY cveautobus"
            End If

            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read = False Then
                MessageBox.Show("No hay Datos en es Rango de Fechas", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                reader.Close()
                Exit Sub
            End If
            conn.Close()
            reader.Close()

            Dim mda2 = New SqlDataAdapter(sql, conn)
            mda2.Fill(DataSet1, "TicketsCancelados")
            cr.DataDefinition.FormulaFields("Rango").Text = "'Detalle de Tickets Cancelados del " & dtpFechaIni.Value.ToString("dd/MM/yyyy") & " al " & dptFechaFin.Value.ToString("dd/MM/yyyy") & " '"
            cr.SetDataSource(DataSet1)
            R.CrystalReportViewer1.ReportSource = cr
            Me.Close()
            R.MdiParent = Principal
            R.WindowState = FormWindowState.Maximized
            R.Show()
        End If

    End Sub

    Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFechaIni.Value = Date.Now
        dptFechaFin.Value = Date.Now
    End Sub
End Class