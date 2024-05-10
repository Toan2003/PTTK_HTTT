namespace PTTK.MH.LapPhieuCCTTDT
{
    partial class XemPDTDN
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
            this.ChiTietBtn = new System.Windows.Forms.Button();
            this.ChuaPheDuyetBtn = new System.Windows.Forms.Button();
            this.ToanBoBTN = new System.Windows.Forms.Button();
            this.DSPDT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DSPDT)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietBtn
            // 
            this.ChiTietBtn.Location = new System.Drawing.Point(368, 424);
            this.ChiTietBtn.Name = "ChiTietBtn";
            this.ChiTietBtn.Size = new System.Drawing.Size(75, 23);
            this.ChiTietBtn.TabIndex = 9;
            this.ChiTietBtn.Text = "Xem Chi Tiet";
            this.ChiTietBtn.UseVisualStyleBackColor = true;
            // 
            // ChuaPheDuyetBtn
            // 
            this.ChuaPheDuyetBtn.Location = new System.Drawing.Point(124, 39);
            this.ChuaPheDuyetBtn.Name = "ChuaPheDuyetBtn";
            this.ChuaPheDuyetBtn.Size = new System.Drawing.Size(131, 23);
            this.ChuaPheDuyetBtn.TabIndex = 8;
            this.ChuaPheDuyetBtn.Text = "Chưa Phê duyệt";
            this.ChuaPheDuyetBtn.UseVisualStyleBackColor = true;
            this.ChuaPheDuyetBtn.Click += new System.EventHandler(this.ChuaPheDuyetBtn_Click);
            // 
            // ToanBoBTN
            // 
            this.ToanBoBTN.Location = new System.Drawing.Point(300, 39);
            this.ToanBoBTN.Name = "ToanBoBTN";
            this.ToanBoBTN.Size = new System.Drawing.Size(132, 23);
            this.ToanBoBTN.TabIndex = 7;
            this.ToanBoBTN.Text = "Toàn bộ";
            this.ToanBoBTN.UseVisualStyleBackColor = true;
            this.ToanBoBTN.Click += new System.EventHandler(this.ToanBoBTN_Click);
            // 
            // DSPDT
            // 
            this.DSPDT.AllowUserToAddRows = false;
            this.DSPDT.AllowUserToDeleteRows = false;
            this.DSPDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSPDT.Location = new System.Drawing.Point(95, 68);
            this.DSPDT.Name = "DSPDT";
            this.DSPDT.ReadOnly = true;
            this.DSPDT.RowHeadersWidth = 51;
            this.DSPDT.RowTemplate.Height = 24;
            this.DSPDT.Size = new System.Drawing.Size(611, 349);
            this.DSPDT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phiếu đăng tuyển";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // XemPDTDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChiTietBtn);
            this.Controls.Add(this.ChuaPheDuyetBtn);
            this.Controls.Add(this.ToanBoBTN);
            this.Controls.Add(this.DSPDT);
            this.Controls.Add(this.label1);
            this.Name = "XemPDTDN";
            this.Text = "XemPDTDN";
            ((System.ComponentModel.ISupportInitialize)(this.DSPDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChiTietBtn;
        private System.Windows.Forms.Button ChuaPheDuyetBtn;
        private System.Windows.Forms.Button ToanBoBTN;
        private System.Windows.Forms.DataGridView DSPDT;
        private System.Windows.Forms.Label label1;
    }
}