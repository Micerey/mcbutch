<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log_In_Page_SUPER_ADMIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Log_In_Page_SUPER_ADMIN))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Gold
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(437, 231)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(936, 672)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Gold
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(580, 405)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 25)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gold
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(580, 511)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F)
        TextBox1.Location = New Point(580, 442)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(301, 47)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 18F)
        TextBox2.Location = New Point(580, 550)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(301, 47)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 11F)
        Button1.Location = New Point(580, 712)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 46)
        Button1.TabIndex = 5
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Gold
        LinkLabel1.Font = New Font("Segoe UI", 11F)
        LinkLabel1.Location = New Point(706, 733)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(209, 25)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Don't have an account?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Gold
        Label3.Font = New Font("Segoe UI", 40F)
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(1093, 712)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 89)
        Label3.TabIndex = 7
        Label3.Text = "M"
        ' 
        ' Log_In_Page_SUPER_ADMIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.ForestGreen
        ClientSize = New Size(1924, 1033)
        Controls.Add(Label3)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Log_In_Page_SUPER_ADMIN"
        Text = "Log_In_Page_SUPER_ADMIN"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
End Class
