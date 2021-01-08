namespace QuanLyKhachSan
{
    partial class frmUpdateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateAccount));
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.lbEmployeeCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.plEmail = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.plNumphone = new System.Windows.Forms.Panel();
            this.txbNumPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTypeAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.plQuanLyNV = new System.Windows.Forms.Panel();
            this.dtgvCheckManager = new System.Windows.Forms.DataGridView();
            this.NVQL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpkDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnChoose = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.plQuanLyNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(588, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(175, 38);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 5);
            this.panel1.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(44, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Maõ Nhaân Vieân :";
            // 
            // ptClose
            // 
            this.ptClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(773, 11);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(30, 30);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 47;
            this.ptClose.TabStop = false;
            this.ptClose.Click += new System.EventHandler(this.ptClose_Click);
            // 
            // lbEmployeeCode
            // 
            this.lbEmployeeCode.AutoSize = true;
            this.lbEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbEmployeeCode.Location = new System.Drawing.Point(264, 18);
            this.lbEmployeeCode.Name = "lbEmployeeCode";
            this.lbEmployeeCode.Size = new System.Drawing.Size(53, 23);
            this.lbEmployeeCode.TabIndex = 48;
            this.lbEmployeeCode.Text = "NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(18, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Email Ñaêng Nhaäp :";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.Black;
            this.txbEmail.Location = new System.Drawing.Point(210, 72);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(538, 23);
            this.txbEmail.TabIndex = 49;
            this.txbEmail.Text = "NULL";
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plEmail.Location = new System.Drawing.Point(210, 98);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(538, 3);
            this.plEmail.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(76, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Hoï vaø Teân :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(210, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 3);
            this.panel2.TabIndex = 50;
            // 
            // txbFullName
            // 
            this.txbFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txbFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFullName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullName.ForeColor = System.Drawing.Color.Black;
            this.txbFullName.Location = new System.Drawing.Point(210, 128);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(250, 23);
            this.txbFullName.TabIndex = 49;
            this.txbFullName.Text = "NULL";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 8;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DarkGray;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(43, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Soá Ñieän Thoaïi :";
            // 
            // plNumphone
            // 
            this.plNumphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.plNumphone.Location = new System.Drawing.Point(210, 211);
            this.plNumphone.Name = "plNumphone";
            this.plNumphone.Size = new System.Drawing.Size(309, 3);
            this.plNumphone.TabIndex = 50;
            // 
            // txbNumPhone
            // 
            this.txbNumPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txbNumPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumPhone.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumPhone.ForeColor = System.Drawing.Color.Black;
            this.txbNumPhone.Location = new System.Drawing.Point(210, 185);
            this.txbNumPhone.Name = "txbNumPhone";
            this.txbNumPhone.Size = new System.Drawing.Size(309, 23);
            this.txbNumPhone.TabIndex = 49;
            this.txbNumPhone.Text = "NULL";
            this.txbNumPhone.TextChanged += new System.EventHandler(this.txbNumPhone_TextChanged);
            this.txbNumPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumPhone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(525, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Giôùi Tính :";
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.Transparent;
            this.cbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSex.FocusedState.Parent = this.cbSex;
            this.cbSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSex.HoverState.Parent = this.cbSex;
            this.cbSex.ItemHeight = 30;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.ItemsAppearance.Parent = this.cbSex;
            this.cbSex.Location = new System.Drawing.Point(648, 178);
            this.cbSex.Name = "cbSex";
            this.cbSex.ShadowDecoration.Parent = this.cbSex;
            this.cbSex.Size = new System.Drawing.Size(100, 36);
            this.cbSex.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(105, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ñòa Chæ :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(210, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(538, 3);
            this.panel5.TabIndex = 50;
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAddress.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.ForeColor = System.Drawing.Color.Black;
            this.txbAddress.Location = new System.Drawing.Point(210, 239);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(538, 98);
            this.txbAddress.TabIndex = 49;
            this.txbAddress.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(95, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Caáp Baäc :";
            // 
            // cbTypeAccount
            // 
            this.cbTypeAccount.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAccount.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeAccount.FocusedState.Parent = this.cbTypeAccount;
            this.cbTypeAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeAccount.HoverState.Parent = this.cbTypeAccount;
            this.cbTypeAccount.ItemHeight = 30;
            this.cbTypeAccount.Items.AddRange(new object[] {
            "Nhân Viên",
            "Quản Lý"});
            this.cbTypeAccount.ItemsAppearance.Parent = this.cbTypeAccount;
            this.cbTypeAccount.Location = new System.Drawing.Point(210, 362);
            this.cbTypeAccount.Name = "cbTypeAccount";
            this.cbTypeAccount.ShadowDecoration.Parent = this.cbTypeAccount;
            this.cbTypeAccount.Size = new System.Drawing.Size(202, 36);
            this.cbTypeAccount.TabIndex = 51;
            this.cbTypeAccount.SelectedIndexChanged += new System.EventHandler(this.cbTypeAccount_SelectedIndexChanged);
            // 
            // plQuanLyNV
            // 
            this.plQuanLyNV.Controls.Add(this.dtgvCheckManager);
            this.plQuanLyNV.Location = new System.Drawing.Point(7, 2);
            this.plQuanLyNV.Name = "plQuanLyNV";
            this.plQuanLyNV.Size = new System.Drawing.Size(756, 357);
            this.plQuanLyNV.TabIndex = 52;
            this.plQuanLyNV.Visible = false;
            // 
            // dtgvCheckManager
            // 
            this.dtgvCheckManager.AllowUserToAddRows = false;
            this.dtgvCheckManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCheckManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCheckManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NVQL});
            this.dtgvCheckManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCheckManager.Location = new System.Drawing.Point(0, 0);
            this.dtgvCheckManager.Name = "dtgvCheckManager";
            this.dtgvCheckManager.RowTemplate.Height = 24;
            this.dtgvCheckManager.Size = new System.Drawing.Size(756, 357);
            this.dtgvCheckManager.TabIndex = 0;
            this.dtgvCheckManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCheckManager_CellContentClick);
            // 
            // NVQL
            // 
            this.NVQL.FillWeight = 76.14214F;
            this.NVQL.HeaderText = "Quản Lý NV";
            this.NVQL.Name = "NVQL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("VNI-Souvir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(478, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Birth Day:";
            // 
            // dtpkDOB
            // 
            this.dtpkDOB.CheckedState.Parent = this.dtpkDOB;
            this.dtpkDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDOB.HoverState.Parent = this.dtpkDOB;
            this.dtpkDOB.Location = new System.Drawing.Point(588, 115);
            this.dtpkDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkDOB.Name = "dtpkDOB";
            this.dtpkDOB.ShadowDecoration.Parent = this.dtpkDOB;
            this.dtpkDOB.Size = new System.Drawing.Size(160, 36);
            this.dtpkDOB.TabIndex = 53;
            this.dtpkDOB.Value = new System.DateTime(2021, 1, 2, 14, 39, 47, 105);
            // 
            // btnChoose
            // 
            this.btnChoose.CheckedState.Parent = this.btnChoose;
            this.btnChoose.CustomImages.Parent = this.btnChoose;
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.HoverState.Parent = this.btnChoose;
            this.btnChoose.Location = new System.Drawing.Point(418, 362);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.ShadowDecoration.Parent = this.btnChoose;
            this.btnChoose.Size = new System.Drawing.Size(101, 38);
            this.btnChoose.TabIndex = 44;
            this.btnChoose.Text = "Choose. . .";
            this.btnChoose.Visible = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // frmUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 428);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.plQuanLyNV);
            this.Controls.Add(this.cbTypeAccount);
            this.Controls.Add(this.txbNumPhone);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbFullName);
            this.Controls.Add(this.plNumphone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.plEmail);
            this.Controls.Add(this.lbEmployeeCode);
            this.Controls.Add(this.ptClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpkDOB);
            this.Controls.Add(this.cbSex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(815, 428);
            this.MinimumSize = new System.Drawing.Size(815, 428);
            this.Name = "frmUpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateAccount";
            this.Load += new System.EventHandler(this.frmUpdateAccount_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmUpdateAccount_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.plQuanLyNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCheckManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEmployeeCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Panel plEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbFullName;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.TextBox txbNumPhone;
        private System.Windows.Forms.Panel plNumphone;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeAccount;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        public System.Windows.Forms.PictureBox ptClose;
        private System.Windows.Forms.Panel plQuanLyNV;
        private System.Windows.Forms.DataGridView dtgvCheckManager;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NVQL;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkDOB;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2GradientButton btnChoose;
    }
}