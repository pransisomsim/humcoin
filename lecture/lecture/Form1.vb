
Public Class Form1
    Dim price As Integer

    Private Sub colorbuttonY_CheckedChanged(sender As Object, e As EventArgs) Handles colorbuttonY.CheckedChanged
        TextBox2.Text = colorbuttonY.Text
    End Sub

    Private Sub colorbuttonR_CheckedChanged(sender As Object, e As EventArgs) Handles colorbuttonR.CheckedChanged
        TextBox2.Text = colorbuttonR.Text
    End Sub

    Private Sub sizebuttonS_CheckedChanged(sender As Object, e As EventArgs) Handles sizebuttonS.CheckedChanged
        If colorbuttonB.Checked Then
            price = 120
        Else
            price = 100
        End If

        TextBox3.Text = price
        TextBox1.Text = sizebuttonS.Text
    End Sub

    Private Sub sizebuttonM_CheckedChanged(sender As Object, e As EventArgs) Handles sizebuttonM.CheckedChanged
        If colorbuttonB.Checked Then
            price = 140
        Else
            price = 110
        End If
        TextBox3.Text = price
        TextBox1.Text = sizebuttonM.Text
    End Sub

    Private Sub sizebuttonL_CheckedChanged(sender As Object, e As EventArgs) Handles sizebuttonL.CheckedChanged
        If colorbuttonB.Checked Then
            price = 160
        Else
            price = 120
        End If
        TextBox3.Text = price
        TextBox1.Text = sizebuttonL.Text
    End Sub

    Private Sub sizebuttonXL_CheckedChanged(sender As Object, e As EventArgs) Handles sizebuttonXL.CheckedChanged
        If colorbuttonB.Checked Then
            price = 180
        Else
            price = 130
        End If
        TextBox3.Text = price
        TextBox1.Text = sizebuttonXL.Text
    End Sub

    Private Sub colorbuttonB_CheckedChanged(sender As Object, e As EventArgs) Handles colorbuttonB.CheckedChanged
        TextBox2.Text = colorbuttonB.Text
    End Sub
End Class
