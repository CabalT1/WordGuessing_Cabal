using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace WordGuessing
{
    public partial class Form1 : Form
    {
        // 🔹 Declare variables as class fields
        private string wordToGuess = "computer";   // The word to guess
        private StringBuilder maskedWord;          // To hold hidden word
        private ArrayList wrongGuesses;            // Store wrong guesses

        public Form1()
        {
            InitializeComponent();

            wrongGuesses = new ArrayList();
            maskedWord = new StringBuilder();


            maskedWord.Append(wordToGuess[0]); // first letter
            for (int i = 1; i < wordToGuess.Length - 1; i++)
                maskedWord.Append("?");
            maskedWord.Append(wordToGuess[wordToGuess.Length - 1]); // last letter

            lblWord.Text = maskedWord.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(userGuess))
            {
                MessageBox.Show("Please enter a guess.");
                return;
            }

            if (userGuess == wordToGuess)
            {
                lblWord.Text = wordToGuess; // reveal answer
                MessageBox.Show("Correct! The word is " + wordToGuess);
                txtGuess.Clear();
                return;
            }
            else
            {
                if (!wrongGuesses.Contains(userGuess))
                {
                    wrongGuesses.Add(userGuess);
                    lstWrongGuesses.Items.Add(userGuess); // display in listbox
                }
                else
                {
                    MessageBox.Show("You already tried that word!");
                }
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void lblWord_Click(object sender, EventArgs e)
        {

        }
    }
}