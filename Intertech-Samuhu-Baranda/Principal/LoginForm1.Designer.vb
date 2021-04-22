<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.CmbBasedeDatos = New System.Windows.Forms.ComboBox()
        Me.LblBasedeDatos = New System.Windows.Forms.Label()
        Me.cmbIpRouterBoard = New System.Windows.Forms.ComboBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbClaveRouter = New System.Windows.Forms.ComboBox()
        Me.CmbUsuarioRouter = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbusuariodb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbClavedb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbservidormysql = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ok = New FontAwesome.Sharp.IconButton()
        Me.Cancel = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.UsernameLabel.Location = New System.Drawing.Point(50, 289)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(166, 23)
        Me.UsernameLabel.TabIndex = 99
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.PasswordLabel.Location = New System.Drawing.Point(81, 346)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(104, 23)
        Me.PasswordLabel.TabIndex = 99
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.DimGray
        Me.TxtUsuario.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtUsuario.Location = New System.Drawing.Point(24, 315)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(220, 23)
        Me.TxtUsuario.TabIndex = 1
        Me.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.DimGray
        Me.TxtPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtPassword.Location = New System.Drawing.Point(24, 372)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(220, 23)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbBasedeDatos
        '
        Me.CmbBasedeDatos.BackColor = System.Drawing.Color.DarkGray
        Me.CmbBasedeDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbBasedeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBasedeDatos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBasedeDatos.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CmbBasedeDatos.FormattingEnabled = True
        Me.CmbBasedeDatos.Location = New System.Drawing.Point(28, 237)
        Me.CmbBasedeDatos.Name = "CmbBasedeDatos"
        Me.CmbBasedeDatos.Size = New System.Drawing.Size(218, 22)
        Me.CmbBasedeDatos.TabIndex = 0
        '
        'LblBasedeDatos
        '
        Me.LblBasedeDatos.AutoSize = True
        Me.LblBasedeDatos.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBasedeDatos.ForeColor = System.Drawing.SystemColors.Control
        Me.LblBasedeDatos.Location = New System.Drawing.Point(44, 216)
        Me.LblBasedeDatos.Name = "LblBasedeDatos"
        Me.LblBasedeDatos.Size = New System.Drawing.Size(156, 18)
        Me.LblBasedeDatos.TabIndex = 99
        Me.LblBasedeDatos.Text = "Seleccione Empresa"
        '
        'cmbIpRouterBoard
        '
        Me.cmbIpRouterBoard.Enabled = False
        Me.cmbIpRouterBoard.FormattingEnabled = True
        Me.cmbIpRouterBoard.Location = New System.Drawing.Point(303, 22)
        Me.cmbIpRouterBoard.Name = "cmbIpRouterBoard"
        Me.cmbIpRouterBoard.Size = New System.Drawing.Size(218, 21)
        Me.cmbIpRouterBoard.TabIndex = 99
        '
        'CmbEstado
        '
        Me.CmbEstado.Enabled = False
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(303, 85)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(218, 21)
        Me.CmbEstado.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Ip RouterBoard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(607, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Clave RouterBoard"
        '
        'CmbClaveRouter
        '
        Me.CmbClaveRouter.Enabled = False
        Me.CmbClaveRouter.FormattingEnabled = True
        Me.CmbClaveRouter.Location = New System.Drawing.Point(544, 22)
        Me.CmbClaveRouter.Name = "CmbClaveRouter"
        Me.CmbClaveRouter.Size = New System.Drawing.Size(218, 21)
        Me.CmbClaveRouter.TabIndex = 99
        '
        'CmbUsuarioRouter
        '
        Me.CmbUsuarioRouter.Enabled = False
        Me.CmbUsuarioRouter.FormattingEnabled = True
        Me.CmbUsuarioRouter.Location = New System.Drawing.Point(542, 85)
        Me.CmbUsuarioRouter.Name = "CmbUsuarioRouter"
        Me.CmbUsuarioRouter.Size = New System.Drawing.Size(218, 21)
        Me.CmbUsuarioRouter.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(607, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Usuario RouterBoard"
        '
        'cmbusuariodb
        '
        Me.cmbusuariodb.Enabled = False
        Me.cmbusuariodb.FormattingEnabled = True
        Me.cmbusuariodb.Location = New System.Drawing.Point(542, 136)
        Me.cmbusuariodb.Name = "cmbusuariodb"
        Me.cmbusuariodb.Size = New System.Drawing.Size(218, 21)
        Me.cmbusuariodb.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(607, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Usuario DB"
        '
        'CmbClavedb
        '
        Me.CmbClavedb.Enabled = False
        Me.CmbClavedb.FormattingEnabled = True
        Me.CmbClavedb.Location = New System.Drawing.Point(542, 183)
        Me.CmbClavedb.Name = "CmbClavedb"
        Me.CmbClavedb.Size = New System.Drawing.Size(218, 21)
        Me.CmbClavedb.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(607, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Clave DB"
        '
        'cmbservidormysql
        '
        Me.cmbservidormysql.Enabled = False
        Me.cmbservidormysql.FormattingEnabled = True
        Me.cmbservidormysql.Location = New System.Drawing.Point(307, 136)
        Me.cmbservidormysql.Name = "cmbservidormysql"
        Me.cmbservidormysql.Size = New System.Drawing.Size(218, 21)
        Me.cmbservidormysql.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(372, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Servidor MYsql"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Intertech_Samuhu_Baranda.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 194)
        Me.PictureBox1.TabIndex = 100
        Me.PictureBox1.TabStop = False
        '
        'ok
        '
        Me.ok.FlatAppearance.BorderSize = 0
        Me.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp
        Me.ok.IconColor = System.Drawing.Color.White
        Me.ok.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ok.Location = New System.Drawing.Point(28, 425)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(98, 55)
        Me.ok.TabIndex = 101
        Me.ok.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown
        Me.Cancel.IconColor = System.Drawing.Color.White
        Me.Cancel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Cancel.Location = New System.Drawing.Point(143, 427)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(89, 53)
        Me.Cancel.TabIndex = 102
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'LoginForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(272, 498)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbClaveRouter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbservidormysql)
        Me.Controls.Add(Me.LblBasedeDatos)
        Me.Controls.Add(Me.CmbClavedb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbusuariodb)
        Me.Controls.Add(Me.CmbUsuarioRouter)
        Me.Controls.Add(Me.CmbEstado)
        Me.Controls.Add(Me.cmbIpRouterBoard)
        Me.Controls.Add(Me.CmbBasedeDatos)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Acceso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbBasedeDatos As ComboBox
    Friend WithEvents LblBasedeDatos As Label
    Friend WithEvents cmbIpRouterBoard As ComboBox
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbClaveRouter As ComboBox
    Friend WithEvents CmbUsuarioRouter As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbusuariodb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbClavedb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbservidormysql As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ok As FontAwesome.Sharp.IconButton
    Friend WithEvents Cancel As FontAwesome.Sharp.IconButton
End Class
