namespace QLCT_May
{
    partial class frmHoaDon
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
            this.dgHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDaiLy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgayLapHoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 33);
            this.button2.TabIndex = 52;
            this.button2.Text = "Xóa hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 33);
            this.button1.TabIndex = 51;
            this.button1.Text = "Thêm hoá đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgHoaDon
            // 
            this.dgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgHoaDon.Location = new System.Drawing.Point(392, 75);
            this.dgHoaDon.Name = "dgHoaDon";
            this.dgHoaDon.RowHeadersWidth = 51;
            this.dgHoaDon.Size = new System.Drawing.Size(414, 217);
            this.dgHoaDon.TabIndex = 50;
            this.dgHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số hoá đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày lập hoá đơn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã đại lý";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(14, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã đại lý";
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMaDaiLy.Location = new System.Drawing.Point(127, 152);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.Size = new System.Drawing.Size(233, 20);
            this.txtMaDaiLy.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ngày lập hoá đơn";
            // 
            // txtNgayLapHoaDon
            // 
            this.txtNgayLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNgayLapHoaDon.Location = new System.Drawing.Point(127, 110);
            this.txtNgayLapHoaDon.Name = "txtNgayLapHoaDon";
            this.txtNgayLapHoaDon.Size = new System.Drawing.Size(233, 20);
            this.txtNgayLapHoaDon.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Số hoá đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 38;
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSoHoaDon.Location = new System.Drawing.Point(127, 72);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(233, 20);
            this.txtSoHoaDon.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgHoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaDaiLy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgayLapHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHoaDon";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDaiLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgayLapHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}