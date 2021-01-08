namespace QuanLyKhachSan
{
    partial class frmRentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentList));
            this.dtgvRentList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillPayment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExtendMore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdName = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdIdentityCard = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIdentityCard = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRentList
            // 
            this.dtgvRentList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvRentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvRentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRentList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvRentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SoCMND,
            this.MaPhong,
            this.NgayThue,
            this.SoNgayThue,
            this.BillPayment,
            this.ExtendMore});
            this.dtgvRentList.DoubleBuffered = true;
            this.dtgvRentList.EnableHeadersVisualStyles = false;
            this.dtgvRentList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.dtgvRentList.HeaderForeColor = System.Drawing.Color.White;
            this.dtgvRentList.Location = new System.Drawing.Point(0, 60);
            this.dtgvRentList.Name = "dtgvRentList";
            this.dtgvRentList.ReadOnly = true;
            this.dtgvRentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvRentList.RowTemplate.Height = 24;
            this.dtgvRentList.Size = new System.Drawing.Size(1141, 585);
            this.dtgvRentList.TabIndex = 0;
            this.dtgvRentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRentList_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.FillWeight = 112.7138F;
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // SoCMND
            // 
            this.SoCMND.DataPropertyName = "SoCMND";
            this.SoCMND.FillWeight = 122.96F;
            this.SoCMND.HeaderText = "Số CMND";
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.FillWeight = 86.4661F;
            this.MaPhong.HeaderText = "Phòng Thuê";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // NgayThue
            // 
            this.NgayThue.DataPropertyName = "NgayThue";
            this.NgayThue.FillWeight = 122.96F;
            this.NgayThue.HeaderText = "Ngày Thuê";
            this.NgayThue.Name = "NgayThue";
            this.NgayThue.ReadOnly = true;
            // 
            // SoNgayThue
            // 
            this.SoNgayThue.DataPropertyName = "SoNgayThue";
            this.SoNgayThue.FillWeight = 85.57973F;
            this.SoNgayThue.HeaderText = "Số Ngày Thuê";
            this.SoNgayThue.Name = "SoNgayThue";
            this.SoNgayThue.ReadOnly = true;
            // 
            // BillPayment
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("VNI-Hobo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.BillPayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillPayment.HeaderText = "";
            this.BillPayment.Name = "BillPayment";
            this.BillPayment.ReadOnly = true;
            this.BillPayment.Text = "Payment";
            this.BillPayment.UseColumnTextForButtonValue = true;
            // 
            // ExtendMore
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("VNI-Hobo", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ExtendMore.DefaultCellStyle = dataGridViewCellStyle4;
            this.ExtendMore.HeaderText = "";
            this.ExtendMore.Name = "ExtendMore";
            this.ExtendMore.ReadOnly = true;
            this.ExtendMore.Text = "Extend More";
            this.ExtendMore.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 5);
            this.panel1.TabIndex = 2;
            // 
            // txbSearch
            // 
            this.txbSearch.AutoRoundedCorners = true;
            this.txbSearch.BackColor = System.Drawing.Color.Transparent;
            this.txbSearch.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txbSearch.BorderRadius = 19;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.Parent = this.txbSearch;
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.Enabled = false;
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txbSearch.FocusedState.Parent = this.txbSearch;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbSearch.HoverState.Parent = this.txbSearch;
            this.txbSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbSearch.IconLeft")));
            this.txbSearch.IconLeftOffset = new System.Drawing.Point(12, 0);
            this.txbSearch.Location = new System.Drawing.Point(13, 12);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSearch.PlaceholderText = "Search here";
            this.txbSearch.SelectedText = "";
            this.txbSearch.ShadowDecoration.BorderRadius = 26;
            this.txbSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSearch.ShadowDecoration.Depth = 20;
            this.txbSearch.ShadowDecoration.Enabled = true;
            this.txbSearch.ShadowDecoration.Parent = this.txbSearch;
            this.txbSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.txbSearch.Size = new System.Drawing.Size(416, 41);
            this.txbSearch.TabIndex = 31;
            this.txbSearch.TextOffset = new System.Drawing.Point(7, 0);
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // rdName
            // 
            this.rdName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName.CheckedState.BorderThickness = 0;
            this.rdName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdName.CheckedState.Parent = this.rdName;
            this.rdName.Location = new System.Drawing.Point(577, 25);
            this.rdName.Name = "rdName";
            this.rdName.ShadowDecoration.Parent = this.rdName;
            this.rdName.Size = new System.Drawing.Size(20, 20);
            this.rdName.TabIndex = 37;
            this.rdName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdName.UncheckedState.BorderThickness = 2;
            this.rdName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdName.UncheckedState.Parent = this.rdName;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // rdIdentityCard
            // 
            this.rdIdentityCard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdIdentityCard.CheckedState.BorderThickness = 0;
            this.rdIdentityCard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdIdentityCard.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdIdentityCard.CheckedState.Parent = this.rdIdentityCard;
            this.rdIdentityCard.Location = new System.Drawing.Point(450, 25);
            this.rdIdentityCard.Name = "rdIdentityCard";
            this.rdIdentityCard.ShadowDecoration.Parent = this.rdIdentityCard;
            this.rdIdentityCard.Size = new System.Drawing.Size(20, 20);
            this.rdIdentityCard.TabIndex = 38;
            this.rdIdentityCard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdIdentityCard.UncheckedState.BorderThickness = 2;
            this.rdIdentityCard.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdIdentityCard.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdIdentityCard.UncheckedState.Parent = this.rdIdentityCard;
            this.rdIdentityCard.CheckedChanged += new System.EventHandler(this.rdIdentityCard_CheckedChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lbName.Location = new System.Drawing.Point(613, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 17);
            this.lbName.TabIndex = 35;
            this.lbName.Text = "Tên Khách Hàng";
            // 
            // lbIdentityCard
            // 
            this.lbIdentityCard.AutoSize = true;
            this.lbIdentityCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lbIdentityCard.Location = new System.Drawing.Point(479, 27);
            this.lbIdentityCard.Name = "lbIdentityCard";
            this.lbIdentityCard.Size = new System.Drawing.Size(69, 17);
            this.lbIdentityCard.TabIndex = 36;
            this.lbIdentityCard.Text = "Số CMND";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmRentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 649);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.rdIdentityCard);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbIdentityCard);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvRentList);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRentList";
            this.Text = "frmRentList";
            this.Load += new System.EventHandler(this.frmRentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvRentList;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdName;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdIdentityCard;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIdentityCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayThue;
        private System.Windows.Forms.DataGridViewButtonColumn BillPayment;
        private System.Windows.Forms.DataGridViewButtonColumn ExtendMore;
    }
}