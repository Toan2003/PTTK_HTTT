﻿namespace PTTK.MH.Dashboard
{
    partial class DashboardNV
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_DuyetDoanhNghiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thực hiện thanh toán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(530, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xem phiếu đăng tuyển";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dash Board Nhân Viên";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DangXuat.FlatAppearance.BorderSize = 2;
            this.btn_DangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(659, 323);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(129, 37);
            this.btn_DangXuat.TabIndex = 4;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_DuyetDoanhNghiep
            // 
            this.btn_DuyetDoanhNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DuyetDoanhNghiep.Location = new System.Drawing.Point(333, 140);
            this.btn_DuyetDoanhNghiep.Name = "btn_DuyetDoanhNghiep";
            this.btn_DuyetDoanhNghiep.Size = new System.Drawing.Size(156, 100);
            this.btn_DuyetDoanhNghiep.TabIndex = 5;
            this.btn_DuyetDoanhNghiep.Text = "Duyệt Doanh nghiệp";
            this.btn_DuyetDoanhNghiep.UseVisualStyleBackColor = true;
            this.btn_DuyetDoanhNghiep.Click += new System.EventHandler(this.btn_DuyetDoanhNghiep_Click);
            // 
            // DashboardNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.btn_DuyetDoanhNghiep);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DashboardNV";
            this.Text = "DashboardNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_DuyetDoanhNghiep;
    }
}