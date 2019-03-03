Imports System.IO

Public Class EnviarCorreo

    Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click
        btnEnviar.Enabled = False
        btnSalir.Enabled = False
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        enviaCorreo(txtEmisor.Text, txtPassword.Text, rtbMensaje.Text, txtAsunto.Text, txtReceptor.Text, txtRutaArchivo.Text)
        If banderaPaso = False Then
            btnEnviar.Enabled = True
            btnSalir.Enabled = True
            Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
        btnEnviar.Enabled = True
        btnSalir.Enabled = True
        Cursor = System.Windows.Forms.Cursors.Default
        Me.Dispose()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                txtRutaArchivo.Text = Me.OpenFileDialog1.FileName
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EnviarCorreo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtAsunto.Text = "Cierre de Diesel X Dia " & Date.Now.ToString("dd_MM_yyyy") & ""
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class