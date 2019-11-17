using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
	public partial class FrmTimKiem : Form
	{
		public FrmTimKiem()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmTimKiemLichTH timKiemLichTH = new FrmTimKiemLichTH();
			timKiemLichTH.Show();
		}

		private void btnTimKiemMayTinh_Click(object sender, EventArgs e)
		{
			FrmTimKiemMayTinh timKiemMayTinh = new FrmTimKiemMayTinh();
			timKiemMayTinh.Show();
		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}
	}
}
