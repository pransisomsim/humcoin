Public Class Form1
    Dim FirstNUM, SecondNum, Result As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox4.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = "+"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = "/"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = "*"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text = "+" Then
            FirstNUM = Val(TextBox1.Text)
            SecondNum = Val(TextBox4.Text)

            Result = FirstNUM + SecondNum
            TextBox3.Text = Result

        ElseIf TextBox2.Text = "-" Then
            FirstNUM = Val(TextBox1.Text)
            SecondNum = Val(TextBox4.Text)

            Result = FirstNUM - SecondNum
            TextBox3.Text = Result

        ElseIf TextBox2.Text = "*" Then
            FirstNUM = Val(TextBox1.Text)
            SecondNum = Val(TextBox4.Text)

            Result = FirstNUM * SecondNum
            TextBox3.Text = Result

        ElseIf TextBox2.Text = "/" Then
            FirstNUM = Val(TextBox1.Text)
            SecondNum = Val(TextBox4.Text)

            Result = FirstNUM / SecondNum
            TextBox3.Text = Result

        Else
            TextBox3.Text = "Invalid Operator"
        End If
    End Sub
End Class
