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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuarioRuc = New System.Windows.Forms.TextBox()
        Me.TxtUsuarioNombre = New System.Windows.Forms.TextBox()
        Me.TxtRslt1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtRslt2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtRslt3 = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.TxtRuc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtUsuarioClave = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ruc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "usuario"
        '
        'txtUsuarioRuc
        '
        Me.txtUsuarioRuc.Location = New System.Drawing.Point(88, 12)
        Me.txtUsuarioRuc.Name = "txtUsuarioRuc"
        Me.txtUsuarioRuc.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuarioRuc.TabIndex = 3
        '
        'TxtUsuarioNombre
        '
        Me.TxtUsuarioNombre.Location = New System.Drawing.Point(248, 12)
        Me.TxtUsuarioNombre.Name = "TxtUsuarioNombre"
        Me.TxtUsuarioNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuarioNombre.TabIndex = 4
        '
        'TxtRslt1
        '
        Me.TxtRslt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRslt1.Location = New System.Drawing.Point(3, 3)
        Me.TxtRslt1.Multiline = True
        Me.TxtRslt1.Name = "TxtRslt1"
        Me.TxtRslt1.Size = New System.Drawing.Size(797, 428)
        Me.TxtRslt1.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(17, 106)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 460)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxtRslt1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(803, 434)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtRslt2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(803, 434)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtRslt2
        '
        Me.TxtRslt2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRslt2.Location = New System.Drawing.Point(3, 3)
        Me.TxtRslt2.Multiline = True
        Me.TxtRslt2.Name = "TxtRslt2"
        Me.TxtRslt2.Size = New System.Drawing.Size(797, 428)
        Me.TxtRslt2.TabIndex = 9
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TxtRslt3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(803, 434)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TxtRslt3
        '
        Me.TxtRslt3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRslt3.Location = New System.Drawing.Point(3, 3)
        Me.TxtRslt3.Multiline = True
        Me.TxtRslt3.Name = "TxtRslt3"
        Me.TxtRslt3.Size = New System.Drawing.Size(797, 428)
        Me.TxtRslt3.TabIndex = 9
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(248, 38)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(100, 20)
        Me.TxtTipo.TabIndex = 13
        '
        'TxtRuc
        '
        Me.TxtRuc.Location = New System.Drawing.Point(88, 38)
        Me.TxtRuc.Name = "TxtRuc"
        Me.TxtRuc.Size = New System.Drawing.Size(100, 20)
        Me.TxtRuc.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ruc"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(573, 35)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumero.TabIndex = 17
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(413, 35)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(100, 20)
        Me.TxtSerie.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(521, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "numero"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "serie"
        '
        'TxtUsuarioClave
        '
        Me.TxtUsuarioClave.Location = New System.Drawing.Point(413, 13)
        Me.TxtUsuarioClave.Name = "TxtUsuarioClave"
        Me.TxtUsuarioClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtUsuarioClave.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuarioClave.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "clave"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 591)
        Me.Controls.Add(Me.TxtUsuarioClave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.TxtSerie)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.TxtRuc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TxtUsuarioNombre)
        Me.Controls.Add(Me.txtUsuarioRuc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuarioRuc As TextBox
    Friend WithEvents TxtUsuarioNombre As TextBox
    Friend WithEvents TxtRslt1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtRslt2 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TxtRslt3 As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents TxtRuc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtUsuarioClave As TextBox
    Friend WithEvents Label7 As Label
End Class
