namespace STUDENT.GUI
{
    partial class PhanLopHocSinh
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHocSinhPhanLop = new System.Windows.Forms.DataGridView();
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.btnPhanLop = new System.Windows.Forms.Button();
            this.btnXoaHocSinhTrongLop = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiSoLop = new System.Windows.Forms.TextBox();
            this.txtMaHocSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNamHoc = new System.Windows.Forms.DateTimePicker();
            this.btnDanhSachHocSinh = new System.Windows.Forms.Button();
            this.btnTraCuuHocSinh = new System.Windows.Forms.Button();
            this.btnLuuDanhSachLop = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDanhSachLop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinhPhanLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(909, 481);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(909, 435);
            this.splitContainer2.SplitterDistance = 404;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDanhSachHocSinh);
            this.groupBox1.Controls.Add(this.btnTraCuuHocSinh);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaHocSinh);
            this.groupBox1.Controls.Add(this.dgvDanhSachHocSinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÂN LỚP HỌC SINH";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnXoaHocSinhTrongLop);
            this.splitContainer3.Panel1.Controls.Add(this.btnPhanLop);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(501, 435);
            this.splitContainer3.SplitterDistance = 109;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnDanhSachLop);
            this.groupBox2.Controls.Add(this.dtNamHoc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnLuuDanhSachLop);
            this.groupBox2.Controls.Add(this.txtSiSoLop);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbKhoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbLop);
            this.groupBox2.Controls.Add(this.dgvDanhSachHocSinhPhanLop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 435);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phân Lớp Học Sinh";
            // 
            // dgvDanhSachHocSinhPhanLop
            // 
            this.dgvDanhSachHocSinhPhanLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinhPhanLop.Location = new System.Drawing.Point(6, 208);
            this.dgvDanhSachHocSinhPhanLop.Name = "dgvDanhSachHocSinhPhanLop";
            this.dgvDanhSachHocSinhPhanLop.Size = new System.Drawing.Size(379, 221);
            this.dgvDanhSachHocSinhPhanLop.TabIndex = 0;
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(6, 208);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(392, 221);
            this.dgvDanhSachHocSinh.TabIndex = 1;
            // 
            // btnPhanLop
            // 
            this.btnPhanLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanLop.Location = new System.Drawing.Point(3, 244);
            this.btnPhanLop.Name = "btnPhanLop";
            this.btnPhanLop.Size = new System.Drawing.Size(94, 67);
            this.btnPhanLop.TabIndex = 0;
            this.btnPhanLop.Text = "Chuyển đến lớp";
            this.btnPhanLop.UseVisualStyleBackColor = true;
            // 
            // btnXoaHocSinhTrongLop
            // 
            this.btnXoaHocSinhTrongLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHocSinhTrongLop.Location = new System.Drawing.Point(3, 331);
            this.btnXoaHocSinhTrongLop.Name = "btnXoaHocSinhTrongLop";
            this.btnXoaHocSinhTrongLop.Size = new System.Drawing.Size(94, 60);
            this.btnXoaHocSinhTrongLop.TabIndex = 1;
            this.btnXoaHocSinhTrongLop.Text = "Xóa Học Sinh Khỏi Lớp";
            this.btnXoaHocSinhTrongLop.UseVisualStyleBackColor = true;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(63, 35);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 28);
            this.cbLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khối:";
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(67, 78);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 28);
            this.cbKhoi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sĩ Số:";
            // 
            // txtSiSoLop
            // 
            this.txtSiSoLop.Location = new System.Drawing.Point(284, 37);
            this.txtSiSoLop.Name = "txtSiSoLop";
            this.txtSiSoLop.Size = new System.Drawing.Size(98, 26);
            this.txtSiSoLop.TabIndex = 6;
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(122, 22);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(200, 26);
            this.txtMaHocSinh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Học Sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(122, 54);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 26);
            this.txtHoTen.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Sinh:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(122, 86);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtNgaySinh.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Năm Học:";
            // 
            // dtNamHoc
            // 
            this.dtNamHoc.Location = new System.Drawing.Point(284, 76);
            this.dtNamHoc.Name = "dtNamHoc";
            this.dtNamHoc.Size = new System.Drawing.Size(98, 26);
            this.dtNamHoc.TabIndex = 12;
            // 
            // btnDanhSachHocSinh
            // 
            this.btnDanhSachHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachHocSinh.Location = new System.Drawing.Point(228, 129);
            this.btnDanhSachHocSinh.Name = "btnDanhSachHocSinh";
            this.btnDanhSachHocSinh.Size = new System.Drawing.Size(94, 50);
            this.btnDanhSachHocSinh.TabIndex = 2;
            this.btnDanhSachHocSinh.Text = "Danh Học Sinh";
            this.btnDanhSachHocSinh.UseVisualStyleBackColor = true;
            // 
            // btnTraCuuHocSinh
            // 
            this.btnTraCuuHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuHocSinh.Location = new System.Drawing.Point(68, 129);
            this.btnTraCuuHocSinh.Name = "btnTraCuuHocSinh";
            this.btnTraCuuHocSinh.Size = new System.Drawing.Size(94, 50);
            this.btnTraCuuHocSinh.TabIndex = 3;
            this.btnTraCuuHocSinh.Text = "Tra Cứu Học Sinh";
            this.btnTraCuuHocSinh.UseVisualStyleBackColor = true;
            // 
            // btnLuuDanhSachLop
            // 
            this.btnLuuDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDanhSachLop.Location = new System.Drawing.Point(21, 139);
            this.btnLuuDanhSachLop.Name = "btnLuuDanhSachLop";
            this.btnLuuDanhSachLop.Size = new System.Drawing.Size(94, 51);
            this.btnLuuDanhSachLop.TabIndex = 4;
            this.btnLuuDanhSachLop.Text = "Lưu Danh Sách Lớp";
            this.btnLuuDanhSachLop.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(282, 138);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 51);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDanhSachLop
            // 
            this.btnDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachLop.Location = new System.Drawing.Point(152, 138);
            this.btnDanhSachLop.Name = "btnDanhSachLop";
            this.btnDanhSachLop.Size = new System.Drawing.Size(94, 50);
            this.btnDanhSachLop.TabIndex = 12;
            this.btnDanhSachLop.Text = "Danh Sách Học Sinh";
            this.btnDanhSachLop.UseVisualStyleBackColor = true;
            // 
            // PhanLopHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 481);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PhanLopHocSinh";
            this.Text = "PhanLopHocSinh";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinhPhanLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDanhSachHocSinh;
        private System.Windows.Forms.Button btnTraCuuHocSinh;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHocSinh;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnXoaHocSinhTrongLop;
        private System.Windows.Forms.Button btnPhanLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDanhSachLop;
        private System.Windows.Forms.DateTimePicker dtNamHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuuDanhSachLop;
        private System.Windows.Forms.TextBox txtSiSoLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinhPhanLop;
    }
}