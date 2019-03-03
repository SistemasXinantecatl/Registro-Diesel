Imports System.Data.SqlClient

Public Class frmDetCatOficinas
    Public Opcion As Integer
    Public Clave As String
    Dim sql As String
    Dim conn As New SqlConnection(connStringSql)
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub frmDetCatOficinas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call MuestraDatos()
    End Sub

    Private Sub MuestraDatos()

        Call Llena_Combos(cmbOficinaDtVax)

        txtNombre.Focus()
        txtNombre.Text = ""
        cmbOficinaDtVax.Text = ""

        If Opcion = 1 Then
        Else
            txtClaveOficina.Enabled = False
            sql = "SELECT * FROM CatOficinasDtVax WHERE Clave='" & Clave & "'"
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read Then
                txtClaveOficina.Text = IIf(reader("Clave") Is DBNull.Value, "", reader("Clave"))
                txtNombre.Text = IIf(reader("Nombre") Is DBNull.Value, "", reader("Nombre"))
                cmbOficinaDtVax.Text = IIf(reader("NomDtVax") Is DBNull.Value, "", reader("NomDtVax"))
            End If
            conn.Close()
            reader.Close()
            chkContinua.Enabled = False
        End If

        If Opcion = 3 Then
            txtClaveOficina.Enabled = False
            txtNombre.Enabled = False
            cmbOficinaDtVax.Enabled = False
            chkContinua.Visible = False
        End If



    End Sub

    Public Sub Llena_Combos(ByVal combo As ComboBox)
        ' Llenar combos de Datos
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim conn As New SqlConnection(connStringSql)
        conn.Open()

        sql = "SELECT oficina as nomOficina From movDTVax  where oficina <>'' group by oficina order by oficina"

        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)

        cmbOficinaDtVax.DataSource = ds.Tables(0)
        cmbOficinaDtVax.DisplayMember = "nomOficina"
        conn.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If txtClaveOficina.Text = "" Then
            MsgBox("Favor de llenar la Clave de la Oficina")
            txtNombre.Focus()
            Exit Sub
        End If

        If txtNombre.Text = "" Then
            MsgBox("Favor de llenar el Nombre de la Oficina")
            txtNombre.Focus()
            Exit Sub
        End If

        If cmbOficinaDtVax.Text = "" Then
            MsgBox("Favor de Seleccionar el Nombre de la Oficina de DtVax")
            cmbOficinaDtVax.Focus()
            Exit Sub
        End If
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call Funcion_Aceptar()
        If Opcion = 1 And chkContinua.Checked = True Then
            Call MuestraDatos()
        Else
            Me.Close()
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Funcion_Aceptar()

        Select Case Opcion
            Case Is = 1
                Call InsBD(1)
                MessageBox.Show("Registro Agregado con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Is = 2
                Call InsBD(2)
                MessageBox.Show("Registro Actualizado con Exito", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        If Not Opcion = 3 Then frmCatOficinas.ActualizaVista()
    End Sub

    Private Sub InsBD(Op As Byte)
        Dim strSQL As String = ""
        If Op = 1 Then
            strSQL = "INSERT INTO CatOficinasDtVax (Clave,Nombre,NomDtVax) " & _
            "VALUES(@clave, @nombre, @NomDtVax)"
        ElseIf Op = 2 Then
            strSQL = "UPDATE CatOficinasDtVax SET Nombre=@nombre, " & _
                    "NomDtVax=@NomDtVax WHERE Clave=@clave "
        End If

        Using cmd As New SqlCommand(strSQL, conn)
            cmd.Parameters.AddWithValue("@clave", txtClaveOficina.Text)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@NomDtVax", cmbOficinaDtVax.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
    End Sub

    Private Sub txtNombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtNombre.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtClaveOficina_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClaveOficina.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtClaveOficina.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
End Class