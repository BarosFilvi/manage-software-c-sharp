namespace QLCT_May
{
    partial class frmChiTietHoaDon
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgCTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 33);
            this.button2.TabIndex = 52;
            this.button2.Text = "Xóa chi tiết hoá đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 33);
            this.button1.TabIndex = 51;
            this.button1.Text = "Thêm chi tiết hoá đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgCTHD
            // 
            this.dgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgCTHD.Location = new System.Drawing.Point(392, 77);
            this.dgCTHD.Name = "dgCTHD";
            this.dgCTHD.RowHeadersWidth = 51;
            this.dgCTHD.Size = new System.Drawing.Size(427, 214);
            this.dgCTHD.TabIndex = 50;
            this.dgCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCTHD_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số lượng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số hoá đơn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(14, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã sản phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMaSanPham.Location = new System.Drawing.Point(127, 154);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(233, 20);
            this.txtMaSanPham.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Số hóa đơn";
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSoHoaDon.Location = new System.Drawing.Point(127, 113);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(233, 20);
            this.txtSoHoaDon.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 38;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSoLuong.Location = new System.Drawing.Point(127, 74);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(233, 20);
            this.txtSoLuong.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "QUẢN LÝ CHI TIẾT HÓA ĐƠN";
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgCTHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgCTHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}