namespace QuanLyKhachSan
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.plSideMenu = new System.Windows.Forms.Panel();
            this.plSystem = new System.Windows.Forms.Panel();
            this.btnOperationsmanagement = new System.Windows.Forms.Button();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.tbnAuthorization = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnhotelmanager = new System.Windows.Forms.Button();
            this.btnLogoutAd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.plManageSubMenu = new System.Windows.Forms.Panel();
            this.btnManagerEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnInfor = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChangePass = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.plLogo = new System.Windows.Forms.Panel();
            this.lbLevel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contextMenuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMInfomation = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.plMainForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plSideMenu.SuspendLayout();
            this.plSystem.SuspendLayout();
            this.plManageSubMenu.SuspendLayout();
            this.plLogo.SuspendLayout();
            this.contextMenuUser.SuspendLayout();
            this.plMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plSideMenu
            // 
            this.plSideMenu.AutoScroll = true;
            this.plSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.plSideMenu.Controls.Add(this.plSystem);
            this.plSideMenu.Controls.Add(this.btnSystem);
            this.plSideMenu.Controls.Add(this.btnhotelmanager);
            this.plSideMenu.Controls.Add(this.btnLogoutAd);
            this.plSideMenu.Controls.Add(this.plManageSubMenu);
            this.plSideMenu.Controls.Add(this.btnUserManagement);
            this.plSideMenu.Controls.Add(this.plLogo);
            this.plSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plSideMenu.Location = new System.Drawing.Point(0, 0);
            this.plSideMenu.Name = "plSideMenu";
            this.plSideMenu.Size = new System.Drawing.Size(278, 731);
            this.plSideMenu.TabIndex = 0;
            // 
            // plSystem
            // 
            this.plSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.plSystem.Controls.Add(this.btnOperationsmanagement);
            this.plSystem.Controls.Add(this.btnBackupRestore);
            this.plSystem.Controls.Add(this.tbnAuthorization);
            this.plSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.plSystem.Location = new System.Drawing.Point(0, 445);
            this.plSystem.Name = "plSystem";
            this.plSystem.Size = new System.Drawing.Size(278, 125);
            this.plSystem.TabIndex = 5;
            // 
            // btnOperationsmanagement
            // 
            this.btnOperationsmanagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperationsmanagement.FlatAppearance.BorderSize = 0;
            this.btnOperationsmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperationsmanagement.ForeColor = System.Drawing.Color.LightGray;
            this.btnOperationsmanagement.Location = new System.Drawing.Point(0, 80);
            this.btnOperationsmanagement.Name = "btnOperationsmanagement";
            this.btnOperationsmanagement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOperationsmanagement.Size = new System.Drawing.Size(278, 40);
            this.btnOperationsmanagement.TabIndex = 2;
            this.btnOperationsmanagement.Text = "Quản Lý Hoạt Động";
            this.btnOperationsmanagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperationsmanagement.UseVisualStyleBackColor = true;
            this.btnOperationsmanagement.Click += new System.EventHandler(this.btnOperationsmanagement_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackupRestore.FlatAppearance.BorderSize = 0;
            this.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupRestore.ForeColor = System.Drawing.Color.LightGray;
            this.btnBackupRestore.Location = new System.Drawing.Point(0, 40);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBackupRestore.Size = new System.Drawing.Size(278, 40);
            this.btnBackupRestore.TabIndex = 1;
            this.btnBackupRestore.Text = "Backup and Restore";
            this.btnBackupRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupRestore.UseVisualStyleBackColor = true;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // tbnAuthorization
            // 
            this.tbnAuthorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbnAuthorization.FlatAppearance.BorderSize = 0;
            this.tbnAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnAuthorization.ForeColor = System.Drawing.Color.LightGray;
            this.tbnAuthorization.Location = new System.Drawing.Point(0, 0);
            this.tbnAuthorization.Name = "tbnAuthorization";
            this.tbnAuthorization.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.tbnAuthorization.Size = new System.Drawing.Size(278, 40);
            this.tbnAuthorization.TabIndex = 0;
            this.tbnAuthorization.Text = "Quản Lý Account";
            this.tbnAuthorization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnAuthorization.UseVisualStyleBackColor = true;
            this.tbnAuthorization.Click += new System.EventHandler(this.tbnAuthorization_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSystem.Location = new System.Drawing.Point(0, 400);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSystem.Size = new System.Drawing.Size(278, 45);
            this.btnSystem.TabIndex = 4;
            this.btnSystem.Text = "Hệ Thống";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnhotelmanager
            // 
            this.btnhotelmanager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhotelmanager.FlatAppearance.BorderSize = 0;
            this.btnhotelmanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhotelmanager.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnhotelmanager.Location = new System.Drawing.Point(0, 355);
            this.btnhotelmanager.Name = "btnhotelmanager";
            this.btnhotelmanager.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnhotelmanager.Size = new System.Drawing.Size(278, 45);
            this.btnhotelmanager.TabIndex = 3;
            this.btnhotelmanager.Text = "Quản Lý Khách Sạn";
            this.btnhotelmanager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhotelmanager.UseVisualStyleBackColor = true;
            this.btnhotelmanager.Click += new System.EventHandler(this.btnhotelmanager_Click);
            // 
            // btnLogoutAd
            // 
            this.btnLogoutAd.CheckedState.Parent = this.btnLogoutAd;
            this.btnLogoutAd.CustomImages.Parent = this.btnLogoutAd;
            this.btnLogoutAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogoutAd.ForeColor = System.Drawing.Color.White;
            this.btnLogoutAd.HoverState.Parent = this.btnLogoutAd;
            this.btnLogoutAd.Location = new System.Drawing.Point(-1, 693);
            this.btnLogoutAd.Name = "btnLogoutAd";
            this.btnLogoutAd.ShadowDecoration.Parent = this.btnLogoutAd;
            this.btnLogoutAd.Size = new System.Drawing.Size(278, 38);
            this.btnLogoutAd.TabIndex = 40;
            this.btnLogoutAd.Text = "Logout";
            this.btnLogoutAd.Visible = false;
            this.btnLogoutAd.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // plManageSubMenu
            // 
            this.plManageSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.plManageSubMenu.Controls.Add(this.btnManagerEmployee);
            this.plManageSubMenu.Controls.Add(this.btnInfor);
            this.plManageSubMenu.Controls.Add(this.btnChangePass);
            this.plManageSubMenu.Controls.Add(this.btnLogout);
            this.plManageSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.plManageSubMenu.Location = new System.Drawing.Point(0, 183);
            this.plManageSubMenu.Name = "plManageSubMenu";
            this.plManageSubMenu.Size = new System.Drawing.Size(278, 172);
            this.plManageSubMenu.TabIndex = 2;
            // 
            // btnManagerEmployee
            // 
            this.btnManagerEmployee.CheckedState.Parent = this.btnManagerEmployee;
            this.btnManagerEmployee.CustomImages.Parent = this.btnManagerEmployee;
            this.btnManagerEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManagerEmployee.ForeColor = System.Drawing.Color.White;
            this.btnManagerEmployee.HoverState.Parent = this.btnManagerEmployee;
            this.btnManagerEmployee.Location = new System.Drawing.Point(0, 1);
            this.btnManagerEmployee.Name = "btnManagerEmployee";
            this.btnManagerEmployee.ShadowDecoration.Parent = this.btnManagerEmployee;
            this.btnManagerEmployee.Size = new System.Drawing.Size(275, 42);
            this.btnManagerEmployee.TabIndex = 40;
            this.btnManagerEmployee.Text = "Quản Lý Nhân Viên";
            this.btnManagerEmployee.Click += new System.EventHandler(this.btnManagerEmployee_Click);
            // 
            // btnInfor
            // 
            this.btnInfor.CheckedState.Parent = this.btnInfor;
            this.btnInfor.CustomImages.Parent = this.btnInfor;
            this.btnInfor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInfor.ForeColor = System.Drawing.Color.White;
            this.btnInfor.HoverState.Parent = this.btnInfor;
            this.btnInfor.Location = new System.Drawing.Point(0, 42);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.ShadowDecoration.Parent = this.btnInfor;
            this.btnInfor.Size = new System.Drawing.Size(275, 49);
            this.btnInfor.TabIndex = 40;
            this.btnInfor.Text = "Thông Tin Cá Nhân";
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.CheckedState.Parent = this.btnChangePass;
            this.btnChangePass.CustomImages.Parent = this.btnChangePass;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.HoverState.Parent = this.btnChangePass;
            this.btnChangePass.Location = new System.Drawing.Point(-2, 90);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ShadowDecoration.Parent = this.btnChangePass;
            this.btnChangePass.Size = new System.Drawing.Size(278, 38);
            this.btnChangePass.TabIndex = 40;
            this.btnChangePass.Text = "Đổi Mật Khẩu";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Location = new System.Drawing.Point(-1, 128);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(278, 38);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 138);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(278, 45);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "Nhân Viên";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // plLogo
            // 
            this.plLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.plLogo.Controls.Add(this.lbLevel);
            this.plLogo.Controls.Add(this.lbName);
            this.plLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLogo.Location = new System.Drawing.Point(0, 0);
            this.plLogo.Name = "plLogo";
            this.plLogo.Size = new System.Drawing.Size(278, 138);
            this.plLogo.TabIndex = 0;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = false;
            this.lbLevel.AutoSizeHeightOnly = true;
            this.lbLevel.AvoidGeometryAntialias = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Yellow;
            this.lbLevel.Location = new System.Drawing.Point(3, 14);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(269, 32);
            this.lbLevel.TabIndex = 1;
            this.lbLevel.Text = "Nhân Viên";
            this.lbLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.AutoSize = false;
            this.lbName.AutoSizeHeightOnly = true;
            this.lbName.AvoidGeometryAntialias = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Yellow;
            this.lbName.Location = new System.Drawing.Point(6, 71);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(269, 24);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Trần Thị Diệu Linh";
            this.lbName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuUser
            // 
            this.contextMenuUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMInfomation,
            this.tSMChangePass,
            this.toolStripSeparator1,
            this.tSMLogout});
            this.contextMenuUser.Name = "contextMenuUser";
            this.contextMenuUser.Size = new System.Drawing.Size(201, 94);
            // 
            // tSMInfomation
            // 
            this.tSMInfomation.Image = ((System.Drawing.Image)(resources.GetObject("tSMInfomation.Image")));
            this.tSMInfomation.Name = "tSMInfomation";
            this.tSMInfomation.Size = new System.Drawing.Size(200, 28);
            this.tSMInfomation.Text = "Thông tin cá nhân";
            // 
            // tSMChangePass
            // 
            this.tSMChangePass.Image = ((System.Drawing.Image)(resources.GetObject("tSMChangePass.Image")));
            this.tSMChangePass.Name = "tSMChangePass";
            this.tSMChangePass.Size = new System.Drawing.Size(200, 28);
            this.tSMChangePass.Text = "Đổi mật khẩu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // tSMLogout
            // 
            this.tSMLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSMLogout.ForeColor = System.Drawing.Color.Red;
            this.tSMLogout.Name = "tSMLogout";
            this.tSMLogout.Size = new System.Drawing.Size(200, 28);
            this.tSMLogout.Text = "Đăng xuất";
            // 
            // plMainForm
            // 
            this.plMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.plMainForm.Controls.Add(this.pictureBox1);
            this.plMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMainForm.Location = new System.Drawing.Point(278, 0);
            this.plMainForm.Name = "plMainForm";
            this.plMainForm.Size = new System.Drawing.Size(1113, 731);
            this.plMainForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1113, 731);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 731);
            this.Controls.Add(this.plMainForm);
            this.Controls.Add(this.plSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1258, 575);
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Trị Khách Sạn Marriott";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHomePage_FormClosed);
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.plSideMenu.ResumeLayout(false);
            this.plSystem.ResumeLayout(false);
            this.plManageSubMenu.ResumeLayout(false);
            this.plLogo.ResumeLayout(false);
            this.contextMenuUser.ResumeLayout(false);
            this.plMainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plSideMenu;
        private System.Windows.Forms.Panel plManageSubMenu;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Panel plLogo;
        private System.Windows.Forms.Button btnhotelmanager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plSystem;
        private System.Windows.Forms.Button btnBackupRestore;
        private System.Windows.Forms.Button tbnAuthorization;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnOperationsmanagement;
        private System.Windows.Forms.Panel plMainForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private System.Windows.Forms.ContextMenuStrip contextMenuUser;
        private System.Windows.Forms.ToolStripMenuItem tSMInfomation;
        private System.Windows.Forms.ToolStripMenuItem tSMChangePass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tSMLogout;
        private Guna.UI2.WinForms.Guna2GradientButton btnInfor;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbLevel;
        private Guna.UI2.WinForms.Guna2GradientButton btnManagerEmployee;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangePass;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogoutAd;
    }
}