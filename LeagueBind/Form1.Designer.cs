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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select your League of Legends directory";
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
            this.feedbackLabel.Location = new System.Drawing.Point(170, 285);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(43, 13);
            this.feedbackLabel.TabIndex = 13;
            this.feedbackLabel.Text = "Waiting";
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
            "[f]"});
            this.bindList.Location = new System.Drawing.Point(132, 126);
            this.bindList.Name = "bindList";
            this.bindList.Size = new System.Drawing.Size(120, 79);
            this.bindList.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose the keys";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(153, 234);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Bind!";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LeagueBind";
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
    }
}

