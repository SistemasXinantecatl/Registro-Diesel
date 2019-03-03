Imports System.Data.SqlClient
Imports System.IO

Public Class frmDetRegTicket
    Public Opcion As Integer
    Public Clave As String
    Dim condicerion, sql, sql1 As String
    Dim conn, conn1 As New SqlConnection(connStringSql)
    Dim cmd, cmd1 As New SqlCommand
    Dim reader, reader1 As SqlDataReader
    Dim Fecha As Date
    Dim TabDiesel As Integer
    Dim Tabla As String
    Dim condicion As String
    Public FechaReg As String
    Dim NumVueltas As Integer
    Dim NoVuelta As Double
    Dim iImporte As Double
    Dim Folio As String
    Dim idDiesel As Long
    Dim TotalVueltas As Double
    Dim ImporteTemp As Decimal

    Private Sub frmDetCatOficinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MuestraDatos()
    End Sub

    Private Sub MuestraDatos()
        txtcveAutobus.Focus()
        txtNombre.Text = Responsable
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtHora.Text = DateTime.Now.ToString("HH:mm:ss")

        txtcveAutobus.Text = ""
        cmbdestino.Text = ""
        chkMediaVuelta.Checked = False
        chkViajesEspeciales.Checked = False
        txtImpote.Text = ""
        txtImpote.Enabled = False
        chkMediaVuelta.Enabled = False

        If Opcion <> 1 Then
            sql = "SELECT *,(SELECT NomDtVax FROM CatResponsablesDtVax WHERE CatResponsablesDtVax.Clave=movdiesel.cveRecaudador) as nombdtvax " & _
                "FROM MovDiesel WHERE identificador= '" & Clave & "' "
            cmd.CommandText = sql
            cmd.Connection = conn1
            conn1.Open()
            reader1 = cmd.ExecuteReader()
            If reader1.Read Then
                If reader1("Fecha") Is DBNull.Value Then
                    Fecha = DateTime.Now.ToString("dd/MM/yyyy")
                    txtFecha.Text = Fecha
                Else
                    Fecha = reader1("Fecha")
                    txtFecha.Text = Fecha.ToString("dd/MM/yyyy")
                End If

                If reader1("Hora") Is DBNull.Value Then
                    txtHora.Text = DateTime.Now.ToString("HH:mm:ss")
                Else
                    txtHora.Text = reader1("Hora").ToString
                End If
                txtNombre.Text = IIf(reader1("nombdtvax") Is DBNull.Value, "", reader1("nombdtvax"))
                txtcveAutobus.Text = IIf(reader1("cveautobus") Is DBNull.Value, "", reader1("cveautobus"))
                cmbdestino.SelectedValue = IIf(reader1("cveDestino") Is DBNull.Value, "", reader1("cveDestino"))
                chkViajesEspeciales.Checked = IIf(reader1("ViajesEspeciales") = 0, False, True)
                chkMediaVuelta.Checked = IIf(reader1("noVuelta") = 0.5, True, False)
                txtImpote.Text = IIf(reader1("Importe") Is DBNull.Value, "", reader1("Importe"))
            End If
            conn1.Close()
            reader1.Close()
            chkContinua.Enabled = False
        End If

        If Opcion = 3 Then
            txtNombre.Enabled = False
            txtImpote.Enabled = False
            txtcveAutobus.Enabled = False
            cmbdestino.Enabled = False
            chkContinua.Visible = False
            btnImporte.Enabled = False
            chkViajesEspeciales.Enabled = False
            chkMediaVuelta.Enabled = False
        End If

    End Sub

    Public Sub Llena_Combos(ByVal combo As ComboBox)
        ' Llenar combos de Datos
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim conn As New SqlConnection(connStringSql)
        conn.Open()
        condicion = "Select * From " & Tabla & " order by cveDestino"
        da = New SqlDataAdapter(condicion, conn)
        ds = New DataSet
        da.Fill(ds)

        cmbdestino.DataSource = ds.Tables(0)
        cmbdestino.DisplayMember = "Descripcion"
        cmbdestino.ValueMember = "cveDestino"
        conn.Close()
    End Sub

    Private Sub Funcion_Aceptar()

        Select Case Opcion
            Case Is = 1
                Call InsBD(1)
            Case Is = 2
                Call InsBD(2)
        End Select

        If Not Opcion = 3 Then frmCatOficinas.ActualizaVista()
    End Sub

    Private Sub InsBD(ByVal Op As Byte)
        Dim strSQL As String = ""
        If Op = 1 Then
            Call folioAutobus()

            strSQL = "INSERT INTO MovDiesel (identificador, cveautobus, Tipo_Cr_A, cveRecaudador, cveDestino, Fecha, Hora, Importe, Status, NoReimpresiones,bActualiza,cveOficina,NoVuelta,ViajesEspeciales,id_auto) " & _
            "VALUES(@Folio, @cveAutobus, @tipo, @cveResponsable, @cveDestino, @Fecha, @Hora, @Importe, 'E', 0, 0,@oficina,@Novuelta,@ViajesEspeciales,@id_auto)"
        End If

        Using cmd As New SqlCommand(strSQL, conn)
            cmd.Parameters.AddWithValue("@Folio", Folio)
            cmd.Parameters.AddWithValue("@cveAutobus", txtcveAutobus.Text)
            cmd.Parameters.AddWithValue("@tipo", IIf(txtcveAutobus.Text > 800 Or txtcveAutobus.Text = 4, "A", "Cr"))
            cmd.Parameters.AddWithValue("@cveResponsable", cveResponsable)
            cmd.Parameters.AddWithValue("@cveDestino", cmbdestino.SelectedValue)
            cmd.Parameters.AddWithValue("@Fecha", txtFecha.Text)
            cmd.Parameters.AddWithValue("@Hora", txtHora.Text)
            cmd.Parameters.AddWithValue("@Importe", txtImpote.Text)
            cmd.Parameters.AddWithValue("@Oficina", cveOficina)
            cmd.Parameters.AddWithValue("@Novuelta", NoVuelta)
            cmd.Parameters.AddWithValue("@id_auto", idDiesel)
            cmd.Parameters.AddWithValue("@ViajesEspeciales", IIf(chkViajesEspeciales.Checked = False, 0, 1))

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        Call ActualizaCatAutobuses()

    End Sub

    Private Sub ActualizaCatAutobuses()
        Dim strSQL As String = ""

        strSQL = "UPDATE CatOficinasDtvax SET idDiesel=@idDiesel where clave='" & cveOficina & "' "

        Using cmd As New SqlCommand(strSQL, conn)
            cmd.Parameters.AddWithValue("@idDiesel", idDiesel)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub
    Private Sub txtApMaterno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImpote.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtImpote.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtcveAutobus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcveAutobus.TextChanged
        cmbdestino.Text = ""

        If txtcveAutobus.Text <> "" Then
            sql = "SELECT * FROM CatAutobuses WHERE cveAutobus=" & txtcveAutobus.Text
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                Label7.Text = ""
                If reader.Read Then
                    If reader("cveAutobus") > 800 Or reader("cveAutobus") = 4 Then
                        Label2.Text = "Destino Autobuses Azules"
                        Tabla = "CatDestinosAzules"
                        txtImpote.Text = ""
                    Else
                        Label2.Text = "Destino Autobuses de Excelencia"
                        Tabla = "CatDestinosCr"
                        txtImpote.Text = ""
                    End If

                    Call Llena_Combos(cmbdestino)
                    If Opcion = 1 Then
                        sql = "SELECT * FROM MovDiesel WHERE cveAutobus=" & txtcveAutobus.Text & " AND Fecha='" & Date.Now.ToString("dd/MM/yyyy") & "'"
                        cmd1.CommandText = sql
                        cmd1.Connection = conn1
                        conn1.Open()
                        reader1 = cmd1.ExecuteReader()
                        If reader1.Read Then
                            cmbdestino.SelectedValue = reader1("cveDestino")
                        End If
                        conn1.Close()
                        reader1.Close()
                    End If

                    TabDiesel = reader("TabDiesel")
                End If

            Else
                Label2.Text = "Destino"
                cmbdestino.DataSource = Nothing
                Label7.Text = "Autobus No Existe en el Catalogo de Autobuses"
            End If
            conn.Close()
            reader.Close()
        Else
            cmbdestino.Text = ""
            Label2.Text = "Destino"
        End If

    End Sub

    Private Sub btnImporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImporte.Click
        NumVueltas = 0
        If txtcveAutobus.Text <> "" Or cmbdestino.SelectedIndex <> -1 Then
            sql = "SELECT * FROM " & Tabla & " WHERE cveDestino=" & cmbdestino.SelectedValue
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read Then
                NumVueltas = reader("nVueltas")
                Select Case TabDiesel
                    Case Is = 1
                        txtImpote.Text = Math.Round((reader("Diesel1") / NumVueltas), 2)
                    Case Is = 2
                        txtImpote.Text = Math.Round((reader("Diesel2") / NumVueltas), 2)
                    Case Is = 3
                        txtImpote.Text = Math.Round((reader("Diesel3") / NumVueltas), 2)
                    Case Is = 4
                        txtImpote.Text = Math.Round((reader("Diesel4") / NumVueltas), 2)
                End Select
            End If
            conn.Close()
            reader.Close()
            If banderabImporte = True Then
                txtImpote.Enabled = True
            End If
            iImporte = txtImpote.Text
            ImporteTemp = txtImpote.Text
            chkMediaVuelta.Enabled = True
        Else
            MessageBox.Show("Debe Llenar Los Campos Autobus y Destino Pra Calcular Importe de Diesel", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click


        If Opcion = 1 Then
            If txtcveAutobus.Text = "" Or Not IsNumeric(txtcveAutobus.Text) Then
                MessageBox.Show("Clave de Autobus No Valido", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtcveAutobus.Focus()
                Exit Sub
            End If

            If txtImpote.Text = "" Then
                MessageBox.Show("Favor de Calcular el Importe", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtImpote.Focus()
                Exit Sub
            End If

            If txtImpote.Text > iImporte Then
                MessageBox.Show("Solo Puede Disminuir el Importe", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtImpote.Focus()
                Exit Sub
            End If

            If cmbdestino.Text = "" Then
                MessageBox.Show("Favor de Seleccionar el Nombre del Destino", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbdestino.Focus()
                Exit Sub
            End If

                Dim Vuelta As String
                If chkMediaVuelta.Checked = True Then
                    NoVuelta = 0.5
                    Vuelta = "MEDIA VUELTA"
                Else
                    NoVuelta = 1
                    Vuelta = "VUELTA COMPLETA"
                End If

                Dim result As Integer = MessageBox.Show("Se Emitira un Ticket por " & Vuelta & " para el AUTOBUS " & txtcveAutobus.Text & " de la RUTA " & cmbdestino.Text & " ¿ESTAS SEGURO DE QUERER CONTINUAR?", "MENSAJE", MessageBoxButtons.YesNo)
                If result = DialogResult.Cancel Or result = DialogResult.No Then
                    txtcveAutobus.Focus()
                    Exit Sub
                End If

            'VALIDAR TOPE NOVUELTAS EXCEPTO EL DESTINO RECARGAS = 23 EN LOS AUTOBUSES AZULES YROJOS EN EL VIAJE SIGLO XXI Y VIAJES ESPECIALES
                If (cmbdestino.SelectedValue = 23 And (txtcveAutobus.Text > 800 Or txtcveAutobus.Text = 4)) Or (cmbdestino.SelectedValue = 43 And (txtcveAutobus.Text < 800 Or txtcveAutobus.Text <> 4)) Then
                Else
                    sql = "SELECT count(cveAutobus) as TotalVueltas FROM MovDiesel WHERE cveAutobus=" & txtcveAutobus.Text & " and Fecha='" & Date.Now.ToString("dd/MM/yyyy") & "' and cveOficina='" & cveOficina & "' AND status<>'C' "
                    cmd.CommandText = sql
                    cmd.Connection = conn
                    conn.Open()
                    reader = cmd.ExecuteReader()
                    If reader.Read Then
                        If reader("TotalVueltas") >= NumVueltas Then
                            MessageBox.Show("No se Puede Generar Ticket Para este el Autobus " & txtcveAutobus.Text & ", por que ya se han generado el Total de Tickets Permitidos para este día", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtcveAutobus.Focus()
                            conn.Close()
                            reader.Close()
                            Exit Sub
                        End If
                    End If
                    conn.Close()
                    reader.Close()
                End If

                Call Funcion_Aceptar()
                Call Imprimir()
                Cursor = System.Windows.Forms.Cursors.WaitCursor
            End If

            If Opcion = 1 And chkContinua.Checked = True Then
                Call frmRegTicket.ActualizaVista()
                Call MuestraDatos()
            Else
                Me.Close()
            End If
            Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub Imprimir()
        Dim cveAutobusTicket As String
        cveAutobusTicket = txtcveAutobus.Text.TrimStart("0")
        QrCodeImgControl1.Text = "{" & """e"":""" & "" + Folio + """," & """f"":""" & "" + txtImpote.Text + """,""g"":""" + cveOficina &
            """,""h"":""" + cveAutobusTicket + """,""i"":""" + txtFecha.Text + " " + txtHora.Text + """}"

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

        sql = "SELECT movdiesel.Fecha, CONVERT(nvarchar(8), movdiesel.Hora, 108) AS Hora, movdiesel.cveautobus, " &
        "CASE " &
        "WHEN movdiesel.Tipo_Cr_A = 'Cr' " &
        "THEN 'Autobus de Excelencia' " &
        "ELSE 'Autobus Azul' " &
        "END AS Tipo, " &
        "(SELECT  nomdtvax FROM CatResponsablesDtVax WHERE CatResponsablesDtVax.Clave=movdiesel.cveRecaudador) as NomResponsableDtVax," &
        "CASE " &
        "WHEN cveautobus > 800 or cveautobus=4 " &
        "THEN (SELECT  Descripcion FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " &
        "ELSE (SELECT  Descripcion FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) " &
        "END AS Destino, " &
        "CASE " &
        "WHEN cveautobus > 800 or cveautobus=4 " &
        "THEN (SELECT  nVueltas FROM catDestinosAzules WHERE catDestinosAzules.cveDestino=movdiesel.cveDestino) " &
        "ELSE (SELECT  nVueltas FROM catDestinosCr WHERE catDestinosCr.cveDestino=movdiesel.cveDestino) " &
        "END AS nVueltas, " &
        "Importe, Identificador,Impreso, (SELECT Nombre FROM CatOficinasDtVax WHERE CatOficinasDtVax.Clave=movdiesel.cveOficina) as Oficina," &
        "MovDiesel.NoVuelta, CASE  WHEN MovDiesel.ViajesEspeciales  = 0 " &
        "THEN '' ELSE 'Viaje Especial' END AS ViajesEspeciales, CASE WHEN movdiesel.NoVuelta = .5 THEN 'Media Vuelta' ELSE 'Vuelta Completa' END AS CantidadVueltas FROM MovDiesel where identificador= '" & Folio & "'"

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


        Dim strSQL As String = ""

        strSQL = "UPDATE MovDiesel Set Impreso=1 WHERE identificador = '" & Folio & "' AND cveOficina = '" & cveOficina & "'"
        Using cmd As New SqlCommand(strSQL, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Private Sub folioAutobus()

        Dim Longitud As Integer = 0
        Dim Longitud_Folio As Integer
        Dim numero_Random As Integer = 0
        Dim numero_Random_2 As Integer = 0
        Dim numero_Random_String_division_uno As String = ""
        Dim numero_Random_String_division_dos As String = ""
        Dim Diferencia As Integer
        Dim Random As New Random()
        Folio = ""
        idDiesel = 0
        sql = "SELECT MAX(id_auto) as idDiesel FROM MovDiesel "
        cmd.CommandText = sql
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader()
        If reader.Read Then
            If reader("idDiesel") Is DBNull.Value Then
                idDiesel = 1
            Else
                idDiesel = reader("idDiesel") + 1
            End If
        End If
        conn.Close()
        reader.Close()

        Dim idDiesel_String As String = idDiesel
        Longitud = idDiesel_String.Length
        numero_Random = Random.Next(1000, 9999)
        Folio = "" & numero_Random & "" & Longitud & "" & idDiesel & ""
        Longitud_Folio = Folio.Length


        numero_Random_String_division_uno = "1"
        numero_Random_String_division_dos = "9"
        Diferencia = 15 - Longitud_Folio
        If Diferencia <= 0 Then
            Folio = Folio
        Else
            Dim i As Integer
            For i = 1 To Diferencia - 1
                numero_Random_String_division_uno = "" & numero_Random_String_division_uno & "0"
                numero_Random_String_division_dos = "" & numero_Random_String_division_dos & "9"
            Next i

            numero_Random_2 = Random.Next(Convert.ToInt32(numero_Random_String_division_uno), Convert.ToInt32(numero_Random_String_division_dos))

            Folio = "" & Folio & "" & numero_Random_2 & ""
        End If
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtcveAutobus_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcveAutobus.KeyPress
        txtcveAutobus.SelectedText = Solo_Numeros_Int(e)
    End Sub

    Private Sub chkMediaVuelta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMediaVuelta.CheckedChanged
        If Opcion = 1 And txtImpote.Text <> "" Then
            If chkMediaVuelta.Checked = True Then
                txtImpote.Text = txtImpote.Text / 2
            Else
                txtImpote.Text = ImporteTemp
            End If
        End If
    End Sub

    Private Sub cmbdestino_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdestino.SelectedValueChanged
        txtImpote.Text = ""
    End Sub
End Class