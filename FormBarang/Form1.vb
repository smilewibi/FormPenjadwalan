Imports System.IO

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub path_TextChanged(sender As Object, e As EventArgs) Handles path.TextChanged

    End Sub

    Private Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog.Title = "Pilih File Tugas"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            path.Text = openFileDialog.FileName
            Dim filePath As String = path.Text
            If File.Exists(filePath) Then
                Dim highPriority As New List(Of String)()
                Dim mediumPriority As New List(Of String)()
                Dim lowPriority As New List(Of String)()

                ReadAndCategorizeTasks(filePath, highPriority, mediumPriority, lowPriority)

                ListBox1.Items.Clear()
                ListBox1.Items.Add("Prioritas Tinggi:")
                AddTasksToListBox(highPriority)
                ListBox1.Items.Add("Prioritas Sedang:")
                AddTasksToListBox(mediumPriority)
                ListBox1.Items.Add("Prioritas Rendah:")
                AddTasksToListBox(lowPriority)
            Else
                MessageBox.Show("File tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ReadAndCategorizeTasks(filePath As String, high As List(Of String), medium As List(Of String), low As List(Of String))
        Dim lines() As String = File.ReadAllLines(filePath)
        For Each line As String In lines
            Dim parts() As String = line.Split(","c)
            If parts.Length = 2 Then
                Dim task As String = parts(0).Trim()
                Dim priority As String = parts(1).Trim().ToLower()

                If priority = "tinggi" Then
                    high.Add(task)
                ElseIf priority = "sedang" Then
                    medium.Add(task)
                ElseIf priority = "rendah" Then
                    low.Add(task)
                Else
                    MessageBox.Show($"Prioritas tidak valid: {priority}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show($"Format tidak valid: {line}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Next
    End Sub

    Private Sub AddTasksToListBox(tasks As List(Of String))
        If tasks.Count > 0 Then
            For Each task As String In tasks
                ListBox1.Items.Add("- " & task)
            Next
        Else
            ListBox1.Items.Add("(Tidak ada tugas)")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
