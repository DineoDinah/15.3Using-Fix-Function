﻿Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		TextBox3.Text = Fix(Val(TextBox1.Text))
		TextBox4.Text = Fix(Val(TextBox2.Text))
	End Sub
End Class
