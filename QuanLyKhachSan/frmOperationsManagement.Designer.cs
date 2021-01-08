namespace QuanLyKhachSan
{
    partial class frmOperationsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperationsManagement));
            this.plMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptSlider = new System.Windows.Forms.PictureBox();
            this.bfFoodList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfFinance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfTransaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRoomManager = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnListCustomer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSlider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 82);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1141, 649);
            this.plMain.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.ptSlider);
            this.panel2.Controls.Add(this.btnListCustomer);
            this.panel2.Controls.Add(this.bfFoodList);
            this.panel2.Controls.Add(this.bfFinance);
            this.panel2.Controls.Add(this.bfTransaction);
            this.panel2.Controls.Add(this.btnRoomManager);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 44);
            this.panel2.TabIndex = 4;
            // 
            // ptSlider
            // 
            this.ptSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.ptSlider.Location = new System.Drawing.Point(15, 40);
            this.ptSlider.Name = "ptSlider";
            this.ptSlider.Size = new System.Drawing.Size(153, 10);
            this.ptSlider.TabIndex = 3;
            this.ptSlider.TabStop = false;
            // 
            // bfFoodList
            // 
            this.bfFoodList.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bfFoodList.BorderRadius = 0;
            this.bfFoodList.ButtonText = "Food Manager";
            this.bfFoodList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfFoodList.DisabledColor = System.Drawing.Color.Gray;
            this.bfFoodList.Iconcolor = System.Drawing.Color.Transparent;
            this.bfFoodList.Iconimage = null;
            this.bfFoodList.Iconimage_right = null;
            this.bfFoodList.Iconimage_right_Selected = null;
            this.bfFoodList.Iconimage_Selected = null;
            this.bfFoodList.IconMarginLeft = 1;
            this.bfFoodList.IconMarginRight = 0;
            this.bfFoodList.IconRightVisible = true;
            this.bfFoodList.IconRightZoom = 0D;
            this.bfFoodList.IconVisible = true;
            this.bfFoodList.IconZoom = 90D;
            this.bfFoodList.IsTab = false;
            this.bfFoodList.Location = new System.Drawing.Point(546, 7);
            this.bfFoodList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfFoodList.Name = "bfFoodList";
            this.bfFoodList.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bfFoodList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfFoodList.selected = false;
            this.bfFoodList.Size = new System.Drawing.Size(135, 28);
            this.bfFoodList.TabIndex = 3;
            this.bfFoodList.Text = "Food Manager";
            this.bfFoodList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfFoodList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfFoodList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfFoodList.Click += new System.EventHandler(this.bfFoodList_Click);
            // 
            // bfFinance
            // 
            this.bfFinance.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bfFinance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bfFinance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bfFinance.BorderRadius = 0;
            this.bfFinance.ButtonText = "Finance";
            this.bfFinance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfFinance.DisabledColor = System.Drawing.Color.Gray;
            this.bfFinance.Iconcolor = System.Drawing.Color.Transparent;
            this.bfFinance.Iconimage = null;
            this.bfFinance.Iconimage_right = null;
            this.bfFinance.Iconimage_right_Selected = null;
            this.bfFinance.Iconimage_Selected = null;
            this.bfFinance.IconMarginLeft = 1;
            this.bfFinance.IconMarginRight = 0;
            this.bfFinance.IconRightVisible = true;
            this.bfFinance.IconRightZoom = 0D;
            this.bfFinance.IconVisible = true;
            this.bfFinance.IconZoom = 90D;
            this.bfFinance.IsTab = false;
            this.bfFinance.Location = new System.Drawing.Point(401, 7);
            this.bfFinance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfFinance.Name = "bfFinance";
            this.bfFinance.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bfFinance.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bfFinance.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfFinance.selected = false;
            this.bfFinance.Size = new System.Drawing.Size(135, 28);
            this.bfFinance.TabIndex = 2;
            this.bfFinance.Text = "Finance";
            this.bfFinance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfFinance.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfFinance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfFinance.Click += new System.EventHandler(this.bfFinance_Click);
            // 
            // bfTransaction
            // 
            this.bfTransaction.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bfTransaction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bfTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bfTransaction.BorderRadius = 0;
            this.bfTransaction.ButtonText = "Transaction Invoice";
            this.bfTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfTransaction.DisabledColor = System.Drawing.Color.Gray;
            this.bfTransaction.Iconcolor = System.Drawing.Color.Transparent;
            this.bfTransaction.Iconimage = null;
            this.bfTransaction.Iconimage_right = null;
            this.bfTransaction.Iconimage_right_Selected = null;
            this.bfTransaction.Iconimage_Selected = null;
            this.bfTransaction.IconMarginLeft = 1;
            this.bfTransaction.IconMarginRight = 0;
            this.bfTransaction.IconRightVisible = true;
            this.bfTransaction.IconRightZoom = 0D;
            this.bfTransaction.IconVisible = true;
            this.bfTransaction.IconZoom = 90D;
            this.bfTransaction.IsTab = false;
            this.bfTransaction.Location = new System.Drawing.Point(178, 7);
            this.bfTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bfTransaction.Name = "bfTransaction";
            this.bfTransaction.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bfTransaction.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bfTransaction.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfTransaction.selected = false;
            this.bfTransaction.Size = new System.Drawing.Size(213, 28);
            this.bfTransaction.TabIndex = 1;
            this.bfTransaction.Text = "Transaction Invoice";
            this.bfTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfTransaction.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bfTransaction.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfTransaction.Click += new System.EventHandler(this.bfTransaction_Click);
            // 
            // btnRoomManager
            // 
            this.btnRoomManager.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnRoomManager.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoomManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoomManager.BorderRadius = 0;
            this.btnRoomManager.ButtonText = "Room Manager";
            this.btnRoomManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomManager.DisabledColor = System.Drawing.Color.Gray;
            this.btnRoomManager.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRoomManager.Iconimage = null;
            this.btnRoomManager.Iconimage_right = null;
            this.btnRoomManager.Iconimage_right_Selected = null;
            this.btnRoomManager.Iconimage_Selected = null;
            this.btnRoomManager.IconMarginLeft = 1;
            this.btnRoomManager.IconMarginRight = 0;
            this.btnRoomManager.IconRightVisible = true;
            this.btnRoomManager.IconRightZoom = 0D;
            this.btnRoomManager.IconVisible = true;
            this.btnRoomManager.IconZoom = 40D;
            this.btnRoomManager.IsTab = false;
            this.btnRoomManager.Location = new System.Drawing.Point(15, 7);
            this.btnRoomManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoomManager.Name = "btnRoomManager";
            this.btnRoomManager.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnRoomManager.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnRoomManager.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnRoomManager.selected = false;
            this.btnRoomManager.Size = new System.Drawing.Size(153, 28);
            this.btnRoomManager.TabIndex = 0;
            this.btnRoomManager.Text = "Room Manager";
            this.btnRoomManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRoomManager.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnRoomManager.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomManager.Click += new System.EventHandler(this.btnRoomManager_Click);
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
            this.panel1.TabIndex = 3;
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
            // btnListCustomer
            // 
            this.btnListCustomer.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnListCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnListCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListCustomer.BorderRadius = 0;
            this.btnListCustomer.ButtonText = "List Customer";
            this.btnListCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListCustomer.DisabledColor = System.Drawing.Color.Gray;
            this.btnListCustomer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnListCustomer.Iconimage = null;
            this.btnListCustomer.Iconimage_right = null;
            this.btnListCustomer.Iconimage_right_Selected = null;
            this.btnListCustomer.Iconimage_Selected = null;
            this.btnListCustomer.IconMarginLeft = 1;
            this.btnListCustomer.IconMarginRight = 0;
            this.btnListCustomer.IconRightVisible = true;
            this.btnListCustomer.IconRightZoom = 0D;
            this.btnListCustomer.IconVisible = true;
            this.btnListCustomer.IconZoom = 90D;
            this.btnListCustomer.IsTab = false;
            this.btnListCustomer.Location = new System.Drawing.Point(691, 7);
            this.btnListCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnListCustomer.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnListCustomer.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnListCustomer.selected = false;
            this.btnListCustomer.Size = new System.Drawing.Size(166, 28);
            this.btnListCustomer.TabIndex = 3;
            this.btnListCustomer.Text = "List Customer";
            this.btnListCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListCustomer.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnListCustomer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomer.Click += new System.EventHandler(this.btnListCustomer_Click);
            // 
            // frmOperationsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 731);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOperationsManagement";
            this.Text = "frmOperationsManagement";
            this.Load += new System.EventHandler(this.frmOperationsManagement_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptSlider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptSlider;
        public Bunifu.Framework.UI.BunifuFlatButton bfFoodList;
        private Bunifu.Framework.UI.BunifuFlatButton bfFinance;
        private Bunifu.Framework.UI.BunifuFlatButton bfTransaction;
        private Bunifu.Framework.UI.BunifuFlatButton btnRoomManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuFlatButton btnListCustomer;
    }
}