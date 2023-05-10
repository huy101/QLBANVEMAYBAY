namespace HoVuQuocTrung
{
    partial class DoanhThuNam
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
            this.bnt_2 = new System.Windows.Forms.Button();
            this.bnt_1 = new System.Windows.Forms.Button();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_2
            // 
            this.bnt_2.Location = new System.Drawing.Point(212, 102);
            this.bnt_2.Name = "bnt_2";
            this.bnt_2.Size = new System.Drawing.Size(75, 23);
            this.bnt_2.TabIndex = 9;
            this.bnt_2.Text = "Thoát";
            this.bnt_2.UseVisualStyleBackColor = true;
            // 
            // bnt_1
            // 
            this.bnt_1.Location = new System.Drawing.Point(10, 102);
            this.bnt_1.Name = "bnt_1";
            this.bnt_1.Size = new System.Drawing.Size(75, 23);
            this.bnt_1.TabIndex = 8;
            this.bnt_1.Text = "Báo Cáo";
            this.bnt_1.UseVisualStyleBackColor = true;
            // 
            // cb_1
            // 
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
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
            this.cb_1.Location = new System.Drawing.Point(101, 57);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(121, 21);
            this.cb_1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "BÁO CÁO DOANH THU NĂM";
            // 
            // DoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 144);
            this.Controls.Add(this.bnt_2);
            this.Controls.Add(this.bnt_1);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThuNam";
            this.Text = "Doanh Thu Năm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_2;
        private System.Windows.Forms.Button bnt_1;
        private System.Windows.Forms.ComboBox cb_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}