namespace HoVuQuocTrung
{
    partial class DoanhThuThang
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
            this.bnt_thoat = new System.Windows.Forms.Button();
            this.bnt_baocao = new System.Windows.Forms.Button();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_thoat
            // 
            this.bnt_thoat.Location = new System.Drawing.Point(268, 149);
            this.bnt_thoat.Name = "bnt_thoat";
            this.bnt_thoat.Size = new System.Drawing.Size(106, 23);
            this.bnt_thoat.TabIndex = 13;
            this.bnt_thoat.Text = "Thoát";
            this.bnt_thoat.UseVisualStyleBackColor = true;
            this.bnt_thoat.Click += new System.EventHandler(this.bnt_thoat_Click);
            // 
            // bnt_baocao
            // 
            this.bnt_baocao.Location = new System.Drawing.Point(41, 149);
            this.bnt_baocao.Name = "bnt_baocao";
            this.bnt_baocao.Size = new System.Drawing.Size(118, 23);
            this.bnt_baocao.TabIndex = 12;
            this.bnt_baocao.Text = "Báo Cáo";
            this.bnt_baocao.UseVisualStyleBackColor = true;
            // 
            // cb_nam
            // 
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Items.AddRange(new object[] {
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cb_nam.Location = new System.Drawing.Point(299, 80);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(77, 21);
            this.cb_nam.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Năm";
            // 
            // cb_thang
            // 
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cb_thang.Location = new System.Drawing.Point(114, 80);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(83, 21);
            this.cb_thang.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(76, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "BÁO CÁO DOANH THU THÁNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tháng";
            // 
            // DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 191);
            this.Controls.Add(this.bnt_thoat);
            this.Controls.Add(this.bnt_baocao);
            this.Controls.Add(this.cb_nam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThuThang";
            this.Text = "DoanhThuThang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_thoat;
        private System.Windows.Forms.Button bnt_baocao;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}