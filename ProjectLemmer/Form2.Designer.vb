<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label2 = New Label()
        btnLogin = New Button()
        Panel1 = New Panel()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(163, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 35)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(12, 182)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(434, 40)
        txtUsername.TabIndex = 1
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(12, 289)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(434, 40)
        txtPassword.TabIndex = 2
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(163, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 35)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnLogin.Font = New Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(153, 364)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(155, 56)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.cropped_Cobraflex2
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(111, 45)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(244, 72)
        Panel1.TabIndex = 5
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 495)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(474, 26)
        StatusStrip1.TabIndex = 6
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(237, 20)
        ToolStripStatusLabel1.Text = "https://www.cobraflexprinters.com"
        ' 
        ' Form2
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(474, 521)
        Controls.Add(StatusStrip1)
        Controls.Add(Panel1)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
