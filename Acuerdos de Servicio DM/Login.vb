Imports System.Data.OleDb
Imports System.Data

Public Class Login
    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click
        Dim user As String = ""
        Dim pass As String
        Dim nombreususario As String = ""
        Dim contrasenap As String

        If Usuario.Text = "" Or Contraseña.Text = "" Then
            Mensaje.Text = "Favor ingresa tu usuario y contraseña"
            Mensaje.Show()
        Else
            user = Usuario.Text
            Principal.Tag = user
            pass = Contraseña.Text
            Mensaje.Hide()
            Dim querry As String = "Select Password From Login where Name= '" & user & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\geojo\Downloads\Acuerdos de Servicio DM\AcuerdosDM.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                contrasenap = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Este Usuario no Existe")
            End Try
            If (pass = contrasenap) Then
                Principal.Show()
                If Principal.Visible Then
                    Me.Close()
                End If

            Else
                Mensaje.Show()
                Mensaje.Text = "Error de inicio de sesión"
                Usuario.Clear()
                Contraseña.Clear()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel2.Hide()
        NewUser1.Visible = True
    End Sub
    Private Sub NewUser1_VisibleChanged(sender As Object, e As EventArgs) Handles NewUser1.VisibleChanged
        Panel2.Show()
    End Sub

End Class

