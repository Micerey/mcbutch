<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_In_Page_in_ADMIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_In_Page_in_ADMIN))
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(429, 266)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(985, 658)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 40F)
        Label4.ForeColor = Color.ForestGreen
        Label4.Location = New Point(1169, 776)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 89)
        Label4.TabIndex = 16
        Label4.Text = "M"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gold
        TextBox3.Font = New Font("Segoe UI", 15F)
        TextBox3.Location = New Point(682, 535)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(423, 41)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gold
        TextBox2.Font = New Font("Segoe UI", 15F)
        TextBox2.Location = New Point(682, 627)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(423, 41)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gold
        TextBox1.Font = New Font("Segoe UI", 15F)
        TextBox1.Location = New Point(682, 454)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(423, 41)
        TextBox1.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Segoe UI", 13F)
        Button1.Location = New Point(839, 780)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 46)
        Button1.TabIndex = 12
        Button1.Text = "Sign In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(682, 599)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 25)
        Label3.TabIndex = 11
        Label3.Text = "Confirm Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(682, 512)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 25)
        Label2.TabIndex = 10
        Label2.Text = "Create Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(682, 431)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 25)
        Label1.TabIndex = 9
        Label1.Text = "Create Username:"
        ' 
        ' Sign_In_Page_in_ADMIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(1924, 1175)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Sign_In_Page_in_ADMIN"
        Text = "Sign_In_Page_in_ADMIN"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
