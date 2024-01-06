using QLTV.BUS;
using QLTV.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form_DocGia : Form
    {
        DocGiaBUS docgia;
        Utils u;
        public Form_DocGia()
        {
            InitializeComponent();
            docgia = new DocGiaBUS();
            u = new Utils();
            u.SetPropertiesDataGridView(dataDocGia);
        }

        private void ShowDataToTextBox(DataGridView data)
        {
            DataGridViewRow row = dataDocGia.SelectedRows[0];

            // Gán cái vừa chọn cho các textbox

            txtMaDocGia.Text = row.Cells["MaDocGia"].Value.ToString();
            txtTenDocGia.Text = row.Cells["TenDocGia"].Value.ToString();
            txtSDT.Text = row.Cells["SDT"].Value.ToString();
            dateBirthDay.Text = row.Cells["NgaySinh"].Value.ToString();
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form_DocGia_Load(object sender, EventArgs e)
        {
            dataDocGia.DataSource = docgia.DocGiaList();
            ShowDataToTextBox(dataDocGia);
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                dataDocGia.DataSource = docgia.DocGiaList();

            else
                if (rdTenDocGia.Checked)
                dataDocGia.DataSource = docgia.LoadDocGiaByName(txtSearch.Text);
            else
                dataDocGia.DataSource = docgia.LoadDocGiaByID(txtSearch.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdbtnAdd.Checked)
            {
                AddReader();
            }
            else if (rdbtnEdit.Checked)
            {
                EditReader();
            }
            else if (rdbtnDelete.Checked)
            {
                DeleteReader();
            }
            else
            {
                u.Message("WARNING", "Bạn chưa chọn hành động nào để lưu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataDocGia.DataSource = docgia.DocGiaList();
        }

        private void dataDocGia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowDataToTextBox(dataDocGia);
        }

        private void AddReader()
        {
            if (docgia.AddDocGia(txtMaDocGia.Text, txtTenDocGia.Text,
                    txtSDT.Text, dateBirthDay.Value.Date))
                u.Message("Thêm Thông tin độc giả", "Add Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                u.Message("Thêm Thông tin độc giả", "Bạn chưa nhập đủ thông tin hoặc chưa chọn nút Thêm", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void EditReader()
        {
            if (docgia.EditDocGia(txtMaDocGia.Text, txtTenDocGia.Text,
                    txtSDT.Text, dateBirthDay.Value.Date))
                u.Message("Sửa thông tin độc giả", "Edit Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                u.Message("Sửa thông tin độc giả", "Không thể sửa khi chưa chọn độc giả", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void DeleteReader()
        {
            if (docgia.DeleteDocGia(txtMaDocGia.Text))
                u.Message("Xoá thông tin độc giả", "Delete Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                u.Message("Xoá thông tin độc giả",
                    "Không thể xoá độc giả khi chưa chọn độc giả hoặc độc giả đó chưa trả hết sách",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rdbtnAdd_Click(object sender, EventArgs e)
        {
            txtTenDocGia.Text = "";
            txtSDT.Text = "";
            dateBirthDay.Value = DateTime.Now;
            using (var db = new QLTVEntities())
            {
                txtMaDocGia.Text = u.CreateID_4("DG", db.DocGias.ToList().Last().MaDocGia);
            }
        }
    }
}
