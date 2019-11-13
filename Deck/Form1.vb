Public Class Form1
    Dim sSuits(0 To 3) As String
    Dim sCards(0 To 12) As String
    Dim cGuess As Int16

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        'Assigns the suits
        sSuits(0) = "Spades"
        sSuits(1) = "Hearts"
        sSuits(2) = "Clubs"
        sSuits(3) = "Diamonds"

        'Assigns the cards
        sCards(0) = "Ace"
        sCards(1) = "Two"
        sCards(2) = "Three"
        sCards(3) = "Four"
        sCards(4) = "Five"
        sCards(5) = "Six"
        sCards(6) = "Seven"
        sCards(7) = "Eight"
        sCards(8) = "Nine"
        sCards(9) = "Ten"
        sCards(10) = "Jack"
        sCards(11) = "Queen"
        sCards(12) = "King"
        CardDraw()

    End Sub

    Private Sub btnHigher_Click(sender As Object, e As EventArgs) Handles btnHigher.Click
        Dim rndmSuit As Int16
        Dim rndmCard As Int16

        rndmSuit = Int((3 * Rnd()))
        rndmCard = Int((12 * Rnd()))
        lblCard.Text = (sCards(rndmCard) & " of " & sSuits(rndmSuit))


        If cGuess > rndmCard Then
            lblResult.Text = "Drink!"
        ElseIf cGuess = rndmCard Then
            lblResult.Text = "Everybody Drink!"
        ElseIf cGuess < rndmCard Then
            lblResult.Text = "You're Safe!"
        End If
        cGuess = rndmCard
    End Sub
    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        Dim rndmSuit As Int16
        Dim rndmCard As Int16

        rndmSuit = Int((3 * Rnd()))
        rndmCard = Int((12 * Rnd()))
        lblCard.Text = (sCards(rndmCard) & " of " & sSuits(rndmSuit))


        If cGuess < rndmCard Then
            lblResult.Text = "Drink!"
        ElseIf cGuess = rndmCard Then
            lblResult.Text = "Everybody Drink!"
        ElseIf cGuess > rndmCard Then
            lblResult.Text = "You're Safe!"
        End If

        cGuess = rndmCard

    End Sub

    Private Sub CardDraw()
        Dim rndmSuit As Int16
        Dim rndmCard As Int16

        rndmSuit = Int((3 * Rnd()))
        rndmCard = Int((12 * Rnd()))
        lblCard.Text = (sCards(rndmCard) & " of " & sSuits(rndmSuit))
        cGuess = rndmCard
    End Sub

    Private Sub btnDraw_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSame_Click(sender As Object, e As EventArgs) Handles btnSame.Click
        Dim rndmSuit As Int16
        Dim rndmCard As Int16

        rndmSuit = Int((3 * Rnd()))
        rndmCard = Int((12 * Rnd()))
        lblCard.Text = (sCards(rndmCard) & " of " & sSuits(rndmSuit))


        If cGuess = rndmCard Then
            lblResult.Text = "EVERYONE DOWN YOUR DRINKS!"
        ElseIf cGuess <> rndmCard Then
            lblResult.Text = "DOWN YOUR DRINK BITCH"
        End If

        cGuess = rndmCard
    End Sub

    Private Sub btnCall_Click(sender As Object, e As EventArgs) Handles btnCall.Click

        Dim rndmSuit As Int16
        Dim rndmCard As Int16
        If tbCall.Text <> "" Then
            cGuess = Convert.ToInt64(tbCall.Text) - 1
            rndmSuit = Int((3 * Rnd()))
            rndmCard = Int((12 * Rnd()))
            lblCard.Text = (sCards(rndmCard) & " of " & sSuits(rndmSuit))


            If cGuess = rndmCard Then
                lblResult.Text = "EVERYONE TAKE 3 DRINKS!"
                btnHigher.Enabled = True
                btnLower.Enabled = True
                btnSame.Enabled = True
            ElseIf cGuess + 1 = rndmCard Then
                lblResult.Text = "AH FUCK, 3 drinks and the next player MUST guess a card!"
                btnHigher.Enabled = False
                btnLower.Enabled = False
                btnSame.Enabled = False
            ElseIf cGuess - 1 = rndmCard Then
                lblResult.Text = "AH FUCK, 3 drinks and the next player MUST guess a card!"
                btnHigher.Enabled = False
                btnLower.Enabled = False
                btnSame.Enabled = False
            ElseIf cGuess <> rndmCard Then
                lblResult.Text = "TAKE 3 DRINKS!"
                btnHigher.Enabled = True
                btnLower.Enabled = True
                btnSame.Enabled = True
            End If
        Else
            MessageBox.Show("Make a call pussy!")
        End If
        cGuess = rndmCard
    End Sub
End Class
