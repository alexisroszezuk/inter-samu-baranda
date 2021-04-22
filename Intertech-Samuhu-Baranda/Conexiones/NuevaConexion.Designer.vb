<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaConexion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtProvincia = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnBuscarCliente = New FontAwesome.Sharp.IconButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblidcliente = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.IconPictureBox2)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 51)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(51, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 23)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Nueva Conexion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtObservacion
        '
        Me.TxtObservacion.BackColor = System.Drawing.Color.Gray
        Me.TxtObservacion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TxtObservacion.Location = New System.Drawing.Point(212, 473)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(279, 81)
        Me.TxtObservacion.TabIndex = 107
        Me.TxtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.Gray
        Me.TxtEmail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TxtEmail.Location = New System.Drawing.Point(212, 440)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(279, 27)
        Me.TxtEmail.TabIndex = 106
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtProvincia
        '
        Me.TxtProvincia.BackColor = System.Drawing.Color.Gray
        Me.TxtProvincia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProvincia.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TxtProvincia.Location = New System.Drawing.Point(212, 406)
        Me.TxtProvincia.Name = "TxtProvincia"
        Me.TxtProvincia.Size = New System.Drawing.Size(279, 27)
        Me.TxtProvincia.TabIndex = 105
        Me.TxtProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCiudad
        '
        Me.TxtCiudad.BackColor = System.Drawing.Color.Gray
        Me.TxtCiudad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCiudad.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TxtCiudad.Location = New System.Drawing.Point(212, 372)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(279, 27)
        Me.TxtCiudad.TabIndex = 104
        Me.TxtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDni
        '
        Me.TxtDni.BackColor = System.Drawing.Color.Gray
        Me.TxtDni.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDni.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDni.Location = New System.Drawing.Point(212, 338)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(279, 27)
        Me.TxtDni.TabIndex = 103
        Me.TxtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.Gray
        Me.txtCelular.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtCelular.Location = New System.Drawing.Point(212, 304)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(279, 27)
        Me.txtCelular.TabIndex = 102
        Me.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BackColor = System.Drawing.Color.Gray
        Me.txtDomicilio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtDomicilio.Location = New System.Drawing.Point(212, 270)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(279, 27)
        Me.txtDomicilio.TabIndex = 101
        Me.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(27, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 34)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Observacion"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.BackColor = System.Drawing.Color.Gray
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtNombreCompleto.Location = New System.Drawing.Point(212, 236)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(279, 27)
        Me.txtNombreCompleto.TabIndex = 100
        Me.txtNombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(27, 435)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 34)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "Email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(27, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 34)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Provincia"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(27, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 34)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Ciudad"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(27, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 34)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "DNI"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(27, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 34)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Celular"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(27, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 34)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Domicilio Legal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(27, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 34)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "IP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gold
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnGuardar.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(257, 572)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Rotation = 20.0R
        Me.btnGuardar.Size = New System.Drawing.Size(205, 58)
        Me.btnGuardar.TabIndex = 108
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.GrayText
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.Gold
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Podcast
        Me.IconPictureBox2.IconColor = System.Drawing.Color.Gold
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 42
        Me.IconPictureBox2.Location = New System.Drawing.Point(239, 3)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(42, 42)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPictureBox2.TabIndex = 0
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Gold
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Podcast
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Gold
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 42
        Me.IconPictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(42, 42)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FloralWhite
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscarCliente.IconColor = System.Drawing.Color.SteelBlue
        Me.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarCliente.Location = New System.Drawing.Point(226, 67)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Rotation = 20.0R
        Me.btnBuscarCliente.Size = New System.Drawing.Size(228, 54)
        Me.btnBuscarCliente.TabIndex = 108
        Me.btnBuscarCliente.Text = "Buscar Cliente"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(27, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 34)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Nombre Completo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcliente
        '
        Me.lblcliente.BackColor = System.Drawing.Color.Transparent
        Me.lblcliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcliente.Location = New System.Drawing.Point(244, 180)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(168, 34)
        Me.lblcliente.TabIndex = 116
        Me.lblcliente.Text = "Busque el Cliente"
        Me.lblcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(27, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 34)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "N° Cliente"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblidcliente
        '
        Me.lblidcliente.BackColor = System.Drawing.Color.Transparent
        Me.lblidcliente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidcliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblidcliente.Location = New System.Drawing.Point(244, 136)
        Me.lblidcliente.Name = "lblidcliente"
        Me.lblidcliente.Size = New System.Drawing.Size(168, 34)
        Me.lblidcliente.TabIndex = 116
        Me.lblidcliente.Text = "0"
        Me.lblidcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NuevaConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(638, 641)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtProvincia)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNombreCompleto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblidcliente)
        Me.Controls.Add(Me.lblcliente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NuevaConexion"
        Me.Text = "NuevaConexion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtProvincia As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCliente As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcliente As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblidcliente As Label
End Class
