namespace PTTK.MH.LapPhieuCCTTDT
{
    partial class XemPhieuDangTuyen
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
            this.DSPDT = new System.Windows.Forms.DataGridView();
            this.ToanBoBTN = new System.Windows.Forms.Button();
            this.ChuaPheDuyetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSPDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu đăng tuyển";
            // 
            // DSPDT
            // 
            this.DSPDT.AllowUserToAddRows = false;
            this.DSPDT.AllowUserToDeleteRows = false;
            this.DSPDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSPDT.Location = new System.Drawing.Point(100, 73);
            this.DSPDT.Name = "DSPDT";
            this.DSPDT.ReadOnly = true;
            this.DSPDT.RowHeadersWidth = 51;
            this.DSPDT.RowTemplate.Height = 24;
            this.DSPDT.Size = new System.Drawing.Size(611, 349);
            this.DSPDT.TabIndex = 1;
            // 
            // ToanBoBTN
            // 
            this.ToanBoBTN.Location = new System.Drawing.Point(514, 44);
            this.ToanBoBTN.Name = "ToanBoBTN";
            this.ToanBoBTN.Size = new System.Drawing.Size(132, 23);
            this.ToanBoBTN.TabIndex = 2;
            this.ToanBoBTN.Text = "Toàn bộ";
            this.ToanBoBTN.UseVisualStyleBackColor = true;
            this.ToanBoBTN.Click += new System.EventHandler(this.ToanBoBTN_Click);
            // 
            // ChuaPheDuyetBtn
            // 
            this.ChuaPheDuyetBtn.Location = new System.Drawing.Point(129, 44);
            this.ChuaPheDuyetBtn.Name = "ChuaPheDuyetBtn";
            this.ChuaPheDuyetBtn.Size = new System.Drawing.Size(131, 23);
            this.ChuaPheDuyetBtn.TabIndex = 3;
            this.ChuaPheDuyetBtn.Text = "Chưa Phê duyệt";
            this.ChuaPheDuyetBtn.UseVisualStyleBackColor = true;
            this.ChuaPheDuyetBtn.Click += new System.EventHandler(this.ChuaPheDuyetBtn_Click);
            // 
            // XemPhieuDangTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.ChuaPheDuyetBtn);
            this.Controls.Add(this.ToanBoBTN);
            this.Controls.Add(this.DSPDT);
            this.Controls.Add(this.label1);
            this.Name = "XemPhieuDangTuyen";
            this.Text = "XemPhieuDangTuyen";
            ((System.ComponentModel.ISupportInitialize)(this.DSPDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DSPDT;
        private System.Windows.Forms.Button ToanBoBTN;
        private System.Windows.Forms.Button ChuaPheDuyetBtn;
    }
}