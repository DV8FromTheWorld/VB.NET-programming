Public Class Form1
    'Austin Keener
    '12/13/2012
    'String Function

    'Define required variables
    Dim strInput1 As String 
    Dim strInput2 As String

    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        If checkStrings() Then
            Select Case String.Compare(strInput1, strInput2)
                Case 0
                    lblDisplay.Text = strInput1 & " is equal to " & strInput2
                Case Is < 0
                    lblDisplay.Text = strInput1 & " comes before " & strInput2
                Case Is > 0
                    lblDisplay.Text = strInput1 & " comes after " & strInput2
            End Select
        End If
    End Sub

    Private Sub btnConcat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcat.Click
        If checkStrings() Then
            lblDisplay.Text = String.Concat(strInput1, strInput2)
        End If
    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        If checkStrings() Then
            If strInput1.Equals(strInput2) Then
                lblDisplay.Text = "The strings are the same."
            Else
                lblDisplay.Text = "The strings are different."
            End If
        End If
    End Sub

    Private Sub btnIndexOf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndexOf.Click
        If checkStrings() Then
            Dim intIndex As Integer = strInput1.IndexOf(strInput2)
            Select Case intIndex
                Case -1
                    lblDisplay.Text = "The second string appears no where in the first"
                Case Else
                    lblDisplay.Text = "The index of the second string is " & intIndex & " in the first string"
            End Select
        End If
    End Sub

    Private Sub btwInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btwInsert.Click
        If checkStrings() Then
            Dim intInsertIndex As Integer
            If Int32.TryParse(InputBox("Enter the index where the second string should be inserted into the first string", "Insert Index"), intInsertIndex) Then
                lblDisplay.Text = strInput1.Insert(intInsertIndex, strInput2)
            Else
                MessageBox.Show("Please enter a valid integer")
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If checkStrings() Then
            Dim intRemoveIndex1 As Integer
            Dim intRemoveIndex2 As Integer
            If Int32.TryParse(InputBox("Enter the index where the removal should begin for the first string", "First String Removal Index"), intRemoveIndex1) Then
                If Int32.TryParse(InputBox("Enter the index where the removal should begin for the second string", "Second String Removal Index"), intRemoveIndex2) Then
                    lblDisplay.Text = _
                        "First String: " & strInput1.Remove(intRemoveIndex1) & vbCrLf & _
                        "Second String: " & strInput2.Remove(intRemoveIndex2)
                Else
                    MessageBox.Show("Please enter a valid integer")
                End If
            Else
                MessageBox.Show("Please enter a valid integer")
            End If
        End If
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        If checkStrings() Then
            lblDisplay.Text = _
                strInput1.Replace(InputBox("Enter the string you want to replace from string 1", "String Replacement"), strInput2)
        End If
    End Sub

    Private Sub btnToLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToLower.Click
        If checkStrings() Then
            lblDisplay.Text = _
                "First string: " & strInput1.ToLower & vbCrLf & _
                "Second string: " & strInput2.ToLower
        End If
    End Sub

    Private Sub btnToUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToUpper.Click
        If checkStrings() Then
            lblDisplay.Text = _
                "First string: " & strInput1.ToUpper & vbCrLf & _
                "Second string: " & strInput2.ToUpper
        End If
    End Sub

    Private Sub btnTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrim.Click
        If checkStrings() Then
            lblDisplay.Text = _
                "String 1: " & strInput1.Trim & vbCrLf & _
                "String 2: " & strInput2.Trim
        End If
    End Sub

    Private Sub btnTrimEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrimEnd.Click
        If checkStrings() Then
            lblDisplay.Text = _
                "String 1: " & strInput1.TrimEnd & vbCrLf & _
                "String 2: " & strInput2.TrimEnd
        End If
    End Sub

    Private Sub btnTrimStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrimStart.Click
        If checkStrings() Then
            lblDisplay.Text = _
                "String 1: " & strInput1.TrimStart & vbCrLf & _
                "String 2: " & strInput2.TrimStart
        End If
    End Sub

    'Used be sure that the strings are not empty.
    Private Function checkStrings() As Boolean
        strInput1 = txtString1.Text
        strInput2 = txtString2.Text
        lblDisplay.Text = ""                                'resets the label 
        If Not String.IsNullOrEmpty(strInput1) Then         'Checks to see that the string isnt empty
            If Not String.IsNullOrEmpty(strInput2) Then     'Checks to see that the string isnt empty
                Return True
            Else
                MessageBox.Show("Please enter a string in the second textbox")      'User Debug
                Return False
            End If
        Else
            MessageBox.Show("Please enter a string in the first textbox")           'User Debug
            Return False
        End If
    End Function
End Class
