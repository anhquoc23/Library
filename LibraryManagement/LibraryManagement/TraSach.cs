using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DTO;
using QLTV.BUS;

namespace LibraryManagement
{
    public partial class TraSach : Form
    {
        private PhieuMuonBUS phieumuonbus = new PhieuMuonBUS();
        public TraSach()
        {
            InitializeComponent();
        }

        private void TraSach_Load(object sender, EventArgs e)
        {
            dgPhieuMuon.AllowUserToAddRows = false;
            dgPhieuMuon.DataSource = new PhieuMuonBUS().LoadPhieuMuon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgPhieuMuon.DataSource = new PhieuMuonBUS().LoadPhieuMuonByIDDG(txtTimKiem.Text);
        }

        private void dgPhieuMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgPhieuMuon.SelectedRows[0];
            lblMaPM.Text = row.Cells["MaPM"].Value.ToString();
            lblNgayLapPhieu.Text = row.Cells["NgayLapPhieu"].Value.ToString();
            lblMaDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
            DocGia dg = new PhieuMuonBUS().LoadDocGiaByIDPM(lblMaDocGia.Text);
            lblTenDocGia.Text = dg.TenDocGia;
            lblNgaySinh.Text = dg.NgaySinh.ToString();
            lblSoDT.Text = dg.SDT;
            int mapm = int.Parse(row.Cells["MaPM"].Value.ToString());
            DateTime ngaylapphieu = new PhieuMuonBUS().NgayLapPhieu(mapm);
            DateTime today = DateTime.Now.Date;
            TimeSpan timespan = today.Subtract(ngaylapphieu.Date);
            int songaymuon = (int)Math.Round(timespan.TotalDays);
            lblSoLuongMuon.Text = new PhieuMuonBUS().SoLuongSachTrongPM(mapm).ToString();
            decimal tienthanhtoan = new PhieuMuonBUS().TongTienDatCoc(mapm) * 1 / 100 * (songaymuon + 1);
            lblTienThanhToan.Text = tienthanhtoan.ToString("#,#.00").Replace(".", ",");
        }

        private void btnTraPM_Click(object sender, EventArgs e)
        {
            if (lblMaPM.Text.Equals(""))
                MessageBox.Show("Hãy chọn phiếu mượn cần trả");
            else
            {
                phieumuonbus.LapHoaDon(DateTime.Now, int.Parse(lblMaPM.Text), decimal.Parse(lblTienThanhToan.Text));
                MessageBox.Show("Trả phiếu mượn thành công");
                dgPhieuMuon.DataSource = new PhieuMuonBUS().LoadPhieuMuon();
                ClearInfor();
                dgPhieuMuon.ClearSelection();
            }
        }

        public void ClearInfor()
        {
            lblMaDocGia.Text = "";
            lblTenDocGia.Text = "";
            lblSoDT.Text = "";
            lblNgaySinh.Text = "";
            lblMaPM.Text = "";
            lblNgayLapPhieu.Text = "";
            lblSoLuongMuon.Text = "";
            lblTienThanhToan.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInfor();
            dgPhieuMuon.ClearSelection();
        }
    }
}
