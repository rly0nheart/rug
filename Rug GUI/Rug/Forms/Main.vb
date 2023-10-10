Imports Newtonsoft.Json.Linq

Public Class Main
    ReadOnly theme As New Theme()
    ReadOnly dataGridViewHandler As New DataGridHandler()
    ReadOnly apiHandler As New ApiHandler()

    ''' <summary>
    ''' Handles the Load event for the StartupForm.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The parameters associated with the Load event.</param>
    ''' <remarks>
    ''' Initializes various components of the Main form:
    ''' - Sets the form's icon.
    ''' - Loads and applies theme settings.
    ''' - Sets a handler to monitor system events.
    ''' - Sets default values for ComboBox controls.
    ''' </remarks>
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon256x256

        theme.LoadThemeSettings()
        theme.ApplyThemeSettings()
        AddHandler Microsoft.Win32.SystemEvents.UserPreferenceChanged, AddressOf SystemEvents_UserPreferenceChanged

        'GroupBox1.Text = $"{Environment.UserName}@{My.Computer.Name}"
        ComboBoxNationality.SelectedIndex = 0
        ComboBoxGender.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Handles the FormClosed event for the Main form.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The parameters associated with the FormClosed event.</param>
    ''' <remarks>This method unhooks the UserPreferenceChanged event to prevent memory leaks.</remarks>
    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RemoveHandler Microsoft.Win32.SystemEvents.UserPreferenceChanged, AddressOf SystemEvents_UserPreferenceChanged
    End Sub

    Private Sub FormMain_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        ' Cancel the default behavior (opening system help)
        e.Cancel = True
        Shell("cmd.exe /c start https://github.com/rly0nheart/rug/wiki")
    End Sub

    ''' <summary>
    ''' Handles the Click event for the Close button.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The parameters associated with the Click event.</param>
    ''' <remarks>Asks the user for confirmation before exiting the program.</remarks>
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim result As DialogResult = MessageBox.Show("This will exit the program, continue?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Handles the Click event for the About button.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The parameters associated with the Click event.</param>
    ''' <remarks>Opens the About dialog box.</remarks>
    Private Sub ButtonAbout_Click(sender As Object, e As EventArgs) Handles ButtonAbout.Click
        About.ShowDialog()
    End Sub

    ''' <summary>
    ''' Handles the SelectedIndexChanged event for the Nationality ComboBox.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The parameters associated with the SelectedIndexChanged event.</param>
    ''' <remarks>Resets the Generate button's text.</remarks>
    Private Sub ComboBoxNationality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNationality.SelectedIndexChanged
        ButtonGenerate.Text = "Generate"
    End Sub

    ''' <summary>
    ''' Handles the SelectedIndexChanged event for the Gender ComboBox.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The parameters associated with the SelectedIndexChanged event.</param>
    ''' <remarks>Resets the Generate button's text.</remarks>
    Private Sub ComboBoxGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGender.SelectedIndexChanged
        ButtonGenerate.Text = "Generate"
    End Sub

    ''' <summary>
    ''' Handles the UserPreferenceChanged system event.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The parameters associated with the UserPreferenceChanged event.</param>
    ''' <remarks>Updates the theme settings if the system's theme has changed.</remarks>
    Private Sub SystemEvents_UserPreferenceChanged(sender As Object, e As Microsoft.Win32.UserPreferenceChangedEventArgs)
        If e.Category = Microsoft.Win32.UserPreferenceCategory.General Then
            ' The theme might have changed, so apply new settings.
            Dim theme As New Theme()
            theme.LoadThemeSettings()
            theme.ApplyThemeSettings()
        End If
    End Sub

    Private Async Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click
        Dim userGender As String = CoreUtils.GetGender()
        Dim userNationality As String = CoreUtils.GetNationality(Name:=ComboBoxNationality.Text)
        Dim result = Await apiHandler.AsyncGetIdentity(gender:=userGender, nationality:=userNationality)

        Dim userData As JObject = result.UserData
        Dim userImage As Bitmap = result.Image

        Identity.PictureBoxLarge.Image = userImage

        dataGridViewHandler.LoadIdentityData(userData:=userData)
        CoreUtils.SaveData(Data:=userData, toJson:=CheckBoxDownloadJson.Checked, toCsv:=CheckBoxDownloadCsv.Checked)

        ButtonGenerate.Text = "New"
    End Sub
End Class
