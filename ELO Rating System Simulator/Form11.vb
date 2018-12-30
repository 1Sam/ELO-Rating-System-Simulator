Public Class Form11
    Dim games As Integer = 0
    Dim new_mmr() As Single = {1500.0, 1500.0}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Result As Array

        Result = MMR.GFG.EloRating(BlueOrigin.Text, RedOrigin.Text, My.Settings.Kfactor, True)

        BlueResult.Text = Result(0)
        RedResult.Text = Result(1)
        TextBox2.Text = BlueResult.Text - BlueOrigin.Text
        TextBox3.Text = RedResult.Text - RedOrigin.Text

        If CheckBox1.Checked = True Then
            BlueOrigin.Text = BlueResult.Text

            games += 1

            Form12.Chart1.Series("Series1").Points.AddXY(games, Math.Round(CDbl(Val(BlueResult.Text)), 0))
        End If

    End Sub

    Private Sub MdStickyButton1_Click(sender As Object, e As EventArgs) Handles MdStickyButton1.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Result As Array

        Result = MMR.GFG.EloRating(BlueOrigin.Text, RedOrigin.Text, My.Settings.Kfactor, False)

        BlueResult.Text = Result(0)
        RedResult.Text = Result(1)
        TextBox2.Text = BlueResult.Text - BlueOrigin.Text
        TextBox3.Text = RedResult.Text - RedOrigin.Text

        If CheckBox1.Checked = True Then
            RedOrigin.Text = RedResult.Text

            games += 1

            Form12.Chart1.Series("Series1").Points.AddXY(games, Math.Round(CDbl(Val(BlueResult.Text)), 0))
        End If


    End Sub

    Private Sub MdButton1_Click(sender As Object, e As EventArgs) Handles MdButton1.Click
        Form12.Show()
    End Sub

    Private Sub MdButton2_Click(sender As Object, e As EventArgs) Handles MdButton2.Click
        BlueOrigin.Text = BlueResult.Text

        games += 1

        Form12.Chart1.Series("Series1").Points.AddXY(games, Math.Round(CDbl(Val(BlueResult.Text)), 0))
        'Form12.Chart1.Series("Series1").Points.Add.Label = games   'su_info.Tier
    End Sub

    Private Sub MdButton3_Click(sender As Object, e As EventArgs) Handles MdButton3.Click
        RedOrigin.Text = RedResult.Text
    End Sub

    Private Sub RedOrigin_TextChanged(sender As Object, e As EventArgs) Handles RedOrigin.TextChanged, BlueOrigin.TextChanged
        Try
            new_mmr = MMR.GFG.EloRating(BlueOrigin.Text, RedOrigin.Text, My.Settings.Kfactor, True)
            TextBox4.Text = new_mmr(2) * 100
            TextBox5.Text = new_mmr(3) * 100

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        My.Settings.Kfactor = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class