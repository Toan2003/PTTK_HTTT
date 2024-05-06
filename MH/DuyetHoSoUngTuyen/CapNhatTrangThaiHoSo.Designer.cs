namespace WindowsFormsApp2.MH.DuyetHoSoUngTuyen
{
    partial class CapNhatTrangThaiHoSo
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
            this.cbx_TrangThaiXetDuyet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_DoUuTien = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_TrangThaiXetDuyet
            // 
            this.cbx_TrangThaiXetDuyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TrangThaiXetDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TrangThaiXetDuyet.FormattingEnabled = true;
            this.cbx_TrangThaiXetDuyet.Items.AddRange(new object[] {
            "Đã tiếp nhận",
            "Đủ điều kiện",
            "Không đủ điều kiện",
            "Đã xử lý",
            "Được DN phản hồi"});
            this.cbx_TrangThaiXetDuyet.Location = new System.Drawing.Point(215, 59);
            this.cbx_TrangThaiXetDuyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_TrangThaiXetDuyet.Name = "cbx_TrangThaiXetDuyet";
            this.cbx_TrangThaiXetDuyet.Size = new System.Drawing.Size(140, 30);
            this.cbx_TrangThaiXetDuyet.TabIndex = 2;
            this.cbx_TrangThaiXetDuyet.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trạng thái hồ sơ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Độ ưu tiên";
            // 
            // cbx_DoUuTien
            // 
            this.cbx_DoUuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_DoUuTien.FormattingEnabled = true;
            this.cbx_DoUuTien.Items.AddRange(new object[] {
            "Thấp",
            "Trung bình",
            "Cao",
            "Chưa xét"});
            this.cbx_DoUuTien.Location = new System.Drawing.Point(215, 143);
            this.cbx_DoUuTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_DoUuTien.Name = "cbx_DoUuTien";
            this.cbx_DoUuTien.Size = new System.Drawing.Size(140, 30);
            this.cbx_DoUuTien.TabIndex = 5;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(103, 220);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(87, 39);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(215, 220);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(87, 39);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            // 
            // CapNhatTrangThaiHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 272);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cbx_DoUuTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_TrangThaiXetDuyet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CapNhatTrangThaiHoSo";
            this.Text = "Cập nhật trạng thái";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_TrangThaiXetDuyet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_DoUuTien;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
    }
}