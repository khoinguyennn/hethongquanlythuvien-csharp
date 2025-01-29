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
using System.Data.Sql;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {
        KetNoiDuLieu xulydl;
        public AddBooks()
        {
            InitializeComponent();
            xulydl = new KetNoiDuLieu();

            if (xulydl.MoKetNoi())
            {
                //MessageBox.Show("Kết nối cơ sở dữ liệu thành công", "Thông báo");
                hienthisach();
                hienthidanhmuc();
                hienthitacgia();
                loaddanhmuc();
                loadtacgia();
                cbMaDanhMuc.SelectedValue = -1;
                cbMaTacGia.SelectedValue = -1;


            }
            else
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công", "Thông báo");

            }
            btnXoaTacGia.Enabled = false;
            btnCapNhatTacGia.Enabled = false;
        }

        void hienthisach()
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from SACH";
            bang = xulydl.LayBayDL(chuoi);
            dgvSach.DataSource = bang;
        }

        void hienthitacgia()
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from TACGIA";
            bang = xulydl.LayBayDL(chuoi);
            dgvTacGia.DataSource = bang;
        }

        void hienthidanhmuc()
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from DANHMUC";
            bang = xulydl.LayBayDL(chuoi);
            dgvDanhMuc.DataSource = bang;
        }


        void loaddanhmuc()
        {
            String chuoi = "select * from DANHMUC";
            cbMaDanhMuc.DataSource = xulydl.LayBayDL(chuoi);
            cbMaDanhMuc.DisplayMember = "MADANHMUC";
            cbMaDanhMuc.ValueMember = "MADANHMUC";
        }

        void loadtacgia()
        {
            String chuoi = "select * from TACGIA";
            cbMaTacGia.DataSource = xulydl.LayBayDL(chuoi);
            cbMaTacGia.DisplayMember = "MATACGIA";
            cbMaTacGia.ValueMember = "MATACGIA";
        }

        public void refreshData()
        {
            hienthisach();
            hienthidanhmuc();
            hienthitacgia();
            loaddanhmuc();
            loadtacgia();
            cbMaDanhMuc.SelectedValue = -1;
            cbMaTacGia.SelectedValue = -1;
            cleardanhmuc();
            clearsach();
            cleartacgia();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để xóa
                string chuoi = "DELETE FROM TACGIA WHERE MATACGIA = '" + txtMaTacGia.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo xóa thành công
                MessageBox.Show("Xóa tác giả thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthitacgia();

                // Xóa dữ liệu trong TextBox và ẩn nút Xóa
                cleartacgia();
                btnXoaTacGia.Enabled = false;
                btnCapNhatTacGia.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để cập nhật
                String chuoi = "UPDATE TACGIA SET TENTACGIA = N'" + txtTenTacGia.Text + "' WHERE MATACGIA = '" + txtMaTacGia.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo cập nhật thành công
                MessageBox.Show("Cập nhật tác giả thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthitacgia();

                // Xóa dữ liệu trong TextBox và ẩn nút Cập nhật
                cleartacgia();
                btnCapNhatTacGia.Enabled = false;
                btnXoaTacGia.Enabled =false;
            }
        }



        private void btnThemTacGia_Click_1(object sender, EventArgs e)
        {
            String chuoi = "insert into TACGIA (MATACGIA, TENTACGIA) values ('" + txtMaTacGia.Text + "',N'" + txtTenTacGia.Text + "')";
            xulydl.ThemDL(chuoi);
            MessageBox.Show("Thêm tác giả thành công thành công!", "Thông báo");
            hienthitacgia();
            cleartacgia();
        }

        private void dgvTacGia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvTacGia.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                txtMaTacGia.Text = row.Cells["MaTacGia1"].Value.ToString();
                txtTenTacGia.Text = row.Cells["TENTACGIA"].Value.ToString();

                // Hiển thị nút Xóa
                btnXoaTacGia.Enabled = true;
                btnCapNhatTacGia.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cleartacgia();
        }

        void cleartacgia()
        {
            txtMaTacGia.Clear();
            txtTenTacGia.Clear();
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                txtMaDanhMuc.Text = row.Cells["MADANHMUC1"].Value.ToString();
                txtTenDanhMuc.Text = row.Cells["TENDANHMUC"].Value.ToString();
                txtMoTaDanhMuc.Text = row.Cells["MOTADANHMUC"].Value.ToString();

                // Hiển thị nút Xóa
                btnXoaDanhMuc.Enabled = true;
                btnCapNhatDanhMuc.Enabled = true;
            }
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            String chuoi = "insert into DANHMUC (MADANHMUC, TENDANHMUC, MOTADANHMUC) values ('" + txtMaDanhMuc.Text + "','" + txtTenDanhMuc.Text + "','" + txtMoTaDanhMuc.Text + "')";
            xulydl.ThemDL(chuoi);
            MessageBox.Show("Thêm tác danh mục thành công!", "Thông báo");
            hienthidanhmuc();
            cleardanhmuc();
        }

        private void btnCapNhatDanhMuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để cập nhật
                String chuoi = "UPDATE DANHMUC SET TENDANHMUC = '" + txtTenDanhMuc.Text + "', MOTADANHMUC ='"+txtMoTaDanhMuc.Text+"' WHERE MADANHMUC = '" + txtMaDanhMuc.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo cập nhật thành công
                MessageBox.Show("Cập nhật danh mục thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthidanhmuc();

                // Xóa dữ liệu trong TextBox và ẩn nút Cập nhật
                cleardanhmuc();
                btnCapNhatDanhMuc.Enabled = false;
                btnXoaDanhMuc.Enabled = false;
            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để xóa
                string chuoi = "DELETE FROM DANHMUC WHERE MADANHMUC = '" + txtMaDanhMuc.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo xóa thành công
                MessageBox.Show("Xóa danh mục thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthidanhmuc();

                // Xóa dữ liệu trong TextBox và ẩn nút Xóa
                cleardanhmuc() ;
                btnXoaDanhMuc.Enabled = false;
                btnCapNhatDanhMuc.Enabled = false;
            }
        }

        private void btnHuyDanhMuc_Click(object sender, EventArgs e)
        {
            cleardanhmuc();
        }

        void cleardanhmuc()
        {
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtMoTaDanhMuc.Clear();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            String chuoi = "insert into SACH (MASACH, MADANHMUC, MATACGIA, TENSACH, NAMXUATBAN, ISBN, SOLUONG, SOLUONGCONLAI, MOTASACH) " +
               "values ('" + txtMaSach.Text + "', '" + cbMaDanhMuc.SelectedValue + "', '" + cbMaTacGia.SelectedValue + "', '" +
               txtTenSach.Text + "', '" + txtNamXuatBan.Text + "', '" + txtISBN.Text + "', '" + txtSoLuong.Text + "', '" +
               txtSoLuong.Text + "', '" + txtMoTaSach.Text + "')";

            xulydl.ThemDL(chuoi);
            MessageBox.Show("Thêm tác sách thành công!", "Thông báo");
            hienthisach();
        }

        private void btnHuySach_Click(object sender, EventArgs e)
        {
            clearsach();
        }

        void clearsach()
        {
            txtMaSach.Clear();
            cbMaDanhMuc.SelectedValue = -1;
            cbMaTacGia.SelectedValue = -1;
            txtTenSach.Clear();
            txtNamXuatBan.Clear();
            txtISBN.Clear();
            txtSoLuong.Clear();
            txtMoTaSach.Clear();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                txtMaSach.Text = row.Cells["MASACH"].Value.ToString();
                cbMaDanhMuc.Text = row.Cells["MADANHMUC"].Value.ToString();
                cbMaTacGia.Text = row.Cells["MATACGIA"].Value.ToString();
                txtTenSach.Text = row.Cells["TENSACH"].Value.ToString();
                txtNamXuatBan.Text = row.Cells["NAMXUATBAN"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                txtMoTaSach.Text = row.Cells["MOTASACH"].Value.ToString();


                // Hiển thị nút Xóa
                btnXoaSach.Enabled = true;
                btnCapNhatSach.Enabled = true;
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để xóa
                string chuoi = "DELETE FROM SACH WHERE MASACH = '" + txtMaSach.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo xóa thành công
                MessageBox.Show("Xóa sách thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthisach();

                // Xóa dữ liệu trong TextBox và ẩn nút Xóa
                clearsach();
                btnXoaSach.Enabled = false;
                btnCapNhatSach.Enabled = false;
            }
        }

        private void btnCapNhatSach_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để cập nhật
                String chuoi = "UPDATE SACH SET MADANHMUC = '" + cbMaDanhMuc.SelectedValue + "', MATACGIA ='" + cbMaTacGia.SelectedValue + "', NAMXUATBAN = '"+txtNamXuatBan.Text+"', ISBN = '"+txtISBN.Text+"', SOLUONG = '"+txtSoLuong.Text+"', MOTASACH = '"+txtMoTaSach.Text+"', SOLUONGCONLAI = '"+txtSoLuong.Text+"' WHERE MASACH = '" + txtMaSach.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo cập nhật thành công
                MessageBox.Show("Cập nhật sách thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthisach();

                // Xóa dữ liệu trong TextBox và ẩn nút Cập nhật
                clearsach() ;
                btnXoaSach.Enabled = false;
                btnCapNhatSach.Enabled = false;
            }
        }

        private void btnHuyTim_Click(object sender, EventArgs e)
        {
            txtTraCuuSach.Clear();
        }

        void timKiemSach()
        {
            string tuKhoa = txtTraCuuSach.Text.Trim();
            string chuoi = "SELECT * FROM SACH WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                chuoi += " AND (TENSACH LIKE N'%" + tuKhoa + "%'" +
                         " OR MATACGIA LIKE '%" + tuKhoa + "%'" +
                         " OR MADANHMUC LIKE '%" + tuKhoa + "%'" +
                         " OR ISBN LIKE '%" + tuKhoa + "%'" +
                         " OR NAMXUATBAN LIKE '%" + tuKhoa + "%'" +
                         " OR MASACH LIKE '%" + tuKhoa + "%')";
            }

            DataTable bang = xulydl.LayBayDL(chuoi);

            if (bang.Rows.Count > 0)
            {
                dgvTraCuuSach.DataSource = bang;
            }
            else
            {
                dgvTraCuuSach.DataSource = null;
                MessageBox.Show("Không tìm thấy sách nào phù hợp!", "Thông báo");
            }
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            timKiemSach();

        }
    }
    }
