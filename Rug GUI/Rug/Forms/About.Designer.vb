<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(About))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ButtonLicense = New Button()
        ButtonClose = New Button()
        LinkLabelCopyright = New LinkLabel()
        ButtonGetUpdates = New Button()
        Version = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icon512x512
        PictureBox1.Location = New Point(138, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(79, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display Semib", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(161, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 17)
        Label1.TabIndex = 1
        Label1.Text = "Rug"
        ' 
        ' ButtonLicense
        ' 
        ButtonLicense.BackColor = Color.FromArgb(CByte(46), CByte(46), CByte(46))
        ButtonLicense.FlatStyle = FlatStyle.Popup
        ButtonLicense.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonLicense.ForeColor = Color.White
        ButtonLicense.Location = New Point(12, 182)
        ButtonLicense.Name = "ButtonLicense"
        ButtonLicense.Size = New Size(95, 25)
        ButtonLicense.TabIndex = 16
        ButtonLicense.Text = "View License"
        ButtonLicense.UseVisualStyleBackColor = False
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.Red
        ButtonClose.FlatStyle = FlatStyle.Popup
        ButtonClose.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonClose.ForeColor = Color.White
        ButtonClose.Location = New Point(291, 182)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(62, 25)
        ButtonClose.TabIndex = 17
        ButtonClose.Text = "&Close"
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' LinkLabelCopyright
        ' 
        LinkLabelCopyright.AutoSize = True
        LinkLabelCopyright.Font = New Font("Segoe UI Variable Display", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabelCopyright.Location = New Point(67, 142)
        LinkLabelCopyright.Name = "LinkLabelCopyright"
        LinkLabelCopyright.Size = New Size(56, 15)
        LinkLabelCopyright.TabIndex = 18
        LinkLabelCopyright.TabStop = True
        LinkLabelCopyright.Text = "Copyright"
        ' 
        ' ButtonGetUpdates
        ' 
        ButtonGetUpdates.BackColor = Color.FromArgb(CByte(46), CByte(46), CByte(46))
        ButtonGetUpdates.Enabled = False
        ButtonGetUpdates.FlatStyle = FlatStyle.Popup
        ButtonGetUpdates.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonGetUpdates.ForeColor = Color.White
        ButtonGetUpdates.Location = New Point(113, 182)
        ButtonGetUpdates.Name = "ButtonGetUpdates"
        ButtonGetUpdates.Size = New Size(104, 25)
        ButtonGetUpdates.TabIndex = 19
        ButtonGetUpdates.Text = "Get Updates"
        ButtonGetUpdates.UseVisualStyleBackColor = False
        ' 
        ' Version
        ' 
        Version.AutoSize = True
        Version.Location = New Point(113, 97)
        Version.Name = "Version"
        Version.Size = New Size(45, 16)
        Version.TabIndex = 20
        Version.Text = "Version"
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        CancelButton = ButtonClose
        ClientSize = New Size(364, 219)
        Controls.Add(Version)
        Controls.Add(ButtonGetUpdates)
        Controls.Add(LinkLabelCopyright)
        Controls.Add(ButtonClose)
        Controls.Add(ButtonLicense)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "About"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "About Rug"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLicense As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents LinkLabelCopyright As LinkLabel
    Friend WithEvents ButtonGetUpdates As Button
    Friend WithEvents Version As Label
End Class
