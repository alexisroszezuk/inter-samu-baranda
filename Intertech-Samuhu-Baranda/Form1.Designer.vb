<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblpunto_de_venta = New System.Windows.Forms.Label()
        Me.LBLIDUSUARIO = New System.Windows.Forms.Label()
        Me.LBLUSUARIO = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLMES = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnPresupuesto = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnDeudaFijas = New System.Windows.Forms.Button()
        Me.BtnGastoIngreso = New System.Windows.Forms.Button()
        Me.BtnCaja = New System.Windows.Forms.Button()
        Me.BtnPagoServicio = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtservidor = New System.Windows.Forms.TextBox()
        Me.txtbasededatos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblporcentaje
        '
        Me.lblporcentaje.AutoSize = True
        Me.lblporcentaje.Location = New System.Drawing.Point(701, 21)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.Size = New System.Drawing.Size(15, 13)
        Me.lblporcentaje.TabIndex = 89
        Me.lblporcentaje.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(663, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "%"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(383, 107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(425, 268)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'lblpunto_de_venta
        '
        Me.lblpunto_de_venta.AutoSize = True
        Me.lblpunto_de_venta.Location = New System.Drawing.Point(81, 58)
        Me.lblpunto_de_venta.Name = "lblpunto_de_venta"
        Me.lblpunto_de_venta.Size = New System.Drawing.Size(77, 13)
        Me.lblpunto_de_venta.TabIndex = 85
        Me.lblpunto_de_venta.Text = "MOSTRADOR"
        '
        'LBLIDUSUARIO
        '
        Me.LBLIDUSUARIO.AutoSize = True
        Me.LBLIDUSUARIO.Location = New System.Drawing.Point(12, 58)
        Me.LBLIDUSUARIO.Name = "LBLIDUSUARIO"
        Me.LBLIDUSUARIO.Size = New System.Drawing.Size(39, 13)
        Me.LBLIDUSUARIO.TabIndex = 78
        Me.LBLIDUSUARIO.Text = "Label6"
        '
        'LBLUSUARIO
        '
        Me.LBLUSUARIO.AutoSize = True
        Me.LBLUSUARIO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSUARIO.ForeColor = System.Drawing.Color.OrangeRed
        Me.LBLUSUARIO.Location = New System.Drawing.Point(105, 12)
        Me.LBLUSUARIO.Name = "LBLUSUARIO"
        Me.LBLUSUARIO.Size = New System.Drawing.Size(65, 19)
        Me.LBLUSUARIO.TabIndex = 75
        Me.LBLUSUARIO.Text = ".............."
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 45)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "USUARIO"
        '
        'LBLMES
        '
        Me.LBLMES.AutoSize = True
        Me.LBLMES.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMES.Location = New System.Drawing.Point(517, 12)
        Me.LBLMES.Name = "LBLMES"
        Me.LBLMES.Size = New System.Drawing.Size(25, 19)
        Me.LBLMES.TabIndex = 73
        Me.LBLMES.Text = "...."
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(401, 13)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(25, 19)
        Me.lblhora.TabIndex = 72
        Me.lblhora.Text = "...."
        '
        'lblfecha
        '
        Me.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblfecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(253, 4)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(358, 36)
        Me.lblfecha.TabIndex = 71
        Me.lblfecha.Text = "....."
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnProductos
        '
        Me.BtnProductos.BackColor = System.Drawing.Color.Transparent
        Me.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnProductos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnProductos.Location = New System.Drawing.Point(15, 351)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(173, 39)
        Me.BtnProductos.TabIndex = 69
        Me.BtnProductos.Text = "PRODUCTOS"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'BtnPresupuesto
        '
        Me.BtnPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.BtnPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPresupuesto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPresupuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPresupuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPresupuesto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPresupuesto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPresupuesto.Location = New System.Drawing.Point(15, 223)
        Me.BtnPresupuesto.Name = "BtnPresupuesto"
        Me.BtnPresupuesto.Size = New System.Drawing.Size(173, 39)
        Me.BtnPresupuesto.TabIndex = 67
        Me.BtnPresupuesto.Text = "PRESUPUESTO"
        Me.BtnPresupuesto.UseVisualStyleBackColor = False
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.Transparent
        Me.BtnVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnVenta.Location = New System.Drawing.Point(15, 161)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(173, 47)
        Me.BtnVenta.TabIndex = 61
        Me.BtnVenta.Text = "VENTA"
        Me.BtnVenta.UseVisualStyleBackColor = False
        '
        'BtnDeudaFijas
        '
        Me.BtnDeudaFijas.BackColor = System.Drawing.Color.Transparent
        Me.BtnDeudaFijas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeudaFijas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeudaFijas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeudaFijas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDeudaFijas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeudaFijas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeudaFijas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDeudaFijas.Location = New System.Drawing.Point(204, 161)
        Me.BtnDeudaFijas.Name = "BtnDeudaFijas"
        Me.BtnDeudaFijas.Size = New System.Drawing.Size(169, 39)
        Me.BtnDeudaFijas.TabIndex = 66
        Me.BtnDeudaFijas.Text = "DEUDA FIJAS"
        Me.BtnDeudaFijas.UseVisualStyleBackColor = False
        '
        'BtnGastoIngreso
        '
        Me.BtnGastoIngreso.BackColor = System.Drawing.Color.Transparent
        Me.BtnGastoIngreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGastoIngreso.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGastoIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGastoIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGastoIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGastoIngreso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGastoIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGastoIngreso.Location = New System.Drawing.Point(204, 223)
        Me.BtnGastoIngreso.Name = "BtnGastoIngreso"
        Me.BtnGastoIngreso.Size = New System.Drawing.Size(173, 39)
        Me.BtnGastoIngreso.TabIndex = 65
        Me.BtnGastoIngreso.Text = "GASTO / INGRESO"
        Me.BtnGastoIngreso.UseVisualStyleBackColor = False
        '
        'BtnCaja
        '
        Me.BtnCaja.BackColor = System.Drawing.Color.Transparent
        Me.BtnCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCaja.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCaja.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCaja.Location = New System.Drawing.Point(200, 111)
        Me.BtnCaja.Name = "BtnCaja"
        Me.BtnCaja.Size = New System.Drawing.Size(173, 39)
        Me.BtnCaja.TabIndex = 64
        Me.BtnCaja.Text = "CAJA"
        Me.BtnCaja.UseVisualStyleBackColor = False
        '
        'BtnPagoServicio
        '
        Me.BtnPagoServicio.BackColor = System.Drawing.Color.Transparent
        Me.BtnPagoServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPagoServicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPagoServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPagoServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPagoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagoServicio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagoServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPagoServicio.Location = New System.Drawing.Point(15, 286)
        Me.BtnPagoServicio.Name = "BtnPagoServicio"
        Me.BtnPagoServicio.Size = New System.Drawing.Size(170, 49)
        Me.BtnPagoServicio.TabIndex = 63
        Me.BtnPagoServicio.Text = "PAGO DE SERVICIO"
        Me.BtnPagoServicio.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClientes.Location = New System.Drawing.Point(15, 106)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(170, 49)
        Me.btnClientes.TabIndex = 62
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(511, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(93, 20)
        Me.DateTimePicker1.TabIndex = 76
        '
        'txtservidor
        '
        Me.txtservidor.Location = New System.Drawing.Point(392, 81)
        Me.txtservidor.Name = "txtservidor"
        Me.txtservidor.Size = New System.Drawing.Size(142, 20)
        Me.txtservidor.TabIndex = 90
        Me.txtservidor.Text = "192.168.248.3"
        Me.txtservidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbasededatos
        '
        Me.txtbasededatos.Location = New System.Drawing.Point(636, 78)
        Me.txtbasededatos.Name = "txtbasededatos"
        Me.txtbasededatos.Size = New System.Drawing.Size(142, 20)
        Me.txtbasededatos.TabIndex = 91
        Me.txtbasededatos.Text = "samuhu"
        Me.txtbasededatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Servidor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(551, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Base de Datos"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 417)
        Me.Controls.Add(Me.txtbasededatos)
        Me.Controls.Add(Me.txtservidor)
        Me.Controls.Add(Me.lblporcentaje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblpunto_de_venta)
        Me.Controls.Add(Me.LBLIDUSUARIO)
        Me.Controls.Add(Me.LBLUSUARIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLMES)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.BtnProductos)
        Me.Controls.Add(Me.BtnPresupuesto)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.BtnDeudaFijas)
        Me.Controls.Add(Me.BtnGastoIngreso)
        Me.Controls.Add(Me.BtnCaja)
        Me.Controls.Add(Me.BtnPagoServicio)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form1"
        Me.Text = "Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblporcentaje As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblpunto_de_venta As Label
    Friend WithEvents LBLIDUSUARIO As Label
    Friend WithEvents LBLUSUARIO As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLMES As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnPresupuesto As Button
    Friend WithEvents BtnVenta As Button
    Friend WithEvents BtnDeudaFijas As Button
    Friend WithEvents BtnGastoIngreso As Button
    Friend WithEvents BtnCaja As Button
    Friend WithEvents BtnPagoServicio As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtservidor As TextBox
    Friend WithEvents txtbasededatos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
End Class
