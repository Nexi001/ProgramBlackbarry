Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gajbica(Val(TextBox1.Text), Val(TextBox5.Text))
        cenica(Val(TextBox6.Text))
        andzarada(Val(TextBox3.Text))
        nenzarda(Val(TextBox4.Text))
        ukupno(Val(TextBox7.Text), Val(TextBox2.Text))
        Label11.Text = Str(andjelka())
        Label12.Text = Str(nenad())
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        Label11.Text = "0"
        Label12.Text = "0"
    End Sub
End Class
