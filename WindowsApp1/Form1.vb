Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.HORSE_RACE__3_
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
End Class
