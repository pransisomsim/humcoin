Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class pizza
    Dim order_total, toppings, drinks, total, size As Integer
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        size = 400
        total = total + size
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        size = 150
        total = total + size
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        size = 250
        total = total + size
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim subTotal1, subTotal As Integer
        Dim sodaCan, soda8oz, soda15L, juice, water As Integer

        toppings = 0
        If CheckBox1.Checked Then toppings += 25
        If CheckBox2.Checked Then toppings += 50
        If CheckBox3.Checked Then toppings += 40
        If CheckBox4.Checked Then toppings += 15
        If CheckBox5.Checked Then toppings += 25
        ToppingsTotal.Text = toppings

        order_total = 0
        subTotal = Val(BreadStick.Text) * 30
        subTotal1 = Val(ChickenWings.Text) * 50
        order_total = subTotal1 + subTotal
        TextBox2.Text = subTotal
        TextBox4.Text = subTotal1
        OrderTotal.Text = order_total

        drinks = 0
        sodaCan = Val(TextBox1.Text) * 30
        soda8oz = Val(TextBox3.Text) * 15
        soda15L = Val(TextBox5.Text) * 60
        juice = Val(TextBox6.Text) * 30
        water = Val(TextBox7.Text) * 20

        TextBox8.Text = sodaCan
        TextBox9.Text = soda8oz
        TextBox10.Text = soda15L
        TextBox11.Text = juice
        TextBox12.Text = water

        drinks = sodaCan + soda8oz + soda15L + juice + water

        TextBox13.Text = size
        TextBox14.Text = toppings
        TextBox15.Text = order_total
        TextBox16.Text = drinks
        TextBox17.Text = size + toppings + order_total + drinks
    End Sub
End Class