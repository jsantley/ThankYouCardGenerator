using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                generatedNoteTextBox.Text = $"Dear {giftGiver}, \n Thank you so much for the {giftGiven}!  I cannot wait to put it to good use!  \n I am so glad that you could attend my {giftOccassion}! \n Thanks again! \n Sincerely, \n {cardSender}";
                senderTextBox.Clear();
                occassionTextBox.Clear();
                giverTextBox.Clear();
                giftTextBox.Clear();

            }
            else
            {
                return;
            }
           

        }
        #endregion



    }
}

