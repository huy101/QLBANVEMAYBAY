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
    public partial class LichBay : Form
    {
        public LichBay()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();

        private void frm_ThemChuyenBay_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SelectAll();
            comboBox1.DataSource = cn.ExecuteData("select * from sanbay ");
            comboBox1.DisplayMember = "TenSanBay";// hiên thị
            comboBox1.ValueMember = "MaSanBay";// giá trị chọn
            comboBox1.SelectedIndex = 0;

            comboBox2.DataSource = cn.ExecuteData("select MASANBAY, TENSANBAY from TUYENBAY, SANBAY where SANBAY.MASANBAY = TUYENBAY.MASANBAYDEN and MASANBAYDI='" + comboBox1.SelectedValue + "' ");
            comboBox2.DisplayMember = "TENSANBAY";// hiên thị
            comboBox2.ValueMember = "MASANBAY";// giá trị chọn

            string sql = "select MAMAYBAY, TENMAYBAY from MAYBAY";
            comboBox3.DataSource = cn.ExecuteData(sql);
            comboBox3.DisplayMember = "TENMAYBAY";
            comboBox3.ValueMember = "MAMAYBAY";
        }


        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from CHUYENBAY");
        }
        public int  INSERT(string MACHUYENBAY, DateTime NGAYGIO, int THOIGIANBAY, int SOLUONGGHEHANG1, int SOLUONGGHEHANG2, string MATUYENBAY, string MAMAYBAY)
        {
            string sql = "INSERT INTO CHUYENBAY(MACHUYENBAY,NGAYGIO,THOIGIANBAY,SOLUONGGHEHANG1,SOLUONGGHEHANG2,MATUYENBAY,MAMAYBAY) VALUES (N'" + MACHUYENBAY + "',N'" + NGAYGIO.ToString("MM/dd/yyyy") + "'," + THOIGIANBAY + "," + SOLUONGGHEHANG1 + "," + SOLUONGGHEHANG2 + ",N'" + MATUYENBAY + "',N'" + MAMAYBAY + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MACHUYENBAY, DateTime NGAYGIO, int THOIGIANBAY, int SOLUONGGHEHANG1, int SOLUONGGHEHANG2, string MATUYENBAY, string MAMAYBAY)
        {
            string sql = "UPDATE CHUYENBAY SET [MACHUYENBAY]='" + MACHUYENBAY + "',[NGAYGIO]='" + NGAYGIO.ToString("MM/dd/yyyy") + "',[THOIGIANBAY]=" + THOIGIANBAY + ",[SOLUONGGHEHANG1]=" + SOLUONGGHEHANG1 + ",[SOLUONGGHEHANG2]=" + SOLUONGGHEHANG2 + ",[MATUYENBAY]='" + MATUYENBAY + "',[MAMAYBAY]='" + MAMAYBAY + "' WHERE [MACHUYENBAY]=N'" + MACHUYENBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }
        public int Delete(string MACHUYENBAY)
        {
            string sql = "DELETE FROM CHUYENBAY WHERE [MACHUYENBAY]=N'" + MACHUYENBAY + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.DataSource = cn.ExecuteData("select MASANBAY, TENSANBAY from TUYENBAY, SANBAY where SANBAY.MASANBAY = TUYENBAY.MASANBAYDEN and MASANBAYDI='" + comboBox1.SelectedValue + "' ");
            comboBox2.DisplayMember = "TENSANBAY";// hiên thị
            comboBox2.ValueMember = "MASANBAY";// giá trị chọn
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            sb.ShowDialog();
            comboBox1.DataSource = cn.ExecuteData("select * from sanbay ");
            comboBox1.DisplayMember = "TenSanBay";// hiên thị
            comboBox1.ValueMember = "MaSanBay";// giá trị chọn
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TuyenBay tb = new TuyenBay();
            tb.ShowDialog();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Thêm mã chuyến bay");
                }
                else if (INSERT(textBox1.Text, dateTimePicker1.Value, int.Parse(textBox6.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), comboBox1.SelectedValue + "-" + comboBox2.SelectedValue, comboBox3.SelectedValue.ToString()) != -1)
                {
                    dataGridView1.DataSource = SelectAll();
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại", "Thông báo");
                }
            }
            catch (Exception m) { MessageBox.Show(m.Message, "Thông báo"); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox3.SelectedValue = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                string s = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBox1.SelectedValue = s.Substring(0, s.IndexOf('-'));
                comboBox2.SelectedValue = s.Substring(s.LastIndexOf('-'), s.Length - s.LastIndexOf('-')).Replace("-", "");
            }
            catch { }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                UPDATE(textBox1.Text, dateTimePicker1.Value, int.Parse(textBox6.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), comboBox1.SelectedValue + "-" + comboBox2.SelectedValue, comboBox3.SelectedValue.ToString());
                dataGridView1.DataSource = SelectAll();
                MessageBox.Show("Đã cập nhật dữ liệu thành công", "Thông báo");
            }
            catch (Exception m) { MessageBox.Show(m.Message, "Thông báo"); }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    Delete(textBox1.Text);

                    dataGridView1.DataSource = SelectAll();
                    MessageBox.Show("Đã xóa liệu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sai dữ liệu");
                }
            }
            catch (Exception m) { MessageBox.Show(m.Message, "Thông báo"); }
        }

        private void bt_re_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            sb.ShowDialog();
            comboBox1.DataSource = cn.ExecuteData("select * from SanBay ");
            comboBox1.DisplayMember = "TenSanBay";// hiên thị
            comboBox1.ValueMember = "MaSanBay";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TuyenBay tb = new TuyenBay();
            tb.ShowDialog();
            comboBox2.DataSource = cn.ExecuteData("select MASANBAY, TENSANBAY from TUYENBAY, SANBAY where SANBAY.MASANBAY = TUYENBAY.MASANBAYDEN and MASANBAYDI='" + comboBox1.SelectedValue + "' ");
            comboBox2.DisplayMember = "TENSANBAY";// hiên thị
            comboBox2.ValueMember = "MASANBAY";// giá trị chọn
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MayBay tb = new MayBay();
            tb.ShowDialog();
            string sql = "select MAMAYBAY, TENMAYBAY from MAYBAY";
            comboBox3.DataSource = cn.ExecuteData(sql);
            comboBox3.DisplayMember = "TENMAYBAY";
            comboBox3.ValueMember = "MAMAYBAY";
        }
    }
}
