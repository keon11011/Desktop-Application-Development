﻿/* TẠO DATABASE SkillBoost */
GO
CREATE DATABASE SkillBoost

GO 
USE SkillBoost

/*USE CASE 1*/
/* TẠO TABLE NHAN_VIEN */
CREATE TABLE NhanVien(
	STT INT IDENTITY(0,1)
	, MaNV AS 'STA' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, HoTenNV					NVARCHAR(70) NOT NULL
	, GioiTinhNV				NVARCHAR(10) NOT NULL
	, NgaySinhNV				DATE
	, ChucVu					NVARCHAR(20) NOT NULL
	, SoDienThoaiNV				CHAR(10) NOT NULL
	, EmailNV					VARCHAR(70) NOT NULL
	, TrangThaiNV				NVARCHAR(30) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)


/* TẠO TABLE TaiKhoan */
CREATE TABLE TaiKhoan(
	STT INT IDENTITY(1,1)
	, MaTK AS 'ACC' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, EmailTK					VARCHAR(70) NOT NULL
	, MatKhauTK					VARCHAR(50) NOT NULL
	, MaHashTK					BINARY(64) 
	, MaSaltTK					UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID()
	, TrangThaiTK				NVARCHAR(50) NOT NULL
	, MaNV						VARCHAR(13) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* Use case 2 */
/* TẠO TABLE YeuCauTuVan */
CREATE TABLE YeuCauTuVan(
	STT INT IDENTITY(1,1)
	, MaTuVan AS 'CON' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, TenLeadYeuCau				NVARCHAR(50) NOT NULL
	, NgaySinhLeadYeuCau		DATE NOT NULL
	, EmailLeadYeuCau			VARCHAR(70) NOT NULL
	, SDTLeadYeuCau				CHAR(10) NOT NULL
	, GhiChuYCTV				NVARCHAR(100)
	, TrangThaiYCTV				NVARCHAR(50) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoiLead				VARCHAR(13) NOT NULL
)

/* TẠO TABLE ChiTietKhoaHocThuocYeuCauTuVan */
CREATE TABLE ChiTietKhoaHocThuocYeuCauTuVan(
	MaTuVan			VARCHAR(13) NOT NULL 
	, MaKhoaHoc		VARCHAR(13) NOT NULL 
	, TenKhoaHoc	NVARCHAR(100) NOT NULL
	, GiangVien		NVARCHAR(20) NOT NULL
	, GiaTien		FLOAT NOT NULL

	CONSTRAINT PK_ChiTietKhoaHocThuocYeuCauTuVan PRIMARY KEY (MaTuVan, MaKhoaHoc)
)

/* Use case 3 */
/* TẠO TABLE Lead */
CREATE TABLE Lead(
	STT INT IDENTITY(1,1)
	, MaLead AS 'LEA' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, HoTenLead					NVARCHAR(70) NOT NULL
	, GioiTinhLead				NVARCHAR(10)
	, NgaySinhLead				DATE
	, SoDienThoaiLead			CHAR(10) NOT NULL
	, EmailLead					VARCHAR(70) NOT NULL
	, MaNgheNghiep				VARCHAR(13)
	, TenNgheNghiep				NVARCHAR(50)
	, MaNVPhuTrachLead			VARCHAR(13) NOT NULL
	, TenNVPhuTrachLead			NVARCHAR(50) NOT NULL
	, TrangThaiLead				NVARCHAR(30) NOT NULL
	, LyDoTrangThaiLead			NVARCHAR(100)
	, NguonLead					VARCHAR(20) NOT NULL
	, GhiChuLead				NVARCHAR(100)
	, LeadTuKHCu				VARCHAR(13)
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE HoatDongLead */
CREATE TABLE HoatDongLead(
	STT INT IDENTITY(1,1)
	, MaHDLead AS 'LAC' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, MaLead					VARCHAR(13) NOT NULL
	, TenHDLead					NVARCHAR(100) NOT NULL
	, LoaiHDLead				NVARCHAR(30) NOT NULL
	, HDLeadDuocTaoBoi			NVARCHAR(20) NOT NULL
	, MaNVPhuTrachHDLead		VARCHAR(13) NOT NULL
	, TenNVPhuTrachHDLead		NVARCHAR(50) NOT NULL
	, MaEmailDenLead			VARCHAR(13)
	, TaoVaoLuc					DATETIME NOT NULL
)

/* TẠO TABLE NgheNghiep */
CREATE TABLE NgheNghiep(
	STT INT IDENTITY(1,1)
	, MaNgheNghiep AS 'OCU' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, TenNgheNghiep				NVARCHAR(100) NOT NULL
	, TrangThaiNgheNghiep		NVARCHAR(100) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE BaoGia */
CREATE TABLE BaoGia(
	STT INT IDENTITY(1,1)
	, MaBaoGia AS 'QUO' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, TenBaoGia					NVARCHAR(255) NOT NULL
	, MaLead					VARCHAR(13) NOT NULL
	, HoTenLead					NVARCHAR(70) NOT NULL
	, TongTienTruocGiam			FLOAT NOT NULL
	, MaGiamGia					VARCHAR(13) 
	, PhanTramGiamGia			INT 
	, TongTien					FLOAT NOT NULL
	, TrangThaiBaoGia			NVARCHAR(30) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE ChiTietKhoaHocThuocBaoGia */
CREATE TABLE ChiTietKhoaHocThuocBaoGia(
	MaBaoGia		VARCHAR(13) NOT NULL 
	, MaKhoaHoc		VARCHAR(13) NOT NULL 
	, TenKhoaHoc	NVARCHAR(100) NOT NULL
	, GiangVien		NVARCHAR(20) NOT NULL
	, GiaTien		FLOAT NOT NULL

	CONSTRAINT PK_ChiTietKhoaHocThuocBaoGia PRIMARY KEY (MaBaoGia, MaKhoaHoc)
)

/* Use case 4 */
/* TẠO TABLE QuyDinhGiamGia */
CREATE TABLE QuyDinhGiamGia(
	STT INT IDENTITY(1,1)
	, MaQuyDinhGiamGia AS 'DIS' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, MoTaLoaiGiamGia			NVARCHAR(150) NOT NULL
	, SoLuongKhoaHocDangKy		INT NOT NULL
	, MaNgheNghiep				VARCHAR(13)  
	, TenNgheNghiep				NVARCHAR(100) 
	, NgayBatDau				DATE
	, NgayKetThuc				DATE
	, PhanTramGiamGiaMacDinh	INT NOT NULL
	, PhanTramGiamGiaToiDa		INT NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, TaoBoiNV					NVARCHAR(50) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE MaGiamGia */
CREATE TABLE MaGiamGia(
	STT INT IDENTITY(1,1)
	, MaGiamGia AS 'DIC' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, MoTaMaGiamGia				VARCHAR(30) NOT NULL
	, PhamViApDung				NVARCHAR(50) NOT NULL
	, PhanTramGiamGia			INT NOT NULL
	, TrangThaiMaGiamGia		NVARCHAR(30) NOT NULL
	, MaQuyDinhGiamGia			VARCHAR(13) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
)

/* TẠO TABLE ChiTietDoiTuongUuDai */
CREATE TABLE ChiTietDoiTuongUuDai(
	MaGiamGia		VARCHAR(13) NOT NULL 
	, MaLead		VARCHAR(13) NOT NULL 
	, DaApDung		NVARCHAR(20) NOT NULL
	CONSTRAINT PK_ChiTietDoiTuongUuDai PRIMARY KEY (MaGiamGia, MaLead)
)

/* Use case 5 */
/* TẠO TABLE KhachHang */
-- thay đổi tương tự Lead
CREATE TABLE KhachHang(
	STT INT IDENTITY(1,1)
	, MaKH AS 'CUS' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, HoTenKH					NVARCHAR(70) NOT NULL
	, GioiTinhKH				NVARCHAR(10)
	, NgaySinhKH				DATE
	, SoDienThoaiKH				CHAR(10) NOT NULL
	, EmailKH					VARCHAR(70) NOT NULL
	, MaNgheNghiep				VARCHAR(13)
	, TenNgheNghiep				NVARCHAR(50)
	, MaNVPhuTrachKH			VARCHAR(13) NOT NULL
	, TenNVPhuTrachKH			NVARCHAR(50) NOT NULL
	, TrangThaiKH				NVARCHAR(30) NOT NULL
	, LyDoTrangThaiKH			NVARCHAR(100)
	, GhiChuKH					NVARCHAR(100)
	, ChuyenDoiTuMaLead			VARCHAR(13)
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE HoatDongKH */
CREATE TABLE HoatDongKH(
	STT INT IDENTITY(1,1)
	, MaHDKH AS 'CA' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, MaKH						VARCHAR(13) NOT NULL
	, TenHDKH					NVARCHAR(200) NOT NULL
	, LoaiHDKH					NVARCHAR(30) NOT NULL
	, HDKHDuocTaoBoi			NVARCHAR(30) NOT NULL
	, MaNVPhuTrachHDKH			VARCHAR(13) NOT NULL
	, TenNVPhuTrachHDKH			NVARCHAR(50) NOT NULL
	, MaEmailDenKH				VARCHAR(13)
	, TaoVaoLuc					DATETIME NOT NULL
)

/* Use case 6 */
/* TẠO TABLE KhoaHoc */
CREATE TABLE KhoaHoc(
	STT INT IDENTITY(1,1)
	, MaKhoaHoc AS 'CRS' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, TenKhoaHoc				NVARCHAR(100) NOT NULL
	, MoTaKhoaHoc				NTEXT NOT NULL
	, ThoiLuongKhoaHoc			NVARCHAR(20) NOT NULL
	, GiangVien					NVARCHAR(20) NOT NULL
	, MucDoKhoaHoc				NVARCHAR(30) NOT NULL
	, SoLuongHocVienToiDa		INT NOT NULL
	, GiaTien					FLOAT NOT NULL
	, NgayKhaiGiang				DATE NOT NULL
	, NgayBeGiang				DATE NOT NULL
	, DanhGiaKhoaHoc			FLOAT NOT NULL
	, TrangThaiKhoaHoc			NVARCHAR(30) NOT NULL
	, MaLoaiKhoaHoc				VARCHAR(13) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE LoaiKhoaHoc */
CREATE TABLE LoaiKhoaHoc(
	STT INT IDENTITY(1,1)
	, MaLoaiKhoaHoc AS 'CID' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, TenLoaiKhoaHoc			NVARCHAR(30) NOT NULL
	, TrangThaiLoaiKhoaHoc		NVARCHAR(30) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL 
)

/* Use case 7 */
/* TẠO TABLE Email */
CREATE TABLE Email(
	STT INT IDENTITY(1,1)
	, MaEmail AS 'EML' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, TieuDeEmail				NVARCHAR(200) NOT NULL
	, NoiDungEmail				NTEXT NOT NULL
	, LichGuiEmail				DATETIME NOT NULL
	, NguoiNhan					NVARCHAR(50) NOT NULL
	, TrangThaiEmail			NVARCHAR(30) NOT NULL
	, MaYCTV					VARCHAR(13)
	, MaBaoGia					VARCHAR(13)
	, MaHoaDon					VARCHAR(13)
	, MaEmailMau				VARCHAR(13) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL  
)

/* TẠO TABLE EmailMau */
CREATE TABLE EmailMau(
	STT INT IDENTITY(1,1)
	, MaEmailMau AS 'EMT' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, TieuDeEmailMau			NVARCHAR(200) NOT NULL
	, MoTaEmailMau				NTEXT NOT NULL
	, NoiDungEmailMau			NTEXT NOT NULL
	, TrangThaiEmailMau			NVARCHAR(30) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL  
)

/* Use case 8 */
/* TẠO TABLE HoaDon */
CREATE TABLE HoaDon(
	STT INT IDENTITY(1,1)
	, MaHoaDon AS 'INV' + CAST(STT AS VARCHAR(10)) PERSISTED NOT NULL PRIMARY KEY
	, MoTaHoaDon				NVARCHAR(200) NOT NULL
	, TenKH						NVARCHAR(50) NOT NULL
	, ThoiDiemThanhToan			DATETIME NOT NULL
	, TongHoaDon				FLOAT NOT NULL
	, MaBaoGia					VARCHAR(13) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
)

/* TẠO TABLE ChiTietKhoaHocThuocHoaDon */
CREATE TABLE ChiTietKhoaHocThuocHoaDon(
	MaHoaDon		VARCHAR(13) NOT NULL 
	, MaKhoaHoc		VARCHAR(13) NOT NULL 
	, TenKhoaHoc	NVARCHAR(100) NOT NULL
	, GiangVien		NVARCHAR(20) NOT NULL
	, GiaTien		FLOAT NOT NULL

	CONSTRAINT PK_ChiTietKhoaHocThuocHoaDon PRIMARY KEY (MaHoaDon, MaKhoaHoc)
)
