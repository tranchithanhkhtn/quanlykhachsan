namespace QuanLyKhachSan
{
    partial class frmListCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvListCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSeacrh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.lbIdentityCard = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbDayofBirth = new System.Windows.Forms.Label();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).BeginInit();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 5);
            this.panel1.TabIndex = 3;
            // 
            // dtgvListCustomer
            // 
            this.dtgvListCustomer.AllowUserToAddRows = false;
            this.dtgvListCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvListCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListCustomer.ColumnHeadersHeight = 40;
            this.dtgvListCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.SoCMND,
            this.TenKH,
            this.NgSinh,
            this.DiaChiTT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListCustomer.EnableHeadersVisualStyles = false;
            this.dtgvListCustomer.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvListCustomer.Location = new System.Drawing.Point(8, 285);
            this.dtgvListCustomer.Name = "dtgvListCustomer";
            this.dtgvListCustomer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvListCustomer.RowHeadersVisible = false;
            this.dtgvListCustomer.RowTemplate.DividerHeight = 1;
            this.dtgvListCustomer.RowTemplate.Height = 24;
            this.dtgvListCustomer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListCustomer.Size = new System.Drawing.Size(1155, 364);
            this.dtgvListCustomer.TabIndex = 52;
            this.dtgvListCustomer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListCustomer.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvListCustomer.ThemeStyle.ReadOnly = true;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListCustomer_CellContentClick);
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.lbAddress);
            this.gbMain.Controls.Add(this.txbSeacrh);
            this.gbMain.Controls.Add(this.label5);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.lbDayofBirth);
            this.gbMain.Controls.Add(this.lbFullName);
            this.gbMain.Controls.Add(this.lbIdentityCard);
            this.gbMain.Controls.Add(this.lbCustomerID);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.gbMain.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.ForeColor = System.Drawing.Color.White;
            this.gbMain.Location = new System.Drawing.Point(3, 6);
            this.gbMain.Name = "gbMain";
            this.gbMain.ShadowDecoration.Parent = this.gbMain;
            this.gbMain.Size = new System.Drawing.Size(1161, 273);
            this.gbMain.TabIndex = 53;
            this.gbMain.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(140, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Identity Card :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Customer ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(160, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "Full Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(145, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "Day of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(650, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "Address :";
            // 
            // txbSeacrh
            // 
            this.txbSeacrh.AutoRoundedCorners = true;
            this.txbSeacrh.BackColor = System.Drawing.Color.Transparent;
            this.txbSeacrh.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txbSeacrh.BorderRadius = 16;
            this.txbSeacrh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSeacrh.DefaultText = "";
            this.txbSeacrh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSeacrh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSeacrh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSeacrh.DisabledState.Parent = this.txbSeacrh;
            this.txbSeacrh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSeacrh.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txbSeacrh.FocusedState.Parent = this.txbSeacrh;
            this.txbSeacrh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbSeacrh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSeacrh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txbSeacrh.HoverState.Parent = this.txbSeacrh;
            this.txbSeacrh.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbSeacrh.IconLeft")));
            this.txbSeacrh.IconLeftOffset = new System.Drawing.Point(12, 0);
            this.txbSeacrh.Location = new System.Drawing.Point(5, 235);
            this.txbSeacrh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSeacrh.Name = "txbSeacrh";
            this.txbSeacrh.PasswordChar = '\0';
            this.txbSeacrh.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSeacrh.PlaceholderText = "Search by Identity Card";
            this.txbSeacrh.SelectedText = "";
            this.txbSeacrh.ShadowDecoration.BorderRadius = 26;
            this.txbSeacrh.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSeacrh.ShadowDecoration.Depth = 20;
            this.txbSeacrh.ShadowDecoration.Enabled = true;
            this.txbSeacrh.ShadowDecoration.Parent = this.txbSeacrh;
            this.txbSeacrh.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.txbSeacrh.Size = new System.Drawing.Size(460, 34);
            this.txbSeacrh.TabIndex = 60;
            this.txbSeacrh.TextOffset = new System.Drawing.Point(7, 0);
            this.txbSeacrh.TextChanged += new System.EventHandler(this.txbSeacrh_TextChanged);
            // 
            // lbAddress
            // 
            this.lbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbAddress.Location = new System.Drawing.Point(743, 99);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(384, 156);
            this.lbAddress.TabIndex = 61;
            this.lbAddress.Text = "NULL";
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.BackColor = System.Drawing.Color.White;
            this.lbCustomerID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbCustomerID.Location = new System.Drawing.Point(143, 45);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(59, 22);
            this.lbCustomerID.TabIndex = 53;
            this.lbCustomerID.Text = "NULL";
            // 
            // lbIdentityCard
            // 
            this.lbIdentityCard.AutoSize = true;
            this.lbIdentityCard.BackColor = System.Drawing.Color.White;
            this.lbIdentityCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentityCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbIdentityCard.Location = new System.Drawing.Point(300, 99);
            this.lbIdentityCard.Name = "lbIdentityCard";
            this.lbIdentityCard.Size = new System.Drawing.Size(59, 22);
            this.lbIdentityCard.TabIndex = 53;
            this.lbIdentityCard.Text = "NULL";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.White;
            this.lbFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbFullName.Location = new System.Drawing.Point(300, 144);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(59, 22);
            this.lbFullName.TabIndex = 53;
            this.lbFullName.Text = "NULL";
            // 
            // lbDayofBirth
            // 
            this.lbDayofBirth.AutoSize = true;
            this.lbDayofBirth.BackColor = System.Drawing.Color.White;
            this.lbDayofBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayofBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbDayofBirth.Location = new System.Drawing.Point(300, 189);
            this.lbDayofBirth.Name = "lbDayofBirth";
            this.lbDayofBirth.Size = new System.Drawing.Size(59, 22);
            this.lbDayofBirth.TabIndex = 53;
            this.lbDayofBirth.Text = "NULL";
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.FillWeight = 69.77986F;
            this.MaKH.HeaderText = "Customer ID";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // SoCMND
            // 
            this.SoCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoCMND.DataPropertyName = "SoCMND";
            this.SoCMND.FillWeight = 111.8165F;
            this.SoCMND.HeaderText = "Identity Card";
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.FillWeight = 129.4804F;
            this.TenKH.HeaderText = "Full Name";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // NgSinh
            // 
            this.NgSinh.DataPropertyName = "NgSinh";
            this.NgSinh.FillWeight = 61.22327F;
            this.NgSinh.HeaderText = "DoB";
            this.NgSinh.Name = "NgSinh";
            this.NgSinh.ReadOnly = true;
            // 
            // DiaChiTT
            // 
            this.DiaChiTT.DataPropertyName = "DiaChiTT";
            this.DiaChiTT.FillWeight = 110.1393F;
            this.DiaChiTT.HeaderText = "Address";
            this.DiaChiTT.Name = "DiaChiTT";
            this.DiaChiTT.ReadOnly = true;
            // 
            // frmListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 649);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.dtgvListCustomer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListCustomer";
            this.Text = "frmListCustomer";
            this.Load += new System.EventHandler(this.frmListCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCustomer)).EndInit();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListCustomer;
        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txbSeacrh;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbDayofBirth;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbIdentityCard;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiTT;
    }
}