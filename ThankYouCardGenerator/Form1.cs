using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ThankYouCardGenerator
{
    public partial class Form1 : Form
    {
        string giftGiven;
        string giftGiver;
        string giftOccassion;
        string cardSender;

        public Form1()
        {
            InitializeComponent();


        }

        #region TextBoxToString
        private void giftTextBox_TextChanged(object sender, EventArgs e)
        //changes the input from this textbox into a useable string from the variables previously created.
        {
            giftGiven = giftTextBox.Text.ToString();

        }

        private void giverTextBox_TextChanged(object sender, EventArgs e)
        //changes the input from this textbox into a useable string from the variables previously created.
        {
            giftGiver = giverTextBox.Text.ToString();

        }

        private void occassionTextBox_TextChanged(object sender, EventArgs e)
        //changes the input from this textbox into a useable string from the variables previously created.
        {
            giftOccassion = occassionTextBox.Text.ToString();

        }

        private void senderTextBox_TextChanged(object sender, EventArgs e)
        //changes the input from this textbox into a useable string from the variables previously created.
        {
            cardSender = senderTextBox.Text.ToString();

        }
        #endregion
        #region ActionIfKeyPressed
        /*at the senderTextBox, this checks to see if either the Tab Key or the Enter keys are pressed to trigger the creation of the thank you card.  
         * It will clear out all the other textboxes to allow for another run of the program upon the key event. 
        */
        private void senderTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                generatedNoteTextBox.Text = $"Dear {giftGiver}, \n \nThank you so much for the {giftGiven}!  I cannot wait to put it to good use!  \nI am so glad that you could attend my {giftOccassion}! \nThanks again! \nSincerely, \n \n{cardSender}";
                

            }
            else
            {
                return;
            }


        }


        #endregion
        #region ButtonClicks
        //added buttons to make it more intuitive and user friendly.
        private void generateButton_Click(object sender, EventArgs e)
            //does the same thing as the enter button.
        {
            generatedNoteTextBox.Text = $"Dear {giftGiver}, \n \nThank you so much for the {giftGiven}!  I cannot wait to put it to good use!  \nI am so glad that you could attend my {giftOccassion}! \nThanks again! \nSincerely, \n \n{cardSender}";
            
        }


        #endregion

        private void saveButton_Click(object sender, EventArgs e)
            //added the ability to save as a text file. 
        {
            TextWriter txt = new StreamWriter("C:\\Users\\Jordan S\\Documents\\thankyou.txt");
            txt.Write(generatedNoteTextBox.Text);
            txt.Close();
            MessageBox.Show("Results have been saved!");
        }

        private void resetButton_Click(object sender, EventArgs e)
            //I made a reset button instead of making "enter" the only way to reset the form. 
        {
            senderTextBox.Clear();
            occassionTextBox.Clear();
            giverTextBox.Clear();
            giftTextBox.Clear();
            generatedNoteTextBox.Clear();
        }
    }
}

