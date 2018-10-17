// Thad Swint Simple Pig Latin Converter
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._5_ThadSwint
{
    public partial class Form1 : Form
    {
        private string aY = "ay";
        private string textTaken;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            GetPigLatin();

        }

        private void GetPigLatin()
        {
            // Prevent anything less than 2 chars -- alert if true
            if (TBox.Text.Length < 2)
            {
                MessageBox.Show("you must have at least 2 characters");
                return;
            }
            // Prevent non-alphabetical input
            if (!(System.Text.RegularExpressions.Regex.IsMatch(TBox.Text, "^[a-zA-Z ]*$")))
            {
                MessageBox.Show("Only alphabetical input please & no returns");
                return;
            }

            // Declare local variales 
            textTaken = TBox.Text;
            TranslatedLabel.MaximumSize = new Size(278, 0);
            TranslatedLabel.AutoSize = true;
            StringBuilder buffer = new StringBuilder();
            string[] words = textTaken.Split(' ');

            // Iterate through each word 
                foreach (var word in words)
                {
                try
                {
                    // Grab the first letter & concat ay
                    string firstLetterWithAy = word[0].ToString() + aY;
                    // Grab the word minus the first letter
                    string wordWithoutFirstLetter = word.Remove(0, 1);
                    // Create the pig latin word
                    string latin = wordWithoutFirstLetter + firstLetterWithAy;
                    // Append the pig latin word to string builder var with a space
                    buffer.Append(latin + " ");
                }
                // Caused by unwanted spaces 
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Too many spaces: \nOnly one allowed\nMust not begin with a space" +
                        "\nMust not end with a space ");
                    return;
                }
                }
                /* 
                 * If we made it this far output the buffer to the label
                 * Add to the counter
                 * Have our label reflect the count 
                 */
            TranslatedLabel.Text = buffer.ToString().ToUpper();
            count++;
            CountLabel.Text = ("Successful translation = " + count.ToString());
        }
    }
}
