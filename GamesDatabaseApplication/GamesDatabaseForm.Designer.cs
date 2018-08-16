namespace GamesDatabaseApplication
{
    partial class GamesDatabaseForm
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
            this.gamesDataView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.directoryButton = new System.Windows.Forms.Button();
            this.refreshDatabase = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.editGameButton = new System.Windows.Forms.Button();
            this.removeGameButton = new System.Windows.Forms.Button();
            this.gameNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.completionComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.platformComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesDataView
            // 
            this.gamesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesDataView.Location = new System.Drawing.Point(12, 43);
            this.gamesDataView.Name = "gamesDataView";
            this.gamesDataView.Size = new System.Drawing.Size(640, 530);
            this.gamesDataView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Collection";
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(876, 538);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(155, 35);
            this.directoryButton.TabIndex = 2;
            this.directoryButton.Text = "Main Menu";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // refreshDatabase
            // 
            this.refreshDatabase.Location = new System.Drawing.Point(876, 467);
            this.refreshDatabase.Name = "refreshDatabase";
            this.refreshDatabase.Size = new System.Drawing.Size(155, 35);
            this.refreshDatabase.TabIndex = 3;
            this.refreshDatabase.Text = "Refresh Database";
            this.refreshDatabase.UseVisualStyleBackColor = true;
            this.refreshDatabase.Click += new System.EventHandler(this.refreshDatabase_Click);
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(876, 344);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(155, 35);
            this.addGameButton.TabIndex = 4;
            this.addGameButton.Text = "Add Game";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // editGameButton
            // 
            this.editGameButton.Location = new System.Drawing.Point(876, 385);
            this.editGameButton.Name = "editGameButton";
            this.editGameButton.Size = new System.Drawing.Size(155, 35);
            this.editGameButton.TabIndex = 5;
            this.editGameButton.Text = "Edit Game";
            this.editGameButton.UseVisualStyleBackColor = true;
            this.editGameButton.Click += new System.EventHandler(this.editGameButton_Click);
            // 
            // removeGameButton
            // 
            this.removeGameButton.Location = new System.Drawing.Point(876, 426);
            this.removeGameButton.Name = "removeGameButton";
            this.removeGameButton.Size = new System.Drawing.Size(155, 35);
            this.removeGameButton.TabIndex = 6;
            this.removeGameButton.Text = "Remove Game";
            this.removeGameButton.UseVisualStyleBackColor = true;
            this.removeGameButton.Click += new System.EventHandler(this.removeGameButton_Click);
            // 
            // gameNameTextBox
            // 
            this.gameNameTextBox.Location = new System.Drawing.Point(658, 59);
            this.gameNameTextBox.Name = "gameNameTextBox";
            this.gameNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.gameNameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Completion Status";
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
            this.completionComboBox.Location = new System.Drawing.Point(658, 138);
            this.completionComboBox.Name = "completionComboBox";
            this.completionComboBox.Size = new System.Drawing.Size(260, 21);
            this.completionComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Platform";
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
            this.platformComboBox.Location = new System.Drawing.Point(658, 98);
            this.platformComboBox.Name = "platformComboBox";
            this.platformComboBox.Size = new System.Drawing.Size(260, 21);
            this.platformComboBox.TabIndex = 12;
            // 
            // GamesDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 634);
            this.Controls.Add(this.platformComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.completionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gameNameTextBox);
            this.Controls.Add(this.removeGameButton);
            this.Controls.Add(this.editGameButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.refreshDatabase);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamesDataView);
            this.Name = "GamesDatabaseForm";
            this.Text = "GamesDatabaseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamesDatabaseForm_FormClosed);
            this.Load += new System.EventHandler(this.GamesDatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView gamesDataView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.Button refreshDatabase;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button editGameButton;
        private System.Windows.Forms.Button removeGameButton;
        private System.Windows.Forms.TextBox gameNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox completionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox platformComboBox;
    }
}