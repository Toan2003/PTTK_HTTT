namespace WindowsFormsApp2.MH.DuyetHoSoUngTuyen
{
    partial class DSHoSoUngVien
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
            this.gridview_HoSoUngVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_sort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TimKiemTenCongTy = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_HoSoUngVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview_HoSoUngVien
            // 
            this.gridview_HoSoUngVien.AllowUserToAddRows = false;
            this.gridview_HoSoUngVien.AllowUserToDeleteRows = false;
            this.gridview_HoSoUngVien.AllowUserToResizeColumns = false;
            this.gridview_HoSoUngVien.AllowUserToResizeRows = false;
            this.gridview_HoSoUngVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_HoSoUngVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_HoSoUngVien.Location = new System.Drawing.Point(33, 55);
            this.gridview_HoSoUngVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridview_HoSoUngVien.MultiSelect = false;
            this.gridview_HoSoUngVien.Name = "gridview_HoSoUngVien";
            this.gridview_HoSoUngVien.ReadOnly = true;
            this.gridview_HoSoUngVien.RowHeadersWidth = 51;
            this.gridview_HoSoUngVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview_HoSoUngVien.RowTemplate.Height = 24;
            this.gridview_HoSoUngVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_HoSoUngVien.Size = new System.Drawing.Size(910, 357);
            this.gridview_HoSoUngVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Công ty";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbx_sort
            // 
            this.cbx_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_sort.FormattingEnabled = true;
            this.cbx_sort.Items.AddRange(new object[] {
            "Độ ưu tiên",
            "Ngày nộp"});
            this.cbx_sort.Location = new System.Drawing.Point(822, 13);
            this.cbx_sort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_sort.Name = "cbx_sort";
            this.cbx_sort.Size = new System.Drawing.Size(121, 30);
            this.cbx_sort.TabIndex = 5;
            this.cbx_sort.Text = "Độ ưu tiên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sắp xếp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_TimKiemTenCongTy
            // 
            this.txt_TimKiemTenCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemTenCongTy.Location = new System.Drawing.Point(107, 16);
            this.txt_TimKiemTenCongTy.Name = "txt_TimKiemTenCongTy";
            this.txt_TimKiemTenCongTy.Size = new System.Drawing.Size(310, 28);
            this.txt_TimKiemTenCongTy.TabIndex = 7;
            this.txt_TimKiemTenCongTy.TextChanged += new System.EventHandler(this.txt_TimKiemTenCongTy_TextChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(423, 13);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 34);
            this.btn_TimKiem.TabIndex = 8;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Location = new System.Drawing.Point(470, 417);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(112, 48);
            this.btn_CapNhat.TabIndex = 9;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // DSHoSoUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 471);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiemTenCongTy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_sort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridview_HoSoUngVien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DSHoSoUngVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Hồ sơ ứng viên";
            this.Load += new System.EventHandler(this.DSHoSoUngVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_HoSoUngVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview_HoSoUngVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_sort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TimKiemTenCongTy;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_CapNhat;
    }
}