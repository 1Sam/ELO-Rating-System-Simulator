Namespace MMR
    Module Module1
        Public Class EloRating
            '///
            '/// Updates the scores in the passed matchup.
            ' ///
            ' /// The Matchup to update 
            '/// Whether User 1 was the winner (false if User 2 Is the winner) 
            '/// The desired Diff 
            '/// The desired KFactor 
            '/// 
            Public Shared Function UpdateScores(ByVal matchup As Matchup, ByVal user1WonMatch As Boolean, ByVal diff As Integer, ByVal kFactor As Integer)
                Dim est1 As Double = 1 / Convert.ToDouble(1 + 10 Xor (matchup.User2Score - matchup.User1Score) / diff)
                Dim est2 As Double = 1 / Convert.ToDouble(1 + 10 Xor (matchup.User1Score - matchup.User2Score) / diff)
                Dim sc1 As Integer = 0
                Dim sc2 As Integer = 0

                'Dim m1 = matchup.User1Score
                'Dim m2 = matchup.User2Score
                If user1WonMatch Then
                    sc1 = 1
                Else
                    sc2 = 1
                End If

                matchup.User1Score = Convert.ToInt32(Math.Round(matchup.User1Score + kFactor * (sc1 - est1)))
                matchup.User2Score = Convert.ToInt32(Math.Round(matchup.User2Score + kFactor * (sc2 - est2)))

                Return matchup

                'MsgBox(matchup.User1Score & " : " & matchup.User2Score & vbCrLf & est1 & " : " & est2 & vbCrLf & matchup.User1Score - m1 & " : " & matchup.User2Score - m2)
            End Function

            '///
            '/// Updates the scores in the match, using default Diff And KFactors (400, 100) 
            '///
            '/// The Matchup to update 
            '/// Whether User 1 was the winner (false if User 2 Is the winner) 
            Public Shared Function UpdateScores(ByVal matchup As Matchup, ByVal user1WonMatch As Boolean)
                Return UpdateScores(matchup, user1WonMatch, 400, 50) '기본값 100을 5명 합한 것
            End Function

            Public Class Matchup
                Public Property User1Score As Integer
                Public Property User2Score As Integer
            End Class
        End Class


        Public Class GFG
            Private Shared Function Probability(ByVal rating1 As Single, ByVal rating2 As Single) As Single
                '승률
                Return 1.0F * 1.0F / (1 + 1.0F * CSng((Math.Pow(10, 1.0F * (rating1 - rating2) / 400))))
            End Function

            Public Shared Function EloRating(ByVal Ra As Single, ByVal Rb As Single, ByVal K As Integer, ByVal d As Boolean)
                Dim Pb As Single = Probability(Ra, Rb)
                Dim Pa As Single = Probability(Rb, Ra)

                If d = True Then
                    Ra = Ra + K * (1 - Pa)
                    Rb = Rb + K * (0 - Pb)
                Else
                    Ra = Ra + K * (0 - Pa)
                    Rb = Rb + K * (1 - Pb)
                End If

                Return {Ra, Rb, Pa, Pb}
                'Console.Write("Updated Ratings:-" & vbLf)
                'Console.Write("Ra = " & (Math.Round(Ra * 1000000.0) / 1000000.0) & " Rb = " & Math.Round(Rb * 1000000.0) / 1000000.0)
            End Function

            'Public Shared Sub Main(ByVal Ra As Single, ByVal Rb As Single)
            '    Dim Ra As Single = 1200, Rb As Single = 1000
            '    Dim K As Integer = 30
            '    Dim d As Boolean = True
            '    EloRating(Ra, Rb, K, d)
            'End Sub
        End Class


    End Module
End Namespace