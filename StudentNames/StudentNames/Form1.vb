Public Class Form1
    'Austin Keener
    '12/4/2012
    'Student Names

    Private Sub btnAddNames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNames.Click
        Dim arrayStudentNames(19) As String                                 'Defines a array with 20 elements (0 - 19)
        For intCounter As Integer = 0 To (arrayStudentNames.Length - 1)     'loops to get the names of the students
            arrayStudentNames(intCounter) = InputBox("Enter Student Name", "Enter Names")
        Next
        For intCounter As Integer = 0 To (arrayStudentNames.Length - 1)     'loops to enter the names into a list box
            lstStudentNames.Items.Add(arrayStudentNames(intCounter))
        Next
    End Sub
End Class
