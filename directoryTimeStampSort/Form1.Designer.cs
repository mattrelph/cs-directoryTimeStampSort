namespace directoryTimeStampSort
{
    partial class mainForm
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
            this.SourceDirLabel = new System.Windows.Forms.Label();
            this.DestinationDirLabel = new System.Windows.Forms.Label();
            this.SourceDirTextBox = new System.Windows.Forms.TextBox();
            this.DestinationDirTextBox = new System.Windows.Forms.TextBox();
            this.moveComboBox = new System.Windows.Forms.ComboBox();
            this.promptsComboBox = new System.Windows.Forms.ComboBox();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.overwriteComboBox = new System.Windows.Forms.ComboBox();
            this.moveLabel = new System.Windows.Forms.Label();
            this.promptsLabel = new System.Windows.Forms.Label();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.overWriteLabel = new System.Windows.Forms.Label();
            this.debugText = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.sourceButton = new System.Windows.Forms.Button();
            this.destinationButton = new System.Windows.Forms.Button();
            this.sourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.sourceBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.destinationBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceDirLabel
            // 
            this.SourceDirLabel.AutoSize = true;
            this.SourceDirLabel.Location = new System.Drawing.Point(43, 39);
            this.SourceDirLabel.Name = "SourceDirLabel";
            this.SourceDirLabel.Size = new System.Drawing.Size(86, 13);
            this.SourceDirLabel.TabIndex = 0;
            this.SourceDirLabel.Text = "Source Directory";
            this.SourceDirLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DestinationDirLabel
            // 
            this.DestinationDirLabel.AutoSize = true;
            this.DestinationDirLabel.Location = new System.Drawing.Point(43, 78);
            this.DestinationDirLabel.Name = "DestinationDirLabel";
            this.DestinationDirLabel.Size = new System.Drawing.Size(105, 13);
            this.DestinationDirLabel.TabIndex = 1;
            this.DestinationDirLabel.Text = "Destination Directory";
            this.DestinationDirLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SourceDirTextBox
            // 
            this.SourceDirTextBox.Location = new System.Drawing.Point(154, 39);
            this.SourceDirTextBox.Name = "SourceDirTextBox";
            this.SourceDirTextBox.Size = new System.Drawing.Size(425, 20);
            this.SourceDirTextBox.TabIndex = 2;
            this.SourceDirTextBox.TextChanged += new System.EventHandler(this.SourceDirTextBox_TextChanged);
            // 
            // DestinationDirTextBox
            // 
            this.DestinationDirTextBox.Location = new System.Drawing.Point(154, 75);
            this.DestinationDirTextBox.Name = "DestinationDirTextBox";
            this.DestinationDirTextBox.Size = new System.Drawing.Size(425, 20);
            this.DestinationDirTextBox.TabIndex = 3;
            this.DestinationDirTextBox.TextChanged += new System.EventHandler(this.DestinationDirTextBox_TextChanged);
            // 
            // moveComboBox
            // 
            this.moveComboBox.FormattingEnabled = true;
            this.moveComboBox.Items.AddRange(new object[] {
            "Copy All Files",
            "Move All Files"});
            this.moveComboBox.Location = new System.Drawing.Point(46, 132);
            this.moveComboBox.MaxDropDownItems = 2;
            this.moveComboBox.Name = "moveComboBox";
            this.moveComboBox.Size = new System.Drawing.Size(121, 21);
            this.moveComboBox.TabIndex = 4;
            this.moveComboBox.SelectedIndexChanged += new System.EventHandler(this.moveComboBox_SelectedIndexChanged);
            // 
            // promptsComboBox
            // 
            this.promptsComboBox.FormattingEnabled = true;
            this.promptsComboBox.Items.AddRange(new object[] {
            "Prompt On Conflict",
            "No Prompts"});
            this.promptsComboBox.Location = new System.Drawing.Point(185, 132);
            this.promptsComboBox.Name = "promptsComboBox";
            this.promptsComboBox.Size = new System.Drawing.Size(121, 21);
            this.promptsComboBox.TabIndex = 5;
            this.promptsComboBox.SelectedIndexChanged += new System.EventHandler(this.promptsComboBox_SelectedIndexChanged);
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "Year",
            "Month",
            "Day"});
            this.sortByComboBox.Location = new System.Drawing.Point(327, 132);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortByComboBox.TabIndex = 6;
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByComboBox_SelectedIndexChanged);
            // 
            // overwriteComboBox
            // 
            this.overwriteComboBox.FormattingEnabled = true;
            this.overwriteComboBox.Items.AddRange(new object[] {
            "Overwrite",
            "Make Duplicate"});
            this.overwriteComboBox.Location = new System.Drawing.Point(466, 132);
            this.overwriteComboBox.Name = "overwriteComboBox";
            this.overwriteComboBox.Size = new System.Drawing.Size(121, 21);
            this.overwriteComboBox.TabIndex = 7;
            this.overwriteComboBox.SelectedIndexChanged += new System.EventHandler(this.overwriteComboBox_SelectedIndexChanged);
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Location = new System.Drawing.Point(46, 113);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(64, 13);
            this.moveLabel.TabIndex = 8;
            this.moveLabel.Text = "Action Type";
            // 
            // promptsLabel
            // 
            this.promptsLabel.AutoSize = true;
            this.promptsLabel.Location = new System.Drawing.Point(185, 112);
            this.promptsLabel.Name = "promptsLabel";
            this.promptsLabel.Size = new System.Drawing.Size(45, 13);
            this.promptsLabel.TabIndex = 9;
            this.promptsLabel.Text = "Prompts";
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Location = new System.Drawing.Point(327, 111);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(41, 13);
            this.sortByLabel.TabIndex = 10;
            this.sortByLabel.Text = "Sort By";
            // 
            // overWriteLabel
            // 
            this.overWriteLabel.AutoSize = true;
            this.overWriteLabel.Location = new System.Drawing.Point(466, 113);
            this.overWriteLabel.Name = "overWriteLabel";
            this.overWriteLabel.Size = new System.Drawing.Size(74, 13);
            this.overWriteLabel.TabIndex = 11;
            this.overWriteLabel.Text = "Default Action";
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(49, 219);
            this.debugText.Multiline = true;
            this.debugText.Name = "debugText";
            this.debugText.ReadOnly = true;
            this.debugText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugText.Size = new System.Drawing.Size(612, 219);
            this.debugText.TabIndex = 13;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(697, 13);
            this.instructionsLabel.TabIndex = 14;
            this.instructionsLabel.Text = "This Program takes the files in the source directory and sorts them into folders " +
    "in the output directory by their time stamp. \r\n";
            this.instructionsLabel.Click += new System.EventHandler(this.instructionsLabel_Click);
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(586, 39);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(75, 23);
            this.sourceButton.TabIndex = 15;
            this.sourceButton.Text = "Browse...";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(586, 75);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(75, 23);
            this.destinationButton.TabIndex = 16;
            this.destinationButton.Text = "Browse...";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // sourceBrowserDialog
            // 
            this.sourceBrowserDialog.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // destinationBrowserDialog
            // 
            this.destinationBrowserDialog.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // sortButton
            // 
            this.sortButton.Enabled = false;
            this.sortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortButton.Location = new System.Drawing.Point(49, 178);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(612, 35);
            this.sortButton.TabIndex = 17;
            this.sortButton.Text = "Sort!";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.destinationButton);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.overWriteLabel);
            this.Controls.Add(this.sortByLabel);
            this.Controls.Add(this.promptsLabel);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.overwriteComboBox);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.promptsComboBox);
            this.Controls.Add(this.moveComboBox);
            this.Controls.Add(this.DestinationDirTextBox);
            this.Controls.Add(this.SourceDirTextBox);
            this.Controls.Add(this.DestinationDirLabel);
            this.Controls.Add(this.SourceDirLabel);
            this.Name = "mainForm";
            this.Text = "Directory Time Stamp Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceDirLabel;
        private System.Windows.Forms.Label DestinationDirLabel;
        private System.Windows.Forms.TextBox SourceDirTextBox;
        private System.Windows.Forms.TextBox DestinationDirTextBox;
        private System.Windows.Forms.ComboBox moveComboBox;
        private System.Windows.Forms.ComboBox promptsComboBox;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.ComboBox overwriteComboBox;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Label promptsLabel;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.Label overWriteLabel;
        private System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog sourceBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog destinationBrowserDialog;
        private System.Windows.Forms.Button sortButton;
    }
}

