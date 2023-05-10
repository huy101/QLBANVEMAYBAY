using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HoVuQuocTrung
{
    public partial class HangKhach : Form
    {
        public HangKhach()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        public int INSERT(string CMND, string TENKH, string DIENTHOAI)
        {
            string sql = "INSERT INTO KHACHHANG(CMND,TENKH,DIENTHOAI) VALUES (N'" + CMND + "',N'" + TENKH + "',N'" + DIENTHOAI + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAKHACHHANG,string CMND, string TENKH, string DIENTHOAI)
        {
            string sql = "UPDATE KHACHHANG SET [CMND]=" + CMND + ",[TENKH]=" + TENKH + ",[DIENTHOAI]=" + DIENTHOAI + " WHERE [MAKHACHHANG]=N'" + MAKHACHHANG + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MAKHACHHANG)
        {
            string sql = "DELETE FROM KHACHHANG WHERE [MAHANHKHACH]=N'" + MAKHACHHANG + "'";
            return cn.ExecuteNonQuery(sql);
        }

        string makh = "";

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        string tenkh = "";

        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        string cmnd = "";

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ExecuteData("select * from KHACHHANG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(INSERT(textBox1.Text, textBox2.Text, textBox4.Text)!=-1)
            {
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = cn.ExecuteData("select * from KHACHHANG");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // lấy cột mã khách hàng khi click chuôt
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells[1].Value != null && Delete(dataGridView1.CurrentRow.Cells[1].Value.ToString()) != -1)
            {
                MessageBox.Show("Xóa thành công");
                dataGridView1.DataSource = cn.ExecuteData("select * from KHACHHANG");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
