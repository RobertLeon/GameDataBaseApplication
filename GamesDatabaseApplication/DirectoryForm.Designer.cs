namespace GamesDatabaseApplication
{
    partial class DirectoryForm
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
            this.logOutButton = new System.Windows.Forms.Button();
            this.gamesDatabaseButton = new System.Windows.Forms.Button();
            this.randomGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(12, 316);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(295, 40);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // gamesDatabaseButton
            // 
            this.gamesDatabaseButton.Location = new System.Drawing.Point(12, 12);
            this.gamesDatabaseButton.Name = "gamesDatabaseButton";
            this.gamesDatabaseButton.Size = new System.Drawing.Size(295, 40);
            this.gamesDatabaseButton.TabIndex = 1;
            this.gamesDatabaseButton.Text = "Games Database";
            this.gamesDatabaseButton.UseVisualStyleBackColor = true;
            this.gamesDatabaseButton.Click += new System.EventHandler(this.gamesDatabaseButton_Click);
            // 
            // randomGameButton
            // 
            this.randomGameButton.Location = new System.Drawing.Point(12, 82);
            this.randomGameButton.Name = "randomGameButton";
            this.randomGameButton.Size = new System.Drawing.Size(295, 40);
            this.randomGameButton.TabIndex = 2;
            this.randomGameButton.Text = "Random Game Selection";
            this.randomGameButton.UseVisualStyleBackColor = true;
            this.randomGameButton.Click += new System.EventHandler(this.randomGameButton_Click);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 370);
            this.Controls.Add(this.randomGameButton);
            this.Controls.Add(this.gamesDatabaseButton);
            this.Controls.Add(this.logOutButton);
            this.Name = "DirectoryForm";
            this.Text = "DirectoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button gamesDatabaseButton;
        private System.Windows.Forms.Button randomGameButton;
    }
}