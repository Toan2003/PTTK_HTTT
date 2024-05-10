namespace PTTK.MH.LapPhieuCCTTDT
{
    partial class MHLapPhieuCCTTDT
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
            this.tenCtyLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HinhThuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LapPhieuBtn = new System.Windows.Forms.Button();
            this.TTYeuCau = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NgayKT = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NgayBD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ViTriUngTuyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // tenCtyLabel
            // 
            this.tenCtyLabel.AutoSize = true;
            this.tenCtyLabel.Location = new System.Drawing.Point(303, 35);
            this.tenCtyLabel.Name = "tenCtyLabel";
            this.tenCtyLabel.Size = new System.Drawing.Size(64, 16);
            this.tenCtyLabel.TabIndex = 43;
            this.tenCtyLabel.Text = "CTY ABC";
            this.tenCtyLabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Công ty";
            // 
            // HinhThuc
            // 
            this.HinhThuc.FormattingEnabled = true;
            this.HinhThuc.Items.AddRange(new object[] {
            "TRANG MẠNG",
            "BANNER QUẢNG CÁO",
            "BÁO GIẤY"});
            this.HinhThuc.Location = new System.Drawing.Point(303, 395);
            this.HinhThuc.Name = "HinhThuc";
            this.HinhThuc.Size = new System.Drawing.Size(294, 24);
            this.HinhThuc.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Hình thức ứng tuyển";
            // 
            // LapPhieuBtn
            // 
            this.LapPhieuBtn.Location = new System.Drawing.Point(378, 434);
            this.LapPhieuBtn.Name = "LapPhieuBtn";
            this.LapPhieuBtn.Size = new System.Drawing.Size(75, 23);
            this.LapPhieuBtn.TabIndex = 39;
            this.LapPhieuBtn.Text = "Lập phiếu";
            this.LapPhieuBtn.UseVisualStyleBackColor = true;
            this.LapPhieuBtn.Click += new System.EventHandler(this.LapPhieuBtn_Click);
            // 
            // TTYeuCau
            // 
            this.TTYeuCau.Location = new System.Drawing.Point(303, 273);
            this.TTYeuCau.Name = "TTYeuCau";
            this.TTYeuCau.Size = new System.Drawing.Size(294, 96);
            this.TTYeuCau.TabIndex = 38;
            this.TTYeuCau.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Thông tin yêu cầu";
            // 
            // NgayKT
            // 
            this.NgayKT.Location = new System.Drawing.Point(303, 227);
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Size = new System.Drawing.Size(200, 22);
            this.NgayKT.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ngày kết thúc";
            // 
            // NgayBD
            // 
            this.NgayBD.Location = new System.Drawing.Point(303, 172);
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.Size = new System.Drawing.Size(200, 22);
            this.NgayBD.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Số lượng tuyển dụng";
            // 
            // ViTriUngTuyen
            // 
            this.ViTriUngTuyen.Location = new System.Drawing.Point(303, 72);
            this.ViTriUngTuyen.Name = "ViTriUngTuyen";
            this.ViTriUngTuyen.Size = new System.Drawing.Size(294, 22);
            this.ViTriUngTuyen.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Vị trí ứng tuyển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "PHIẾU ĐĂNG TUYỂN";
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(303, 128);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(120, 22);
            this.SoLuong.TabIndex = 44;
            // 
            // MHLapPhieuCCTTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.tenCtyLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HinhThuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LapPhieuBtn);
            this.Controls.Add(this.TTYeuCau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NgayKT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NgayBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ViTriUngTuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MHLapPhieuCCTTDT";
            this.Text = "MHLapPhieuCCTTDT";
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tenCtyLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox HinhThuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LapPhieuBtn;
        private System.Windows.Forms.RichTextBox TTYeuCau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker NgayKT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NgayBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ViTriUngTuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SoLuong;
    }
}