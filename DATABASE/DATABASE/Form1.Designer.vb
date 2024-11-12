<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Panel2 = New Panel()
        Button2 = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.ForestGreen
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(2416, 731)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(575, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(595, 525)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = ""
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 13F)
        Button1.Location = New Point(709, 830)
        Button1.Name = "Button1"
        Button1.RightToLeft = RightToLeft.No
        Button1.Size = New Size(171, 68)
        Button1.TabIndex = 1
        Button1.Text = "ADMIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Location = New Point(902, 820)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1, 93)
        Panel2.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.Font = New Font("Segoe UI", 13F)
        Button2.Location = New Point(927, 830)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 68)
        Button2.TabIndex = 3
        Button2.Text = "SUPER ADMIN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(871, 797)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 4
        Label1.Text = "Log In As"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1175)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Panel2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Home"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
