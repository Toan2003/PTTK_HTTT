﻿namespace PTTK.MH.Dashboard
{
    partial class DashboardDN
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
            this.lbl_TenCongTy = new System.Windows.Forms.Label();
            this.btn_XemPhieuDangTuyen = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_TaoPhieuDangTuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TenCongTy
            // 
            this.lbl_TenCongTy.AutoSize = true;
            this.lbl_TenCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenCongTy.Location = new System.Drawing.Point(609, 30);
            this.lbl_TenCongTy.Name = "lbl_TenCongTy";
            this.lbl_TenCongTy.Size = new System.Drawing.Size(190, 22);
            this.lbl_TenCongTy.TabIndex = 0;
            this.lbl_TenCongTy.Text = "Xin chào, công ty ABC";
            // 
            // btn_XemPhieuDangTuyen
            // 
            this.btn_XemPhieuDangTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemPhieuDangTuyen.Location = new System.Drawing.Point(323, 125);
            this.btn_XemPhieuDangTuyen.Name = "btn_XemPhieuDangTuyen";
            this.btn_XemPhieuDangTuyen.Size = new System.Drawing.Size(209, 65);
            this.btn_XemPhieuDangTuyen.TabIndex = 1;
            this.btn_XemPhieuDangTuyen.Text = "Xem phiếu đăng tuyển";
            this.btn_XemPhieuDangTuyen.UseVisualStyleBackColor = true;
            this.btn_XemPhieuDangTuyen.Click += new System.EventHandler(this.btn_XemPhieuDangTuyen_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DangXuat.FlatAppearance.BorderSize = 2;
            this.btn_DangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(670, 406);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(129, 37);
            this.btn_DangXuat.TabIndex = 2;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            // 
            // btn_TaoPhieuDangTuyen
            // 
            this.btn_TaoPhieuDangTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoPhieuDangTuyen.Location = new System.Drawing.Point(323, 226);
            this.btn_TaoPhieuDangTuyen.Name = "btn_TaoPhieuDangTuyen";
            this.btn_TaoPhieuDangTuyen.Size = new System.Drawing.Size(208, 62);
            this.btn_TaoPhieuDangTuyen.TabIndex = 3;
            this.btn_TaoPhieuDangTuyen.Text = "Tạo phiếu đăng tuyển";
            this.btn_TaoPhieuDangTuyen.UseVisualStyleBackColor = true;
            // 
            // DashboardDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.Controls.Add(this.btn_TaoPhieuDangTuyen);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_XemPhieuDangTuyen);
            this.Controls.Add(this.lbl_TenCongTy);
            this.Name = "DashboardDN";
            this.Text = "DashboardDN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TenCongTy;
        private System.Windows.Forms.Button btn_XemPhieuDangTuyen;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_TaoPhieuDangTuyen;
    }
}