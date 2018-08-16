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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.GamesDatabaseButton = new System.Windows.Forms.Button();
            this.RandomGameButton = new System.Windows.Forms.Button();
            this.PieChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(12, 316);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(295, 40);
            this.LogOutButton.TabIndex = 0;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // GamesDatabaseButton
            // 
            this.GamesDatabaseButton.Location = new System.Drawing.Point(12, 12);
            this.GamesDatabaseButton.Name = "GamesDatabaseButton";
            this.GamesDatabaseButton.Size = new System.Drawing.Size(295, 40);
            this.GamesDatabaseButton.TabIndex = 1;
            this.GamesDatabaseButton.Text = "Games Database";
            this.GamesDatabaseButton.UseVisualStyleBackColor = true;
            this.GamesDatabaseButton.Click += new System.EventHandler(this.GamesDatabaseButton_Click);
            // 
            // RandomGameButton
            // 
            this.RandomGameButton.Location = new System.Drawing.Point(12, 82);
            this.RandomGameButton.Name = "RandomGameButton";
            this.RandomGameButton.Size = new System.Drawing.Size(295, 40);
            this.RandomGameButton.TabIndex = 2;
            this.RandomGameButton.Text = "Random Game Selection";
            this.RandomGameButton.UseVisualStyleBackColor = true;
            this.RandomGameButton.Click += new System.EventHandler(this.RandomGameButton_Click);
            // 
            // PieChartButton
            // 
            this.PieChartButton.Location = new System.Drawing.Point(12, 165);
            this.PieChartButton.Name = "PieChartButton";
            this.PieChartButton.Size = new System.Drawing.Size(295, 40);
            this.PieChartButton.TabIndex = 3;
            this.PieChartButton.Text = "Pie Chart";
            this.PieChartButton.UseVisualStyleBackColor = true;
            this.PieChartButton.Click += new System.EventHandler(this.PieChartButton_Click);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 370);
            this.Controls.Add(this.PieChartButton);
            this.Controls.Add(this.RandomGameButton);
            this.Controls.Add(this.GamesDatabaseButton);
            this.Controls.Add(this.LogOutButton);
            this.Name = "DirectoryForm";
            this.Text = "DirectoryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DirectoryForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button GamesDatabaseButton;
        private System.Windows.Forms.Button RandomGameButton;
        private System.Windows.Forms.Button PieChartButton;
    }
}