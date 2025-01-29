using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace LibraryManagementSystem
{
    public partial class ThongKe : UserControl
    {
        KetNoiDuLieu xulydl;

        public ThongKe()
        {
            InitializeComponent();
            xulydl = new KetNoiDuLieu();

            if (xulydl.MoKetNoi())
            {
                //MessageBox.Show("Kết nối cơ sở dữ liệu thành công", "Thông báo");
                loaddanhmucsach();
                loadnguoidung();


            }
            else
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công", "Thông báo");

            }
     
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }


        }

        private void btnXemSachMuonNhieu_Click(object sender, EventArgs e)
        {
            // Lấy ngày chỉ định từ các DateTimePicker
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            // Kiểm tra nếu ngày bắt đầu lớn hơn ngày kết thúc
            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo");
                return;
            }

            try
            {
                // Chuỗi kết nối
                string connectionString = "Data Source=khoinguyen;Initial Catalog=QLTV_TAPSON;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu truy vấn SQL
                    string query = @"
            SELECT MASACH, MANGUOIDUNG, NGAYMUON, SOLUONGSACH, NGAYTRADUKIEN
            FROM PHIEUMUON
            WHERE NGAYMUON BETWEEN @tuNgay AND @denNgay
            ORDER BY SOLUONGSACH DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tuNgay", tuNgay);
                        command.Parameters.AddWithValue("@denNgay", denNgay);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dtThongKe = new DataTable();
                            adapter.Fill(dtThongKe);

                            // Kiểm tra dữ liệu và hiển thị lên DataGridView
                            if (dtThongKe.Rows.Count > 0)
                            {
                                // Đảm bảo cột được tự động tạo từ DataTable
                                dgvThongKeSach.AutoGenerateColumns = true; // Cột sẽ được tạo tự động từ DataTable

                                // Gán DataSource cho DataGridView
                                dgvThongKeSach.DataSource = dtThongKe;

                                // Tùy chọn: thay đổi tên cột nếu muốn
                                dgvThongKeSach.Columns["MASACH"].HeaderText = "Mã Sách";
                                dgvThongKeSach.Columns["MANGUOIDUNG"].HeaderText = "Mã Người Dùng";
                                dgvThongKeSach.Columns["NGAYMUON"].HeaderText = "Ngày Mượn";
                                dgvThongKeSach.Columns["SOLUONGSACH"].HeaderText = "Số Lượng Sách";
                                dgvThongKeSach.Columns["NGAYTRADUKIEN"].HeaderText = "Ngày Trả Dự Kiến";

                                // Điều chỉnh kích thước cột tự động để lấp đầy DataGridView
                                dgvThongKeSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu thống kê trong khoảng thời gian này!", "Thông báo");
                                dgvThongKeSach.DataSource = null;  // Không có dữ liệu, đặt lại DataSource
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message, "Thông báo");
            }
        }

        private void btnXemSachSapHet_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuỗi kết nối
                string connectionString = "Data Source=khoinguyen;Initial Catalog=QLTV_TAPSON;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu truy vấn SQL để lấy thông tin sách có số lượng còn lại dưới 2
                    string query = @"
                SELECT S.MASACH, S.TENSACH, T.TENTACGIA, S.SOLUONGCONLAI, DM.TENDANHMUC
                FROM SACH S
                JOIN TACGIA T ON S.MATACGIA = T.MATACGIA
                JOIN DANHMUC DM ON S.MADANHMUC = DM.MADANHMUC
                WHERE S.SOLUONGCONLAI < 2";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dtSachSapHet = new DataTable();
                            adapter.Fill(dtSachSapHet);

                            // Kiểm tra dữ liệu và hiển thị lên DataGridView
                            if (dtSachSapHet.Rows.Count > 0)
                            {
                                // Đảm bảo cột được tự động tạo từ DataTable
                                dgvThongKeSach.AutoGenerateColumns = true; // Cột sẽ được tạo tự động từ DataTable

                                // Gán DataSource cho DataGridView
                                dgvThongKeSach.DataSource = dtSachSapHet;

                                // Tùy chọn: thay đổi tên cột nếu muốn
                                dgvThongKeSach.Columns["MASACH"].HeaderText = "Mã Sách";
                                dgvThongKeSach.Columns["TENSACH"].HeaderText = "Tên Sách";
                                dgvThongKeSach.Columns["TENTACGIA"].HeaderText = "Tác Giả";
                                dgvThongKeSach.Columns["SOLUONGCONLAI"].HeaderText = "Số Lượng Còn Lại";
                                dgvThongKeSach.Columns["TENDANHMUC"].HeaderText = "Danh Mục";

                                // Điều chỉnh kích thước cột tự động để lấp đầy DataGridView
                                dgvThongKeSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                            else
                            {
                                MessageBox.Show("Không có sách sắp hết trong kho!", "Thông báo");
                                dgvThongKeSach.DataSource = null;  // Không có dữ liệu, đặt lại DataSource
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message, "Thông báo");
            }
        }

        private void btnMuonNhieuNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuỗi kết nối (bạn nên sử dụng từ lớp KetNoiDuLieu hoặc tệp cấu hình)
                string connectionString = "Data Source=khoinguyen;Initial Catalog=QLTV_TAPSON;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu truy vấn SQL để lấy danh sách người dùng mượn nhiều nhất
                    string query = @"
                SELECT TOP 10 
                    P.MANGUOIDUNG, 
                    N.TENNGUOIDUNG, 
                    COUNT(P.MANGUOIDUNG) AS SO_LUONG_MUON
                FROM PHIEUMUON P
                JOIN NGUOIDUNG N ON P.MANGUOIDUNG = N.MANGUOIDUNG
                GROUP BY P.MANGUOIDUNG, N.TENNGUOIDUNG
                ORDER BY SO_LUONG_MUON DESC";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Tạo đối tượng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dtMuonNhieuNhat = new DataTable();
                            adapter.Fill(dtMuonNhieuNhat);

                            // Kiểm tra dữ liệu và hiển thị lên DataGridView
                            if (dtMuonNhieuNhat.Rows.Count > 0)
                            {
                                dgvThongKeNguoiDung.DataSource = dtMuonNhieuNhat;

                                // Đặt tên cho các cột trong DataGridView
                                dgvThongKeNguoiDung.Columns[0].HeaderText = "Mã Người Dùng";
                                dgvThongKeNguoiDung.Columns[1].HeaderText = "Tên Người Dùng";
                                dgvThongKeNguoiDung.Columns[2].HeaderText = "Số Lượng Mượn";

                                // Điều chỉnh các cột để lắp đầy DataGridView
                                dgvThongKeNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                            else
                            {
                                MessageBox.Show("Không có người dùng mượn sách trong thời gian này!", "Thông báo");
                                dgvThongKeNguoiDung.DataSource = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message, "Thông báo");
            }
        }

        private void btnQuaHanNhieuNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuỗi kết nối (bạn nên sử dụng từ lớp KetNoiDuLieu hoặc tệp cấu hình)
                string connectionString = "Data Source=khoinguyen;Initial Catalog=QLTV_TAPSON;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu truy vấn SQL để lấy danh sách người dùng trả sách quá hạn
                    string query = @"
                SELECT TOP 10 
                    P.MANGUOIDUNG, 
                    N.TENNGUOIDUNG, 
                    COUNT(P.MANGUOIDUNG) AS SO_LUONG_TRA_MUON_QUA_HAN
                FROM PHIEUMUON P
                JOIN NGUOIDUNG N ON P.MANGUOIDUNG = N.MANGUOIDUNG
                JOIN HOADONTRASACH H ON P.MAPHIEUMUON = H.MAPHIEUMUON
                WHERE H.NGAYTRA > P.NGAYTRADUKIEN
                GROUP BY P.MANGUOIDUNG, N.TENNGUOIDUNG
                ORDER BY SO_LUONG_TRA_MUON_QUA_HAN DESC";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Tạo đối tượng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dtQuaHanNhieuNhat = new DataTable();
                            adapter.Fill(dtQuaHanNhieuNhat);

                            // Kiểm tra dữ liệu và hiển thị lên DataGridView
                            if (dtQuaHanNhieuNhat.Rows.Count > 0)
                            {
                                dgvThongKeNguoiDung.DataSource = dtQuaHanNhieuNhat;

                                // Kiểm tra số lượng cột trong DataGridView
                                if (dgvThongKeNguoiDung.Columns.Count >= 3)
                                {
                                    // Đặt tên cho các cột trong DataGridView
                                    dgvThongKeNguoiDung.Columns[0].HeaderText = "Mã Người Dùng";
                                    dgvThongKeNguoiDung.Columns[1].HeaderText = "Tên Người Dùng";
                                    dgvThongKeNguoiDung.Columns[2].HeaderText = "Số Lượng Trả Muộn";

                                    // Điều chỉnh các cột để lắp đầy DataGridView
                                    dgvThongKeNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                }
                                else
                                {
                                    MessageBox.Show("Dữ liệu không hợp lệ hoặc thiếu cột!", "Thông báo");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không có người dùng trả sách quá hạn trong thời gian này!", "Thông báo");
                                dgvThongKeNguoiDung.DataSource = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn: " + ex.Message, "Thông báo");
            }
        }

        void loaddanhmucsach()
        {      
                String chuoi = "select * from DANHMUC";
                cbDanhMucSach.DataSource = xulydl.LayBayDL(chuoi);
                cbDanhMucSach.DisplayMember = "MADANHMUC";
                cbDanhMucSach.ValueMember = "MADANHMUC";         
        }

        void loadnguoidung()
        {
            String chuoi = "select * from NGUOIDUNG";
            cbLoaiNguoiDung.DataSource = xulydl.LayBayDL(chuoi);
            cbLoaiNguoiDung.DisplayMember = "LOAINGUOIDUNG";
            cbLoaiNguoiDung.ValueMember = "LOAINGUOIDUNG";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddanhmucsach();
            loadnguoidung();
        }

        private void btnXuatSach_Click(object sender, EventArgs e)
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from SACH where MADANHMUC = '" + cbDanhMucSach.Text + "'";
            bang = xulydl.LayBayDL(chuoi);
            dgvBaoCao.DataSource = bang;

            // Đặt tên cho các cột trong DataGridView
            dgvBaoCao.Columns[0].HeaderText = "Mã Sách";
            dgvBaoCao.Columns[1].HeaderText = "Mã Danh Mục";
            dgvBaoCao.Columns[2].HeaderText = "Mã Tác Giả";
            dgvBaoCao.Columns[3].HeaderText = "Tên Sách";
            dgvBaoCao.Columns[4].HeaderText = "Năm Xuất Bản";
            dgvBaoCao.Columns[5].HeaderText = "ISBN";
            dgvBaoCao.Columns[6].HeaderText = "Số Lượng";
            dgvBaoCao.Columns[7].HeaderText = "Số Lượng Còn Lại";
            dgvBaoCao.Columns[8].HeaderText = "Mô Tả Sách";

            // Điều chỉnh các cột để lắp đầy DataGridView
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvBaoCao.Rows.Count > 0)
            {
                // Tạo đối tượng SaveFileDialog để cho phép người dùng chọn nơi lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";  // Định dạng file Excel
                saveFileDialog.Title = "Chọn nơi lưu báo cáo";
                saveFileDialog.FileName = "Sach_Report.xlsx";  // Tên mặc định cho file lưu

                // Nếu người dùng chọn "Save"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn và tên file người dùng chọn
                    string filePath = saveFileDialog.FileName;

                    // Tạo đối tượng Excel
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false;  // Không hiển thị Excel

                    // Tạo một workbook mới
                    Excel.Workbook workBook = excelApp.Workbooks.Add(Type.Missing);

                    // Lấy sheet đầu tiên trong workbook
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];

                    // Duyệt qua cột và thêm tiêu đề vào Excel
                    for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                    {
                        workSheet.Cells[1, i + 1] = dgvBaoCao.Columns[i].HeaderText;
                    }

                    // Duyệt qua các dòng và thêm dữ liệu vào Excel
                    for (int i = 0; i < dgvBaoCao.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvBaoCao.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 2, j + 1] = dgvBaoCao.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    try
                    {
                        // Lưu file Excel vào đường dẫn người dùng chọn
                        workBook.SaveAs(filePath);
                        MessageBox.Show("Báo cáo sách đã được xuất ra file Excel.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Đảm bảo đóng đối tượng Excel đúng cách
                        if (workBook != null)
                        {
                            workBook.Close(false);  // Đóng workbook mà không lưu
                            Marshal.ReleaseComObject(workBook);  // Giải phóng đối tượng workbook
                        }

                        if (excelApp != null)
                        {
                            excelApp.Quit();  // Thoát ứng dụng Excel
                            Marshal.ReleaseComObject(excelApp);  // Giải phóng đối tượng excelApp
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnXuatNguoiDung_Click(object sender, EventArgs e)
        {
            DataTable bang = new DataTable();
            String chuoi = "select * from NGUOIDUNG where LOAINGUOIDUNG = '" + cbLoaiNguoiDung.Text + "'";
            bang = xulydl.LayBayDL(chuoi);
            dgvBaoCao.DataSource = bang;

            // Đặt tên cho các cột trong DataGridView
            dgvBaoCao.Columns[0].HeaderText = "Mã Người Dùng";
            dgvBaoCao.Columns[1].HeaderText = "Tên Người Dùng";
            dgvBaoCao.Columns[2].HeaderText = "Loại Người Dùng";
            dgvBaoCao.Columns[3].HeaderText = "Số Điện Thoại";
            dgvBaoCao.Columns[4].HeaderText = "Email";
            dgvBaoCao.Columns[5].HeaderText = "Địa Chỉ";
            dgvBaoCao.Columns[6].HeaderText = "Thông tin bổ sung";

            // Điều chỉnh các cột để lắp đầy DataGridView
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvBaoCao.Rows.Count > 0)
            {
                // Tạo đối tượng SaveFileDialog để cho phép người dùng chọn nơi lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";  // Định dạng file Excel
                saveFileDialog.Title = "Chọn nơi lưu báo cáo";
                saveFileDialog.FileName = "NguoiDung_Report.xlsx";  // Tên mặc định cho file lưu

                // Nếu người dùng chọn "Save"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn và tên file người dùng chọn
                    string filePath = saveFileDialog.FileName;

                    // Tạo đối tượng Excel
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = false;  // Không hiển thị Excel

                    // Tạo một workbook mới
                    Excel.Workbook workBook = excelApp.Workbooks.Add(Type.Missing);

                    // Lấy sheet đầu tiên trong workbook
                    Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];

                    // Duyệt qua cột và thêm tiêu đề vào Excel
                    for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                    {
                        workSheet.Cells[1, i + 1] = dgvBaoCao.Columns[i].HeaderText;
                    }

                    // Duyệt qua các dòng và thêm dữ liệu vào Excel
                    for (int i = 0; i < dgvBaoCao.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvBaoCao.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 2, j + 1] = dgvBaoCao.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    try
                    {
                        // Lưu file Excel vào đường dẫn người dùng chọn
                        workBook.SaveAs(filePath);
                        MessageBox.Show("Báo cáo người dùng đã được xuất ra file Excel.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Đảm bảo đóng đối tượng Excel đúng cách
                        if (workBook != null)
                        {
                            workBook.Close(false);  // Đóng workbook mà không lưu
                            Marshal.ReleaseComObject(workBook);  // Giải phóng đối tượng workbook
                        }

                        if (excelApp != null)
                        {
                            excelApp.Quit();  // Thoát ứng dụng Excel
                            Marshal.ReleaseComObject(excelApp);  // Giải phóng đối tượng excelApp
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
