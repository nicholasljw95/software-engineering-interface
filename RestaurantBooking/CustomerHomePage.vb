Public Class CustomerHomePage
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtTime.Text = "" Then
            txtTime.Text = "Example : 1400"
        End If

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        BunifuCustomLabel5.Visible = False
        BunifuCustomLabel7.Visible = False
        BunifuCustomLabel8.Visible = False
        BunifuCustomLabel9.Visible = False
        BunifuCustomLabel10.Visible = False
        BunifuMetroTextbox1.Visible = False
        BunifuFlatButton2.Visible = False
        BunifuFlatButton3.Visible = False
        BunifuCustomLabel11.Visible = False
        BunifuCustomLabel12.Visible = False
        BunifuCustomLabel13.Visible = False
        BunifuCustomLabel14.Visible = False
        BunifuCustomLabel15.Visible = False
        BunifuCustomLabel16.Visible = False
        BunifuCustomLabel17.Visible = False
        BunifuCustomLabel18.Visible = False
        BunifuCustomLabel19.Visible = False

    End Sub

    Private Sub txtTime_Enter(sender As Object, e As EventArgs) Handles txtTime.Enter
        txtTime.Text = ""
    End Sub

    Private Sub btnChooseFood_Click(sender As Object, e As EventArgs) Handles btnChooseFood.Click
        BunifuCustomLabel1.Visible = False
        BunifuCustomLabel2.Visible = False
        BunifuCustomLabel3.Visible = False
        BunifuCustomLabel4.Visible = False
        BunifuDatepicker1.Visible = False
        BunifuMetroTextbox2.Visible = False
        txtTime.Visible = False
        btnChooseFood.Visible = False
        Panel1.Visible = True
        Panel2.Visible = True
        Panel3.Visible = True
        BunifuCustomLabel5.Visible = True
        BunifuMetroTextbox1.Visible = True
        BunifuCustomLabel6.Visible = False
        BunifuFlatButton2.Visible = True
        BunifuFlatButton3.Visible = True
        BunifuCustomLabel9.Visible = True
        BunifuFlatButton1.Visible = False

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        BunifuCustomLabel1.Visible = True
        BunifuCustomLabel2.Visible = True
        BunifuCustomLabel3.Visible = True
        BunifuCustomLabel4.Visible = True
        BunifuDatepicker1.Visible = True
        BunifuMetroTextbox2.Visible = True
        txtTime.Visible = True
        btnChooseFood.Visible = True
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        BunifuCustomLabel5.Visible = False
        BunifuMetroTextbox1.Visible = False
        BunifuFlatButton2.Visible = False
        BunifuFlatButton3.Visible = False
        BunifuCustomLabel6.Visible = True
        BunifuCustomLabel7.Visible = False
        BunifuCustomLabel8.Visible = False
        BunifuCustomLabel9.Visible = False
        BunifuFlatButton1.Visible = True
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        BunifuCustomLabel7.Visible = True
        BunifuCustomLabel8.Visible = True
        BunifuCustomLabel9.Visible = True
        BunifuCustomLabel6.Text = "Total :       RM145.00"
        BunifuCustomLabel9.Text = "Total :       RM145.00"

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BunifuCustomLabel10.Visible = True
        BunifuCustomLabel1.Visible = False
        BunifuCustomLabel2.Visible = False
        BunifuCustomLabel3.Visible = False
        BunifuCustomLabel4.Visible = False
        BunifuDatepicker1.Visible = False
        BunifuMetroTextbox2.Visible = False
        txtTime.Visible = False
        btnChooseFood.Visible = False
        BunifuCustomLabel6.Visible = False
        BunifuFlatButton1.Visible = False
    End Sub

    Private Sub btnAdvanceOrder_Click(sender As Object, e As EventArgs) Handles btnAdvanceOrder.Click
        If txtTime.Text = "" Then
            txtTime.Text = "Example : 1400"
        End If

        BunifuCustomLabel10.Visible = False
        BunifuCustomLabel1.Visible = True
        BunifuCustomLabel2.Visible = True
        BunifuCustomLabel3.Visible = True
        BunifuCustomLabel4.Visible = True
        BunifuDatepicker1.Visible = True
        BunifuMetroTextbox2.Visible = True
        txtTime.Visible = True
        btnChooseFood.Visible = True
        BunifuCustomLabel6.Visible = True
        BunifuFlatButton1.Visible = True
        BunifuCustomLabel6.Text = "Total :       RM0.00"
        BunifuCustomLabel3.Text = "Remark :"
        BunifuCustomLabel11.Visible = False
        BunifuCustomLabel12.Visible = False
        BunifuCustomLabel13.Visible = False
        BunifuCustomLabel14.Visible = False
        BunifuCustomLabel15.Visible = False
        BunifuCustomLabel16.Visible = False
        BunifuCustomLabel17.Visible = False
        BunifuCustomLabel18.Visible = False
        BunifuCustomLabel19.Visible = False

    End Sub

    Private Sub btnRoomReserve_Click(sender As Object, e As EventArgs) Handles btnRoomReserve.Click
        BunifuCustomLabel10.Visible = False
        BunifuCustomLabel1.Visible = True
        BunifuCustomLabel2.Visible = True
        BunifuCustomLabel3.Visible = True
        BunifuDatepicker1.Visible = True
        txtTime.Visible = True
        BunifuFlatButton1.Visible = True

        BunifuMetroTextbox2.Visible = True
        BunifuCustomLabel3.Text = "    Room :"
        BunifuCustomLabel4.Visible = False
        btnChooseFood.Visible = False
        BunifuCustomLabel6.Visible = False
        BunifuCustomLabel11.Visible = False
        BunifuCustomLabel12.Visible = False
        BunifuCustomLabel13.Visible = False
        BunifuCustomLabel14.Visible = False
        BunifuCustomLabel15.Visible = False
        BunifuCustomLabel16.Visible = False
        BunifuCustomLabel17.Visible = False
        BunifuCustomLabel18.Visible = False
        BunifuCustomLabel19.Visible = False

    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        BunifuCustomLabel10.Visible = False
        BunifuCustomLabel1.Visible = False
        BunifuCustomLabel2.Visible = False
        BunifuCustomLabel3.Visible = False
        BunifuCustomLabel4.Visible = False
        BunifuDatepicker1.Visible = False
        BunifuMetroTextbox2.Visible = False
        txtTime.Visible = False
        btnChooseFood.Visible = False
        BunifuCustomLabel6.Visible = False
        BunifuFlatButton1.Visible = False
        BunifuCustomLabel11.Visible = True
        BunifuCustomLabel12.Visible = True
        BunifuCustomLabel13.Visible = True
        BunifuCustomLabel14.Visible = True
        BunifuCustomLabel15.Visible = True
        BunifuCustomLabel16.Visible = True
        BunifuCustomLabel17.Visible = True
        BunifuCustomLabel18.Visible = True
        BunifuCustomLabel19.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BunifuCustomLabel10.Visible = False
        BunifuCustomLabel1.Visible = False
        BunifuCustomLabel2.Visible = False
        BunifuCustomLabel3.Visible = False
        BunifuCustomLabel4.Visible = False
        BunifuDatepicker1.Visible = False
        BunifuMetroTextbox2.Visible = False
        BunifuCustomLabel11.Visible = False
        BunifuCustomLabel12.Visible = False
        BunifuCustomLabel13.Visible = False
        BunifuCustomLabel14.Visible = False
        BunifuCustomLabel15.Visible = False
        BunifuCustomLabel16.Visible = False
        BunifuCustomLabel17.Visible = False
        BunifuCustomLabel18.Visible = False
        txtTime.Visible = False
        btnChooseFood.Visible = False
        BunifuCustomLabel6.Visible = False
        BunifuFlatButton1.Visible = False
        BunifuCustomLabel19.Visible = True
    End Sub
End Class
