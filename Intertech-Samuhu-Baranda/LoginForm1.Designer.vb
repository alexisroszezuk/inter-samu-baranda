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
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

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
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbusuariodb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbClavedb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbservidormysql = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(95, 77)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(102, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(104, 134)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(66, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(37, 103)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(37, 160)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(220, 20)
        Me.TxtPassword.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(30, 287)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Aceptar"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(158, 287)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        '
        'CmbBasedeDatos
        '
        Me.CmbBasedeDatos.FormattingEnabled = True
        Me.CmbBasedeDatos.Location = New System.Drawing.Point(41, 25)
        Me.CmbBasedeDatos.Name = "CmbBasedeDatos"
        Me.CmbBasedeDatos.Size = New System.Drawing.Size(218, 21)
        Me.CmbBasedeDatos.TabIndex = 6
        '
        'LblBasedeDatos
        '
        Me.LblBasedeDatos.AutoSize = True
        Me.LblBasedeDatos.Location = New System.Drawing.Point(110, 9)
        Me.LblBasedeDatos.Name = "LblBasedeDatos"
        Me.LblBasedeDatos.Size = New System.Drawing.Size(48, 13)
        Me.LblBasedeDatos.TabIndex = 7
        Me.LblBasedeDatos.Text = "Empresa"
        '
        'cmbIpRouterBoard
        '
        Me.cmbIpRouterBoard.FormattingEnabled = True
        Me.cmbIpRouterBoard.Location = New System.Drawing.Point(303, 22)
        Me.cmbIpRouterBoard.Name = "cmbIpRouterBoard"
        Me.cmbIpRouterBoard.Size = New System.Drawing.Size(218, 21)
        Me.cmbIpRouterBoard.TabIndex = 6
        '
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(303, 85)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(218, 21)
        Me.CmbEstado.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ip RouterBoard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(607, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Clave RouterBoard"
        '
        'CmbClaveRouter
        '
        Me.CmbClaveRouter.FormattingEnabled = True
        Me.CmbClaveRouter.Location = New System.Drawing.Point(544, 22)
        Me.CmbClaveRouter.Name = "CmbClaveRouter"
        Me.CmbClaveRouter.Size = New System.Drawing.Size(218, 21)
        Me.CmbClaveRouter.TabIndex = 8
        '
        'CmbUsuarioRouter
        '
        Me.CmbUsuarioRouter.FormattingEnabled = True
        Me.CmbUsuarioRouter.Location = New System.Drawing.Point(542, 85)
        Me.CmbUsuarioRouter.Name = "CmbUsuarioRouter"
        Me.CmbUsuarioRouter.Size = New System.Drawing.Size(218, 21)
        Me.CmbUsuarioRouter.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(607, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Usuario RouterBoard"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbusuariodb
        '
        Me.cmbusuariodb.FormattingEnabled = True
        Me.cmbusuariodb.Location = New System.Drawing.Point(542, 136)
        Me.cmbusuariodb.Name = "cmbusuariodb"
        Me.cmbusuariodb.Size = New System.Drawing.Size(218, 21)
        Me.cmbusuariodb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(607, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario DB"
        '
        'CmbClavedb
        '
        Me.CmbClavedb.FormattingEnabled = True
        Me.CmbClavedb.Location = New System.Drawing.Point(542, 183)
        Me.CmbClavedb.Name = "CmbClavedb"
        Me.CmbClavedb.Size = New System.Drawing.Size(218, 21)
        Me.CmbClavedb.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(607, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Clave DB"
        '
        'cmbservidormysql
        '
        Me.cmbservidormysql.FormattingEnabled = True
        Me.cmbservidormysql.Location = New System.Drawing.Point(307, 136)
        Me.cmbservidormysql.Name = "cmbservidormysql"
        Me.cmbservidormysql.Size = New System.Drawing.Size(218, 21)
        Me.cmbservidormysql.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(372, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Servidor MYsql"
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(859, 334)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Control de Acceso"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbusuariodb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbClavedb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbservidormysql As ComboBox
    Friend WithEvents Label7 As Label
End Class
