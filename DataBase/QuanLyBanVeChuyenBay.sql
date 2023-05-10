create database QuanLyBanVeMayBay
go

use QuanLyBanVeMayBay
go

create table CHUYENBAY
(
	MaChuyenBay nvarchar(50),
	MaTuyenBay nvarchar(50),
	NgayGio datetime,
	ThoiGianBay float,
	SoLuongGheHang1 int,
	SoLuongGheHang2 int,
	constraint pk_chuyenbay primary key (MaChuyenBay),
)
go

create table TUYENBAY
(
	MaTuyenBay nvarchar(50),
	SanBayDi nvarchar(50),
	SanBayDen nvarchar(50),
	constraint pk_tuyenbay primary key (MaTuyenBay),
)
go

create table CHITIETCHUYENBAY
(
	MaChiTietChuyenBay nvarchar(50),
	MaChuyenBay nvarchar(50),
	SanBayTrungGian nvarchar(50),
	ThoiGianDung float,
	constraint pk_chitietchuyenbay primary key (MaChiTietChuyenBay),
)
go

create table TINHTRANGVE
(
	MaTinhTrangVe nvarchar(50),
	MaChuyenBay nvarchar(50),
	MaHangVe nvarchar(50),
	SoGheTrong int,
	SoGheDat int,
	constraint pk_tinhtrangve primary key (MaTinhTrangVe),
)
go

create table DONGIA
(
	MaDonGia nvarchar(50),
	MaTuyenBay nvarchar(50),
	MaHangVe nvarchar(50),
	DonGia float,
	constraint pk_dongia primary key (MaDonGia),
)
go

create table SANBAY
(
	MaSanBay nvarchar(50),
	TenSanBay nvarchar(50),
	constraint pk_sanbay primary key (MaSanBay),
)
go

create table VECHUYENBAY
(
	MaVe nvarchar(50),
	MaChuyenBay nvarchar(50),
	MaHangVe nvarchar(50),
	MaHanhKhach nvarchar(50),
	GiaTien float,
	constraint pk_vechuyenbay primary key (MaVe),
)
go

create table HANGVE
(
	MaHangVe nvarchar(50),
	TenHangVe nvarchar(50),
	constraint pk_hangve primary key (MaHangVe),
)
go

create table CTDOANHTHUTHANG
(
	MaCTDoanhThuThang nvarchar(50),
	MaDoanhThuThang nvarchar(50),
	MaChuyenBay nvarchar(50),
	SoVe int,
	TyLe float,
	DoanhThu float,
	constraint pk_ctdoanhthuthang primary key (MaCTDoanhThuThang),
)
go
 
create table HANHKHACH
(
	MaHanhKhach nvarchar(50),
	TenHanhKhach nvarchar(50),
	CMND nvarchar(50),
	DienThoai nvarchar(50),
	constraint pk_hanhkhach primary key (MaHanhKhach),
)
go

create table DOANHTHUNAM
(
	MaDoanhThuNam nvarchar(50),
	Nam int,
	TongDoanhThuNam float,
	constraint pk_doanhthunam primary key (MaDoanhThuNam),
)
go

create table DOANHTHUTHANG
(
	MaDoanhThuThang nvarchar(50),
	Thang int,
	MaDoanhThuNam nvarchar(50),
	SoChuyenBay int,
	TyLe float,
	TongDoanhThuThang float,
	constraint pk_doanhthuthang primary key (MaDoanhThuThang),
)
go

create table PHIEUDATCHO
(
	MaPhieuDat nvarchar(50),
	MaChuyenBay nvarchar(50),
	MaHanhKhach nvarchar(50),
	MaHangVe nvarchar(50),
	GiaTien float,
	NgayDat datetime,
	constraint pk_phieudatcho primary key (MaPhieuDat),
)
go

create table THAMSO
(
	ThoiGianBayToiThieu float, 
	SoSanBayTrungGianToiDa float,
	ThoiGianDungToiThieu float,
	ThoiGianDungToiDa float,
	ThoiGianChamNhatDatVe float,
	ThoiGianChamNhatHuyVe float,
)
go

alter table CHUYENBAY add 
	constraint fk_chuyenbay_tuyenbay foreign key (MaTuyenBay) references TUYENBAY(MaTuyenBay)

alter table TUYENBAY add
	constraint fk_tuyenbay_sanbaydi foreign key (SanBayDi) references SANBAY(MaSanBay),
	constraint fk_tuyenbay_sanbayden foreign key (SanBayDen) references SANBAY(MaSanBay)
go

alter table CHITIETCHUYENBAY add
	constraint fk_chitiettuyenbay_chuyenbay foreign key (MaChuyenBay) references CHUYENBAY(MaChuyenBay),
	constraint fk_chitiettuyenbay_sanbay foreign key (SanBayTrungGian) references SANBAY(MaSanBay)
go

alter table TINHTRANGVE add
	constraint fk_tinhtrangve_chuyenbay foreign key (MaChuyenBay) references CHUYENBAY(MaChuyenBay),
	constraint fk_tinhtrangve_hangve foreign key (MaHangVe) references HANGVE(MaHangVe)
go

alter table DONGIA add
	constraint fk_dongia_tuyenbay foreign key (MaTuyenBay) references TUYENBAY(MaTuyenBay),
	constraint fk_dongia_hangve foreign key (MaHangVe) references HANGVE(MaHangVe)

alter table VECHUYENBAY add
	constraint fk_vechuyenbay_chuyenbay foreign key (MaChuyenBay) references CHUYENBAY(MaChuyenBay),
	constraint fk_vechuyenbay_hangve foreign key (MaHangVe) references HANGVE(MaHangVe),
	constraint fk_vechuyenbay_hanhkhach foreign key (MaHanhKhach) references HANHKHACH(MaHanhKhach)

alter table CTDOANHTHUTHANG add
	constraint fk_ctdoanhthuthang_chuyenbay foreign key (MaChuyenBay) references CHUYENBAY(MaChuyenBay),
	constraint fk_ctdoanhthuthang_doanhthuthang foreign key (MaDoanhThuThang) references DOANHTHUTHANG(MaDoanhThuThang)

alter table DOANHTHUTHANG add
	constraint fk_doanhthuthang_doanhthunam foreign key (MaDoanhThuNam) references DOANHTHUNAM(MaDoanhThuNam)

alter table PHIEUDATCHO add
	constraint fk_phieudatcho_chuyenbay foreign key (MaChuyenBay) references CHUYENBAY(MaChuyenBay),
	constraint fk__phieudatcho_hangve foreign key (MaHangVe) references HANGVE(MaHangVe),
	constraint fk_phieudatcho_hanhkhach foreign key (MaHanhKhach) references HANHKHACH(MaHanhKhach)
	