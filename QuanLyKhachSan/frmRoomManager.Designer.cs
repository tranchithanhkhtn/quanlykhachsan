namespace QuanLyKhachSan
{
    partial class frmRoomManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txbDescribe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbUnitPrice = new System.Windows.Forms.TextBox();
            this.cbTypeRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plRoomCode = new System.Windows.Forms.Panel();
            this.txbCodeRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteRoom = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvListRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSeacrh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.gbImage = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ptDelete4 = new System.Windows.Forms.PictureBox();
            this.ptDelete3 = new System.Windows.Forms.PictureBox();
            this.ptDelete2 = new System.Windows.Forms.PictureBox();
            this.ptDelete1 = new System.Windows.Forms.PictureBox();
            this.btnImage4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnImage3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnImage2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnImage1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ptImage4 = new System.Windows.Forms.PictureBox();
            this.ptImage3 = new System.Windows.Forms.PictureBox();
            this.ptImage2 = new System.Windows.Forms.PictureBox();
            this.ptImage1 = new System.Windows.Forms.PictureBox();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbMain.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListRoom)).BeginInit();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 5);
            this.panel1.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMain.Controls.Add(this.txbDescribe);
            this.gbMain.Controls.Add(this.label4);
            this.gbMain.Controls.Add(this.txbUnitPrice);
            this.gbMain.Controls.Add(this.cbTypeRoom);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.panel3);
            this.gbMain.Controls.Add(this.plRoomCode);
            this.gbMain.Controls.Add(this.txbCodeRoom);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.lbNote);
            this.gbMain.Controls.Add(this.label6);
            this.gbMain.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.gbMain.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMain.ForeColor = System.Drawing.Color.White;
            this.gbMain.Location = new System.Drawing.Point(0, 7);
            this.gbMain.Name = "gbMain";
            this.gbMain.ShadowDecoration.Parent = this.gbMain;
            this.gbMain.Size = new System.Drawing.Size(1161, 171);
            this.gbMain.TabIndex = 39;
            this.gbMain.Text = "Infomation";
            // 
            // txbDescribe
            // 
            this.txbDescribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDescribe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescribe.ForeColor = System.Drawing.Color.Silver;
            this.txbDescribe.Location = new System.Drawing.Point(674, 50);
            this.txbDescribe.Multiline = true;
            this.txbDescribe.Name = "txbDescribe";
            this.txbDescribe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDescribe.Size = new System.Drawing.Size(467, 109);
            this.txbDescribe.TabIndex = 3;
            this.txbDescribe.Text = "Enter Text. . .";
            this.txbDescribe.Enter += new System.EventHandler(this.txbDescribe_Enter);
            this.txbDescribe.Leave += new System.EventHandler(this.txbDescribe_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(596, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "Mô Tả";
            // 
            // txbUnitPrice
            // 
            this.txbUnitPrice.BackColor = System.Drawing.Color.White;
            this.txbUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUnitPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUnitPrice.ForeColor = System.Drawing.Color.Silver;
            this.txbUnitPrice.Location = new System.Drawing.Point(131, 119);
            this.txbUnitPrice.Name = "txbUnitPrice";
            this.txbUnitPrice.Size = new System.Drawing.Size(140, 21);
            this.txbUnitPrice.TabIndex = 1;
            this.txbUnitPrice.Text = "Enter Price";
            this.txbUnitPrice.Enter += new System.EventHandler(this.txbUnitPrice_Enter);
            this.txbUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUnitPrice_KeyPress);
            this.txbUnitPrice.Leave += new System.EventHandler(this.txbUnitPrice_Leave);
            // 
            // cbTypeRoom
            // 
            this.cbTypeRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeRoom.FocusedState.Parent = this.cbTypeRoom;
            this.cbTypeRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTypeRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeRoom.HoverState.Parent = this.cbTypeRoom;
            this.cbTypeRoom.ItemHeight = 30;
            this.cbTypeRoom.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTypeRoom.ItemsAppearance.Parent = this.cbTypeRoom;
            this.cbTypeRoom.Location = new System.Drawing.Point(452, 50);
            this.cbTypeRoom.Name = "cbTypeRoom";
            this.cbTypeRoom.ShadowDecoration.Parent = this.cbTypeRoom;
            this.cbTypeRoom.Size = new System.Drawing.Size(104, 36);
            this.cbTypeRoom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(333, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 52;
            this.label2.Text = "Loại Phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã Phòng :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(131, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 3);
            this.panel3.TabIndex = 62;
            // 
            // plRoomCode
            // 
            this.plRoomCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plRoomCode.Location = new System.Drawing.Point(131, 77);
            this.plRoomCode.Name = "plRoomCode";
            this.plRoomCode.Size = new System.Drawing.Size(140, 3);
            this.plRoomCode.TabIndex = 55;
            // 
            // txbCodeRoom
            // 
            this.txbCodeRoom.BackColor = System.Drawing.Color.White;
            this.txbCodeRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCodeRoom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodeRoom.ForeColor = System.Drawing.Color.Silver;
            this.txbCodeRoom.Location = new System.Drawing.Point(131, 51);
            this.txbCodeRoom.Name = "txbCodeRoom";
            this.txbCodeRoom.Size = new System.Drawing.Size(140, 21);
            this.txbCodeRoom.TabIndex = 0;
            this.txbCodeRoom.Text = "Enter Code";
            this.txbCodeRoom.Enter += new System.EventHandler(this.txbCodeRoom_Enter);
            this.txbCodeRoom.Leave += new System.EventHandler(this.txbCodeRoom_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(28, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "Đơn Giá :";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.BackColor = System.Drawing.Color.Transparent;
            this.lbNote.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.Red;
            this.lbNote.Location = new System.Drawing.Point(125, 85);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(41, 20);
            this.lbNote.TabIndex = 57;
            this.lbNote.Text = "Error";
            this.lbNote.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label6.Location = new System.Drawing.Point(274, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 60;
            this.label6.Text = "VND";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dtgvListRoom);
            this.panel4.Controls.Add(this.btnDeleteRoom);
            this.panel4.Controls.Add(this.txbSeacrh);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnAddRoom);
            this.panel4.Controls.Add(this.btnUpdateRoom);
            this.panel4.Location = new System.Drawing.Point(0, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1161, 238);
            this.panel4.TabIndex = 50;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRoom.AutoRoundedCorners = true;
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDeleteRoom.BorderRadius = 16;
            this.btnDeleteRoom.BorderThickness = 1;
            this.btnDeleteRoom.CheckedState.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.CustomImages.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteRoom.Font = new System.Drawing.Font(".VnCooper", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDeleteRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDeleteRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDeleteRoom.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.HoverState.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.Location = new System.Drawing.Point(580, 6);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.ShadowDecoration.BorderRadius = 26;
            this.btnDeleteRoom.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDeleteRoom.ShadowDecoration.Enabled = true;
            this.btnDeleteRoom.ShadowDecoration.Parent = this.btnDeleteRoom;
            this.btnDeleteRoom.Size = new System.Drawing.Size(151, 35);
            this.btnDeleteRoom.TabIndex = 41;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // dtgvListRoom
            // 
            this.dtgvListRoom.AllowUserToAddRows = false;
            this.dtgvListRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvListRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvListRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListRoom.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvListRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvListRoom.ColumnHeadersHeight = 40;
            this.dtgvListRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.LoaiPhong,
            this.DonGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvListRoom.EnableHeadersVisualStyles = false;
            this.dtgvListRoom.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvListRoom.Location = new System.Drawing.Point(3, 47);
            this.dtgvListRoom.Name = "dtgvListRoom";
            this.dtgvListRoom.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvListRoom.RowHeadersVisible = false;
            this.dtgvListRoom.RowTemplate.DividerHeight = 1;
            this.dtgvListRoom.RowTemplate.Height = 24;
            this.dtgvListRoom.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvListRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListRoom.Size = new System.Drawing.Size(1158, 191);
            this.dtgvListRoom.TabIndex = 51;
            this.dtgvListRoom.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvListRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvListRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListRoom.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvListRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvListRoom.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvListRoom.ThemeStyle.ReadOnly = true;
            this.dtgvListRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvListRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvListRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvListRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvListRoom.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvListRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvListRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txbSeacrh.Location = new System.Drawing.Point(9, 6);
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
            this.txbSeacrh.Size = new System.Drawing.Size(487, 34);
            this.txbSeacrh.TabIndex = 50;
            this.txbSeacrh.TextOffset = new System.Drawing.Point(7, 0);
            this.txbSeacrh.TextChanged += new System.EventHandler(this.txbSeacrh_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.BorderRadius = 16;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Font = new System.Drawing.Font(".VnCooper", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(759, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.BorderRadius = 26;
            this.btnUpdate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdate.ShadowDecoration.Enabled = true;
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(151, 35);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoom.AutoRoundedCorners = true;
            this.btnAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddRoom.BorderRadius = 16;
            this.btnAddRoom.BorderThickness = 1;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddRoom.Font = new System.Drawing.Font(".VnCooper", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddRoom.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Location = new System.Drawing.Point(934, 6);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.BorderRadius = 26;
            this.btnAddRoom.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddRoom.ShadowDecoration.Enabled = true;
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(151, 35);
            this.btnAddRoom.TabIndex = 41;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateRoom.AutoRoundedCorners = true;
            this.btnUpdateRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.BorderRadius = 16;
            this.btnUpdateRoom.BorderThickness = 1;
            this.btnUpdateRoom.CheckedState.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.CustomImages.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateRoom.Font = new System.Drawing.Font(".VnCooper", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoom.HoverState.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.Location = new System.Drawing.Point(759, 6);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.ShadowDecoration.BorderRadius = 26;
            this.btnUpdateRoom.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.ShadowDecoration.Enabled = true;
            this.btnUpdateRoom.ShadowDecoration.Parent = this.btnUpdateRoom;
            this.btnUpdateRoom.Size = new System.Drawing.Size(151, 35);
            this.btnUpdateRoom.TabIndex = 41;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // gbImage
            // 
            this.gbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImage.Controls.Add(this.ptDelete4);
            this.gbImage.Controls.Add(this.ptDelete3);
            this.gbImage.Controls.Add(this.ptDelete2);
            this.gbImage.Controls.Add(this.ptDelete1);
            this.gbImage.Controls.Add(this.btnImage4);
            this.gbImage.Controls.Add(this.btnImage3);
            this.gbImage.Controls.Add(this.btnImage2);
            this.gbImage.Controls.Add(this.btnImage1);
            this.gbImage.Controls.Add(this.ptImage4);
            this.gbImage.Controls.Add(this.ptImage3);
            this.gbImage.Controls.Add(this.ptImage2);
            this.gbImage.Controls.Add(this.ptImage1);
            this.gbImage.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.gbImage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImage.ForeColor = System.Drawing.Color.White;
            this.gbImage.Location = new System.Drawing.Point(0, 184);
            this.gbImage.Name = "gbImage";
            this.gbImage.ShadowDecoration.Parent = this.gbImage;
            this.gbImage.Size = new System.Drawing.Size(1161, 210);
            this.gbImage.TabIndex = 40;
            this.gbImage.Text = "Images Describe";
            // 
            // ptDelete4
            // 
            this.ptDelete4.Image = ((System.Drawing.Image)(resources.GetObject("ptDelete4.Image")));
            this.ptDelete4.Location = new System.Drawing.Point(1055, 171);
            this.ptDelete4.Name = "ptDelete4";
            this.ptDelete4.Size = new System.Drawing.Size(30, 33);
            this.ptDelete4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptDelete4.TabIndex = 2;
            this.ptDelete4.TabStop = false;
            this.ptDelete4.Visible = false;
            this.ptDelete4.Click += new System.EventHandler(this.ptDelete4_Click);
            // 
            // ptDelete3
            // 
            this.ptDelete3.Image = ((System.Drawing.Image)(resources.GetObject("ptDelete3.Image")));
            this.ptDelete3.Location = new System.Drawing.Point(779, 171);
            this.ptDelete3.Name = "ptDelete3";
            this.ptDelete3.Size = new System.Drawing.Size(30, 33);
            this.ptDelete3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptDelete3.TabIndex = 2;
            this.ptDelete3.TabStop = false;
            this.ptDelete3.Visible = false;
            this.ptDelete3.Click += new System.EventHandler(this.ptDelete3_Click);
            // 
            // ptDelete2
            // 
            this.ptDelete2.BackColor = System.Drawing.Color.Transparent;
            this.ptDelete2.Image = ((System.Drawing.Image)(resources.GetObject("ptDelete2.Image")));
            this.ptDelete2.Location = new System.Drawing.Point(504, 171);
            this.ptDelete2.Name = "ptDelete2";
            this.ptDelete2.Size = new System.Drawing.Size(30, 33);
            this.ptDelete2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptDelete2.TabIndex = 2;
            this.ptDelete2.TabStop = false;
            this.ptDelete2.Visible = false;
            this.ptDelete2.Click += new System.EventHandler(this.ptDelete2_Click);
            // 
            // ptDelete1
            // 
            this.ptDelete1.BackColor = System.Drawing.Color.Transparent;
            this.ptDelete1.Image = ((System.Drawing.Image)(resources.GetObject("ptDelete1.Image")));
            this.ptDelete1.Location = new System.Drawing.Point(229, 171);
            this.ptDelete1.Name = "ptDelete1";
            this.ptDelete1.Size = new System.Drawing.Size(30, 33);
            this.ptDelete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptDelete1.TabIndex = 2;
            this.ptDelete1.TabStop = false;
            this.ptDelete1.Visible = false;
            this.ptDelete1.Click += new System.EventHandler(this.ptDelete1_Click);
            // 
            // btnImage4
            // 
            this.btnImage4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage4.CheckedState.Parent = this.btnImage4;
            this.btnImage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage4.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage4.HoverState.Parent = this.btnImage4;
            this.btnImage4.Image = ((System.Drawing.Image)(resources.GetObject("btnImage4.Image")));
            this.btnImage4.ImageRotate = 0F;
            this.btnImage4.Location = new System.Drawing.Point(922, 93);
            this.btnImage4.Name = "btnImage4";
            this.btnImage4.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage4.PressedState.Parent = this.btnImage4;
            this.btnImage4.Size = new System.Drawing.Size(65, 60);
            this.btnImage4.TabIndex = 1;
            this.btnImage4.Click += new System.EventHandler(this.btnImage4_Click);
            this.btnImage4.MouseLeave += new System.EventHandler(this.btnImage4_MouseLeave);
            this.btnImage4.MouseHover += new System.EventHandler(this.btnImage4_MouseHover);
            // 
            // btnImage3
            // 
            this.btnImage3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage3.CheckedState.Parent = this.btnImage3;
            this.btnImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage3.HoverState.Parent = this.btnImage3;
            this.btnImage3.Image = ((System.Drawing.Image)(resources.GetObject("btnImage3.Image")));
            this.btnImage3.ImageRotate = 0F;
            this.btnImage3.Location = new System.Drawing.Point(650, 93);
            this.btnImage3.Name = "btnImage3";
            this.btnImage3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage3.PressedState.Parent = this.btnImage3;
            this.btnImage3.Size = new System.Drawing.Size(65, 60);
            this.btnImage3.TabIndex = 1;
            this.btnImage3.Click += new System.EventHandler(this.btnImage3_Click);
            this.btnImage3.MouseLeave += new System.EventHandler(this.btnImage3_MouseLeave);
            this.btnImage3.MouseHover += new System.EventHandler(this.btnImage3_MouseHover);
            // 
            // btnImage2
            // 
            this.btnImage2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage2.CheckedState.Parent = this.btnImage2;
            this.btnImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage2.HoverState.Parent = this.btnImage2;
            this.btnImage2.Image = ((System.Drawing.Image)(resources.GetObject("btnImage2.Image")));
            this.btnImage2.ImageRotate = 0F;
            this.btnImage2.Location = new System.Drawing.Point(378, 93);
            this.btnImage2.Name = "btnImage2";
            this.btnImage2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage2.PressedState.Parent = this.btnImage2;
            this.btnImage2.Size = new System.Drawing.Size(65, 60);
            this.btnImage2.TabIndex = 1;
            this.btnImage2.Click += new System.EventHandler(this.btnImage2_Click);
            this.btnImage2.MouseLeave += new System.EventHandler(this.btnImage2_MouseLeave);
            this.btnImage2.MouseHover += new System.EventHandler(this.btnImage2_MouseHover);
            // 
            // btnImage1
            // 
            this.btnImage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImage1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage1.CheckedState.Parent = this.btnImage1;
            this.btnImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage1.HoverState.Parent = this.btnImage1;
            this.btnImage1.Image = ((System.Drawing.Image)(resources.GetObject("btnImage1.Image")));
            this.btnImage1.ImageRotate = 0F;
            this.btnImage1.Location = new System.Drawing.Point(91, 93);
            this.btnImage1.Name = "btnImage1";
            this.btnImage1.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnImage1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage1.PressedState.Parent = this.btnImage1;
            this.btnImage1.Size = new System.Drawing.Size(65, 60);
            this.btnImage1.TabIndex = 1;
            this.btnImage1.Click += new System.EventHandler(this.btnImage1_Click);
            this.btnImage1.MouseLeave += new System.EventHandler(this.btnImage1_MouseLeave);
            this.btnImage1.MouseHover += new System.EventHandler(this.btnImage1_MouseHover);
            // 
            // ptImage4
            // 
            this.ptImage4.Location = new System.Drawing.Point(831, 44);
            this.ptImage4.Name = "ptImage4";
            this.ptImage4.Size = new System.Drawing.Size(254, 160);
            this.ptImage4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage4.TabIndex = 0;
            this.ptImage4.TabStop = false;
            // 
            // ptImage3
            // 
            this.ptImage3.Location = new System.Drawing.Point(555, 44);
            this.ptImage3.Name = "ptImage3";
            this.ptImage3.Size = new System.Drawing.Size(254, 160);
            this.ptImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage3.TabIndex = 0;
            this.ptImage3.TabStop = false;
            // 
            // ptImage2
            // 
            this.ptImage2.Location = new System.Drawing.Point(280, 44);
            this.ptImage2.Name = "ptImage2";
            this.ptImage2.Size = new System.Drawing.Size(254, 160);
            this.ptImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage2.TabIndex = 0;
            this.ptImage2.TabStop = false;
            // 
            // ptImage1
            // 
            this.ptImage1.Location = new System.Drawing.Point(5, 44);
            this.ptImage1.Name = "ptImage1";
            this.ptImage1.Size = new System.Drawing.Size(254, 160);
            this.ptImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImage1.TabIndex = 0;
            this.ptImage1.TabStop = false;
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // frmRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1170, 649);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoomManager";
            this.Text = "frmRoomManager";
            this.Load += new System.EventHandler(this.frmRoomManager_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListRoom)).EndInit();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDelete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2GroupBox gbImage;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRoom;
        private Guna.UI2.WinForms.Guna2Button btnDeleteRoom;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage4;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage3;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage2;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage1;
        private System.Windows.Forms.PictureBox ptImage4;
        private System.Windows.Forms.PictureBox ptImage3;
        private System.Windows.Forms.PictureBox ptImage2;
        private System.Windows.Forms.PictureBox ptImage1;
        private System.Windows.Forms.PictureBox ptDelete4;
        private System.Windows.Forms.PictureBox ptDelete3;
        private System.Windows.Forms.PictureBox ptDelete2;
        private System.Windows.Forms.PictureBox ptDelete1;
        private Guna.UI2.WinForms.Guna2TextBox txbSeacrh;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvListRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private System.Windows.Forms.TextBox txbUnitPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNote;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeRoom;
        private System.Windows.Forms.TextBox txbCodeRoom;
        private System.Windows.Forms.Panel plRoomCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescribe;
        private System.Windows.Forms.Label label4;
    }
}