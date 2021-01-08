namespace QuanLyKhachSan
{
    partial class frmQuanLyPhongKS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhongKS));
            this.plMain = new System.Windows.Forms.Panel();
            this.lbinfoRoom = new System.Windows.Forms.Label();
            this.dtgvListRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbTypeRoom = new System.Windows.Forms.Label();
            this.lbRoomNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTyperoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ptImageroom = new System.Windows.Forms.PictureBox();
            this.txbSeacrh = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListRoom)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImageroom)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.AutoScroll = true;
            this.plMain.Controls.Add(this.lbinfoRoom);
            this.plMain.Controls.Add(this.dtgvListRoom);
            this.plMain.Controls.Add(this.guna2GroupBox1);
            this.plMain.Controls.Add(this.label4);
            this.plMain.Controls.Add(this.label2);
            this.plMain.Controls.Add(this.label3);
            this.plMain.Controls.Add(this.cbStatus);
            this.plMain.Controls.Add(this.cbTyperoom);
            this.plMain.Controls.Add(this.ptImageroom);
            this.plMain.Controls.Add(this.txbSeacrh);
            this.plMain.Controls.Add(this.panel1);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(0, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1141, 649);
            this.plMain.TabIndex = 1;
            // 
            // lbinfoRoom
            // 
            this.lbinfoRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbinfoRoom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfoRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbinfoRoom.Location = new System.Drawing.Point(660, 53);
            this.lbinfoRoom.Name = "lbinfoRoom";
            this.lbinfoRoom.Size = new System.Drawing.Size(469, 379);
            this.lbinfoRoom.TabIndex = 0;
            this.lbinfoRoom.Text = "NULL";
            // 
            // dtgvListRoom
            // 
            this.dtgvListRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgvListRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvListRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvListRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListRoom.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvListRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvListRoom.ColumnHeadersHeight = 40;
            this.dtgvListRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.DonGia,
            this.TinhTrang});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListRoom.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvListRoom.EnableHeadersVisualStyles = false;
            this.dtgvListRoom.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvListRoom.Location = new System.Drawing.Point(4, 477);
            this.dtgvListRoom.Name = "dtgvListRoom";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvListRoom.RowHeadersVisible = false;
            this.dtgvListRoom.RowTemplate.DividerHeight = 1;
            this.dtgvListRoom.RowTemplate.Height = 24;
            this.dtgvListRoom.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListRoom.Size = new System.Drawing.Size(1125, 172);
            this.dtgvListRoom.TabIndex = 36;
            this.dtgvListRoom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListRoom.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dtgvListRoom.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvListRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvListRoom.ThemeStyle.ReadOnly = false;
            this.dtgvListRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvListRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvListRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvListRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListRoom_CellContentClick);
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.FillWeight = 63.356F;
            this.MaPhong.HeaderText = "Code";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.FillWeight = 101.5228F;
            this.LoaiPhong.HeaderText = "Type Room";
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.FillWeight = 117.5606F;
            this.DonGia.HeaderText = "Unit Price";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.FillWeight = 117.5606F;
            this.TinhTrang.HeaderText = "Status";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2GroupBox1.Controls.Add(this.btnAddRoom);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.lbStatus);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.lbUnitPrice);
            this.guna2GroupBox1.Controls.Add(this.lbTypeRoom);
            this.guna2GroupBox1.Controls.Add(this.lbRoomNum);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Tomato;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 247);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(641, 185);
            this.guna2GroupBox1.TabIndex = 35;
            this.guna2GroupBox1.Text = "THÔNG TIN PHÒNG";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Location = new System.Drawing.Point(9, 137);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(133, 38);
            this.btnAddRoom.TabIndex = 39;
            this.btnAddRoom.Text = "ADD ROOM";
            this.btnAddRoom.Click += new System.EventHandler(this.atmAddRoom_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(388, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(23, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Unit Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Room Code :";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbStatus.Location = new System.Drawing.Point(488, 100);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 23);
            this.lbStatus.TabIndex = 33;
            this.lbStatus.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(244, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "VNĐ";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbUnitPrice.Location = new System.Drawing.Point(154, 100);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(53, 23);
            this.lbUnitPrice.TabIndex = 33;
            this.lbUnitPrice.Text = "NULL";
            // 
            // lbTypeRoom
            // 
            this.lbTypeRoom.AutoSize = true;
            this.lbTypeRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeRoom.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTypeRoom.Location = new System.Drawing.Point(488, 52);
            this.lbTypeRoom.Name = "lbTypeRoom";
            this.lbTypeRoom.Size = new System.Drawing.Size(53, 23);
            this.lbTypeRoom.TabIndex = 33;
            this.lbTypeRoom.Text = "NULL";
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbRoomNum.Location = new System.Drawing.Point(156, 52);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(53, 23);
            this.lbRoomNum.TabIndex = 33;
            this.lbRoomNum.Text = "NULL";
            this.lbRoomNum.TextChanged += new System.EventHandler(this.lbRoomNum_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(801, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "THÔNG TIN CHI TIẾT";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(568, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "LOẠI PHÒNG";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(856, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "TÌNH TRẠNG";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.Parent = this.cbStatus;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.HoverState.Parent = this.cbStatus;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "Chưa Thuê",
            "Đã Thuê"});
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(968, 435);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(158, 36);
            this.cbStatus.TabIndex = 32;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbTyperoom
            // 
            this.cbTyperoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTyperoom.BackColor = System.Drawing.Color.Transparent;
            this.cbTyperoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTyperoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTyperoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTyperoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTyperoom.FocusedState.Parent = this.cbTyperoom;
            this.cbTyperoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTyperoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTyperoom.HoverState.Parent = this.cbTyperoom;
            this.cbTyperoom.ItemHeight = 30;
            this.cbTyperoom.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTyperoom.ItemsAppearance.Parent = this.cbTyperoom;
            this.cbTyperoom.Location = new System.Drawing.Point(680, 435);
            this.cbTyperoom.Name = "cbTyperoom";
            this.cbTyperoom.ShadowDecoration.Parent = this.cbTyperoom;
            this.cbTyperoom.Size = new System.Drawing.Size(158, 36);
            this.cbTyperoom.TabIndex = 32;
            this.cbTyperoom.SelectedIndexChanged += new System.EventHandler(this.cbTyperoom_SelectedIndexChanged);
            // 
            // ptImageroom
            // 
            this.ptImageroom.Image = ((System.Drawing.Image)(resources.GetObject("ptImageroom.Image")));
            this.ptImageroom.Location = new System.Drawing.Point(12, 17);
            this.ptImageroom.Name = "ptImageroom";
            this.ptImageroom.Size = new System.Drawing.Size(641, 228);
            this.ptImageroom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptImageroom.TabIndex = 36;
            this.ptImageroom.TabStop = false;
            // 
            // txbSeacrh
            // 
            this.txbSeacrh.AutoRoundedCorners = true;
            this.txbSeacrh.BackColor = System.Drawing.Color.Transparent;
            this.txbSeacrh.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.txbSeacrh.BorderRadius = 18;
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
            this.txbSeacrh.Location = new System.Drawing.Point(4, 435);
            this.txbSeacrh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSeacrh.Name = "txbSeacrh";
            this.txbSeacrh.PasswordChar = '\0';
            this.txbSeacrh.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSeacrh.PlaceholderText = "Search by Room Code";
            this.txbSeacrh.SelectedText = "";
            this.txbSeacrh.ShadowDecoration.BorderRadius = 26;
            this.txbSeacrh.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSeacrh.ShadowDecoration.Depth = 20;
            this.txbSeacrh.ShadowDecoration.Enabled = true;
            this.txbSeacrh.ShadowDecoration.Parent = this.txbSeacrh;
            this.txbSeacrh.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.txbSeacrh.Size = new System.Drawing.Size(405, 38);
            this.txbSeacrh.TabIndex = 30;
            this.txbSeacrh.TextOffset = new System.Drawing.Point(7, 0);
            this.txbSeacrh.TextChanged += new System.EventHandler(this.txbSeacrh_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 5);
            this.panel1.TabIndex = 1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(346, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Type Room :";
            // 
            // frmQuanLyPhongKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1141, 649);
            this.Controls.Add(this.plMain);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyPhongKS";
            this.Text = "frmQuanLyPhongKS";
            this.Load += new System.EventHandler(this.frmQuanLyPhongKS_Load);
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListRoom)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImageroom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Guna.UI2.WinForms.Guna2TextBox txbSeacrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbTyperoom;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.PictureBox ptImageroom;
        private System.Windows.Forms.Label lbinfoRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbTypeRoom;
        private System.Windows.Forms.Label lbRoomNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListRoom;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddRoom;
        private System.Windows.Forms.Label label8;
    }
}