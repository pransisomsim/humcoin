<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Window
        Button2.BackgroundImage = My.Resources.Resources.subtract
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Location = New Point(136, 155)
        Button2.Name = "Button2"
        Button2.Size = New Size(64, 53)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Window
        Button3.BackgroundImage = My.Resources.Resources.div
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Location = New Point(21, 245)
        Button3.Name = "Button3"
        Button3.Size = New Size(64, 53)
        Button3.TabIndex = 1
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gainsboro
        Button4.BackgroundImage = My.Resources.Resources.equal
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Location = New Point(246, 155)
        Button4.Name = "Button4"
        Button4.Size = New Size(64, 53)
        Button4.TabIndex = 1
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.Window
        Button6.BackgroundImage = My.Resources.Resources.mult
        Button6.BackgroundImageLayout = ImageLayout.Zoom
        Button6.Location = New Point(136, 245)
        Button6.Name = "Button6"
        Button6.Size = New Size(64, 53)
        Button6.TabIndex = 1
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.OrangeRed
        Button7.BackgroundImage = My.Resources.Resources.clear
        Button7.BackgroundImageLayout = ImageLayout.Zoom
        Button7.Location = New Point(246, 245)
        Button7.Name = "Button7"
        Button7.Size = New Size(64, 53)
        Button7.TabIndex = 1
        Button7.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 46)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(97, 23)
        TextBox1.TabIndex = 2
        TextBox1.Text = "0"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(145, 46)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(28, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 105)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(307, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(215, 46)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(104, 23)
        TextBox4.TabIndex = 2
        TextBox4.Text = "0"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Window
        Button1.BackgroundImage = My.Resources.Resources.addd
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Location = New Point(21, 155)
        Button1.Name = "Button1"
        Button1.Size = New Size(64, 53)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(331, 326)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button7)
        Controls.Add(Button4)
        Controls.Add(Button6)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button

End Class
