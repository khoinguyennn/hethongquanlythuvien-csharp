
namespace LibraryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ThongKe_btn = new System.Windows.Forms.Button();
            this.addUser_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.HoaDon_btn = new System.Windows.Forms.Button();
            this.PhieuMuon_btn = new System.Windows.Forms.Button();
            this.addBooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.thongKe1 = new LibraryManagementSystem.ThongKe();
            this.addUsers1 = new LibraryManagementSystem.AddUsers();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.issueBooks1 = new LibraryManagementSystem.HoaDon();
            this.returnBooks1 = new LibraryManagementSystem.PhieuMuon();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 43);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ thống quản lý thư viện THPT Tập Sơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1443, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ThongKe_btn);
            this.panel2.Controls.Add(this.addUser_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.HoaDon_btn);
            this.panel2.Controls.Add(this.PhieuMuon_btn);
            this.panel2.Controls.Add(this.addBooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_label);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 695);
            this.panel2.TabIndex = 1;
            // 
            // ThongKe_btn
            // 
            this.ThongKe_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThongKe_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ThongKe_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.ThongKe_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThongKe_btn.ForeColor = System.Drawing.Color.White;
            this.ThongKe_btn.Image = ((System.Drawing.Image)(resources.GetObject("ThongKe_btn.Image")));
            this.ThongKe_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKe_btn.Location = new System.Drawing.Point(12, 544);
            this.ThongKe_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ThongKe_btn.Name = "ThongKe_btn";
            this.ThongKe_btn.Size = new System.Drawing.Size(267, 55);
            this.ThongKe_btn.TabIndex = 9;
            this.ThongKe_btn.Text = "THỐNG KÊ";
            this.ThongKe_btn.UseVisualStyleBackColor = true;
            this.ThongKe_btn.Click += new System.EventHandler(this.ThongKe_btn_Click);
            // 
            // addUser_btn
            // 
            this.addUser_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addUser_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser_btn.ForeColor = System.Drawing.Color.White;
            this.addUser_btn.Image = ((System.Drawing.Image)(resources.GetObject("addUser_btn.Image")));
            this.addUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addUser_btn.Location = new System.Drawing.Point(12, 352);
            this.addUser_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(267, 55);
            this.addUser_btn.TabIndex = 8;
            this.addUser_btn.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 654);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đăng xuất";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(11, 642);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(47, 43);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // HoaDon_btn
            // 
            this.HoaDon_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoaDon_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.HoaDon_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.HoaDon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoaDon_btn.ForeColor = System.Drawing.Color.White;
            this.HoaDon_btn.Image = ((System.Drawing.Image)(resources.GetObject("HoaDon_btn.Image")));
            this.HoaDon_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HoaDon_btn.Location = new System.Drawing.Point(11, 479);
            this.HoaDon_btn.Margin = new System.Windows.Forms.Padding(4);
            this.HoaDon_btn.Name = "HoaDon_btn";
            this.HoaDon_btn.Size = new System.Drawing.Size(267, 55);
            this.HoaDon_btn.TabIndex = 5;
            this.HoaDon_btn.Text = "QUẢN LÝ HÓA ĐƠN";
            this.HoaDon_btn.UseVisualStyleBackColor = true;
            this.HoaDon_btn.Click += new System.EventHandler(this.returnBooks_btn_Click);
            // 
            // PhieuMuon_btn
            // 
            this.PhieuMuon_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PhieuMuon_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.PhieuMuon_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.PhieuMuon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhieuMuon_btn.ForeColor = System.Drawing.Color.White;
            this.PhieuMuon_btn.Image = ((System.Drawing.Image)(resources.GetObject("PhieuMuon_btn.Image")));
            this.PhieuMuon_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhieuMuon_btn.Location = new System.Drawing.Point(11, 414);
            this.PhieuMuon_btn.Margin = new System.Windows.Forms.Padding(4);
            this.PhieuMuon_btn.Name = "PhieuMuon_btn";
            this.PhieuMuon_btn.Size = new System.Drawing.Size(267, 55);
            this.PhieuMuon_btn.TabIndex = 4;
            this.PhieuMuon_btn.Text = "QUẢN LÝ PHIẾU MƯỢN";
            this.PhieuMuon_btn.UseVisualStyleBackColor = true;
            this.PhieuMuon_btn.Click += new System.EventHandler(this.issueBooks_btn_Click);
            // 
            // addBooks_btn
            // 
            this.addBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addBooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_btn.ForeColor = System.Drawing.Color.White;
            this.addBooks_btn.Image = ((System.Drawing.Image)(resources.GetObject("addBooks_btn.Image")));
            this.addBooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBooks_btn.Location = new System.Drawing.Point(11, 290);
            this.addBooks_btn.Margin = new System.Windows.Forms.Padding(4);
            this.addBooks_btn.Name = "addBooks_btn";
            this.addBooks_btn.Size = new System.Drawing.Size(267, 55);
            this.addBooks_btn.TabIndex = 3;
            this.addBooks_btn.Text = "QUẢN LÝ SÁCH";
            this.addBooks_btn.UseVisualStyleBackColor = true;
            this.addBooks_btn.Click += new System.EventHandler(this.addBooks_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_btn.Image")));
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(11, 228);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(267, 55);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "TRANG CHỦ";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_label.ForeColor = System.Drawing.Color.White;
            this.greet_label.Location = new System.Drawing.Point(68, 163);
            this.greet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(154, 24);
            this.greet_label.TabIndex = 1;
            this.greet_label.Text = "Xin chào, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.thongKe1);
            this.panel3.Controls.Add(this.addUsers1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(293, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1174, 695);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, -1);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1173, 695);
            this.dashboard1.TabIndex = 5;
            // 
            // thongKe1
            // 
            this.thongKe1.Location = new System.Drawing.Point(0, -2);
            this.thongKe1.Margin = new System.Windows.Forms.Padding(4);
            this.thongKe1.Name = "thongKe1";
            this.thongKe1.Size = new System.Drawing.Size(1173, 695);
            this.thongKe1.TabIndex = 4;
            // 
            // addUsers1
            // 
            this.addUsers1.Location = new System.Drawing.Point(0, 0);
            this.addUsers1.Name = "addUsers1";
            this.addUsers1.Padding = new System.Windows.Forms.Padding(3);
            this.addUsers1.Size = new System.Drawing.Size(1174, 695);
            this.addUsers1.TabIndex = 3;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(1173, 695);
            this.addBooks1.TabIndex = 2;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(1173, 695);
            this.issueBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Margin = new System.Windows.Forms.Padding(5);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(1173, 695);
            this.returnBooks1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 738);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBooks_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HoaDon_btn;
        private System.Windows.Forms.Button PhieuMuon_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private PhieuMuon returnBooks1;
        private AddBooks addBooks1;
        private HoaDon issueBooks1;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.Button ThongKe_btn;
        private AddUsers addUsers1;
        private Dashboard dashboard1;
        private ThongKe thongKe1;
    }
}