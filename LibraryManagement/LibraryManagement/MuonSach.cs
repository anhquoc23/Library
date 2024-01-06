using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.BUS;
using QLTV.DTO;

namespace LibraryManagement
{
    public partial class MuonSach : Form
    {
        private PhieuMuonBUS phieumuonbus = new PhieuMuonBUS();
        public MuonSach()
        {
            InitializeComponent();
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            dgSachMuon.AllowUserToAddRows = false;
            dgDocGia.AllowUserToAddRows = false;
            dgSach.AllowUserToDeleteRows = false;
            dgSach.DataSource = new SachBUS().ListSachMuon();
            dgDocGia.DataSource = new DocGiaBUS().DocGiaList();
            rdMaDocGia.Checked = true;
            rdTenSach.Checked = true;
        }

        private void btnTimKiemDG_Click(object sender, EventArgs e)
        {
            if (txtTimKiemDG.Text.Equals(""))
                dgDocGia.DataSource = new DocGiaBUS().DocGiaList();
            else
            {
                if (rdMaDocGia.Checked)
                    dgDocGia.DataSource = new DocGiaBUS().LoadDocGiaByID(txtTimKiemDG.Text);
                else
                    dgDocGia.DataSource = new DocGiaBUS().LoadDocGiaByName(txtTimKiemDG.Text);
            }
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            if (txtTimKiemSach.Text.Equals(""))
                dgSach.DataSource = new SachBUS().ListSachMuon();
            else
            {
                if (rdMaSach.Checked)
                    dgSach.DataSource = new SachBUS().LoadSachMuonByID(txtTimKiemSach.Text);
                else
                    dgSach.DataSource = new SachBUS().LoadSachMuonByName(txtTimKiemSach.Text);
            }

        }
        private void ShowInfoDocGia(DataGridView data)
        {
            DataGridViewRow row = dgDocGia.SelectedRows[0];
            lblMaDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
            lblTenDocGia.Text = row.Cells["TenDocGia"].Value.ToString();
            lblSoDT.Text = row.Cells["SDT"].Value.ToString();
            lblNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
        }

        private void dgDocGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowInfoDocGia(dgDocGia);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool duplicate = false;
            if (dgSach.SelectedRows.Count == 0)
                MessageBox.Show("Hãy chọn sách cần mượn");
            else
            {
                DataGridViewRow row = dgSach.SelectedRows[0];
                foreach (DataGridViewRow r in dgSachMuon.Rows)
                {
                    if (r.Cells["MaSach"].Value == row.Cells["MaSach"].Value)
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (duplicate == true)
                    MessageBox.Show("Quyển sách này đã được chọn");
                else
                {
                    DataGridViewRow newrow = (DataGridViewRow)row.Clone();
                    foreach (DataGridViewCell cell in row.Cells)
                        newrow.Cells[cell.ColumnIndex].Value = cell.Value;
                    dgSachMuon.Rows.Add(newrow);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgSachMuon.RowCount == 0)
                MessageBox.Show("Chưa có sách trong danh sách mượn");
            //else if (dgSachMuon.SelectedRows.Count <= 0)
            //    MessageBox.Show("Hãy chọn sách cần xóa khỏi danh sách mượn");
            else
            {
                DataGridViewRow row = dgSachMuon.SelectedRows[0];
                dgSachMuon.Rows.Remove(row);
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (lblMaDocGia.Text.Equals(""))
                MessageBox.Show("Hãy chọn độc giả cần mượn sách");
            else if (dgSachMuon.RowCount == 0)
                MessageBox.Show("Chưa có sách trong danh sách mượn");
            else
            {
                phieumuonbus.LapPhieuMuon(DateTime.Now, lblMaDocGia.Text);
                int lastid = phieumuonbus.LayIDPhieuMuonLonNhat();
                foreach (DataGridViewRow r in dgSachMuon.Rows)
                {
                    phieumuonbus.LapCTPM(r.Cells["MaSach"].Value.ToString(), 1, lastid, decimal.Parse(r.Cells["GiaNhap"].Value.ToString()));
                    phieumuonbus.SetSoLuongSachTrongCTPM(r.Cells["MaSach"].Value.ToString(), int.Parse(r.Cells["SoLuong"].Value.ToString()));

                }
                MessageBox.Show("Lập phiếu mượn thành công");
                dgDocGia.ClearSelection();
                ClearInforDocGia();
                dgSachMuon.Rows.Clear();
                dgSach.DataSource = new SachBUS().ListSachMuon();
            }
        }
        public void ClearInforDocGia()
        {
            lblMaDocGia.Text = "";
            lblNgaySinh.Text = "";
            lblSoDT.Text = "";
            lblTenDocGia.Text = "";
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            ClearInforDocGia();
            dgDocGia.ClearSelection();
            dgSachMuon.Rows.Clear();
        }
    }
}

