Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Int(1 + Rnd() * 6)
        Dim str As String = "D:\Fahad Sir\VB APP\DICE_GAME\DICE_GAME\d" & n & ".png"

        PictureBox1.Image = Image.FromFile(str)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Height = 200
        PictureBox1.Width = 200
    End Sub
End Class
