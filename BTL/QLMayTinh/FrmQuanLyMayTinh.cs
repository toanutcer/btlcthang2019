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

namespace BTL
{
	public partial class FrmQuanLyMayTinh : Form
	{
		SqlConnection sqlConnection;
		public FrmQuanLyMayTinh(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void btnOCung_Click(object sender, EventArgs e)
		{
			FrmOCung oCung = new FrmOCung(sqlConnection);
			oCung.Show();
		}

		private void btnDungLuong_Click(object sender, EventArgs e)
		{
			FrmDungLuong dungLuong = new FrmDungLuong(sqlConnection);
			dungLuong.Show();
		}

		private void btnChip_Click(object sender, EventArgs e)
		{
			FrmChip chip = new FrmChip(sqlConnection);
			chip.Show();

		}

		private void btnRam_Click(object sender, EventArgs e)
		{
			FrmRam ram = new FrmRam(sqlConnection);
			ram.Show();
		}

		private void btnTocDo_Click(object sender, EventArgs e)
		{
			FrmTocDo tocDo = new FrmTocDo(sqlConnection);
			tocDo.Show();
		}

		private void btnMaChuot_Click(object sender, EventArgs e)
		{
			FrmMaChuot maChuot = new FrmMaChuot(sqlConnection);
			maChuot.Show();
		}

		private void btnMaBanPhim_Click(object sender, EventArgs e)
		{
			FrmMaBanPhim maBanPhim = new FrmMaBanPhim(sqlConnection);
			maBanPhim.Show();
		}

		private void btnMaODia_Click(object sender, EventArgs e)
		{
			FrmMaODia maODia = new FrmMaODia(sqlConnection);
			maODia.Show();
		}

		private void btnManHinh_Click(object sender, EventArgs e)
		{
			FrmManHinh manHinh = new FrmManHinh(sqlConnection);
			manHinh.Show();
		}

		private void btnCoManHinh_Click(object sender, EventArgs e)
		{
			FrmCoManHinh coManHinh = new FrmCoManHinh(sqlConnection);
			coManHinh.Show();
		}

		private void xuiButton1_Click(object sender, EventArgs e)
		{
			FrmThongTinMayTinh ttmt = new FrmThongTinMayTinh(sqlConnection);
			ttmt.Show();
		}

		private void FrmQuanLyMayTinh_Load(object sender, EventArgs e)
		{

		}
	}
}
