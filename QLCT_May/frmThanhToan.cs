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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DaiLyDataContext dbThanhToan = new DaiLyDataContext())
            {
                ThanhToan tt = new ThanhToan();

                tt.SoPhieuThu = Int32.Parse(txtSoPhieuThu.Text);
                tt.NgayLapPhieu = DateTime.Parse(txtNgayLap.Text);
                tt.SoTien = Int32.Parse(txtSoTien.Text);
                tt.MaDaiLy = Int32.Parse(txtMaDaiLy.Text);

                dbThanhToan.ThanhToans.InsertOnSubmit(tt);
                dbThanhToan.SubmitChanges();
            }
            this.frmThanhToan_Load(sender, e);
        }

        private void dgThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgThanhToan.Rows[e.RowIndex];
                txtSoPhieuThu.Text = r.Cells[0].Value.ToString();
                txtNgayLap.Text = r.Cells[1].Value.ToString();
                txtSoTien.Text = r.Cells[2].Value.ToString();
                txtMaDaiLy.Text = r.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaDaiLy == null || txtMaDaiLy.Equals(""))
            {
                MessageBox.Show("Nhập mã đại lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("Bạn có đồng ý xóa?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (DaiLyDataContext dbThanhToan = new DaiLyDataContext())
                {
                    try
                    {
                        var thanhToanRemove = dbThanhToan.ThanhToans.Where(thanhtoan => thanhtoan.MaDaiLy == Int32.Parse(txtMaDaiLy.Text)).FirstOrDefault();
                        if (thanhToanRemove != null)
                        {
                            dbThanhToan.ThanhToans.DeleteOnSubmit(thanhToanRemove);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã đại lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dbThanhToan.SubmitChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.RefreshForm();
            this.frmThanhToan_Load(sender, e);
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            dgThanhToan.Rows.Clear();
            dgThanhToan.Refresh();
            using (DaiLyDataContext dbThanhToan = new DaiLyDataContext())
            {
                var thanhToans = (from d in dbThanhToan.ThanhToans select d).ToList();
                foreach (var thanhtoan in thanhToans)
                {
                    string[] row = new string[] {thanhtoan.SoPhieuThu.ToString(), thanhtoan.NgayLapPhieu.ToString(), thanhtoan.SoTien.ToString(), thanhtoan.MaDaiLy.ToString() };
                    dgThanhToan.Rows.Add(row);
                }
            }
        }

        private void RefreshForm()
        {
            txtSoPhieuThu.Text = "";
            txtNgayLap.Text = "";
            txtSoTien.Text = "";
            txtMaDaiLy.Text = "";
        }
    }
}
