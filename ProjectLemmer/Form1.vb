Imports System.IO

Public Class Form1
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog.Title = "Select a text file"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Read the selected text file
            Dim filePath As String = openFileDialog.FileName
            Dim lines As String() = File.ReadAllLines(filePath)

            ' Split each line by commas and populate the DataGridView
            dgvData.Rows.Clear()
            For Each line As String In lines
                Dim values As String() = line.Split(","c)
                dgvData.Rows.Add(values)
            Next
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
