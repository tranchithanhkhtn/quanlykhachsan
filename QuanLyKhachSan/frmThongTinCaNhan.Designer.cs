namespace QuanLyKhachSan
{
    partial class frmThongTinCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinCaNhan));
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbFullname = new System.Windows.Forms.TextBox();
            this.txbNumPhone = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.plEmail = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmployeeCode = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSaveAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ofdFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveImage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(546, 352);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(161, 34);
            this.dtpDOB.TabIndex = 14;
            this.dtpDOB.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Enabled = false;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbEmail.Location = new System.Drawing.Point(307, 113);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(399, 23);
            this.txbEmail.TabIndex = 13;
            this.txbEmail.Text = "NULL";
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // txbFullname
            // 
            this.txbFullname.BackColor = System.Drawing.SystemColors.Control;
            this.txbFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFullname.Enabled = false;
            this.txbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbFullname.Location = new System.Drawing.Point(305, 270);
            this.txbFullname.Name = "txbFullname";
            this.txbFullname.Size = new System.Drawing.Size(401, 23);
            this.txbFullname.TabIndex = 10;
            this.txbFullname.Text = "NULL";
            // 
            // txbNumPhone
            // 
            this.txbNumPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txbNumPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumPhone.Enabled = false;
            this.txbNumPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumPhone.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbNumPhone.Location = new System.Drawing.Point(305, 188);
            this.txbNumPhone.Name = "txbNumPhone";
            this.txbNumPhone.Size = new System.Drawing.Size(401, 23);
            this.txbNumPhone.TabIndex = 9;
            this.txbNumPhone.Text = "NULL";
            this.txbNumPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumPhone_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Location = new System.Drawing.Point(79, 519);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(628, 3);
            this.panel5.TabIndex = 19;
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.plEmail.Location = new System.Drawing.Point(79, 145);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(627, 3);
            this.plEmail.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(79, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 3);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(79, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 3);
            this.panel2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("VNI 06 Springtime", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(380, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 37);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ngaøy Sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("VNI 06 Springtime", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(72, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hoï vaø Teân :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(79, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 3);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNI 06 Springtime", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(72, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soá Dieän Thoaïi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("VNI-Cooper", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(344, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 58);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thoâng Tin Caù Nhaân";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("VNI 06 Springtime", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(72, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 37);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email Daêng Nhaäp :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("VNI 06 Springtime", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(72, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 37);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giôùi Tính :";
            // 
            // ptClose
            // 
            this.ptClose.Image = ((System.Drawing.Image)(resources.GetObject("ptClose.Image")));
            this.ptClose.Location = new System.Drawing.Point(1041, 12);
            this.ptClose.Name = "ptClose";
            this.ptClose.Size = new System.Drawing.Size(34, 34);
            this.ptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptClose.TabIndex = 31;
            this.ptClose.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Aqua;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1085, 5);
            this.panel6.TabIndex = 32;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.DimGray;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI 06 Springtime", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(72, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Address :";
            // 
            // txbAddress
            // 
            this.txbAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbAddress.Enabled = false;
            this.txbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbAddress.Location = new System.Drawing.Point(186, 434);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(520, 79);
            this.txbAddress.TabIndex = 11;
            this.txbAddress.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("VNI-Duff", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(12, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Maõ Nhaân Vieân :";
            // 
            // lbEmployeeCode
            // 
            this.lbEmployeeCode.AutoSize = true;
            this.lbEmployeeCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeCode.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbEmployeeCode.Location = new System.Drawing.Point(168, 545);
            this.lbEmployeeCode.Name = "lbEmployeeCode";
            this.lbEmployeeCode.Size = new System.Drawing.Size(78, 26);
            this.lbEmployeeCode.TabIndex = 24;
            this.lbEmployeeCode.Text = "NULL";
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(570, 532);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(137, 38);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.CheckedState.Parent = this.btnSaveAll;
            this.btnSaveAll.CustomImages.Parent = this.btnSaveAll;
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.HoverState.Parent = this.btnSaveAll;
            this.btnSaveAll.Location = new System.Drawing.Point(570, 532);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.ShadowDecoration.Parent = this.btnSaveAll;
            this.btnSaveAll.Size = new System.Drawing.Size(137, 38);
            this.btnSaveAll.TabIndex = 41;
            this.btnSaveAll.Text = "SAVE ALL";
            this.btnSaveAll.Visible = false;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.Transparent;
            this.cbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.Enabled = false;
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
            this.cbSex.Location = new System.Drawing.Point(214, 350);
            this.cbSex.Name = "cbSex";
            this.cbSex.ShadowDecoration.Parent = this.cbSex;
            this.cbSex.Size = new System.Drawing.Size(140, 36);
            this.cbSex.TabIndex = 42;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.label2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.picAvatar.Location = new System.Drawing.Point(747, 113);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(294, 325);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 43;
            this.picAvatar.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.CheckedState.Parent = this.btnLoadImage;
            this.btnLoadImage.CustomImages.Parent = this.btnLoadImage;
            this.btnLoadImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadImage.HoverState.Parent = this.btnLoadImage;
            this.btnLoadImage.Location = new System.Drawing.Point(782, 475);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.ShadowDecoration.Parent = this.btnLoadImage;
            this.btnLoadImage.Size = new System.Drawing.Size(116, 38);
            this.btnLoadImage.TabIndex = 41;
            this.btnLoadImage.Text = "Browns. . .";
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // ofdFileDialog
            // 
            this.ofdFileDialog.FileName = "openFileDialog1";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.CheckedState.Parent = this.btnSaveImage;
            this.btnSaveImage.CustomImages.Parent = this.btnSaveImage;
            this.btnSaveImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveImage.ForeColor = System.Drawing.Color.White;
            this.btnSaveImage.HoverState.Parent = this.btnSaveImage;
            this.btnSaveImage.Location = new System.Drawing.Point(916, 475);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.ShadowDecoration.Parent = this.btnSaveImage;
            this.btnSaveImage.Size = new System.Drawing.Size(116, 38);
            this.btnSaveImage.TabIndex = 41;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Location = new System.Drawing.Point(739, 192);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 271);
            this.panel7.TabIndex = 44;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel8.Location = new System.Drawing.Point(712, 444);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 2);
            this.panel8.TabIndex = 44;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel9.Location = new System.Drawing.Point(845, 104);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(221, 2);
            this.panel9.TabIndex = 44;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel10.Location = new System.Drawing.Point(1047, 86);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 276);
            this.panel10.TabIndex = 44;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(288, 157);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(42, 14);
            this.lbError.TabIndex = 59;
            this.lbError.Text = "Error";
            this.lbError.Visible = false;
            // 
            // frmThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 583);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ptClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbEmployeeCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbFullname);
            this.Controls.Add(this.txbNumPhone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.plEmail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1085, 583);
            this.MinimumSize = new System.Drawing.Size(1085, 583);
            this.Name = "frmThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongTinCaNhan";
            this.Load += new System.EventHandler(this.frmThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbFullname;
        private System.Windows.Forms.TextBox txbNumPhone;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel plEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lbEmployeeCode;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton btnSaveAll;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ComboBox cbSex;
        public System.Windows.Forms.PictureBox ptClose;
        private System.Windows.Forms.PictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2GradientButton btnLoadImage;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.OpenFileDialog ofdFileDialog;
        private Guna.UI2.WinForms.Guna2GradientButton btnSaveImage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbError;
    }
}