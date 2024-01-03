using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoaDon
{
      
    public partial class frmTraCuuHoaDon : Form
    {
        clsHoaDon cls = new clsHoaDon();
        public frmTraCuuHoaDon()
        {
            InitializeComponent();
            dgvHoaDon.DataSource = cls.layDSHoaDon();
            rdoMaHD.Checked = true; 
        }

        private void btnTimTiep_Click(object sender, EventArgs e)
        {
            txtThongTin.Text = string.Empty;
            txtThongTin.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdoMaHD.Checked == true)
            {
                dgvHoaDon.DataSource = cls.timKiemTheoMaHD(txtThongTin.Text);

            }
            else
            {
                dgvHoaDon.DataSource = cls.timKiemTheoMaKHang(txtThongTin.Text);

            }
        }
    }
}
