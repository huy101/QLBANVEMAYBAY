﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HoVuQuocTrung
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btdanhnhap_Click(object sender, EventArgs e)
        {
            string sql = "select manv, tennv from NHANVIEN where manv ='" + textBox1.Text + "' and matkhau='" + textBox2.Text + "'";
            DataTable dt = cn.ExecuteData(sql);
            if (dt.Rows.Count > 0)
            {
                if (textBox2.Text == "123456789")
                {
                   if(MessageBox.Show("Bạn đang dùng mật khẩu mặc định.\nHãy đổi mật khẩu", "Cảnh báo",MessageBoxButtons.YesNo) ==DialogResult.Yes)
                    {
                        DoiMatKhau dmk = new DoiMatKhau();
                        dmk.manv = dt.Rows[0][0].ToString();
                        dmk.tennv = dt.Rows[0][1].ToString();
                        dmk.ShowDialog();
                    }
                }
                Main frmMain = new Main();
                frmMain.Manv = dt.Rows[0][0].ToString();
                frmMain.Tennv = dt.Rows[0][1].ToString();
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btdanhnhap_Click(new object(), new EventArgs());
            }
        }
    }
}
