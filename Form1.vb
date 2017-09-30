Imports System.IO
Public Class Form1
    Dim arrCards(312) As Card
    Dim arrUnsorted(52) As Card
    Dim arrShuffle(312) As Integer
    Dim arrDeck(312) As Card
    Dim arrPic(11) As PictureBox
    Dim arrUsed(52) As Card
    Dim arrDealer(10) As Card
    Dim arrplayer(10) As Card
    Dim arrTopTen(11) As TopTen
    Dim arrTopTenString(20) As String
    Dim used As Integer
    Dim hit As Integer, flag As Integer
    Dim Player1Count As Integer, DealerCount As Integer, stand As Integer, MoveCount As Integer
    'Dim dealerscore As Integer, playerscore As Integer
    Dim Player1Wallet As Single, Bet As Single
    Dim turn As Integer, flashflag As Integer
    Dim Ticker As Integer, playerturn As Boolean, swagdaddy As Integer

    Private Sub cmdHit_Click(sender As Object, e As EventArgs) Handles cmdHit.Click
        Dim totalplayer As Integer
        '/////////////////////////////////////GIVE CARD/////////////////////////////////////'
        Player1Count = Player1Count + 1
        used = used + 1
        hit = hit + 1
        MoveCount = MoveCount + 1
        arrPic(MoveCount).Image = Image.FromFile("D:\School\Computer Programming II\Computer Programming 2\Card Images\cardimages\" & arrDeck(used).tostring1 & ".gif")
        arrPic(MoveCount).Left = 711 + (20 * hit)
        arrPic(MoveCount).Top = 525 - (20 * hit)
        arrplayer(Player1Count) = arrDeck(used)
        totalplayer = TotalCards(arrplayer, Player1Count)
        lstPlayerCards.Items.Add(arrplayer(Player1Count).tostring1)
        'MessageBox.Show("Player Score:" & Str(totalplayer))
        'MessageBox.Show("Player Card Count:" & Str(Player1Count))
        '/////////////////////////////////////CHECK SCORE/////////////////////////////////////'
        If Player1Count = 5 And totalplayer <= 21 Then
            Player1Wallet = Player1Wallet + Bet
            lblMoney.Text = FormatCurrency(Player1Wallet)
            Call Flash(5)
            arrPic(4).Image = Image.FromFile("D: \School\Computer Programming II\Computer Programming 2\Card Images\cardimages\" & arrDealer(2).tostring1 & ".gif")
            Call DisableThings()
        ElseIf totalplayer > 21 Then
            arrPic(4).Image = Image.FromFile("D: \School\Computer Programming II\Computer Programming 2\Card Images\cardimages\" & arrDealer(2).tostring1 & ".gif")
            'BUST
            Call Flash(4)
            Player1Wallet = Player1Wallet - Bet
            lblMoney.Text = FormatCurrency(Player1Wallet)
            Call TopTenCheck(Player1Wallet)
            Call DisableThings()
        End If
    End Sub

    Private Sub cmdStand_Click(sender As Object, e As EventArgs) Handles cmdStand.Click
        Dim totaldealer As Integer, totalplayer As Integer
        '/////////////////////////////////////REVEAL/////////////////////////////////////'
        arrPic(4).Image = Image.FromFile("D: \School\Computer Programming II\Computer Programming 2\Card Images\cardimages\" & arrDealer(2).tostring1 & ".gif")
        totaldealer = TotalCards(arrDealer, DealerCount)
        'MessageBox.Show("Dealer Score:" & Str(totaldealer))
        'MessageBox.Show("Dealer Card Count:" & Str(DealerCount))
        totalplayer = TotalCards(arrplayer, Player1Count)
        'MessageBox.Show("Player Score:" & Str(totalplayer))
        'MessageBox.Show("Player Card Count:" & Str(Player1Count))
        '/////////////////////////////////////DEALER DRAW TILL 16/////////////////////////////////////'
        stand = 1
        Do While totaldealer < 16
            MessageBox.Show("Hi")
            used = used + 1
            DealerCount = DealerCount + 1
            stand = stand + 1
            MoveCount = MoveCount + 1
            arrPic(MoveCount).Image = Image.FromFile("D: \School\Computer Programming II\Computer Programming 2\Card Images\cardimages\" & arrDeck(used).tostring1 & ".gif")
            arrPic(MoveCount).Left = 642 + (79 * stand)
            arrPic(MoveCount).Top = 164
            arrDealer(DealerCount) = arrDeck(used)
            totaldealer = TotalCards(arrDealer, DealerCount)
            lstDealerCards.Items.Add(arrDealer(DealerCount).tostring1)
        Loop
        '/////////////////////////////////////CHECK WIN/////////////////////////////////////'
        If totaldealer > totalplayer And totaldealer <= 21 Then
            'LOSE
            Call Flash(2)
            Player1Wallet = Player1Wallet - Bet
            lblMoney.Text = FormatCurrency(Player1Wallet)
            Call TopTenCheck(Player1Wallet)
            Call DisableThings()
        ElseIf totalplayer > totaldealer And totalplayer <= 21 Then
            'WIN
            Call Flash(1)
            Player1Wallet = Player1Wallet + Bet
            lblMoney.Text = FormatCurrency(Player1Wallet)
            Call TopTenCheck(Player1Wallet)
            Call DisableThings()
        ElseIf totaldealer > 21 And totaldealer > totalplayer Then
            'WIN
            Call Flash(1)
            Player1Wallet = Player1Wallet + Bet
            lblMoney.Text = FormatCurrency(Player1Wallet)
            Call TopTenCheck(Player1Wallet)
            Call DisableThings()
        ElseIf totaldealer = totalplayer And totalplayer <= 21 And totaldealer <= 21 Then
            'PUSH
            Call Flash(3)
            Call DisableThings()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer, x As Integer
        arrPic(1) = picCard0
        arrPic(2) = picCard1
        arrPic(3) = picCard2
        arrPic(4) = picCard3
        arrPic(5) = picCard4
        arrPic(6) = picCard5
        arrPic(7) = picCard6
        arrPic(8) = picCard7
        arrPic(9) = picCard8
        arrPic(10) = picCard9
        arrPic(11) = picCard10
        For i = 1 To 11
            arrPic(i).Left = 135
            arrPic(i).Top = 8
            arrPic(i).Image = Image.FromFile("D:\School\Computer Programming II\Computer Programming 2\Card Images\cardimages\black.gif")
        Next i
        Player1Wallet = 500
        '/////////////////////////////////////OPEN//////////////////////////////////////'
        Dim File As StreamReader
        x = 0
        File = New StreamReader("D:\School\Computer Programming II\VB.Net Projects\Black Jack\BlackJack\BlackJack\TopTen.txt")
        Do While Not File.EndOfStream
            x = x + 1
            arrTopTenString(x) = File.ReadLine
        Loop
        File.Close()
        Call TopTenMid()
        flashflag = 1
        lblflash.BackColor = Color.Transparent
        Bet = 0
    End Sub

    Private Sub optOne_CheckedChanged(sender As Object, e As EventArgs) Handles optOne.CheckedChanged
        If optOne.Checked = True Or optEleven.Checked = True Then
            cmdNewGame.Enabled = True
        Else
            cmdNewGame.Enabled = False
        End If
    End Sub

    Private Sub optEleven_CheckedChanged(sender As Object, e As EventArgs) Handles optEleven.CheckedChanged
        If optOne.Checked = True Or optEleven.Checked = True Then
            cmdNewGame.Enabled = True
        Else
            cmdNewGame.Enabled = False
        End If
    End Sub

    Private Sub lblMoney_Click(sender As Object, e As EventArgs) Handles lblMoney.Click

    End Sub

    Private Sub cmdNewGame_Click(sender As Object, e As EventArgs) Handles cmdNewGame.Click
        Dim x As Integer, i As Integer, p As Integer, k As Integer
        Dim count As Integer, rnum As Integer, mex As Integer
        '/////////////////////////////////////CHECK BET/////////////////////////////////////'
        If Bet = 0 Then
            MessageBox.Show("Please place a bet.")
        ElseIf Bet <> 0 Then
            txtBet.Enabled = False
            lbl5.Enabled = False
            lbl10.Enabled = False
            lbl25.Enabled = False
            lbl50.Enabled = False
            lbl100.Enabled = False
            lbl500.Enabled = False
            p = 0
            '/////////////////////////////////////GENERATE DECK/////////////////////////////////////'
            For i = 1 To 13
                For x = 1 To 4
                    p = p + 1
                    arrCards(p).suit = x
                    arrCards(p).number = i
                Next x
            Next i
            For i = 1 To 312
                arrShuffle(i) = 0
            Next i
            '////////////////////////////////////SHUFFLE/////////////////////////////////////'
            ListBox1.Items.Clear()
            Call Shuffle(arrCards, arrDeck)
            '/////////////////////////////////////DEAL/////////////////////////////////////'
            hit = 0
            used = 0
            MoveCount = 4
            For i = 1 To 11
                arrPic(i).Left = 135
                arrPic(i).Top = 8
                arrPic(i).Image = Image.FromFile("D:\School\Computer Programming II\Computer Programming 2\Card Images\cardimages\black.gif")
            Next i

            For i = 1 To 3
                arrPic(i).Image = Image.FromFile("D:\School\Computer Programming II\Computer Programming 2\Card Images\cardimages\" & arrDeck(used + i).tostring1 & ".gif")
            Next
            Player1Count = 1
            DealerCount = 1

            arrDealer(DealerCount) = arrDeck(2)
            DealerCount = DealerCount + 1
            arrDealer(DealerCount) = arrDeck(4)
            flag = used + 2

            arrplayer(Player1Count) = arrDeck(1)
            Player1Count = Player1Count + 1
            arrplayer(Player1Count) = arrDeck(3)

            arrPic(1).Left = 691
            arrPic(1).Top = 545

            arrPic(2).Left = 642
            arrPic(2).Top = 164

            arrPic(3).Left = 711
            arrPic(3).Top = 525

            arrPic(4).Left = 721
            arrPic(4).Top = 164
            used = 4
            For i = 1 To Player1Count
                lstPlayerCards.Items.Add(arrplayer(i).tostring1)
            Next i
            For i = 1 To DealerCount
                lstDealerCards.Items.Add(arrDealer(i).tostring1)
            Next i
            cmdStand.Enabled = True
            cmdHit.Enabled = True
            'dealerscore = 0
            'playerscore = 0
            Player1Wallet = 500
            lblMoney.Text = FormatCurrency(Player1Wallet)
            lblflash.Visible = False
            cmdDeal.Enabled = True
        End If
    End Sub
    Function TotalCards(arrCount() As Card, num As Integer) As Integer
        Dim i As Integer, total As Integer, point As Integer
        '/////////////////////////////////////TOTAL UP SCORE/////////////////////////////////////'
        If optEleven.Checked = True Then
            For i = 1 To num
                Select Case arrCount(i).number
                    Case 1 : point = 11
                    Case 10 : point = 10
                    Case 11 : point = 10
                    Case 12 : point = 10
                    Case 13 : point = 10
                    Case Else
                        point = arrCount(i).number
                End Select
                total = total + point
            Next i
            TotalCards = total
        ElseIf optOne.Checked = True Then
            For i = 1 To num
                Select Case arrCount(i).number
                    Case 1 : point = 1
                    Case 10 : point = 10
                    Case 11 : point = 10
                    Case 12 : point = 10
                    Case 13 : point = 10
                    Case Else
                        point = arrCount(i).number
                End Select
                total = total + point
            Next i
            TotalCards = total
        End If
    End Function

    Private Sub cmdDeal_Click(sender As Object, e As EventArgs) Handles cmdDeal.Click
        If Bet = 0 Then
            MessageBox.Show("Please place a bet.")
        ElseIf Bet <> 0 Then
            lbl5.Enabled = False
            lbl10.Enabled = False
            lbl25.Enabled = False
            lbl50.Enabled = False
            lbl100.Enabled = False
            lbl500.Enabled = False
            hit = 0
            stand = 0
            MoveCount = 4
            For i = 1 To 11
                arrPic(i).Left = 135
                arrPic(i).Top = 8
                arrPic(i).Image = Image.FromFile("D:\School\Computer Programming II\Computer Programming 2\Card Images\cardimages\black.gif")
            Next i
            For i = 1 To 3
                arrPic(i).Image = Image.FromFile("D:\School\Computer Programming II\Computer Programming 2\Card Images\cardimages\" & arrDeck(used + i).tostring1 & ".gif")
            Next
            If used >= 307 Then
                Call Shuffle(arrCards, arrDeck)
                used = 0
            End If
            Player1Count = 0
            DealerCount = 0
            DealerCount = DealerCount + 1
            arrDealer(DealerCount) = arrDeck(used + 2)
            DealerCount = DealerCount + 1
            arrDealer(DealerCount) = arrDeck(used + 4)
            flag = used + 2
            Player1Count = Player1Count + 1
            arrplayer(Player1Count) = arrDeck(used + 1)
            Player1Count = Player1Count + 1
            arrplayer(Player1Count) = arrDeck(used + 3)
            used = used + 4


            arrPic(1).Left = 691
            arrPic(1).Top = 545

            arrPic(2).Left = 642
            arrPic(2).Top = 164

            arrPic(3).Left = 711
            arrPic(3).Top = 525

            arrPic(4).Left = 721
            arrPic(4).Top = 164
            lstPlayerCards.Items.Clear()
            lstDealerCards.Items.Clear()
            For i = 1 To Player1Count
                lstPlayerCards.Items.Add(arrplayer(i).tostring1)
            Next i
            For i = 1 To DealerCount
                lstDealerCards.Items.Add(arrDealer(i).tostring1)
            Next i
            cmdDeal.Enabled = False
            cmdStand.Enabled = True
            cmdHit.Enabled = True
            lblflash.Visible = False
        End If
    End Sub

    Structure Card
        Dim suit As Integer
        Dim number As Integer
        Function tostring1() As String
            Dim str As String = String.Empty
            Select Case number
                Case 1 : str = str + "a"
                Case 10 : str = str + "t"
                Case 11 : str = str + "j"
                Case 12 : str = str + "q"
                Case 13 : str = str + "k"
                Case Else
                    str = str + CStr(number)
            End Select
            Select Case suit
                Case 1 : str = str + "c"
                Case 2 : str = str + "s"
                Case 3 : str = str + "h"
                Case 4 : str = str + "d"
            End Select
            tostring1 = str
        End Function
    End Structure

    Private Sub TimerMove1_Tick(sender As Object, e As EventArgs) Handles TimerMove1.Tick

    End Sub


    Private Sub tmrFlash_Tick(sender As Object, e As EventArgs) Handles tmrFlash.Tick
        If flashflag < 0 Then
            lblflash.ForeColor = Color.DarkRed
        ElseIf flashflag > 0 Then
            lblflash.ForeColor = Color.Yellow
        End If
        flashflag = flashflag * -1
    End Sub

    Private Sub lbl5_Click(sender As Object, e As EventArgs) Handles lbl5.Click
        Bet = Bet + 5
        txtBet.Text = FormatCurrency(Bet)
    End Sub
    Private Sub lbl10_Click(sender As Object, e As EventArgs) Handles lbl10.Click
        Bet = Bet + 10
        txtBet.Text = FormatCurrency(Bet)
    End Sub
    Private Sub lbl25_Click(sender As Object, e As EventArgs) Handles lbl25.Click
        Bet = Bet + 25
        txtBet.Text = FormatCurrency(Bet)
    End Sub
    Private Sub lbl50_Click(sender As Object, e As EventArgs) Handles lbl50.Click
        Bet = Bet + 50
        txtBet.Text = FormatCurrency(Bet)
    End Sub
    Private Sub lbl100_Click(sender As Object, e As EventArgs) Handles lbl100.Click
        Bet = Bet + 100
        txtBet.Text = FormatCurrency(Bet)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lbl500_Click(sender As Object, e As EventArgs) Handles lbl500.Click
        Bet = Bet + 500
        txtBet.Text = FormatCurrency(Bet)
    End Sub

    Structure TopTen
        Dim Name As String
        Dim Score As Integer
        Function tostring2(num As Integer) As String
            Dim StringScore As String = String.Empty
            Dim space As String
            space = " "
            StringScore = Str(num) & "." & space & Name & space & space & Str(FormatCurrency(Score))
            tostring2 = StringScore
        End Function
    End Structure

    Sub Shuffle(arrCards() As Card, arrdeck() As Card)
        Dim x As Integer, i As Integer, p As Integer, k As Integer
        Dim count As Integer, rnum As Integer, mex As Integer
        For i = 1 To 312
            arrShuffle(i) = 0
        Next i
        count = 1
        mex = 0
        Randomize()
        rnum = Int(Rnd() * 52) + 1
        arrdeck(1).suit = arrCards(rnum).suit
        arrdeck(1).number = arrCards(rnum).number
        arrShuffle(1) = rnum
        Do While count <= 311
            Randomize()
            rnum = Int(Rnd() * 52) + 1
            For i = 1 To 52
                If rnum = arrShuffle(i) Then
                    mex = mex + 1
                End If
            Next i
            If mex <= 4 Then
                count = count + 1
                arrShuffle(count) = rnum
                arrdeck(count).suit = arrCards(rnum).suit
                arrdeck(count).number = arrCards(rnum).number
                ListBox1.Items.Add(arrdeck(count).tostring1)
            End If
            mex = 0
        Loop
    End Sub
    Sub TopTenMid()
        Dim i As Integer, pos As Integer, x As Integer
        x = 1
        For i = 1 To 20
            If i Mod 2 <> 0 Then
                arrTopTen(x).Score = Val(arrTopTenString(i + 1))
                arrTopTen(x).Name = arrTopTenString(i)
                x = x + 1
            End If
        Next i
        For i = 1 To 10
            lstTopTen.Items.Add(arrTopTen(i).tostring2(i))
        Next
    End Sub
    Sub TopTenCheck(Wallet As Integer)
        Dim pos As Integer, x As Integer, NewName As String, arrtemp(10) As TopTen, temp As TopTen
        'MessageBox.Show(Str(Wallet))
        For i = 1 To 10
            If Wallet > arrTopTen(i).Score Then
                NewName = InputBox("Congratulations, new high score!", "New High Score", "Name...")
                arrTopTen(11).Name = NewName
                arrTopTen(11).Score = Wallet
                pos = i
                Exit For
            End If
        Next i
        Dim front As Integer, back As Integer
        For front = 1 To 10
            For back = front + 1 To 11
                If arrTopTen(front).Score < arrTopTen(back).Score Then
                    temp = arrTopTen(front)
                    arrTopTen(front) = arrTopTen(back)
                    arrTopTen(back) = temp
                End If
            Next back
        Next front
        lstTopTen.Items.Clear()
        For i = 1 To 10
            lstTopTen.Items.Add(arrTopTen(i).tostring2(i))
        Next i
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim x As Integer
        x = 1
        FileOpen(1, "D:\School\Computer Programming II\VB.Net Projects\Black Jack\BlackJack\BlackJack\TopTen.txt", OpenMode.Output)
        For i = 1 To 10

            PrintLine(1, arrTopTen(x).Name)
            PrintLine(1, Str(arrTopTen(x).Score))
            x = x + 1

        Next i
        FileClose(1)
    End Sub
    Sub Flash(flag As Integer)
        tmrFlash.Enabled = True
        lblflash.Visible = True
        If flag = 1 Then
            lblflash.Text = "WIN!"
        ElseIf flag = 2 Then
            lblflash.Text = "LOSE!"
        ElseIf flag = 3 Then
            lblflash.Text = "PUSH!"
        ElseIf flag = 4 Then
            lblflash.Text = "PLAYER BUST!"
        ElseIf flag = 5 Then
            lblflash.Text = "5 CARD CHARLIE!"
        End If
    End Sub
    Function NewLocation(InitialLocation As Point, targetx As Single, targety As Integer, alpha As Single) As Point
        Dim newx As Single, newy As Single
        If InitialLocation.X = targetx And InitialLocation.Y = targety Then
            NewLocation.X = targetx
            NewLocation.Y = targety
        Else
            newx = (((InitialLocation.X - targetx) / 2) * alpha)
            newy = (((InitialLocation.Y - targety) / 2) * alpha)
            NewLocation.X = InitialLocation.X - newx
            NewLocation.Y = InitialLocation.Y - newy
        End If
    End Function
    Sub DisableThings()
        cmdDeal.Enabled = True
        txtBet.Enabled = True
        cmdStand.Enabled = False
        cmdHit.Enabled = False
        lbl5.Enabled = True
        lbl10.Enabled = True
        lbl25.Enabled = True
        lbl50.Enabled = True
        lbl100.Enabled = True
        lbl500.Enabled = True
        Bet = 0
        txtBet.Text = FormatCurrency(Bet)
        If Player1Wallet <= 0 Then
            MessageBox.Show("All out of funds, GAME OVER!")
            cmdDeal.Enabled = False
            Player1Wallet = 500
            lblMoney.Text = FormatCurrency(Player1Wallet)
        End If
    End Sub
End Class