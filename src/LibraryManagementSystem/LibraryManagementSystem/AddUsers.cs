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
    public partial class AddUsers : UserControl
    {
        KetNoiDuLieu xulydl;
        public AddUsers()
        {
            InitializeComponent();
            xulydl = new KetNoiDuLieu();

            if (xulydl.MoKetNoi())
            {
                //MessageBox.Show("Kết nối cơ sở dữ liệu thành công", "Thông báo");
                hienthinguoidung();


            }
            else
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công", "Thông báo");

            }
            btnXoaNguoiDung.Enabled = false;
            btnCapNhatNguoiDung.Enabled = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public void refreshData()
        {
            clear();

        }

        void hienthinguoidung()
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from NGUOIDUNG";
            bang = xulydl.LayBayDL(chuoi);
            dgvNguoiDung.DataSource = bang;
        }

        private void btnHuyNguoiDung_Click(object sender, EventArgs e)
        {
            clear();
        }


        void clear()
        {
            txtMaNguoiDung.Clear();
            txtTenNguoiDung.Clear();
            cbLoaiNguoiDung.SelectedValue = -1;
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtThongTinBoSung.Clear();
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            String chuoi = "insert into NGUOIDUNG (MANGUOIDUNG, TENNGUOIDUNG, LOAINGUOIDUNG, SODIENTHOAI, EMAIL, DIACHI, THONGTINBOSUNG) values ('" + txtMaNguoiDung.Text + "','" + txtTenNguoiDung.Text + "','"+cbLoaiNguoiDung.Text+"','"+txtSoDienThoai.Text+"','"+txtEmail.Text+"','"+txtDiaChi.Text+"','"+txtThongTinBoSung.Text+"')";
            xulydl.ThemDL(chuoi);
            MessageBox.Show("Thêm người dùng thành công thành công!", "Thông báo");
            hienthinguoidung();
            clear();
        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvNguoiDung.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                txtMaNguoiDung.Text = row.Cells["MANGUOIDUNG"].Value.ToString();
                txtTenNguoiDung.Text = row.Cells["TENNGUOIDUNG"].Value.ToString();
                cbLoaiNguoiDung.Text = row.Cells["LOAINGUOIDUNG"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SODIENTHOAI"].Value.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
                txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
                txtThongTinBoSung.Text = row.Cells["THONGTINBOSUNG"].Value.ToString();

                // Hiển thị nút Xóa
                btnXoaNguoiDung.Enabled = true;
                btnCapNhatNguoiDung.Enabled = true;
            }
        }

        private void btnXoaNguoiDung_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để xóa
                string chuoi = "DELETE FROM NGUOIDUNG WHERE MANGUOIDUNG = '" + txtMaNguoiDung.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo xóa thành công
                MessageBox.Show("Xóa người dùng thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthinguoidung();

                // Xóa dữ liệu trong TextBox và ẩn nút Xóa
                clear();
                btnXoaNguoiDung.Enabled = false;
                btnCapNhatNguoiDung.Enabled = false;
            }
        }

        private void btnCapNhatNguoiDung_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để cập nhật
                String chuoi = "UPDATE NGUOIDUNG SET TENNGUOIDUNG = '" + txtTenNguoiDung.Text + "', LOAINGUOIDUNG ='" + cbLoaiNguoiDung.Text + "', SODIENTHOAI = '" + txtSoDienThoai.Text + "', EMAIL = '" + txtEmail.Text + "', DIACHI = '" + txtDiaChi.Text + "', THONGTINBOSUNG = '" + txtThongTinBoSung.Text + "' WHERE MANGUOIDUNG = '" + txtMaNguoiDung.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo cập nhật thành công
                MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthinguoidung();

                // Xóa dữ liệu trong TextBox và ẩn nút Cập nhật
                clear();
                btnXoaNguoiDung.Enabled = false;
                btnCapNhatNguoiDung.Enabled = false;
            }
        }
        void timkiemnguoidung()
        {
            string tuKhoa = txtTraCuuNguoiDung.Text.Trim();
            string chuoi = "SELECT * FROM NGUOIDUNG WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                chuoi += " AND (MANGUOIDUNG LIKE '%" + tuKhoa + "%'" +
                         " OR TENNGUOIDUNG LIKE '%" + tuKhoa + "%'" +
                         " OR LOAINGUOIDUNG LIKE '%" + tuKhoa + "%'" +
                         " OR SODIENTHOAI LIKE '%" + tuKhoa + "%'" +
                         " OR EMAIL LIKE '%" + tuKhoa + "%'" +
                         " OR DIACHI LIKE '%" + tuKhoa + "%'" +
                         " OR THONGTINBOSUNG LIKE '%" + tuKhoa + "%')";
            }

            DataTable bang = xulydl.LayBayDL(chuoi);

            if (bang.Rows.Count > 0)
            {
                dgvkqNguoiDung.DataSource = bang;
            }
            else
            {
                dgvkqNguoiDung.DataSource = null;
                MessageBox.Show("Không tìm thấy người dùng nào phù hợp!", "Thông báo");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timkiemnguoidung();
        }
    }
}
