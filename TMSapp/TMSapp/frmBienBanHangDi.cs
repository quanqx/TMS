using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSapp
{
    public partial class frmBienBanHangDi : Form
    {
        public frmBienBanHangDi()
        {
            InitializeComponent();
        }

        private void btnChonSo_Click(object sender, EventArgs e)
        {
            frmBienBanVanChuyen frm = new frmBienBanVanChuyen();
            frm.ShowDialog();
        }

        private void btnDanhMucKH_Click(object sender, EventArgs e)
        {
            frmDanhMucKH frm = new frmDanhMucKH();
            frm.ShowDialog();
        }
    }
}
