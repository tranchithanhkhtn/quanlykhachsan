﻿namespace QuanLyKhachSan
{
    partial class frmRevenue
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRental = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRental)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRental
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRental.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRental.Legends.Add(legend1);
            this.chartRental.Location = new System.Drawing.Point(12, 12);
            this.chartRental.Name = "chartRental";
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "SL Phiếu Thuê";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tháng";
            this.chartRental.Series.Add(series1);
            this.chartRental.Series.Add(series2);
            this.chartRental.Size = new System.Drawing.Size(988, 480);
            this.chartRental.TabIndex = 0;
            this.chartRental.Text = "chart1";
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 504);
            this.Controls.Add(this.chartRental);
            this.MaximumSize = new System.Drawing.Size(1030, 551);
            this.MinimumSize = new System.Drawing.Size(1030, 551);
            this.Name = "frmRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.frmRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRental)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRental;
    }
}