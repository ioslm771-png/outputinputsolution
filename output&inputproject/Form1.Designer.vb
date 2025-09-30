<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        NumericUpDown1 = New NumericUpDown()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(27, 229)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(120, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(27, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 23)
        Button1.TabIndex = 1
        Button1.Text = "حول المشروع"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(27, 70)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 23)
        Button2.TabIndex = 2
        Button2.Text = "خروج"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(27, 99)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 23)
        Button3.TabIndex = 3
        Button3.Text = "صندوق ادخال الالوان"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(27, 128)
        Button4.Name = "Button4"
        Button4.Size = New Size(132, 23)
        Button4.TabIndex = 4
        Button4.Text = "الالوان العشوائية"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(27, 157)
        Button5.Name = "Button5"
        Button5.Size = New Size(132, 23)
        Button5.TabIndex = 5
        Button5.Text = "الكتابة على عدة اسطر"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(27, 200)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(240, 450)
        Controls.Add(NumericUpDown1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "رسائل الاخراج والادخال"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown

End Class
