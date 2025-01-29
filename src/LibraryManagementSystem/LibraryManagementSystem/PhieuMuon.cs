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
    public partial class PhieuMuon : UserControl
    {

        KetNoiDuLieu xulydl;
        public PhieuMuon()
        {
            InitializeComponent();
            xulydl = new KetNoiDuLieu();

            if (xulydl.MoKetNoi())
            {
                //MessageBox.Show("Kết nối cơ sở dữ liệu thành công", "Thông báo");
                hienthiphieu();
                loadnguoidung();
                loadmasach();
            }
            else
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công", "Thông báo");

            }
            btnXoaPhieu.Enabled = false;
            
        }

        public void refreshData()
        {
            hienthiphieu();
            loadnguoidung();
            loadmasach();
            clear();

        }

        void hienthiphieu()
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from PHIEUMUON";
            bang = xulydl.LayBayDL(chuoi);
            dgvPhieuMuon.DataSource = bang;
        }

        void loadnguoidung()
        {
            String chuoi = "select * from NGUOIDUNG";
            cbMaNguoiDung.DataSource = xulydl.LayBayDL(chuoi);
            cbMaNguoiDung.DisplayMember = "MANGUOIDUNG";
            cbMaNguoiDung.ValueMember = "MANGUOIDUNG";
        }

        void loadmasach()
        {
            String chuoi = "select * from SACH";
            cbMaSach.DataSource = xulydl.LayBayDL(chuoi);
            cbMaSach.DisplayMember = "MASACH";
            cbMaSach.ValueMember = "MASACH";
        }


        void clear()
        {
            txtMaPhieuMuon.Clear();
            cbMaNguoiDung.SelectedValue = -1;
            cbMaSach.SelectedValue = -1;
            txtSoLuongSach.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(txtMaPhieuMuon.Text) ||
                    cbMaNguoiDung.SelectedValue == null ||
                    cbMaSach.SelectedValue == null ||
                    string.IsNullOrEmpty(txtSoLuongSach.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                int soLuongMuon = int.Parse(txtSoLuongSach.Text);

                // Lấy số lượng còn lại hiện tại của sách
                String maSach = cbMaSach.SelectedValue.ToString();
                String querySoLuongConLai = $"SELECT SOLUONGCONLAI FROM SACH WHERE MASACH = '{maSach}'";
                DataTable result = xulydl.LayBayDL(querySoLuongConLai);

                if (result.Rows.Count > 0)
                {
                    int soLuongConLai = int.Parse(result.Rows[0]["SOLUONGCONLAI"].ToString());

                    // Kiểm tra số lượng sách đủ để mượn
                    if (soLuongMuon > soLuongConLai)
                    {
                        MessageBox.Show("Không đủ số lượng sách để mượn!", "Thông báo");
                        return;
                    }

                    // Giảm số lượng còn lại trong bảng SACH
                    int soLuongMoi = soLuongConLai - soLuongMuon;
                    String queryCapNhatSoLuong = $"UPDATE SACH SET SOLUONGCONLAI = {soLuongMoi} WHERE MASACH = '{maSach}'";
                    xulydl.ThemDL(queryCapNhatSoLuong);

                    // Thêm phiếu mượn vào bảng PHIEUMUON
                    String ngayMuon = dtpNgayMuon.Value.ToString("yyyy-MM-dd");
                    String ngayTraDuKien = dtpNgayTraDuKien.Value.ToString("yyyy-MM-dd");

                    String queryLapPhieu = "INSERT INTO PHIEUMUON (MAPHIEUMUON, MANGUOIDUNG, MASACH, NGAYMUON, SOLUONGSACH, NGAYTRADUKIEN) " +
                                           $"VALUES ('{txtMaPhieuMuon.Text}', '{cbMaNguoiDung.SelectedValue}', '{cbMaSach.SelectedValue}', " +
                                           $"'{ngayMuon}', {soLuongMuon}, '{ngayTraDuKien}')";
                    xulydl.ThemDL(queryLapPhieu);

                    MessageBox.Show("Lập phiếu mượn thành công!", "Thông báo");

                    // Cập nhật lại danh sách phiếu mượn và làm trống các trường nhập liệu
                    hienthiphieu();
                    clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo");
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để xóa
                string chuoi = "DELETE FROM PHIEUMUON WHERE MAPHIEUMUON = '" + txtMaPhieuMuon.Text + "'";
                xulydl.ThemDL(chuoi);

                // Thông báo xóa thành công
                MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthiphieu();

                // Xóa dữ liệu trong TextBox và ẩn nút Xóa
                clear();
                btnXoaPhieu.Enabled = false;
            }
        }

        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvPhieuMuon.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                txtMaPhieuMuon.Text = row.Cells["MAPHIEUMUON"].Value.ToString();
                cbMaNguoiDung.Text = row.Cells["MANGUOIDUNG"].Value.ToString();
                cbMaSach.Text = row.Cells["MASACH"].Value.ToString();
                dtpNgayMuon.Text = row.Cells["NGAYMUON"].Value.ToString();
                txtSoLuongSach.Text = row.Cells["SOLUONGSACH"].Value.ToString();
                dtpNgayTraDuKien.Text = row.Cells["NGAYTRADUKIEN"].Value.ToString();


                // Hiển thị nút Xóa
                btnXoaPhieu.Enabled = true;
            }
        }

        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
            string maPhieuMuon = txtPhieuMuon.Text.Trim();
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo");
                return;
            }

            // Gọi phương thức tìm kiếm
            DataTable ketQua = xulydl.TimKiemPhieuMuon(maPhieuMuon, tuNgay, denNgay);

            if (ketQua.Rows.Count > 0)
            {
                dgvKetQuaTimKiem.DataSource = ketQua; // Hiển thị kết quả lên DataGridView
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu mượn nào phù hợp!", "Thông báo");
                dgvKetQuaTimKiem.DataSource = null;
            }
        }
    }
}
