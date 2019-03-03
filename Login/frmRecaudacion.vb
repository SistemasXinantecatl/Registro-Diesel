Imports System.Data.SqlClient

Public Class frmRecaudacion
    Dim sql As String
    Dim conn As New SqlConnection(connStringSql)
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub frmRecaudacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOficina.Text = Oficina
        txtRecaudador.Text = NombreDtvax
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        sql = "SELECT * FROM MovRecaudaciones WHERE Fecha='" & txtFecha.Text & "' AND cveOficina=" & cveOficina & ""
        cmd.CommandText = sql
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            MessageBox.Show("Ya se Genero el Reporte de Recaudacion Total del Dia de Hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
            reader.Close()
            Exit Sub
        End If
        conn.Close()
        reader.Close()


        Call GenerarRecaudacionTotal()
        
    End Sub

    Private Sub GenerarRecaudacionTotal()
        If Not IsNumeric(txtImporteTotal.Text) Then
            MessageBox.Show("El Importe Depositado no es Numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtImporteTotal.Focus()
            Exit Sub
        End If


        If Not IsNumeric(txtImporteEfectivo.Text) Then
            MessageBox.Show("El Importe Efectivo No es Numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtImporteEfectivo.Focus()
            Exit Sub
        End If

        sql = "INSERT INTO MovRecaudaciones (Fecha,cveOficina,cveResponsable,ImporteDepositado,ImporteEfectivo) " & _
            "VALUES(@Fecha, @cveOficina, @cveResponsable, @ImporteDepositado, @ImporteEfectivo)"

        Using cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Fecha", txtFecha.Text)
            cmd.Parameters.AddWithValue("@cveOficina", cveOficina)
            cmd.Parameters.AddWithValue("@cveResponsable", cveResponsable)
            cmd.Parameters.AddWithValue("@ImporteDepositado", txtImporteTotal.Text)
            cmd.Parameters.AddWithValue("@ImporteEfectivo", txtImporteEfectivo.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using

        MessageBox.Show("Agregado con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

        Call MostrarRecaudacion()
    End Sub
    Private Sub MostrarRecaudacion()
        Dim dt As New DataTable
        Dim cr As New rptRecaudaciones
        Dim R As New Reporte
        Dim DataSet1 = New DataSet()

        sql = "SELECT Fecha,cveOficina,(SELECT Nombre FROM CatOficinasDtVax where Clave = cveoficina) as NombreOficina," & _
        "cveResponsable,(SELECT NomDtVax FROM CatResponsablesDtvax where Clave = cveResponsable) as NombreResponsable," & _
        "ImporteDepositado, ImporteEfectivo FROM MovRecaudaciones WHERE Fecha='" & txtFecha.Text & "' AND cveOficina=" & cveOficina & ""

        Dim mda2 = New SqlDataAdapter(sql, conn)
        mda2.Fill(DataSet1, "MovRecaudaciones")


        cr.DataDefinition.FormulaFields("NombreEmpresa").Text = "'Servicios Urbanos y Sub-Urbanos Xinantecatl S.A. de C.V.'"
        cr.DataDefinition.FormulaFields("RFC").Text = "'SUS 810803 QN0'"
        cr.DataDefinition.FormulaFields("dirCalle").Text = "'Cristobal Colon #212, Barrio de San Miguel Zinacantepec,'"
        cr.DataDefinition.FormulaFields("dirColonia").Text = "'Estado de México C.P. 51350'"
        cr.SetDataSource(DataSet1)
        R.CrystalReportViewer1.ReportSource = cr
        'cr.PrintToPrinter(1, False, 0, 0)
        R.MdiParent = Principal
        R.Show()
    End Sub

    Private Sub txtImporteTotal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteTotal.KeyPress
        txtImporteTotal.SelectedText = Solo_Numeros_float(e)
    End Sub

    Private Sub txtImporteEfectivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporteEfectivo.KeyPress
        txtImporteEfectivo.SelectedText = Solo_Numeros_float(e)
    End Sub
End Class