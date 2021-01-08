namespace QuanLyKhachSan
{
    partial class Item_HistoryFoods
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNameCustomer = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNameCustomer
            // 
            this.lbNameCustomer.AutoSize = true;
            this.lbNameCustomer.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCustomer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbNameCustomer.Location = new System.Drawing.Point(19, 11);
            this.lbNameCustomer.Name = "lbNameCustomer";
            this.lbNameCustomer.Size = new System.Drawing.Size(44, 19);
            this.lbNameCustomer.TabIndex = 48;
            this.lbNameCustomer.Text = "NULL";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbAmount.Location = new System.Drawing.Point(227, 11);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(44, 19);
            this.lbAmount.TabIndex = 48;
            this.lbAmount.Text = "NULL";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbPrice.Location = new System.Drawing.Point(325, 11);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 19);
            this.lbPrice.TabIndex = 48;
            this.lbPrice.Text = "NULL";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTotalPrice.Location = new System.Drawing.Point(450, 11);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(44, 19);
            this.lbTotalPrice.TabIndex = 48;
            this.lbTotalPrice.Text = "NULL";
            // 
            // Item_HistoryFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbNameCustomer);
            this.Name = "Item_HistoryFoods";
            this.Size = new System.Drawing.Size(622, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameCustomer;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTotalPrice;
    }
}
