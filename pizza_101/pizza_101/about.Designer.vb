﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(466, 340)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 49)
        Button1.TabIndex = 0
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' about
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(627, 447)
        Controls.Add(Button1)
        Name = "about"
        Text = "about"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
End Class
