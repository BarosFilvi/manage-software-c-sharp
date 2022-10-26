
namespace QLCT_May
{
    partial class frmDaiLy
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgDaiLy = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoDauKy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHinhThucThanhToan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDaiLy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMadDaiLy = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẠI LÝ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Thêm đại lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgDaiLy
            // 
            this.dgDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgDaiLy.Location = new System.Drawing.Point(405, 62);
            this.dgDaiLy.Name = "dgDaiLy";
            this.dgDaiLy.Size = new System.Drawing.Size(645, 330);
            this.dgDaiLy.TabIndex = 33;
            this.dgDaiLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDaiLy_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(12, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nợ đầu kỳ";
            // 
            // txtNoDauKy
            // 
            this.txtNoDauKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNoDauKy.Location = new System.Drawing.Point(125, 260);
            this.txtNoDauKy.Name = "txtNoDauKy";
            this.txtNoDauKy.Size = new System.Drawing.Size(233, 20);
            this.txtNoDauKy.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(12, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Hình thức thanh toán";
            // 
            // txtHinhThucThanhToan
            // 
            this.txtHinhThucThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtHinhThucThanhToan.Location = new System.Drawing.Point(125, 219);
            this.txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
            this.txtHinhThucThanhToan.Size = new System.Drawing.Size(233, 20);
            this.txtHinhThucThanhToan.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSdt.Location = new System.Drawing.Point(125, 182);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(233, 20);
            this.txtSdt.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDiaChi.Location = new System.Drawing.Point(125, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(233, 20);
            this.txtDiaChi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên chủ đại lý";
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTenDaiLy.Location = new System.Drawing.Point(125, 101);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(233, 20);
            this.txtTenDaiLy.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã đại lý";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // txtMadDaiLy
            // 
            this.txtMadDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMadDaiLy.Location = new System.Drawing.Point(125, 62);
            this.txtMadDaiLy.Name = "txtMadDaiLy";
            this.txtMadDaiLy.Size = new System.Drawing.Size(233, 20);
            this.txtMadDaiLy.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 33);
            this.button2.TabIndex = 35;
            this.button2.Text = "Xóa đại lý";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã đại lý";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên đại lý";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Hình thức thanh toán";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nợ đầu kỳ";
            this.Column6.Name = "Column6";
            // 
            // frmDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDaiLy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNoDauKy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHinhThucThanhToan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDaiLy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMadDaiLy);
            this.Controls.Add(this.label1);
            this.Name = "frmDaiLy";
            this.Text = "Quản lý đại lý";
            this.Load += new System.EventHandler(this.frmDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDaiLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgDaiLy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoDauKy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHinhThucThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMadDaiLy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}