Public Class Form1

    Dim INR As Double = 76.8395451
    Dim SEK As Double = 10.6044725
    Dim NGN As Double = 403.7257
    Dim USD As Double = 1.12155
    Dim GB As Double = 0.897006778
    Dim CAD As Double = 1.466838
    Function converter(ByVal balance As Double) As Double
        If ComboBox1.Text = "USA" Then
            Return Math.Round(USD * balance, 2)
        ElseIf ComboBox1.Text = "UK" Then
            Return Math.Round(GB * balance, 2)
        ElseIf ComboBox1.Text = "Nigeria" Then
            Return Math.Round(NGN * balance, 2)
        ElseIf ComboBox1.Text = "Canada" Then
            Return Math.Round(CAD * balance, 2)
        ElseIf ComboBox1.Text = "India" Then
            Return Math.Round(INR * balance, 2)
        ElseIf ComboBox1.Text = "Sweden" Then
            Return Math.Round(SEK * balance, 2)
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Startbttn.Visible = True
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Choose one..."
        ComboBox1.Items.Add("USA")
        ComboBox1.Items.Add("Nigeria")
        ComboBox1.Items.Add("Canada")
        ComboBox1.Items.Add("India")
        ComboBox1.Items.Add("UK")
        ComboBox1.Items.Add("Sweden")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = "Choose one..."
        TextBox1.Text = ""
        Label4.Text = " "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text = "USA" Then
            Label4.Text = "USD" & " " & Val(Label4.Text)
        ElseIf ComboBox1.Text = "UK" Then
            Label4.Text = "UK" & " " & Val(Label4.Text)
        ElseIf ComboBox1.Text = "Sweden" Then
            Label4.Text = "SEK" & " " & Val(Label4.Text)
        ElseIf ComboBox1.Text = "India" Then
            Label4.Text = "INR" & " " & Val(Label4.Text)
        ElseIf ComboBox1.Text = "Canada" Then
            Label4.Text = "CAD" & " " & Val(Label4.Text)
        ElseIf ComboBox1.Text = "Nigeria" Then
            Label4.Text = "NGN" & " " & Val(Label4.Text)
        ElseIf ComboBox1.Text = "Choose one..." Then
            Dim unused = MessageBox.Show("Please pick destination first!")
        End If
    End Sub

    Private Sub Startbttn_Click(sender As Object, e As EventArgs) Handles Startbttn.Click
        Startbttn.Visible = False
    End Sub

End Class
