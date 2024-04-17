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
            this.HoSoUngVienDataGridView = new System.Windows.Forms.DataGridView();
            this.congTyCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sapXepCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HoSoUngVienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HoSoUngVienDataGridView
            // 
            this.HoSoUngVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoSoUngVienDataGridView.Location = new System.Drawing.Point(25, 45);
            this.HoSoUngVienDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoSoUngVienDataGridView.Name = "HoSoUngVienDataGridView";
            this.HoSoUngVienDataGridView.RowTemplate.Height = 24;
            this.HoSoUngVienDataGridView.Size = new System.Drawing.Size(548, 290);
            this.HoSoUngVienDataGridView.TabIndex = 0;
            // 
            // congTyCombobox
            // 
            this.congTyCombobox.FormattingEnabled = true;
            this.congTyCombobox.Location = new System.Drawing.Point(66, 18);
            this.congTyCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.congTyCombobox.Name = "congTyCombobox";
            this.congTyCombobox.Size = new System.Drawing.Size(200, 21);
            this.congTyCombobox.TabIndex = 3;
            this.congTyCombobox.Text = "Tất cả (mặc định)";
            this.congTyCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Công ty";
            // 
            // sapXepCombobox
            // 
            this.sapXepCombobox.FormattingEnabled = true;
            this.sapXepCombobox.Items.AddRange(new object[] {
            "Độ ưu tiên",
            "Ngày nộp"});
            this.sapXepCombobox.Location = new System.Drawing.Point(369, 17);
            this.sapXepCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sapXepCombobox.Name = "sapXepCombobox";
            this.sapXepCombobox.Size = new System.Drawing.Size(92, 21);
            this.sapXepCombobox.TabIndex = 5;
            this.sapXepCombobox.Text = "Độ ưu tiên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sắp xếp";
            // 
            // DSHoSoUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sapXepCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.congTyCombobox);
            this.Controls.Add(this.HoSoUngVienDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DSHoSoUngVien";
            this.Text = "Danh sách Hồ sơ ứng viên";
            ((System.ComponentModel.ISupportInitialize)(this.HoSoUngVienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HoSoUngVienDataGridView;
        private System.Windows.Forms.ComboBox congTyCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sapXepCombobox;
        private System.Windows.Forms.Label label2;
    }
}