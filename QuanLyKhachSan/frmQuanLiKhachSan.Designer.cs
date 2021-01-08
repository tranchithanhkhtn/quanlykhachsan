namespace QuanLyKhachSan
{
    partial class frmQuanLiKhachSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiKhachSan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptSlider = new System.Windows.Forms.PictureBox();
            this.btnSalesAnalysis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfFoodList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfRentList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfRoomList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.plMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.ptClose);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 38);
            this.panel1.TabIndex = 0;
            // 
            // ptClose
            // 
            this.ptClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(2, 4);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(30, 30);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 34;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(965, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(215, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Quản Lý Khách Sạn - Marriott";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptSlider);
            this.panel2.Controls.Add(this.btnSalesAnalysis);
            this.panel2.Controls.Add(this.bfFoodList);
            this.panel2.Controls.Add(this.bfRentList);
            this.panel2.Controls.Add(this.bfRoomList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 44);
            this.panel2.TabIndex = 1;
            // 
            // ptSlider
            // 
            this.ptSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.ptSlider.Location = new System.Drawing.Point(15, 39);
            this.ptSlider.Name = "ptSlider";
            this.ptSlider.Size = new System.Drawing.Size(135, 10);
            this.ptSlider.TabIndex = 3;
            this.ptSlider.TabStop = false;
            // 
            // btnSalesAnalysis
            // 
            this.btnSalesAnalysis.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesAnalysis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesAnalysis.BorderRadius = 0;
            this.btnSalesAnalysis.ButtonText = "Sales Analysis";
            this.btnSalesAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesAnalysis.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalesAnalysis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalesAnalysis.Iconimage = null;
            this.btnSalesAnalysis.Iconimage_right = null;
            this.btnSalesAnalysis.Iconimage_right_Selected = null;
            this.btnSalesAnalysis.Iconimage_Selected = null;
            this.btnSalesAnalysis.IconMarginLeft = 0;
            this.btnSalesAnalysis.IconMarginRight = 0;
            this.btnSalesAnalysis.IconRightVisible = true;
            this.btnSalesAnalysis.IconRightZoom = 0D;
            this.btnSalesAnalysis.IconVisible = true;
            this.btnSalesAnalysis.IconZoom = 90D;
            this.btnSalesAnalysis.IsTab = false;
            this.btnSalesAnalysis.Location = new System.Drawing.Point(301, 9);
            this.btnSalesAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalesAnalysis.Name = "btnSalesAnalysis";
            this.btnSalesAnalysis.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesAnalysis.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesAnalysis.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnSalesAnalysis.selected = false;
            this.btnSalesAnalysis.Size = new System.Drawing.Size(135, 28);
            this.btnSalesAnalysis.TabIndex = 3;
            this.btnSalesAnalysis.Text = "Sales Analysis";
            this.btnSalesAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalesAnalysis.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnSalesAnalysis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesAnalysis.Click += new System.EventHandler(this.btnSalesAnalysis_Click);
            // 
            // bfFoodList
            // 
            this.bfFoodList.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfFoodList.BorderRadius = 0;
            this.bfFoodList.ButtonText = "Food List";
            this.bfFoodList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfFoodList.DisabledColor = System.Drawing.Color.Gray;
            this.bfFoodList.Iconcolor = System.Drawing.Color.Transparent;
            this.bfFoodList.Iconimage = null;
            this.bfFoodList.Iconimage_right = null;
            this.bfFoodList.Iconimage_right_Selected = null;
            this.bfFoodList.Iconimage_Selected = null;
            this.bfFoodList.IconMarginLeft = 0;
            this.bfFoodList.IconMarginRight = 0;
            this.bfFoodList.IconRightVisible = true;
            this.bfFoodList.IconRightZoom = 0D;
            this.bfFoodList.IconVisible = true;
            this.bfFoodList.IconZoom = 90D;
            this.bfFoodList.IsTab = false;
            this.bfFoodList.Location = new System.Drawing.Point(444, 9);
            this.bfFoodList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfFoodList.Name = "bfFoodList";
            this.bfFoodList.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfFoodList.selected = false;
            this.bfFoodList.Size = new System.Drawing.Size(135, 28);
            this.bfFoodList.TabIndex = 3;
            this.bfFoodList.Text = "Food List";
            this.bfFoodList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfFoodList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfFoodList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfFoodList.Click += new System.EventHandler(this.bfFoodList_Click);
            // 
            // bfRentList
            // 
            this.bfRentList.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bfRentList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bfRentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfRentList.BorderRadius = 0;
            this.bfRentList.ButtonText = "Rent List";
            this.bfRentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfRentList.DisabledColor = System.Drawing.Color.Gray;
            this.bfRentList.Iconcolor = System.Drawing.Color.Transparent;
            this.bfRentList.Iconimage = null;
            this.bfRentList.Iconimage_right = null;
            this.bfRentList.Iconimage_right_Selected = null;
            this.bfRentList.Iconimage_Selected = null;
            this.bfRentList.IconMarginLeft = 0;
            this.bfRentList.IconMarginRight = 0;
            this.bfRentList.IconRightVisible = true;
            this.bfRentList.IconRightZoom = 0D;
            this.bfRentList.IconVisible = true;
            this.bfRentList.IconZoom = 90D;
            this.bfRentList.IsTab = false;
            this.bfRentList.Location = new System.Drawing.Point(158, 7);
            this.bfRentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfRentList.Name = "bfRentList";
            this.bfRentList.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bfRentList.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bfRentList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfRentList.selected = false;
            this.bfRentList.Size = new System.Drawing.Size(135, 28);
            this.bfRentList.TabIndex = 1;
            this.bfRentList.Text = "Rent List";
            this.bfRentList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfRentList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfRentList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfRentList.Click += new System.EventHandler(this.bfRentList_Click);
            // 
            // bfRoomList
            // 
            this.bfRoomList.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bfRoomList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bfRoomList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfRoomList.BorderRadius = 0;
            this.bfRoomList.ButtonText = "Room List";
            this.bfRoomList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfRoomList.DisabledColor = System.Drawing.Color.Gray;
            this.bfRoomList.Iconcolor = System.Drawing.Color.Transparent;
            this.bfRoomList.Iconimage = null;
            this.bfRoomList.Iconimage_right = null;
            this.bfRoomList.Iconimage_right_Selected = null;
            this.bfRoomList.Iconimage_Selected = null;
            this.bfRoomList.IconMarginLeft = 5;
            this.bfRoomList.IconMarginRight = 0;
            this.bfRoomList.IconRightVisible = true;
            this.bfRoomList.IconRightZoom = 0D;
            this.bfRoomList.IconVisible = true;
            this.bfRoomList.IconZoom = 40D;
            this.bfRoomList.IsTab = false;
            this.bfRoomList.Location = new System.Drawing.Point(15, 7);
            this.bfRoomList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfRoomList.Name = "bfRoomList";
            this.bfRoomList.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bfRoomList.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bfRoomList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfRoomList.selected = false;
            this.bfRoomList.Size = new System.Drawing.Size(135, 28);
            this.bfRoomList.TabIndex = 0;
            this.bfRoomList.Text = "Room List";
            this.bfRoomList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfRoomList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfRoomList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfRoomList.Click += new System.EventHandler(this.bfRoomList_Click);
            // 
            // plMain
            // 
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 82);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1141, 649);
            this.plMain.TabIndex = 2;
            // 
            // frmQuanLiKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1141, 731);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLiKhachSan";
            this.Text = "frmQuanLiKhachSan";
            this.Load += new System.EventHandler(this.frmQuanLiKhachSan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptSlider;
        private Bunifu.Framework.UI.BunifuFlatButton bfRentList;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.PictureBox ptClose;
        private Bunifu.Framework.UI.BunifuFlatButton bfRoomList;
        public Bunifu.Framework.UI.BunifuFlatButton bfFoodList;
        public Bunifu.Framework.UI.BunifuFlatButton btnSalesAnalysis;
    }
}