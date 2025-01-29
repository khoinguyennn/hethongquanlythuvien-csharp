using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addBooks1.Visible = false;
            addUsers1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
            thongKe1.Visible = false;

            Dashboard dForm = dashboard1 as Dashboard;
            if (dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void addBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = true;
            addUsers1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
            thongKe1.Visible = false;

            AddBooks aForm = addBooks1 as AddBooks;
            if(aForm != null)
            {
                aForm.refreshData();
            }
        }

        private void issueBooks_btn_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addBooks1.Visible = false;
            addUsers1.Visible = false;
            returnBooks1.Visible = true;
            issueBooks1.Visible = false;
            thongKe1.Visible = false;

            HoaDon iForm = issueBooks1 as HoaDon;
            if (iForm != null)
            {
                iForm.refreshData();
            }
        }

        private void returnBooks_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            addUsers1.Visible = false;
            issueBooks1.Visible = true;
            thongKe1.Visible = false;

            PhieuMuon hoadon = returnBooks1 as PhieuMuon;
            if (hoadon != null)
            {
                hoadon.refreshData();
            }
        }

        private void addUser_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            addUsers1.Visible = true;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
            thongKe1.Visible = false;

            AddUsers adduser = addUsers1 as AddUsers;
            if (adduser != null)
            {
                adduser.refreshData();
            }
        }

        private void ThongKe_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            addUsers1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
            thongKe1.Visible = true;

            ThongKe thongke = thongKe1 as ThongKe;
            if (thongke != null)
            {
                thongke.refreshData();
            }
        }
    }
}

