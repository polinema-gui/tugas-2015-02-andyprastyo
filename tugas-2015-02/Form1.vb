Public Class kalkulator
    Dim tambah As Integer
    Dim pembeda As Integer
    Dim kurang As Integer
    Dim hasil As Integer
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        TextBox1.Text = "0"
        tambah = 0
        kurang = 0
        hasil = 0
    End Sub

    Private Sub nol_Click(sender As Object, e As EventArgs) Handles nol.Click
        TextBox1.Text &= "0"
    End Sub

    Private Sub satu_Click(sender As Object, e As EventArgs) Handles satu.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text &= "1"
        End If
    End Sub

    Private Sub dua_Click(sender As Object, e As EventArgs) Handles dua.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text &= "2"
        End If
    End Sub

    Private Sub tiga_Click(sender As Object, e As EventArgs) Handles tiga.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text &= "3"
        End If
    End Sub

    Private Sub empat_Click(sender As Object, e As EventArgs) Handles empat.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text &= "4"
        End If
    End Sub

    Private Sub lima_Click(sender As Object, e As EventArgs) Handles lima.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text &= "5"
        End If
    End Sub

    Private Sub enam_Click(sender As Object, e As EventArgs) Handles enam.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text &= "6"
        End If
    End Sub

    Private Sub tujuh_Click(sender As Object, e As EventArgs) Handles tujuh.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text &= "7"
        End If
    End Sub

    Private Sub delapan_Click(sender As Object, e As EventArgs) Handles delapan.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text &= "8"
        End If
    End Sub

    Private Sub sembilan_Click(sender As Object, e As EventArgs) Handles sembilan.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text &= "9"
        End If
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        If kurang = 0 Then
            pembeda = 1
            If hasil = 0 Then
                If tambah = 0 Then
                    tambah = Convert.ToInt32(TextBox1.Text)
                    TextBox1.Text = "0"
                Else
                    tambah = tambah + Convert.ToInt32(TextBox1.Text)
                    TextBox1.Text = "0"
                End If
            Else
                TextBox1.Text = "0"
                tambah = hasil + Convert.ToInt32(TextBox1.Text)
                TextBox1.Text = "0"
            End If
        Else
            pembeda = 1
            tambah = kurang - Convert.ToInt32(TextBox1.Text)
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        If tambah = 0 Then
            pembeda = 0
            If hasil = 0 Then
                If kurang = 0 Then
                    kurang = Convert.ToInt32(TextBox1.Text)
                    TextBox1.Text = "0"
                Else
                    kurang = kurang - Convert.ToInt32(TextBox1.Text)
                    TextBox1.Text = "0"
                End If
            Else
                TextBox1.Text = "0"
                kurang = hasil - Convert.ToInt32(TextBox1.Text)
                TextBox1.Text = "0"
            End If
        Else
            pembeda = 0
            kurang = tambah + Convert.ToInt32(TextBox1.Text)
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Samadengan_Click(sender As Object, e As EventArgs) Handles Samadengan.Click
        If pembeda = 1 Then
            hasil = tambah + Convert.ToInt32(TextBox1.Text)
            tambah = 0
        Else
            hasil = kurang - Convert.ToInt32(TextBox1.Text)
            kurang = 0
        End If
        TextBox1.Text = hasil
    End Sub

    Private Sub backspace_Click(sender As Object, e As EventArgs) Handles backspace.Click
        Dim back As String
        back = TextBox1.Text
        back = back.Substring(0, back.Length - 1)
        TextBox1.Text = back
    End Sub
End Class
