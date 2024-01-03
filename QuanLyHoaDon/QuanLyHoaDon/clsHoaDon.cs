using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoaDon
{
    internal class clsHoaDon
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=QLHD_DE1;Integrated Security=True");

        public clsHoaDon() 
        {
            try
            {
                conn.Open();
                MessageBox.Show("Kết nối database thành công");
            }
            catch 
            {
                MessageBox.Show("Kết nối database không thành công");
            }
        }

        public DataTable layDSHoaDon()
        {
            DataTable dtHoaDon = new DataTable();
            SqlDataAdapter daHoaDon;

            string tenSP = "SP_LAYDSHOADON";

            SqlCommand cmd = new SqlCommand(tenSP,conn);
            cmd.CommandType = CommandType.StoredProcedure;

            daHoaDon = new SqlDataAdapter(cmd);
            daHoaDon.Fill(dtHoaDon);
            return dtHoaDon;
        }
        public int themHoaDon (string sMaHD,DateTime dtNgayLap, int iSoLuong , float DonGia, float ThanhTien,string sMaKHang)
        {
            int iKetQua = 0;

            string tenSP = "SP_THEMHOADON";
            SqlCommand cmd = new SqlCommand(tenSP,conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MAHD", sMaHD);
            cmd.Parameters.AddWithValue("@NGAYLAP", dtNgayLap);
            cmd.Parameters.AddWithValue("@SOLUONG", iSoLuong);
            cmd.Parameters.AddWithValue("@DONGIA", DonGia);
            cmd.Parameters.AddWithValue("@Thanhtien", ThanhTien);
            cmd.Parameters.AddWithValue("@MAKHANG", sMaKHang);
            try
            { 
                cmd.ExecuteNonQuery();
                iKetQua = 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return iKetQua;
        }
        public DataTable layDSKhachHang()
        {
            DataTable dtKhachHang = new DataTable();
            SqlDataAdapter daKhachHang;

            string tenSP = "SP_LAYDSKHACHHANG";

            SqlCommand cmd = new SqlCommand(tenSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            daKhachHang = new SqlDataAdapter(cmd);
            daKhachHang.Fill(dtKhachHang);
            return dtKhachHang;
        }
        public int suaHoaDon(string sMaHD, DateTime dtNgayLap, int iSoLuong, float DonGia, float ThanhTien, string sMaKHang)
        {
            int iKetQua = 0;
            string tenSP = "SP_SUAHOADON";
            SqlCommand cmd = new SqlCommand(tenSP,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHD", sMaHD);
            cmd.Parameters.AddWithValue("@NGAYLAP", dtNgayLap);
            cmd.Parameters.AddWithValue("@SOLUONG", iSoLuong);
            cmd.Parameters.AddWithValue("@DONGIA", DonGia);
            cmd.Parameters.AddWithValue("@Thanhtien", ThanhTien);
            cmd.Parameters.AddWithValue("@MAKHANG", sMaKHang);

            try
            {
                cmd.ExecuteNonQuery();
                iKetQua = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iKetQua;

        }
        public int xoaHoaDon(string sMaHD)
        {
            int iKetQua = 0;
            string tenSP = "SP_XOAHOADON";
            SqlCommand cmd = new SqlCommand(tenSP,conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHD", sMaHD);

            try
            {
                cmd.ExecuteNonQuery();
                iKetQua = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iKetQua;
        }
        public DataTable timKiemTheoMaHD(string maHD)
        {
            DataTable dtHoaDon = new DataTable();
            SqlDataAdapter daHoaDon;

            string tenSP = "SP_TIMKIEMMAHD";

            SqlCommand cmd = new SqlCommand(tenSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHD", maHD);

            daHoaDon = new SqlDataAdapter(cmd);
            daHoaDon.Fill(dtHoaDon);
            return dtHoaDon;
        }
        public DataTable timKiemTheoMaKHang(string maKH)
        {
            DataTable dtHoaDon = new DataTable();
            SqlDataAdapter daHoaDon;

            string tenSP = "SP_TIMKIEMMAKHANG";

            SqlCommand cmd = new SqlCommand(tenSP, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAKHANG", maKH);

            daHoaDon = new SqlDataAdapter(cmd);
            daHoaDon.Fill(dtHoaDon);
            return dtHoaDon;
        }
    }
}
