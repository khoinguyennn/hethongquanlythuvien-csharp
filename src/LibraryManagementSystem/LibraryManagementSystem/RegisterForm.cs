using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        KetNoiDuLieu xulydl;
        public RegisterForm()
        {
            InitializeComponent();
            xulydl = new KetNoiDuLieu();
            if (xulydl.MoKetNoi())
            {
                //MessageBox.Show("Kết nối cơ sở dữ liệu thành công", "Thông báo");
            }
            else 
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công", "Thông báo");

            }

        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void clear()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String chuoi = "insert into User (Email, Username, Password) values ('" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
                xulydl.ThemDL(chuoi);
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo");
                clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }
    }
}
