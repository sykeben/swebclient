Public Class Main
    Dim Quitting As Boolean
    Dim HomeUrl As String

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        If Not AppFrame.Url = New Uri(HomeUrl) Then
            Dim Answer As DialogResult = MessageBox.Show("Are you sure you want to go home?",
            "Confirm", MessageBoxButtons.YesNo)
            Select Case Answer
                Case Windows.Forms.DialogResult.Yes
                    AppFrame.Navigate(HomeUrl)
            End Select
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quitting = False
        HomeUrl = "https://sykeben.github.io/swebserver/"
        AppFrame.Navigate(HomeUrl)
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object,
    ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Quitting = False Then
            Dim Answer As DialogResult = MessageBox.Show("Are you sure you want to quit?",
            "Confirm", MessageBoxButtons.YesNo)
            Select Case Answer
                Case Windows.Forms.DialogResult.Yes
                    e.Cancel = False
                    Quitting = True
                    Application.Exit()
                Case Windows.Forms.DialogResult.No
                    Quitting = False
                    e.Cancel = True
                Case Else
                    Quitting = False
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub AppFrame_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles AppFrame.Navigated
        Title.Text = AppFrame.DocumentTitle
        If AppFrame.Url = New Uri(HomeUrl) Then
            Title.Text = "Home"
        End If
    End Sub

    Private Sub AppFrame_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles AppFrame.Navigating
        Title.Text = "Loading..."
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim Answer As DialogResult = MessageBox.Show("Are you sure you want to refresh?",
            "Confirm", MessageBoxButtons.YesNo)
        Select Case Answer
            Case Windows.Forms.DialogResult.Yes
                AppFrame.Refresh()
        End Select
    End Sub
End Class
