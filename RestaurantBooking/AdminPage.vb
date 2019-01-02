Public Class AdminPage
    Dim str(6) As String
    Dim itm As ListViewItem
    Dim i = 1

    Public Property TimeOfDay() As DateTime

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlDay.SelectedIndex = 0
    End Sub

    Private Sub ddlDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDay.SelectedIndexChanged
        If (ddlDay.SelectedIndex.Equals(0)) Then
            listTransaction.Items.Remove(itm)

            str(0) = i.ToString()
            str(1) = 2.ToString()
            str(2) = "Dine in"
            str(3) = TimeOfDay.ToString("h:mm:ss tt")
            str(4) = "RM30.50"
            str(5) = "Dining"

            itm = New ListViewItem(str)
            listTransaction.Items.Add(itm)
        ElseIf (ddlDay.SelectedIndex.Equals(1)) Then
            listTransaction.Items.Remove(itm)

            str(0) = i.ToString()
            str(1) = 4.ToString()
            str(2) = "Reservation"
            str(3) = TimeOfDay.ToString("h:mm:ss tt")
            str(4) = "RM28.30"
            str(5) = "Paid"

            itm = New ListViewItem(str)
            listTransaction.Items.Add(itm)
        End If

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        MsgBox("Successfully exported")
    End Sub
End Class