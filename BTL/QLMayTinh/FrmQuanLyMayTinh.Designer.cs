namespace BTL
{
	partial class FrmQuanLyMayTinh
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyMayTinh));
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.xuiButton1 = new XanderUI.XUIButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnTocDo = new System.Windows.Forms.Button();
			this.btnRam = new System.Windows.Forms.Button();
			this.btnChip = new System.Windows.Forms.Button();
			this.btnDungLuong = new System.Windows.Forms.Button();
			this.btnOCung = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnCoManHinh = new System.Windows.Forms.Button();
			this.btnMaBanPhim = new System.Windows.Forms.Button();
			this.btnManHinh = new System.Windows.Forms.Button();
			this.btnMaChuot = new System.Windows.Forms.Button();
			this.btnMaODia = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("High Tower Text", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LightCoral;
			this.label1.Location = new System.Drawing.Point(100, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(509, 71);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Máy Tính";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 84);
			this.panel2.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.xuiButton1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 460);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 98);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// xuiButton1
			// 
			this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
			this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xuiButton1.ButtonText = "Thông Tin Máy Tính";
			this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.xuiButton1.CornerRadius = 5;
			this.xuiButton1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xuiButton1.Location = new System.Drawing.Point(4, 4);
			this.xuiButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.xuiButton1.Name = "xuiButton1";
			this.xuiButton1.Size = new System.Drawing.Size(283, 86);
			this.xuiButton1.TabIndex = 2;
			this.xuiButton1.TextColor = System.Drawing.Color.DodgerBlue;
			this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(479, 4);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(301, 86);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnTocDo);
			this.panel3.Controls.Add(this.btnRam);
			this.panel3.Controls.Add(this.btnChip);
			this.panel3.Controls.Add(this.btnDungLuong);
			this.panel3.Controls.Add(this.btnOCung);
			this.panel3.Controls.Add(this.splitter1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 84);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(380, 376);
			this.panel3.TabIndex = 4;
			// 
			// btnTocDo
			// 
			this.btnTocDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnTocDo.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnTocDo.Location = new System.Drawing.Point(76, 316);
			this.btnTocDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTocDo.Name = "btnTocDo";
			this.btnTocDo.Size = new System.Drawing.Size(211, 55);
			this.btnTocDo.TabIndex = 5;
			this.btnTocDo.Text = "Tốc Độ";
			this.btnTocDo.UseVisualStyleBackColor = true;
			this.btnTocDo.Click += new System.EventHandler(this.btnTocDo_Click);
			// 
			// btnRam
			// 
			this.btnRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnRam.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnRam.Location = new System.Drawing.Point(76, 241);
			this.btnRam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRam.Name = "btnRam";
			this.btnRam.Size = new System.Drawing.Size(211, 55);
			this.btnRam.TabIndex = 4;
			this.btnRam.Text = "Ram";
			this.btnRam.UseVisualStyleBackColor = true;
			this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
			// 
			// btnChip
			// 
			this.btnChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnChip.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnChip.Location = new System.Drawing.Point(76, 162);
			this.btnChip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnChip.Name = "btnChip";
			this.btnChip.Size = new System.Drawing.Size(211, 55);
			this.btnChip.TabIndex = 3;
			this.btnChip.Text = "Chíp";
			this.btnChip.UseVisualStyleBackColor = true;
			this.btnChip.Click += new System.EventHandler(this.btnChip_Click);
			// 
			// btnDungLuong
			// 
			this.btnDungLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnDungLuong.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnDungLuong.Location = new System.Drawing.Point(76, 85);
			this.btnDungLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDungLuong.Name = "btnDungLuong";
			this.btnDungLuong.Size = new System.Drawing.Size(211, 55);
			this.btnDungLuong.TabIndex = 2;
			this.btnDungLuong.Text = "Dung Lượng";
			this.btnDungLuong.UseVisualStyleBackColor = true;
			this.btnDungLuong.Click += new System.EventHandler(this.btnDungLuong_Click);
			// 
			// btnOCung
			// 
			this.btnOCung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnOCung.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnOCung.Location = new System.Drawing.Point(76, 7);
			this.btnOCung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOCung.Name = "btnOCung";
			this.btnOCung.Size = new System.Drawing.Size(211, 55);
			this.btnOCung.TabIndex = 1;
			this.btnOCung.Text = "Ổ cứng";
			this.btnOCung.UseVisualStyleBackColor = true;
			this.btnOCung.Click += new System.EventHandler(this.btnOCung_Click);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(376, 0);
			this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(4, 376);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnCoManHinh);
			this.panel4.Controls.Add(this.btnMaBanPhim);
			this.panel4.Controls.Add(this.btnManHinh);
			this.panel4.Controls.Add(this.btnMaChuot);
			this.panel4.Controls.Add(this.btnMaODia);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(388, 84);
			this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(396, 376);
			this.panel4.TabIndex = 5;
			// 
			// btnCoManHinh
			// 
			this.btnCoManHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnCoManHinh.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnCoManHinh.Location = new System.Drawing.Point(91, 316);
			this.btnCoManHinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCoManHinh.Name = "btnCoManHinh";
			this.btnCoManHinh.Size = new System.Drawing.Size(211, 55);
			this.btnCoManHinh.TabIndex = 10;
			this.btnCoManHinh.Text = "Cỡ Màn Hình";
			this.btnCoManHinh.UseVisualStyleBackColor = true;
			this.btnCoManHinh.Click += new System.EventHandler(this.btnCoManHinh_Click);
			// 
			// btnMaBanPhim
			// 
			this.btnMaBanPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnMaBanPhim.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnMaBanPhim.Location = new System.Drawing.Point(91, 85);
			this.btnMaBanPhim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMaBanPhim.Name = "btnMaBanPhim";
			this.btnMaBanPhim.Size = new System.Drawing.Size(211, 55);
			this.btnMaBanPhim.TabIndex = 7;
			this.btnMaBanPhim.Text = "Mã Bàn Phím";
			this.btnMaBanPhim.UseVisualStyleBackColor = true;
			this.btnMaBanPhim.Click += new System.EventHandler(this.btnMaBanPhim_Click);
			// 
			// btnManHinh
			// 
			this.btnManHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnManHinh.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnManHinh.Location = new System.Drawing.Point(91, 241);
			this.btnManHinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnManHinh.Name = "btnManHinh";
			this.btnManHinh.Size = new System.Drawing.Size(211, 55);
			this.btnManHinh.TabIndex = 9;
			this.btnManHinh.Text = "Màn Hình";
			this.btnManHinh.UseVisualStyleBackColor = true;
			this.btnManHinh.Click += new System.EventHandler(this.btnManHinh_Click);
			// 
			// btnMaChuot
			// 
			this.btnMaChuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnMaChuot.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnMaChuot.Location = new System.Drawing.Point(91, 7);
			this.btnMaChuot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMaChuot.Name = "btnMaChuot";
			this.btnMaChuot.Size = new System.Drawing.Size(211, 55);
			this.btnMaChuot.TabIndex = 6;
			this.btnMaChuot.Text = "Mã Chuột";
			this.btnMaChuot.UseVisualStyleBackColor = true;
			this.btnMaChuot.Click += new System.EventHandler(this.btnMaChuot_Click);
			// 
			// btnMaODia
			// 
			this.btnMaODia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnMaODia.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.btnMaODia.Location = new System.Drawing.Point(91, 162);
			this.btnMaODia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMaODia.Name = "btnMaODia";
			this.btnMaODia.Size = new System.Drawing.Size(211, 55);
			this.btnMaODia.TabIndex = 8;
			this.btnMaODia.Text = "Mã Ổ Đĩa";
			this.btnMaODia.UseVisualStyleBackColor = true;
			this.btnMaODia.Click += new System.EventHandler(this.btnMaODia_Click);
			// 
			// FrmQuanLyMayTinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cornsilk;
			this.ClientSize = new System.Drawing.Size(784, 558);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.Cornsilk;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmQuanLyMayTinh";
			this.Text = "FrmQuanLyPM";
			this.Load += new System.EventHandler(this.FrmQuanLyMayTinh_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnTocDo;
		private System.Windows.Forms.Button btnRam;
		private System.Windows.Forms.Button btnChip;
		private System.Windows.Forms.Button btnDungLuong;
		private System.Windows.Forms.Button btnOCung;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnCoManHinh;
		private System.Windows.Forms.Button btnMaBanPhim;
		private System.Windows.Forms.Button btnManHinh;
		private System.Windows.Forms.Button btnMaChuot;
		private System.Windows.Forms.Button btnMaODia;
		private System.Windows.Forms.PictureBox pictureBox2;
		private XanderUI.XUIButton xuiButton1;
	}
}