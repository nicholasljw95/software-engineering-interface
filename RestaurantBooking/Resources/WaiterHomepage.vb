Public Class WaiterHomepage
    Private Sub btnOrderButton_Click(sender As Object, e As EventArgs) Handles btnOrderButton.Click
        pnlMakeOrder.Visible = True
        pnlCheckOrder.Visible = False

    End Sub


    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        MessageBox.Show("Returning to Main Menu")
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnMakeOrder_Click(sender As Object, e As EventArgs) Handles btnMakeOrder.Click
        MessageBox.Show("Order Successfull")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Returning to Main Menu")
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnFood1_Click(sender As Object, e As EventArgs) Handles btnFood1.Click
        MessageBox.Show("You Have Selected Burger!")
    End Sub

    Private Sub btnFood2_Click(sender As Object, e As EventArgs) Handles btnFood2.Click
        MessageBox.Show("You Have Selected Turkey!")
    End Sub

    Private Sub btnFood3_Click(sender As Object, e As EventArgs) Handles btnFood3.Click
        MessageBox.Show("You Have Selected Coffee!")
    End Sub

    Private Sub btnCheckOrder_Click(sender As Object, e As EventArgs) Handles btnCheckOrder.Click

    End Sub
End Class