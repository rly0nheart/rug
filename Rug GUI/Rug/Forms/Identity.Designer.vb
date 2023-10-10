<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Identity
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBoxLarge = New PictureBox()
        TabControlIdentity = New TabControl()
        TabPage1 = New TabPage()
        Panel1 = New Panel()
        DataGridUserInformation = New DataGridView()
        TabPageLoginCredentials = New TabPage()
        DataGridPassword = New DataGridView()
        CType(PictureBoxLarge, ComponentModel.ISupportInitialize).BeginInit()
        TabControlIdentity.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridUserInformation, ComponentModel.ISupportInitialize).BeginInit()
        TabPageLoginCredentials.SuspendLayout()
        CType(DataGridPassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxLarge
        ' 
        PictureBoxLarge.Location = New Point(6, 6)
        PictureBoxLarge.Name = "PictureBoxLarge"
        PictureBoxLarge.Size = New Size(126, 118)
        PictureBoxLarge.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBoxLarge.TabIndex = 7
        PictureBoxLarge.TabStop = False
        ' 
        ' TabControlIdentity
        ' 
        TabControlIdentity.Controls.Add(TabPage1)
        TabControlIdentity.Controls.Add(TabPageLoginCredentials)
        TabControlIdentity.Dock = DockStyle.Fill
        TabControlIdentity.Location = New Point(0, 0)
        TabControlIdentity.Name = "TabControlIdentity"
        TabControlIdentity.SelectedIndex = 0
        TabControlIdentity.Size = New Size(434, 172)
        TabControlIdentity.TabIndex = 9
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(PictureBoxLarge)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(426, 144)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Personal Identifiable Information"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridUserInformation)
        Panel1.Location = New Point(138, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(282, 128)
        Panel1.TabIndex = 10
        ' 
        ' DataGridUserInformation
        ' 
        DataGridUserInformation.AllowUserToAddRows = False
        DataGridUserInformation.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridUserInformation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridUserInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridUserInformation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridUserInformation.BackgroundColor = SystemColors.Control
        DataGridUserInformation.BorderStyle = BorderStyle.Fixed3D
        DataGridUserInformation.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridUserInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridUserInformation.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Format = "F"
        DataGridViewCellStyle2.NullValue = "N/A"
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridUserInformation.DefaultCellStyle = DataGridViewCellStyle2
        DataGridUserInformation.Dock = DockStyle.Fill
        DataGridUserInformation.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridUserInformation.Location = New Point(0, 0)
        DataGridUserInformation.Name = "DataGridUserInformation"
        DataGridUserInformation.ReadOnly = True
        DataGridUserInformation.RowHeadersVisible = False
        DataGridUserInformation.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridUserInformation.RowTemplate.Height = 25
        DataGridUserInformation.ShowEditingIcon = False
        DataGridUserInformation.Size = New Size(282, 128)
        DataGridUserInformation.TabIndex = 9
        ' 
        ' TabPageLoginCredentials
        ' 
        TabPageLoginCredentials.BackColor = Color.Transparent
        TabPageLoginCredentials.Controls.Add(DataGridPassword)
        TabPageLoginCredentials.Location = New Point(4, 24)
        TabPageLoginCredentials.Name = "TabPageLoginCredentials"
        TabPageLoginCredentials.Padding = New Padding(3)
        TabPageLoginCredentials.Size = New Size(426, 144)
        TabPageLoginCredentials.TabIndex = 1
        TabPageLoginCredentials.Text = "Login Credentials"
        ' 
        ' DataGridPassword
        ' 
        DataGridPassword.AllowUserToAddRows = False
        DataGridPassword.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridPassword.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridPassword.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridPassword.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridPassword.BackgroundColor = SystemColors.Control
        DataGridPassword.BorderStyle = BorderStyle.Fixed3D
        DataGridPassword.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.NullValue = "N/A"
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridPassword.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridPassword.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridPassword.ColumnHeadersVisible = False
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.Format = "F"
        DataGridViewCellStyle5.NullValue = "N/A"
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridPassword.DefaultCellStyle = DataGridViewCellStyle5
        DataGridPassword.Dock = DockStyle.Fill
        DataGridPassword.EnableHeadersVisualStyles = False
        DataGridPassword.Location = New Point(3, 3)
        DataGridPassword.Name = "DataGridPassword"
        DataGridPassword.ReadOnly = True
        DataGridPassword.RowHeadersVisible = False
        DataGridPassword.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridPassword.RowTemplate.Height = 25
        DataGridPassword.Size = New Size(420, 138)
        DataGridPassword.TabIndex = 2
        ' 
        ' Identity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(434, 172)
        Controls.Add(TabControlIdentity)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Identity"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Identity"
        CType(PictureBoxLarge, ComponentModel.ISupportInitialize).EndInit()
        TabControlIdentity.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(DataGridUserInformation, ComponentModel.ISupportInitialize).EndInit()
        TabPageLoginCredentials.ResumeLayout(False)
        CType(DataGridPassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxLarge As PictureBox
    Friend WithEvents TabControlIdentity As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPageLoginCredentials As TabPage
    Friend WithEvents DataGridUserInformation As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridPassword As DataGridView
End Class
