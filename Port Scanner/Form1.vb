'Daft punk icon from http://www.iconarchive.com/show/daft-punk-icons-by-svengraph/Daft-Punk-Guyman-On-icon.html

Imports System.Net.Sockets
Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = TextBox4.Text Then Timer1.Stop()
        Try
            TextBox1.Text = TextBox1.Text + 1
            Dim range As TcpClient = New TcpClient("127.0.0.1", TextBox1.Text)
            If range.Connected = True Then
                TextBox2.Text = TextBox2.Text + 1
                ListBox1.Items.Add(TextBox1.Text & " is open")
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            End If
        Catch ex As Exception
            TextBox3.Text = TextBox3.Text + 1
            ListBox2.Items.Add(TextBox1.Text & " is closed")
            ListBox2.SelectedIndex = ListBox2.SelectedIndex + 1
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
