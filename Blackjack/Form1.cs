using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private List<Card> playerHand = new List<Card>();
        private List<Card> dealerHand = new List<Card>();
        private Random rand = new Random();

        private PictureBox[] playerCardBoxes;
        private PictureBox[] dealerCardBoxes;

        private bool dealerFirstCardHidden = true;

        public Form1()
        {
            InitializeComponent();
            InitializeCardPictureBoxes();
            RestartGame();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void RestartGame()
        {
            playerHand.Clear();
            dealerHand.Clear();
            lblResult.Text = "";

            playerHand.Add(DrawCard());
            playerHand.Add(DrawCard());

            dealerHand.Add(DrawCard());
            dealerHand.Add(DrawCard());

            dealerFirstCardHidden = true; // Hide the dealer's first card

            UpdateScores();
            UpdateCardImages();
        }

        private Card DrawCard()
        {
            int value = rand.Next(1, 11); // 1 to 10
            string[] suits = { "spades", "hearts", "diamonds", "clubs" };
            string suit = suits[rand.Next(suits.Length)];
            return new Card { Value = value, Suit = suit };
        }

        private int GetScore(List<Card> hand)
        {
            int total = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                if (card.Value == 1) 
                {
                    total += 11;
                    aceCount++;
                }
                else
                {
                    total += card.Value;
                }
            }

            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        private void UpdateScores()
        {
            lblPlayerScore.Text = "Player: " + GetScore(playerHand);

            if (dealerFirstCardHidden)
            {
                // Only show the value of the visible dealer card (the second card)
                var visibleCard = dealerHand.Count > 1 ? new List<Card> { dealerHand[1] } : new List<Card>();
                lblDealerScore.Text = "Dealer: " + GetScore(visibleCard);
            }
            else
            {
                // Show the full dealer score
                lblDealerScore.Text = "Dealer: " + GetScore(dealerHand);
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerHand.Add(DrawCard());
            UpdateScores();
            UpdateCardImages();

            int playerScore = GetScore(playerHand);

            if (playerScore == 21)
            {
                lblResult.Text = "Blackjack! You win.";
                btnHit.Enabled = false;
                btnStand.Enabled = false;
            }
            else if (playerScore > 21)
            {
                lblResult.Text = "You busted!";
                btnHit.Enabled = false;
                btnStand.Enabled = false;
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            dealerFirstCardHidden = false; // Reveal the dealer's first card

            while (GetScore(dealerHand) < 17)
            {
                dealerHand.Add(DrawCard());
            }

            UpdateScores();
            UpdateCardImages();

            int playerScore = GetScore(playerHand);
            int dealerScore = GetScore(dealerHand);

            if (playerScore > 21)
            {
                lblResult.Text = "You busted!";
            }
            else if (dealerScore > 21)
            {
                lblResult.Text = "Dealer busted! You win!";
            }
            else if (playerScore > dealerScore)
            {
                lblResult.Text = "You win!";
            }
            else if (playerScore == dealerScore)
            {
                lblResult.Text = "It's a tie!";
            }
            else
            {
                lblResult.Text = "Dealer wins!";
            }

            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
            btnHit.Enabled = true;
            btnStand.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblResult_Click(object sender, EventArgs e) { }
        private void lblDealerScore_Click(object sender, EventArgs e) { }

        private void InitializeCardPictureBoxes()
        {
            playerCardBoxes = new PictureBox[] { playerCardBox1, playerCardBox2, playerCardBox3, playerCardBox4, playerCardBox5 };
            dealerCardBoxes = new PictureBox[] { dealerCardBox1, dealerCardBox2, dealerCardBox3, dealerCardBox4, dealerCardBox5 };
        }

        private void UpdateCardImages()
        {
            for (int i = 0; i < playerCardBoxes.Length; i++)
            {
                if (i < playerHand.Count)
                {
                    var card = playerHand[i];
                    string valueName = card.Value == 1 ? "ace" : card.Value.ToString();
                    string resourceName = $"{valueName}_of_{card.Suit}";
                    var img = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                    // if (img == null)
                    //     MessageBox.Show($"Missing resource: {resourceName}");
                    playerCardBoxes[i].Image = img;
                    playerCardBoxes[i].Visible = img != null;
                }
                else
                {
                    playerCardBoxes[i].Image = null;
                    playerCardBoxes[i].Visible = false;
                }
            }

            for (int i = 0; i < dealerCardBoxes.Length; i++)
            {
                if (i < dealerHand.Count)
                {
                    if (i == 0 && dealerFirstCardHidden)
                    {
                        // Show back of card for the first dealer card
                        dealerCardBoxes[i].Image = Properties.Resources.Copilot_20250707_100128;
                        dealerCardBoxes[i].Visible = true;
                    }
                    else
                    {
                        var card = dealerHand[i];
                        string valueName = card.Value == 1 ? "ace" : card.Value.ToString();
                        string resourceName = $"{valueName}_of_{card.Suit}";
                        var img = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                        dealerCardBoxes[i].Image = img;
                        dealerCardBoxes[i].Visible = img != null;
                    }
                }
                else
                {
                    dealerCardBoxes[i].Image = null;
                    dealerCardBoxes[i].Visible = false;
                }
            }
        }
    }

    public class Card
    {
        public int Value { get; set; }
        public string Suit { get; set; }
    }
}