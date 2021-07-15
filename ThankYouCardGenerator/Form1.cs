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
        string secondGift;
        bool secondGifttrue;
        bool   money;


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

        private void secondGiftTextBox_TextChanged(object sender, EventArgs e)
        {
            secondGift = secondGiftTextBox.Text.ToString();
            secondGifttrue = secondGiftTextBox.Text != "";

        }

        private void wasMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (wasMoney.Checked == true)
            {
                money = true;
            } else if (wasMoney.Checked == false)
            {
                money = false;
            }
            
        }

        #endregion
        #region ActionIfKeyPressed
        /*at the senderTextBox, this checks to see if either the Tab Key or the Enter keys are pressed to trigger the creation of the thank you card.  
         * It will clear out all the other textboxes to allow for another run of the program upon the key event. 
        */
        public void occassionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                generateNote(giftGiven, giftGiver, giftOccassion, cardSender, secondGift, money);
            }
            else
            {
                return;
            }
        }




            #endregion

            #region methodCreationNote
            //made a method that could be called to generate the note instead of repeated statements. 
            private void generateNote(string giftGiven,string giftGiver, string giftOccassion, string cardSender, string secondGift, bool money)
            {
            
            if (secondGifttrue == false && money == false)
            {
                generatedNoteTextBox.Text = $"Dear {giftGiver}, \n \nThank you so much for the {giftGiven}!  We cannot wait to put it to good use!  \nWe are so glad that you could attend our {giftOccassion}! \nThanks again! \nSincerely, \n \n{cardSender}";

            } else if (secondGifttrue == false && money == true)
            {
                generatedNoteTextBox.Text = $"Dear {giftGiver}, \n \nThank you so much for the generous gift!  We cannot wait to put it to good use! \nWe are so glad that you could attend our {giftOccassion}! \nThanks again! \nSincerely, \n \n{cardSender}";
            } else if (secondGifttrue == true && money == false)
            {
                generatedNoteTextBox.Text = $"Dear {giftGiver}, \n \nThank you so much for the {giftGiven} and the {secondGift}!  We cannot wait to put them to good use! \nWe are so glad that you could attend our {giftOccassion}! \nThanks again! \nSincerely, \n \n{cardSender}";

            }
            else if (secondGifttrue == true && money == true)
            {
                generatedNoteTextBox.Text = $"Dear {giftGiver}, \n \nThank you so much for the generous gifts!  We cannot wait to put them to good use! \nWe are so glad that you could attend our {giftOccassion}! \nThanks again! \nSincerely, \n \n{cardSender}";
            }

            return;
        }



        #endregion
        #region ButtonClicks
        //added buttons to make it more intuitive and user friendly.
        private void generateButton_Click(object sender, EventArgs e)
            //does the same thing as the enter button.
        {
            generateNote(giftGiven, giftGiver, giftOccassion, cardSender, secondGift, money);

        }


        

        private void saveButton_Click(object sender, EventArgs e)
            //added the ability to save as a text file. 
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            TextWriter txt = new StreamWriter(Path.Combine(docPath, "thankyounote.txt"));
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
            secondGiftTextBox.Clear();
            wasMoney.Checked = false;
            
        }

        #endregion

    }
}

