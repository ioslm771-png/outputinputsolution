Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ,صندوق ادخال الالوان
         i = InputBox(15و "الرجالء ادخال عدد بين الصفر""," صندوق الالدخال)
        ,الاجراء من الخروج
        If I >= 0 And I <= 15 Then
            Me.BackColor = System.Drawing.ColorTranslator.FromOle(QBColor(Val(i)))
        Else
            MsgBox("الادخال خاطى"",,"تنبيه"")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ,الالوان العشوائية
        Randomize()
        Me.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(Rnd()
            255, rnd( *255,rnd() * 255))
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
     ,حول المشروع
 w = Chr(13) + Chr(10)
        x = x + "جامعة الملك خالد " + w
        x = x + "مركز التدريب وخدمة المجتمع" + w
        x = x + "دبلوم الحاسب الالي" + w
        x = x + "اعداد حديفه " + w
        x = x + "للعام الدراسي 1442ا" + w
        y = "حول المشروع"
        MsgBox(Xaml, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, y)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ,خروج
        x = "هل تريد الخروج"
        Y = "تحدير"
        K = MsgBox(X, MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight)
        If K = 6 Then End

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ,الكتابة على عدة اسطر
        W = Char(13) + Chr(10)
        TextBox1.Text = "الحمدالله" + w + "رب العالمين"
        Label.Text = "الحمدالله" + w + "رب العالمين"
    End Sub
End Class
