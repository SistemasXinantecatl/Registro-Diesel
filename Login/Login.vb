Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Login
    Dim sql As String

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conn As New SqlConnection(connStringSql)
        Dim cmd As New SqlCommand()
        ServerIni = Application.StartupPath & "\" & "Servidor.Ini"
        Server = My.Computer.FileSystem.ReadAllText(ServerIni)
        Oficina = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\OficinaSistema.ini")
        connStringSql = "Server =" & Server & ";initial catalog = dbSistema;user id = sa;password = 12345678"
        Llena_Combos(cmbUsuario)
    End Sub

    Public Sub Llena_Combos(ByVal usuario As ComboBox)
        ' Llenar combos de Datos
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim conn As New SqlConnection(connStringSql)
        conn.Open()

        sql = "SELECT clave,(ApPaterno+ ' ' + ApMaterno + ' ' + Nombre) as NombreRecaudador FROM CatResponsablesDtVax order by clave "

        da = New SqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)

        cmbUsuario.DataSource = ds.Tables(0)
        cmbUsuario.DisplayMember = "NombreRecaudador"
        cmbUsuario.ValueMember = "clave"
        conn.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim conn As New SqlConnection(connStringSql)
        Dim reader As SqlDataReader
        Dim cmd As New SqlCommand()

        Dim Pass, nombre, usu, clave As String
        Pass = ""
        nombre = ""
        usu = ""
        clave = ""
        sql = " SELECT * from CatResponsablesDtVax WHERE clave = @clave"

        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@clave", cmbUsuario.SelectedValue)
        '        cmd.Parameters.AddWithValue("@quincena", Quincena)
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader()
        While reader.Read()
            Pass = reader("password")
            nombre = reader("NomDtVax")
            usu = reader("NomDtVax")
            clave = reader("Clave")
            Su = reader("SuperUsuario")
            banderabImporte = IIf(reader("BanderabImporte") Is DBNull.Value, False, reader("BanderabImporte"))
        End While
        conn.Close()
        reader.Close()
        cmd.Parameters.Clear()

        If Pass = "" Then
            MsgBox("Usuario no existe o esta Inactivo", MsgBoxStyle.Critical, "Sistema de Registro de Tickets de Diesel")
            cmbUsuario.Focus()
        Else
            If Pass <> txtPassword.Text Then
                MsgBox("Contraseña incorrecta.", MsgBoxStyle.Critical, "Sistema de Registro de Tickets de Diesel")
                txtPassword.Focus()
            Else
                Responsable = usu
                cveResponsable = clave
                UsuarioLogin = cmbUsuario.Text
                NombreDtvax = usu
                Principal.Show()
                Me.Close()
            End If
        End If

        sql = " SELECT * from CatOficinasDtvax WHERE nombre = @nombre"

        cmd.CommandText = sql
        cmd.Parameters.AddWithValue("@nombre", Oficina)
        '        cmd.Parameters.AddWithValue("@quincena", Quincena)
        cmd.Connection = conn
        conn.Open()
        reader = cmd.ExecuteReader()
        If reader.Read Then
            cveOficina = reader("Clave")
        End If
        conn.Close()
        reader.Close()
        cmd.Parameters.Clear()

    End Sub

    Private Sub Login_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

End Class
