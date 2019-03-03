Imports System.Data.SqlClient

Public Class frmCatResponsables
    Dim conn As New SqlConnection(connStringSql)
    Dim sql As String
    Dim clave As String

    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        dgview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgview.ScrollBars = ScrollBars.Both
        dgview.ForeColor = Color.Black
        dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        dgview.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Call ActualizaVista()
    End Sub

    Public Sub ActualizaVista()
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        clave = ""
        dgview.DataSource = Nothing
        dgview.Refresh()

        ' Consultar Registros 
        sql = "SELECT Clave, ApPaterno, ApMaterno, Nombre, NomDtVax  FROM CatResponsablesDtVax ORDER BY Clave"

        Dim mda = New SqlDataAdapter(sql, conn)
        Dim ds = New DataSet()

        mda.Fill(ds, "CatResponsablesDtVax")
        dgview.DataSource = ds
        dgview.DataMember = "CatResponsablesDtVax"
        Me.dgview.Columns(0).Visible = False
        Me.dgview.Columns(1).HeaderText = "Apellido Paterno"
        Me.dgview.Columns(2).HeaderText = "Apellido Materno"
        Me.dgview.Columns(3).HeaderText = "Nombre"
        Me.dgview.Columns(4).HeaderText = "Nombre DtVax"
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub frm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.dgview.Width = 0.8 * Me.Width
        Me.dgview.Height = 0.7 * Me.Height
    End Sub

    Private Sub dgview_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgview.CellClick
        Dim i As Integer
        Try
            i = dgview.CurrentRow.Index
            clave = dgview.Item(0, i).Value
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Call Direccionar(1)
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        If clave <> "" Then
            Call Direccionar(2)
        ElseIf clave = "" Then
            MessageBox.Show("No se Ha Seleccionado un Registro a Modificar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDetalles_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalles.Click
        If clave <> "" Then
            Call Direccionar(3)
        ElseIf clave = "" Then
            MessageBox.Show("No se Ha Seleccionado un Registro a Mostrar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If clave <> "" Then
            If MsgBox("¿Realmente desea eliminar este registro?", vbQuestion + vbOKCancel) = vbOK Then
                Dim strSQL As String = ""
                strSQL = "DELETE FROM CatResponsablesDtVax WHERE clave=@clave"
                Using cmd As New SqlCommand(strSQL, conn)
                    cmd.Parameters.AddWithValue("@clave", clave)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
                MessageBox.Show("Datos Eliminados Correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf clave = "" Then
            MessageBox.Show("No se Ha escogido un Registro a Eliminar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Call ActualizaVista()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Direccionar(ByVal opcion As Integer)
        frmDetCatResponsables.Opcion = opcion
        frmDetCatResponsables.Clave = clave
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        frmDetCatResponsables.ShowDialog()
        Cursor = System.Windows.Forms.Cursors.Default
        frmDetCatResponsables = Nothing
        If opcion = 1 Or opcion = 2 Then
            Call ActualizaVista()
        End If
    End Sub

End Class