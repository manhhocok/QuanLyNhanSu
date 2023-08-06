Create database QLNhanSu
CREATE TABLE PHONGBAN(          
           MaPB varchar(50) NOT NULL PRIMARY KEY,
	TenPB nvarchar(50) NOT NULL,
	SđtPB char(12) NOT NULL,
	DiaChiPB nvarchar(50) );
-- Tạo bảng HỢP ĐỒNG
CREATE TABLE HOPDONG(         
           MaHD varchar(50) NOT NULL PRIMARY KEY,
	LoaiHD nvarchar(50) NOT NULL,
	GhiChu nvarchar(100) NULL  );
-- Tạo bảng BẢNG CÔNG
CREATE TABLE BANGCONG(
	MaBC varchar(50) NOT NULL PRIMARY KEY,
	TenBC nvarchar(50) NOT NULL,
	Thang int NOT NULL,
	Nam int NOT NULL,
	SoNgayCong int NOT NULL);
-- Tạo bảng BẢO HIỂM
CREATE TABLE BAOHIEM(
	MaBH varchar(50) NOT NULL PRIMARY KEY,
	LoaiBH nvarchar(50) NOT NULL,
	NgayCapBH date NOT NULL,
	NoiCapBH nvarchar(50) NOT NULL);
-- Tạo bảng CHỨC VỤ
CREATE TABLE CHUCVU(
	MaCV varchar(50) NOT NULL PRIMARY KEY,
	TenCV nvarchar(50) NOT NULL);
-- Tạo bảng TRÌNH ĐỘ HỌC VẤN
CREATE TABLE TRINHDOHOCVAN(
	MaTDHV varchar(50) NOT NULL PRIMARY KEY ,
	TenTDHV nvarchar(50) NOT NULL,
	ChuyenNganh nvarchar(50));
-- Tạo bảng LƯƠNG
CREATE TABLE LUONG(
	BacL char(10) NOT NULL PRIMARY KEY,
	LuongcoBan real NOT NULL,
	Phucap real,
	MaBH varchar(50) foreign key references BAOHIEM(MaBH));
-- Tạo bảng NHÂN VIÊN
CREATE TABLE NHANVIEN(
	MaNV varchar(50) NOT NULL PRIMARY KEY,
	HoTenNV nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL,
	GioiTinh nvarchar(5) NOT NULL,
	Quequan nvarchar(50) NOT NULL,
	SdtNV int NOT NULL,
	DanToc nvarchar(50) NOT NULL,
	QuocTich nvarchar(50) NOT NULL,
	MaPB varchar(50) foreign key references PHONGBAN(MaPB),
	MaHD varchar(50) foreign key references HOPDONG(MaHD),
	MaTDHV varchar(50) foreign key references TRINHDOHOCVAN(MaTDHV),
	MaBC varchar(50) foreign key references BANGCONG(MaBC),
	BacL char(10) foreign key references LUONG(BacL),
	MaCV varchar(50) foreign key references CHUCVU(MaCV));
CREATE TABLE Thoigiancongtac(
           MaNV varchar(50) NOT NULL,
	MaCV varchar(50) NOT NULL,
	NgayNhanChuc date,
	foreign key (MaNV) references NHANVIEN(MaNV),
	foreign key (MaCV) references CHUCVU(MaCV)
);
-- QLNhanSu