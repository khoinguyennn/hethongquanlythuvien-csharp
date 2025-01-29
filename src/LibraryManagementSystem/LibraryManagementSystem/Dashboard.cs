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
    public partial class Dashboard : UserControl
    {
        KetNoiDuLieu xulydl;

        public Dashboard()
        {
            InitializeComponent();
            hienThiTongSach();
            hienThiTongSachMuon();
            hienthiTongNguoiDung();

        }

        public void refreshData()
        {

            hienThiTongSach();
            hienThiTongSachMuon();
            hienthiTongNguoiDung();

        }

        void hienThiTongSach()
        {
            xulydl = new KetNoiDuLieu();
            string chuoi = "SELECT SUM(SOLUONGCONLAI) FROM SACH";
            int tong = xulydl.LayTongSach(chuoi);
            txtTongSach.Text = tong.ToString();
        }


        void hienThiTongSachMuon()
        {
            xulydl = new KetNoiDuLieu();
            string chuoi = "SELECT SUM(SOLUONGSACH) FROM PHIEUMUON";
            int tong = xulydl.LayTongSach(chuoi);
            txtTongSachMuon.Text = tong.ToString();
        }

        void hienthiTongNguoiDung()
        {
            if (xulydl != null && xulydl.MoKetNoi())
            {
                int tongNguoiDung = xulydl.DemSoNguoiDung();
                txtTongNguoiDung.Text = tongNguoiDung.ToString(); // Gán tổng số người dùng vào TextBox
            }
            else
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu để đếm số người dùng!", "Thông báo");
            }
        }
    }
}
