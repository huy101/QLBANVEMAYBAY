namespace HoVuQuocTrung
{
    partial class DangNhap
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
            this.gbthongtindangnhap = new System.Windows.Forms.GroupBox();
            this.lbstatus = new System.Windows.Forms.Label();
            this.btnhaplai = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdanhnhap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbdn = new System.Windows.Forms.Label();
            this.gbthongtindangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbthongtindangnhap
            // 
            this.gbthongtindangnhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbthongtindangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbthongtindangnhap.Controls.Add(this.lbstatus);
            this.gbthongtindangnhap.Controls.Add(this.btnhaplai);
            this.gbthongtindangnhap.Controls.Add(this.btthoat);
            this.gbthongtindangnhap.Controls.Add(this.btdanhnhap);
            this.gbthongtindangnhap.Controls.Add(this.textBox2);
            this.gbthongtindangnhap.Controls.Add(this.lbid);
            this.gbthongtindangnhap.Controls.Add(this.textBox1);
            this.gbthongtindangnhap.Controls.Add(this.lbdn);
            this.gbthongtindangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthongtindangnhap.ForeColor = System.Drawing.Color.Red;
            this.gbthongtindangnhap.Location = new System.Drawing.Point(6, 12);
            this.gbthongtindangnhap.Name = "gbthongtindangnhap";
            this.gbthongtindangnhap.Size = new System.Drawing.Size(454, 222);
            this.gbthongtindangnhap.TabIndex = 1;
            this.gbthongtindangnhap.TabStop = false;
            this.gbthongtindangnhap.Text = "Thông Tin Đăng Nhập";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbstatus.Location = new System.Drawing.Point(77, 127);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(11, 13);
            this.lbstatus.TabIndex = 6;
            this.lbstatus.Text = ".";
            // 
            // btnhaplai
            // 
            this.btnhaplai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnhaplai.Location = new System.Drawing.Point(180, 156);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(108, 42);
            this.btnhaplai.TabIndex = 4;
            this.btnhaplai.Text = "Nhập Lại";
            this.btnhaplai.UseVisualStyleBackColor = false;
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btthoat.Location = new System.Drawing.Point(338, 156);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(102, 43);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdanhnhap
            // 
            this.btdanhnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btdanhnhap.Location = new System.Drawing.Point(9, 156);
            this.btdanhnhap.Name = "btdanhnhap";
            this.btdanhnhap.Size = new System.Drawing.Size(108, 43);
            this.btdanhnhap.TabIndex = 3;
            this.btdanhnhap.Text = "Đăng Nhập";
            this.btdanhnhap.UseVisualStyleBackColor = false;
            this.btdanhnhap.Click += new System.EventHandler(this.btdanhnhap_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 24);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1";
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbid.Location = new System.Drawing.Point(19, 98);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(101, 16);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "Mã Đăng Nhập:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 24);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "2001110133";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // lbdn
            // 
            this.lbdn.AutoSize = true;
            this.lbdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbdn.Location = new System.Drawing.Point(19, 46);
            this.lbdn.Name = "lbdn";
            this.lbdn.Size = new System.Drawing.Size(106, 16);
            this.lbdn.TabIndex = 0;
            this.lbdn.Text = "Tên Đăng Nhập:";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 247);
            this.Controls.Add(this.gbthongtindangnhap);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.gbthongtindangnhap.ResumeLayout(false);
            this.gbthongtindangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbthongtindangnhap;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Button btnhaplai;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btdanhnhap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbdn;
    }
}

