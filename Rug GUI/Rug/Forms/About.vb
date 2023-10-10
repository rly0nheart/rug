Public Class About
    Private Async Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonGetUpdates.Enabled = False
        LinkLabelCopyright.Text = My.Application.Info.Copyright


        Await CoreUtils.AsyncCheckUpdates()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub LinkLabelCopyright_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCopyright.LinkClicked
        Shell("cmd.exe /c start https://about.me/rly0nheart")
    End Sub

    Private Sub ButtonLicense_Click(sender As Object, e As EventArgs) Handles ButtonLicense.Click
        CoreUtils.License()
    End Sub

    Private Sub ButtonGetUpdates_Click(sender As Object, e As EventArgs) Handles ButtonGetUpdates.Click
        Shell("cmd.exe /c start https://github.com/rly0nheart/rug/releases/latest")
    End Sub
End Class