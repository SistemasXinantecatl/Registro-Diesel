Imports System.Data.SqlClient

Public Class frmCorteXDia
    Dim sql As String
    Dim conn As New SqlConnection(connStringSql)
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim dt As New DataTable
        Dim cr As New rptCorteXDia
        Dim R As New Reporte
        Dim DataSet1 = New DataSet()
        sql = "SELECT [Fecha]  ,(SELECT (co.nomOperador+' '+co.ApPaterno+' '+co.ApMaterno) from CatOperadores as co where co.cveOperador=pxf.cveOperador) AS NomCompleto " _
            & ",pxf.[cveOperador],sum([Accidentes])[Accidentes],sum([Vidrios])[Vidrios] " _
            & ",sum([Infracciones])[Infracciones],sum([Fianza])[Fianza],sum([Infonavit])[Infonavit] " _
            & ",sum([Pendientes])[Pendientes] " _
            & "From [dbSistema].[dbo].[pagosXFueraDtVax] as pxf " _
            & "where Fecha='" & dtpFecha.Text & "' group by Fecha,pxf.cveOperador order by Fecha,pxf.cveOperador"

        Dim mda2 = New SqlDataAdapter(sql, conn)
        mda2.Fill(DataSet1, "CorteXDia")

        cr.DataDefinition.FormulaFields("NombreEmpresa").Text = "'Servicios Urbanos y Sub-Urbanos Xinantecatl S.A. de C.V.'"
        cr.DataDefinition.FormulaFields("RFC").Text = "'SUS 810803 QN0'"
        cr.SetDataSource(DataSet1)
        R.CrystalReportViewer1.ReportSource = cr
        'cr.PrintToPrinter(1, True, 0, 0)
        'R.MdiParent = Principal
        R.WindowState = FormWindowState.Maximized
        R.Show()
    End Sub
End Class