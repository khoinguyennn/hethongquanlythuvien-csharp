using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem
{
    internal class KetNoiDuLieu
    {
        SqlConnection ketnoi;
        SqlCommand lenh;

        public KetNoiDuLieu(String chuoiketnoi)
        {
            ketnoi = new SqlConnection();
            ketnoi.ConnectionString = chuoiketnoi;
        }
        public KetNoiDuLieu()
        {
            ketnoi = new SqlConnection();
            ketnoi.ConnectionString = "Data Source=khoinguyen;Initial Catalog=QLTV_TAPSON;Integrated Security=True;TrustServerCertificate=True";
        }
        public Boolean MoKetNoi()
        {
            try
            {
                ketnoi.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void dongKetNoi()
        {
            ketnoi.Close();
        }
        public void ThemDL(String chuoi)
        {
            lenh = new SqlCommand();
            lenh.Connection = ketnoi;
            lenh.CommandText = chuoi;
            lenh.ExecuteNonQuery();
        }
        public DataTable LayBayDL(String chuoi)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter bodocghi = new SqlDataAdapter(chuoi, ketnoi);

            bodocghi.Fill(tb);

            return tb;

        }

        public int LayTongSach(string chuoi)
        {
            int tong = 0;
            try
            {
                if (ketnoi.State != ConnectionState.Open)
                    ketnoi.Open();

                lenh = new SqlCommand(chuoi, ketnoi);
                object result = lenh.ExecuteScalar();
                tong = result != null ? Convert.ToInt32(result) : 0;
            }
            catch
            {
                tong = 0; // Trường hợp lỗi, trả về 0
            }
            finally
            {
                ketnoi.Close();
            }
            return tong;
        }

        public int DemSoNguoiDung()
        {
            try
            {
                if (ketnoi.State == ConnectionState.Closed)
                {
                    ketnoi.Open();
                }

                string query = "SELECT COUNT(MANGUOIDUNG) FROM NGUOIDUNG";
                SqlCommand cmd = new SqlCommand(query, ketnoi);
                int count = (int)cmd.ExecuteScalar(); // Lấy kết quả của COUNT
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đếm số người dùng: " + ex.Message);
                return 0; // Trả về 0 nếu có lỗi
            }
            finally
            {
                if (ketnoi.State == ConnectionState.Open)
                {
                    ketnoi.Close();
                }
            }
        }

        public DataTable TimKiemPhieuMuon(string maPhieuMuon, DateTime tuNgay, DateTime denNgay)
        {
            DataTable ketQua = new DataTable();
            try
            {
                if (ketnoi.State == ConnectionState.Closed)
                {
                    ketnoi.Open();
                }

                // Câu lệnh SQL tìm kiếm
                string query = @"SELECT * 
                         FROM PHIEUMUON 
                         WHERE 
                             (@maPhieuMuon IS NULL OR MAPHIEUMUON = @maPhieuMuon) AND
                             NGAYMUON BETWEEN @tuNgay AND @denNgay";

                SqlCommand cmd = new SqlCommand(query, ketnoi);
                cmd.Parameters.AddWithValue("@maPhieuMuon", string.IsNullOrEmpty(maPhieuMuon) ? (object)DBNull.Value : maPhieuMuon);
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@denNgay", denNgay);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ketQua);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm phiếu mượn: " + ex.Message, "Thông báo");
            }
            finally
            {
                if (ketnoi.State == ConnectionState.Open)
                {
                    ketnoi.Close();
                }
            }
            return ketQua;
        }

        public void CapNhatDL(string chuoiSQL, int soLuongSach, string maSach)
        {
            try
            {
                SqlCommand command = new SqlCommand(chuoiSQL, ketnoi);

                // Thêm tham số số lượng sách và mã sách vào câu lệnh SQL
                command.Parameters.Add("@soLuongSach", SqlDbType.Int).Value = soLuongSach;
                command.Parameters.Add("@maSach", SqlDbType.NVarChar).Value = maSach;

                // Thực thi câu lệnh SQL mà không trả về kết quả
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }




    }
}
