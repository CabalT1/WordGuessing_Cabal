namespace WordGuessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtGuess = new TextBox();
            btnGuess = new Button();
            lstWrongGuesses = new ListBox();
            label1 = new Label();
            lblWord = new Label();
            SuspendLayout();
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuess.Location = new Point(196, 221);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(268, 33);
            txtGuess.TabIndex = 0;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.DarkSeaGreen;
            btnGuess.FlatStyle = FlatStyle.Flat;
            btnGuess.Font = new Font("Segoe UI", 12F);
            btnGuess.ForeColor = Color.White;
            btnGuess.Location = new Point(295, 260);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(66, 34);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += button1_Click;
            // 
            // lstWrongGuesses
            // 
            lstWrongGuesses.FormattingEnabled = true;
            lstWrongGuesses.ItemHeight = 15;
            lstWrongGuesses.Location = new Point(532, 136);
            lstWrongGuesses.Name = "lstWrongGuesses";
            lstWrongGuesses.Size = new Size(186, 184);
            lstWrongGuesses.TabIndex = 2;
            lstWrongGuesses.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Location = new Point(592, 118);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Wrong Guess";
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.BackColor = Color.White;
            lblWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWord.Location = new Point(265, 182);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(0, 21);
            lblWord.TabIndex = 4;
            lblWord.Click += lblWord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(lblWord);
            Controls.Add(label1);
            Controls.Add(lstWrongGuesses);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGuess;
        private Button btnGuess;
        private ListBox lstWrongGuesses;
        private Label label1;
        private Label lblWord;
    }
}
