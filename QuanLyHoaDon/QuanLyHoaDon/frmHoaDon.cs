using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace QuanLyHoaDon
{
    public partial class frmHoaDon : Form
    {
        clsHoaDon cls = new clsHoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
            dgvHoaDon.DataSource = cls.layDSHoaDon();
            DataTable dsKhachHang  = cls.layDSKhachHang();
            for(int i = 0; i < dsKhachHang.Rows.Count; i++)
            {
                cboMAKHANG.Items.Add(dsKhachHang.Rows[i][0]);
            }
            cboMAKHANG.SelectedIndex = 0; 
        }

        //Thêm sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieuNhap() == 1)
            {
                return;
            }

            string sMaHD = txtMaHoaDon.Text.Trim();
            DateTime dtNgayLap = dtpNgayLap.Value.Date;
            int iSoLuong = int.Parse(txtSoLuong.Text.Trim());
            float fDonGia = float.Parse(txtDonGia.Text.Trim());
            float fThanhTien = float.Parse(txtThanhTien.Text.Trim());
            string sMaKHang = cboMAKHANG.SelectedItem.ToString();

            if(cls.themHoaDon(sMaHD,dtNgayLap,iSoLuong,fDonGia,fThanhTien,sMaKHang)==1)
            {
                MessageBox.Show("Thêm hóa đơn thành công");
                dgvHoaDon.DataSource = cls.layDSHoaDon();
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn không thành công");
            }
           
            
        }
        //Kiểm tra dữ liệu nhập trước khi thêm
        public int kiemTraDuLieuNhap()
        {
            //Nếu iKetQua = 0 không có lỗi nào nếu i bằng 1 có lỗi dữ liệu nhập
            int iKetQua = 0;
            //Kiểm tra rỗng
            if (txtMaHoaDon.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtMaHoaDon, "Vui lòng nhập mã hóa đơn");
                iKetQua = 1;
            }
            else
            {
                errorProvider1.SetError(txtMaHoaDon, "");
            }
            //Kiểm tra rỗng số lượng
            if (txtSoLuong.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtSoLuong, "Vui lòng nhập số lượng");
                iKetQua = 1;
            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "");
            }
            //Kiểm tra rỗng đơn giá
            if (txtDonGia.Text.Trim() == String.Empty)
            {
                errorProvider1.SetError(txtDonGia, "Vui lòng nhập đơn giá");
                iKetQua = 1;
            }
            else
            {
                errorProvider1.SetError(txtDonGia, "");
            }
            //Kiểm tra dữ liệu dạng số thực
            if (!float.TryParse(txtDonGia.Text.Trim(), out float fDonGia))
            {
                errorProvider1.SetError(txtDonGia, "Vui lòng nhập dữ liệu dạng số thực");
                iKetQua = 1;
            }
            else
            {
                errorProvider1.SetError(txtDonGia, "");
            }
            //Kiểm tra dữ liệu dạng số 
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int iSoLuong))
            {
                errorProvider1.SetError(txtSoLuong, "Vui lòng nhập dữ liệu dạng số ");
                iKetQua = 1;
            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "");
            }
            return iKetQua;

        }
        // Cập nhật giá trị thành tiền
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtSoLuong.Text.Trim(), out float fDonGia) || !int.TryParse(txtDonGia.Text.Trim(),out int iSoLuong))
            {
                return;
            }
            txtThanhTien.Text = (fDonGia * iSoLuong).ToString();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtSoLuong.Text.Trim(), out float fDonGia) || !int.TryParse(txtDonGia.Text.Trim(), out int iSoLuong))
            {
                return;
            }
            txtThanhTien.Text = (fDonGia * iSoLuong).ToString();
        }
        // Thêm sự kiện cho btnDong
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Thêm sự kiện cho btnSua
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kiemTraDuLieuNhap() == 1)
            {
                return;
            }

            string sMaHD = txtMaHoaDon.Text.Trim();
            DateTime dtNgayLap = dtpNgayLap.Value.Date;
            int iSoLuong = int.Parse(txtSoLuong.Text.Trim());
            float fDonGia = float.Parse(txtDonGia.Text.Trim());
            float fThanhTien = float.Parse(txtThanhTien.Text.Trim());
            string sMaKHang = cboMAKHANG.SelectedItem.ToString();

            if (cls.suaHoaDon(sMaHD, dtNgayLap, iSoLuong, fDonGia, fThanhTien, sMaKHang) == 1)
            {
                MessageBox.Show("Sửa hóa đơn thành công");
                dgvHoaDon.DataSource = cls.layDSHoaDon();
            }
            else
            {
                MessageBox.Show("Sửa hóa đơn không thành công");
            }

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDong = e.RowIndex;
            if(iDong >= 0 && dgvHoaDon.Rows[iDong].Cells[0].Value.ToString()!= String.Empty)
            {
                txtMaHoaDon.Text = dgvHoaDon.Rows[iDong].Cells[0].Value.ToString();
                dtpNgayLap.Value = DateTime.Parse(dgvHoaDon.Rows[iDong].Cells[1].Value.ToString()).Date;
                txtSoLuong.Text = dgvHoaDon.Rows[iDong].Cells[2].Value.ToString();
                txtDonGia.Text = dgvHoaDon.Rows[iDong].Cells[3].Value.ToString();
                cboMAKHANG.SelectedIndex  = cboMAKHANG.FindStringExact(dgvHoaDon.Rows[iDong].Cells[5].Value.ToString());

                 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaHoaDon.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa");
                return;
            }
            string sMaHD = txtMaHoaDon.Text.Replace(" ","");
            DialogResult dr = MessageBox.Show($"Bạn có muốn xóa hóa đơn có mã là : {sMaHD}","Thông báo",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) 
            {
                if(cls.xoaHoaDon(sMaHD)==1)
                {
                    MessageBox.Show("Xóa hóa đơn thành công");
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn không thành công");
                }
                dgvHoaDon.DataSource = cls.layDSHoaDon();
            }

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmInHoaDon frm = new frmInHoaDon();
            frm.ShowDialog();
        }
    }
}
