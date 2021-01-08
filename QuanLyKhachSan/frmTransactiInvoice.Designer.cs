namespace QuanLyKhachSan
{
    partial class frmTransactiInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactiInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSeacrh = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdtRentalSlip = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdtReturnSlip = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
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
            this.txbSeacrh.Location = new System.Drawing.Point(13, 14);
            this.txbSeacrh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSeacrh.Name = "txbSeacrh";
            this.txbSeacrh.PasswordChar = '\0';
            this.txbSeacrh.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSeacrh.PlaceholderText = "Search by Code";
            this.txbSeacrh.SelectedText = "";
            this.txbSeacrh.ShadowDecoration.BorderRadius = 26;
            this.txbSeacrh.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txbSeacrh.ShadowDecoration.Depth = 20;
            this.txbSeacrh.ShadowDecoration.Enabled = true;
            this.txbSeacrh.ShadowDecoration.Parent = this.txbSeacrh;
            this.txbSeacrh.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.txbSeacrh.Size = new System.Drawing.Size(400, 38);
            this.txbSeacrh.TabIndex = 31;
            this.txbSeacrh.TextOffset = new System.Drawing.Point(7, 0);
            this.txbSeacrh.TextChanged += new System.EventHandler(this.txbSeacrh_TextChanged);
            // 
            // rdtRentalSlip
            // 
            this.rdtRentalSlip.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdtRentalSlip.CheckedState.BorderThickness = 0;
            this.rdtRentalSlip.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdtRentalSlip.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdtRentalSlip.CheckedState.Parent = this.rdtRentalSlip;
            this.rdtRentalSlip.Location = new System.Drawing.Point(505, 25);
            this.rdtRentalSlip.Name = "rdtRentalSlip";
            this.rdtRentalSlip.ShadowDecoration.Parent = this.rdtRentalSlip;
            this.rdtRentalSlip.Size = new System.Drawing.Size(20, 20);
            this.rdtRentalSlip.TabIndex = 33;
            this.rdtRentalSlip.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdtRentalSlip.UncheckedState.BorderThickness = 2;
            this.rdtRentalSlip.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdtRentalSlip.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdtRentalSlip.UncheckedState.Parent = this.rdtRentalSlip;
            // 
            // rdtReturnSlip
            // 
            this.rdtReturnSlip.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdtReturnSlip.CheckedState.BorderThickness = 0;
            this.rdtReturnSlip.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdtReturnSlip.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdtReturnSlip.CheckedState.Parent = this.rdtReturnSlip;
            this.rdtReturnSlip.Location = new System.Drawing.Point(721, 25);
            this.rdtReturnSlip.Name = "rdtReturnSlip";
            this.rdtReturnSlip.ShadowDecoration.Parent = this.rdtReturnSlip;
            this.rdtReturnSlip.Size = new System.Drawing.Size(20, 20);
            this.rdtReturnSlip.TabIndex = 33;
            this.rdtReturnSlip.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdtReturnSlip.UncheckedState.BorderThickness = 2;
            this.rdtReturnSlip.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdtReturnSlip.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdtReturnSlip.UncheckedState.Parent = this.rdtReturnSlip;
            this.rdtReturnSlip.CheckedChanged += new System.EventHandler(this.rdtReturnSlip_CheckedChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(540, 21);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 29);
            this.guna2HtmlLabel1.TabIndex = 34;
            this.guna2HtmlLabel1.Text = "Phiếu Thuê";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(757, 21);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(93, 29);
            this.guna2HtmlLabel2.TabIndex = 34;
            this.guna2HtmlLabel2.Text = "Phiếu Trả";
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBill.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBill.EnableHeadersVisualStyles = false;
            this.dtgvBill.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvBill.Location = new System.Drawing.Point(12, 61);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowTemplate.DividerHeight = 1;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBill.Size = new System.Drawing.Size(1117, 576);
            this.dtgvBill.TabIndex = 37;
            this.dtgvBill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dtgvBill.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvBill.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgvBill.ThemeStyle.ReadOnly = true;
            this.dtgvBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvBill.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnRevenue
            // 
            this.btnRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevenue.CheckedState.Parent = this.btnRevenue;
            this.btnRevenue.CustomImages.Parent = this.btnRevenue;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.HoverState.Parent = this.btnRevenue;
            this.btnRevenue.Location = new System.Drawing.Point(918, 14);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.ShadowDecoration.Parent = this.btnRevenue;
            this.btnRevenue.Size = new System.Drawing.Size(191, 38);
            this.btnRevenue.TabIndex = 38;
            this.btnRevenue.Text = "REVENUE";
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // frmTransactiInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 649);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.dtgvBill);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.rdtReturnSlip);
            this.Controls.Add(this.rdtRentalSlip);
            this.Controls.Add(this.txbSeacrh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactiInvoice";
            this.Text = "frmTransactiInvoice";
            this.Load += new System.EventHandler(this.frmTransactiInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txbSeacrh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBill;
        public Guna.UI2.WinForms.Guna2GradientButton btnRevenue;
        public Guna.UI2.WinForms.Guna2CustomRadioButton rdtRentalSlip;
        public Guna.UI2.WinForms.Guna2CustomRadioButton rdtReturnSlip;
    }
}