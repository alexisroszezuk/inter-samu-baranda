<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusquedaCliente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbidcliente = New System.Windows.Forms.ComboBox()
        Me.Cmbcliente = New System.Windows.Forms.ComboBox()
        Me.btnBusquedaCliente = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(800, 51)
        Me.Panel1.TabIndex = 4
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.GrayText
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.IconPictureBox2.IconColor = System.Drawing.Color.CornflowerBlue
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 42
        Me.IconPictureBox2.Location = New System.Drawing.Point(253, 3)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(42, 42)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPictureBox2.TabIndex = 0
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.IconPictureBox1.IconColor = System.Drawing.Color.CornflowerBlue
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 42
        Me.IconPictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(42, 42)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
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
        Me.Label2.Size = New System.Drawing.Size(199, 23)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Busqueda Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.BackColor = System.Drawing.Color.Gray
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtNombreCompleto.Location = New System.Drawing.Point(81, 91)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(279, 27)
        Me.txtNombreCompleto.TabIndex = 100
        Me.txtNombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(65, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 34)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Busqueda por Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(775, 308)
        Me.DataGridView1.TabIndex = 102
        '
        'cmbidcliente
        '
        Me.cmbidcliente.BackColor = System.Drawing.Color.DarkGray
        Me.cmbidcliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbidcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbidcliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbidcliente.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbidcliente.FormattingEnabled = True
        Me.cmbidcliente.Location = New System.Drawing.Point(379, 91)
        Me.cmbidcliente.Name = "cmbidcliente"
        Me.cmbidcliente.Size = New System.Drawing.Size(87, 22)
        Me.cmbidcliente.TabIndex = 103
        '
        'Cmbcliente
        '
        Me.Cmbcliente.BackColor = System.Drawing.Color.DarkGray
        Me.Cmbcliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcliente.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbcliente.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Cmbcliente.FormattingEnabled = True
        Me.Cmbcliente.Location = New System.Drawing.Point(472, 91)
        Me.Cmbcliente.Name = "Cmbcliente"
        Me.Cmbcliente.Size = New System.Drawing.Size(316, 22)
        Me.Cmbcliente.TabIndex = 103
        '
        'btnBusquedaCliente
        '
        Me.btnBusquedaCliente.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnBusquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusquedaCliente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusquedaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBusquedaCliente.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnBusquedaCliente.IconColor = System.Drawing.Color.Black
        Me.btnBusquedaCliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBusquedaCliente.Location = New System.Drawing.Point(13, 57)
        Me.btnBusquedaCliente.Name = "btnBusquedaCliente"
        Me.btnBusquedaCliente.Size = New System.Drawing.Size(62, 61)
        Me.btnBusquedaCliente.TabIndex = 104
        Me.btnBusquedaCliente.Text = "Venta"
        Me.btnBusquedaCliente.UseVisualStyleBackColor = True
        '
        'BusquedaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBusquedaCliente)
        Me.Controls.Add(Me.Cmbcliente)
        Me.Controls.Add(Me.cmbidcliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNombreCompleto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BusquedaCliente"
        Me.Text = "BusquedaCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbidcliente As ComboBox
    Friend WithEvents Cmbcliente As ComboBox
    Friend WithEvents btnBusquedaCliente As FontAwesome.Sharp.IconButton
End Class
