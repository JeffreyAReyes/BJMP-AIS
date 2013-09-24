
Imports MySql.Data.MySqlClient

''' <summary>
''' Database procedures.
''' 
''' </summary>
''' <remarks>
''' Sept. 24, 2013 5:40 PM - Jeffrey A. Reyes
''' </remarks>
Module ModDatabase

    ''' <summary>
    ''' Retrieve data and returns data set.
    ''' </summary>
    ''' <param name="connString"></param>
    ''' <param name="commText"></param>
    ''' <param name="paramList"></param>
    ''' <param name="commType"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' A generic method of executing sql statement. Accepts any number of parameters to pass to the sql statement.
    ''' Sept. 24, 2013 9:05 PM - Jeffrey A. Reyes
    ''' </remarks>
    Public Function GetDataAndReturnDataSet(ByVal connString As String, ByVal commText As String, _
                ByVal paramList As Dictionary(Of String, String), ByVal commType As Integer) As DataSet

        Dim collData As New DataSet
        Dim myadapter As New MySqlDataAdapter

        Try
            Using myconn As New MySqlConnection(connString)

                Using mycomm As New MySqlCommand
                    With mycomm
                        .Connection = myconn
                        .CommandText = commText
                        .CommandType = commType

                        'iterate parameters
                        For Each key In paramList.Keys
                            .Parameters.AddWithValue(key, paramList(key))
                        Next

                    End With
                    
                    myconn.Open()

                    myadapter.SelectCommand = mycomm
                    myadapter.Fill(collData)

                End Using
            End Using
        Catch ex As MySqlException
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSet")
        Catch ex As Exception
            collData = Nothing
            Debug.Print(ex.Message & vbCrLf & ex.StackTrace & " In: GetDataAndReturnDataSet")
        End Try

        Return collData

    End Function

End Module
