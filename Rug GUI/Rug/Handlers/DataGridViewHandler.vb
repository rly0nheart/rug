Imports Newtonsoft.Json.Linq

''' <summary>
''' Class responsible for handling the display of user data within data grids.
''' </summary>
Public Class DataGridHandler

    ''' <summary>
    ''' Initializes the DataGridView by clearing its current data and setting up default columns.
    ''' </summary>
    ''' <param name="grid">The DataGridView to be initialized.</param>
    Private Shared Sub InitializeDataGrid(ByRef grid As DataGridView)
        grid.Rows.Clear()
        grid.Columns.Clear()
        grid.Columns.Add("Field", "Field")
        grid.Columns.Add("Data", "Data")
    End Sub

    ''' <summary>
    ''' Populates Personally Identifiable Information (PII) into the DataGridUserInformation from the given JSON data.
    ''' </summary>
    ''' <param name="result">JSON data containing PII details of the user.</param>
    Private Sub PopulatePIIData(ByVal result As JObject)
        With Identity.DataGridUserInformation
            .Rows.Add("Title", result?("name")?("title").ToString)
            .Rows.Add("First Name", result?("name")?("first").ToString)
            .Rows.Add("Last Name", result?("name")?("last").ToString)
            .Rows.Add("Age", result?("dob")?("age").ToString)
            .Rows.Add("Nationality", result?("nat").ToString)
            .Rows.Add("Date Of Birth", result?("dob")?("date").ToString)
            .Rows.Add(result?("id")?("name").ToString, result?("id")?("value").ToString)
            .Rows.Add("Email", result?("email").ToString)
            .Rows.Add("Phone", result?("phone").ToString)
            .Rows.Add("Cell", result?("cell").ToString)
            .Rows.Add("Street", result?("location")?("street")?("number").ToString & " " & result?("location")?("street")?("name").ToString)
            .Rows.Add("City", result?("location")?("city").ToString)
            .Rows.Add("State", result?("location")?("state").ToString)
            .Rows.Add("Country", result?("location")?("country").ToString)
            .Rows.Add("Postcode", result?("location")?("postcode").ToString)
            .Rows.Add("Latitude", result?("location")?("coordinates")?("latitude").ToString)
            .Rows.Add("Longitude", result?("location")?("coordinates")?("longitude").ToString)
            .Rows.Add("Timezone", result?("location")?("timezone")?("description").ToString)
            .Rows.Add("Offset", result?("location")?("timezone")?("offset").ToString)
        End With
    End Sub

    ''' <summary>
    ''' Populates login-related information into the DataGridPassword from the given JSON data.
    ''' </summary>
    ''' <param name="loginInfo">JSON data containing login details of the user.</param>
    Private Sub PopulateLoginData(ByVal loginInfo As JObject)
        With Identity.DataGridPassword
            .Rows.Add("Username", loginInfo?("username").ToString)
            .Rows.Add("Password", loginInfo?("password").ToString)
            .Rows.Add("UUID", loginInfo?("uuid").ToString)
            .Rows.Add("SALT", loginInfo?("salt").ToString)
            .Rows.Add("MD5", loginInfo?("md5").ToString)
            .Rows.Add("SHA1", loginInfo?("sha1").ToString)
            .Rows.Add("SHA256", loginInfo?("sha256").ToString)
        End With
    End Sub

    ''' <summary>
    ''' Loads the identity data from the given JSON object into the respective DataGridViews and displays the Identity form.
    ''' </summary>
    ''' <param name="userData">The complete identity data in JSON format to be displayed in the data grids.</param>
    Public Sub LoadIdentityData(ByVal userData As JObject)
        InitializeDataGrid(Identity.DataGridUserInformation)
        InitializeDataGrid(Identity.DataGridPassword)

        PopulatePIIData(result:=userData)
        PopulateLoginData(loginInfo:=userData?("login"))

        Identity.Show()
    End Sub
End Class

