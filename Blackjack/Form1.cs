using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
       
        private List<int> playerHand = new List<int>();
        private List<int> dealerHand = new List<int>();
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            RestartGame();
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

            UpdateScores();
        }

        private int DrawCard()
        {
            return rand.Next(1, 11); // Card values from 1 to 10
        }

        private int GetScore(List<int> hand)
        {
            int total = 0;
            foreach (int card in hand)
                total += card;
            return total;
        }

        private void UpdateScores()
        {
            lblPlayerScore.Text = "Player: " + GetScore(playerHand);
            lblDealerScore.Text = "Dealer: " + GetScore(dealerHand);
        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            playerHand.Add(DrawCard());
            UpdateScores();

            if (GetScore(playerHand) > 21)
                lblResult.Text = "You busted!";
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (GetScore(dealerHand) < 17)
                dealerHand.Add(DrawCard());

            UpdateScores();

            int playerScore = GetScore(playerHand);
            int dealerScore = GetScore(dealerHand);

            if (dealerScore > 21 || playerScore > dealerScore)
                lblResult.Text = "You win!";
            else if (dealerScore == playerScore)
                lblResult.Text = "It's a tie!";
            else
                lblResult.Text = "Dealer wins!";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
   }

