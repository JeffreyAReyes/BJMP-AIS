

Public Class frmMain

#Region "Miscellaneous Procedures"

    Private Sub SetMenusAsDisabled()
        With Me
            .RibbonPanel2.Enabled = False
            .RibbonPanel3.Enabled = False
        End With
    End Sub
#End Region

#Region "Database Procedures"

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load application settings
        LoadAppSettings()

        With Me
            .Text = AppName
            .tsUserName.Text = "Current Logged In: Jeffrey A. Reyes"
            .tsDate.Text = FormatDateTime(Date.Today.Date, DateFormat.LongDate)
            .Webmain.Navigate(Application.StartupPath & "\WebPages\WebMain.mht")
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        SetMenusAsDisabled()

        If My.Settings.DatabaseHost.ToString.Trim.Length <= 0 Then
            'If database settings is not yet defined, load settings form to define it.
            Dim newfrmapp As New frmAppSettings

            With newfrmapp
                .ShowDialog()
                If .IsSettingsSaved = True Then
                    'show login form
                    Dim newfrm As New frmLogin

                    With newfrm
                        .ShowDialog()
                    End With
                Else
                    'SetMenusAsDisabled()
                End If
            End With
        End If

        
    End Sub

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        Dim newfrmapp As New frmAppSettings
        With newfrmapp
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        'show login form
        Dim newfrm As New frmLogin

        With newfrm
            .ShowDialog()
        End With
    End Sub

End Class
