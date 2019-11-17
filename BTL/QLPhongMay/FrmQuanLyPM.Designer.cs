namespace BTL.QLPhongMay
{
	partial class FrmQuanLyPM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyPM));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvThongTinPM = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ptbQuayLai = new System.Windows.Forms.PictureBox();
			this.ptbLuu = new System.Windows.Forms.PictureBox();
			this.ptbSua = new System.Windows.Forms.PictureBox();
			this.ptbXoa = new System.Windows.Forms.PictureBox();
			this.ptbThem = new System.Windows.Forms.PictureBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMaPM = new System.Windows.Forms.TextBox();
			this.txtTenPM = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.txtDiaDiem = new System.Windows.Forms.TextBox();
			this.txtSoMay = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMs = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPM)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbQuayLai)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbLuu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbSua)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbXoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbThem)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.groupBox1.ForeColor = System.Drawing.Color.DarkMagenta;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox1.Size = new System.Drawing.Size(1054, 562);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Phòng Máy";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvThongTinPM);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.ForeColor = System.Drawing.Color.DarkMagenta;
			this.groupBox2.Location = new System.Drawing.Point(1, 139);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox2.Size = new System.Drawing.Size(1052, 422);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách";
			// 
			// dgvThongTinPM
			// 
			this.dgvThongTinPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvThongTinPM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvThongTinPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvThongTinPM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvThongTinPM.Location = new System.Drawing.Point(1, 20);
			this.dgvThongTinPM.Margin = new System.Windows.Forms.Padding(1);
			this.dgvThongTinPM.Name = "dgvThongTinPM";
			this.dgvThongTinPM.RowHeadersWidth = 102;
			this.dgvThongTinPM.RowTemplate.Height = 40;
			this.dgvThongTinPM.Size = new System.Drawing.Size(1050, 303);
			this.dgvThongTinPM.TabIndex = 0;
			this.dgvThongTinPM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinPM_CellContentClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.ptbQuayLai);
			this.groupBox3.Controls.Add(this.ptbLuu);
			this.groupBox3.Controls.Add(this.ptbSua);
			this.groupBox3.Controls.Add(this.ptbXoa);
			this.groupBox3.Controls.Add(this.ptbThem);
			this.groupBox3.Controls.Add(this.splitter1);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.groupBox3.ForeColor = System.Drawing.Color.DarkMagenta;
			this.groupBox3.Location = new System.Drawing.Point(1, 323);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox3.Size = new System.Drawing.Size(1050, 98);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Chức năng";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label17.ForeColor = System.Drawing.Color.Teal;
			this.label17.Location = new System.Drawing.Point(836, 72);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(73, 20);
			this.label17.TabIndex = 15;
			this.label17.Text = "Quay lại";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label16.ForeColor = System.Drawing.Color.Teal;
			this.label16.Location = new System.Drawing.Point(654, 72);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(39, 20);
			this.label16.TabIndex = 14;
			this.label16.Text = "Lưu";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label15.ForeColor = System.Drawing.Color.Teal;
			this.label15.Location = new System.Drawing.Point(485, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 20);
			this.label15.TabIndex = 13;
			this.label15.Text = "Sửa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(304, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Xóa";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(128, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Thêm";
			// 
			// ptbQuayLai
			// 
			this.ptbQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("ptbQuayLai.Image")));
			this.ptbQuayLai.Location = new System.Drawing.Point(848, 12);
			this.ptbQuayLai.Name = "ptbQuayLai";
			this.ptbQuayLai.Size = new System.Drawing.Size(61, 56);
			this.ptbQuayLai.TabIndex = 10;
			this.ptbQuayLai.TabStop = false;
			this.ptbQuayLai.Click += new System.EventHandler(this.ptbQuayLai_Click);
			// 
			// ptbLuu
			// 
			this.ptbLuu.Image = ((System.Drawing.Image)(resources.GetObject("ptbLuu.Image")));
			this.ptbLuu.Location = new System.Drawing.Point(658, 12);
			this.ptbLuu.Name = "ptbLuu";
			this.ptbLuu.Size = new System.Drawing.Size(61, 56);
			this.ptbLuu.TabIndex = 9;
			this.ptbLuu.TabStop = false;
			// 
			// ptbSua
			// 
			this.ptbSua.Image = ((System.Drawing.Image)(resources.GetObject("ptbSua.Image")));
			this.ptbSua.Location = new System.Drawing.Point(489, 11);
			this.ptbSua.Name = "ptbSua";
			this.ptbSua.Size = new System.Drawing.Size(61, 56);
			this.ptbSua.TabIndex = 8;
			this.ptbSua.TabStop = false;
			// 
			// ptbXoa
			// 
			this.ptbXoa.Image = ((System.Drawing.Image)(resources.GetObject("ptbXoa.Image")));
			this.ptbXoa.Location = new System.Drawing.Point(308, 10);
			this.ptbXoa.Name = "ptbXoa";
			this.ptbXoa.Size = new System.Drawing.Size(61, 56);
			this.ptbXoa.TabIndex = 7;
			this.ptbXoa.TabStop = false;
			// 
			// ptbThem
			// 
			this.ptbThem.Image = ((System.Drawing.Image)(resources.GetObject("ptbThem.Image")));
			this.ptbThem.Location = new System.Drawing.Point(124, 9);
			this.ptbThem.Name = "ptbThem";
			this.ptbThem.Size = new System.Drawing.Size(61, 56);
			this.ptbThem.TabIndex = 6;
			this.ptbThem.TabStop = false;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(1, 20);
			this.splitter1.Margin = new System.Windows.Forms.Padding(1);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(1, 77);
			this.splitter1.TabIndex = 5;
			this.splitter1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtMaPM);
			this.panel1.Controls.Add(this.txtTenPM);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txt);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtDienThoai);
			this.panel1.Controls.Add(this.txtDiaDiem);
			this.panel1.Controls.Add(this.txtSoMay);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtMs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(1, 20);
			this.panel1.Margin = new System.Windows.Forms.Padding(1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1052, 119);
			this.panel1.TabIndex = 15;
			// 
			// txtMaPM
			// 
			this.txtMaPM.Location = new System.Drawing.Point(95, 13);
			this.txtMaPM.Margin = new System.Windows.Forms.Padding(1);
			this.txtMaPM.Multiline = true;
			this.txtMaPM.Name = "txtMaPM";
			this.txtMaPM.Size = new System.Drawing.Size(150, 30);
			this.txtMaPM.TabIndex = 32;
			// 
			// txtTenPM
			// 
			this.txtTenPM.Location = new System.Drawing.Point(95, 54);
			this.txtTenPM.Margin = new System.Windows.Forms.Padding(1);
			this.txtTenPM.Multiline = true;
			this.txtTenPM.Name = "txtTenPM";
			this.txtTenPM.Size = new System.Drawing.Size(150, 30);
			this.txtTenPM.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(11, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã PM :";
			// 
			// txt
			// 
			this.txt.AutoSize = true;
			this.txt.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txt.Location = new System.Drawing.Point(11, 58);
			this.txt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(59, 17);
			this.txt.TabIndex = 3;
			this.txt.Text = "Tên PM :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label6.Location = new System.Drawing.Point(306, 58);
			this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Địa Điểm :";
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Location = new System.Drawing.Point(791, 13);
			this.txtDienThoai.Margin = new System.Windows.Forms.Padding(1);
			this.txtDienThoai.Multiline = true;
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(189, 30);
			this.txtDienThoai.TabIndex = 20;
			// 
			// txtDiaDiem
			// 
			this.txtDiaDiem.Location = new System.Drawing.Point(415, 58);
			this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(1);
			this.txtDiaDiem.Multiline = true;
			this.txtDiaDiem.Name = "txtDiaDiem";
			this.txtDiaDiem.Size = new System.Drawing.Size(256, 30);
			this.txtDiaDiem.TabIndex = 9;
			// 
			// txtSoMay
			// 
			this.txtSoMay.Location = new System.Drawing.Point(415, 11);
			this.txtSoMay.Margin = new System.Windows.Forms.Padding(1);
			this.txtSoMay.Multiline = true;
			this.txtSoMay.Name = "txtSoMay";
			this.txtSoMay.Size = new System.Drawing.Size(136, 30);
			this.txtSoMay.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label5.Location = new System.Drawing.Point(306, 18);
			this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số Máy :";
			// 
			// txtMs
			// 
			this.txtMs.AutoSize = true;
			this.txtMs.Font = new System.Drawing.Font("#9Slide03 Ample", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtMs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtMs.Location = new System.Drawing.Point(689, 18);
			this.txtMs.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.txtMs.Name = "txtMs";
			this.txtMs.Size = new System.Drawing.Size(77, 17);
			this.txtMs.TabIndex = 1;
			this.txtMs.Text = "Điện Thoại :";
			// 
			// FrmQuanLyPM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1054, 562);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "FrmQuanLyPM";
			this.Text = "FrmQuanLyPM";
			this.Load += new System.EventHandler(this.FrmQuanLyPM_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPM)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbQuayLai)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbLuu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbSua)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbXoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbThem)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}



		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSoMay;
		private System.Windows.Forms.TextBox txtDiaDiem;
		private System.Windows.Forms.TextBox txtTenPM;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label txt;
		private System.Windows.Forms.Label txtMs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvThongTinPM;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMaPM;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.PictureBox ptbSua;
		private System.Windows.Forms.PictureBox ptbXoa;
		private System.Windows.Forms.PictureBox ptbThem;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox ptbQuayLai;
		private System.Windows.Forms.PictureBox ptbLuu;
	}
}