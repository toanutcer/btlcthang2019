namespace BTL.QLLichTH
{
	partial class FrmQuanLyLichTH
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyLichTH));
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnPhongMay = new XanderUI.XUIButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.btnNhanVien = new XanderUI.XUIButton();
			this.btnGiaoVien = new XanderUI.XUIButton();
			this.btnLop = new XanderUI.XUIButton();
			this.btnMonThucHanh = new XanderUI.XUIButton();
			this.btnCaHoc = new XanderUI.XUIButton();
			this.btnThongTinLichTH = new XanderUI.XUIButton();
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
			this.label1.Font = new System.Drawing.Font("#9Slide04 Yeseva One", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.Tomato;
			this.label1.Location = new System.Drawing.Point(48, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(479, 52);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Lịch Thực Hành";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MistyRose;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(588, 68);
			this.panel2.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MistyRose;
			this.panel1.Controls.Add(this.btnThongTinLichTH);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 373);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(588, 80);
			this.panel1.TabIndex = 3;
			// 
			// btnPhongMay
			// 
			this.btnPhongMay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnPhongMay.ButtonImage = null;
			this.btnPhongMay.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.btnPhongMay.ButtonText = "Phòng Máy";
			this.btnPhongMay.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnPhongMay.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.btnPhongMay.CornerRadius = 5;
			this.btnPhongMay.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnPhongMay.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.btnPhongMay.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnPhongMay.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.btnPhongMay.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.btnPhongMay.Location = new System.Drawing.Point(33, 16);
			this.btnPhongMay.Name = "btnPhongMay";
			this.btnPhongMay.Size = new System.Drawing.Size(212, 70);
			this.btnPhongMay.TabIndex = 2;
			this.btnPhongMay.TextColor = System.Drawing.Color.DodgerBlue;
			this.btnPhongMay.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.btnPhongMay.Click += new System.EventHandler(this.xuiButton1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(330, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(212, 73);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.MistyRose;
			this.panel3.Controls.Add(this.btnGiaoVien);
			this.panel3.Controls.Add(this.btnNhanVien);
			this.panel3.Controls.Add(this.btnPhongMay);
			this.panel3.Controls.Add(this.splitter1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 68);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(291, 305);
			this.panel3.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.MistyRose;
			this.panel4.Controls.Add(this.btnCaHoc);
			this.panel4.Controls.Add(this.btnMonThucHanh);
			this.panel4.Controls.Add(this.btnLop);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(291, 68);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(297, 305);
			this.panel4.TabIndex = 5;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(288, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 305);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// btnNhanVien
			// 
			this.btnNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnNhanVien.ButtonImage = null;
			this.btnNhanVien.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.btnNhanVien.ButtonText = "Nhân Viên";
			this.btnNhanVien.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnNhanVien.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.btnNhanVien.CornerRadius = 5;
			this.btnNhanVien.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnNhanVien.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.btnNhanVien.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnNhanVien.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.btnNhanVien.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.btnNhanVien.Location = new System.Drawing.Point(33, 109);
			this.btnNhanVien.Name = "btnNhanVien";
			this.btnNhanVien.Size = new System.Drawing.Size(212, 70);
			this.btnNhanVien.TabIndex = 3;
			this.btnNhanVien.TextColor = System.Drawing.Color.DodgerBlue;
			this.btnNhanVien.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
			// 
			// btnGiaoVien
			// 
			this.btnGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnGiaoVien.ButtonImage = null;
			this.btnGiaoVien.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.btnGiaoVien.ButtonText = "Giáo Viên";
			this.btnGiaoVien.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnGiaoVien.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.btnGiaoVien.CornerRadius = 5;
			this.btnGiaoVien.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnGiaoVien.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.btnGiaoVien.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnGiaoVien.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.btnGiaoVien.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.btnGiaoVien.Location = new System.Drawing.Point(33, 210);
			this.btnGiaoVien.Name = "btnGiaoVien";
			this.btnGiaoVien.Size = new System.Drawing.Size(212, 70);
			this.btnGiaoVien.TabIndex = 4;
			this.btnGiaoVien.TextColor = System.Drawing.Color.DodgerBlue;
			this.btnGiaoVien.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
			// 
			// btnLop
			// 
			this.btnLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnLop.ButtonImage = null;
			this.btnLop.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.btnLop.ButtonText = "Lớp";
			this.btnLop.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnLop.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.btnLop.CornerRadius = 5;
			this.btnLop.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnLop.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.btnLop.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnLop.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.btnLop.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.btnLop.Location = new System.Drawing.Point(39, 16);
			this.btnLop.Name = "btnLop";
			this.btnLop.Size = new System.Drawing.Size(212, 70);
			this.btnLop.TabIndex = 5;
			this.btnLop.TextColor = System.Drawing.Color.DodgerBlue;
			this.btnLop.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
			// 
			// btnMonThucHanh
			// 
			this.btnMonThucHanh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnMonThucHanh.ButtonImage = null;
			this.btnMonThucHanh.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.btnMonThucHanh.ButtonText = "Môn Thực Hành";
			this.btnMonThucHanh.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnMonThucHanh.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.btnMonThucHanh.CornerRadius = 5;
			this.btnMonThucHanh.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnMonThucHanh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.btnMonThucHanh.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnMonThucHanh.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.btnMonThucHanh.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.btnMonThucHanh.Location = new System.Drawing.Point(39, 109);
			this.btnMonThucHanh.Name = "btnMonThucHanh";
			this.btnMonThucHanh.Size = new System.Drawing.Size(212, 70);
			this.btnMonThucHanh.TabIndex = 6;
			this.btnMonThucHanh.TextColor = System.Drawing.Color.DodgerBlue;
			this.btnMonThucHanh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.btnMonThucHanh.Click += new System.EventHandler(this.btnMonThucHanh_Click);
			// 
			// btnCaHoc
			// 
			this.btnCaHoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCaHoc.ButtonImage = null;
			this.btnCaHoc.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.btnCaHoc.ButtonText = "Ca Học";
			this.btnCaHoc.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnCaHoc.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.btnCaHoc.CornerRadius = 5;
			this.btnCaHoc.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnCaHoc.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.btnCaHoc.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnCaHoc.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.btnCaHoc.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.btnCaHoc.Location = new System.Drawing.Point(39, 210);
			this.btnCaHoc.Name = "btnCaHoc";
			this.btnCaHoc.Size = new System.Drawing.Size(212, 70);
			this.btnCaHoc.TabIndex = 7;
			this.btnCaHoc.TextColor = System.Drawing.Color.DodgerBlue;
			this.btnCaHoc.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.btnCaHoc.Click += new System.EventHandler(this.btnCaHoc_Click);
			// 
			// btnThongTinLichTH
			// 
			this.btnThongTinLichTH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnThongTinLichTH.ButtonImage = null;
			this.btnThongTinLichTH.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.btnThongTinLichTH.ButtonText = "Thông Tin Lịch Thực Hành";
			this.btnThongTinLichTH.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnThongTinLichTH.ClickTextColor = System.Drawing.Color.DodgerBlue;
			this.btnThongTinLichTH.CornerRadius = 5;
			this.btnThongTinLichTH.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnThongTinLichTH.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.btnThongTinLichTH.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnThongTinLichTH.HoverTextColor = System.Drawing.Color.DodgerBlue;
			this.btnThongTinLichTH.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.btnThongTinLichTH.Location = new System.Drawing.Point(33, 6);
			this.btnThongTinLichTH.Name = "btnThongTinLichTH";
			this.btnThongTinLichTH.Size = new System.Drawing.Size(212, 70);
			this.btnThongTinLichTH.TabIndex = 5;
			this.btnThongTinLichTH.TextColor = System.Drawing.Color.DodgerBlue;
			this.btnThongTinLichTH.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.btnThongTinLichTH.Click += new System.EventHandler(this.btnThongTinLichTH_Click);
			// 
			// FrmQuanLyLichTH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cornsilk;
			this.ClientSize = new System.Drawing.Size(588, 453);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Name = "FrmQuanLyLichTH";
			this.Text = "FrmQuanLyPM";
			this.Load += new System.EventHandler(this.FrmQuanLyLichTH_Load);
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
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private XanderUI.XUIButton btnPhongMay;
		private XanderUI.XUIButton btnThongTinLichTH;
		private XanderUI.XUIButton btnGiaoVien;
		private XanderUI.XUIButton btnNhanVien;
		private System.Windows.Forms.Splitter splitter1;
		private XanderUI.XUIButton btnCaHoc;
		private XanderUI.XUIButton btnMonThucHanh;
		private XanderUI.XUIButton btnLop;
	}
}