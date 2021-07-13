
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.giftLabel = new System.Windows.Forms.Label();
            this.whoGaveLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.occassionLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.generatedNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
           //this.whoGaveLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(314, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Thank You Note Generator";
            //this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(466, 141);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(129, 13);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "Who is sending this card?";
            //this.fromLabel.Click += new System.EventHandler(this.fromLabel_Click);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(618, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(618, 141);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 9;
            // 
            // generatedNote
            // 
            this.generatedNote.Location = new System.Drawing.Point(113, 189);
            this.generatedNote.Multiline = true;
            this.generatedNote.Name = "generatedNote";
            this.generatedNote.Size = new System.Drawing.Size(594, 249);
            this.generatedNote.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generatedNote);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.occassionLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.whoGaveLabel);
            this.Controls.Add(this.giftLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Thank You Note Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label giftLabel;
        private System.Windows.Forms.Label whoGaveLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label occassionLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox generatedNote;
    }
}

