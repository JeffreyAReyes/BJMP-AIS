

Public Class frmLogin

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static i As Integer

        i = i + 1

        If i = 5 Then
            Me.Close()
        End If
    End Sub
End Class