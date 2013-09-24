


Public Class frmAppSettings

#Region "Properties"

    Dim boolIsSettingsSaved As Boolean
    Public Property IsSettingsSaved() As Boolean
        Get
            Return boolIsSettingsSaved
        End Get
        Set(ByVal value As Boolean)
            boolIsSettingsSaved = value
        End Set
    End Property

#End Region

End Class