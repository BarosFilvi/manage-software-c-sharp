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
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DaiLyDataContext dbCTHD = new DaiLyDataContext())
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();

                cthd.SoLuong = Int32.Parse(txtSoLuong.Text);
                cthd.SoHoaDon = Int32.Parse(txtSoHoaDon.Text);    
                cthd.MaSanPham = Int32.Parse(txtMaSanPham.Text);

                dbCTHD.ChiTietHoaDons.InsertOnSubmit(cthd);
                dbCTHD.SubmitChanges();
            }
            this.frmChiTietHoaDon_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSoHoaDon == null || txtSoHoaDon.Equals(""))
            {
                MessageBox.Show("Nhập số hoá đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("Bạn có đồng ý xóa?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (DaiLyDataContext dbCTHD = new DaiLyDataContext())
                {
                    try
                    {
                        var cTHDRemove = dbCTHD.ChiTietHoaDons.Where(cTHD => cTHD.SoHoaDon == Int32.Parse(txtSoHoaDon.Text)).FirstOrDefault();
                        if (cTHDRemove != null)
                        {
                            dbCTHD.ChiTietHoaDons.DeleteOnSubmit(cTHDRemove);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy số hoá đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dbCTHD.SubmitChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.RefreshForm();
            this.frmChiTietHoaDon_Load(sender, e);
        }

        private void RefreshForm()
        {
            txtSoLuong.Text = "";
            txtSoHoaDon.Text = "";
            txtMaSanPham.Text = "";
        }

        private void dgCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgCTHD.Rows[e.RowIndex];
                txtSoLuong.Text = r.Cells[0].Value.ToString();
                txtSoHoaDon.Text = r.Cells[1].Value.ToString();
                txtMaSanPham.Text = r.Cells[2].Value.ToString();
            }
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgCTHD.Rows.Clear();
            dgCTHD.Refresh();
            using (DaiLyDataContext dbCTHD = new DaiLyDataContext())
            {
                var cTHDs = (from d in dbCTHD.ChiTietHoaDons select d).ToList();
                foreach (var cTHD in cTHDs)
                {
                    string[] row = new string[] { cTHD.SoLuong.ToString(), cTHD.SoHoaDon.ToString(), cTHD.MaSanPham.ToString() };
                    dgCTHD.Rows.Add(row);
                }
            }
        }


    }
}
