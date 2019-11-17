using BTL.QLNhanVien;
using BTL.QLPhongMay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.QLLichTH
{
	public partial class FrmQuanLyLichTH : Form
	{
		SqlConnection sqlConnection;
		

		public FrmQuanLyLichTH()
		{
			InitializeComponent();
		}

		private void xuiButton1_Click(object sender, EventArgs e)
		{
			FrmQuanLyPM quanLyPhongMay = new FrmQuanLyPM(sqlConnection);
			quanLyPhongMay.Show();
		}

		private void btnNhanVien_Click(object sender, EventArgs e)
		{
			FrmQuanLyNV quanLyNV = new FrmQuanLyNV(sqlConnection);
			
			quanLyNV.Show();
		}

		private void btnGiaoVien_Click(object sender, EventArgs e)
		{
			FrmGiaoVien giaoVien = new FrmGiaoVien(sqlConnection);
			giaoVien.Show();
		}

		private void btnLop_Click(object sender, EventArgs e)
		{

			FrmLop lop = new FrmLop(sqlConnection);
			lop.Show();
		}

		private void btnMonThucHanh_Click(object sender, EventArgs e)
		{
			FrmMonTH monTH = new FrmMonTH(sqlConnection);
			monTH.Show();
		}

		private void btnCaHoc_Click(object sender, EventArgs e)
		{
			FrmCaHoc caHoc = new FrmCaHoc(sqlConnection);
			caHoc.Show();
		}

		private void btnThongTinLichTH_Click(object sender, EventArgs e)
		{
			FrmThongTinLichTH thongTinLichTH = new FrmThongTinLichTH(sqlConnection);
			thongTinLichTH.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmQuanLyLichTH_Load(object sender, EventArgs e)
		{
			string conn = @"Data Source=TOANUTC\SQLEXPRESS;Initial Catalog=PHONGMAY;Integrated Security=True";
			sqlConnection = new SqlConnection(conn);
			sqlConnection.Open();
		}
	}
}
