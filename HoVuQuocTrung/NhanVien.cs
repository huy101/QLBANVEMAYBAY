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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        Connection ketnoi = new Connection(); // khai bao doi tuong trong class ket noi

        public int INSERT(string MANV, string TENNV, string DIENTHOAI, string DIACHI, string MATKHAU)
        {
            string sql = "INSERT INTO NHANVIEN(manv,tennv,dienthoai,diachi,matkhau) VALUES (N'" + MANV + "',N'" + TENNV + "',N'" + DIENTHOAI + "',N'" + DIACHI + "',N'" + MATKHAU + "')";
            // sql la câu lệnh truy vấn INSERT INTO để lưu dữ liệu vào bảng nhân viên
            return ketnoi.ExecuteNonQuery(sql);// gọi hàm ExecuteNonQuery để lưu
        }
        public int UPDATE(string MANV, string TENNV, string DIENTHOAI, string DIACHI)
        {
            string sql = "UPDATE NHANVIEN SET tennv=N'" + TENNV + "', dienthoai=N'" + DIENTHOAI + "', diachi=N'" + DIACHI + "' WHERE manv=N'" + MANV + "'";
            return ketnoi.ExecuteNonQuery(sql);// ExecuteNonQuery nằm trong classs Connection
        }
        public int Delete(string MANV)
        {
            string sql = "DELETE FROM NHANVIEN WHERE manv=N'" + MANV + "'";// cau lênh sql xóa truyền vào mã để xóa
            return ketnoi.ExecuteNonQuery(sql);
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ketnoi.ExecuteData("select manv, tennv, dienthoai, diachi from NHANVIEN");// load tất cả dữ liệu lên khi mới mở form
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try  // BẮT LỖI TỰ ĐỘNG TRÁNH BỊ LỖI PM
            {
                txt_manv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //MANV là cột 0 có  thể dùng dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_tennv.Text = dataGridView1.CurrentRow.Cells["TENNV"].Value.ToString();//"TENNV"
                txt_dienthoai.Text = dataGridView1.CurrentRow.Cells["DIENTHOAI"].Value.ToString();//"DIACHI"

                txt_diachi.Text = dataGridView1.CurrentRow.Cells["Diachi"].Value.ToString();//"Diachi"
            }
            catch (Exception j) { MessageBox.Show(j.Message); }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (INSERT(txt_manv.Text, txt_tennv.Text, txt_dienthoai.Text, txt_diachi.Text, "123456789") != -1)
            {
                MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (UPDATE(txt_manv.Text, txt_tennv.Text, txt_dienthoai.Text, txt_diachi.Text) != -1)
            {
                MessageBox.Show("Đã cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(new object(), new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_themmoi_Click(object sender, EventArgs e)
        {
            txt_tennv.Clear();
            txt_diachi.Clear();
            txt_manv.Clear();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "")
            {
                if (MessageBox.Show("Bạn muốn xóa nhân viên: " + txt_tennv.Text, "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Delete(txt_manv.Text) != -1)
                    {
                        MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NhanVien_Load(new object(), new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
