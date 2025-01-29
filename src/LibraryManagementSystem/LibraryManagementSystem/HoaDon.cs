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
using System.Drawing.Printing;


namespace LibraryManagementSystem
{
    public partial class HoaDon : UserControl
    {
        KetNoiDuLieu xulydl;
        List<string> danhSachDaLapHoaDon = new List<string>();
        private PrintDocument printDocument = new PrintDocument();
        private string hoaDonContent = ""; // Nội dung hóa đơn để in

        public HoaDon()
        {
            InitializeComponent();
            printDocument.PrintPage += printDocument_PrintPage;
            xulydl = new KetNoiDuLieu();

            if (xulydl.MoKetNoi())
            {
                //MessageBox.Show("Kết nối cơ sở dữ liệu thành công", "Thông báo");
                hienthiphieumuon();
                hienthihoadon();
                btnXoaHoaDon.Enabled = false;

            }
            else
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công", "Thông báo");
            }
        }

        public void refreshData()
        {
            hienthiphieumuon();
            clear();
        }

        void hienthiphieumuon()
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from PHIEUMUON";
            bang = xulydl.LayBayDL(chuoi);
            dgvPhieuMuon.DataSource = bang;

            // Tô màu các dòng đã lập hóa đơn
            foreach (DataGridViewRow row in dgvPhieuMuon.Rows)
            {
                if (row.Cells["MAPHIEUMUON"].Value != null && danhSachDaLapHoaDon.Contains(row.Cells["MAPHIEUMUON"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black; // Nếu cần, thay đổi màu chữ
                }
            }
        }

        void hienthihoadon()
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from HOADONTRASACH";
            bang = xulydl.LayBayDL(chuoi);
            dgvHoaDon.DataSource = bang;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            clear();
        }


        void clear()
        {
            txtMaHoaDon.Clear();
            txtMaPhieuMuon.Clear();
            txtTongPhiPhat.Clear();
            cbTinhTrangSach.SelectedValue = -1;
            txtSoNgaySuDung.Clear();
            txtMaSach.Clear();
        }
        private void dgvPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvPhieuMuon.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                txtMaPhieuMuon.Text = row.Cells["MAPHIEUMUON"].Value.ToString();
                txtMaSach.Text = row.Cells["MASACH"].Value.ToString();
            }
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày trả từ DateTimePicker
            DateTime ngayTra = dtpNgayTra.Value;

            // Kiểm tra nếu dòng hiện tại hợp lệ
            if (dgvPhieuMuon.CurrentRow != null)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgvPhieuMuon.CurrentRow;

                // Lấy ngày trả dự kiến và ngày mượn từ DataGridView
                DateTime ngayTraDuKien = Convert.ToDateTime(row.Cells["NGAYTRADUKIEN"].Value);
                DateTime ngayMuon = Convert.ToDateTime(row.Cells["NGAYMUON"].Value);

                // Kiểm tra nếu ngày trả lớn hơn ngày trả dự kiến
                if (ngayTra > ngayTraDuKien)
                {
                    // Tính số ngày trễ hạn
                    int soNgayTre = (ngayTra - ngayTraDuKien).Days;

                    // Tính phí phạt (1 ngày = 20000)
                    int phiPhat = soNgayTre * 20000;

                    // Hiển thị phí phạt vào txtTongPhiPhat
                    txtTongPhiPhat.Text = phiPhat.ToString();
                }
                else
                {
                    // Nếu không trễ hạn, phí phạt là 0
                    txtTongPhiPhat.Text = "0";
                }

                // Tính số ngày sử dụng
                int soNgaySuDung = (ngayTra - ngayMuon).Days;

                // Hiển thị số ngày sử dụng vào txtSoNgaySuDung
                txtSoNgaySuDung.Text = soNgaySuDung.ToString();
            }
            else
            {
                txtTongPhiPhat.Text = "0";
                txtSoNgaySuDung.Text = "0";
                MessageBox.Show("Vui lòng chọn một phiếu mượn!", "Thông báo");
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu các trường dữ liệu cần thiết đã được điền
            if (string.IsNullOrEmpty(txtMaHoaDon.Text) || string.IsNullOrEmpty(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn!", "Thông báo");
                return;
            }

            // Kiểm tra nếu mã phiếu mượn đã được lập hóa đơn trước đó
            if (danhSachDaLapHoaDon.Contains(txtMaPhieuMuon.Text))
            {
                MessageBox.Show("Phiếu mượn này đã được lập hóa đơn trước đó!", "Thông báo");
                return;
            }

            // Lập hóa đơn
            String chuoi = "insert into HOADONTRASACH (MAHOADON, MAPHIEUMUON, NGAYTRA, TONGPHIPHAT) " +
                           "values ('" + txtMaHoaDon.Text + "', '" + txtMaPhieuMuon.Text + "', '" + dtpNgayTra.Value.ToString("yyyy-MM-dd") + "', '" +
                           txtTongPhiPhat.Text + "')";

            // Thêm dữ liệu vào bảng HOADONTRASACH
            xulydl.ThemDL(chuoi);
            MessageBox.Show("Lập hóa đơn thành công!", "Thông báo");

            // Lấy số lượng sách từ phiếu mượn
            string maPhieuMuon = txtMaPhieuMuon.Text;
            string chuoiSoLuongSach = "select SOLUONGSACH, MASACH from PHIEUMUON where MAPHIEUMUON = '" + maPhieuMuon + "'";

            DataTable dtSoLuongSach = xulydl.LayBayDL(chuoiSoLuongSach);

            if (dtSoLuongSach.Rows.Count > 0)
            {
                int soLuongSach = Convert.ToInt32(dtSoLuongSach.Rows[0]["SOLUONGSACH"]);
                string maSach = dtSoLuongSach.Rows[0]["MASACH"].ToString();

                // Cập nhật số lượng sách còn lại trong bảng SACH
                string chuoiCapNhatSoLuong = "UPDATE SACH SET SOLUONGCONLAI = SOLUONGCONLAI + @soLuongSach WHERE MASACH = @maSach";
                xulydl.CapNhatDL(chuoiCapNhatSoLuong, soLuongSach, maSach);
            }

            // Thêm mã phiếu mượn vào danh sách đã lập hóa đơn
            danhSachDaLapHoaDon.Add(txtMaPhieuMuon.Text);

            // Tô màu vàng cho dòng đã lập hóa đơn trong DataGridView
            foreach (DataGridViewRow row in dgvPhieuMuon.Rows)
            {
                if (row.Cells["MAPHIEUMUON"].Value != null && row.Cells["MAPHIEUMUON"].Value.ToString() == txtMaPhieuMuon.Text)
                {
                    // Tô màu vàng
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black; // Nếu cần, đổi màu chữ để dễ đọc
                    break; // Thoát vòng lặp sau khi tìm thấy dòng cần tô màu
                }
            }

            // Lập chi tiết hóa đơn
            String chuoi1 = "insert into CHITIET (MASACH, MAHOADON, SONGAYSUDUNG, TINHTRANGSACH) " +
                            "values ('" + txtMaSach.Text + "', '" + txtMaHoaDon.Text + "', '" + txtSoNgaySuDung.Text + "', '" +
                            cbTinhTrangSach.Text + "')";

            // Thêm dữ liệu vào bảng CHITIET
            xulydl.ThemDL(chuoi1);

            // Làm sạch dữ liệu trong các TextBox sau khi lập hóa đơn
            clear();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                tbMaHoaDon.Text = row.Cells["MAHOADON"].Value.ToString();
                tbMaPhieuMuon.Text = row.Cells["MAPHIEUMUON1"].Value.ToString();
                dtimepickerNgayTra.Text = row.Cells["NGAYTRA"].Value.ToString();
                tbTongPhiPhat.Text = row.Cells["TONGPHIPHAT"].Value.ToString();


                // Hiển thị nút Xóa
                btnXoaHoaDon.Enabled = true;
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Chuỗi lệnh SQL để xóa
                string chuoi1 = "DELETE FROM CHITIET WHERE MAHOADON = '" + tbMaHoaDon.Text + "'";
                xulydl.ThemDL(chuoi1);
                string chuoi2 = "DELETE FROM HOADONTRASACH WHERE MAHOADON = '" + tbMaHoaDon.Text + "'";
                xulydl.ThemDL(chuoi2);
                // Thông báo xóa thành công
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");

                // Làm mới danh sách tác giả
                hienthihoadon();

                // Xóa dữ liệu trong TextBox và ẩn nút Xóa
          
                btnXoaHoaDon.Enabled = false;
            }
        }

        void loadhoadon()
        {
            DataTable bang = new DataTable();
            String chuoi = @"
            SELECT 
                H.MAHOADON, 
                N.TENNGUOIDUNG, 
                S.TENSACH, 
                P.NGAYMUON, 
                P.SOLUONGSACH, 
                P.NGAYTRADUKIEN, 
                H.NGAYTRA, 
                H.TONGPHIPHAT
            FROM 
                HOADONTRASACH H
            INNER JOIN PHIEUMUON P ON H.MAPHIEUMUON = P.MAPHIEUMUON
            INNER JOIN NGUOIDUNG N ON P.MANGUOIDUNG = N.MANGUOIDUNG
            INNER JOIN SACH S ON P.MASACH = S.MASACH";
            bang = xulydl.LayBayDL(chuoi);
            dgvInHoaDon.DataSource = bang;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage1": // Tên của tab đầu tiên
                    hienthiphieumuon();
                    break;
                case "tabPage2": // Tên của tab thứ hai
                    hienthihoadon();
                    break;
                case "tabPage4":
                    loadhoadon();
                    btnIn.Enabled = false;
                    break;
                default:
                    break;
            }
        }
        void tracuuhoadon()
        {
            string tuKhoa = txtTraCuuHoaDon.Text.Trim();
            string chuoi = "SELECT * FROM HOADONTRASACH WHERE 1=1";

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                chuoi += " AND (MAHOADON LIKE '%" + tuKhoa + "%'" +
                         " OR MAPHIEUMUON LIKE '%" + tuKhoa + "%'" +
                         " OR NGAYTRA LIKE '%" + tuKhoa + "%'" +
                         " OR TONGPHIPHAT LIKE '%" + tuKhoa + "%')";
            }

            DataTable bang = xulydl.LayBayDL(chuoi);

            if (bang.Rows.Count > 0)
            {
                dgvkqHoaDon.DataSource = bang;
            }
            else
            {
                dgvkqHoaDon.DataSource = null;
                MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp!", "Thông báo");
            }
        }


        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
            tracuuhoadon();
        }

        private void dgvInHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu dòng được chọn hợp lệ
            {
                DataGridViewRow row = dgvInHoaDon.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột
                txtMaIn.Text = row.Cells["MAHOADONIN"].Value.ToString();

                // Hiển thị nút Xóa
                btnIn.Enabled = true;
            }
        }

        void clearinhoadon()
        {
            txtMaIn.Clear();
            dgvInHoaDon.ClearSelection();
        }
        private void btnHuyIn_Click(object sender, EventArgs e)
        {
            clearinhoadon();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn hóa đơn chưa
            if (string.IsNullOrEmpty(txtMaIn.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu hóa đơn (ví dụ: từ DataGridView hoặc database)
            string maHoaDon = txtMaIn.Text;
            DataGridViewRow selectedRow = dgvInHoaDon.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["MAHOADONIN"].Value.ToString() == maHoaDon);

            if (selectedRow != null)
            {
                hoaDonContent = $"Hóa đơn: {selectedRow.Cells["MAHOADONIN"].Value}\n";
                hoaDonContent += $"Tên người dùng: {selectedRow.Cells["TENNGUOIDUNG1"].Value}\n";
                hoaDonContent += $"Tên sách: {selectedRow.Cells["TENSACH1"].Value}\n";
                hoaDonContent += $"Ngày mượn: {Convert.ToDateTime(selectedRow.Cells["NGAYMUON1"].Value).ToString("yyyy-MM-dd")}\n";
                hoaDonContent += $"Số lượng sách: {selectedRow.Cells["SOLUONGSACH1"].Value}\n";
                hoaDonContent += $"Ngày trả dự kiến: {Convert.ToDateTime(selectedRow.Cells["NGAYTRADUKIEN1"].Value).ToString("yyyy-MM-dd")}\n";
                hoaDonContent += $"Ngày trả: {Convert.ToDateTime(selectedRow.Cells["NGAYTRA1"].Value).ToString("yyyy-MM-dd")}\n";
                hoaDonContent += $"Tổng phí phạt: {selectedRow.Cells["TONGPHIPHAT1"].Value}\n";
            }

            // Gọi chức năng in
            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printDocument;
            printPreview.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Kích thước và font chữ
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12, FontStyle.Regular);
            Font footerFont = new Font("Arial", 10, FontStyle.Italic);

            // Màu sắc và căn lề
            Brush brush = Brushes.Black;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Lấy thông tin hóa đơn từ dòng đã chọn
            string maHoaDon = txtMaIn.Text;
            DataGridViewRow selectedRow = dgvInHoaDon.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["MAHOADONIN"].Value.ToString() == maHoaDon);

            if (selectedRow != null)
            {
                string logoPath = "D:\\PT&TKHTTT\\Đồ án\\Library-Management-System-using-CSharp-main\\LibraryManagementSystem\\LibraryManagementSystem\\Assets\\logo tap son.png";
                Image logoImage = Image.FromFile(logoPath);

                // Vẽ logo bên cạnh tiêu đề
                float logoWidth = 80; // Chiều rộng của logo
                float logoHeight = 80; // Chiều cao của logo
                e.Graphics.DrawImage(logoImage, leftMargin + 20, topMargin - 10, logoWidth, logoHeight);


                // Logo hoặc tiêu đề
                e.Graphics.DrawString("THƯ VIỆN TRƯỜNG THPT TẬP SƠN", titleFont, brush, new PointF(leftMargin + 117, topMargin));
                e.Graphics.DrawString("HÓA ĐƠN TRẢ SÁCH", titleFont, brush, new PointF(leftMargin + 200, topMargin + 40));

                // Đường kẻ ngang
                e.Graphics.DrawLine(Pens.Black, leftMargin, topMargin + 80, e.MarginBounds.Right, topMargin + 80);

                // Nội dung hóa đơn
                float yPosition = topMargin + 100;
                e.Graphics.DrawString($"Mã hóa đơn: {selectedRow.Cells["MAHOADONIN"].Value}", contentFont, brush, new PointF(leftMargin, yPosition));
                yPosition += 30;
                e.Graphics.DrawString($"Tên người dùng: {selectedRow.Cells["TENNGUOIDUNG1"].Value}", contentFont, brush, new PointF(leftMargin, yPosition));
                yPosition += 30;
                e.Graphics.DrawString($"Tên sách: {selectedRow.Cells["TENSACH1"].Value}", contentFont, brush, new PointF(leftMargin, yPosition));
                yPosition += 30;
                e.Graphics.DrawString($"Ngày mượn: {Convert.ToDateTime(selectedRow.Cells["NGAYMUON1"].Value).ToString("dd/MM/yyyy")}", contentFont, brush, new PointF(leftMargin, yPosition));
                yPosition += 30;
                e.Graphics.DrawString($"Ngày trả: {Convert.ToDateTime(selectedRow.Cells["NGAYTRA1"].Value).ToString("dd/MM/yyyy")}", contentFont, brush, new PointF(leftMargin, yPosition));
                yPosition += 30;
                e.Graphics.DrawString($"Ngày trả dự kiến: {Convert.ToDateTime(selectedRow.Cells["NGAYTRADUKIEN1"].Value).ToString("dd/MM/yyyy")}", contentFont, brush, new PointF(leftMargin, yPosition));
                yPosition += 30;
                e.Graphics.DrawString($"Tổng phí phạt: {selectedRow.Cells["TONGPHIPHAT1"].Value} VND", contentFont, brush, new PointF(leftMargin, yPosition));
                yPosition += 50;

                // Lời cảm ơn
                e.Graphics.DrawLine(Pens.Black, leftMargin, yPosition, e.MarginBounds.Right, yPosition);
                yPosition += 20;
                e.Graphics.DrawString("Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!", footerFont, brush, new PointF(leftMargin, yPosition));
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}
