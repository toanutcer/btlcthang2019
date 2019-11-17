namespace BTL.QLNhanVien
{
	partial class FrmQuanLyNV
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNV));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvThongTinNV = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.ptbQuayLai = new System.Windows.Forms.PictureBox();
			this.ptbLuu = new System.Windows.Forms.PictureBox();
			this.ptbSua = new System.Windows.Forms.PictureBox();
			this.ptbXoa = new System.Windows.Forms.PictureBox();
			this.ptbThem = new System.Windows.Forms.PictureBox();
			this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.txtMaTinh = new System.Windows.Forms.TextBox();
			this.txtMaPM = new System.Windows.Forms.TextBox();
			this.txtNamSinh = new System.Windows.Forms.TextBox();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbQuayLai)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbLuu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbSua)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbXoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbThem)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.cmbGioiTinh);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.txtMaTinh);
			this.groupBox1.Controls.Add(this.txtMaPM);
			this.groupBox1.Controls.Add(this.txtNamSinh);
			this.groupBox1.Controls.Add(this.txtTenNV);
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.groupBox1.ForeColor = System.Drawing.Color.DarkMagenta;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox1.Size = new System.Drawing.Size(1031, 590);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin Nhân viên";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvThongTinNV);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.ForeColor = System.Drawing.Color.DarkMagenta;
			this.groupBox2.Location = new System.Drawing.Point(1, 123);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox2.Size = new System.Drawing.Size(1029, 466);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách";
			// 
			// dgvThongTinNV
			// 
			this.dgvThongTinNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvThongTinNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvThongTinNV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvThongTinNV.Location = new System.Drawing.Point(1, 20);
			this.dgvThongTinNV.Margin = new System.Windows.Forms.Padding(1);
			this.dgvThongTinNV.Name = "dgvThongTinNV";
			this.dgvThongTinNV.RowHeadersWidth = 102;
			this.dgvThongTinNV.RowTemplate.Height = 40;
			this.dgvThongTinNV.Size = new System.Drawing.Size(1027, 360);
			this.dgvThongTinNV.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.ptbQuayLai);
			this.groupBox3.Controls.Add(this.ptbLuu);
			this.groupBox3.Controls.Add(this.ptbSua);
			this.groupBox3.Controls.Add(this.ptbXoa);
			this.groupBox3.Controls.Add(this.ptbThem);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.groupBox3.ForeColor = System.Drawing.Color.DarkMagenta;
			this.groupBox3.Location = new System.Drawing.Point(1, 380);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox3.Size = new System.Drawing.Size(1027, 85);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chức năng";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(781, 64);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 20);
			this.label12.TabIndex = 9;
			this.label12.Text = "Quay Lại";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(612, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(36, 20);
			this.label11.TabIndex = 8;
			this.label11.Text = "Lưu";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(446, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 20);
			this.label10.TabIndex = 7;
			this.label10.Text = "Sửa";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(288, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 20);
			this.label9.TabIndex = 6;
			this.label9.Text = "Xóa";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(126, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 20);
			this.label8.TabIndex = 5;
			this.label8.Text = "Thêm";
			// 
			// ptbQuayLai
			// 
			this.ptbQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("ptbQuayLai.Image")));
			this.ptbQuayLai.Location = new System.Drawing.Point(789, 11);
			this.ptbQuayLai.Name = "ptbQuayLai";
			this.ptbQuayLai.Size = new System.Drawing.Size(63, 51);
			this.ptbQuayLai.TabIndex = 4;
			this.ptbQuayLai.TabStop = false;
			this.ptbQuayLai.Click += new System.EventHandler(this.ptbQuayLai_Click);
			// 
			// ptbLuu
			// 
			this.ptbLuu.Image = ((System.Drawing.Image)(resources.GetObject("ptbLuu.Image")));
			this.ptbLuu.Location = new System.Drawing.Point(616, 11);
			this.ptbLuu.Name = "ptbLuu";
			this.ptbLuu.Size = new System.Drawing.Size(63, 51);
			this.ptbLuu.TabIndex = 3;
			this.ptbLuu.TabStop = false;
			// 
			// ptbSua
			// 
			this.ptbSua.Image = ((System.Drawing.Image)(resources.GetObject("ptbSua.Image")));
			this.ptbSua.Location = new System.Drawing.Point(450, 11);
			this.ptbSua.Name = "ptbSua";
			this.ptbSua.Size = new System.Drawing.Size(63, 51);
			this.ptbSua.TabIndex = 2;
			this.ptbSua.TabStop = false;
			// 
			// ptbXoa
			// 
			this.ptbXoa.Image = ((System.Drawing.Image)(resources.GetObject("ptbXoa.Image")));
			this.ptbXoa.Location = new System.Drawing.Point(288, 11);
			this.ptbXoa.Name = "ptbXoa";
			this.ptbXoa.Size = new System.Drawing.Size(63, 51);
			this.ptbXoa.TabIndex = 1;
			this.ptbXoa.TabStop = false;
			// 
			// ptbThem
			// 
			this.ptbThem.Image = ((System.Drawing.Image)(resources.GetObject("ptbThem.Image")));
			this.ptbThem.Location = new System.Drawing.Point(120, 11);
			this.ptbThem.Name = "ptbThem";
			this.ptbThem.Size = new System.Drawing.Size(63, 51);
			this.ptbThem.TabIndex = 0;
			this.ptbThem.TabStop = false;
			// 
			// cmbGioiTinh
			// 
			this.cmbGioiTinh.FormattingEnabled = true;
			this.cmbGioiTinh.Location = new System.Drawing.Point(577, 38);
			this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(1);
			this.cmbGioiTinh.Name = "cmbGioiTinh";
			this.cmbGioiTinh.Size = new System.Drawing.Size(87, 28);
			this.cmbGioiTinh.TabIndex = 13;
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Location = new System.Drawing.Point(754, 41);
			this.txtDienThoai.Margin = new System.Windows.Forms.Padding(1);
			this.txtDienThoai.Multiline = true;
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(127, 30);
			this.txtDienThoai.TabIndex = 12;
			// 
			// txtMaTinh
			// 
			this.txtMaTinh.Location = new System.Drawing.Point(577, 87);
			this.txtMaTinh.Margin = new System.Windows.Forms.Padding(1);
			this.txtMaTinh.Multiline = true;
			this.txtMaTinh.Name = "txtMaTinh";
			this.txtMaTinh.Size = new System.Drawing.Size(87, 30);
			this.txtMaTinh.TabIndex = 11;
			// 
			// txtMaPM
			// 
			this.txtMaPM.Location = new System.Drawing.Point(356, 38);
			this.txtMaPM.Margin = new System.Windows.Forms.Padding(1);
			this.txtMaPM.Multiline = true;
			this.txtMaPM.Name = "txtMaPM";
			this.txtMaPM.Size = new System.Drawing.Size(136, 30);
			this.txtMaPM.TabIndex = 10;
			// 
			// txtNamSinh
			// 
			this.txtNamSinh.Location = new System.Drawing.Point(356, 87);
			this.txtNamSinh.Margin = new System.Windows.Forms.Padding(1);
			this.txtNamSinh.Multiline = true;
			this.txtNamSinh.Name = "txtNamSinh";
			this.txtNamSinh.Size = new System.Drawing.Size(136, 30);
			this.txtNamSinh.TabIndex = 9;
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(96, 87);
			this.txtTenNV.Margin = new System.Windows.Forms.Padding(1);
			this.txtTenNV.Multiline = true;
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(150, 30);
			this.txtTenNV.TabIndex = 8;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(96, 34);
			this.txtMaNV.Margin = new System.Windows.Forms.Padding(1);
			this.txtMaNV.Multiline = true;
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(150, 30);
			this.txtMaNV.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label7.Location = new System.Drawing.Point(512, 42);
			this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "Giới tính :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label6.Location = new System.Drawing.Point(260, 92);
			this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Năm sinh :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label5.Location = new System.Drawing.Point(260, 45);
			this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mã Phòng Máy :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(34, 92);
			this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tên NV :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(513, 92);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mã tỉnh : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(679, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Điện thoại :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(34, 45);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã NV :";
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(1, 20);
			this.panel1.Margin = new System.Windows.Forms.Padding(1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1029, 103);
			this.panel1.TabIndex = 15;
			// 
			// FrmQuanLyNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 590);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "FrmQuanLyNV";
			this.Text = "FrmQuanLyNV";
			this.Load += new System.EventHandler(this.FrmQuanLyNV_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbQuayLai)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbLuu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbSua)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbXoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbThem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbGioiTinh;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.TextBox txtMaTinh;
		private System.Windows.Forms.TextBox txtMaPM;
		private System.Windows.Forms.TextBox txtNamSinh;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvThongTinNV;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox ptbQuayLai;
		private System.Windows.Forms.PictureBox ptbLuu;
		private System.Windows.Forms.PictureBox ptbSua;
		private System.Windows.Forms.PictureBox ptbXoa;
		private System.Windows.Forms.PictureBox ptbThem;
	}
}