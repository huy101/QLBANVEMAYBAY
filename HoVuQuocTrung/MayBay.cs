using System;
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
    public partial class MayBay : Form
    {
        public MayBay()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        private void MayBay_Load(object sender, EventArgs e)
        {
            string sql = "select * from MAYBAY";
            dataGridView1.DataSource = cn.ExecuteData(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (INSERT(textBox1.Text, textBox2.Text, textBox3.Text) != -1)
            {
                MessageBox.Show("Thêm thành công");
                MayBay_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        public int INSERT(string MAMAYBAY, string TENMAYBAY, string THONGTIN)
        {
            if (TENMAYBAY.Trim() == "")
                TENMAYBAY = MAMAYBAY;
            string sql = "INSERT INTO MAYBAY(MAMAYBAY,TENMAYBAY,THONGTIN) VALUES (N'" + MAMAYBAY + "',N'" + TENMAYBAY + "',N'" + THONGTIN + "')";
            return cn.ExecuteNonQuery(sql);
        }

        public int DELETE(string MAMAYBAY)
        {
            string sql = "DELETE FROM MAYBAY where MAMAYBAY = '" + MAMAYBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }

        public int UPDATE(string MAMAYBAY, string TENMAYBAY, string THONGTIN)
        {
            if (TENMAYBAY.Trim() == "")
                TENMAYBAY = MAMAYBAY;
            string sql = "UPDATE MAYBAY set TENMAYBAY = N'"+TENMAYBAY +"', THONGTIN=N'"+THONGTIN+"'  where MAMAYBAY = '" + MAMAYBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DELETE(textBox1.Text) != -1)
            {
                MessageBox.Show("Xóa thành công");
                MayBay_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UPDATE(textBox1.Text, textBox2.Text, textBox3.Text) != -1)
            {
                MessageBox.Show("Sửa thông tin thành công");
                MayBay_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
