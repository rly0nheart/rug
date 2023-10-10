Imports System.IO
Imports System.Net.Http
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json.Linq

''' <summary>
''' A class to handle API interactions.
''' </summary>
Public Class ApiHandler
    ''' <summary>
    ''' Represents the current program version in format {Major}.{Minor}.
    ''' </summary>
    Private ReadOnly appVersion As String = $"{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}"

    ''' <summary>
    ''' Represents the .NET version program is running on.
    ''' </summary>
    Private ReadOnly dotNetVersion As String = RuntimeInformation.FrameworkDescription

    ''' <summary>
    ''' HttpClient instance to be reused across asynchronous methods.
    ''' </summary>
    Private httpClient As New HttpClient()

    Public Sub New()
        httpClient.DefaultRequestHeaders.Add("User-Agent", $"Rug/{appVersion} ({dotNetVersion}; +https://about.me/rly0nheart)")
    End Sub

    ''' <summary>
    ''' Makes an asynchronous GET request to a given endpoint.
    ''' </summary>
    ''' <param name="endpoint">The API endpoint URL.</param>
    ''' <returns>JToken received from the API call.</returns>
    Private Async Function AsyncGetData(endpoint As String) As Task(Of JObject)
        Try
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(endpoint)

            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Return JObject.Parse(json)
            Else
                MessageBox.Show(response.ReasonPhrase, "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "HTTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    ''' <summary>
    ''' Asynchronously retrieves a random user's identity and image from the randomuser.me API.
    ''' </summary>
    ''' <returns>
    ''' A tuple containing the user's JObject details and the image.
    ''' In case of an error, a tuple with a default empty JObject and Nothing for the image is returned.
    ''' </returns>
    Public Async Function AsyncGetIdentity(gender As String, nationality As String) As Task(Of (UserData As JObject, Image As Bitmap))
        Dim ApiEndpoint As String = $"https://randomuser.me/api/?results=1&gender={gender}&nat={nationality}&noinfo"
        Dim identity As JObject = Await AsyncGetData(endpoint:=ApiEndpoint)

        If identity IsNot Nothing Then
            Dim ImageUri As String = identity("results")(0)("picture")("large").ToString
            Dim ImageBytes As Byte() = Await httpClient.GetByteArrayAsync(ImageUri)
            Dim Image As New Bitmap(New MemoryStream(ImageBytes))

            Return (identity?("results")?(0), Image)
        End If

        ' Return default empty JObject and nothing for the image in case of failures
        Return (New JObject(), Nothing)
    End Function

    ''' <summary>
    ''' Asynchronously fetches the program's update information from GitHub.
    ''' <summary>
    Public Async Function AsyncGetUpdates() As Task(Of JObject)
        Return Await AsyncGetData(endpoint:="https://api.github.com/repos/rly0nheart/reddit-post-scraping-tool/releases/latest")
    End Function
End Class
