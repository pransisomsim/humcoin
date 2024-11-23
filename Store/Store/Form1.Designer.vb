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
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        ListBox4 = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        Button2 = New Button()
        spagiti = New PictureBox()
        manuk = New PictureBox()
        burgir = New PictureBox()
        juice = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        CType(spagiti, ComponentModel.ISupportInitialize).BeginInit()
        CType(manuk, ComponentModel.ISupportInitialize).BeginInit()
        CType(burgir, ComponentModel.ISupportInitialize).BeginInit()
        CType(juice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.AntiqueWhite
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"SPAGHETTI", "CHICKEN", "JUICE", "BURGER"})
        ComboBox1.Location = New Point(40, 30)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(213, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(269, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(62, 25)
        Button1.TabIndex = 1
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.Linen
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(27, 202)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(115, 124)
        ListBox1.TabIndex = 2
        ' 
        ' ListBox2
        ' 
        ListBox2.BackColor = Color.Linen
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(164, 202)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(89, 124)
        ListBox2.TabIndex = 2
        ' 
        ' ListBox3
        ' 
        ListBox3.BackColor = Color.Linen
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 15
        ListBox3.Location = New Point(402, 202)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(147, 124)
        ListBox3.TabIndex = 2
        ' 
        ' ListBox4
        ' 
        ListBox4.BackColor = Color.Linen
        ListBox4.FormattingEnabled = True
        ListBox4.ItemHeight = 15
        ListBox4.Location = New Point(269, 202)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(102, 124)
        ListBox4.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Linen
        Label1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(27, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 16)
        Label1.TabIndex = 3
        Label1.Text = "Product"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Linen
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(164, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 16)
        Label2.TabIndex = 3
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Linen
        Label3.Font = New Font("Arial", 9.75F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(269, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 16)
        Label3.TabIndex = 3
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Linen
        Label4.Font = New Font("Arial", 9.75F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(402, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 16)
        Label4.TabIndex = 3
        Label4.Text = "Total"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.AntiqueWhite
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        ComboBox2.Location = New Point(40, 59)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(213, 23)
        ComboBox2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(269, 59)
        Button2.Name = "Button2"
        Button2.Size = New Size(62, 25)
        Button2.TabIndex = 1
        Button2.Text = "Order"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' spagiti
        ' 
        spagiti.BackgroundImage = My.Resources.Resources.spag
        spagiti.BackgroundImageLayout = ImageLayout.Stretch
        spagiti.Location = New Point(416, 30)
        spagiti.Name = "spagiti"
        spagiti.Size = New Size(133, 110)
        spagiti.TabIndex = 5
        spagiti.TabStop = False
        ' 
        ' manuk
        ' 
        manuk.BackgroundImage = My.Resources.Resources.mang
        manuk.BackgroundImageLayout = ImageLayout.Stretch
        manuk.Location = New Point(416, 30)
        manuk.Name = "manuk"
        manuk.Size = New Size(133, 110)
        manuk.TabIndex = 6
        manuk.TabStop = False
        ' 
        ' burgir
        ' 
        burgir.BackgroundImage = My.Resources.Resources.burgir
        burgir.BackgroundImageLayout = ImageLayout.Stretch
        burgir.Location = New Point(416, 30)
        burgir.Name = "burgir"
        burgir.Size = New Size(133, 110)
        burgir.TabIndex = 7
        burgir.TabStop = False
        ' 
        ' juice
        ' 
        juice.BackgroundImage = My.Resources.Resources.Orange_Juice_1_of_1
        juice.BackgroundImageLayout = ImageLayout.Stretch
        juice.Location = New Point(416, 30)
        juice.Name = "juice"
        juice.Size = New Size(133, 110)
        juice.TabIndex = 9
        juice.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Linen
        Label5.Font = New Font("Arial", 9.75F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(402, 330)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 16)
        Label5.TabIndex = 10
        Label5.Text = "Total"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Linen
        Label6.Font = New Font("Arial", 9.75F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(442, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(14, 16)
        Label6.TabIndex = 11
        Label6.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.tabletop_looking_out_empty_restaurant
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(561, 355)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(juice)
        Controls.Add(burgir)
        Controls.Add(manuk)
        Controls.Add(spagiti)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListBox3)
        Controls.Add(ListBox4)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        CType(spagiti, ComponentModel.ISupportInitialize).EndInit()
        CType(manuk, ComponentModel.ISupportInitialize).EndInit()
        CType(burgir, ComponentModel.ISupportInitialize).EndInit()
        CType(juice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents spagiti As PictureBox
    Friend WithEvents manuk As PictureBox
    Friend WithEvents burgir As PictureBox
    Friend WithEvents juice As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
