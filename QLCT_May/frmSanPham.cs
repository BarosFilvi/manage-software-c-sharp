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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DaiLyDataContext dbSanPham = new DaiLyDataContext())
            {
                SanPham sp = new SanPham();

                sp.MaSanPham = Int32.Parse(txtMaHang.Text);
                sp.TenSanPham = txtTenHang.Text;
                sp.KichThuoc = Int32.Parse(txtKichThuoc.Text);
                sp.DonGiaTraCham = Int32.Parse(txtDonGiaTraCham.Text);
                sp.DonGiaTraNgay = Int32.Parse(txtDonGiaTraNgay.Text);
                sp.DonGiaTraGop = Int32.Parse(txtDonGiaTraGop.Text);
                sp.GhiChu = txtGhiChu.Text;

                dbSanPham.SanPhams.InsertOnSubmit(sp);
                dbSanPham.SubmitChanges();
            }
            this.frmSanPham_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaHang == null || txtMaHang.Equals(""))
            {
                MessageBox.Show("Nhập mã đại lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("Bạn có đồng ý xóa?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (DaiLyDataContext dbSanPham = new DaiLyDataContext())
                {
                    try
                    {
                        var sanphamRemove = dbSanPham.SanPhams.Where(sanpham => sanpham.MaSanPham == Int32.Parse(txtMaHang.Text)).FirstOrDefault();
                        if (sanphamRemove != null)
                        {
                            dbSanPham.SanPhams.DeleteOnSubmit(sanphamRemove);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã đại lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dbSanPham.SubmitChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.RefreshForm();
            this.frmSanPham_Load(sender, e);
        }

        private void RefreshForm()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtKichThuoc.Text = "";
            txtDonGiaTraCham.Text = "";
            txtDonGiaTraNgay.Text = "";
            txtDonGiaTraGop.Text = "";
            txtGhiChu.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgSanPham.Rows.Clear();
            dgSanPham.Refresh();
            using (DaiLyDataContext dbSanPham = new DaiLyDataContext())
            {
                var sanPhams = (from d in dbSanPham.SanPhams select d).ToList();
                foreach (var sanpham in sanPhams)
                {
                    string[] row = new string[] { sanpham.MaSanPham.ToString(), sanpham.TenSanPham, sanpham.KichThuoc.ToString(), sanpham.DonGiaTraCham.ToString()
                        , sanpham.DonGiaTraNgay.ToString(), sanpham.DonGiaTraGop.ToString(), sanpham.GhiChu};
                    dgSanPham.Rows.Add(row);
                }
            }
        }

        private void dgSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgSanPham.Rows[e.RowIndex];
                txtMaHang.Text = r.Cells[0].Value.ToString();
                txtTenHang.Text = r.Cells[1].Value.ToString();
                txtKichThuoc.Text = r.Cells[2].Value.ToString();
                txtDonGiaTraCham.Text = r.Cells[3].Value.ToString();
                txtDonGiaTraNgay.Text = r.Cells[4].Value.ToString();
                txtDonGiaTraGop.Text = r.Cells[5].Value.ToString();
                txtGhiChu.Text = r.Cells[6].Value.ToString();
            }
        }
    }
}
