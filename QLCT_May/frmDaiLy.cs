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
    public partial class frmDaiLy : Form
    {
        public frmDaiLy()
        {
            InitializeComponent();
        }

        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            dgDaiLy.Rows.Clear();
            dgDaiLy.Refresh();
            using (DaiLyDataContext dbDaiLy = new DaiLyDataContext())
            {
                var daiLies = (from d in dbDaiLy.DaiLies select d).ToList();
                foreach(var daily in daiLies)
                {
                    string[] row = new string[] {daily.MaDaiLy.ToString(), daily.TenChuDaiLy, daily.DiaChi, daily.SoDienThoai, daily.HinhThucThanhToan, daily.NoDauKy.ToString()};
                    dgDaiLy.Rows.Add(row);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DaiLyDataContext dbDaiLy = new DaiLyDataContext())
            {
               try
                {
                    DaiLy daily = new DaiLy();

                    daily.MaDaiLy = Int32.Parse(txtMadDaiLy.Text);
                    daily.TenChuDaiLy = txtTenDaiLy.Text;
                    daily.DiaChi = txtDiaChi.Text;
                    daily.SoDienThoai = txtSdt.Text;
                    daily.HinhThucThanhToan = txtHinhThucThanhToan.Text;
                    daily.NoDauKy = Int32.Parse(txtNoDauKy.Text);

                    dbDaiLy.DaiLies.InsertOnSubmit(daily);
                    dbDaiLy.SubmitChanges();
                }
                catch(Exception exception)
                {   
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.frmDaiLy_Load(sender,e);
        }

        private void dgDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgDaiLy.Rows[e.RowIndex];
                txtMadDaiLy.Text = r.Cells[0].Value.ToString();
                txtTenDaiLy.Text = r.Cells[1].Value.ToString();
                txtDiaChi.Text = r.Cells[2].Value.ToString();
                txtSdt.Text = r.Cells[3].Value.ToString();
                txtHinhThucThanhToan.Text = r.Cells[4].Value.ToString();
                txtNoDauKy.Text = r.Cells[5].Value.ToString();
            }
        }

        private void RefreshForm()
        {
            txtMadDaiLy.Text = "";
            txtTenDaiLy.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtHinhThucThanhToan.Text = "";
            txtNoDauKy.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMadDaiLy == null || txtMadDaiLy.Equals(""))
            {
                MessageBox.Show("Nhập mã đại lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult result = MessageBox.Show("Bạn có đồng ý xóa?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (DaiLyDataContext dbDaiLy = new DaiLyDataContext())
                {
                    try
                    {
                        var dailyRemove = dbDaiLy.DaiLies.Where(daily => daily.MaDaiLy == Int32.Parse(txtMadDaiLy.Text)).FirstOrDefault();
                        if(dailyRemove != null)
                        {
                            dbDaiLy.DaiLies.DeleteOnSubmit(dailyRemove);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã đại lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dbDaiLy.SubmitChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.RefreshForm();
            this.frmDaiLy_Load(sender, e);
        }
    }
}
