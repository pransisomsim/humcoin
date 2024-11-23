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
        colorbuttonR = New RadioButton()
        colorbuttonB = New RadioButton()
        colorbuttonY = New RadioButton()
        Color = New GroupBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        sizebuttonL = New RadioButton()
        sizebuttonXL = New RadioButton()
        sizebuttonM = New RadioButton()
        sizebuttonS = New RadioButton()
        GroupBox2 = New GroupBox()
        Color.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' colorbuttonR
        ' 
        colorbuttonR.AutoSize = True
        colorbuttonR.Location = New Point(6, 73)
        colorbuttonR.Name = "colorbuttonR"
        colorbuttonR.Size = New Size(46, 19)
        colorbuttonR.TabIndex = 0
        colorbuttonR.TabStop = True
        colorbuttonR.Text = "RED"
        colorbuttonR.UseVisualStyleBackColor = True
        ' 
        ' colorbuttonB
        ' 
        colorbuttonB.AutoSize = True
        colorbuttonB.Location = New Point(6, 48)
        colorbuttonB.Name = "colorbuttonB"
        colorbuttonB.Size = New Size(52, 19)
        colorbuttonB.TabIndex = 0
        colorbuttonB.TabStop = True
        colorbuttonB.Text = "BLUE"
        colorbuttonB.UseVisualStyleBackColor = True
        ' 
        ' colorbuttonY
        ' 
        colorbuttonY.AutoSize = True
        colorbuttonY.Location = New Point(6, 22)
        colorbuttonY.Name = "colorbuttonY"
        colorbuttonY.Size = New Size(76, 19)
        colorbuttonY.TabIndex = 0
        colorbuttonY.TabStop = True
        colorbuttonY.Text = "YELLLOW"
        colorbuttonY.UseVisualStyleBackColor = True
        ' 
        ' Color
        ' 
        Color.Controls.Add(colorbuttonY)
        Color.Controls.Add(colorbuttonB)
        Color.Controls.Add(colorbuttonR)
        Color.Location = New Point(24, 31)
        Color.Name = "Color"
        Color.Size = New Size(113, 114)
        Color.TabIndex = 2
        Color.TabStop = False
        Color.Text = "COLOR"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(177, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 35)
        Button1.TabIndex = 4
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 5
        Label1.Text = "Size"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 5
        Label2.Text = "Color"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 5
        Label3.Text = "Price"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(74, 177)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(87, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(74, 206)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(87, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(74, 236)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(87, 23)
        TextBox3.TabIndex = 6
        ' 
        ' sizebuttonL
        ' 
        sizebuttonL.AutoSize = True
        sizebuttonL.Location = New Point(8, 67)
        sizebuttonL.Name = "sizebuttonL"
        sizebuttonL.Size = New Size(31, 19)
        sizebuttonL.TabIndex = 0
        sizebuttonL.TabStop = True
        sizebuttonL.Text = "L"
        sizebuttonL.UseVisualStyleBackColor = True
        ' 
        ' sizebuttonXL
        ' 
        sizebuttonXL.AutoSize = True
        sizebuttonXL.Location = New Point(8, 89)
        sizebuttonXL.Name = "sizebuttonXL"
        sizebuttonXL.Size = New Size(38, 19)
        sizebuttonXL.TabIndex = 0
        sizebuttonXL.TabStop = True
        sizebuttonXL.Text = "XL"
        sizebuttonXL.UseVisualStyleBackColor = True
        ' 
        ' sizebuttonM
        ' 
        sizebuttonM.AutoSize = True
        sizebuttonM.Location = New Point(8, 42)
        sizebuttonM.Name = "sizebuttonM"
        sizebuttonM.Size = New Size(36, 19)
        sizebuttonM.TabIndex = 0
        sizebuttonM.TabStop = True
        sizebuttonM.Text = "M"
        sizebuttonM.UseVisualStyleBackColor = True
        ' 
        ' sizebuttonS
        ' 
        sizebuttonS.AutoSize = True
        sizebuttonS.Location = New Point(8, 17)
        sizebuttonS.Name = "sizebuttonS"
        sizebuttonS.Size = New Size(31, 19)
        sizebuttonS.TabIndex = 0
        sizebuttonS.TabStop = True
        sizebuttonS.Text = "S"
        sizebuttonS.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(sizebuttonS)
        GroupBox2.Controls.Add(sizebuttonM)
        GroupBox2.Controls.Add(sizebuttonXL)
        GroupBox2.Controls.Add(sizebuttonL)
        GroupBox2.Location = New Point(169, 31)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(100, 114)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "SIZES"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(282, 303)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(Color)
        Name = "Form1"
        Text = "Form1"
        Color.ResumeLayout(False)
        Color.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents colorbuttonR As RadioButton
    Friend WithEvents colorbuttonB As RadioButton
    Friend WithEvents colorbuttonY As RadioButton
    Friend WithEvents Color As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents sizebuttonL As RadioButton
    Friend WithEvents sizebuttonXL As RadioButton
    Friend WithEvents sizebuttonM As RadioButton
    Friend WithEvents sizebuttonS As RadioButton
    Friend WithEvents GroupBox2 As GroupBox

End Class
