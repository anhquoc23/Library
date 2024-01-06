
using QLTV.BUS;
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
using System.Data.Entity;
using LibraryManagement;

namespace BTL_LTCSDL_QLThưViện
{
    public partial class Form_QuanLySach : Form
    {
        SachBUS sach;
        Utils u;
        public Form_QuanLySach()
        {
            InitializeComponent();
            u = new Utils();
            sach = new SachBUS();
        }

        private void ShowDataToTextBox()
        {
            DataGridViewRow row = dataSach.SelectedRows[0];

            // Gán cái vừa chọn cho các textbox

            txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
            txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            txtGia.Text = row.Cells["GiaNhap"].Value.ToString();
            txtLoaiSach.Text = row.Cells["TheLoai"].Value.ToString();
            comNhaCungCap.Text = row.Cells["NhaCungCap"].Value.ToString();
            comTacGia.Text = row.Cells["TenTacGia"].Value.ToString();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_QuanLySach_Load(object sender, EventArgs e)
        {
            u.SetPropertiesDataGridView(dataSach);
            dataSach.DataSource = sach.SachList();
            ShowDataToTextBox();
            comTacGia.DataSource = new TacGiaBUS().TacGiaList();
            comTacGia.DisplayMember = "TenTacGia";
            comTacGia.ValueMember = "MaTacGia";

            comNhaCungCap.DataSource = new NhaCCBUS().NhaCCList();
            comNhaCungCap.DisplayMember = "TenNCC";
            comNhaCungCap.ValueMember = "MaNCC";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                dataSach.DataSource = sach.SachList();
            else
            {
                if (rdMaSach.Checked)
                    dataSach.DataSource = sach.LoadSachByID(txtSearch.Text);
                else if (rdTenSach.Checked)
                    dataSach.DataSource = sach.LoadSachBySach(txtSearch.Text);
                else
                    dataSach.DataSource = sach.LoadSachByTacGia(txtSearch.Text);
            }

        }

        private void dataSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            ShowDataToTextBox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rdbtnAdd.Checked) 
            {
                AddBook();
            }
            else if (rdbtnEdit.Checked) 
            {
                EditBook();
            }
            else if (rdbtnDelete.Checked)
            {
                DeleteBook();
            }
            else { u.Message("WARNING", "Bạn chưa chọn hành động nào để lưu", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void rdbtnAdd_Click(object sender, EventArgs e)
        {
            txtTenSach.Text = "";
            comTacGia.SelectedIndex = 0;
            comNhaCungCap.SelectedIndex = 0;
            txtLoaiSach.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            using (var db = new QLTVEntities())
            {
                txtMaSach.Text = new Utils().CreateID_4("SA", db.Saches.ToList().Last().MaSach);
            }
        }


        private void AddBook()
        {
            if (sach.AddSach(txtMaSach.Text, txtTenSach.Text, txtLoaiSach.Text, txtGia.Text,
                comTacGia.SelectedValue.ToString(), comNhaCungCap.SelectedValue.ToString(),
                txtSoLuong.Text))
                u.Message("Thêm Sách", "Add Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                u.Message("Thêm sách", "Bạn chưa nhập đủ thông tin hoặc chưa chọn nút Thêm\"", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            dataSach.DataSource = sach.SachList();
        }

        private void EditBook()
        {
            if (sach.EditSach(txtMaSach.Text, txtTenSach.Text, txtLoaiSach.Text,
                txtGia.Text, comTacGia.SelectedValue.ToString(),
                comNhaCungCap.SelectedValue.ToString(), txtSoLuong.Text))
                u.Message("Sửa thông tin Sách", "Edit Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                u.Message("Sửa thông tin Sách", "Không thể sửa thông tin khi chưa chọn Sách", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            dataSach.DataSource = sach.SachList();
        }
        private void DeleteBook()
        {
            if (sach.DeleteSach(txtMaSach.Text))
                u.Message("Xoá thông tin sách", "Delete Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                u.Message("Xoá thông tin sách",
                    "Không thể xoá sách khi chưa chọn sách hoặc sách đó còn đang mượn",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataSach.DataSource = sach.SachList();
        }
    }
}
