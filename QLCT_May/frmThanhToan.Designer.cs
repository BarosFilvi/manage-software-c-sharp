namespace QLCT_May
{
    partial class frmThanhToan
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
            this.dgThanhToan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDaiLy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoPhieuThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(20, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 33);
            this.button2.TabIndex = 52;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 33);
            this.button1.TabIndex = 51;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgThanhToan
            // 
            this.dgThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgThanhToan.Location = new System.Drawing.Point(397, 68);
            this.dgThanhToan.Name = "dgThanhToan";
            this.dgThanhToan.RowHeadersWidth = 51;
            this.dgThanhToan.Size = new System.Drawing.Size(414, 252);
            this.dgThanhToan.TabIndex = 50;
            this.dgThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgThanhToan_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số phiếu thu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày lập phiếu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số tiền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã đại lý";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(18, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Mã đại lý";
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMaDaiLy.Location = new System.Drawing.Point(131, 185);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.Size = new System.Drawing.Size(233, 20);
            this.txtMaDaiLy.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Số tiền";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSoTien.Location = new System.Drawing.Point(131, 145);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(233, 20);
            this.txtSoTien.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ngày lập phiếu";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNgayLap.Location = new System.Drawing.Point(131, 104);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(233, 20);
            this.txtNgayLap.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số phiếu thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 38;
            // 
            // txtSoPhieuThu
            // 
            this.txtSoPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSoPhieuThu.Location = new System.Drawing.Point(131, 65);
            this.txtSoPhieuThu.Name = "txtSoPhieuThu";
            this.txtSoPhieuThu.Size = new System.Drawing.Size(233, 20);
            this.txtSoPhieuThu.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "THANH TOÁN";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 337);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgThanhToan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaDaiLy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPhieuThu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThanhToan";
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaDaiLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoPhieuThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}