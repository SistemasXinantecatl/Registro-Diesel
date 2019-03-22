Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmPagoOperadores
    Dim conn As New SqlConnection(connStringSql)
    Dim dataReader As SqlDataReader
    Dim dataReader2 As SqlDataReader
    Dim cmd, cm2 As New SqlCommand
    Dim sql, sql1 As String
    Dim clave As String
    Dim ClaveOpe As String
    Dim resta As Integer
    Dim OperSelect As Integer
    Dim selectedItem As Object
    Dim mayores As String
    Dim FechaDia As Date







    Public Sub Llena_Combos(ByVal usuario As ComboBox)
        ' Llenar combos de Datos
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim conn As New SqlConnection(connStringSql)

        conn.Open()

        sql = "SELECT do.cveOperador,(co.ApPaterno + ' ' + co.ApMaterno + ' ' + co.nomOperador +' ' + '('+ " _
              & "convert(varchar(MAX),do.cveOperador) + ')' ) as NombreOperador " _
              & "FROM CatOperadores as co " _
              & "inner join distribucion_Despues as do on co.cveOperador=do.cveOperador " _
              & "ORDER BY ApPaterno, ApMaterno, nomOperador "

        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)

        cmbOper.DataSource = ds.Tables(0)
        cmbOper.DisplayMember = "NombreOperador"
        cmbOper.ValueMember = "cveOperador"
        conn.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Refresh()
        Dim strSQL As String = ""
        Dim i As Integer
        If (CSng(txtCobAcc.Text) < Val(txtPagAcc.Text)) Then
            mayores = mayores + vbLf + "El Pago de Accidentes es Mayor a la Deuda"
            i = i + 1
        End If
        If (CSng(txtCobVid.Text) < Val(txtPagVid.Text)) Then
            mayores = mayores + vbLf + "El Pago de Vidrios es Mayor a la Deuda"
            i = i + 1
        End If
        If (CSng(txtCobInf.Text) < Val(txtPagInf.Text)) Then
            mayores = mayores + vbLf + "El Pago de Infracciones es Mayor a la Deuda"
            i = i + 1
        End If
        If (CSng(txtCobFian.Text) < Val(txtPagFian.Text)) Then
            mayores = mayores + vbLf + "El Pago de Fianza es Mayor a la Deuda"
            i = i + 1
        End If
        If (CSng(txtCobInfo.Text) < Val(txtCobInfo.Text)) Then
            mayores = mayores + vbLf + "El Pago de Infonavit es Mayor a la Deuda"
            i = i + 1
        End If
        If (CSng(txtCobPend.Text) < Val(txtPagPend.Text)) Then
            mayores = mayores + vbLf + "El Pago de Pendientes es Mayor a la Deuda"
            i = i + 1
        End If
        If (i = 0) Then
            strSQL = "INSERT INTO pagosXFueraDtVax (Fecha,cveOperador,Accidentes,Vidrios,Infracciones,Fianza,Infonavit, " _
                & "Pendientes) " _
                & "VALUES('" & FechaDia.ToString("MM/dd/yyyy") & "'," & ClaveOpe & "," & IIf(String.IsNullOrEmpty(txtPagAcc.Text), 0, Val(txtPagAcc.Text)) & "," & IIf(String.IsNullOrEmpty(txtPagVid.Text), 0, Val(txtPagVid.Text)) _
                & "," & IIf(String.IsNullOrEmpty(txtPagInf.Text), 0, Val(txtPagInf.Text)) _
                & "," & IIf(String.IsNullOrEmpty(txtPagFian.Text), 0, Val(txtPagFian.Text)) & "," & IIf(String.IsNullOrEmpty(txtPagInfo.Text), 0, Val(txtPagInfo.Text)) & "," _
                & IIf(String.IsNullOrEmpty(txtPagPend.Text), 0, Val(txtPagPend.Text)) & ")"
            Using cmd As New SqlCommand(strSQL, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Pago Realizado con Exito", "Saldos de Operadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Else
            MessageBox.Show("Error en el Pago: " + mayores + vbLf + " Verificar que los Pagos sean Menores a la Deuda", "Saldos de Operadores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        txtXpAcc.Text = CSng(txtCobAcc.Text) - Val(txtPagAcc.Text)
        txtXpVid.Text = CSng(txtCobVid.Text) - Val(txtPagVid.Text)
        txtXpInf.Text = CSng(txtCobInf.Text) - Val(txtPagInf.Text)
        txtXpFia.Text = CSng(txtCobFian.Text) - Val(txtPagFian.Text)
        txtXpInfo.Text = CSng(txtCobInfo.Text) - Val(txtPagInfo.Text)
        txtXpPen.Text = CSng(txtCobPend.Text) - Val(txtPagPend.Text)
        Call formatos_pagos()
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call Imprimir(ClaveOpe)
        Cursor = System.Windows.Forms.Cursors.Default



    End Sub

    Private Sub cmbOper_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbOper.SelectionChangeCommitted
        txtPagAcc.Text = 0
        txtPagVid.Text = 0
        txtPagInf.Text = 0
        txtPagFian.Text = 0
        txtPagInfo.Text = 0
        txtPagPend.Text = 0

        txtXpAcc.Text = 0
        txtXpVid.Text = 0
        txtXpInf.Text = 0
        txtXpFia.Text = 0
        txtXpInfo.Text = 0
        txtXpPen.Text = 0

        OperSelect = cmbOper.SelectedIndex
        selectedItem = cmbOper.SelectedItem
        If (OperSelect > -1) Then
            ClaveOpe = cmbOper.SelectedValue
        End If
        Call Obtener_Datos(ClaveOpe)
    End Sub

    Private Sub frmPagoOperadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Llena_Combos(cmbOper)
        FechaDia = Today
        txtXpAcc.Enabled = False
        txtXpVid.Enabled = False
        txtXpInf.Enabled = False
        txtXpFia.Enabled = False
        txtXpInfo.Enabled = False
        txtXpPen.Enabled = False
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub txtPagAcc_Click(sender As Object, e As EventArgs) Handles txtPagAcc.Click
        txtPagAcc.SelectAll()
    End Sub

    Private Sub txtPagVid_Click(sender As Object, e As EventArgs) Handles txtPagVid.Click
        txtPagVid.SelectAll()
    End Sub

    Private Sub txtPagInf_Click(sender As Object, e As EventArgs) Handles txtPagInf.Click
        txtPagInf.SelectAll()
    End Sub

    Private Sub txtPagFian_Click(sender As Object, e As EventArgs) Handles txtPagFian.Click
        txtPagFian.SelectAll()
    End Sub

    Private Sub txtPagInfo_Click(sender As Object, e As EventArgs) Handles txtPagInfo.Click
        txtPagInfo.SelectAll()
    End Sub

    Private Sub txtPagPend_Click(sender As Object, e As EventArgs) Handles txtPagPend.Click
        txtPagPend.SelectAll()
    End Sub

    Private Sub Obtener_Datos(cveOpe As String)
        Dim conn1 As New SqlConnection(connStringSql)
        sql1 = "SELECT cveOperador, ApPaterno, ApMaterno, nomOperador FROM CatOperadores where cveOperador=" & cveOpe & ""
        cmd.CommandText = sql1
        cmd.Connection = conn1
        conn1.Open()
        dataReader = cmd.ExecuteReader()
        If dataReader.HasRows = False Then
            txtCobAcc.Text = 0
            txtCobVid.Text = 0
            txtCobInf.Text = 0
            txtCobFian.Text = 0
            txtCobInfo.Text = 0
            txtCobPend.Text = 0

            txtPagAcc.Text = 0
            txtPagVid.Text = 0
            txtPagInf.Text = 0
            txtPagFian.Text = 0
            txtPagInfo.Text = 0
            txtPagPend.Text = 0

            txtXpAcc.Text = 0
            txtXpVid.Text = 0
            txtXpInf.Text = 0
            txtXpFia.Text = 0
            txtXpInfo.Text = 0
            txtXpPen.Text = 0

            conn1.Close()
            dataReader.Close()
            Exit Sub

        Else
            Dim conn2 As New SqlConnection(connStringSql)
            Dim sql2 As String
            sql2 = "SELECT Accidentes, Vidrios, Infracciones, Fianza, Infonavit, Pendientes FROM distribucion_Despues " _
               & " WHERE cveOperador = " & cveOpe
            Using cmd2 As New SqlCommand(sql2, conn2)
                conn2.Open()
                dataReader2 = cmd2.ExecuteReader()
                dataReader2.Read()
                If dataReader2.HasRows = True Then
                    txtCobAcc.Text = dataReader2("Accidentes").ToString()
                    txtCobVid.Text = dataReader2("Vidrios").ToString()
                    txtCobInf.Text = dataReader2("Infracciones").ToString()
                    txtCobFian.Text = dataReader2("Fianza").ToString()
                    txtCobInfo.Text = dataReader2("Infonavit").ToString()
                    txtCobPend.Text = dataReader2("Pendientes").ToString()
                    Call formatos()
                Else
                    MsgBox("No entra")
                End If
                conn2.Close()
                dataReader.Close()

            End Using

            Exit Sub
        End If
        conn1.Close()
        dataReader.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Refresh()
    End Sub

    Private Sub formatos()
        Dim txtAccidentes As Double = Val(txtCobAcc.Text)
        Dim txtVidrios As Double = Val(txtCobVid.Text)
        Dim txtInf As Double = Val(txtCobInf.Text)
        Dim txtFian As Double = Val(txtCobFian.Text)
        Dim txtInfo As Double = Val(txtCobInfo.Text)
        Dim txtPendientes As Double = Val(txtCobPend.Text)

        txtCobAcc.Text = txtAccidentes.ToString("C")
        txtCobVid.Text = txtVidrios.ToString("C")
        txtCobInf.Text = txtInf.ToString("C")
        txtCobFian.Text = txtFian.ToString("C")
        txtCobInfo.Text = txtInfo.ToString("C")
        txtCobPend.Text = txtPendientes.ToString("C")

    End Sub
    Private Sub formatos_pagos()
        Dim txtAccPag As Double = Val(txtPagAcc.Text)
        Dim txtVidPag As Double = Val(txtPagVid.Text)
        Dim txtInfPag As Double = Val(txtPagInfo.Text)
        Dim txtFianPag As Double = Val(txtPagFian.Text)
        Dim txtInfoPag As Double = Val(txtPagInfo.Text)
        Dim txtPendPag As Double = Val(txtPagPend.Text)

        Dim txtAccXp As Double = Val(txtXpAcc.Text)
        Dim txtVidXp As Double = Val(txtXpVid.Text)
        Dim txtInfXp As Double = Val(txtXpInf.Text)
        Dim txtFianXp As Double = Val(txtXpFia.Text)
        Dim txtInfoXp As Double = Val(txtXpInfo.Text)
        Dim txtPendXp As Double = Val(txtXpPen.Text)

        txtPagAcc.Text = txtAccPag.ToString("C")
        txtPagVid.Text = txtVidPag.ToString("C")
        txtPagInf.Text = txtInfPag.ToString("C")
        txtPagFian.Text = txtFianPag.ToString("C")
        txtPagInfo.Text = txtInfoPag.ToString("C")
        txtPagPend.Text = txtPendPag.ToString("C")

        txtXpAcc.Text = txtAccXp.ToString("C")
        txtXpVid.Text = txtVidXp.ToString("C")
        txtXpInf.Text = txtInfXp.ToString("C")
        txtXpFia.Text = txtFianXp.ToString("C")
        txtXpInfo.Text = txtInfoXp.ToString("C")
        txtXpPen.Text = txtPendXp.ToString("C")

    End Sub
    Private Sub Imprimir(Optional cveOpe = "")
        Dim dt As New DataTable
        Dim cr As New TicketPagos
        Dim R As New Reporte
        Dim DataSet1 = New DataSet()
        sql = "Select Top 1 px.Fecha,px.cveOperador,px.Accidentes,px.Vidrios,px.Infracciones, px.Fianza, px.Infonavit,px.Pendientes ,(co.ApMaterno+' '+co.ApPaterno +' '+ co.nomOperador) as NomCompleto
                from pagosXFueraDtVax as px
                inner join CatOperadores as co
                on px.cveOperador=co.cveOperador
                where px.cveOperador = " & cveOpe _
              & "order by Fecha desc"

        Dim mda2 = New SqlDataAdapter(sql, conn)
        mda2.Fill(DataSet1, "pagosXFuera")

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