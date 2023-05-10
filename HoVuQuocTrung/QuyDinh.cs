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
    public partial class QuyDinh : Form
    {
        public QuyDinh()
        {
            InitializeComponent();
        }

        private void bnt_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Connection ketnoi = new Connection();
        private void frm_Thongso1_Load(object sender, EventArgs e)
        {
            DataTable dulieu = ketnoi.ExecuteData("select * from THAMSO");

            txt_1.Text = dulieu.Rows[0]["ThoiGianBayToiThieu"].ToString();
            txt_2.Text = dulieu.Rows[0]["SoSanBayTrungGianToiDa"].ToString();
            txt_3.Text = dulieu.Rows[0]["ThoiGianDungToiThieu"].ToString();
            txt_4.Text = dulieu.Rows[0]["ThoiGianDungToiDa"].ToString();
            textBox1.Text = dulieu.Rows[0]["TGChamNhatDatVe"].ToString();
            textBox2.Text = dulieu.Rows[0]["TGChamNhatHuyDatVe"].ToString();
        }

        public void UPDATE_THAMSO(int ThoiGianBayToiThieu, int SoSanBayTrungGianToiDa, int ThoiGianDungToiThieu, int ThoiGianDungToiDa, int TGChamNhatDatVe, int TGChamNhatHuyDatVe)
        {

            string sql = "UPDATE THAMSO SET [ThoiGianBayToiThieu]=" + ThoiGianBayToiThieu + ",[SoSanBayTrungGianToiDa]=" + SoSanBayTrungGianToiDa + ",[ThoiGianDungToiThieu]=" + ThoiGianDungToiThieu + ",[ThoiGianDungToiDa]=" + ThoiGianDungToiDa + ",[TGChamNhatDatVe]=" + TGChamNhatDatVe + ",[TGChamNhatHuyDatVe]=" + TGChamNhatHuyDatVe + "";
            ketnoi.ExecuteNonQuery(sql);

        }

        private void bnt_1_Click(object sender, EventArgs e)
        {
            UPDATE_THAMSO(int.Parse(txt_1.Text), int.Parse(txt_2.Text), int.Parse(txt_3.Text), int.Parse(txt_4.Text), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            MessageBox.Show("Đã cập nhật thành công !", "Thông báo");
        }
    }
}
