Public Class Form1
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        End
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'Değişkenlerin tanımı
        Dim TCKN As Long = Long.Parse(Guna2TextBox3.Text)
        Dim Ad, Soyad As String
        Dim dogum As Integer = Guna2DateTimePicker1.Value.Year
        Ad = Guna2TextBox1.Text
        Soyad = Guna2TextBox2.Text
        'Değişken tanımı END

        'API bağlantısı ve değişkenlerin yerine koyulması
        Dim KK As ServiceReference1.KPSPublicSoapClient = New ServiceReference1.KPSPublicSoapClient()
        Dim Durum As Boolean = KK.TCKimlikNoDogrula(TCKN, Ad, Soyad, dogum)
        'Apı bağlantısı END


        'Sorgulama sonrası kullanıcıya dönen cevap
        If Durum = True Then
            MessageBox.Show("Girilen Kimlik Bilgileri Doğrulandı.", "Geçerli Durum", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        End If

        If Durum <> True Then
            MessageBox.Show("Girilen Kimlik Bilgileri Doğrulanamadı.", "Geçersiz Durum", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End If

        'Sorgulama sonrası kullanıcıya dönen cevap END



    End Sub

End Class
