Public Class Form1
    'Austin Keener
    '12/4/2012
    'Favorite Foods

    Dim strFavoriteFoodsArray(4) As String      'Defines an array, for strings, with 5 elements (0 - 4)

    Private Sub btnEnterFoods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterFoods.Click
        enterFoods(strFavoriteFoodsArray)
    End Sub

    Private Sub btnShowFoods_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowFoods.Click
        showFoods(strFavoriteFoodsArray)
    End Sub

    Private Sub enterFoods(ByVal strFoods() As String)
        lstFoodDisplay.Items.Clear()
        For intcounter As Integer = 0 To (strFoods.Length - 1)
            lstFoodDisplay.Items.Add(strFoods(intcounter))
        Next
    End Sub

    Private Sub showFoods(ByVal strFoods() As String)
        lstFoodDisplay.Items.Clear()
        For intcounter As Integer = 0 To (strFoods.Length - 1)
            lstFoodDisplay.Items.Add(strFoods(intcounter))
        Next
    End Sub
End Class
