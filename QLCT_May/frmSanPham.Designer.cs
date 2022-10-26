
namespace QLCT_May
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGiaTraGop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGiaTraCham = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGiaTraNgay = new System.Windows.Forms.TextBox();
            this.dgSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHang
            // 
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMaHang.Location = new System.Drawing.Point(112, 71);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(233, 20);
            this.txtMaHang.TabIndex = 0;
            this.txtMaHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ SẢN PHẨM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên hàng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTenHang.Location = new System.Drawing.Point(112, 110);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(233, 20);
            this.txtTenHang.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(29, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kích thước";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtKichThuoc.Location = new System.Drawing.Point(112, 151);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(233, 20);
            this.txtKichThuoc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(29, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtGhiChu.Location = new System.Drawing.Point(112, 196);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(233, 61);
            this.txtGhiChu.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(18, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Đơn giá trả góp";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDonGiaTraGop
            // 
            this.txtDonGiaTraGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDonGiaTraGop.Location = new System.Drawing.Point(112, 286);
            this.txtDonGiaTraGop.Name = "txtDonGiaTraGop";
            this.txtDonGiaTraGop.Size = new System.Drawing.Size(233, 20);
            this.txtDonGiaTraGop.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(18, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Đơn giá trả chậm";
            // 
            // txtDonGiaTraCham
            // 
            this.txtDonGiaTraCham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDonGiaTraCham.Location = new System.Drawing.Point(112, 327);
            this.txtDonGiaTraCham.Name = "txtDonGiaTraCham";
            this.txtDonGiaTraCham.Size = new System.Drawing.Size(233, 20);
            this.txtDonGiaTraCham.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(18, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Đơn giá trả ngay";
            // 
            // txtDonGiaTraNgay
            // 
            this.txtDonGiaTraNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDonGiaTraNgay.Location = new System.Drawing.Point(112, 368);
            this.txtDonGiaTraNgay.Name = "txtDonGiaTraNgay";
            this.txtDonGiaTraNgay.Size = new System.Drawing.Size(233, 20);
            this.txtDonGiaTraNgay.TabIndex = 14;
            // 
            // dgSanPham
            // 
            this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgSanPham.Location = new System.Drawing.Point(378, 74);
            this.dgSanPham.Name = "dgSanPham";
            this.dgSanPham.Size = new System.Drawing.Size(660, 364);
            this.dgSanPham.TabIndex = 16;
            this.dgSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kích thước";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đơn giá trả chậm";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn giá trả ngay";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Đơn giá trả trước";
            this.Column7.Name = "Column7";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thêm sản phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(223, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Xóa sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgSanPham);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDonGiaTraNgay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDonGiaTraCham);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDonGiaTraGop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKichThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHang);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGiaTraGop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGiaTraCham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGiaTraNgay;
        private System.Windows.Forms.DataGridView dgSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}