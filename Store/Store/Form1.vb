Public Class Form1
    Dim products() As String = {"SPAGHETTI", "CHICKEN", "BURGER", "JUICE"}
    Dim total, subtotal, quantity As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim item As Integer
        For i = 0 To products.Length - 1
            Dim product As String = products(i)

            If product.Contains(ComboBox1.Text) Then
                ListBox1.Items.Add(product)
                ListBox2.Items.Add(Val(ComboBox2.Text))
                If product = "SPAGHETTI" Then
                    ListBox4.Items.Add(100)
                    subtotal = 100 * Val(ComboBox2.Text)
                    ListBox3.Items.Add(subtotal)
                    total = total + subtotal
                    burgir.Hide()
                    manuk.Hide()
                    juice.Hide()
                    spagiti.Show()

                ElseIf product = "CHICKEN" Then
                    ListBox4.Items.Add(85)
                    subtotal = 85 * Val(ComboBox2.Text)
                    ListBox3.Items.Add(subtotal)
                    total = total + subtotal
                    burgir.Hide()
                    manuk.Show()
                    juice.Hide()
                    spagiti.Hide()

                ElseIf product = "JUICE" Then
                    ListBox4.Items.Add(40)
                    subtotal = 40 * Val(ComboBox2.Text)
                    ListBox3.Items.Add(subtotal)
                    total = total + subtotal
                    burgir.Hide()
                    manuk.Hide()
                    juice.Show()
                    spagiti.Hide()

                ElseIf product = "BURGER" Then
                    ListBox4.Items.Add(50)
                    subtotal = 50 * Val(ComboBox2.Text)
                    ListBox3.Items.Add(subtotal)
                    total = total + subtotal
                    burgir.Show()
                    manuk.Hide()
                    juice.Hide()
                    spagiti.Hide()
                Else
                    burgir.Hide()
                    manuk.Hide()
                    juice.Hide()
                    spagiti.Hide()
                End If
            End If
        Next
        Label6.Text = total
    End Sub
End Class
