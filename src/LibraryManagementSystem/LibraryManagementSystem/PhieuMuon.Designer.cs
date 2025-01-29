
namespace LibraryManagementSystem
{
    partial class PhieuMuon
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

        #region Component Designer generated code

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.MAPHIEUMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANGUOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRADUKIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtpNgayTraDuKien = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMaNguoiDung = new System.Windows.Forms.ComboBox();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSoLuongSach = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhieuMuon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimPhieu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.label29 = new System.Windows.Forms.Label();
            this.MAPHIEUMUON1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANGUOIDUNG1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASACH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYMUON1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGSACH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRADUKIEN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.panel8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 692);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1180, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lập phiếu mượn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dgvPhieuMuon);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(403, 5);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(737, 647);
            this.panel7.TabIndex = 9;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuMuon.ColumnHeadersHeight = 29;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEUMUON,
            this.MANGUOIDUNG,
            this.MASACH,
            this.NGAYMUON,
            this.SOLUONGSACH,
            this.NGAYTRADUKIEN});
            this.dgvPhieuMuon.EnableHeadersVisualStyles = false;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(25, 74);
            this.dgvPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuMuon.RowHeadersVisible = false;
            this.dgvPhieuMuon.RowHeadersWidth = 51;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(687, 548);
            this.dgvPhieuMuon.TabIndex = 3;
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
            // 
            // MAPHIEUMUON
            // 
            this.MAPHIEUMUON.DataPropertyName = "MAPHIEUMUON";
            this.MAPHIEUMUON.HeaderText = "Mã Phiếu Mượn";
            this.MAPHIEUMUON.MinimumWidth = 6;
            this.MAPHIEUMUON.Name = "MAPHIEUMUON";
            this.MAPHIEUMUON.ReadOnly = true;
            this.MAPHIEUMUON.Width = 125;
            // 
            // MANGUOIDUNG
            // 
            this.MANGUOIDUNG.DataPropertyName = "MANGUOIDUNG";
            this.MANGUOIDUNG.HeaderText = "Mã Người Dùng";
            this.MANGUOIDUNG.MinimumWidth = 6;
            this.MANGUOIDUNG.Name = "MANGUOIDUNG";
            this.MANGUOIDUNG.ReadOnly = true;
            this.MANGUOIDUNG.Width = 140;
            // 
            // MASACH
            // 
            this.MASACH.DataPropertyName = "MASACH";
            this.MASACH.HeaderText = "Mã Sách";
            this.MASACH.MinimumWidth = 6;
            this.MASACH.Name = "MASACH";
            this.MASACH.ReadOnly = true;
            this.MASACH.Width = 125;
            // 
            // NGAYMUON
            // 
            this.NGAYMUON.DataPropertyName = "NGAYMUON";
            this.NGAYMUON.HeaderText = "Ngày Mượn";
            this.NGAYMUON.MinimumWidth = 6;
            this.NGAYMUON.Name = "NGAYMUON";
            this.NGAYMUON.ReadOnly = true;
            this.NGAYMUON.Width = 125;
            // 
            // SOLUONGSACH
            // 
            this.SOLUONGSACH.DataPropertyName = "SOLUONGSACH";
            this.SOLUONGSACH.HeaderText = "Số Lượng Sách";
            this.SOLUONGSACH.MinimumWidth = 6;
            this.SOLUONGSACH.Name = "SOLUONGSACH";
            this.SOLUONGSACH.ReadOnly = true;
            this.SOLUONGSACH.Width = 150;
            // 
            // NGAYTRADUKIEN
            // 
            this.NGAYTRADUKIEN.DataPropertyName = "NGAYTRADUKIEN";
            this.NGAYTRADUKIEN.HeaderText = "Ngày Trả Dự Kiến";
            this.NGAYTRADUKIEN.MinimumWidth = 6;
            this.NGAYTRADUKIEN.Name = "NGAYTRADUKIEN";
            this.NGAYTRADUKIEN.ReadOnly = true;
            this.NGAYTRADUKIEN.Width = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tất cả phiếu mượn";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.dtpNgayTraDuKien);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.cbMaSach);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.cbMaNguoiDung);
            this.panel8.Controls.Add(this.btnXoaPhieu);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.dtpNgayMuon);
            this.panel8.Controls.Add(this.btnHuy);
            this.panel8.Controls.Add(this.btnLapPhieu);
            this.panel8.Controls.Add(this.label22);
            this.panel8.Controls.Add(this.txtSoLuongSach);
            this.panel8.Controls.Add(this.label25);
            this.panel8.Controls.Add(this.label26);
            this.panel8.Controls.Add(this.txtMaPhieuMuon);
            this.panel8.Controls.Add(this.label27);
            this.panel8.Location = new System.Drawing.Point(4, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(370, 647);
            this.panel8.TabIndex = 8;
            // 
            // dtpNgayTraDuKien
            // 
            this.dtpNgayTraDuKien.Location = new System.Drawing.Point(156, 311);
            this.dtpNgayTraDuKien.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTraDuKien.Name = "dtpNgayTraDuKien";
            this.dtpNgayTraDuKien.Size = new System.Drawing.Size(194, 27);
            this.dtpNgayTraDuKien.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 311);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ngày trả dự kiến:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(156, 182);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(190, 28);
            this.cbMaSach.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(73, 182);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "Mã sách:";
            // 
            // cbMaNguoiDung
            // 
            this.cbMaNguoiDung.FormattingEnabled = true;
            this.cbMaNguoiDung.Location = new System.Drawing.Point(156, 143);
            this.cbMaNguoiDung.Name = "cbMaNguoiDung";
            this.cbMaNguoiDung.Size = new System.Drawing.Size(190, 28);
            this.cbMaNguoiDung.TabIndex = 22;
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btnXoaPhieu.FlatAppearance.BorderSize = 0;
            this.btnXoaPhieu.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoaPhieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoaPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.Location = new System.Drawing.Point(193, 531);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(132, 42);
            this.btnXoaPhieu.TabIndex = 21;
            this.btnXoaPhieu.Text = "XÓA";
            this.btnXoaPhieu.UseVisualStyleBackColor = false;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "Lập phiếu mượn";
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(156, 225);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(194, 27);
            this.dtpNgayMuon.TabIndex = 19;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(193, 471);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 42);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btnLapPhieu.FlatAppearance.BorderSize = 0;
            this.btnLapPhieu.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLapPhieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLapPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapPhieu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(35, 471);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(132, 42);
            this.btnLapPhieu.TabIndex = 15;
            this.btnLapPhieu.Text = "LẬP";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(49, 225);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 21);
            this.label22.TabIndex = 13;
            this.label22.Text = "Ngày mượn:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuongSach
            // 
            this.txtSoLuongSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongSach.Location = new System.Drawing.Point(156, 267);
            this.txtSoLuongSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongSach.Name = "txtSoLuongSach";
            this.txtSoLuongSach.Size = new System.Drawing.Size(194, 26);
            this.txtSoLuongSach.TabIndex = 10;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(31, 271);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 21);
            this.label25.TabIndex = 9;
            this.label25.Text = "Số lượng sách:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(27, 143);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 21);
            this.label26.TabIndex = 2;
            this.label26.Text = "Mã người dùng:";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(157, 95);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(189, 26);
            this.txtMaPhieuMuon.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(23, 97);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(130, 21);
            this.label27.TabIndex = 0;
            this.label27.Text = "Mã phiếu mượn:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1180, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tra cứu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhieuMuon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnTimPhieu);
            this.panel1.Location = new System.Drawing.Point(33, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 621);
            this.panel1.TabIndex = 8;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(150, 253);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(194, 27);
            this.dtpDenNgay.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Đến ngày:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(147, 215);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(194, 27);
            this.dtpTuNgay.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Từ ngày:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhieuMuon
            // 
            this.txtPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuMuon.Location = new System.Drawing.Point(29, 167);
            this.txtPhieuMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhieuMuon.Name = "txtPhieuMuon";
            this.txtPhieuMuon.Size = new System.Drawing.Size(315, 26);
            this.txtPhieuMuon.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nhập thông tin phiếu mượn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tra cứu phiếu mượn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(212, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "HỦY";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.btnTimPhieu.FlatAppearance.BorderSize = 0;
            this.btnTimPhieu.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTimPhieu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTimPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimPhieu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieu.ForeColor = System.Drawing.Color.White;
            this.btnTimPhieu.Location = new System.Drawing.Point(29, 312);
            this.btnTimPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.Size = new System.Drawing.Size(132, 42);
            this.btnTimPhieu.TabIndex = 15;
            this.btnTimPhieu.Text = "TÌM KIẾM";
            this.btnTimPhieu.UseVisualStyleBackColor = false;
            this.btnTimPhieu.Click += new System.EventHandler(this.btnTimPhieu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvKetQuaTimKiem);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Location = new System.Drawing.Point(411, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 622);
            this.panel2.TabIndex = 9;
            // 
            // dgvKetQuaTimKiem
            // 
            this.dgvKetQuaTimKiem.AllowUserToAddRows = false;
            this.dgvKetQuaTimKiem.AllowUserToDeleteRows = false;
            this.dgvKetQuaTimKiem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKetQuaTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQuaTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKetQuaTimKiem.ColumnHeadersHeight = 29;
            this.dgvKetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKetQuaTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEUMUON1,
            this.MANGUOIDUNG1,
            this.MASACH1,
            this.NGAYMUON1,
            this.SOLUONGSACH1,
            this.NGAYTRADUKIEN1});
            this.dgvKetQuaTimKiem.EnableHeadersVisualStyles = false;
            this.dgvKetQuaTimKiem.Location = new System.Drawing.Point(20, 71);
            this.dgvKetQuaTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            this.dgvKetQuaTimKiem.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQuaTimKiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKetQuaTimKiem.RowHeadersVisible = false;
            this.dgvKetQuaTimKiem.RowHeadersWidth = 51;
            this.dgvKetQuaTimKiem.Size = new System.Drawing.Size(695, 532);
            this.dgvKetQuaTimKiem.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(20, 22);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 29);
            this.label29.TabIndex = 0;
            this.label29.Text = "Kết quả";
            // 
            // MAPHIEUMUON1
            // 
            this.MAPHIEUMUON1.DataPropertyName = "MAPHIEUMUON";
            this.MAPHIEUMUON1.HeaderText = "Mã Phiếu Mượn";
            this.MAPHIEUMUON1.MinimumWidth = 6;
            this.MAPHIEUMUON1.Name = "MAPHIEUMUON1";
            this.MAPHIEUMUON1.ReadOnly = true;
            this.MAPHIEUMUON1.Width = 140;
            // 
            // MANGUOIDUNG1
            // 
            this.MANGUOIDUNG1.DataPropertyName = "MANGUOIDUNG";
            this.MANGUOIDUNG1.HeaderText = "Mã Người Dùng";
            this.MANGUOIDUNG1.MinimumWidth = 6;
            this.MANGUOIDUNG1.Name = "MANGUOIDUNG1";
            this.MANGUOIDUNG1.ReadOnly = true;
            this.MANGUOIDUNG1.Width = 140;
            // 
            // MASACH1
            // 
            this.MASACH1.DataPropertyName = "MASACH";
            this.MASACH1.HeaderText = "Mã Sách";
            this.MASACH1.MinimumWidth = 6;
            this.MASACH1.Name = "MASACH1";
            this.MASACH1.ReadOnly = true;
            this.MASACH1.Width = 125;
            // 
            // NGAYMUON1
            // 
            this.NGAYMUON1.DataPropertyName = "NGAYMUON";
            this.NGAYMUON1.HeaderText = "Ngày Mượn";
            this.NGAYMUON1.MinimumWidth = 6;
            this.NGAYMUON1.Name = "NGAYMUON1";
            this.NGAYMUON1.ReadOnly = true;
            this.NGAYMUON1.Width = 125;
            // 
            // SOLUONGSACH1
            // 
            this.SOLUONGSACH1.DataPropertyName = "SOLUONGSACH";
            this.SOLUONGSACH1.HeaderText = "Số Lượng Sách";
            this.SOLUONGSACH1.MinimumWidth = 6;
            this.SOLUONGSACH1.Name = "SOLUONGSACH1";
            this.SOLUONGSACH1.ReadOnly = true;
            this.SOLUONGSACH1.Width = 140;
            // 
            // NGAYTRADUKIEN1
            // 
            this.NGAYTRADUKIEN1.DataPropertyName = "NGAYTRADUKIEN";
            this.NGAYTRADUKIEN1.HeaderText = "Ngày Trả Dự Kiến";
            this.NGAYTRADUKIEN1.MinimumWidth = 6;
            this.NGAYTRADUKIEN1.Name = "NGAYTRADUKIEN1";
            this.NGAYTRADUKIEN1.ReadOnly = true;
            this.NGAYTRADUKIEN1.Width = 160;
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuMuon";
            this.Size = new System.Drawing.Size(1173, 695);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dtpNgayTraDuKien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbMaNguoiDung;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtSoLuongSach;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimPhieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKetQuaTimKiem;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUMUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANGUOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMUON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRADUKIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEUMUON1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANGUOIDUNG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMUON1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGSACH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRADUKIEN1;
    }
}
