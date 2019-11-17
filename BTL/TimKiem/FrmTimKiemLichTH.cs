using BTL.TimKiem;
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

	public partial class FrmTimKiemLichTH : Form
	{
		Clsdatabase cls = new Clsdatabase();
		int i = 0;
		public FrmTimKiemLichTH()
		{
			InitializeComponent();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void btnTimkiem_Click(object sender, EventArgs e)
		{
			try
			{
				if ((txtTuKhoa.Text == "") || (txtTuKhoa.Text == "Nhập vào từ khóa tìm kiếm"))
				{
					MessageBox.Show("Bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				}
				else
				{
					if (i == 1)
					{
						cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from [PHONGMAY].[dbo].[Phòng Máy] where[Mã PM]=N'" + txtTuKhoa.Text + "'");
					}
					if (i == 2)
					{
						cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from [PHONGMAY].[dbo].[Lớp] where [Mã lớp]=N'" + txtTuKhoa.Text + "'");
					}
					if (i == 3)
					{
						cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from [PHONGMAY].[dbo].[Giáo viên] where [Mã GV]=N'" + txtTuKhoa.Text + "'");
					}
				}
			}
			catch
			{
				MessageBox.Show("Tìm kiếm sai");
			}
		}

		private void rdbPhongMay_CheckedChanged(object sender, EventArgs e)
		{
			i = 1;
		}

		private void rdbLop_CheckedChanged(object sender, EventArgs e)
		{
			i = 2;
		}

		private void rdbGiaoVien_CheckedChanged(object sender, EventArgs e)
		{
			i = 3;
		}

		private void FrmTimKiemLichTH_Load(object sender, EventArgs e)
		{
			rdbPhongMay.Checked = true;
			cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from [PHONGMAY].[dbo].[Phòng Máy]");
		}
	}
}
