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
    public partial class DatCho : Form
    {
        public DatCho()
        {
            InitializeComponent();
        }

        private void DatCho_Load(object sender, EventArgs e)
        {
            // su kien form load

            cb_1.DataSource = cn.ExecuteData("select * from CHUYENBAY ");
            cb_1.ValueMember = "MACHUYENBAY";
            cb_1.DisplayMember = "MACHUYENBAY";
            //cb_1.Items.Add("---Chọn chuyến bay--");

            HienthiHangVe();

            dataGridView1.DataSource = cn.ExecuteData("select * from PHIEUDATCHO");
        }

        Connection cn = new Connection();

        public DataTable SelectAll()
        {
            return cn.ExecuteData("select * from VECHUYENBAY");
        }
        public void HienthiHangVe()
        {
            cb_2.DataSource = cn.ExecuteData("select * from HANGVE ");
            cb_2.ValueMember = "MAHANGVE";
            cb_2.DisplayMember = "TENHANGVE";
        }
        string matuyen = "";
        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from CHUYENBAY where MACHUYENBAY=N'" + cb_1.Text + "'";
                DataTable dt = cn.ExecuteData(sql);
                string maTuyenBay = dt.Rows[0]["MATUYENBAY"].ToString();
                string[] sanBay = maTuyenBay.Split('-');
                sql = "select TENSANBAY from SANBAY where MASANBAY =N'" + sanBay[0] + "'";
                txt_1.Text = cn.ExecuteData(sql).Rows[0][0].ToString();
                sql = "select TENSANBAY from SANBAY where MASANBAY =N'" + sanBay[1] + "'";
                txt_2.Text = cn.ExecuteData(sql).Rows[0][0].ToString();

                txt_4.Text = "Còn vé";
                txt_3.Text = dt.Rows[0]["NGAYGIO"].ToString();
                matuyen = dt.Rows[0]["MATUYENBAY"].ToString();
                DataTable giave = cn.ExecuteData("SELECT * FROM DONGIA WHERE  MACHUYENBAY='" + matuyen + "' AND MAHANGVE='" + cb_2.SelectedValue + "'");
                if (giave.Rows.Count > 0)
                    textBox10.Text = giave.Rows[0]["VND"].ToString();
                else textBox10.Text = "0";

            }
            catch { }
        }

        public int INSERT(string MAKHACHHANG, string CMND, string MACHUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GiaTien)
        {
            string sql = "INSERT INTO PHIEUDATCHO(MAHANHKHACH,CMND,MACHUYENBAY,MAHANGVE,SOGHEDAT,NGAYDAT,GiaTien) VALUES (N'" + MAKHACHHANG+"','"+ CMND + "',N'" + MACHUYENBAY + "',N'" + MAHANGVE + "'," + SOGHEDAT + ",N'" + NGAYDAT.ToString("hh:mm:ss  MM/dd/ yyyy") + "'," + GiaTien + ")";
            return cn.ExecuteNonQuery(sql);
        }
        public int UPDATE(int MAPHIEUDATCHO, string MAKHACHHANG, string CMND, string MACHUYENBAY, string MAHANGVE, int SOGHEDAT, DateTime NGAYDAT, int GiaTien)
        {
            string sql = "UPDATE PHIEUDATCHO SET [MAHANHKHACH]="+ MAKHACHHANG+",[CMND]=" + CMND + ",[MACHUYENBAY]=" + MACHUYENBAY + ",[MAHANGVE]=" + MAHANGVE + ",[SOGHEDAT]=N'" + SOGHEDAT + "',[NGAYDAT]=" + NGAYDAT.ToString("hh:mm:ss  MM/dd/ yyyy") + ",[GiaTien]=N'" + GiaTien + "' WHERE [MAPHIEUDATCHO]=" + MAPHIEUDATCHO + "";
            return cn.ExecuteNonQuery(sql);
        }
        public int  Delete(string MAPHIEUDATCHO)
        {
            string sql = "DELETE FROM PHIEUDATCHO WHERE [MAPHIEUDAT]=N'" + MAPHIEUDATCHO + "'";
            return cn.ExecuteNonQuery(sql);
        }

        private void bnt_luu_Click(object sender, EventArgs e)
        {
            if (INSERT(txt_5.Text,txt_6.Text,cb_1.SelectedValue.ToString(), cb_2.SelectedValue.ToString(),1,dateTimePicker1.Value,int.Parse(textBox10.Text))!= -1)
            {
                MessageBox.Show("Thêm Phiếu đạt thành công");
                DatCho_Load(new object(), new EventArgs());
                txt_5.Clear();
                txt_6.Clear();
                txt_7.Clear();
                txt_8.Clear();
            }
            else
            {
                MessageBox.Show("Thêm phiếu đặt thất bại");
            }
        }

        private void txt_5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * from KHACHHANG where MAHANHKHACH ='" + txt_5.Text + "'";
                DataTable dt = cn.ExecuteData(sql);
                if (dt?.Rows.Count > 0)
                {
                    txt_6.Text = dt.Rows[0]["CMND"].ToString();
                    txt_7.Text = dt.Rows[0]["TENKH"].ToString();
                    txt_8.Text = dt.Rows[0]["DIENTHOAI"].ToString();
                }
            }
            catch { }
        }

        private void cb_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select DONGIA from DONGIA where MAHANGVE='" + cb_2.SelectedValue.ToString() + "' and MACHUYENBAY='" + cb_1.SelectedValue.ToString() + "'";
            DataTable dt = cn.ExecuteData(sql);
            if (dt?.Rows.Count > 0)
            {
                textBox10.Text = dt.Rows[0][0].ToString();
            }
        }

        private void bnt_taomoi_Click(object sender, EventArgs e)
        {
            DatCho_Load(new object(), new EventArgs());
        }

        private void bnt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            if (Delete(dataGridView1.CurrentRow.Cells[0].Value.ToString())!= -1){

                MessageBox.Show("Xóa phiếu đặt chỗ thành công");
                DatCho_Load(new object(), new EventArgs());

            }
            else
            {
                MessageBox.Show("Xóa phiếu đặt chỗ thất bại");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanBay sb = new SanBay();
            sb.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TuyenBay tb = new TuyenBay();
            tb.ShowDialog();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            HangVe vn = new HangVe();
            vn.ShowDialog();
            HienthiHangVe();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            QuanLyGia ql = new QuanLyGia();
            ql.ShowDialog();
        }
    }
}
