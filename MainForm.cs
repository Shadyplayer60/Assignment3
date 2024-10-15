using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private List<int> deck;
        private int[] hand;

        public MainForm()
        {
            InitializeComponent();
            deck = new List<int>();
            hand = new int[5];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DealHand(); // Deal an initial hand when the form loads
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            DealHand(); // Deal a new hand when the Deal button is clicked
        }

        // Method to deal cards
        private void DealHand()
        {
            // Clear the deck and add all card indices from the ImageList
            deck.Clear();

            // Fill the deck with card indices (0 to imageCardsList.Images.Count - 1)
            for (int i = 0; i < imageCardsList.Images.Count; i++)
            {
                deck.Add(i);
            }

            // Shuffle the deck before dealing
            ShuffleDeck();

            // Loop through the hand array and deal new cards only to cards that are not kept
            for (int i = 0; i < 5; i++)
            {
                // Check if the corresponding "Keep" checkbox is unchecked before dealing a new card
                if (!GetKeepCheckbox(i).Checked)
                {
                    hand[i] = deck[0]; // Deal a new card from the deck
                    deck.RemoveAt(0); // Remove the dealt card from the deck
                    UpdateCardPictureBox(i); // Update the PictureBox with the new card
                }
            }
        }

        // Method to shuffle the deck
        private void ShuffleDeck()
        {
            Random rng = new Random();
            int n = deck.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        // Method to update PictureBox based on hand array
        private void UpdateCardPictureBox(int index)
        {
            if (hand[index] >= 0 && hand[index] < imageCardsList.Images.Count)
            {
                GetCardPictureBox(index).Image = imageCardsList.Images[hand[index]];
            }
            else
            {
                GetCardPictureBox(index).Image = null;
            }
        }

        // Helper method to get the PictureBox for the card based on the index
        private PictureBox GetCardPictureBox(int index)
        {
            switch (index)
            {
                case 0: return picCard1;
                case 1: return picCard2;
                case 2: return picCard3;
                case 3: return picCard4;
                case 4: return picCard5;
                default: return null;
            }
        }

        // Helper method to get the Keep checkbox for the card based on the index
        private CheckBox GetKeepCheckbox(int index)
        {
            switch (index)
            {
                case 0: return chkKeep1;
                case 1: return chkKeep2;
                case 2: return chkKeep3;
                case 3: return chkKeep4;
                case 4: return chkKeep5;
                default: return null;
            }
        }

        // Save the current hand to a text file
        private void btnSaveHand_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = "C:\\",
                DefaultExt = ".txt"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var card in hand)
                    {
                        writer.WriteLine(card);
                    }
                }
            }
        }

        // Load a hand from a text file
        private void btnLoadHand_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                DefaultExt = ".txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (reader.Peek() >= 0)
                        {
                            hand[i] = int.Parse(reader.ReadLine());
                            UpdateCardPictureBox(i);
                        }
                        else
                        {
                            hand[i] = -1; // No card
                            UpdateCardPictureBox(i);
                        }
                    }
                }
            }
        }

        // Toggle checkbox when clicking PictureBox
        private void picCard1_Click(object sender, EventArgs e)
        {
            chkKeep1.Checked = !chkKeep1.Checked;
        }

        private void picCard2_Click(object sender, EventArgs e)
        {
            chkKeep2.Checked = !chkKeep2.Checked;
        }

        private void picCard3_Click(object sender, EventArgs e)
        {
            chkKeep3.Checked = !chkKeep3.Checked;
        }

        private void picCard4_Click(object sender, EventArgs e)
        {
            chkKeep4.Checked = !chkKeep4.Checked;
        }

        private void picCard5_Click(object sender, EventArgs e)
        {
            chkKeep5.Checked = !chkKeep5.Checked;
        }
    }
}
