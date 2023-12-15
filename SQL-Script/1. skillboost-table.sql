/* TẠO DATABASE SkillBoost */
GO
CREATE DATABASE SkillBoost
GO 
USE SkillBoost

-- DROP DATABASE SkillBoost

/*USE CASE 1*/
/* TẠO TABLE NHAN_VIEN */
CREATE TABLE NhanVien(
	MaNV						VARCHAR(10) NOT NULL PRIMARY KEY
	, HoNV						NVARCHAR(15) NOT NULL
	, TenLotNV					NVARCHAR(20) NOT NULL
	, TenNV						NVARCHAR(15) NOT NULL
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
ALTER TABLE NhanVien
ALTER COLUMN TenLotNV NVARCHAR(20) NULL
--DROP TABLE NhanVien

/* TẠO TABLE TaiKhoan */
CREATE TABLE TaiKhoan(
	MaTK						VARCHAR(10) NOT NULL PRIMARY KEY
	, EmailTK					VARCHAR(70) NOT NULL
	, MatKhauTK					VARCHAR(50) NOT NULL
	, MaHashTK					VARCHAR(100) NOT NULL
	, MaSaltTK					VARCHAR(70) NOT NULL
	, TrangThaiTK				NVARCHAR(50) NOT NULL
	, MaNV						VARCHAR(10) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)
-- Foreign Key bảng TaiKhoan
ALTER TABLE TaiKhoan
ADD FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
--DROP TABLE TaiKhoan

/* Use case 2 */
/* TẠO TABLE YeuCauTuVan */
CREATE TABLE YeuCauTuVan(
	MaTuVan						VARCHAR(10) NOT NULL PRIMARY KEY
	, TenLeadYeuCau				NVARCHAR(50) NOT NULL
	, NgaySinhLeadYeuCau		DATE
	, EmailLeadYeuCau			VARCHAR(70) NOT NULL
	, SDTLeadYeuCau				CHAR(10) NOT NULL
	, GhiChuYCTV				NVARCHAR(100)
	, TrangThaiYCTV				NVARCHAR(50) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoiLead				VARCHAR(10) NOT NULL
)
-- Foreign Key bảng YeuCauTuVan
ALTER TABLE YeuCauTuVan
ADD FOREIGN KEY(TaoBoiLead) REFERENCES Lead(MaLead)
--DROP TABLE YeuCauTuVan

/* TẠO TABLE ChiTietKhoaHocThuocYeuCauTuVan */
CREATE TABLE ChiTietKhoaHocThuocYeuCauTuVan(
	MaTuVan		VARCHAR(10) NOT NULL 
	, MaKhoaHoc	VARCHAR(10) NOT NULL 

	CONSTRAINT PKChiTietKhoaHocThuocYeuCauTuVan PRIMARY KEY (MaTuVan, MaKhoaHoc)
)
-- Foreign Key bảng YeuCauTuVan
ALTER TABLE ChiTietKhoaHocThuocYeuCauTuVan
ADD FOREIGN KEY(MaTuVan) REFERENCES YeuCauTuVan(MaTuVan)
ALTER TABLE ChiTietKhoaHocThuocYeuCauTuVan
ADD FOREIGN KEY(MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
--DROP TABLE ChiTietKhoaHocThuocYeuCauTuVan

/* Use case 3 */
/* TẠO TABLE Lead */
CREATE TABLE Lead(
	MaLead						VARCHAR(10) NOT NULL PRIMARY KEY
	, HoLead					NVARCHAR(15) NOT NULL
	, TenLotLead				NVARCHAR(20) NOT NULL
	, TenLead					NVARCHAR(15) NOT NULL
	, GioiTinhLead				NVARCHAR(10) NOT NULL
	, NgaySinhLead				DATE
	, SoDienThoaiLead			CHAR(10) NOT NULL
	, EmailLead					VARCHAR(70) NOT NULL
	, MaNgheNghiep				VARCHAR(10)
	, NguoiPhuTrachLead			VARCHAR(10) NOT NULL
	, TrangThaiLead				NVARCHAR(30) NOT NULL
	, LyDoTrangThaiLead			NVARCHAR(100)
	, NguonLead					VARCHAR(20) NOT NULL
	, GhiChuLead				NVARCHAR(100)
	, LeadTuKHCu				VARCHAR(10)
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)
ALTER TABLE Lead
ALTER COLUMN TenLotLead NVARCHAR(20) NULL
-- Foreign Key bảng Lead
ALTER TABLE Lead
ADD FOREIGN KEY(MaNgheNghiep) REFERENCES NgheNghiep(MaNgheNghiep)
ALTER TABLE Lead
ADD FOREIGN KEY(NguoiPhuTrachLead) REFERENCES NhanVien(MaNV)
ALTER TABLE Lead
ADD FOREIGN KEY(LeadTuKHCu) REFERENCES KhachHang(MaKH)
--DROP TABLE Lead

/* TẠO TABLE HoatDongLead */
CREATE TABLE HoatDongLead(
	MaHDLead					VARCHAR(10) NOT NULL PRIMARY KEY
	, MaLead					VARCHAR(10) NOT NULL
	, TenHDLead					NVARCHAR(100) NOT NULL
	, LoaiHDLead				NVARCHAR(30) NOT NULL
	, HDLeadDuocTaoBoi			NVARCHAR(20) NOT NULL
	, NguoiPhuTrachHDLead		VARCHAR(10) NOT NULL
	, MaEmailDenLead			VARCHAR(10)
	, TaoVaoLuc					DATETIME NOT NULL
)
-- Foreign Key bảng HoatDongLead
ALTER TABLE HoatDongLead
ADD FOREIGN KEY(MaLead) REFERENCES Lead(MaLead)
ALTER TABLE HoatDongLead
ADD FOREIGN KEY(NguoiPhuTrachHDLead) REFERENCES NhanVien(MaNV)
ALTER TABLE HoatDongLead
ADD FOREIGN KEY(MaEmailDenLead) REFERENCES Email(MaEmail)
--DROP TABLE HoatDongLead

/* TẠO TABLE NgheNghiep */
CREATE TABLE NgheNghiep(
	MaNgheNghiep				VARCHAR(10) NOT NULL PRIMARY KEY
	, TenNgheNghiep				NVARCHAR(50) NOT NULL
	, TrangThaiNgheNghiep		NVARCHAR(100) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)
--DROP TABLE NgheNghiep

/* TẠO TABLE BaoGia */
CREATE TABLE BaoGia(
	MaBaoGia					VARCHAR(10) NOT NULL PRIMARY KEY
	, MaLead					VARCHAR(10) NOT NULL
	, MaGiamGia					VARCHAR(10) 
	, MoTaBaoGia				TEXT NOT NULL
	, TrangThaiBaoGia			NVARCHAR(30) NOT NULL
	, TongTien					FLOAT NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)
/*
ALTER TABLE BaoGia
ALTER COLUMN MoTaBaoGia NTEXT
*/

-- Foreign Key bảng BaoGia
ALTER TABLE BaoGia
ADD FOREIGN KEY(MaLead) REFERENCES Lead(MaLead)
ALTER TABLE BaoGia
ADD FOREIGN KEY(MaGiamGia) REFERENCES MaGiamGia(MaGiamGia)
-- DROP TABLE BaoGia

/* TẠO TABLE ChiTietKhoaHocThuocBaoGia */
CREATE TABLE ChiTietKhoaHocThuocBaoGia(
	MaBaoGia		VARCHAR(10) NOT NULL 
	, MaKhoaHoc		VARCHAR(10) NOT NULL 

	CONSTRAINT PKChiTietKhoaHocThuocBaoGia PRIMARY KEY (MaBaoGia, MaKhoaHoc)
)
-- Foreign Key bảng ChiTietKhoaHocThuocBaoGia
ALTER TABLE ChiTietKhoaHocThuocBaoGia
ADD FOREIGN KEY(MaBaoGia) REFERENCES BaoGia(MaBaoGia)
ALTER TABLE ChiTietKhoaHocThuocBaoGia
ADD FOREIGN KEY(MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
--DROP TABLE ChiTietKhoaHocThuocBaoGia

/* Use case 4 */
/* TẠO TABLE QuyDinhGiamGia */
CREATE TABLE QuyDinhGiamGia(
	MaQuyDinhGiamGia			VARCHAR(10) NOT NULL PRIMARY KEY
	, MoTaLoaiGiamGia			NVARCHAR(150) NOT NULL
	, SoLuongKhoaHocDangKy		INT NOT NULL
	, NgheNghiep				NVARCHAR(100)
	, NgayBatDau				DATE
	, NgayKetThuc				DATE
	, PhanTramGiamGiaMacDinh	INT NOT NULL
	, PhanTramGiamGiaToiDa		INT NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)
-- Đổi data type cho cột NgheNghiep
ALTER TABLE QuyDinhGiamGia
ALTER COLUMN NgheNghiep VARCHAR(10)
-- Foreign key cho bảng QuyDinhGiamGia
ALTER TABLE QuyDinhGiamGia
ADD FOREIGN KEY(NgheNghiep) REFERENCES NgheNghiep(MaNgheNghiep)
--DROP TABLE QuyDinhGiamGia

/* TẠO TABLE MaGiamGia */
CREATE TABLE MaGiamGia(
	MaGiamGia					VARCHAR(10) NOT NULL PRIMARY KEY
	, MoTaMaGiamGia				VARCHAR(30) NOT NULL
	, PhamViApDung				NVARCHAR(30) NOT NULL
	, PhanTramGiamGia			INT NOT NULL
	, TrangThaiMaGiamGia		NVARCHAR(30) NOT NULL
	, MaQuyDinhGiamGia			VARCHAR(10) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
)
-- Foreign Key bảng MaGiamGia
ALTER TABLE MaGiamGia
ADD FOREIGN KEY(MaQuyDinhGiamGia) REFERENCES QuyDinhGiamGia(MaQuyDinhGiamGia)
--DROP TABLE MaGiamGia

/* TẠO TABLE ChiTietDoiTuongUuDai */
CREATE TABLE ChiTietDoiTuongUuDai(
	MaGiamGia		VARCHAR(10) NOT NULL 
	, MaLead		VARCHAR(10) NOT NULL 
	, DaApDung		NVARCHAR(20) NOT NULL
	CONSTRAINT PKChiTietDoiTuongUuDai PRIMARY KEY (MaGiamGia, MaLead)
)
-- Foreign Key bảng ChiTietDoiTuongUuDai
ALTER TABLE ChiTietDoiTuongUuDai
ADD FOREIGN KEY(MaGiamGia) REFERENCES MaGiamGia(MaGiamGia)
ALTER TABLE ChiTietDoiTuongUuDai
ADD FOREIGN KEY(MaLead) REFERENCES Lead(MaLead)
--DROP TABLE ChiTietDoiTuongUuDai

/* Use case 5 */
/* TẠO TABLE KhachHang */
CREATE TABLE KhachHang(
	MaKH						VARCHAR(10) NOT NULL PRIMARY KEY
	, HoKH						NVARCHAR(15) NOT NULL
	, TenLotKH					NVARCHAR(20) NOT NULL
	, TenKH						NVARCHAR(15) NOT NULL
	, GioiTinhKH				NVARCHAR(10) NOT NULL
	, NgaySinhKH				DATE
	, SoDienThoaiKH				CHAR(10) NOT NULL
	, EmailKH					VARCHAR(70) NOT NULL
	, MaNgheNghiep				VARCHAR(10)
	, NguoiPhuTrachKH			VARCHAR(10) NOT NULL
	, TrangThaiKH				NVARCHAR(30) NOT NULL
	, LyDoTrangThaiKH			NVARCHAR(100)
	, GhiChuKH					NVARCHAR(100)
	, ChuyenDoiTuMaLead			VARCHAR(10)
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)
ALTER TABLE KhachHang
ALTER COLUMN TenLotKH NVARCHAR(20) NULL
-- Foreign Key bảng KhachHang
ALTER TABLE KhachHang
ADD FOREIGN KEY(MaNgheNghiep) REFERENCES NgheNghiep(MaNgheNghiep)
ALTER TABLE KhachHang
ADD FOREIGN KEY(NguoiPhuTrachKH) REFERENCES NhanVien(MaNV)
ALTER TABLE KhachHang
ADD FOREIGN KEY(ChuyenDoiTuMaLead) REFERENCES Lead(MaLead)
--DROP TABLE KhachHang

/* TẠO TABLE HoatDongKH */
CREATE TABLE HoatDongKH(
	MaHDKH						VARCHAR(10) NOT NULL PRIMARY KEY
	, MaKH						VARCHAR(10) NOT NULL
	, TenHDKH					NVARCHAR(200) NOT NULL
	, LoaiHDKH					NVARCHAR(30) NOT NULL
	, HDKHDuocTaoBoi			NVARCHAR(30) NOT NULL
	, NguoiPhuTrachHDKH			VARCHAR(10) NOT NULL
	, MaEmailDenKH				VARCHAR(10)
	, TaoVaoLuc					DATETIME NOT NULL
)
-- Foreign Key bảng HoatDongLead
ALTER TABLE HoatDongKH
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
ALTER TABLE HoatDongKH
ADD FOREIGN KEY(NguoiPhuTrachHDKH) REFERENCES NhanVien(MaNV)
ALTER TABLE HoatDongKH
ADD FOREIGN KEY(MaEmailDenKH) REFERENCES Email(MaEmail)
--DROP TABLE HoatDongKH

/* Use case 6 */
/* TẠO TABLE KhoaHoc */
CREATE TABLE KhoaHoc(
	MaKhoaHoc					VARCHAR(10) NOT NULL PRIMARY KEY
	, TenKhoaHoc				NVARCHAR(100) NOT NULL
	, MoTaKhoaHoc				TEXT NOT NULL
	, ThoiLuongKhoaHoc			NVARCHAR(20) NOT NULL
	, GiangVien					NVARCHAR(20) NOT NULL
	, MucDoKhoaHoc				NVARCHAR(30) NOT NULL
	, SoLuongHocVienToiDa		INT NOT NULL
	, HocPhi					FLOAT NOT NULL
	, NgayKhaiGiang				DATE NOT NULL
	, NgayBeGiang				DATE NOT NULL
	, DanhGiaKhoaHoc			FLOAT NOT NULL
	, TrangThaiKhoaHoc			NVARCHAR(30) NOT NULL
	, MaLoaiKhoaHoc				VARCHAR(10) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)
-- Foreign Key bảng KhoaHoc
ALTER TABLE KhoaHoc
ADD FOREIGN KEY(MaLoaiKhoaHoc) REFERENCES LoaiKhoaHoc(MaLoaiKhoaHoc)
--DROP TABLE KhoaHoc

/* TẠO TABLE LoaiKhoaHoc */
CREATE TABLE LoaiKhoaHoc(
	MaLoaiKhoaHoc				VARCHAR(10) NOT NULL PRIMARY KEY
	, TenLoaiKhoaHoc			VARCHAR(10) NOT NULL
	, TrangThaiLoaiKhoaHoc		NVARCHAR(30) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL 
)
--DROP TABLE LoaiKhoaHoc

/* Use case 7 */
/* TẠO TABLE Email */
CREATE TABLE Email(
	MaEmail						VARCHAR(10) NOT NULL PRIMARY KEY
	, TieuDeEmail				NVARCHAR(200) NOT NULL
	, NoiDungEmail				TEXT NOT NULL
	, LichGuiEmail				DATETIME NOT NULL
	, NguoiNhan					NVARCHAR(50) NOT NULL
	, TrangThaiEmail			NVARCHAR(30) NOT NULL
	, MaYCTV					VARCHAR(10)
	, MaBaoGia					VARCHAR(10)
	, MaHoaDon					VARCHAR(10)
	, MaEmailMau				VARCHAR(10) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL  
)
-- Foreign Key bảng Email
ALTER TABLE Email
ADD FOREIGN KEY(MaYCTV) REFERENCES YeuCauTuVan(MaTuVan)
ALTER TABLE Email
ADD FOREIGN KEY(MaBaoGia) REFERENCES BaoGia(MaBaoGia)
ALTER TABLE Email
ADD FOREIGN KEY(MaHoaDon) REFERENCES HoaDon(MaHoaDon)
ALTER TABLE Email
ADD FOREIGN KEY(MaEmailMau) REFERENCES EmailMau(MaEmailMau)
--DROP TABLE Email

/* TẠO TABLE EmailMau */
CREATE TABLE EmailMau(
	MaEmailMau					VARCHAR(10) NOT NULL PRIMARY KEY
	, TieuDeEmailMau			NVARCHAR(200) NOT NULL
	, NoiDungEmailMau			TEXT NOT NULL
	, MoTaEmailMau				TEXT NOT NULL
	, TrangThaiEmailMau			NVARCHAR(30) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL  
)
--DROP TABLE EmailMau

/* Use case 8 */
/* TẠO TABLE HoaDon */
CREATE TABLE HoaDon(
	MaHoaDon					VARCHAR(10) NOT NULL PRIMARY KEY
	, MaBaoGia					VARCHAR(10) NOT NULL
	, TenKH						NVARCHAR(50) NOT NULL
	, ThoiDiemThanhToan			DATETIME NOT NULL
	, MoTaHoaDon				NVARCHAR(200) NOT NULL
	, TongHoaDon				FLOAT NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
)
-- Foreign Key bảng HoaDon
ALTER TABLE HoaDon
ADD FOREIGN KEY(MaBaoGia) REFERENCES BaoGia(MaBaoGia)
--DROP TABLE HoaDon

/* TẠO TABLE ChiTietKhoaHocThuocHoaDon */
CREATE TABLE ChiTietKhoaHocThuocHoaDon(
	MaHoaDon		VARCHAR(10) NOT NULL 
	, MaKhoaHoc		VARCHAR(10) NOT NULL 

	CONSTRAINT PKChiTietKhoaHocThuocHoaDon PRIMARY KEY (MaHoaDon, MaKhoaHoc)
)
-- Foreign Key bảng ChiTietKhoaHocThuocHoaDon
ALTER TABLE ChiTietKhoaHocThuocHoaDon
ADD FOREIGN KEY(MaHoaDon) REFERENCES HoaDon(MaHoaDon)
ALTER TABLE ChiTietKhoaHocThuocHoaDon
ADD FOREIGN KEY(MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
