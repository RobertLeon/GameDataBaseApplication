namespace GamesDatabaseApplication
{
    partial class RandomGameForm
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
            this.components = new System.ComponentModel.Container();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.gameView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.platformComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.completionComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberGamesComboBox = new System.Windows.Forms.ComboBox();
            this.randomGameButton = new System.Windows.Forms.Button();
            this.resetComboBoxesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(625, 479);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(155, 35);
            this.mainMenuButton.TabIndex = 0;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // gameView
            // 
            this.gameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameView.Location = new System.Drawing.Point(12, 29);
            this.gameView.Name = "gameView";
            this.gameView.Size = new System.Drawing.Size(385, 485);
            this.gameView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Games";
            // 
            // platformComboBox
            // 
            this.platformComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platformComboBox.FormattingEnabled = true;
            this.platformComboBox.Items.AddRange(new object[] {
            "Atari 2600",
            "Sega Master System",
            "Nintendo Entertainment System",
            "Commodore 64",
            "TurboGrafx-16",
            "Sega Genesis",
            "Neo-Geo",
            "Super Nintendo",
            "CD-i",
            "Sega 32X",
            "Atari Jaguar",
            "PlayStation",
            "Sega Saturn",
            "3DO",
            "Nintendo 64",
            "Amiga CD32",
            "Dreamcast",
            "PlayStation 2",
            "GameCube",
            "Xbox",
            "Xbox360",
            "PlayStation 3",
            "Wii",
            "Wii U",
            "Playstation 4",
            "Xbox One",
            "Steam (PC)",
            "Origin (PC)",
            "Uplay (PC)"});
            this.platformComboBox.Location = new System.Drawing.Point(403, 45);
            this.platformComboBox.Name = "platformComboBox";
            this.platformComboBox.Size = new System.Drawing.Size(260, 21);
            this.platformComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Platform";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Completion";
            // 
            // completionComboBox
            // 
            this.completionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.completionComboBox.FormattingEnabled = true;
            this.completionComboBox.Items.AddRange(new object[] {
            "Unplayed",
            "Played",
            "Finished",
            "Completed"});
            this.completionComboBox.Location = new System.Drawing.Point(403, 90);
            this.completionComboBox.Name = "completionComboBox";
            this.completionComboBox.Size = new System.Drawing.Size(260, 21);
            this.completionComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Games";
            // 
            // numberGamesComboBox
            // 
            this.numberGamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberGamesComboBox.FormattingEnabled = true;
            this.numberGamesComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberGamesComboBox.Location = new System.Drawing.Point(403, 134);
            this.numberGamesComboBox.Name = "numberGamesComboBox";
            this.numberGamesComboBox.Size = new System.Drawing.Size(260, 21);
            this.numberGamesComboBox.TabIndex = 8;
            // 
            // randomGameButton
            // 
            this.randomGameButton.Location = new System.Drawing.Point(454, 199);
            this.randomGameButton.Name = "randomGameButton";
            this.randomGameButton.Size = new System.Drawing.Size(155, 35);
            this.randomGameButton.TabIndex = 9;
            this.randomGameButton.Text = "Select Random Game(s)";
            this.randomGameButton.UseVisualStyleBackColor = true;
            this.randomGameButton.Click += new System.EventHandler(this.randomGameButton_Click);
            // 
            // resetComboBoxesButton
            // 
            this.resetComboBoxesButton.Location = new System.Drawing.Point(625, 426);
            this.resetComboBoxesButton.Name = "resetComboBoxesButton";
            this.resetComboBoxesButton.Size = new System.Drawing.Size(155, 35);
            this.resetComboBoxesButton.TabIndex = 10;
            this.resetComboBoxesButton.Text = "Clear Input";
            this.resetComboBoxesButton.UseVisualStyleBackColor = true;
            this.resetComboBoxesButton.Click += new System.EventHandler(this.resetComboBoxesButton_Click);
            // 
            // RandomGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 526);
            this.Controls.Add(this.resetComboBoxesButton);
            this.Controls.Add(this.randomGameButton);
            this.Controls.Add(this.numberGamesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.completionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.platformComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameView);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "RandomGameForm";
            this.Text = "RandomGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.gameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.DataGridView gameView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox platformComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox completionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox numberGamesComboBox;
        private System.Windows.Forms.Button randomGameButton;
        private System.Windows.Forms.Button resetComboBoxesButton;
    }
}