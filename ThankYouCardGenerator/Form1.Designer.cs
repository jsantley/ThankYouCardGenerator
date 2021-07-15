
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
            this.generatedNoteTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.wasMoney = new System.Windows.Forms.CheckBox();
            this.secondGiftTextBox = new System.Windows.Forms.TextBox();
            this.secondGiftLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giftTextBox
            // 
            this.giftTextBox.Location = new System.Drawing.Point(221, 70);
            this.giftTextBox.Name = "giftTextBox";
            this.giftTextBox.Size = new System.Drawing.Size(156, 20);
            this.giftTextBox.TabIndex = 0;
            this.giftTextBox.TextChanged += new System.EventHandler(this.giftTextBox_TextChanged);
            // 
            // giftLabel
            // 
            this.giftLabel.AutoSize = true;
            this.giftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giftLabel.Location = new System.Drawing.Point(65, 70);
            this.giftLabel.Name = "giftLabel";
            this.giftLabel.Size = new System.Drawing.Size(134, 15);
            this.giftLabel.TabIndex = 1;
            this.giftLabel.Text = "What did they give you?";
            // 
            // whoGaveLabel
            // 
            this.whoGaveLabel.AutoSize = true;
            this.whoGaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoGaveLabel.Location = new System.Drawing.Point(65, 138);
            this.whoGaveLabel.Name = "whoGaveLabel";
            this.whoGaveLabel.Size = new System.Drawing.Size(125, 15);
            this.whoGaveLabel.TabIndex = 2;
            this.whoGaveLabel.Text = "Who gave this to you?";
            // 
            // giverTextBox
            // 
            this.giverTextBox.Location = new System.Drawing.Point(221, 138);
            this.giverTextBox.Name = "giverTextBox";
            this.giverTextBox.Size = new System.Drawing.Size(156, 20);
            this.giverTextBox.TabIndex = 2;
            this.giverTextBox.TextChanged += new System.EventHandler(this.giverTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(338, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Thank You Note Generator";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(65, 104);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(147, 15);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "Who is sending this card?";
            // 
            // occassionLabel
            // 
            this.occassionLabel.AutoSize = true;
            this.occassionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occassionLabel.Location = new System.Drawing.Point(403, 138);
            this.occassionLabel.Name = "occassionLabel";
            this.occassionLabel.Size = new System.Drawing.Size(145, 15);
            this.occassionLabel.TabIndex = 7;
            this.occassionLabel.Text = "What was the occassion?";
            // 
            // occassionTextBox
            // 
            this.occassionTextBox.Location = new System.Drawing.Point(618, 138);
            this.occassionTextBox.Name = "occassionTextBox";
            this.occassionTextBox.Size = new System.Drawing.Size(156, 20);
            this.occassionTextBox.TabIndex = 5;
            this.occassionTextBox.TextChanged += new System.EventHandler(this.occassionTextBox_TextChanged);
            this.occassionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.occassionTextBox_KeyDown);
            // 
            // senderTextBox
            // 
            this.senderTextBox.AcceptsReturn = true;
            this.senderTextBox.Location = new System.Drawing.Point(221, 103);
            this.senderTextBox.Multiline = true;
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(156, 20);
            this.senderTextBox.TabIndex = 1;
            this.senderTextBox.TextChanged += new System.EventHandler(this.senderTextBox_TextChanged);
            this.senderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.occassionTextBox_KeyDown);
            // 
            // generatedNoteTextBox
            // 
            this.generatedNoteTextBox.Location = new System.Drawing.Point(54, 187);
            this.generatedNoteTextBox.Name = "generatedNoteTextBox";
            this.generatedNoteTextBox.ReadOnly = true;
            this.generatedNoteTextBox.Size = new System.Drawing.Size(490, 251);
            this.generatedNoteTextBox.TabIndex = 6;
            this.generatedNoteTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(618, 286);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save as Txt";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(618, 236);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(618, 340);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // wasMoney
            // 
            this.wasMoney.AutoSize = true;
            this.wasMoney.Location = new System.Drawing.Point(406, 105);
            this.wasMoney.Name = "wasMoney";
            this.wasMoney.Size = new System.Drawing.Size(123, 17);
            this.wasMoney.TabIndex = 4;
            this.wasMoney.Text = "Was the gift money?";
            this.wasMoney.UseVisualStyleBackColor = true;
            this.wasMoney.CheckedChanged += new System.EventHandler(this.wasMoney_CheckedChanged);
            // 
            // secondGiftTextBox
            // 
            this.secondGiftTextBox.Location = new System.Drawing.Point(618, 70);
            this.secondGiftTextBox.Name = "secondGiftTextBox";
            this.secondGiftTextBox.Size = new System.Drawing.Size(156, 20);
            this.secondGiftTextBox.TabIndex = 3;
            this.secondGiftTextBox.TextChanged += new System.EventHandler(this.secondGiftTextBox_TextChanged);
            // 
            // secondGiftLabel
            // 
            this.secondGiftLabel.AutoSize = true;
            this.secondGiftLabel.Location = new System.Drawing.Point(403, 73);
            this.secondGiftLabel.Name = "secondGiftLabel";
            this.secondGiftLabel.Size = new System.Drawing.Size(199, 13);
            this.secondGiftLabel.TabIndex = 16;
            this.secondGiftLabel.Text = "What was the second gift (if applicable)?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondGiftLabel);
            this.Controls.Add(this.secondGiftTextBox);
            this.Controls.Add(this.wasMoney);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.saveButton);
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
        private System.Windows.Forms.RichTextBox generatedNoteTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox wasMoney;
        private System.Windows.Forms.TextBox secondGiftTextBox;
        private System.Windows.Forms.Label secondGiftLabel;
    }
}

