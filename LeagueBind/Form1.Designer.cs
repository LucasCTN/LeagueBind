namespace LeagueBind
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
            this.label2 = new System.Windows.Forms.Label();
            this.directoryText = new System.Windows.Forms.TextBox();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.directoryButton = new System.Windows.Forms.Button();
            this.bindList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.directoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.masteryEmote = new System.Windows.Forms.RadioButton();
            this.danceEmote = new System.Windows.Forms.RadioButton();
            this.laughEmote = new System.Windows.Forms.RadioButton();
            this.tauntEmote = new System.Windows.Forms.RadioButton();
            this.jokeEmote = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "1. Select your League of Legends directory";
            // 
            // directoryText
            // 
            this.directoryText.Location = new System.Drawing.Point(12, 34);
            this.directoryText.Name = "directoryText";
            this.directoryText.Size = new System.Drawing.Size(267, 20);
            this.directoryText.TabIndex = 14;
            this.directoryText.TextChanged += new System.EventHandler(this.directoryText_TextChanged);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(9, 308);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(168, 13);
            this.feedbackLabel.TabIndex = 13;
            this.feedbackLabel.Text = "Waiting for you to make choices...";
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(300, 31);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(111, 23);
            this.directoryButton.TabIndex = 12;
            this.directoryButton.Text = "Change Directory";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // bindList
            // 
            this.bindList.FormattingEnabled = true;
            this.bindList.Items.AddRange(new object[] {
            "[q]",
            "[w]",
            "[e]",
            "[r]",
            "[d]",
            "[f]",
            "[1]",
            "[2]",
            "[3]",
            "[4]",
            "[5]",
            "[6]",
            "[7]"});
            this.bindList.Location = new System.Drawing.Point(278, 126);
            this.bindList.Name = "bindList";
            this.bindList.Size = new System.Drawing.Size(136, 124);
            this.bindList.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "3. Choose the keys";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(279, 256);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(136, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Bind Emote to Key!";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Made by Luk3M";
            // 
            // masteryEmote
            // 
            this.masteryEmote.AutoSize = true;
            this.masteryEmote.Checked = true;
            this.masteryEmote.Location = new System.Drawing.Point(6, 19);
            this.masteryEmote.Name = "masteryEmote";
            this.masteryEmote.Size = new System.Drawing.Size(95, 17);
            this.masteryEmote.TabIndex = 18;
            this.masteryEmote.TabStop = true;
            this.masteryEmote.Text = "Mastery Emote";
            this.masteryEmote.UseVisualStyleBackColor = true;
            this.masteryEmote.CheckedChanged += new System.EventHandler(this.MasteryEmote_CheckedChanged);
            // 
            // danceEmote
            // 
            this.danceEmote.AutoSize = true;
            this.danceEmote.Location = new System.Drawing.Point(6, 42);
            this.danceEmote.Name = "danceEmote";
            this.danceEmote.Size = new System.Drawing.Size(90, 17);
            this.danceEmote.TabIndex = 19;
            this.danceEmote.TabStop = true;
            this.danceEmote.Text = "Dance Emote";
            this.danceEmote.UseVisualStyleBackColor = true;
            this.danceEmote.CheckedChanged += new System.EventHandler(this.DanceEmote_CheckedChanged);
            // 
            // laughEmote
            // 
            this.laughEmote.AutoSize = true;
            this.laughEmote.Location = new System.Drawing.Point(6, 88);
            this.laughEmote.Name = "laughEmote";
            this.laughEmote.Size = new System.Drawing.Size(88, 17);
            this.laughEmote.TabIndex = 19;
            this.laughEmote.TabStop = true;
            this.laughEmote.Text = "Laugh Emote";
            this.laughEmote.UseVisualStyleBackColor = true;
            this.laughEmote.CheckedChanged += new System.EventHandler(this.LaughEmote_CheckedChanged);
            // 
            // tauntEmote
            // 
            this.tauntEmote.AutoSize = true;
            this.tauntEmote.Location = new System.Drawing.Point(6, 111);
            this.tauntEmote.Name = "tauntEmote";
            this.tauntEmote.Size = new System.Drawing.Size(86, 17);
            this.tauntEmote.TabIndex = 19;
            this.tauntEmote.TabStop = true;
            this.tauntEmote.Text = "Taunt Emote";
            this.tauntEmote.UseVisualStyleBackColor = true;
            this.tauntEmote.CheckedChanged += new System.EventHandler(this.TauntEmote_CheckedChanged);
            // 
            // jokeEmote
            // 
            this.jokeEmote.AutoSize = true;
            this.jokeEmote.Location = new System.Drawing.Point(6, 65);
            this.jokeEmote.Name = "jokeEmote";
            this.jokeEmote.Size = new System.Drawing.Size(81, 17);
            this.jokeEmote.TabIndex = 19;
            this.jokeEmote.TabStop = true;
            this.jokeEmote.Text = "Joke Emote";
            this.jokeEmote.UseVisualStyleBackColor = true;
            this.jokeEmote.CheckedChanged += new System.EventHandler(this.JokeEmote_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tauntEmote);
            this.groupBox1.Controls.Add(this.jokeEmote);
            this.groupBox1.Controls.Add(this.masteryEmote);
            this.groupBox1.Controls.Add(this.laughEmote);
            this.groupBox1.Controls.Add(this.danceEmote);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 140);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Choose the emote";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directoryText);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.bindList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LeagueBind";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directoryText;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.CheckedListBox bindList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.FolderBrowserDialog directoryBrowser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton masteryEmote;
        private System.Windows.Forms.RadioButton danceEmote;
        private System.Windows.Forms.RadioButton laughEmote;
        private System.Windows.Forms.RadioButton tauntEmote;
        private System.Windows.Forms.RadioButton jokeEmote;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

