namespace QuanLyKhachSan
{
    partial class frmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackupRestore));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptClose = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBrowseST = new System.Windows.Forms.Button();
            this.plbkpath = new System.Windows.Forms.Panel();
            this.txbRestoreName = new System.Windows.Forms.TextBox();
            this.lbbkpath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBrowseBK = new System.Windows.Forms.Button();
            this.plbk = new System.Windows.Forms.Panel();
            this.txbBackupName = new System.Windows.Forms.TextBox();
            this.lblocation = new System.Windows.Forms.Label();
            this.rdBackUp = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdRestore = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(951, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(223, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Back Up and Restore Database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnBrowseST);
            this.groupBox2.Controls.Add(this.plbkpath);
            this.groupBox2.Controls.Add(this.txbRestoreName);
            this.groupBox2.Controls.Add(this.lbbkpath);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1069, 256);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phục hồi dữ liệu";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRestore.Enabled = false;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestore.Location = new System.Drawing.Point(893, 189);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(119, 34);
            this.btnRestore.TabIndex = 36;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseST
            // 
            this.btnBrowseST.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBrowseST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseST.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseST.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowseST.Location = new System.Drawing.Point(768, 189);
            this.btnBrowseST.Name = "btnBrowseST";
            this.btnBrowseST.Size = new System.Drawing.Size(119, 34);
            this.btnBrowseST.TabIndex = 37;
            this.btnBrowseST.Text = "Browse.....";
            this.btnBrowseST.UseVisualStyleBackColor = false;
            this.btnBrowseST.Visible = false;
            this.btnBrowseST.Click += new System.EventHandler(this.btnBrowseST_Click);
            // 
            // plbkpath
            // 
            this.plbkpath.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plbkpath.Location = new System.Drawing.Point(240, 124);
            this.plbkpath.Name = "plbkpath";
            this.plbkpath.Size = new System.Drawing.Size(731, 1);
            this.plbkpath.TabIndex = 35;
            this.plbkpath.Visible = false;
            // 
            // txbRestoreName
            // 
            this.txbRestoreName.BackColor = System.Drawing.SystemColors.Control;
            this.txbRestoreName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRestoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRestoreName.Location = new System.Drawing.Point(244, 97);
            this.txbRestoreName.Name = "txbRestoreName";
            this.txbRestoreName.Size = new System.Drawing.Size(727, 20);
            this.txbRestoreName.TabIndex = 34;
            this.txbRestoreName.Visible = false;
            // 
            // lbbkpath
            // 
            this.lbbkpath.AutoSize = true;
            this.lbbkpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbkpath.Location = new System.Drawing.Point(117, 99);
            this.lbbkpath.Name = "lbbkpath";
            this.lbbkpath.Size = new System.Drawing.Size(104, 20);
            this.lbbkpath.TabIndex = 33;
            this.lbbkpath.Text = "Backup Path";
            this.lbbkpath.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnBrowseBK);
            this.groupBox1.Controls.Add(this.plbk);
            this.groupBox1.Controls.Add(this.txbBackupName);
            this.groupBox1.Controls.Add(this.lblocation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 234);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu dữ liệu";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackup.Enabled = false;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackup.Location = new System.Drawing.Point(896, 157);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(119, 34);
            this.btnBackup.TabIndex = 32;
            this.btnBackup.Text = "Back Up";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Visible = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowseBK
            // 
            this.btnBrowseBK.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBrowseBK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBK.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseBK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowseBK.Location = new System.Drawing.Point(771, 157);
            this.btnBrowseBK.Name = "btnBrowseBK";
            this.btnBrowseBK.Size = new System.Drawing.Size(119, 34);
            this.btnBrowseBK.TabIndex = 32;
            this.btnBrowseBK.Text = "Browse.....";
            this.btnBrowseBK.UseVisualStyleBackColor = false;
            this.btnBrowseBK.Visible = false;
            this.btnBrowseBK.Click += new System.EventHandler(this.btnBrowseBK_Click);
            // 
            // plbk
            // 
            this.plbk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plbk.Location = new System.Drawing.Point(212, 115);
            this.plbk.Name = "plbk";
            this.plbk.Size = new System.Drawing.Size(731, 1);
            this.plbk.TabIndex = 2;
            this.plbk.Visible = false;
            // 
            // txbBackupName
            // 
            this.txbBackupName.BackColor = System.Drawing.SystemColors.Control;
            this.txbBackupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBackupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBackupName.Location = new System.Drawing.Point(216, 88);
            this.txbBackupName.Name = "txbBackupName";
            this.txbBackupName.Size = new System.Drawing.Size(727, 20);
            this.txbBackupName.TabIndex = 1;
            this.txbBackupName.Visible = false;
            // 
            // lblocation
            // 
            this.lblocation.AutoSize = true;
            this.lblocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocation.Location = new System.Drawing.Point(120, 90);
            this.lblocation.Name = "lblocation";
            this.lblocation.Size = new System.Drawing.Size(73, 20);
            this.lblocation.TabIndex = 0;
            this.lblocation.Text = "Location";
            this.lblocation.Visible = false;
            // 
            // rdBackUp
            // 
            this.rdBackUp.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdBackUp.CheckedState.BorderThickness = 0;
            this.rdBackUp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdBackUp.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdBackUp.CheckedState.Parent = this.rdBackUp;
            this.rdBackUp.Location = new System.Drawing.Point(34, 68);
            this.rdBackUp.Name = "rdBackUp";
            this.rdBackUp.ShadowDecoration.Parent = this.rdBackUp;
            this.rdBackUp.Size = new System.Drawing.Size(25, 23);
            this.rdBackUp.TabIndex = 36;
            this.rdBackUp.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdBackUp.UncheckedState.BorderThickness = 2;
            this.rdBackUp.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdBackUp.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdBackUp.UncheckedState.Parent = this.rdBackUp;
            this.rdBackUp.CheckedChanged += new System.EventHandler(this.rdBackUp_CheckedChanged);
            // 
            // rdRestore
            // 
            this.rdRestore.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdRestore.CheckedState.BorderThickness = 0;
            this.rdRestore.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdRestore.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdRestore.CheckedState.Parent = this.rdRestore;
            this.rdRestore.Location = new System.Drawing.Point(37, 386);
            this.rdRestore.Name = "rdRestore";
            this.rdRestore.ShadowDecoration.Parent = this.rdRestore;
            this.rdRestore.Size = new System.Drawing.Size(25, 23);
            this.rdRestore.TabIndex = 36;
            this.rdRestore.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdRestore.UncheckedState.BorderThickness = 2;
            this.rdRestore.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdRestore.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdRestore.UncheckedState.Parent = this.rdRestore;
            this.rdRestore.CheckedChanged += new System.EventHandler(this.rdRestore_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Back Up Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Restore Database";
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 731);
            this.Controls.Add(this.rdRestore);
            this.Controls.Add(this.rdBackUp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackupRestore";
            this.Text = "frmBackupRestore";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBrowseST;
        private System.Windows.Forms.Panel plbkpath;
        private System.Windows.Forms.TextBox txbRestoreName;
        private System.Windows.Forms.Label lbbkpath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBrowseBK;
        private System.Windows.Forms.Panel plbk;
        private System.Windows.Forms.TextBox txbBackupName;
        private System.Windows.Forms.Label lblocation;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBackUp;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdRestore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}