namespace WindowsFormsApp2.MH.ThemDNThanhVien
{
    partial class DuyetPhieuDangKyDN
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
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.gridview_DanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.btn_Duyet = new System.Windows.Forms.Button();
            this.cbx_TimKiemTheo = new System.Windows.Forms.ComboBox();
            this.lbl_Theo = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_DanhSachPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(120, 31);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(286, 28);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(32, 31);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(82, 22);
            this.lbl_TimKiem.TabIndex = 1;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            this.lbl_TimKiem.Click += new System.EventHandler(this.Search_Click);
            // 
            // gridview_DanhSachPhieu
            // 
            this.gridview_DanhSachPhieu.AllowUserToAddRows = false;
            this.gridview_DanhSachPhieu.AllowUserToDeleteRows = false;
            this.gridview_DanhSachPhieu.AllowUserToResizeColumns = false;
            this.gridview_DanhSachPhieu.AllowUserToResizeRows = false;
            this.gridview_DanhSachPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_DanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_DanhSachPhieu.Location = new System.Drawing.Point(27, 81);
            this.gridview_DanhSachPhieu.MultiSelect = false;
            this.gridview_DanhSachPhieu.Name = "gridview_DanhSachPhieu";
            this.gridview_DanhSachPhieu.ReadOnly = true;
            this.gridview_DanhSachPhieu.RowHeadersWidth = 51;
            this.gridview_DanhSachPhieu.RowTemplate.Height = 24;
            this.gridview_DanhSachPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_DanhSachPhieu.Size = new System.Drawing.Size(872, 640);
            this.gridview_DanhSachPhieu.TabIndex = 2;
            // 
            // btn_Duyet
            // 
            this.btn_Duyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Duyet.Location = new System.Drawing.Point(946, 81);
            this.btn_Duyet.Name = "btn_Duyet";
            this.btn_Duyet.Size = new System.Drawing.Size(109, 37);
            this.btn_Duyet.TabIndex = 3;
            this.btn_Duyet.Text = "Duyệt";
            this.btn_Duyet.UseVisualStyleBackColor = true;
            this.btn_Duyet.Click += new System.EventHandler(this.btn_Duyet_Click);
            // 
            // cbx_TimKiemTheo
            // 
            this.cbx_TimKiemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TimKiemTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TimKiemTheo.FormattingEnabled = true;
            this.cbx_TimKiemTheo.Items.AddRange(new object[] {
            "Tên công ty",
            "MST",
            "Tên đăng nhập"});
            this.cbx_TimKiemTheo.Location = new System.Drawing.Point(493, 31);
            this.cbx_TimKiemTheo.Name = "cbx_TimKiemTheo";
            this.cbx_TimKiemTheo.Size = new System.Drawing.Size(173, 30);
            this.cbx_TimKiemTheo.TabIndex = 4;
            this.cbx_TimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.cbx_TimKiemTheo_SelectedIndexChanged);
            // 
            // lbl_Theo
            // 
            this.lbl_Theo.AutoSize = true;
            this.lbl_Theo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Theo.Location = new System.Drawing.Point(420, 34);
            this.lbl_Theo.Name = "lbl_Theo";
            this.lbl_Theo.Size = new System.Drawing.Size(65, 28);
            this.lbl_Theo.TabIndex = 5;
            this.lbl_Theo.Text = "Theo";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(700, 30);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(94, 31);
            this.btn_Tim.TabIndex = 6;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(946, 140);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(109, 36);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // DuyetPhieuDangKyDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 767);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.lbl_Theo);
            this.Controls.Add(this.cbx_TimKiemTheo);
            this.Controls.Add(this.btn_Duyet);
            this.Controls.Add(this.gridview_DanhSachPhieu);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Name = "DuyetPhieuDangKyDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuyetPhieuDangKyDN";
            ((System.ComponentModel.ISupportInitialize)(this.gridview_DanhSachPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.DataGridView gridview_DanhSachPhieu;
        private System.Windows.Forms.Button btn_Duyet;
        private System.Windows.Forms.ComboBox cbx_TimKiemTheo;
        private System.Windows.Forms.Label lbl_Theo;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_Sua;
    }
}