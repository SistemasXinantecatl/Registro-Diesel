Imports System.Data.SqlClient

Public Class frmDetCatResponsables
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

        Call Llena_Combos(cmbResponsableDtVax)

        txtNombre.Focus()
        txtNombre.Text = ""
        cmbResponsableDtVax.Text = ""
        txtApMaterno.Text = ""
        txtApPaterno.Text = ""

        If Opcion = 1 Then
            sql = "SELECT MAX(Clave) as Clave FROM CatResponsablesDtVax"
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read Then
                If reader("Clave") Is DBNull.Value Then
                    txtClaveResponsable.Text = 1
                Else
                    txtClaveResponsable.Text = reader("Clave") + 1
                End If
            End If
            conn.Close()
            reader.Close()
        Else
            sql = "SELECT * FROM CatResponsablesDtVax WHERE Clave=" & Clave
            cmd.CommandText = sql
            cmd.Connection = conn
            conn.Open()
            reader = cmd.ExecuteReader()
            If reader.Read Then
                txtClaveResponsable.Text = IIf(reader("Clave") Is DBNull.Value, "", reader("Clave"))
                txtNombre.Text = IIf(reader("Nombre") Is DBNull.Value, "", reader("Nombre"))
                txtApPaterno.Text = IIf(reader("ApPaterno") Is DBNull.Value, "", reader("ApPaterno"))
                txtApMaterno.Text = IIf(reader("ApMaterno") Is DBNull.Value, "", reader("ApMaterno"))
                cmbResponsableDtVax.Text = IIf(reader("NomDtVax") Is DBNull.Value, "", reader("NomDtVax"))
                txtpassword.Text = IIf(reader("password") Is DBNull.Value, "", reader("password"))
                chkSU.Checked = IIf(reader("SuperUsuario") = 0, False, True)
                bImporte.Checked = IIf(reader("BanderabImporte") = 0, False, True)
            End If
            conn.Close()
            reader.Close()
            chkContinua.Enabled = False
        End If

        If Opcion = 3 Then
            txtClaveResponsable.Enabled = False
            txtNombre.Enabled = False
            txtApPaterno.Enabled = False
            txtApMaterno.Enabled = False
            cmbResponsableDtVax.Enabled = False
            chkContinua.Visible = False
            chkPassword.Enabled = False
            chkSU.Enabled = False
            bImporte.Enabled = False
            txtpassword.Enabled = False
        End If
    End Sub

    Public Sub Llena_Combos(ByVal combo As ComboBox)
        ' Llenar combos de Datos
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim conn As New SqlConnection(connStringSql)
        conn.Open()

        sql = "SELECT nomRecaudador From movDTVaxXina where nomRecaudador<>'fabian.garduÃ±o' " & _
        " and nomRecaudador<>'fabian.garduÃƒÂ±o' group by nomRecaudador order by nomRecaudador"

        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)

        cmbResponsableDtVax.DataSource = ds.Tables(0)
        cmbResponsableDtVax.DisplayMember = "nomRecaudador"
        conn.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If txtNombre.Text = "" Then
            MsgBox("Favor de llenar el Nombre del Responsable")
            txtNombre.Focus()
            Exit Sub
        End If

        If txtApPaterno.Text = "" Then
            MsgBox("Favor de llenar el Apellido Paterno del Responsable")
            txtApPaterno.Focus()
            Exit Sub
        End If

        If txtApMaterno.Text = "" Then
            MsgBox("Favor de llenar el Apellido Materno del Responsable")
            txtApMaterno.Focus()
            Exit Sub
        End If

        If cmbResponsableDtVax.Text = "" Then
            MsgBox("Favor de Seleccionar el Nombre de la Oficina de DtVax")
            cmbResponsableDtVax.Focus()
            Exit Sub
        End If

        If txtpassword.Text = "" Then
            MsgBox("Favor de Agreagar una Contaseña")
            txtpassword.Focus()
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
            strSQL = "INSERT INTO CatResponsablesDtVax (Clave,ApPaterno,ApMaterno,Nombre,NomDtVax,password,SuperUsuario,BanderabImporte) " & _
            "VALUES(@clave, @apPaterno, @apMaterno, @nombre, @NomDtVax, @password, @su, @bimporte)"
        ElseIf Op = 2 Then
            strSQL = "UPDATE CatResponsablesDtVax SET Nombre=@nombre, " & _
                    "NomDtVax=@NomDtVax, ApPaterno=@apPaterno, ApMaterno=@apMaterno, password=@password, " & _
                    "SuperUsuario = @Su, BanderabImporte=@bimporte WHERE Clave=@clave "
        End If

        Using cmd As New SqlCommand(strSQL, conn)
            cmd.Parameters.AddWithValue("@clave", txtClaveResponsable.Text)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@apPaterno", txtApPaterno.Text)
            cmd.Parameters.AddWithValue("@apMaterno", txtApMaterno.Text)
            cmd.Parameters.AddWithValue("@NomDtVax", cmbResponsableDtVax.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@Su", IIf(chkSU.Checked = True, 1, 0))
            cmd.Parameters.AddWithValue("@bimporte", IIf(bImporte.Checked = True, 1, 0))
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

    Private Sub txtApPaterno_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApPaterno.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtApPaterno.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtApMaterno_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApMaterno.KeyPress
        If Char.IsLower(e.KeyChar) Then
            txtApMaterno.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub chkPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then    'aqui la condicion es cuando se presiona el checkbok le decimos muestra lo que haya escrito o desactiva la opcion de passwordchar
            txtpassword.PasswordChar = ""
        ElseIf chkPassword.Checked = False Then ' si la codicion no se cumple entonces solo me mostrara el simbolo o texto quee hayamos asigando,siempre estara activa la opcion password char
            txtpassword.PasswordChar = "*"
        End If
    End Sub
End Class