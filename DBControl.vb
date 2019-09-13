Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class DBControl
    Private DBCon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\geojo\OneDrive\Acuerdos de Servicio\Acuerdos de Servicio DM\AcuerdosDM.accdb")
    Private DBcmd As OleDbCommand
    Public DBDatos As OleDbDataAdapter
    Public DBDataTable As DataTable
    Public Params As New List(Of OleDbParameter)
    Public Exception As String

    Public Sub ExecQuery(Query As String)
        Try
            DBCon.Open()
            DBcmd = New OleDbCommand(Query, DBCon)
            Params.ForEach(Sub(p) DBcmd.Parameters.Add(p))
            Params.Clear()
            DBDataTable = New DataTable
            DBDatos = New OleDbDataAdapter(DBcmd)
        Catch ex As Exception
            Exception = ex.Message
        End Try
        If DBCon.State = ConnectionState.Open Then DBCon.Close()
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OleDbParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class
