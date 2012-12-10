Public Class Form1
    'Austin Keener
    '12/7/2012
    'GPA Array

    Private Sub btnAddGPAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGPAs.Click
        Dim dblGPAArray(4) As Double
        addGPA(dblGPAArray)
        displayGPA(dblGPAArray)
    End Sub

    Private Sub addGPA(ByRef gpaArray() As Double)
        For intCounter As Integer = 0 To (gpaArray.Length - 1)
            gpaArray(intCounter) = InputBox("Enter the GPA for set: " & (intCounter + 1))
        Next
    End Sub

    Private Sub displayGPA(ByVal gpaArray() As Double)
        For intCounter As Integer = 0 To (gpaArray.length - 1)
            lstDisplay.Items.Add("GPA #" & (intCounter + 1) & " is " & gpaArray(intCounter))
        Next
    End Sub
End Class
