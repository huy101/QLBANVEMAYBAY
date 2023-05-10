using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoVuQuocTrung
{
    public partial class TraCuuChuyenBay : Form
    {
        public TraCuuChuyenBay()
        {
            InitializeComponent();
        }

        private void bnt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Connection kn = new Connection();
        private void TraCuuChuyenBay_Load(object sender, EventArgs e)
        {
            //  kn.KetNoi();

            cb_1.DataSource = kn.ExecuteData("select * from SANBAY"); // câu lệnh lấy dữ liệu từ bảng sanbay
            cb_1.DisplayMember = "TenSanBay";// hiên thị
            cb_1.ValueMember = "MaSanBay";// giá trị chọn

            //cb_2.DataSource = kn.ExecuteData("select * from SANBAY");

            dataGridView1.DataSource = kn.ExecuteData("select * from chuyenbay");
            //  kn.DongKetNoi();
        }

        private void bnt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string c = cb_1.SelectedValue.ToString() + "-" + cb_2.SelectedValue.ToString();

                dataGridView1.DataSource = kn.ExecuteData("select * from CHUYENBAY where MATUYENBAY='" + c + "' and  NGAYGIO >='" + dateTimePicker1.Value.ToString("MM/dd/yyy") + "' and Ngaygio<='" + dateTimePicker2.Value.ToString("MM/dd/yyy") + "'");
            }
            catch { MessageBox.Show("Không thực hiện được vui long kiểm tra lại"); }
        }

        private void cb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    cb_2.DataSource = kn.ExecuteData("select * from View_2 where MASANBAYDI='" + cb_1.SelectedValue + "' ");
            //    cb_2.DisplayMember = "TenSanBay";
            //    cb_2.ValueMember = "MaSanBayden";
            //}
            //catch { }
            cb_2.Text = "";
            cb_2.DataSource = kn.ExecuteData("select MASANBAY, TENSANBAY from TUYENBAY, SANBAY where SANBAY.MASANBAY = TUYENBAY.MASANBAYDEN and MASANBAYDI='" + cb_1.SelectedValue + "' ");
            cb_2.DisplayMember = "TENSANBAY";// hiên thị
            cb_2.ValueMember = "MASANBAY";// giá trị chọn
        }
    }
}
