Imports System.IO
Imports Microsoft.Win32
Imports Newtonsoft.Json.Linq

Public Class CoreUtils
    ''' <summary>
    ''' Retrieves the gender selection from the ComboBox on the Main form.
    ''' </summary>
    ''' <returns>
    ''' Returns the lowercase value of the selected gender. 
    ''' If "Random" is selected, returns an empty string.
    ''' </returns>
    Public Shared Function GetGender() As String
        If Main.ComboBoxGender.SelectedItem Is "Random" Then
            Return String.Empty
        Else
            Return Main.ComboBoxGender.SelectedItem.ToLower
        End If
    End Function

    ''' <summary>
    ''' Maps a human-readable nationality to its respective country code.
    ''' </summary>
    ''' <param name="Name">The human-readable nationality (e.g., "American").</param>
    ''' <returns>
    ''' Returns the corresponding country code (e.g., "US" for "American").
    ''' If the provided nationality isn't in the dictionary, returns an empty string.
    ''' </returns>
    Public Shared Function GetNationality(Name As String) As String
        Dim nationalities As New Dictionary(Of String, String) From {
        {"American", "US"},
        {"Australian", "AU"},
        {"Brazilian", "BR"},
        {"British", "GB"},
        {"Canadian", "CA"},
        {"Dane (Denmark)", "DK"},
        {"Dutch", "NL"},
        {"Finnish (Finland)", "FI"},
        {"German", "DE"},
        {"Indian", "IN"},
        {"Iranian", "IR"},
        {"Irish", "IE"},
        {"Kiwi (New Zealand)", "NZ"},
        {"Mexican", "MX"},
        {"Norwegian", "NO"},
        {"Serb (Serbia)", "RS"},
        {"Spaniard", "ES"},
        {"Swiss", "CH"},
        {"Türk (Türkiye)", "TR"},
        {"Ukranian", "UA"}
    }

        If nationalities.ContainsKey(Name) Then
            Return nationalities(Name)
        Else
            Return String.Empty
        End If
    End Function


    ''' <summary>
    ''' Displays the software's licensing notice to the user.
    ''' </summary>
    ''' <remarks>
    ''' The licensing notice adheres to the GNU General Public License v3.0 terms.
    ''' It includes details about redistribution rights, warranty disclaimer, and references to the full license document.
    ''' </remarks>
    Public Shared Sub License()
        MessageBox.Show($"{My.Application.Info.Copyright}

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  
If not, see <https://www.gnu.org/licenses/>", "GNU General Public License v3.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    ''' <summary>
    ''' Determines if the Windows system theme is in dark mode.
    ''' </summary>
    ''' <returns>
    ''' True if the dark mode is enabled, otherwise false.
    ''' </returns>
    Public Shared Function IsSystemDarkTheme() As Boolean
        Dim registryKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize")
        If registryKey IsNot Nothing Then
            Dim appsUseLightTheme As Object = registryKey.GetValue("AppsUseLightTheme")
            Return appsUseLightTheme IsNot Nothing AndAlso CType(appsUseLightTheme, Integer) = 0
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Asynchronously checks for available updates and updates the version label accordingly.
    ''' </summary>
    ''' <returns>A task representing the asynchronous operation.</returns>
    Public Shared Async Function AsyncCheckUpdates() As Task
        About.Version.Text = "Checking for Updates..."
        ' Creating a new instance of the ApiHandler class to interact with the API.
        Dim Api As New ApiHandler()

        ' Making an asynchronous request to check for updates.
        Dim data As JObject = Await Api.AsyncGetUpdates()

        ' Checking if data is not null before proceeding with extracting information from it.
        If data IsNot Nothing Then
            ' Extracting the tag name, body, and HTML URL from the data.
            Dim tagName As String = data("tag_name")?.ToString

            ' Checking if the current version is the latest version.
            If tagName = My.Application.Info.Version.ToString Then
                About.Version.Text = $"Up-to-date ({tagName})"
            Else
                About.Version.Text = $"Updates found ({tagName})"
                About.ButtonGetUpdates.Enabled = True
            End If
        End If
    End Function

    ''' <summary>
    ''' Saves JObject data to specified formats.
    ''' </summary>
    ''' <param name="Data">The JObject data to save.</param>
    ''' <param name="toJson">If True, saves data as JSON. Default is False.</param>
    ''' <param name="toCsv">If True, saves data as CSV. Default is False.</param>
    Public Shared Sub SaveData(ByVal Data As JObject, Optional toJson As Boolean = False, Optional toCsv As Boolean = False)
        ' Derive default filename based on "name" property within the JObject
        Dim defaultFileName As String = $"{Data?("name")?("first")}_{Data?("name")?("last")}"

        ' Get the user's Documents directory
        Dim documentsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        ' Save as JSON file if toJson is True
        If toJson Then
            Dim jsonFileName = Path.Combine(documentsPath, $"{defaultFileName}.json")
            File.WriteAllText(jsonFileName, Data.ToString())
            MessageBox.Show($"JSON data written to {jsonFileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Save as CSV file if toCsv is True
        If toCsv Then
            Dim csvFileName = Path.Combine(documentsPath, $"{defaultFileName}.csv")
            Using sw As New StreamWriter(csvFileName)
                ' Extract keys from JObject and write as CSV headers
                Dim headers = Data.Properties().Select(Function(p) p.Name).ToArray()
                sw.WriteLine(String.Join(",", headers))

                ' Extract values from JObject and write to the CSV
                Dim values = Data.Properties().Select(Function(p) p.Value.ToString()).ToArray()
                sw.WriteLine(String.Join(",", values))
            End Using
            MessageBox.Show($"CSV data written to {csvFileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
