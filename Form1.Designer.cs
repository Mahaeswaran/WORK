namespace rssFeedCSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.refreshButton = new System.Windows.Forms.Button();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveRssbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(450, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(23, 46);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(421, 21);
            this.titleComboBox.TabIndex = 1;
            this.titleComboBox.SelectedIndexChanged += new System.EventHandler(this.titleComboBox_SelectedIndexChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(19, 207);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(58, 24);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "GoTo";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 77);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(421, 128);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(23, 237);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(418, 20);
            this.channelTextBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(421, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // saveRssbutton
            // 
            this.saveRssbutton.Location = new System.Drawing.Point(450, 234);
            this.saveRssbutton.Name = "saveRssbutton";
            this.saveRssbutton.Size = new System.Drawing.Size(75, 23);
            this.saveRssbutton.TabIndex = 6;
            this.saveRssbutton.Text = "Save RSS";
            this.saveRssbutton.UseVisualStyleBackColor = true;
            this.saveRssbutton.Click += new System.EventHandler(this.saveRssbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 306);
            this.Controls.Add(this.saveRssbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.refreshButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rss Feed Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveRssbutton;
    }
}

