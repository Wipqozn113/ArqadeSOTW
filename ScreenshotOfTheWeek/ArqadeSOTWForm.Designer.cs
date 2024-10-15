namespace ScreenshotOfTheWeek
{
    partial class ArqadeSOTWForm
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
            copyToClipboard = new Button();
            sotwNumberTextBox = new TextBox();
            sotwNumberLabel = new Label();
            themeTitleTextBox = new TextBox();
            themeTitleLabel = new Label();
            themeBodyLabel = new Label();
            themeBodyRichTextBox = new RichTextBox();
            label1 = new Label();
            prevPostTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            winningPostTextBox = new TextBox();
            label4 = new Label();
            gameTagTextBox = new TextBox();
            label5 = new Label();
            winningUserTextBox = new TextBox();
            label6 = new Label();
            winningScreenshotTextBox = new TextBox();
            label7 = new Label();
            winningUpvotesTextBox = new TextBox();
            SuspendLayout();
            // 
            // copyToClipboard
            // 
            copyToClipboard.Location = new Point(283, 405);
            copyToClipboard.Name = "copyToClipboard";
            copyToClipboard.Size = new Size(135, 23);
            copyToClipboard.TabIndex = 0;
            copyToClipboard.Text = "Copy to Clipboard";
            copyToClipboard.UseVisualStyleBackColor = true;
            copyToClipboard.Click += copyToClickboard_Click;
            // 
            // sotwNumberTextBox
            // 
            sotwNumberTextBox.Location = new Point(103, 37);
            sotwNumberTextBox.Name = "sotwNumberTextBox";
            sotwNumberTextBox.Size = new Size(145, 23);
            sotwNumberTextBox.TabIndex = 1;
            sotwNumberTextBox.TextChanged += sotwNumberTextBox_TextChanged;
            // 
            // sotwNumberLabel
            // 
            sotwNumberLabel.AutoSize = true;
            sotwNumberLabel.Location = new Point(12, 40);
            sotwNumberLabel.Name = "sotwNumberLabel";
            sotwNumberLabel.Size = new Size(85, 15);
            sotwNumberLabel.TabIndex = 2;
            sotwNumberLabel.Text = "SOTW Number";
            // 
            // themeTitleTextBox
            // 
            themeTitleTextBox.Location = new Point(103, 66);
            themeTitleTextBox.Name = "themeTitleTextBox";
            themeTitleTextBox.Size = new Size(145, 23);
            themeTitleTextBox.TabIndex = 3;
            themeTitleTextBox.Text = "No Theme";
            // 
            // themeTitleLabel
            // 
            themeTitleLabel.AutoSize = true;
            themeTitleLabel.Location = new Point(12, 69);
            themeTitleLabel.Name = "themeTitleLabel";
            themeTitleLabel.Size = new Size(68, 15);
            themeTitleLabel.TabIndex = 4;
            themeTitleLabel.Text = "Theme Title";
            // 
            // themeBodyLabel
            // 
            themeBodyLabel.AutoSize = true;
            themeBodyLabel.Location = new Point(12, 100);
            themeBodyLabel.Name = "themeBodyLabel";
            themeBodyLabel.Size = new Size(73, 15);
            themeBodyLabel.TabIndex = 5;
            themeBodyLabel.Text = "Theme Body";
            // 
            // themeBodyRichTextBox
            // 
            themeBodyRichTextBox.Location = new Point(103, 95);
            themeBodyRichTextBox.Name = "themeBodyRichTextBox";
            themeBodyRichTextBox.Size = new Size(315, 104);
            themeBodyRichTextBox.TabIndex = 6;
            themeBodyRichTextBox.Text = "There is no theme this week.";
            themeBodyRichTextBox.TextChanged += themeBodyRichTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 208);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 7;
            label1.Text = "Previous SOTW Post ID";
            // 
            // prevPostTextBox
            // 
            prevPostTextBox.Location = new Point(134, 205);
            prevPostTextBox.Name = "prevPostTextBox";
            prevPostTextBox.Size = new Size(84, 23);
            prevPostTextBox.TabIndex = 8;
            prevPostTextBox.TextChanged += prevPostTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 9;
            label2.Text = "Arqade SOTW Generator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 208);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 10;
            label3.Text = "Winning Post ID";
            // 
            // winningPostTextBox
            // 
            winningPostTextBox.Location = new Point(333, 205);
            winningPostTextBox.Name = "winningPostTextBox";
            winningPostTextBox.Size = new Size(85, 23);
            winningPostTextBox.TabIndex = 11;
            winningPostTextBox.TextChanged += winningPostTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 239);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 12;
            label4.Text = "Game  Tag";
            // 
            // gameTagTextBox
            // 
            gameTagTextBox.Location = new Point(80, 236);
            gameTagTextBox.Name = "gameTagTextBox";
            gameTagTextBox.Size = new Size(338, 23);
            gameTagTextBox.TabIndex = 13;
            gameTagTextBox.TextChanged += gameTagTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 271);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 14;
            label5.Text = "Winning User";
            // 
            // winningUserTextBox
            // 
            winningUserTextBox.Location = new Point(80, 268);
            winningUserTextBox.Name = "winningUserTextBox";
            winningUserTextBox.Size = new Size(338, 23);
            winningUserTextBox.TabIndex = 15;
            winningUserTextBox.TextChanged += winningUserTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 303);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 16;
            label6.Text = "Winning Screenshot";
            // 
            // winningScreenshotTextBox
            // 
            winningScreenshotTextBox.Location = new Point(134, 300);
            winningScreenshotTextBox.Name = "winningScreenshotTextBox";
            winningScreenshotTextBox.Size = new Size(284, 23);
            winningScreenshotTextBox.TabIndex = 17;
            winningScreenshotTextBox.TextChanged += winningScreenshotTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 330);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 18;
            label7.Text = "Winning Post Upvotes";
            // 
            // winningUpvotesTextBox
            // 
            winningUpvotesTextBox.Location = new Point(134, 327);
            winningUpvotesTextBox.Name = "winningUpvotesTextBox";
            winningUpvotesTextBox.Size = new Size(57, 23);
            winningUpvotesTextBox.TabIndex = 19;
            winningUpvotesTextBox.TextChanged += winningUpvotesTextBox_TextChanged;
            // 
            // ArqadeSOTWForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
            Controls.Add(winningUpvotesTextBox);
            Controls.Add(label7);
            Controls.Add(winningScreenshotTextBox);
            Controls.Add(label6);
            Controls.Add(winningUserTextBox);
            Controls.Add(label5);
            Controls.Add(gameTagTextBox);
            Controls.Add(label4);
            Controls.Add(winningPostTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(prevPostTextBox);
            Controls.Add(label1);
            Controls.Add(themeBodyRichTextBox);
            Controls.Add(themeBodyLabel);
            Controls.Add(themeTitleLabel);
            Controls.Add(themeTitleTextBox);
            Controls.Add(sotwNumberLabel);
            Controls.Add(sotwNumberTextBox);
            Controls.Add(copyToClipboard);
            Name = "ArqadeSOTWForm";
            Text = "Arqade SOTW Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button copyToClipboard;
        private TextBox sotwNumberTextBox;
        private Label sotwNumberLabel;
        private TextBox themeTitleTextBox;
        private Label themeTitleLabel;
        private Label themeBodyLabel;
        private RichTextBox themeBodyRichTextBox;
        private Label label1;
        private TextBox prevPostTextBox;
        private Label label2;
        private Label label3;
        private TextBox winningPostTextBox;
        private Label label4;
        private TextBox gameTagTextBox;
        private Label label5;
        private TextBox winningUserTextBox;
        private Label label6;
        private TextBox winningScreenshotTextBox;
        private Label label7;
        private TextBox winningUpvotesTextBox;
    }
}
