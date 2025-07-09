public class Card
    {
        public int Value { get; set; } 
        public string Suit { get; set; } 

        private List<Card> playerHand = new List<Card>();
        private List<Card> dealerHand = new List<Card>();

        private Card DrawCard()
        {
            int value = rand.Next(1, 11);
            string[] suits = { "spades", "hearts", "diamonds", "clubs" };
            string suit = suits[rand.Next(suits.Length)];
            return new Card { Value = value, Suit = suit };
        }

        private int GetScore(List<Card> hand)
        {
            int total = 0;
            foreach (var card in hand)
                total += card.Value;
            return total;
        }

        private void UpdateCardImages()
        {
            for (int i = 0; i < playerCardBoxes.Length; i++)
            {
                if (i < playerHand.Count)
                {
                    var card = playerHand[i];
                string resourceName = $"{card.Value}_of_{card.Suit}.png";
                playerCardBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                    playerCardBoxes[i].Visible = true;
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
                    var card = dealerHand[i];
                    string resourceName = $"{card.Value}_of_{card.Suit}";
                    dealerCardBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(resourceName);
                    dealerCardBoxes[i].Visible = true;
                }
                else
                {
                    dealerCardBoxes[i].Image = null;
                    dealerCardBoxes[i].Visible = false;
                }
            }
        }
    }