Imports System.Data.OleDb
Imports System.Data

Public Class NewUser
    Private Access As New DBControl
    Dim Panel2 As UserControl
    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click

        If NuevoUsuario.Text = "" Or NuevaContraseña.Text = "" Or Confirmar.Text = "" Or AreaDM.Text = "" Then
            Mensaje.Text = "Favor diligenciar todos los campos"
        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\geojo\Downloads\Acuerdos de Servicio DM\AcuerdosDM.accdb;")
                Dim insert As String = "Insert into Login values('" & NuevoUsuario.Text & "','" & NuevaContraseña.Text & "','" & AreaDM.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()

                MsgBox("Usuario Creado Correctamente")
                NuevoUsuario.Clear()
                NuevaContraseña.Clear()
                Confirmar.Clear()
                AreaDM.Items.Clear()
                Me.Hide()
            Catch ex As Exception
                Mensaje.Text = "Favor revisar los campos"
            End Try
        End If
    End Sub

End Class
