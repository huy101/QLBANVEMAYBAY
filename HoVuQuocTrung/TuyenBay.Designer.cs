namespace HoVuQuocTrung
{
    partial class TuyenBay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATUYENBAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASANBAYDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATUYENBAY,
            this.MASANBAYDI,
            this.MASANBAYDEN});
            this.dataGridView1.Location = new System.Drawing.Point(9, 211);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 226);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // MATUYENBAY
            // 
            this.MATUYENBAY.DataPropertyName = "MATUYENBAY";
            this.MATUYENBAY.HeaderText = "Mã tuyến bay";
            this.MATUYENBAY.Name = "MATUYENBAY";
            this.MATUYENBAY.Width = 150;
            // 
            // MASANBAYDI
            // 
            this.MASANBAYDI.DataPropertyName = "MASANBAYDI";
            this.MASANBAYDI.HeaderText = "Mã Sân Bay Đi";
            this.MASANBAYDI.Name = "MASANBAYDI";
            this.MASANBAYDI.Width = 200;
            // 
            // MASANBAYDEN
            // 
            this.MASANBAYDEN.DataPropertyName = "MASANBAYDEN";
            this.MASANBAYDEN.HeaderText = "Mã Sân Bay Đến";
            this.MASANBAYDEN.Name = "MASANBAYDEN";
            this.MASANBAYDEN.Width = 200;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên Sân Bay đi:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 164);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_1.Location = new System.Drawing.Point(216, 68);
            this.txt_1.Margin = new System.Windows.Forms.Padding(5);
            this.txt_1.Name = "txt_1";
            this.txt_1.ReadOnly = true;
            this.txt_1.Size = new System.Drawing.Size(220, 20);
            this.txt_1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên Sân Bay đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Tuyến Bay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(212, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "THÊM TUYẾN BAY";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(469, 62);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(98, 30);
            this.bt_them.TabIndex = 26;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // TuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_them);
            this.Name = "TuyenBay";
            this.Text = "Tuyến Bay";
            this.Load += new System.EventHandler(this.TuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATUYENBAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASANBAYDEN;
    }
}