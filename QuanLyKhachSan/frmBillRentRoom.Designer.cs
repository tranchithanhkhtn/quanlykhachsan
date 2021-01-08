namespace QuanLyKhachSan
{
    partial class frmBillRentRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillRentRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbError = new System.Windows.Forms.Label();
            this.dtpcDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.plDayofBirth = new System.Windows.Forms.Panel();
            this.txbCard = new System.Windows.Forms.TextBox();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.plFullName = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.plIdentityCard = new System.Windows.Forms.Panel();
            this.btnRent = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plNumofDay = new System.Windows.Forms.Panel();
            this.lbRentDay = new System.Windows.Forms.Label();
            this.lbRentTime = new System.Windows.Forms.Label();
            this.lbRentCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNumofDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbTypeRoom = new System.Windows.Forms.Label();
            this.lbRoomNum = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lbPayDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 5);
            this.panel1.TabIndex = 2;
            // 
            // ptClose
            // 
            this.ptClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(802, 7);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(30, 30);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 35;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lbError);
            this.guna2GroupBox1.Controls.Add(this.dtpcDateOfBirth);
            this.guna2GroupBox1.Controls.Add(this.panel6);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.txbAddress);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.lbPassword);
            this.guna2GroupBox1.Controls.Add(this.plDayofBirth);
            this.guna2GroupBox1.Controls.Add(this.txbCard);
            this.guna2GroupBox1.Controls.Add(this.txbFullName);
            this.guna2GroupBox1.Controls.Add(this.plFullName);
            this.guna2GroupBox1.Controls.Add(this.lbEmail);
            this.guna2GroupBox1.Controls.Add(this.plIdentityCard);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 279);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(813, 301);
            this.guna2GroupBox1.TabIndex = 36;
            this.guna2GroupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.White;
            this.lbError.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(603, 71);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(51, 25);
            this.lbError.TabIndex = 67;
            this.lbError.Text = "Error";
            this.lbError.Visible = false;
            // 
            // dtpcDateOfBirth
            // 
            this.dtpcDateOfBirth.CheckedState.Parent = this.dtpcDateOfBirth;
            this.dtpcDateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtpcDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpcDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpcDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcDateOfBirth.HoverState.Parent = this.dtpcDateOfBirth;
            this.dtpcDateOfBirth.Location = new System.Drawing.Point(566, 116);
            this.dtpcDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpcDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpcDateOfBirth.Name = "dtpcDateOfBirth";
            this.dtpcDateOfBirth.ShadowDecoration.Parent = this.dtpcDateOfBirth;
            this.dtpcDateOfBirth.Size = new System.Drawing.Size(201, 36);
            this.dtpcDateOfBirth.TabIndex = 66;
            this.dtpcDateOfBirth.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(172, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(611, 3);
            this.panel6.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(66, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "Địa Chỉ :";
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.Color.White;
            this.txbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.ForeColor = System.Drawing.Color.Silver;
            this.txbAddress.Location = new System.Drawing.Point(172, 179);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(611, 87);
            this.txbAddress.TabIndex = 3;
            this.txbAddress.Text = "~số 1, P. 10 - Quận 1 - TP.HCM";
            this.txbAddress.Enter += new System.EventHandler(this.txbAddress_Enter);
            this.txbAddress.Leave += new System.EventHandler(this.txbAddress_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(432, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Ngày Sinh :";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.White;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbPassword.Location = new System.Drawing.Point(44, 123);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(115, 23);
            this.lbPassword.TabIndex = 62;
            this.lbPassword.Text = "Họ và tên :";
            // 
            // plDayofBirth
            // 
            this.plDayofBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plDayofBirth.Location = new System.Drawing.Point(416, 152);
            this.plDayofBirth.Name = "plDayofBirth";
            this.plDayofBirth.Size = new System.Drawing.Size(367, 3);
            this.plDayofBirth.TabIndex = 61;
            // 
            // txbCard
            // 
            this.txbCard.BackColor = System.Drawing.Color.White;
            this.txbCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCard.ForeColor = System.Drawing.Color.Silver;
            this.txbCard.Location = new System.Drawing.Point(336, 72);
            this.txbCard.Name = "txbCard";
            this.txbCard.Size = new System.Drawing.Size(261, 23);
            this.txbCard.TabIndex = 1;
            this.txbCard.Text = "CMND hoặc Thẻ Căn Cước";
            this.txbCard.TextChanged += new System.EventHandler(this.txbCard_TextChanged);
            this.txbCard.Enter += new System.EventHandler(this.txbCard_Enter);
            this.txbCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCard_KeyPress);
            this.txbCard.Leave += new System.EventHandler(this.txbCard_Leave);
            // 
            // txbFullName
            // 
            this.txbFullName.BackColor = System.Drawing.Color.White;
            this.txbFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullName.ForeColor = System.Drawing.Color.Silver;
            this.txbFullName.Location = new System.Drawing.Point(175, 123);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(251, 23);
            this.txbFullName.TabIndex = 2;
            this.txbFullName.Text = "~Nguyễn Văn A";
            this.txbFullName.Enter += new System.EventHandler(this.txbFullName_Enter);
            this.txbFullName.Leave += new System.EventHandler(this.txbFullName_Leave);
            // 
            // plFullName
            // 
            this.plFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plFullName.Location = new System.Drawing.Point(175, 152);
            this.plFullName.Name = "plFullName";
            this.plFullName.Size = new System.Drawing.Size(251, 3);
            this.plFullName.TabIndex = 61;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.White;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbEmail.Location = new System.Drawing.Point(19, 70);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(276, 23);
            this.lbEmail.TabIndex = 59;
            this.lbEmail.Text = "Số Chứng Minh Thư (CMND) :";
            // 
            // plIdentityCard
            // 
            this.plIdentityCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plIdentityCard.Location = new System.Drawing.Point(336, 99);
            this.plIdentityCard.Name = "plIdentityCard";
            this.plIdentityCard.Size = new System.Drawing.Size(447, 3);
            this.plIdentityCard.TabIndex = 58;
            // 
            // btnRent
            // 
            this.btnRent.AutoRoundedCorners = true;
            this.btnRent.BackColor = System.Drawing.Color.Transparent;
            this.btnRent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRent.BorderRadius = 22;
            this.btnRent.BorderThickness = 2;
            this.btnRent.CheckedState.Parent = this.btnRent;
            this.btnRent.CustomImages.Parent = this.btnRent;
            this.btnRent.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRent.Font = new System.Drawing.Font("VNI-Fato", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRent.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRent.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRent.HoverState.Parent = this.btnRent;
            this.btnRent.Location = new System.Drawing.Point(639, 596);
            this.btnRent.Name = "btnRent";
            this.btnRent.ShadowDecoration.BorderRadius = 26;
            this.btnRent.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRent.ShadowDecoration.Enabled = true;
            this.btnRent.ShadowDecoration.Parent = this.btnRent;
            this.btnRent.Size = new System.Drawing.Size(186, 47);
            this.btnRent.TabIndex = 4;
            this.btnRent.Text = "Thueâ Phoøng";
            this.btnRent.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plNumofDay);
            this.groupBox1.Controls.Add(this.lbRentDay);
            this.groupBox1.Controls.Add(this.lbPayDate);
            this.groupBox1.Controls.Add(this.lbRentTime);
            this.groupBox1.Controls.Add(this.lbRentCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbNumofDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbUnitPrice);
            this.groupBox1.Controls.Add(this.lbTypeRoom);
            this.groupBox1.Controls.Add(this.lbRoomNum);
            this.groupBox1.Font = new System.Drawing.Font("VNI-Duff", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 240);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thoâng Tin Phoøng Thueâ";
            // 
            // plNumofDay
            // 
            this.plNumofDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plNumofDay.Location = new System.Drawing.Point(217, 219);
            this.plNumofDay.Name = "plNumofDay";
            this.plNumofDay.Size = new System.Drawing.Size(78, 3);
            this.plNumofDay.TabIndex = 63;
            // 
            // lbRentDay
            // 
            this.lbRentDay.AutoSize = true;
            this.lbRentDay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentDay.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbRentDay.Location = new System.Drawing.Point(308, 99);
            this.lbRentDay.Name = "lbRentDay";
            this.lbRentDay.Size = new System.Drawing.Size(53, 23);
            this.lbRentDay.TabIndex = 44;
            this.lbRentDay.Text = "NULL";
            // 
            // lbRentTime
            // 
            this.lbRentTime.AutoSize = true;
            this.lbRentTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentTime.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbRentTime.Location = new System.Drawing.Point(224, 99);
            this.lbRentTime.Name = "lbRentTime";
            this.lbRentTime.Size = new System.Drawing.Size(53, 23);
            this.lbRentTime.TabIndex = 44;
            this.lbRentTime.Text = "NULL";
            // 
            // lbRentCode
            // 
            this.lbRentCode.AutoSize = true;
            this.lbRentCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbRentCode.Location = new System.Drawing.Point(224, 52);
            this.lbRentCode.Name = "lbRentCode";
            this.lbRentCode.Size = new System.Drawing.Size(53, 23);
            this.lbRentCode.TabIndex = 45;
            this.lbRentCode.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(45, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Soâ Ngaøy Thueâ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(74, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngaøy Thueâ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(35, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Maõ Phieáu Thueâ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(502, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ñôn Giaù :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(473, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Loaïi Phoøng :";
            // 
            // txbNumofDay
            // 
            this.txbNumofDay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbNumofDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumofDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumofDay.ForeColor = System.Drawing.Color.Silver;
            this.txbNumofDay.Location = new System.Drawing.Point(219, 193);
            this.txbNumofDay.Name = "txbNumofDay";
            this.txbNumofDay.Size = new System.Drawing.Size(78, 23);
            this.txbNumofDay.TabIndex = 0;
            this.txbNumofDay.Text = "Text...";
            this.txbNumofDay.TextChanged += new System.EventHandler(this.txbNumofDay_TextChanged);
            this.txbNumofDay.Enter += new System.EventHandler(this.txbNumofDay_Enter);
            this.txbNumofDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumofDay_KeyPress);
            this.txbNumofDay.Leave += new System.EventHandler(this.txbNumofDay_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(484, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Maõ Phoøng :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(314, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 23);
            this.label12.TabIndex = 37;
            this.label12.Text = "Ngày";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPrice.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbUnitPrice.Location = new System.Drawing.Point(646, 146);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(53, 23);
            this.lbUnitPrice.TabIndex = 38;
            this.lbUnitPrice.Text = "NULL";
            // 
            // lbTypeRoom
            // 
            this.lbTypeRoom.AutoSize = true;
            this.lbTypeRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeRoom.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTypeRoom.Location = new System.Drawing.Point(646, 99);
            this.lbTypeRoom.Name = "lbTypeRoom";
            this.lbTypeRoom.Size = new System.Drawing.Size(53, 23);
            this.lbTypeRoom.TabIndex = 39;
            this.lbTypeRoom.Text = "NULL";
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNum.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbRoomNum.Location = new System.Drawing.Point(646, 50);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(53, 23);
            this.lbRoomNum.TabIndex = 40;
            this.lbRoomNum.Text = "NULL";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DimGray;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(88, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ngaøy Traû :";
            // 
            // lbPayDate
            // 
            this.lbPayDate.AutoSize = true;
            this.lbPayDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayDate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbPayDate.Location = new System.Drawing.Point(224, 146);
            this.lbPayDate.Name = "lbPayDate";
            this.lbPayDate.Size = new System.Drawing.Size(53, 23);
            this.lbPayDate.TabIndex = 44;
            this.lbPayDate.Text = "NULL";
            // 
            // frmBillRentRoom
            // 
            this.AcceptButton = this.btnRent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(837, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.ptClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillRentRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillRentRoom";
            this.Load += new System.EventHandler(this.frmBillRentRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptClose;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbTypeRoom;
        private System.Windows.Forms.Label lbRoomNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel plDayofBirth;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.Panel plFullName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbIdentityCard;
        private System.Windows.Forms.Panel plIdentityCard;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpcDateOfBirth;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lbRentTime;
        private System.Windows.Forms.Label lbRentCode;
        private System.Windows.Forms.Panel plNumofDay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbNumofDay;
        private System.Windows.Forms.TextBox txbCard;
        private System.Windows.Forms.Label lbError;
        public Guna.UI2.WinForms.Guna2Button btnRent;
        private System.Windows.Forms.Label lbRentDay;
        private System.Windows.Forms.Label lbPayDate;
        private System.Windows.Forms.Label label7;
    }
}