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
	public partial class FrmThongTin : Form
	{
		 SqlConnection sqlConnection;
		public FrmThongTin(SqlConnection sql)
		{
			sqlConnection = sql;
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FrmThongTinMayTinh ttmt = new FrmThongTinMayTinh(sqlConnection);
			ttmt.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FrmThongTinNV ttnv = new FrmThongTinNV(sqlConnection);
			ttnv.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmThongTinPM ttpm = new FrmThongTinPM(sqlConnection);
			ttpm.Show();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			FrmThongTinLichTH ttlth = new FrmThongTinLichTH(sqlConnection);
			ttlth.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void FrmThongTin_Load(object sender, EventArgs e)
		{

		}
	}
}
