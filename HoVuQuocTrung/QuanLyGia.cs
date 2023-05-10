using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoVuQuocTrung
{
    public partial class QuanLyGia : Form
    {
        public QuanLyGia()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        private void frm_quanlygia_Load(object sender, EventArgs e)
        {
            cb_chuyenbay.DataSource = cn.ExecuteData("select * from CHUYENBAY");//hien du lieu len combox chuyen bay
            cb_chuyenbay.DisplayMember = "MACHUYENBAY";// tên hiển thị
            cb_chuyenbay.ValueMember = "MACHUYENBAY";//giá trị chọn
            cb_hangve.DataSource = cn.ExecuteData("select * from HANGVE");
            cb_hangve.DisplayMember = "TENHANGVE";// tên hiển thị
            cb_hangve.ValueMember = "MAHANGVE";//giá trị chọn
            dataGridView1.DataSource = cn.ExecuteData("select * from DONGIA"); // lòad dữ liệu bảng đơn giá lên lưới
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into DONGIA values('" + cb_chuyenbay.Text + "','" + cb_hangve.SelectedValue.ToString() + "'," + txtgia.Text + ")";
            if (cn.ExecuteNonQuery(sql)!=-1)
            {
                MessageBox.Show("Thêm thành công");
                dataGridView1.DataSource = cn.ExecuteData("select * from DONGIA");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE DONGIA set DONGIA = " + txtgia.Text + " where MATUYENBAY='" + cb_chuyenbay.Text + "' and MAHANGVE='" + cb_hangve.SelectedValue.ToString() + "'";
            if (cn.ExecuteNonQuery(sql) != -1)
            {
                MessageBox.Show("Sửa thông tin thành công");
                dataGridView1.DataSource = cn.ExecuteData("select * from DONGIA");
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // bắt sự kiên click chuôt trênb dataGridView1
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                cb_chuyenbay.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cb_hangve.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtgia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
