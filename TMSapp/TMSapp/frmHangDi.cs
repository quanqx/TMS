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
    public partial class frmHangDi : Form
    {

        private ImageList imgLst = new ImageList();

        public frmHangDi()
        {
            InitializeComponent();
            imgLst.Images.Add(Image.FromFile(@"E:\Dotnet\TMS\Resources\file.png"));
        }

        private void frmHangDi_Load(object sender, EventArgs e)
        {
            funcHangDi.Connect();
            createTreeViewThoiGian();
            createTreeViewGaDen();
            createTreeViewKhachHang();
            setThongTinGRV();
        }

        private void setThongTinGRV()
        {
            dataGridViewHangdi.RowHeadersVisible = false;
            dataGridViewHangdi.Width = tabPageDSBB.Width - 5;
            dataGridViewHangdi.Height = tabPageDSBB.Height - btnInBienBan.Height - 15;
            dataGridViewHangdi.DataSource = funcHangDi.getDataToTable("SELECT TOP 0 ROW_NUMBER() OVER (ORDER BY B.BillMainNo DESC) ,B.BillMainNo, B.BillOrdNo, A.TrainCode, CONVERT(NVARCHAR(10),A.ArriveDate,101), CONVERT(NVARCHAR(10), A.EnterDate, 101), c.OrigQty, C.CostVol, C.InvtName, C.Debt, C.ThuhoAmt, C.ThuhoKHAmt, C.Debt - C.ThuhoAmt - C.ThuhoKHAmt, C.Payment, C.SlsPerID, D.SlsPerName, C.S_CustID, E.CustName, E.Address, E.Phone, E.CMT, C.R_CustName, c.R_CustAdd, c.R_CustPhone, F.StationName, C.OrigActVol, C.UnitPrice, C.Amount, C.InvoiceNbr, C.VAT, C.Discount, C.OrderDescr, C.InterDescr, C.DocAttached FROM LadingBill A JOIN LadingBillDet B ON A.BillNo = B.BillMainNo JOIN Orders C ON B.BillOrdNo = C.OrderNo JOIN SalesPerson D ON C.SlsPerID = D.SlsPerID JOIN Customer E ON C.S_CustID = e.CustID JOIN Stations F ON C.StationID = F.StationID");
            setHeaderText();
        }

        private void setHeaderText()
        {
            dataGridViewHangdi.Columns[0].Visible = true;
            dataGridViewHangdi.Columns[1].Width = 20;
            dataGridViewHangdi.Columns[1].HeaderText = "#";
            dataGridViewHangdi.Columns[2].HeaderText = "Số vận đơn";
            dataGridViewHangdi.Columns[3].HeaderText = "Số biên bản";
            dataGridViewHangdi.Columns[4].HeaderText = "Mác tàu";
            dataGridViewHangdi.Columns[5].HeaderText = "Ngày vận đơn";
            dataGridViewHangdi.Columns[6].HeaderText = "Ngày biên bản";
            dataGridViewHangdi.Columns[7].HeaderText = "Số kiện";
            dataGridViewHangdi.Columns[8].HeaderText = "TLTC";
            dataGridViewHangdi.Columns[8].HeaderText = "Tên hàng";
            dataGridViewHangdi.Columns[9].HeaderText = "Phải thu";
            dataGridViewHangdi.Columns[10].HeaderText = "Thu hộ NB";
            dataGridViewHangdi.Columns[11].HeaderText = "Thu hộ KH";
            dataGridViewHangdi.Columns[12].HeaderText = "Còn lại";
            dataGridViewHangdi.Columns[13].HeaderText = "T/Toán trước";
            dataGridViewHangdi.Columns[14].HeaderText = "Mã NV";
            dataGridViewHangdi.Columns[15].HeaderText = "Tên NV";
            dataGridViewHangdi.Columns[16].HeaderText = "Mã KH";
            dataGridViewHangdi.Columns[17].HeaderText = "Người gửi";
            dataGridViewHangdi.Columns[18].HeaderText = "Địa chỉ";
            dataGridViewHangdi.Columns[19].HeaderText = "Điện thoại";
            dataGridViewHangdi.Columns[21].HeaderText = "CMT";
            dataGridViewHangdi.Columns[22].HeaderText = "Người nhận";
            dataGridViewHangdi.Columns[23].HeaderText = "Địa chỉ";
            dataGridViewHangdi.Columns[24].HeaderText = "Điện thoại";
            dataGridViewHangdi.Columns[25].HeaderText = "Ga đến";
            dataGridViewHangdi.Columns[26].HeaderText = "TLTT";
            dataGridViewHangdi.Columns[27].HeaderText = "Đơn giá";
            dataGridViewHangdi.Columns[28].HeaderText = "Thành tiền";
            dataGridViewHangdi.Columns[29].HeaderText = "Số hóa đơn";
            dataGridViewHangdi.Columns[30].HeaderText = "VAT";
            dataGridViewHangdi.Columns[31].HeaderText = "Chiết khấu";
            dataGridViewHangdi.Columns[32].HeaderText = "Ghi chú KH";
            dataGridViewHangdi.Columns[33].HeaderText = "Ghi chú NB";
            dataGridViewHangdi.Columns[34].HeaderText = "CT kèm theo";
        }

        private void createTreeViewThoiGian()
        {
            TreeNode root = new TreeNode("Thời gian");
            treeViewThoiGian.ImageList = imgLst;
            root.Expand();
            treeViewThoiGian.ImageIndex = 0;
            treeViewThoiGian.Nodes.Add(root);
            int year = DateTime.Now.Year;
            while(year >= 2015)
            {
                int month = 12;
                while(month >=1)
                {
                    treeViewThoiGian.Nodes[0].Nodes.Add("Tháng " + month + "/" + year);
                    month--;
                }
                year--;
            }
        }

        private void createTreeViewGaDen()
        {
            TreeNode root = new TreeNode("Ga đến");
            root.Expand();
            treeViewGaDen.ImageList = imgLst;
            treeViewGaDen.ImageIndex = 0;
            treeViewGaDen.Nodes.Add(root);
            DataTable dataTable = funcHangDi.getDataToTable("SELECT StationName FROM Stations");
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                treeViewGaDen.Nodes[0].Nodes.Add(dataTable.Rows[i][0].ToString());
            }
        }

        private void createTreeViewKhachHang()
        {
            TreeNode root = new TreeNode("Khách hàng");
            root.Expand();
            treeViewKhachHang.Nodes.Add(root);
            treeViewKhachHang.ImageList = imgLst;
            treeViewKhachHang.ImageIndex = 0;
            DataTable dataTable = funcHangDi.getDataToTable("SELECT CustName FROM Customer");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                treeViewKhachHang.Nodes[0].Nodes.Add(dataTable.Rows[i][0].ToString());
            }
        }

        private void treeViewGaDen_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable dataTable = funcHangDi.getDataToTable("SELECT ROW_NUMBER() OVER (ORDER BY B.BillMainNo DESC) ,B.BillMainNo, B.BillOrdNo, A.TrainCode, CONVERT(NVARCHAR(10),A.ArriveDate,101), CONVERT(NVARCHAR(10), A.EnterDate, 101), c.OrigQty, C.CostVol, C.InvtName, C.Debt, C.ThuhoAmt, C.ThuhoKHAmt, C.Debt - C.ThuhoAmt - C.ThuhoKHAmt, C.Payment, C.SlsPerID, D.SlsPerName, C.S_CustID, E.CustName, E.Address, E.Phone, E.CMT, C.R_CustName, c.R_CustAdd, c.R_CustPhone, F.StationName, C.OrigActVol, C.UnitPrice, C.Amount, C.InvoiceNbr, C.VAT, C.Discount, C.OrderDescr, C.InterDescr, C.DocAttached FROM LadingBill A JOIN LadingBillDet B ON A.BillNo = B.BillMainNo JOIN Orders C ON B.BillOrdNo = C.OrderNo JOIN SalesPerson D ON C.SlsPerID = D.SlsPerID JOIN Customer E ON C.S_CustID = e.CustID JOIN Stations F ON C.StationID = F.StationID WHERE F.StationName = N'" + treeViewGaDen.SelectedNode.Text + "'");
            dataGridViewHangdi.DataSource = dataTable;
        }

        private void dataGridViewHangdi_DoubleClick(object sender, EventArgs e)
        {
            frmBienBanHangDi bbhd = new frmBienBanHangDi();
            bbhd.ShowDialog();
        }

        private void treeViewKhachHang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridViewHangdi.DataSource = funcHangDi.getDataToTable("SELECT ROW_NUMBER() OVER (ORDER BY B.BillMainNo DESC) ,B.BillMainNo, B.BillOrdNo, A.TrainCode, CONVERT(NVARCHAR(10),A.ArriveDate,101), CONVERT(NVARCHAR(10), A.EnterDate, 101), c.OrigQty, C.CostVol, C.InvtName, C.Debt, C.ThuhoAmt, C.ThuhoKHAmt, C.Debt - C.ThuhoAmt - C.ThuhoKHAmt, C.Payment, C.SlsPerID, D.SlsPerName, C.S_CustID, E.CustName, E.Address, E.Phone, E.CMT, C.R_CustName, c.R_CustAdd, c.R_CustPhone, F.StationName, C.OrigActVol, C.UnitPrice, C.Amount, C.InvoiceNbr, C.VAT, C.Discount, C.OrderDescr, C.InterDescr, C.DocAttached FROM LadingBill A JOIN LadingBillDet B ON A.BillNo = B.BillMainNo JOIN Orders C ON B.BillOrdNo = C.OrderNo JOIN SalesPerson D ON C.SlsPerID = D.SlsPerID JOIN Customer E ON C.S_CustID = e.CustID JOIN Stations F ON C.StationID = F.StationID WHERE E.CustName = N'" + treeViewKhachHang.SelectedNode.Text + "'");
        }

        private void treeViewThoiGian_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String []str = treeViewThoiGian.SelectedNode.Text.Split(' ');
            String[] MY = str[1].Split('/');
            dataGridViewHangdi.DataSource = funcHangDi.getDataToTable("SELECT ROW_NUMBER() OVER (ORDER BY B.BillMainNo DESC) ,B.BillMainNo, B.BillOrdNo, A.TrainCode, CONVERT(NVARCHAR(10),A.ArriveDate,101), CONVERT(NVARCHAR(10), A.EnterDate, 101), c.OrigQty, C.CostVol, C.InvtName, C.Debt, C.ThuhoAmt, C.ThuhoKHAmt, C.Debt - C.ThuhoAmt - C.ThuhoKHAmt, C.Payment, C.SlsPerID, D.SlsPerName, C.S_CustID, E.CustName, E.Address, E.Phone, E.CMT, C.R_CustName, c.R_CustAdd, c.R_CustPhone, F.StationName, C.OrigActVol, C.UnitPrice, C.Amount, C.InvoiceNbr, C.VAT, C.Discount, C.OrderDescr, C.InterDescr, C.DocAttached FROM LadingBill A JOIN LadingBillDet B ON A.BillNo = B.BillMainNo JOIN Orders C ON B.BillOrdNo = C.OrderNo JOIN SalesPerson D ON C.SlsPerID = D.SlsPerID JOIN Customer E ON C.S_CustID = e.CustID JOIN Stations F ON C.StationID = F.StationID WHERE MONTH(A.EnterDate) = " + MY[0] + " and YEAR(A.EnterDate) = " + MY[1]);
        }
    }
}
