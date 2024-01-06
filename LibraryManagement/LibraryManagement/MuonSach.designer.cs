namespace LibraryManagement
{
    partial class MuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgSachMuon = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdTenSach = new System.Windows.Forms.RadioButton();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.rdMaSach = new System.Windows.Forms.RadioButton();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemDG = new System.Windows.Forms.Button();
            this.rdMaDocGia = new System.Windows.Forms.RadioButton();
            this.rdTenDocGia = new System.Windows.Forms.RadioButton();
            this.txtTimKiemDG = new System.Windows.Forms.TextBox();
            this.dgDocGia = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSachMuon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocGia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgSachMuon);
            this.groupBox1.Location = new System.Drawing.Point(12, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách mượn:";
            // 
            // dgSachMuon
            // 
            this.dgSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.GiaNhap,
            this.TenTacGia,
            this.SoLuong});
            this.dgSachMuon.Location = new System.Drawing.Point(-5, 21);
            this.dgSachMuon.Name = "dgSachMuon";
            this.dgSachMuon.RowHeadersWidth = 51;
            this.dgSachMuon.RowTemplate.Height = 24;
            this.dgSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSachMuon.Size = new System.Drawing.Size(763, 458);
            this.dgSachMuon.TabIndex = 1;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "MaSach";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 125;
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "TenSach";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "TheLoai";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Width = 125;
            // 
            // GiaNhap
            // 
            this.GiaNhap.HeaderText = "GiaNhap";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 125;
            // 
            // TenTacGia
            // 
            this.TenTacGia.HeaderText = "TenTacGia";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdTenSach);
            this.groupBox3.Controls.Add(this.btnTimKiemSach);
            this.groupBox3.Controls.Add(this.rdMaSach);
            this.groupBox3.Controls.Add(this.txtTimKiemSach);
            this.groupBox3.Controls.Add(this.dgSach);
            this.groupBox3.Location = new System.Drawing.Point(804, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(942, 502);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sách trong kho:";
            // 
            // rdTenSach
            // 
            this.rdTenSach.AutoSize = true;
            this.rdTenSach.Location = new System.Drawing.Point(138, 38);
            this.rdTenSach.Name = "rdTenSach";
            this.rdTenSach.Size = new System.Drawing.Size(84, 20);
            this.rdTenSach.TabIndex = 6;
            this.rdTenSach.TabStop = true;
            this.rdTenSach.Text = "Tên sách";
            this.rdTenSach.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSach.Location = new System.Drawing.Point(626, 38);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(103, 27);
            this.btnTimKiemSach.TabIndex = 5;
            this.btnTimKiemSach.Text = "Tìm kiếm";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            this.btnTimKiemSach.Click += new System.EventHandler(this.btnTimKiemSach_Click);
            // 
            // rdMaSach
            // 
            this.rdMaSach.AutoSize = true;
            this.rdMaSach.Location = new System.Drawing.Point(6, 38);
            this.rdMaSach.Name = "rdMaSach";
            this.rdMaSach.Size = new System.Drawing.Size(79, 20);
            this.rdMaSach.TabIndex = 3;
            this.rdMaSach.TabStop = true;
            this.rdMaSach.Text = "Mã sách";
            this.rdMaSach.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSach.Location = new System.Drawing.Point(267, 38);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(301, 27);
            this.txtTimKiemSach.TabIndex = 2;
            // 
            // dgSach
            // 
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.Location = new System.Drawing.Point(6, 71);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 51;
            this.dgSach.RowTemplate.Height = 24;
            this.dgSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSach.Size = new System.Drawing.Size(930, 408);
            this.dgSach.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnTimKiemDG);
            this.groupBox2.Controls.Add(this.rdMaDocGia);
            this.groupBox2.Controls.Add(this.rdTenDocGia);
            this.groupBox2.Controls.Add(this.txtTimKiemDG);
            this.groupBox2.Controls.Add(this.dgDocGia);
            this.groupBox2.Location = new System.Drawing.Point(804, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 311);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách độc giả:";
            // 
            // btnTimKiemDG
            // 
            this.btnTimKiemDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDG.Location = new System.Drawing.Point(327, 74);
            this.btnTimKiemDG.Name = "btnTimKiemDG";
            this.btnTimKiemDG.Size = new System.Drawing.Size(103, 27);
            this.btnTimKiemDG.TabIndex = 4;
            this.btnTimKiemDG.Text = "Tìm kiếm";
            this.btnTimKiemDG.UseVisualStyleBackColor = true;
            this.btnTimKiemDG.Click += new System.EventHandler(this.btnTimKiemDG_Click);
            // 
            // rdMaDocGia
            // 
            this.rdMaDocGia.AutoSize = true;
            this.rdMaDocGia.Location = new System.Drawing.Point(134, 35);
            this.rdMaDocGia.Name = "rdMaDocGia";
            this.rdMaDocGia.Size = new System.Drawing.Size(95, 20);
            this.rdMaDocGia.TabIndex = 3;
            this.rdMaDocGia.TabStop = true;
            this.rdMaDocGia.Text = "Mã độc giả";
            this.rdMaDocGia.UseVisualStyleBackColor = true;
            // 
            // rdTenDocGia
            // 
            this.rdTenDocGia.AutoSize = true;
            this.rdTenDocGia.Location = new System.Drawing.Point(7, 35);
            this.rdTenDocGia.Name = "rdTenDocGia";
            this.rdTenDocGia.Size = new System.Drawing.Size(100, 20);
            this.rdTenDocGia.TabIndex = 2;
            this.rdTenDocGia.TabStop = true;
            this.rdTenDocGia.Text = "Tên độc giả";
            this.rdTenDocGia.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemDG
            // 
            this.txtTimKiemDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemDG.Location = new System.Drawing.Point(6, 74);
            this.txtTimKiemDG.Name = "txtTimKiemDG";
            this.txtTimKiemDG.Size = new System.Drawing.Size(301, 27);
            this.txtTimKiemDG.TabIndex = 1;
            // 
            // dgDocGia
            // 
            this.dgDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocGia.Location = new System.Drawing.Point(6, 107);
            this.dgDocGia.Name = "dgDocGia";
            this.dgDocGia.RowHeadersWidth = 51;
            this.dgDocGia.RowTemplate.Height = 24;
            this.dgDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDocGia.Size = new System.Drawing.Size(930, 198);
            this.dgDocGia.TabIndex = 0;
            this.dgDocGia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDocGia_CellMouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHuy);
            this.groupBox4.Controls.Add(this.btnLapPhieu);
            this.groupBox4.Controls.Add(this.lblNgaySinh);
            this.groupBox4.Controls.Add(this.lblSoDT);
            this.groupBox4.Controls.Add(this.lblTenDocGia);
            this.groupBox4.Controls.Add(this.lblMaDocGia);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(764, 297);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin độc giả:";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(534, 259);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 31);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(407, 259);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(89, 32);
            this.btnLapPhieu.TabIndex = 8;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(156, 193);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(0, 18);
            this.lblNgaySinh.TabIndex = 7;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.Location = new System.Drawing.Point(137, 142);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(0, 18);
            this.lblSoDT.TabIndex = 6;
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDocGia.Location = new System.Drawing.Point(176, 93);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(0, 18);
            this.lblTenDocGia.TabIndex = 5;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDocGia.Location = new System.Drawing.Point(176, 48);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(0, 18);
            this.lblMaDocGia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số DT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Location = new System.Drawing.Point(330, 930);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Location = new System.Drawing.Point(1238, 930);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 32);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 1055);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuonSach";
            this.Text = "MuonSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSachMuon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocGia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgDocGia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiemDG;
        private System.Windows.Forms.RadioButton rdMaDocGia;
        private System.Windows.Forms.RadioButton rdTenDocGia;
        private System.Windows.Forms.TextBox txtTimKiemDG;
        private System.Windows.Forms.DataGridView dgSachMuon;
        private System.Windows.Forms.RadioButton rdTenSach;
        private System.Windows.Forms.Button btnTimKiemSach;
        private System.Windows.Forms.RadioButton rdMaSach;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblTenDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}