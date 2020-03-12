Public Class Form1

    Private Sub AC_Click(sender As Object, e As EventArgs) Handles AC.Click
        If Expression_txtbx.Text = "" Then
            Expression_txtbx.Text = ""
        Else
            Expression_txtbx.Text = "0"
        End If
    End Sub

    Private Sub One_Click(sender As Object, e As EventArgs) Handles One.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "1"
        Else
            Expression_txtbx.Text = 1
        End If
    End Sub

    Private Sub Two_Click(sender As Object, e As EventArgs) Handles Two.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "2"
        Else
            Expression_txtbx.Text = 2
        End If
    End Sub

    Private Sub Three_Click(sender As Object, e As EventArgs) Handles Three.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "3"
        Else
            Expression_txtbx.Text = 3
        End If
    End Sub

    Private Sub Four_Click(sender As Object, e As EventArgs) Handles Four.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "4"
        Else
            Expression_txtbx.Text = 4
        End If
    End Sub

    Private Sub Five_Click(sender As Object, e As EventArgs) Handles Five.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "5"
        Else
            Expression_txtbx.Text = 5
        End If
    End Sub

    Private Sub Six_Click(sender As Object, e As EventArgs) Handles Six.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "6"
        Else
            Expression_txtbx.Text = 6
        End If
    End Sub

    Private Sub Seven_Click(sender As Object, e As EventArgs) Handles Seven.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "7"
        Else
            Expression_txtbx.Text = 7
        End If
    End Sub

    Private Sub Eight_Click(sender As Object, e As EventArgs) Handles Eight.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "8"
        Else
            Expression_txtbx.Text = 8
        End If
    End Sub

    Private Sub Nine_Click(sender As Object, e As EventArgs) Handles Nine.Click
        If Expression_txtbx.Text <> "0" Then
            Expression_txtbx.Text += "9"
        Else
            Expression_txtbx.Text = 9
        End If
    End Sub


End Class