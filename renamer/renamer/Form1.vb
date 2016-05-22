Public Class Form1
    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        Dim beginning As Integer
        Dim ending As Integer
        Dim extension As String
        Dim path As String


        beginning = nudBegin.Value
        ending = nudEnd.Value
        extension = txtExt.Text
        path = txtPath.Text

        Try
            Rename(beginning, ending, extension, path)
        Catch ex As Exception
            MsgBox("There was an error renaming the files, please check all values and try again.", MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub Rename(ByVal beginning, ByVal ending, ByVal extension, ByVal path)

        For i As Integer = beginning To ending
            My.Computer.FileSystem.RenameFile(path + CStr(i) + extension, "0" + CStr(i) + extension)
        Next

        MsgBox("Files have successfully been renamed.", MsgBoxStyle.OkOnly, "Success!")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        nudBegin.Value = 0
        nudEnd.Value = 0
        txtExt.Text = ""
        txtPath.Text = ""
    End Sub
End Class
