namespace QuanLyKhachSan
{
    partial class Item_ListFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_ListFood));
            this.lbNameFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameFood
            // 
            this.lbNameFood.BackColor = System.Drawing.Color.Transparent;
            this.lbNameFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.lbNameFood.Location = new System.Drawing.Point(73, 7);
            this.lbNameFood.Name = "lbNameFood";
            this.lbNameFood.Size = new System.Drawing.Size(27, 18);
            this.lbNameFood.TabIndex = 1;
            this.lbNameFood.Text = "???";
            // 
            // ptDelete
            // 
            this.ptDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptDelete.Image")));
            this.ptDelete.Location = new System.Drawing.Point(11, 14);
            this.ptDelete.Name = "ptDelete";
            this.ptDelete.ShadowDecoration.Parent = this.ptDelete;
            this.ptDelete.Size = new System.Drawing.Size(28, 28);
            this.ptDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptDelete.TabIndex = 2;
            this.ptDelete.TabStop = false;
            // 
            // lbMoney
            // 
            this.lbMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbMoney.Location = new System.Drawing.Point(73, 34);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(24, 18);
            this.lbMoney.TabIndex = 1;
            this.lbMoney.Text = "???";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalMoney.Location = new System.Drawing.Point(324, 19);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(10, 18);
            this.lbTotalMoney.TabIndex = 1;
            this.lbTotalMoney.Text = "0";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.lbCount.Location = new System.Drawing.Point(245, 19);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(17, 17);
            this.lbCount.TabIndex = 3;
            this.lbCount.Text = "1";
            this.lbCount.TextChanged += new System.EventHandler(this.lbCount_TextChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlus.CheckedState.Parent = this.btnPlus;
            this.btnPlus.CustomImages.Parent = this.btnPlus;
            this.btnPlus.FillColor = System.Drawing.SystemColors.Control;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlus.ForeColor = System.Drawing.Color.Red;
            this.btnPlus.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnPlus.HoverState.ForeColor = System.Drawing.Color.Blue;
            this.btnPlus.HoverState.Parent = this.btnPlus;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(269, 0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ShadowDecoration.Parent = this.btnPlus;
            this.btnPlus.Size = new System.Drawing.Size(28, 28);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinus.CheckedState.Parent = this.btnMinus;
            this.btnMinus.CustomImages.Parent = this.btnMinus;
            this.btnMinus.Enabled = false;
            this.btnMinus.FillColor = System.Drawing.SystemColors.Control;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinus.ForeColor = System.Drawing.Color.Red;
            this.btnMinus.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnMinus.HoverState.ForeColor = System.Drawing.Color.Blue;
            this.btnMinus.HoverState.Parent = this.btnMinus;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(269, 27);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ShadowDecoration.Parent = this.btnMinus;
            this.btnMinus.Size = new System.Drawing.Size(28, 28);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(130, 34);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(32, 18);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "VND";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(375, 19);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(32, 18);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "VND";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(218, 19);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(25, 18);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "SL:";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 61);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(440, 1);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(386, -1);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(44, 17);
            this.lbType.TabIndex = 8;
            this.lbType.Text = "Temp";
            this.lbType.Visible = false;
            // 
            // Item_ListFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.ptDelete);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lbNameFood);
            this.Name = "Item_ListFood";
            this.Size = new System.Drawing.Size(433, 62);
            this.Load += new System.EventHandler(this.Item_ListFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lbMoney;
        public Guna.UI2.WinForms.Guna2PictureBox ptDelete;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbNameFood;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbTotalMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public System.Windows.Forms.Label lbCount;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        public Guna.UI2.WinForms.Guna2Button btnPlus;
        public Guna.UI2.WinForms.Guna2Button btnMinus;
        private System.Windows.Forms.Label lbType;
    }
}
