Imports System.Drawing

Public Class Form1

    Dim draw As Boolean
    Dim drawcolor As Color = Color.Black
    Dim drawsize As Integer = 6
    Dim bmp As Bitmap


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set initial brush size
        cb_size.SelectedIndex = 2

        'populate  picturebox image property
        bmp = New Bitmap(PB_draw.Width, PB_draw.Height)
        PB_draw.Image = bmp

    End Sub

    Private Sub paintbrush(x As Integer, y As Integer)
        Using g As Graphics = Graphics.FromImage(PB_draw.Image)
            g.FillRectangle(New SolidBrush(drawcolor), New Rectangle(x, y, drawsize, drawsize))

        End Using
        PB_draw.Refresh()

    End Sub

    Private Sub PB_draw_Click(sender As Object, e As EventArgs) Handles PB_draw.Click

    End Sub

    Private Sub PB_draw_MouseDown(sender As Object, e As MouseEventArgs) Handles PB_draw.MouseDown
        draw = True
        'first pixel
        paintbrush(e.X, e.Y)
    End Sub

    Private Sub PB_draw_MouseMove(sender As Object, e As MouseEventArgs) Handles PB_draw.MouseMove
        If draw = True Then
            paintbrush(e.X, e.Y)

        End If
    End Sub

    Private Sub PB_draw_MouseUp(sender As Object, e As MouseEventArgs) Handles PB_draw.MouseUp
        draw = False
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        bmp = New Bitmap(PB_draw.Width, PB_draw.Height)
        PB_draw.Image = bmp
    End Sub

    Private Sub cb_size_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_size.SelectedIndexChanged
        drawsize = cb_size.SelectedItem
    End Sub

    Private Sub btn_color_Click(sender As Object, e As EventArgs) Handles btn_color.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            drawcolor = ColorDialog1.color
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        PB_draw.DrawToBitmap(bmp, New Rectangle(0, 0, PB_draw.Width, PB_draw.Height))
        bmp.Save("test2.png", Imaging.ImageFormat.Png)

        bmp = New Bitmap(PB_draw.Width, PB_draw.Height)
    End Sub

End Class
