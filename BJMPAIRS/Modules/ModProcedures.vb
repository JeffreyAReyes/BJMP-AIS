
''' <summary>
''' Global procedures used throughout the application
''' 
''' </summary>
''' <remarks>
''' Sept. 23, 2013 10:55 AM - Jeffrey A. Reyes
''' </remarks>
Module ModProcedures

    ''' <summary>
    ''' Procedure to load application settings.
    ''' Called during application start-up.
    ''' </summary>
    ''' <remarks>
    ''' Sept. 23, 2013 10:56 AM - Jeffrey A. Reyes
    ''' </remarks>
    Public Sub LoadAppSettings()

        With My.Settings
            AppName = .AppName
            StreetAddress = .AddressStreet
            Province = .Province
            City = .City
            BranchName = .BJMPBranch
        End With
    End Sub

End Module
