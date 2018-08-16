namespace GamesDatabaseApplication
{
    partial class PieChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BackButton = new System.Windows.Forms.Button();
            this.Completion = new System.Windows.Forms.Button();
            this.Platform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(633, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(661, 390);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(134, 48);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Completion
            // 
            this.Completion.Location = new System.Drawing.Point(661, 12);
            this.Completion.Name = "Completion";
            this.Completion.Size = new System.Drawing.Size(134, 67);
            this.Completion.TabIndex = 2;
            this.Completion.Text = "Games Completion";
            this.Completion.UseVisualStyleBackColor = true;
            this.Completion.Click += new System.EventHandler(this.Completion_Click);
            // 
            // Platform
            // 
            this.Platform.Location = new System.Drawing.Point(661, 98);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(134, 56);
            this.Platform.TabIndex = 3;
            this.Platform.Text = "Platform";
            this.Platform.UseVisualStyleBackColor = true;
            this.Platform.Click += new System.EventHandler(this.Platform_Click);
            // 
            // PieChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Platform);
            this.Controls.Add(this.Completion);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.chart1);
            this.Name = "PieChartForm";
            this.Text = "PieChartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PieChartForm_FormClosed);
            this.Load += new System.EventHandler(this.PieChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Completion;
        private System.Windows.Forms.Button Platform;
    }
}