Imports System.Data.OleDb
Imports System.Data

Public Class Principal
    Private Access As New DBControl
    Private Sub ComercialBtn_Click(sender As Object, e As EventArgs) Handles ComercialBtn.Click
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Comercial1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub ProduccionBtn_Click(sender As Object, e As EventArgs) Handles ProduccionBtn.Click
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Produccion1.Visible = True

        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub IngenieriaBtn_Click(sender As Object, e As EventArgs) Handles IngenieriaBtn.Click
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Ingenieria1.Visible = True

        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub ComprasBtn_Click(sender As Object, e As EventArgs) Handles ComprasBtn.Click
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Compras1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub FinancieraBtn_Click(sender As Object, e As EventArgs) Handles FinancieraBtn.Click
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Financiera1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub ProyectosBtn_Click(sender As Object, e As EventArgs) Handles ProyectosBtn.Click
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Proyectos1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub GHBtn_Click(sender As Object, e As EventArgs) Handles GHBtn.Click
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Gh1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub DespachosBtn_Click(sender As Object, e As EventArgs) Handles DespachosBtn.Click
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Despachos1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub GerenciaBtn_Click(sender As Object, e As EventArgs) Handles GerenciaBtn.Click
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Gerencia1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Calidad1.Visible = False
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub CalidadBtn_Click(sender As Object, e As EventArgs) Handles CalidadBtn.Click
        CalidadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Calidad1.Visible = True

        Produccion1.Visible = False
        ProduccionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Comercial1.Visible = False
        ComercialBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Ingenieria1.Visible = False
        IngenieriaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Compras1.Visible = False
        ComprasBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Financiera1.Visible = False
        FinancieraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Proyectos1.Visible = False
        ProyectosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gh1.Visible = False
        GHBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Despachos1.Visible = False
        DespachosBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Gerencia1.Visible = False
        GerenciaBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    End Sub

    Private Sub Principal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim user As String
        user = Me.Tag
        Dim AreaDm As String = ""

        Dim querry As String = "Select Area From Login where Name= '" & user & "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\geojo\Downloads\Acuerdos de Servicio DM\AcuerdosDM.accdb"
        Dim conn = New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        Try
            AreaDm = cmd.ExecuteScalar().ToString
        Catch ex As Exception
            MsgBox("ERROR")
        End Try

        If AreaDm = "INGENIERIA" Then
            ComercialBtn.Enabled = False
            ProduccionBtn.Enabled = False
            ProyectosBtn.Enabled = False
            DespachosBtn.Enabled = False
            FinancieraBtn.Enabled = False
            ComprasBtn.Enabled = False
            GerenciaBtn.Enabled = False
            GHBtn.Enabled = False
            CalidadBtn.Enabled = False
        Else
            If AreaDm = "COMERCIAL" Then
                IngenieriaBtn.Enabled = False
                ProduccionBtn.Enabled = False
                ProyectosBtn.Enabled = False
                DespachosBtn.Enabled = False
                FinancieraBtn.Enabled = False
                ComprasBtn.Enabled = False
                GerenciaBtn.Enabled = False
                GHBtn.Enabled = False
                CalidadBtn.Enabled = False
            Else
                If AreaDm = "PRODUCCION" Then
                    IngenieriaBtn.Enabled = False
                    ComercialBtn.Enabled = False
                    ProyectosBtn.Enabled = False
                    DespachosBtn.Enabled = False
                    FinancieraBtn.Enabled = False
                    ComprasBtn.Enabled = False
                    GerenciaBtn.Enabled = False
                    GHBtn.Enabled = False
                    CalidadBtn.Enabled = False
                Else
                    If AreaDm = "COMPRAS" Then
                        IngenieriaBtn.Enabled = False
                        ComercialBtn.Enabled = False
                        ProyectosBtn.Enabled = False
                        DespachosBtn.Enabled = False
                        FinancieraBtn.Enabled = False
                        ProduccionBtn.Enabled = False
                        GerenciaBtn.Enabled = False
                        GHBtn.Enabled = False
                        CalidadBtn.Enabled = False
                    Else
                        If AreaDm = "FINANCIERA" Then
                            IngenieriaBtn.Enabled = False
                            ComercialBtn.Enabled = False
                            ProyectosBtn.Enabled = False
                            DespachosBtn.Enabled = False
                            ComprasBtn.Enabled = False
                            ProduccionBtn.Enabled = False
                            GerenciaBtn.Enabled = False
                            GHBtn.Enabled = False
                            CalidadBtn.Enabled = False
                        Else
                            If AreaDm = "PROYECTOS" Then
                                IngenieriaBtn.Enabled = False
                                ComercialBtn.Enabled = False
                                FinancieraBtn.Enabled = False
                                DespachosBtn.Enabled = False
                                ComprasBtn.Enabled = False
                                ProduccionBtn.Enabled = False
                                GerenciaBtn.Enabled = False
                                GHBtn.Enabled = False
                                CalidadBtn.Enabled = False
                            Else
                                If AreaDm = "GH" Then
                                    IngenieriaBtn.Enabled = False
                                    ComercialBtn.Enabled = False
                                    FinancieraBtn.Enabled = False
                                    DespachosBtn.Enabled = False
                                    ComprasBtn.Enabled = False
                                    ProduccionBtn.Enabled = False
                                    GerenciaBtn.Enabled = False
                                    ProyectosBtn.Enabled = False
                                    CalidadBtn.Enabled = False
                                Else
                                    If AreaDm = "GERENCIA" Then
                                        IngenieriaBtn.Enabled = False
                                        ComercialBtn.Enabled = False
                                        FinancieraBtn.Enabled = False
                                        DespachosBtn.Enabled = False
                                        ComprasBtn.Enabled = False
                                        ProduccionBtn.Enabled = False
                                        GHBtn.Enabled = False
                                        ProyectosBtn.Enabled = False
                                        CalidadBtn.Enabled = False
                                    Else
                                        If AreaDm = "DESPACHOS" Then
                                            IngenieriaBtn.Enabled = False
                                            ComercialBtn.Enabled = False
                                            FinancieraBtn.Enabled = False
                                            ComprasBtn.Enabled = False
                                            ProduccionBtn.Enabled = False
                                            GerenciaBtn.Enabled = False
                                            GHBtn.Enabled = False
                                            ProyectosBtn.Enabled = False
                                            CalidadBtn.Enabled = False
                                        Else
                                            If AreaDm = "CALIDAD" Then
                                                IngenieriaBtn.Enabled = False
                                                ComercialBtn.Enabled = False
                                                FinancieraBtn.Enabled = False
                                                ComprasBtn.Enabled = False
                                                ProduccionBtn.Enabled = False
                                                GerenciaBtn.Enabled = False
                                                GHBtn.Enabled = False
                                                ProyectosBtn.Enabled = False
                                                DespachosBtn.Enabled = False
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Class