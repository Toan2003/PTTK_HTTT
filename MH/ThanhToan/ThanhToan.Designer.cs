namespace PTTK.MH.ThanhToan
{
    partial class ThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TenKhachHang = new System.Windows.Forms.TextBox();
            this.ThanhToanThang = new System.Windows.Forms.Button();
            this.ThanhToanTraGop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaDoanhNghiep = new System.Windows.Forms.TextBox();
            this.TimBtn = new System.Windows.Forms.Button();
            this.MaPhieuDangKy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiếu đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Doanh Nghiệp";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TenKhachHang.Location = new System.Drawing.Point(196, 144);
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Size = new System.Drawing.Size(243, 22);
            this.TenKhachHang.TabIndex = 4;
            // 
            // ThanhToanThang
            // 
            this.ThanhToanThang.Location = new System.Drawing.Point(113, 350);
            this.ThanhToanThang.Name = "ThanhToanThang";
            this.ThanhToanThang.Size = new System.Drawing.Size(178, 25);
            this.ThanhToanThang.TabIndex = 5;
            this.ThanhToanThang.Text = "Thanh toán trả thẳng";
            this.ThanhToanThang.UseVisualStyleBackColor = true;
            // 
            // ThanhToanTraGop
            // 
            this.ThanhToanTraGop.Location = new System.Drawing.Point(499, 350);
            this.ThanhToanTraGop.Name = "ThanhToanTraGop";
            this.ThanhToanTraGop.Size = new System.Drawing.Size(183, 25);
            this.ThanhToanTraGop.TabIndex = 6;
            this.ThanhToanTraGop.Text = "Thanh toán trả góp";
            this.ThanhToanTraGop.UseVisualStyleBackColor = true;
            this.ThanhToanTraGop.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng số tiền";
            // 
            // TongTien
            // 
            this.TongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TongTien.Location = new System.Drawing.Point(196, 187);
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Size = new System.Drawing.Size(323, 22);
            this.TongTien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình trạng";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(196, 235);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(323, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Chưa thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã Doanh Nghiệp";
            // 
            // MaDoanhNghiep
            // 
            this.MaDoanhNghiep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaDoanhNghiep.Location = new System.Drawing.Point(610, 147);
            this.MaDoanhNghiep.Name = "MaDoanhNghiep";
            this.MaDoanhNghiep.ReadOnly = true;
            this.MaDoanhNghiep.Size = new System.Drawing.Size(122, 22);
            this.MaDoanhNghiep.TabIndex = 12;
            // 
            // TimBtn
            // 
            this.TimBtn.Location = new System.Drawing.Point(467, 97);
            this.TimBtn.Name = "TimBtn";
            this.TimBtn.Size = new System.Drawing.Size(101, 29);
            this.TimBtn.TabIndex = 13;
            this.TimBtn.Text = "Tìm";
            this.TimBtn.UseVisualStyleBackColor = true;
            this.TimBtn.Click += new System.EventHandler(this.TimBtn_Click);
            // 
            // MaPhieuDangKy
            // 
            this.MaPhieuDangKy.Location = new System.Drawing.Point(196, 100);
            this.MaPhieuDangKy.Name = "MaPhieuDangKy";
            this.MaPhieuDangKy.Size = new System.Drawing.Size(243, 22);
            this.MaPhieuDangKy.TabIndex = 14;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaPhieuDangKy);
            this.Controls.Add(this.TimBtn);
            this.Controls.Add(this.MaDoanhNghiep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThanhToanTraGop);
            this.Controls.Add(this.ThanhToanThang);
            this.Controls.Add(this.TenKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenKhachHang;
        private System.Windows.Forms.Button ThanhToanThang;
        private System.Windows.Forms.Button ThanhToanTraGop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaDoanhNghiep;
        private System.Windows.Forms.Button TimBtn;
        private System.Windows.Forms.TextBox MaPhieuDangKy;
    }
}

