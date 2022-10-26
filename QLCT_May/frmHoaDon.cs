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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgHoaDon.Rows[e.RowIndex];
                txtSoHoaDon.Text = r.Cells[0].Value.ToString();
                txtNgayLapHoaDon.Text = r.Cells[1].Value.ToString();
                txtMaDaiLy.Text = r.Cells[2].Value.ToString();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgHoaDon.Rows.Clear();
            dgHoaDon.Refresh();
            using (DaiLyDataContext dbHoaDon = new DaiLyDataContext())
            {
                var hoaDons = (from d in dbHoaDon.HoaDons select d).ToList();
                foreach (var hoaDon in hoaDons)
                {
                    string[] row = new string[] { hoaDon.SoHoaDon.ToString(), hoaDon.NgayLapHoaDon.ToString(), hoaDon.MaDaiLy.ToString() };
                    dgHoaDon.Rows.Add(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DaiLyDataContext dbHoaDon = new DaiLyDataContext())
            {
                HoaDon hoaDon = new HoaDon();

                hoaDon.SoHoaDon = Int32.Parse(txtSoHoaDon.Text);
                hoaDon.NgayLapHoaDon = DateTime.Parse(txtNgayLapHoaDon.Text);
                hoaDon.MaDaiLy = Int32.Parse(txtMaDaiLy.Text);

                dbHoaDon.HoaDons.InsertOnSubmit(hoaDon);
                dbHoaDon.SubmitChanges();
            }
            this.frmHoaDon_Load(sender, e);
        }

        private void RefreshForm()
        {
            txtSoHoaDon.Text = "";
            txtNgayLapHoaDon.Text = "";
            txtMaDaiLy.Text = "";
          
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
                using (DaiLyDataContext dbHoaDon = new DaiLyDataContext())
                {
                    try
                    {
                        var hoadonRemove = dbHoaDon.HoaDons.Where(hoaDon => hoaDon.SoHoaDon == Int32.Parse(txtSoHoaDon.Text)).FirstOrDefault();
                        if (hoadonRemove != null)
                        {
                            dbHoaDon.HoaDons.DeleteOnSubmit(hoadonRemove);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy số hoá đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dbHoaDon.SubmitChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.RefreshForm();
            this.frmHoaDon_Load(sender, e);
        }
    }
}
