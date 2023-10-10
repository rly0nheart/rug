Imports System.Globalization
Imports System.IO

Public Class Theme
    ''' <summary>
    ''' Indicates whether the dark mode is enabled or disabled.
    ''' Based on the system's theme settings.
    ''' </summary>
    Public ReadOnly Property DarkMode As Boolean
        Get
            Return CoreUtils.IsSystemDarkTheme() ' Assuming this method checks the system theme
        End Get
    End Property

    ''' <summary>
    ''' Contains the color settings for different visual themes (e.g., Dark, Light).
    ''' The outer dictionary key represents the theme (Dark, Light),
    ''' and the inner dictionary contains the color settings.
    ''' </summary>
    Public Property ColorSettings As Dictionary(Of String, Dictionary(Of String, String))

    ''' <summary>
    ''' Loads application settings from the 'settings.json' file.
    ''' If the settings file doesn't exist, it creates a new file with default settings.
    ''' </summary>
    Public Sub LoadThemeSettings()
        Dim defaultSettings = New Theme With {
            .ColorSettings = New Dictionary(Of String, Dictionary(Of String, String))() From {
                {"Dark", New Dictionary(Of String, String)() From {
                    {"PrimaryBackgroundColor", "#FF1A1A1A"},
                    {"PrimaryTextColor", "#FFFFFFFF"},
                    {"SecondaryBackgroundColor", "#FF2E2E2E"}
                }
            },
                {"Light", New Dictionary(Of String, String)() From {
                     {"PrimaryBackgroundColor", "#FFF0F0F0"},
                     {"PrimaryTextColor", "#FF121212"},
                     {"SecondaryBackgroundColor", "#FFFFFAFA"}
                }
            }
        }
    }

        ColorSettings = defaultSettings.ColorSettings
    End Sub


    ''' <summary>
    ''' Applies the current settings to the application's interface. This includes
    ''' toggling SaveToJson, SaveToCsv, and applying the visual theme based on the Dark Mode setting.
    ''' </summary>
    Public Sub ApplyThemeSettings()
        ' Use ColorSettings property directly
        Dim colorSettings As Dictionary(Of String, Dictionary(Of String, String)) = Me.ColorSettings

        ' Apply the color scheme based on the Dark Mode setting
        Dim isDarkMode As Boolean = Me.DarkMode ' Use the property to get the system's theme
        ApplyColorScheme(isDarkMode:=isDarkMode, colorSettings:=colorSettings)
    End Sub


    ''' <summary>
    ''' Applies the color scheme based on the given Dark Mode setting. 
    ''' Colors are defined in a mapping for easier maintenance and flexibility.
    ''' </summary>
    ''' <param name="isDarkMode">Indicates whether Dark Mode is enabled.</param>
    Public Shared Sub ApplyColorScheme(ByVal isDarkMode As Boolean, ByVal colorSettings As Dictionary(Of String, Dictionary(Of String, String)))
        Dim color As New Dictionary(Of String, Color)

        Dim mode As String = If(isDarkMode, "Dark", "Light")
        Dim modeColors As Dictionary(Of String, String) = colorSettings(mode)

        For Each colorName As String In modeColors.Keys
            color(colorName) = ColorTranslator.FromHtml(modeColors(colorName))
        Next

        SetUIColors(color:=color)
    End Sub

    ''' <summary>
    ''' Applies the specified color settings to the UI components.
    ''' </summary>
    ''' <param name="color">A dictionary mapping color names to Color objects.</param>
    Private Shared Sub SetUIColors(ByVal color As Dictionary(Of String, Color))

        ''' <summary>
        ''' Apply colors to data grid view cells
        ''' </summary>
        Dim cellStyles As New List(Of DataGridViewCellStyle) From {
            Identity.DataGridPassword.AlternatingRowsDefaultCellStyle,
            Identity.DataGridPassword.DefaultCellStyle,
            Identity.DataGridUserInformation.AlternatingRowsDefaultCellStyle,
            Identity.DataGridUserInformation.DefaultCellStyle
            }
        For Each cellStyle In cellStyles
            cellStyle.BackColor = color("PrimaryBackgroundColor")
            cellStyle.ForeColor = color("PrimaryTextColor")
        Next

        ''' <summary>
        ''' Apply colors to data grid view controls
        ''' </summary>
        Dim dataGridViews As New List(Of DataGridView) From {
            Identity.DataGridPassword,
            Identity.DataGridUserInformation
        }
        For Each datagridview In dataGridViews
            datagridview.BackColor = color("PrimaryBackgroundColor")
            datagridview.ForeColor = color("PrimaryTextColor")
        Next

        ''' <summary>
        ''' Apply colors to tab pages
        ''' </summary>
        Dim tabpages As New List(Of TabPage) From {
            Identity.TabPageLoginCredentials,
            Identity.TabPage1
        }
        For Each tabpage In tabpages
            tabpage.BackColor = color("PrimaryBackgroundColor")
            tabpage.ForeColor = color("PrimaryTextColor")
        Next


        ''' <summary>
        ''' Apply colors to Forms
        ''' </summary>
        Dim forms As New List(Of Form) From {
            Main,
            About
            }
        For Each form In forms
            form.BackColor = color("PrimaryBackgroundColor")
            form.ForeColor = color("PrimaryTextColor")
        Next

        ''' <summary>
        ''' Apply colors to buttons
        ''' </summary>
        Dim buttons As New List(Of Button) From {
            Main.ButtonAbout,
            Main.ButtonGenerate,
            About.ButtonLicense,
            About.ButtonGetUpdates
        }
        ' MainForm.ButtonFetchPostData,
        For Each button In buttons
            button.BackColor = color("SecondaryBackgroundColor")
            button.ForeColor = color("PrimaryTextColor")
        Next

        ''' <summary>
        ''' Apply colors to Label controls
        ''' </summary>
        Dim labels As New List(Of Label) From {
            Main.LabelGender,
            Main.LabelNationality,
            About.Label1
            }
        For Each label In labels
            label.ForeColor = color("PrimaryTextColor")
        Next

        ''' <summary>
        ''' Apply colors to ComboBox controls
        ''' </summary>
        Dim comboBoxes As New List(Of ComboBox) From {
            Main.ComboBoxNationality,
            Main.ComboBoxGender
            }
        For Each comboBox In comboBoxes
            comboBox.BackColor = color("SecondaryBackgroundColor")
            comboBox.ForeColor = color("PrimaryTextColor")
        Next
    End Sub
End Class