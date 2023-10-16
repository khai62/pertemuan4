Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Sepeda Motor")
        ComboBox1.Items.Add("Bajai")
        ComboBox1.Items.Add("Mobil")
        ComboBox1.Items.Add("Truk")
        ComboBox1.Items.Add("Bus")


        ComboBox2.Items.Add("Pertamax")
        ComboBox2.Items.Add("Pertalite")
        ComboBox2.Items.Add("Pertamax Turbo")
        ComboBox2.Items.Add("Dexlite")
        ComboBox2.Items.Add("Pertamina Dex")
        ComboBox2.Items.Add("Pertamina Biosolar")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Pertamax"
                TextBox1.Text = 12400
            Case "Pertalite"
                TextBox1.Text = 10000
            Case "Pertamax Turbo"
                TextBox1.Text = 14400
            Case "Dexlite"
                TextBox1.Text = 13950
            Case "Pertamina Dex"
                TextBox1.Text = 14350
            Case "Pertamina Biosolar"
                TextBox1.Text = 6800
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Sepeda Motor"
                Label13.Text = "Roda Dua"
            Case "Bajai"
                Label13.Text = "Roda Tiga"
            Case "Mobil"
                Label13.Text = "Roda Empat / Enam"
            Case "Truk"
                Label13.Text = "Roda Empat / Enam"
            Case "Bus"
                Label13.Text = "Roda Empat / Enam"
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Double = Val(TextBox2.Text) / Val(TextBox1.Text)

        If RadioButton1.Checked = True Then
            Label14.Text = "Rp. " & Val(TextBox2.Text) * Val(TextBox1.Text)
            Label15.Text = TextBox2.Text & " Liter"
        End If
        If RadioButton2.Checked = True Then
            Label14.Text = "Rp. " & TextBox2.Text
            Label15.Text = result.ToString("0.0") & " Liter"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        Label13.Text = ""
        Label14.Text = ""
        Label15.Text = ""
    End Sub


End Class
