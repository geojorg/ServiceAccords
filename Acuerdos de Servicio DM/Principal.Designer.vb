<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CalidadBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GerenciaBtn = New System.Windows.Forms.Button()
        Me.DespachosBtn = New System.Windows.Forms.Button()
        Me.ProyectosBtn = New System.Windows.Forms.Button()
        Me.GHBtn = New System.Windows.Forms.Button()
        Me.FinancieraBtn = New System.Windows.Forms.Button()
        Me.ComprasBtn = New System.Windows.Forms.Button()
        Me.IngenieriaBtn = New System.Windows.Forms.Button()
        Me.ComercialBtn = New System.Windows.Forms.Button()
        Me.ProduccionBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BIENVENIDOS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Calidad1 = New Acuerdos_de_Servicio_DM.Calidad()
        Me.Gerencia1 = New Acuerdos_de_Servicio_DM.Gerencia()
        Me.Gh1 = New Acuerdos_de_Servicio_DM.GH()
        Me.Proyectos1 = New Acuerdos_de_Servicio_DM.Proyectos()
        Me.Ingenieria1 = New Acuerdos_de_Servicio_DM.Ingenieria()
        Me.Financiera1 = New Acuerdos_de_Servicio_DM.Financiera()
        Me.Despachos1 = New Acuerdos_de_Servicio_DM.Despachos()
        Me.Compras1 = New Acuerdos_de_Servicio_DM.Compras()
        Me.Produccion1 = New Acuerdos_de_Servicio_DM.Produccion()
        Me.Comercial1 = New Acuerdos_de_Servicio_DM.Comercial()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CalidadBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GerenciaBtn)
        Me.Panel1.Controls.Add(Me.DespachosBtn)
        Me.Panel1.Controls.Add(Me.ProyectosBtn)
        Me.Panel1.Controls.Add(Me.GHBtn)
        Me.Panel1.Controls.Add(Me.FinancieraBtn)
        Me.Panel1.Controls.Add(Me.ComprasBtn)
        Me.Panel1.Controls.Add(Me.IngenieriaBtn)
        Me.Panel1.Controls.Add(Me.ComercialBtn)
        Me.Panel1.Controls.Add(Me.ProduccionBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 604)
        Me.Panel1.TabIndex = 2
        '
        'CalidadBtn
        '
        Me.CalidadBtn.FlatAppearance.BorderSize = 0
        Me.CalidadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalidadBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalidadBtn.ForeColor = System.Drawing.Color.White
        Me.CalidadBtn.Image = CType(resources.GetObject("CalidadBtn.Image"), System.Drawing.Image)
        Me.CalidadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CalidadBtn.Location = New System.Drawing.Point(0, 49)
        Me.CalidadBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CalidadBtn.Name = "CalidadBtn"
        Me.CalidadBtn.Size = New System.Drawing.Size(224, 51)
        Me.CalidadBtn.TabIndex = 17
        Me.CalidadBtn.Text = "       CALIDAD"
        Me.CalidadBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "AREA SOLICITANTE:"
        '
        'GerenciaBtn
        '
        Me.GerenciaBtn.FlatAppearance.BorderSize = 0
        Me.GerenciaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GerenciaBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GerenciaBtn.ForeColor = System.Drawing.Color.White
        Me.GerenciaBtn.Image = CType(resources.GetObject("GerenciaBtn.Image"), System.Drawing.Image)
        Me.GerenciaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GerenciaBtn.Location = New System.Drawing.Point(-3, 552)
        Me.GerenciaBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GerenciaBtn.Name = "GerenciaBtn"
        Me.GerenciaBtn.Size = New System.Drawing.Size(224, 51)
        Me.GerenciaBtn.TabIndex = 1
        Me.GerenciaBtn.Text = "     GERENCIA"
        Me.GerenciaBtn.UseVisualStyleBackColor = True
        '
        'DespachosBtn
        '
        Me.DespachosBtn.FlatAppearance.BorderSize = 0
        Me.DespachosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DespachosBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DespachosBtn.ForeColor = System.Drawing.Color.White
        Me.DespachosBtn.Image = CType(resources.GetObject("DespachosBtn.Image"), System.Drawing.Image)
        Me.DespachosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DespachosBtn.Location = New System.Drawing.Point(-3, 495)
        Me.DespachosBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DespachosBtn.Name = "DespachosBtn"
        Me.DespachosBtn.Size = New System.Drawing.Size(224, 51)
        Me.DespachosBtn.TabIndex = 1
        Me.DespachosBtn.Text = "     DESPACHOS"
        Me.DespachosBtn.UseVisualStyleBackColor = True
        '
        'ProyectosBtn
        '
        Me.ProyectosBtn.FlatAppearance.BorderSize = 0
        Me.ProyectosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProyectosBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProyectosBtn.ForeColor = System.Drawing.Color.White
        Me.ProyectosBtn.Image = CType(resources.GetObject("ProyectosBtn.Image"), System.Drawing.Image)
        Me.ProyectosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProyectosBtn.Location = New System.Drawing.Point(-3, 386)
        Me.ProyectosBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProyectosBtn.Name = "ProyectosBtn"
        Me.ProyectosBtn.Size = New System.Drawing.Size(224, 51)
        Me.ProyectosBtn.TabIndex = 1
        Me.ProyectosBtn.Text = "     PROYECTOS"
        Me.ProyectosBtn.UseVisualStyleBackColor = True
        '
        'GHBtn
        '
        Me.GHBtn.FlatAppearance.BorderSize = 0
        Me.GHBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GHBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GHBtn.ForeColor = System.Drawing.Color.White
        Me.GHBtn.Image = CType(resources.GetObject("GHBtn.Image"), System.Drawing.Image)
        Me.GHBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GHBtn.Location = New System.Drawing.Point(-3, 438)
        Me.GHBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GHBtn.Name = "GHBtn"
        Me.GHBtn.Size = New System.Drawing.Size(224, 51)
        Me.GHBtn.TabIndex = 1
        Me.GHBtn.Text = "     GH"
        Me.GHBtn.UseVisualStyleBackColor = True
        '
        'FinancieraBtn
        '
        Me.FinancieraBtn.FlatAppearance.BorderSize = 0
        Me.FinancieraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinancieraBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinancieraBtn.ForeColor = System.Drawing.Color.White
        Me.FinancieraBtn.Image = CType(resources.GetObject("FinancieraBtn.Image"), System.Drawing.Image)
        Me.FinancieraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FinancieraBtn.Location = New System.Drawing.Point(-3, 329)
        Me.FinancieraBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FinancieraBtn.Name = "FinancieraBtn"
        Me.FinancieraBtn.Size = New System.Drawing.Size(224, 51)
        Me.FinancieraBtn.TabIndex = 1
        Me.FinancieraBtn.Text = "      FINANCIERA"
        Me.FinancieraBtn.UseVisualStyleBackColor = True
        '
        'ComprasBtn
        '
        Me.ComprasBtn.FlatAppearance.BorderSize = 0
        Me.ComprasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComprasBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComprasBtn.ForeColor = System.Drawing.Color.White
        Me.ComprasBtn.Image = CType(resources.GetObject("ComprasBtn.Image"), System.Drawing.Image)
        Me.ComprasBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComprasBtn.Location = New System.Drawing.Point(-3, 272)
        Me.ComprasBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComprasBtn.Name = "ComprasBtn"
        Me.ComprasBtn.Size = New System.Drawing.Size(224, 51)
        Me.ComprasBtn.TabIndex = 1
        Me.ComprasBtn.Text = "      COMPRAS"
        Me.ComprasBtn.UseVisualStyleBackColor = True
        '
        'IngenieriaBtn
        '
        Me.IngenieriaBtn.FlatAppearance.BorderSize = 0
        Me.IngenieriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IngenieriaBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngenieriaBtn.ForeColor = System.Drawing.Color.White
        Me.IngenieriaBtn.Image = CType(resources.GetObject("IngenieriaBtn.Image"), System.Drawing.Image)
        Me.IngenieriaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IngenieriaBtn.Location = New System.Drawing.Point(-3, 215)
        Me.IngenieriaBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IngenieriaBtn.Name = "IngenieriaBtn"
        Me.IngenieriaBtn.Size = New System.Drawing.Size(224, 51)
        Me.IngenieriaBtn.TabIndex = 1
        Me.IngenieriaBtn.Text = "      INGENIERIA"
        Me.IngenieriaBtn.UseVisualStyleBackColor = True
        '
        'ComercialBtn
        '
        Me.ComercialBtn.FlatAppearance.BorderSize = 0
        Me.ComercialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComercialBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComercialBtn.ForeColor = System.Drawing.Color.White
        Me.ComercialBtn.Image = CType(resources.GetObject("ComercialBtn.Image"), System.Drawing.Image)
        Me.ComercialBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ComercialBtn.Location = New System.Drawing.Point(-3, 101)
        Me.ComercialBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComercialBtn.Name = "ComercialBtn"
        Me.ComercialBtn.Size = New System.Drawing.Size(224, 51)
        Me.ComercialBtn.TabIndex = 1
        Me.ComercialBtn.Text = "        COMERCIAL"
        Me.ComercialBtn.UseVisualStyleBackColor = True
        '
        'ProduccionBtn
        '
        Me.ProduccionBtn.FlatAppearance.BorderSize = 0
        Me.ProduccionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProduccionBtn.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProduccionBtn.ForeColor = System.Drawing.Color.White
        Me.ProduccionBtn.Image = CType(resources.GetObject("ProduccionBtn.Image"), System.Drawing.Image)
        Me.ProduccionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProduccionBtn.Location = New System.Drawing.Point(-3, 158)
        Me.ProduccionBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProduccionBtn.Name = "ProduccionBtn"
        Me.ProduccionBtn.Size = New System.Drawing.Size(224, 51)
        Me.ProduccionBtn.TabIndex = 1
        Me.ProduccionBtn.Text = "        PRODUCCION"
        Me.ProduccionBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(224, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 24)
        Me.Panel2.TabIndex = 7
        '
        'BIENVENIDOS
        '
        Me.BIENVENIDOS.AutoSize = True
        Me.BIENVENIDOS.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BIENVENIDOS.Location = New System.Drawing.Point(239, 38)
        Me.BIENVENIDOS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BIENVENIDOS.Name = "BIENVENIDOS"
        Me.BIENVENIDOS.Size = New System.Drawing.Size(243, 41)
        Me.BIENVENIDOS.TabIndex = 8
        Me.BIENVENIDOS.Text = "BIENVENIDOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(224, 260)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(702, 344)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(656, 129)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Calidad1
        '
        Me.Calidad1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calidad1.Location = New System.Drawing.Point(224, 21)
        Me.Calidad1.Name = "Calidad1"
        Me.Calidad1.Size = New System.Drawing.Size(702, 583)
        Me.Calidad1.TabIndex = 20
        Me.Calidad1.Visible = False
        '
        'Gerencia1
        '
        Me.Gerencia1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gerencia1.Location = New System.Drawing.Point(224, 21)
        Me.Gerencia1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Gerencia1.Name = "Gerencia1"
        Me.Gerencia1.Size = New System.Drawing.Size(702, 583)
        Me.Gerencia1.TabIndex = 19
        Me.Gerencia1.Visible = False
        '
        'Gh1
        '
        Me.Gh1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gh1.Location = New System.Drawing.Point(224, 21)
        Me.Gh1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Gh1.Name = "Gh1"
        Me.Gh1.Size = New System.Drawing.Size(702, 583)
        Me.Gh1.TabIndex = 17
        Me.Gh1.Visible = False
        '
        'Proyectos1
        '
        Me.Proyectos1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Proyectos1.Location = New System.Drawing.Point(224, 21)
        Me.Proyectos1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Proyectos1.Name = "Proyectos1"
        Me.Proyectos1.Size = New System.Drawing.Size(702, 583)
        Me.Proyectos1.TabIndex = 16
        Me.Proyectos1.Visible = False
        '
        'Ingenieria1
        '
        Me.Ingenieria1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ingenieria1.Location = New System.Drawing.Point(224, 21)
        Me.Ingenieria1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Ingenieria1.Name = "Ingenieria1"
        Me.Ingenieria1.Size = New System.Drawing.Size(702, 583)
        Me.Ingenieria1.TabIndex = 13
        Me.Ingenieria1.Visible = False
        '
        'Financiera1
        '
        Me.Financiera1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Financiera1.Location = New System.Drawing.Point(224, 21)
        Me.Financiera1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Financiera1.Name = "Financiera1"
        Me.Financiera1.Size = New System.Drawing.Size(702, 583)
        Me.Financiera1.TabIndex = 15
        Me.Financiera1.Visible = False
        '
        'Despachos1
        '
        Me.Despachos1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Despachos1.Location = New System.Drawing.Point(224, 21)
        Me.Despachos1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Despachos1.Name = "Despachos1"
        Me.Despachos1.Size = New System.Drawing.Size(702, 583)
        Me.Despachos1.TabIndex = 18
        Me.Despachos1.Visible = False
        '
        'Compras1
        '
        Me.Compras1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Compras1.Location = New System.Drawing.Point(224, 21)
        Me.Compras1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Compras1.Name = "Compras1"
        Me.Compras1.Size = New System.Drawing.Size(702, 583)
        Me.Compras1.TabIndex = 14
        Me.Compras1.Visible = False
        '
        'Produccion1
        '
        Me.Produccion1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Produccion1.Location = New System.Drawing.Point(224, 21)
        Me.Produccion1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Produccion1.Name = "Produccion1"
        Me.Produccion1.Size = New System.Drawing.Size(702, 583)
        Me.Produccion1.TabIndex = 12
        Me.Produccion1.Visible = False
        '
        'Comercial1
        '
        Me.Comercial1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Comercial1.Location = New System.Drawing.Point(224, 21)
        Me.Comercial1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Comercial1.Name = "Comercial1"
        Me.Comercial1.Size = New System.Drawing.Size(702, 583)
        Me.Comercial1.TabIndex = 11
        Me.Comercial1.Visible = False
        '
        'Principal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(926, 604)
        Me.Controls.Add(Me.Calidad1)
        Me.Controls.Add(Me.Gerencia1)
        Me.Controls.Add(Me.Gh1)
        Me.Controls.Add(Me.Proyectos1)
        Me.Controls.Add(Me.Ingenieria1)
        Me.Controls.Add(Me.Financiera1)
        Me.Controls.Add(Me.Despachos1)
        Me.Controls.Add(Me.Compras1)
        Me.Controls.Add(Me.Produccion1)
        Me.Controls.Add(Me.Comercial1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BIENVENIDOS)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Principal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acuerdos de Servicios DM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GerenciaBtn As Button
    Friend WithEvents DespachosBtn As Button
    Friend WithEvents ProyectosBtn As Button
    Friend WithEvents GHBtn As Button
    Friend WithEvents FinancieraBtn As Button
    Friend WithEvents ComprasBtn As Button
    Friend WithEvents IngenieriaBtn As Button
    Friend WithEvents ComercialBtn As Button
    Friend WithEvents ProduccionBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BIENVENIDOS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Comercial1 As Comercial
    Friend WithEvents Produccion1 As Produccion
    Friend WithEvents Ingenieria1 As Ingenieria
    Friend WithEvents Compras1 As Compras
    Friend WithEvents Financiera1 As Financiera
    Friend WithEvents Despachos1 As Despachos
    Friend WithEvents Proyectos1 As Proyectos
    Friend WithEvents Gh1 As GH
    Friend WithEvents Gerencia1 As Gerencia
    Friend WithEvents CalidadBtn As Button
    Friend WithEvents Calidad1 As Calidad
End Class
