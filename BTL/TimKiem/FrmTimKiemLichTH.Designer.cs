namespace BTL
{
	partial class FrmTimKiemLichTH
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

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemLichTH));
			this.rdbPhongMay = new System.Windows.Forms.RadioButton();
			this.rdbLop = new System.Windows.Forms.RadioButton();
			this.rdbGiaoVien = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnTimkiem = new System.Windows.Forms.Button();
			this.txtTuKhoa = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvThongtinTimkiem = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThongtinTimkiem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// rdbPhongMay
			// 
			this.rdbPhongMay.AutoSize = true;
			this.rdbPhongMay.Location = new System.Drawing.Point(35, 18);
			this.rdbPhongMay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdbPhongMay.Name = "rdbPhongMay";
			this.rdbPhongMay.Size = new System.Drawing.Size(126, 27);
			this.rdbPhongMay.TabIndex = 1;
			this.rdbPhongMay.TabStop = true;
			this.rdbPhongMay.Text = "Phòng Máy";
			this.rdbPhongMay.UseVisualStyleBackColor = true;
			this.rdbPhongMay.CheckedChanged += new System.EventHandler(this.rdbPhongMay_CheckedChanged);
			// 
			// rdbLop
			// 
			this.rdbLop.AutoSize = true;
			this.rdbLop.Location = new System.Drawing.Point(200, 18);
			this.rdbLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdbLop.Name = "rdbLop";
			this.rdbLop.Size = new System.Drawing.Size(64, 27);
			this.rdbLop.TabIndex = 2;
			this.rdbLop.TabStop = true;
			this.rdbLop.Text = "Lớp";
			this.rdbLop.UseVisualStyleBackColor = true;
			this.rdbLop.CheckedChanged += new System.EventHandler(this.rdbLop_CheckedChanged);
			// 
			// rdbGiaoVien
			// 
			this.rdbGiaoVien.AutoSize = true;
			this.rdbGiaoVien.Location = new System.Drawing.Point(361, 18);
			this.rdbGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdbGiaoVien.Name = "rdbGiaoVien";
			this.rdbGiaoVien.Size = new System.Drawing.Size(114, 27);
			this.rdbGiaoVien.TabIndex = 3;
			this.rdbGiaoVien.TabStop = true;
			this.rdbGiaoVien.Text = "Giáo Viên";
			this.rdbGiaoVien.UseVisualStyleBackColor = true;
			this.rdbGiaoVien.CheckedChanged += new System.EventHandler(this.rdbGiaoVien_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnThoat);
			this.groupBox1.Controls.Add(this.btnTimkiem);
			this.groupBox1.Controls.Add(this.txtTuKhoa);
			this.groupBox1.Controls.Add(this.rdbLop);
			this.groupBox1.Controls.Add(this.rdbGiaoVien);
			this.groupBox1.Controls.Add(this.rdbPhongMay);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(235, 22);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(508, 199);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm theo";
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(295, 130);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(137, 55);
			this.btnThoat.TabIndex = 6;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnTimkiem
			// 
			this.btnTimkiem.Location = new System.Drawing.Point(55, 130);
			this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTimkiem.Name = "btnTimkiem";
			this.btnTimkiem.Size = new System.Drawing.Size(139, 55);
			this.btnTimkiem.TabIndex = 5;
			this.btnTimkiem.Text = "Tìm kiếm";
			this.btnTimkiem.UseVisualStyleBackColor = true;
			this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
			// 
			// txtTuKhoa
			// 
			this.txtTuKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTuKhoa.Location = new System.Drawing.Point(35, 76);
			this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.Size = new System.Drawing.Size(437, 29);
			this.txtTuKhoa.TabIndex = 4;
			this.txtTuKhoa.Text = "Nhập vào từ khóa tìm kiếm";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvThongtinTimkiem);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(16, 260);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(856, 270);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			// 
			// dgvThongtinTimkiem
			// 
			this.dgvThongtinTimkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvThongtinTimkiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvThongtinTimkiem.BackgroundColor = System.Drawing.Color.White;
			this.dgvThongtinTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvThongtinTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvThongtinTimkiem.Location = new System.Drawing.Point(4, 23);
			this.dgvThongtinTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvThongtinTimkiem.Name = "dgvThongtinTimkiem";
			this.dgvThongtinTimkiem.RowHeadersWidth = 51;
			this.dgvThongtinTimkiem.Size = new System.Drawing.Size(848, 243);
			this.dgvThongtinTimkiem.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(183, 207);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// FrmTimKiemLichTH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(880, 533);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmTimKiemLichTH";
			this.Text = "Tìm Kiếm Lịch Thực Hành";
			this.Load += new System.EventHandler(this.FrmTimKiemLichTH_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvThongtinTimkiem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}


		private System.Windows.Forms.RadioButton rdbPhongMay;
		private System.Windows.Forms.RadioButton rdbLop;
		private System.Windows.Forms.RadioButton rdbGiaoVien;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnTimkiem;
		private System.Windows.Forms.TextBox txtTuKhoa;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvThongtinTimkiem;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}