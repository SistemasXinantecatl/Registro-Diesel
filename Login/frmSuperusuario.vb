Imports System.Data.SqlClient
Imports System.IO

Public Class frmSuperUsuario
    Dim conn As New SqlConnection(connStringSql)
    Dim sql As String
    Dim clave As String
    Dim Fecha As Date
    Dim Identificador
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim cveOfi As String
    Dim bActualiza As Integer

    Private Sub frm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.dgview.Width = 0.8 * Me.Width
        Me.dgview.Height = 0.7 * Me.Height
    End Sub

    Public Sub ActualizaVista()
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        clave = ""
        dgview.DataSource = Nothing
        dgview.Refresh()

        ' Consultar Registros 
        sql = "SELECT CONVERT (char(10), movdiesel.Fecha, 103) as Fecha, CONVERT(nvarchar(8), movdiesel.Hora, 108) AS Hora, movdiesel.cveautobus, " & _
        "CASE " & _
        "WHEN movdiesel.Tipo_Cr_A = 'Cr' " & _
        "THEN 'Autobus de Excelencia' " & _
        "ELSE 'Autobus Azul' " & _
        "END AS Tipo, " & _
        "(SELECT  nomdtvax FROM CatResponsablesDtVax WHERE CatResponsablesDtVax.Clave=movdiesel.cveRecaudador) as NomResponsableDtVax," & _
        "CASE " & _
        "WHEN cveautobus > 800 or cveautobus=4 " & _
        "THEN (SELECT  Descripcion FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " & _
        "ELSE (SELECT  Descripcion FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) " & _
        "END AS Destino, " & _
        "Importe, Status, Identificador,NoReimpresiones, (SELECT Nombre FROM CatOficinasDtVax WHERE CatOficinasDtVax.Clave=movdiesel.cveOficina) as Oficina," & _
        "MovDiesel.NoVuelta as CantidadVuelta, movdiesel.cveOficina, movDiesel.id_auto, MovDiesel.bActualiza  FROM MovDiesel WHERE fecha='" & Date.Now.ToString("dd/MM/yyyy") & "' ORDER BY Fecha desc,hora"

        Dim mda = New SqlDataAdapter(sql, conn)
        Dim ds = New DataSet()

        mda.Fill(ds, "MovDiesel")
        dgview.DataSource = ds
        dgview.DataMember = "MovDiesel"
        Me.dgview.Columns(3).HeaderText = "Tipo Autobus"
        Me.dgview.Columns(4).HeaderText = "Recaudador"
        Me.dgview.Columns(5).HeaderText = "Destino"
        Me.dgview.Columns(8).Visible = False
        Me.dgview.Columns(12).Visible = False
        Me.dgview.Columns(13).Visible = False
        Me.dgview.Columns(14).Visible = False
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dgview_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgview.CellClick
        Dim i As Integer
        Try
            i = dgview.CurrentRow.Index
            clave = dgview.Item(8, i).Value
            Fecha = dgview.Item(0, i).Value
            cveOfi = dgview.Item(12, i).Value
            bActualiza = dgview.Item(14, i).Value
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click

        If clave <> "" Then
            sql = "SELECT * FROM MovDiesel WHERE identificador='" & clave & "'"
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read Then
                If reader("Status") = "C" Then
                    MessageBox.Show("El Ticket Se Cancelo", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    reader.Close()
                    Exit Sub
                End If
            End If
            conn.Close()
            reader.Close()

            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Imprimir()
            Cursor = System.Windows.Forms.Cursors.Default
        ElseIf clave = "" Then
            MessageBox.Show("No se Ha Seleccionado un Registro para Imprimir", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Imprimir()

        If clave <> "" Then
            Dim i As Integer = dgview.CurrentRow.Index
            
            QrCodeImgControl1.Text = "{" & """e"":""" & "" + dgview.Item(8, i).Value.ToString + """," & """f"":""" & "" + dgview.Item(6, i).Value.ToString + """,""g"":""" + dgview.Item(12, i).Value.ToString & _
            """,""h"":""" + dgview.Item(2, i).Value.ToString + """,""i"":""" + dgview.Item(0, i).Value.ToString + " " + dgview.Item(1, i).Value.ToString + """}"

            If Not Directory.Exists("C:\qr") Then
                My.Computer.FileSystem.CreateDirectory("C:\qr")
                Dim hide_file_info As IO.FileInfo = My.Computer.FileSystem.GetFileInfo("C:\qr")
                hide_file_info.Attributes = hide_file_info.Attributes Or IO.FileAttributes.Hidden
            End If

            QrCodeImgControl1.Image.Save("C:\qr\Qr.png")

            Dim dt As New DataTable
            Dim cr As New Ticket
            Dim R As New Reporte
            Dim DataSet1 = New DataSet()

            sql = "SELECT movdiesel.Fecha, CONVERT(nvarchar(8), movdiesel.Hora, 108) AS Hora, movdiesel.cveautobus, " & _
            "CASE " & _
            "WHEN movdiesel.Tipo_Cr_A = 'Cr' " & _
            "THEN 'Autobus de Excelencia' " & _
            "ELSE 'Autobus Azul' " & _
            "END AS Tipo, " & _
            "(SELECT  nomdtvax FROM CatResponsablesDtVax WHERE CatResponsablesDtVax.Clave=movdiesel.cveRecaudador) as NomResponsableDtVax," & _
            "CASE " & _
            "WHEN cveautobus > 800 or cveautobus=4 " & _
            "THEN (SELECT  Descripcion FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " & _
            "ELSE (SELECT  Descripcion FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) " & _
            "END AS Destino, " & _
            "CASE " & _
            "WHEN cveautobus > 800 or cveautobus=4 " & _
            "THEN (SELECT  nVueltas FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " & _
            "ELSE (SELECT  nVueltas FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) " & _
            "END AS nVueltas, " & _
            "Importe, Identificador,Impreso, (SELECT Nombre FROM CatOficinasDtVax WHERE CatOficinasDtVax.Clave=movdiesel.cveOficina) as Oficina," & _
            "MovDiesel.NoVuelta, CASE  WHEN MovDiesel.ViajesEspeciales  = 0 " & _
            "THEN '' ELSE 'Viaje Especial' END AS ViajesEspeciales, CASE WHEN movdiesel.NoVuelta = .5 THEN 'Media Vuelta' ELSE 'Vuelta Completa' END AS CantidadVueltas  FROM MovDiesel where identificador= '" & clave & "' "

            Dim mda2 = New SqlDataAdapter(sql, conn)
            mda2.Fill(DataSet1, "movDiesel")


            cr.DataDefinition.FormulaFields("NombreEmpresa").Text = "'Servicios Urbanos y Sub-Urbanos Xinantecatl S.A. de C.V.'"
            cr.DataDefinition.FormulaFields("RFC").Text = "'SUS 810803 QN0'"
            cr.DataDefinition.FormulaFields("dirCalle").Text = "'Cristobal Colon #212, Barrio de San Miguel Zinacantepec,'"
            cr.DataDefinition.FormulaFields("dirColonia").Text = "'Estado de México C.P. 51350'"
            cr.SetDataSource(DataSet1)
            R.CrystalReportViewer1.ReportSource = cr
            cr.PrintToPrinter(1, False, 0, 0)
            'R.MdiParent = Principal
            'R.Show()



            Dim NoReimpresiones As Integer
            sql = "SELECT * FROM MovDiesel WHERE identificador='" & clave & "'"
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read Then
                If reader("NoReimpresiones") = 0 Then
                    NoReimpresiones = 1
                Else
                    NoReimpresiones = reader("NoReimpresiones") + 1
                End If
            End If
            conn.Close()
            reader.Close()


            Dim strSQL As String = ""

            strSQL = "UPDATE MovDiesel Set NoReimpresiones=" & NoReimpresiones & ",  status= 'R' WHERE identificador = '" & clave & "' AND cveOficina = '" & cveOfi & "'"
            Using cmd As New SqlCommand(strSQL, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using

            Call ActualizaVista()
        ElseIf clave = "" Then
            MessageBox.Show("No se Ha Seleccionado un Registro a Imprimir", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If clave <> "" Then
            Call Cancelar()
            Call ActualizaVista()
        ElseIf clave = "" Then
            MessageBox.Show("No se Ha Seleccionado un Registro a Cancelar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Cancelar()
        If MsgBox("¿Realmente desea CANCELAR este Ticket?", vbQuestion + vbOKCancel) = vbOK Then
            If bActualiza = 0 Then
                Dim strSQL As String = ""
                strSQL = "UPDATE MovDiesel Set Status='C' WHERE identificador = " & clave & " AND cveOficina = '" & cveOfi & "'"
                Using cmd As New SqlCommand(strSQL, conn)
                    cmd.Parameters.AddWithValue("@clave", clave)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
                MessageBox.Show("Ticket Cancelado", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ticket Seleccionado No se Puede Cancelar, Ya se encuentra Concentrado en la Oficina Central", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        sql = "SELECT CONVERT (char(10), movdiesel.Fecha, 103) as Fecha, CONVERT(nvarchar(8), movdiesel.Hora, 108) AS Hora, movdiesel.cveautobus, " & _
       "CASE " & _
       "WHEN movdiesel.Tipo_Cr_A = 'Cr' " & _
       "THEN 'Autobus de Excelencia' " & _
       "ELSE 'Autobus Azul' " & _
       "END AS Tipo, " & _
       "(SELECT  nomdtvax FROM CatResponsablesDtVax WHERE CatResponsablesDtVax.Clave=movdiesel.cveRecaudador) as NomResponsableDtVax," & _
       "CASE " & _
       "WHEN cveautobus > 800 or cveautobus=4 " & _
       "THEN (SELECT  Descripcion FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " & _
       "ELSE (SELECT  Descripcion FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) " & _
       "END AS Destino, " & _
       "Importe, Status, Identificador,NoReimpresiones, (SELECT Nombre FROM CatOficinasDtVax WHERE CatOficinasDtVax.Clave=movdiesel.cveOficina) as Oficina," & _
       "MovDiesel.NoVuelta as CantidadVuelta, movdiesel.cveOficina, movDiesel.id_auto FROM MovDiesel WHERE fecha='" & dtpFecha.Value.ToString("dd/MM/yyyy") & "'"

        If txtAutobus.Text <> "" Then
            sql = sql + " and cveAutobus ='" & txtAutobus.Text & "' "
        End If

        cmd.CommandText = sql
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader()
        If Not reader.HasRows Then
            MessageBox.Show("No Hay Resultados de la Busqueda", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
            reader.Close()
            Exit Sub
        End If
        conn.Close()
        reader.Close()

        dgview.DataSource = Nothing
        dgview.Refresh()
        Dim mda = New SqlDataAdapter(sql, conn)
        Dim ds = New DataSet()

        mda.Fill(ds, "MovDiesel")
        dgview.DataSource = ds
        dgview.DataMember = "MovDiesel"
        Me.dgview.Columns(3).HeaderText = "Tipo Autobus"
        Me.dgview.Columns(4).HeaderText = "Recaudador"
        Me.dgview.Columns(5).HeaderText = "Destino"
        Me.dgview.Columns(8).Visible = False
        Me.dgview.Columns(13).Visible = False
    End Sub


    Private Sub frmSuperUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dtpFecha.Value = Date.Now
        dgview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgview.ScrollBars = ScrollBars.Both
        dgview.ForeColor = Color.Black
        dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        dgview.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Call ActualizaVista()
    End Sub

End Class