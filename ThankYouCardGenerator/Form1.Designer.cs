
namespace ThankYouCardGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.giftTextBox = new System.Windows.Forms.TextBox();
            this.giftLabel = new System.Windows.Forms.Label();
            this.whoGaveLabel = new System.Windows.Forms.Label();
            this.giverTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.occassionLabel = new System.Windows.Forms.Label();
            this.occassionTextBox = new System.Windows.Forms.TextBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.generatedNoteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // giftTextBox
            // 
            this.giftTextBox.Location = new System.Drawing.Point(221, 91);
            this.giftTextBox.Name = "giftTextBox";
            this.giftTextBox.Size = new System.Drawing.Size(156, 20);
            this.giftTextBox.TabIndex = 0;
            this.giftTextBox.TextChanged += new System.EventHandler(this.giftTextBox_TextChanged);
            // 
            // giftLabel
            // 
            this.giftLabel.AutoSize = true;
            this.giftLabel.Location = new System.Drawing.Point(85, 91);
            this.giftLabel.Name = "giftLabel";
            this.giftLabel.Size = new System.Drawing.Size(122, 13);
            this.giftLabel.TabIndex = 1;
            this.giftLabel.Text = "What did they give you?";
            // 
            // whoGaveLabel
            // 
            this.whoGaveLabel.AutoSize = true;
            this.whoGaveLabel.Location = new System.Drawing.Point(85, 138);
            this.whoGaveLabel.Name = "whoGaveLabel";
            this.whoGaveLabel.Size = new System.Drawing.Size(114, 13);
            this.whoGaveLabel.TabIndex = 2;
            this.whoGaveLabel.Text = "Who gave this to you?";
            // 
            // giverTextBox
            // 
            this.giverTextBox.Location = new System.Drawing.Point(221, 138);
            this.giverTextBox.Name = "giverTextBox";
            this.giverTextBox.Size = new System.Drawing.Size(156, 20);
            this.giverTextBox.TabIndex = 3;
            this.giverTextBox.TextChanged += new System.EventHandler(this.giverTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(314, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Thank You Note Generator";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(466, 141);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(129, 13);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "Who is sending this card?";
            // 
            // occassionLabel
            // 
            this.occassionLabel.AutoSize = true;
            this.occassionLabel.Location = new System.Drawing.Point(466, 91);
            this.occassionLabel.Name = "occassionLabel";
            this.occassionLabel.Size = new System.Drawing.Size(130, 13);
            this.occassionLabel.TabIndex = 7;
            this.occassionLabel.Text = "What was the occassion?";
            // 
            // occassionTextBox
            // 
            this.occassionTextBox.Location = new System.Drawing.Point(618, 84);
            this.occassionTextBox.Name = "occassionTextBox";
            this.occassionTextBox.Size = new System.Drawing.Size(156, 20);
            this.occassionTextBox.TabIndex = 8;
            this.occassionTextBox.TextChanged += new System.EventHandler(this.occassionTextBox_TextChanged);
            // 
            // senderTextBox
            // 
            this.senderTextBox.AcceptsReturn = true;
            this.senderTextBox.Location = new System.Drawing.Point(618, 141);
            this.senderTextBox.Multiline = true;
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(156, 20);
            this.senderTextBox.TabIndex = 9;
            this.senderTextBox.TextChanged += new System.EventHandler(this.senderTextBox_TextChanged);
            this.senderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.senderTextBox_KeyDown);
            // 
            // generatedNoteTextBox
            // 
            this.generatedNoteTextBox.Location = new System.Drawing.Point(113, 189);
            this.generatedNoteTextBox.Multiline = true;
            this.generatedNoteTextBox.Name = "generatedNoteTextBox";
            this.generatedNoteTextBox.ReadOnly = true;
            this.generatedNoteTextBox.Size = new System.Drawing.Size(594, 249);
            this.generatedNoteTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generatedNoteTextBox);
            this.Controls.Add(this.senderTextBox);
            this.Controls.Add(this.occassionTextBox);
            this.Controls.Add(this.occassionLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.giverTextBox);
            this.Controls.Add(this.whoGaveLabel);
            this.Controls.Add(this.giftLabel);
            this.Controls.Add(this.giftTextBox);
            this.Name = "Form1";
            this.Text = "Thank You Note Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox giftTextBox;
        private System.Windows.Forms.Label giftLabel;
        private System.Windows.Forms.Label whoGaveLabel;
        private System.Windows.Forms.TextBox giverTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label occassionLabel;
        private System.Windows.Forms.TextBox occassionTextBox;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.TextBox generatedNoteTextBox;
    }
}

