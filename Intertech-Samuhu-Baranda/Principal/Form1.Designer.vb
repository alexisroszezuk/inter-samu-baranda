﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblpunto_de_venta = New System.Windows.Forms.Label()
        Me.LBLIDUSUARIO = New System.Windows.Forms.Label()
        Me.LBLUSUARIO = New System.Windows.Forms.Label()
        Me.LBLMES = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtservidor = New System.Windows.Forms.TextBox()
        Me.txtbasededatos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnGastos = New FontAwesome.Sharp.IconButton()
        Me.BtnCajas = New FontAwesome.Sharp.IconButton()
        Me.BtnCobranza = New FontAwesome.Sharp.IconButton()
        Me.btnConexiones = New FontAwesome.Sharp.IconButton()
        Me.BtnClientes = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblpunto_de_venta
        '
        Me.lblpunto_de_venta.AutoSize = True
        Me.lblpunto_de_venta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpunto_de_venta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblpunto_de_venta.Location = New System.Drawing.Point(479, 495)
        Me.lblpunto_de_venta.Name = "lblpunto_de_venta"
        Me.lblpunto_de_venta.Size = New System.Drawing.Size(82, 13)
        Me.lblpunto_de_venta.TabIndex = 85
        Me.lblpunto_de_venta.Text = "MOSTRADOR"
        '
        'LBLIDUSUARIO
        '
        Me.LBLIDUSUARIO.AutoSize = True
        Me.LBLIDUSUARIO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIDUSUARIO.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLIDUSUARIO.Location = New System.Drawing.Point(699, 495)
        Me.LBLIDUSUARIO.Name = "LBLIDUSUARIO"
        Me.LBLIDUSUARIO.Size = New System.Drawing.Size(14, 13)
        Me.LBLIDUSUARIO.TabIndex = 78
        Me.LBLIDUSUARIO.Text = "1"
        '
        'LBLUSUARIO
        '
        Me.LBLUSUARIO.AutoSize = True
        Me.LBLUSUARIO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSUARIO.ForeColor = System.Drawing.Color.Snow
        Me.LBLUSUARIO.Location = New System.Drawing.Point(741, 493)
        Me.LBLUSUARIO.Name = "LBLUSUARIO"
        Me.LBLUSUARIO.Size = New System.Drawing.Size(63, 13)
        Me.LBLUSUARIO.TabIndex = 75
        Me.LBLUSUARIO.Text = ".............."
        '
        'LBLMES
        '
        Me.LBLMES.AutoSize = True
        Me.LBLMES.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMES.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLMES.Location = New System.Drawing.Point(741, 18)
        Me.LBLMES.Name = "LBLMES"
        Me.LBLMES.Size = New System.Drawing.Size(23, 14)
        Me.LBLMES.TabIndex = 73
        Me.LBLMES.Text = "...."
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblhora.Location = New System.Drawing.Point(642, 18)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(23, 14)
        Me.lblhora.TabIndex = 72
        Me.lblhora.Text = "...."
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblfecha.Location = New System.Drawing.Point(529, 18)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(27, 14)
        Me.lblfecha.TabIndex = 71
        Me.lblfecha.Text = "....."
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1049, 254)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(93, 26)
        Me.DateTimePicker1.TabIndex = 76
        Me.DateTimePicker1.Visible = False
        '
        'txtservidor
        '
        Me.txtservidor.BackColor = System.Drawing.Color.Gray
        Me.txtservidor.Enabled = False
        Me.txtservidor.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtservidor.Location = New System.Drawing.Point(960, 491)
        Me.txtservidor.Name = "txtservidor"
        Me.txtservidor.Size = New System.Drawing.Size(82, 20)
        Me.txtservidor.TabIndex = 90
        Me.txtservidor.Text = "192.168.248.3"
        Me.txtservidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbasededatos
        '
        Me.txtbasededatos.BackColor = System.Drawing.Color.Gray
        Me.txtbasededatos.Enabled = False
        Me.txtbasededatos.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtbasededatos.Location = New System.Drawing.Point(854, 491)
        Me.txtbasededatos.Name = "txtbasededatos"
        Me.txtbasededatos.Size = New System.Drawing.Size(89, 20)
        Me.txtbasededatos.TabIndex = 91
        Me.txtbasededatos.Text = "samuhu"
        Me.txtbasededatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(979, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Servidor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(866, 466)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Base de Datos"
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.BtnGastos)
        Me.Panel2.Controls.Add(Me.BtnCajas)
        Me.Panel2.Controls.Add(Me.BtnCobranza)
        Me.Panel2.Controls.Add(Me.btnConexiones)
        Me.Panel2.Controls.Add(Me.BtnClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 523)
        Me.Panel2.TabIndex = 93
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Intertech_Samuhu_Baranda.My.Resources.Resources.InterTech_Logo_Photoshop_Alta_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 74)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnGastos
        '
        Me.BtnGastos.BackColor = System.Drawing.Color.Transparent
        Me.BtnGastos.FlatAppearance.BorderSize = 0
        Me.BtnGastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGastos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGastos.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGastos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGastos.IconChar = FontAwesome.Sharp.IconChar.Tasks
        Me.BtnGastos.IconColor = System.Drawing.Color.WhiteSmoke
        Me.BtnGastos.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGastos.Location = New System.Drawing.Point(3, 373)
        Me.BtnGastos.Name = "BtnGastos"
        Me.BtnGastos.Size = New System.Drawing.Size(194, 56)
        Me.BtnGastos.TabIndex = 0
        Me.BtnGastos.Text = "Gastos"
        Me.BtnGastos.UseVisualStyleBackColor = False
        '
        'BtnCajas
        '
        Me.BtnCajas.BackColor = System.Drawing.Color.Transparent
        Me.BtnCajas.FlatAppearance.BorderSize = 0
        Me.BtnCajas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnCajas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCajas.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCajas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCajas.IconChar = FontAwesome.Sharp.IconChar.Receipt
        Me.BtnCajas.IconColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCajas.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnCajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCajas.Location = New System.Drawing.Point(3, 311)
        Me.BtnCajas.Name = "BtnCajas"
        Me.BtnCajas.Size = New System.Drawing.Size(194, 56)
        Me.BtnCajas.TabIndex = 0
        Me.BtnCajas.Text = "Cajas"
        Me.BtnCajas.UseVisualStyleBackColor = False
        '
        'BtnCobranza
        '
        Me.BtnCobranza.BackColor = System.Drawing.Color.Transparent
        Me.BtnCobranza.FlatAppearance.BorderSize = 0
        Me.BtnCobranza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnCobranza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCobranza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCobranza.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCobranza.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCobranza.IconChar = FontAwesome.Sharp.IconChar.SearchDollar
        Me.BtnCobranza.IconColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCobranza.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnCobranza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCobranza.Location = New System.Drawing.Point(3, 249)
        Me.BtnCobranza.Name = "BtnCobranza"
        Me.BtnCobranza.Size = New System.Drawing.Size(194, 56)
        Me.BtnCobranza.TabIndex = 0
        Me.BtnCobranza.Text = "Cobranza"
        Me.BtnCobranza.UseVisualStyleBackColor = False
        '
        'btnConexiones
        '
        Me.btnConexiones.BackColor = System.Drawing.Color.Transparent
        Me.btnConexiones.FlatAppearance.BorderSize = 0
        Me.btnConexiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnConexiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnConexiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConexiones.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConexiones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConexiones.IconChar = FontAwesome.Sharp.IconChar.Podcast
        Me.btnConexiones.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnConexiones.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnConexiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConexiones.Location = New System.Drawing.Point(3, 187)
        Me.btnConexiones.Name = "btnConexiones"
        Me.btnConexiones.Size = New System.Drawing.Size(194, 56)
        Me.btnConexiones.TabIndex = 0
        Me.btnConexiones.Text = "Conexiones"
        Me.btnConexiones.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry
        Me.BtnClientes.IconColor = System.Drawing.Color.WhiteSmoke
        Me.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(0, 125)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(194, 56)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.LBLMES)
        Me.Panel1.Controls.Add(Me.lblhora)
        Me.Panel1.Controls.Add(Me.lblfecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(197, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 55)
        Me.Panel1.TabIndex = 94
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1048, 523)
        Me.Controls.Add(Me.lblpunto_de_venta)
        Me.Controls.Add(Me.LBLIDUSUARIO)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LBLUSUARIO)
        Me.Controls.Add(Me.txtbasededatos)
        Me.Controls.Add(Me.txtservidor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpunto_de_venta As Label
    Friend WithEvents LBLIDUSUARIO As Label
    Friend WithEvents LBLUSUARIO As Label
    Friend WithEvents LBLMES As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtservidor As TextBox
    Friend WithEvents txtbasededatos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGastos As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCajas As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCobranza As FontAwesome.Sharp.IconButton
    Friend WithEvents btnConexiones As FontAwesome.Sharp.IconButton
End Class
