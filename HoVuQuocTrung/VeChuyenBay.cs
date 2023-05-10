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
    public partial class VeChuyenBay : Form
    {
        public VeChuyenBay()
        {
            InitializeComponent();
        }

        private void bnt_4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Connection cn = new Connection();

        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from VECHUYENBAY");
        }
        public void INSERT(string MAKH, string MAHANGVE, string MACHUYENBAY, int GiaTien)
        {
            string sql = "INSERT INTO VECHUYENBAY(MAKH,MAHANGVE,MACHUYENBAY,GiaTien) VALUES (N'" + MAKH + "',N'" + MAHANGVE + "',N'" + MACHUYENBAY + "'," + GiaTien + ")";
            cn.ExecuteNonQuery(sql);
        }
        public void UPDATE(int MAVECHUYENBAY, string MAKH, string MAHANGVE, string MACHUYENBAY, int GiaTien)
        {
            this.cn.KetNoi();
            string sql = "UPDATE VECHUYENBAY SET [MAKH]=" + MAKH + ",[MAHANGVE]=" + MAHANGVE + ",[MACHUYENBAY]=" + MACHUYENBAY + ",[GiaTien]=N'" + GiaTien + "' WHERE [MAVECHUYENBAY]=" + MAVECHUYENBAY + "";
            cn.ExecuteNonQuery(sql);
        }
        public void Delete(string MAPHIEUDATCHO)
        {
            this.cn.KetNoi();
            string sql = "DELETE FROM PHIEUDATCHO WHERE [MAPHIEUDATCHO]=N'" + MAPHIEUDATCHO + "'";
            cn.ExecuteNonQuery(sql);
        }

        private void frm_VeChuyenBay_Load(object sender, EventArgs e)
        {
            cb_1.DataSource = cn.ExecuteData("select * from CHUYENBAY ");
            cb_1.ValueMember = "MACHUYENBAY";
            HienthiHangVe();

        }
        public void HienthiHangVe()
        {
            cb_2.DataSource = cn.ExecuteData("select * from HANGVE ");
            cb_2.ValueMember = "MAHANGVE";
            cb_2.DisplayMember = "TENHANGVE";
        }

        private void bnt_1_Click(object sender, EventArgs e)
        {
            HangKhach kh = new HangKhach();
            kh.ShowDialog();
            txt_7.Text = kh.Tenkh;
            txt_5.Text = kh.Makh;
            txt_6.Text = kh.Makh;
            txt_8.Text = kh.Cmnd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           HangVe vn = new HangVe();
            vn.ShowDialog();
            HienthiHangVe();

        }

        private void bnt_2_Click(object sender, EventArgs e)
        {
            try
            {
                INSERT(txt_5.Text, cb_2.SelectedValue.ToString(), cb_1.SelectedValue.ToString(), int.Parse(textBox10.Text));

                MessageBox.Show("Đã thêm thành công!");

            }
            catch (Exception d) { MessageBox.Show(d.Message); }
        }
        string matuyen = "";

        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
