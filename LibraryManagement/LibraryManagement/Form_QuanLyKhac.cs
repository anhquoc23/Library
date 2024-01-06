using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.BUS;
using QLTV.DTO;

namespace LibraryManagement
{
    public partial class Form_QuanLyKhac : Form
    {
        TacGiaBUS tacgia;
        NhaCCBUS nhacc;
        Utils u;
        public Form_QuanLyKhac()
        {
            InitializeComponent();
            tacgia = new TacGiaBUS();
            nhacc = new NhaCCBUS();
            u = new Utils();
        }



        private void btnSave_TG_Click(object sender, EventArgs e)
        {
            if (rdbtnAdd_TG.Checked)
            {
                AddTacGia();
            }
            else if (rdbtnEdit_TG.Checked)
            {
                EditTacGia();
            }
            else if (rdbtnDelete_TG.Checked)
            { 
                DeleteTacGia(); 
            }


            dataTacGia.DataSource = tacgia.TacGiaList();
        }

        private void txtSDT_TacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_NCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_QuanLyKhac_Load(object sender, EventArgs e)
        {
            u.SetPropertiesDataGridView(dataTacGia);
            u.SetPropertiesDataGridView(dataNhaCungCap);
            dataTacGia.DataSource = tacgia.TacGiaList();
            dataNhaCungCap.DataSource = new NhaCCBUS().NhaCCList();
            ShowDataTacGiaToTextBox();
        }

        private void btnSearch_TG_Click(object sender, EventArgs e)
        {
            if (txtSearch_TG.Text == "")
            {
                dataTacGia.DataSource = tacgia.TacGiaList();
                return;
            }
            if (rdTenTacGia.Checked)
                dataTacGia.DataSource = tacgia.LoadTacGiaByName(txtSearch_TG.Text);
            else
                dataTacGia.DataSource = tacgia.LoadTacGiaByID(txtSearch_TG.Text);
        }

        private void dataTacGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowDataTacGiaToTextBox();
        }

        private void ShowDataTacGiaToTextBox()
        {
            DataGridViewRow row = dataTacGia.SelectedRows[0];

            txtMaTacGia.Text = row.Cells["MaTacGia"].Value.ToString();
            txtTenTacGia.Text = row.Cells["TenTacGia"].Value.ToString();
            txtSDT_TacGia.Text = row.Cells["SDT"].Value.ToString();
            txtEmail_TacGia.Text = row.Cells["Email"].Value.ToString();
        }

        private void rdbtnAdd_TG_Click(object sender, EventArgs e)
        {
            txtTenTacGia.Text = "";
            txtSDT_TacGia.Text = "";
            txtEmail_TacGia.Text = "";
            using (var db = new QLTVEntities())
            {
                txtMaTacGia.Text = u.CreateID_4("TG", db.TacGias.ToList().Last().MaTacGia);
            }
        }

        private void AddTacGia()
        {
            if (tacgia.AddTacGia(txtMaTacGia.Text, txtTenTacGia.Text, 
                txtSDT_TacGia.Text, txtEmail_TacGia.Text))
                u.Message("Thêm Tác giả", 
                    "Add Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
             else
                 u.Message("Thêm Tác giả", 
                     "Bạn chưa nhập đủ thông tin hoặc chưa chọn nút Thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditTacGia()
        {
            if (tacgia.EditTacGia(txtMaTacGia.Text, txtTenTacGia.Text,
                txtSDT_TacGia.Text, txtEmail_TacGia.Text))
                u.Message("Sửa thông tin tác giả", "Edit Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                u.Message("Sửa thông tin tác giả",
                    "Không thể sửa thông tin khi chưa chọn thông tin nhà cung cấp",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeleteTacGia()
        {
            if (tacgia.DeleteTacGia(txtMaTacGia.Text))
                u.Message("Xoá Tác giả", 
                    "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                u.Message("Xoá Tác giả", 
                    "Do còn Sách của tác giả " + txtTenTacGia.Text + " nên không thể xoá.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_NCC_Click(object sender, EventArgs e)
        {
            if (txtSearch_NCC.Text == "")
            {
                dataNhaCungCap.DataSource = nhacc.NhaCCList();
                return;
            }
            if (rdTenNCC.Checked)
                dataNhaCungCap.DataSource = nhacc.LoadNCCByName(txtSearch_NCC.Text);
            else
                dataNhaCungCap.DataSource = nhacc.LoadNCCByID(txtSearch_NCC.Text);
        }

        private void rdbtnAdd_NCC_Click(object sender, EventArgs e)
        {
            txtTenNCC.Text = "";
            txtSDT_NCC.Text = "";
            txtEmail_NCC.Text = "";
            using (var db = new QLTVEntities())
            {
                txtMaNCC.Text = u.CreateID_3("NCC", db.NhaCungCaps.ToList().Last().MaNCC);
            }
        }

        private void btnSave_NCC_Click(object sender, EventArgs e)
        {
            if (rdbtnAdd_NCC.Checked) 
            {
                AddNCC();
            }
            else if (rdbtnEdit_NCC.Checked)
            {
                EditNCC();
            }
            else if (rdbtnDelete_NCC.Checked)
            {
                DeleteNCC();
            }
            else
            {
                u.Message("WARNING", "Bạn chưa chọn hành động nào để lưu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataNhaCungCap.DataSource = nhacc.NhaCCList();
        }

        private void AddNCC()
        {
            if (nhacc.AddNCC(txtMaNCC.Text, txtTenNCC.Text, txtSDT_NCC.Text, txtEmail_NCC.Text))
                u.Message("Thêm Nhà Cung Cấp", 
                    "Add Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                u.Message("Thêm Nhà Cung Cấp", 
                    "Bạn chưa nhập đủ thông tin hoặc chưa chọn nút Thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditNCC()
        {
            if (nhacc.EditNCC(txtMaNCC.Text, txtTenNCC.Text, txtSDT_NCC.Text, txtEmail_NCC.Text))
                u.Message("Sửa thông tin Nhà Cung Cấp", 
                    "Edit Successful", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                u.Message("Sửa thông tin Nhà Cung Cấp", 
                    "Không thể sửa thông tin khi chưa chọn nhà cung cấp", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
        }

        private void DeleteNCC()
        {

            if (nhacc.DeleteNCC(txtMaNCC.Text))
                u.Message("Xoá Nhà Cung Cấp", "Delete Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                u.Message("Xoá Nhà Cung Cấp", "Do còn Sách của nhà cung cấp " + txtTenNCC.Text + " nên không thể xoá.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowDataNCCShowToTextBox()
        {
            DataGridViewRow row = dataNhaCungCap.SelectedRows[0];

            txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
            txtSDT_NCC.Text = row.Cells["SDT"].Value.ToString();
            txtEmail_NCC.Text = row.Cells["Email"].Value.ToString();
        }

        private void dataNhaCungCap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowDataNCCShowToTextBox();
        }

        private void tabNCC_Click(object sender, EventArgs e)
        {
            ShowDataNCCShowToTextBox();
        }

        private void tabNCC_ChangeUICues(object sender, UICuesEventArgs e)
        {
            ShowDataNCCShowToTextBox();
        }

        private void tabFormQLKhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataNCCShowToTextBox();
        }
    }
}
