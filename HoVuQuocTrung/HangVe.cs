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
    public partial class HangVe : Form
    {
        public HangVe()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        private void frm_ThemHangVe_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cn.ExecuteData("select * from HANGVE");
            comboBox1.ValueMember = "Mahangve";
            comboBox1.DisplayMember = "Tenhangve";
        }
        public int INSERT(string MAHANGVE, string TENHANGVE)
        {
            string sql = "INSERT INTO HANGVE(MAHANGVE,TENHANGVE) VALUES (N'" + MAHANGVE + "',N'" + TENHANGVE + "')";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(string MAHANGVE, string TENHANGVE)
        {
            var mahangvecu = comboBox1.SelectedValue;
            if(!MAHANGVE.Equals(mahangvecu))
            {
                MessageBox.Show("Không thể cập nhật Mã hạng vé");
                return -1;
            }
            else
            {
                string sql = "UPDATE HANGVE SET [TENHANGVE]='" + TENHANGVE + "' WHERE [MAHANGVE]=N'" + MAHANGVE + "'";
                var result = cn.ExecuteNonQuery(sql);
                return result;
            }
        }
        public int Delete(string MAHANGVE)
        {
            string sql = "DELETE FROM HANGVE WHERE [MAHANGVE]=N'" + MAHANGVE + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                    UPDATE(textBox1.Text, textBox2.Text);
                comboBox1.DataSource = cn.ExecuteData("select * from HANGVE");
                comboBox1.ValueMember = "Mahangve";
                comboBox1.DisplayMember = "Tenhangve";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                    INSERT(textBox1.Text, textBox2.Text);
                comboBox1.DataSource = cn.ExecuteData("select * from HANGVE");
                comboBox1.ValueMember = "Mahangve";
                comboBox1.DisplayMember = "Tenhangve";
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.Text;
            textBox1.Text = comboBox1.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
