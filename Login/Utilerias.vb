Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Module Utilerias
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Public banderaPaso As Boolean





    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, ByVal ruta As String)
        Try
            banderaPaso = True
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            If ruta <> "" Then
                Dim archivo As Net.Mail.Attachment = New Net.Mail.Attachment(ruta)
                correos.Attachments.Add(archivo)
            End If

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            banderaPaso = False
            MessageBox.Show("Error al Enciar Revisar el Correo Receptor/Conexion a Internet  ", "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890.", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function

    Public Function Solo_Mayusculas(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tecla As Char = ""
        If Char.IsLower(e.KeyChar) Then
            tecla = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
        Return tecla
    End Function
    Public Function Solo_Numeros_Int(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tecla As String = ""
        If (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8) Or Asc(e.KeyChar) > 57 Then
            tecla = ""
            e.Handled = True
        End If
        Return tecla
    End Function
    Public Function Solo_Numeros_float(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tecla As String = ""
        If (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46) Or Asc(e.KeyChar) > 57 Then
            tecla = ""
            e.Handled = True
        End If
        Return tecla
    End Function
    Public Function solo_letras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tecla As String = ""
        If (Asc(e.KeyChar) < 65 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 241) Or Asc(e.KeyChar) > 122 Then
            tecla = ""
            e.Handled = True
        End If
        Return tecla
    End Function
    Public Function solo_nombres(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tecla As String = ""
        If (Asc(e.KeyChar) < 65 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 43 And Asc(e.KeyChar) <> 45) Then
            tecla = ""
            e.Handled = True
        End If
        Return tecla
    End Function
    Public Function solo_numeros_dec(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal cad As String)
        Dim tecla As String = ""
        If ((Asc(e.KeyChar) < 48) And (Asc(e.KeyChar) <> 8)) Or (Asc(e.KeyChar) > 57) Then
            e.Handled = True
            Dim l_SeparadorDecimal As String = "."
            If (e.KeyChar = l_SeparadorDecimal) And (0 = InStr(cad, l_SeparadorDecimal, CompareMethod.Binary)) Then
                e.Handled = False
            End If
        Else
            tecla = ""
        End If
        Return tecla
    End Function

    Public Function solo_operaciones(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tecla As String = ""
        If (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 43 And Asc(e.KeyChar) <> 45) Or Asc(e.KeyChar) > 57 Then
            tecla = ""
            e.Handled = True
        End If
        Return tecla
    End Function

    Public Sub mensaje_o(ByVal men As String)
        MsgBox("El campo de " & men & " es obligatorio", MsgBoxStyle.Exclamation)
    End Sub
    Public Function obtener_mes(ByVal n As Integer)
        Dim mes As String = ""
        Select Case n
            Case 1
                mes = "ENERO"
            Case 2
                mes = "FEBRERO"
            Case 3
                mes = "MARZO"
            Case 4
                mes = "ABRIL"
            Case 5
                mes = "MAYO"
            Case 6
                mes = "JUNIO"
            Case 7
                mes = "JULIO"
            Case 8
                mes = "AGOSTO"
            Case 9
                mes = "SEPTIEMBRE"
            Case 10
                mes = "OCTUBRE"
            Case 11
                mes = "NOVIEMBRE"
            Case 12
                mes = "DICIEMBRE"
        End Select
        Return mes
    End Function


End Module