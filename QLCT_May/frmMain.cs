using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT_May
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSanPham = new frmSanPham();
            frmSanPham.Show();
        }

        private void quảnLýĐạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDaiLy = new frmDaiLy();
            frmDaiLy.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHoaDon = new frmHoaDon();
            frmHoaDon.Show();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmChiTietHoaDon = new frmChiTietHoaDon();
            frmChiTietHoaDon.Show();
        }

        private void thanhToánPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThanhToan = new frmThanhToan();
            frmThanhToan.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSanPham = new frmSanPham();
            frmSanPham.Show();
        }
    }
}
