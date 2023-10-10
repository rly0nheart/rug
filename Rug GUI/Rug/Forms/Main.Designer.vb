<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Main))
        ButtonGenerate = New Button()
        ComboBoxNationality = New ComboBox()
        ComboBoxGender = New ComboBox()
        LabelGender = New Label()
        LabelNationality = New Label()
        ButtonAbout = New Button()
        ButtonClose = New Button()
        CheckBoxDownloadJson = New CheckBox()
        Panel1 = New Panel()
        CheckBoxDownloadCsv = New CheckBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonGenerate
        ' 
        ButtonGenerate.BackColor = Color.White
        ButtonGenerate.FlatStyle = FlatStyle.Popup
        ButtonGenerate.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonGenerate.ForeColor = SystemColors.ControlText
        ButtonGenerate.Location = New Point(133, 89)
        ButtonGenerate.Name = "ButtonGenerate"
        ButtonGenerate.Size = New Size(70, 25)
        ButtonGenerate.TabIndex = 4
        ButtonGenerate.Text = "Generate"
        ButtonGenerate.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxNationality
        ' 
        ComboBoxNationality.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxNationality.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxNationality.BackColor = Color.White
        ComboBoxNationality.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxNationality.FlatStyle = FlatStyle.Popup
        ComboBoxNationality.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBoxNationality.ForeColor = SystemColors.ControlText
        ComboBoxNationality.FormattingEnabled = True
        ComboBoxNationality.Items.AddRange(New Object() {"Random", "American", "Australian", "Brazilian", "British", "Canadian", "Dane (Denmark)", "Dutch", "Finnish (Finland)", "German", "Indian", "Iranian", "Irish", "Kiwi (New Zealand)", "Mexican", "Norwegian", "Serb (Serbia)", "Spaniard", "Swiss", "Türk (Türkiye)", "Ukranian"})
        ComboBoxNationality.Location = New Point(6, 29)
        ComboBoxNationality.Name = "ComboBoxNationality"
        ComboBoxNationality.Size = New Size(103, 24)
        ComboBoxNationality.TabIndex = 8
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxGender.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxGender.BackColor = Color.White
        ComboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxGender.FlatStyle = FlatStyle.Popup
        ComboBoxGender.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBoxGender.ForeColor = SystemColors.ControlText
        ComboBoxGender.FormattingEnabled = True
        ComboBoxGender.Items.AddRange(New Object() {"Random", "Female", "Male"})
        ComboBoxGender.Location = New Point(122, 29)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(81, 24)
        ComboBoxGender.TabIndex = 12
        ' 
        ' LabelGender
        ' 
        LabelGender.AutoSize = True
        LabelGender.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LabelGender.Location = New Point(118, 10)
        LabelGender.Name = "LabelGender"
        LabelGender.Size = New Size(47, 16)
        LabelGender.TabIndex = 13
        LabelGender.Text = "Gender:"
        ' 
        ' LabelNationality
        ' 
        LabelNationality.AutoSize = True
        LabelNationality.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNationality.Location = New Point(4, 10)
        LabelNationality.Name = "LabelNationality"
        LabelNationality.Size = New Size(67, 16)
        LabelNationality.TabIndex = 0
        LabelNationality.Text = "Nationality:"
        ' 
        ' ButtonAbout
        ' 
        ButtonAbout.BackColor = Color.White
        ButtonAbout.FlatStyle = FlatStyle.Popup
        ButtonAbout.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonAbout.ForeColor = SystemColors.ControlText
        ButtonAbout.Location = New Point(12, 138)
        ButtonAbout.Name = "ButtonAbout"
        ButtonAbout.Size = New Size(55, 25)
        ButtonAbout.TabIndex = 14
        ButtonAbout.Text = "About"
        ButtonAbout.UseVisualStyleBackColor = False
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.Red
        ButtonClose.FlatStyle = FlatStyle.Popup
        ButtonClose.Font = New Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonClose.ForeColor = Color.White
        ButtonClose.Location = New Point(161, 138)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(60, 25)
        ButtonClose.TabIndex = 15
        ButtonClose.Text = "&Close"
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxDownloadJson
        ' 
        CheckBoxDownloadJson.AutoSize = True
        CheckBoxDownloadJson.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxDownloadJson.Location = New Point(3, 3)
        CheckBoxDownloadJson.Name = "CheckBoxDownloadJson"
        CheckBoxDownloadJson.Size = New Size(56, 20)
        CheckBoxDownloadJson.TabIndex = 14
        CheckBoxDownloadJson.Text = "JSON"
        CheckBoxDownloadJson.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CheckBoxDownloadCsv)
        Panel1.Controls.Add(CheckBoxDownloadJson)
        Panel1.Location = New Point(6, 89)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(121, 25)
        Panel1.TabIndex = 0
        ' 
        ' CheckBoxDownloadCsv
        ' 
        CheckBoxDownloadCsv.AutoSize = True
        CheckBoxDownloadCsv.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxDownloadCsv.Location = New Point(65, 2)
        CheckBoxDownloadCsv.Name = "CheckBoxDownloadCsv"
        CheckBoxDownloadCsv.Size = New Size(48, 20)
        CheckBoxDownloadCsv.TabIndex = 15
        CheckBoxDownloadCsv.Text = "CSV"
        CheckBoxDownloadCsv.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(LabelNationality)
        Panel2.Controls.Add(ComboBoxGender)
        Panel2.Controls.Add(LabelGender)
        Panel2.Controls.Add(ButtonGenerate)
        Panel2.Controls.Add(ComboBoxNationality)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(209, 120)
        Panel2.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 16)
        Label1.TabIndex = 14
        Label1.Text = "Save identity to:"
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        CancelButton = ButtonClose
        ClientSize = New Size(232, 175)
        Controls.Add(Panel2)
        Controls.Add(ButtonClose)
        Controls.Add(ButtonAbout)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedSingle
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = " Rug"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ButtonGenerate As Button
    Friend WithEvents ComboBoxNationality As ComboBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents LabelGender As Label
    Friend WithEvents LabelNationality As Label
    Friend WithEvents ButtonAbout As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents CheckBoxDownloadJson As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxDownloadCsv As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
