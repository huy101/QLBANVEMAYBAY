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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string manv = "";

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        string tennv = "";

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            toolStripLabel3.Text = tennv;
            //frm_SanBay vn = new frm_SanBay(); // khởi tạo đối tượng form 1 để gọi lên 
            //vn.TopLevel = false;//gán  toplevel bằng false mới add dc

            //panel1.Controls.Add(vn); // add vào cái khung chứa 
            //vn.Show();
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien.ShowDialog();
        }

        private void MenuTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuChuyenBay tracuu = new TraCuuChuyenBay();
            tracuu.ShowDialog();
        }

        private void MenuGiaVeChuyenBay_Click(object sender, EventArgs e)
        {
            QuanLyGia giave = new QuanLyGia();
            giave.ShowDialog();
        }

        private void MenuVeChuyenBay_Click(object sender, EventArgs e)
        {
            VeChuyenBay vechuyenbay = new VeChuyenBay();
            vechuyenbay.ShowDialog();

        }

        private void MenuDatCho_Click(object sender, EventArgs e)
        {
            DatCho phieudat = new DatCho();
            phieudat.ShowDialog();
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MenuQuanLyHangKhach_Click(object sender, EventArgs e)
        {
            HangKhach hk = new HangKhach();
            hk.ShowDialog();
        }

        private void MenuTuyenBay_Click(object sender, EventArgs e)
        {
            TuyenBay tuyenbay = new TuyenBay();
            tuyenbay.ShowDialog();
        }

        private void MenuQuyDinh_Click(object sender, EventArgs e)
        {
            QuyDinh quydinh = new QuyDinh();
            quydinh.ShowDialog();
        }

        private void MenuLichBay_Click(object sender, EventArgs e)
        {
            LichBay lichchuyen = new LichBay();
            lichchuyen.ShowDialog();
        }

        private void MenuHangVe_Click(object sender, EventArgs e)
        {
            HangVe themhangve = new HangVe();
            themhangve.ShowDialog();
        }

        private void MenuSanBay_Click(object sender, EventArgs e)
        {
            SanBay sanbay = new SanBay();
            sanbay.ShowDialog();
        }

        private void MenuDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau doimatkhau = new DoiMatKhau();
            doimatkhau.manv = this.manv;
            doimatkhau.tennv = this.tennv;
            doimatkhau.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtdongho.Text = DateTime.Now.ToShortTimeString();
        }

        private void MenuDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThuThang doanhthuthang = new DoanhThuThang();
            doanhthuthang.ShowDialog();
        }

        private void quảnLýLịchBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichBay lichchuyen = new LichBay();
            lichchuyen.ShowDialog();
        }

        private void véChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeChuyenBay vechuyenbay = new VeChuyenBay();
            vechuyenbay.ShowDialog();
        }

        private void hạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangVe themhangve = new HangVe();
            themhangve.ShowDialog();
        }

        private void máyBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayBay mb = new MayBay();
            mb.ShowDialog();
        }
    }
}
