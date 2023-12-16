/* TẠO DATABASE SkillBoost */
GO
CREATE DATABASE SkillBoost

GO 
USE SkillBoost

/*USE CASE 1*/
/* TẠO TABLE NHAN_VIEN */
CREATE TABLE NhanVien(
	MaNV						VARCHAR(10) NOT NULL PRIMARY KEY
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

/* Use case 2 */
/* TẠO TABLE YeuCauTuVan */
CREATE TABLE YeuCauTuVan(
	MaTuVan						VARCHAR(10) NOT NULL PRIMARY KEY
	, TenLeadYeuCau				NVARCHAR(50) NOT NULL
	, NgaySinhLeadYeuCau		DATE NOT NULL
	, EmailLeadYeuCau			VARCHAR(70) NOT NULL
	, SDTLeadYeuCau				CHAR(10) NOT NULL
	, GhiChuYCTV				NVARCHAR(100)
	, TrangThaiYCTV				NVARCHAR(50) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoiLead				VARCHAR(10) NOT NULL
)

/* TẠO TABLE ChiTietKhoaHocThuocYeuCauTuVan */
CREATE TABLE ChiTietKhoaHocThuocYeuCauTuVan(
	MaTuVan			VARCHAR(10) NOT NULL 
	, MaKhoaHoc		VARCHAR(10) NOT NULL 
	, TenKhoaHoc	NVARCHAR(100) NOT NULL
	, GiangVien		NVARCHAR(20) NOT NULL
	, GiaTien		FLOAT NOT NULL

	CONSTRAINT PKChiTietKhoaHocThuocYeuCauTuVan PRIMARY KEY (MaTuVan, MaKhoaHoc)
)

/* Use case 3 */
/* TẠO TABLE Lead */
CREATE TABLE Lead(
	MaLead						VARCHAR(10) NOT NULL PRIMARY KEY
	, HoTenLead					NVARCHAR(70) NOT NULL
	, GioiTinhLead				NVARCHAR(10) NOT NULL
	, NgaySinhLead				DATE NOT NULL
	, SoDienThoaiLead			CHAR(10) NOT NULL
	, EmailLead					VARCHAR(70) NOT NULL
	, MaNgheNghiep				VARCHAR(10) NOT NULL
	, TenNgheNghiep				NVARCHAR(50) NOT NULL
	, MaNVPhuTrachLead			VARCHAR(10) NOT NULL
	, TenNVPhuTrachLead			NVARCHAR(50) NOT NULL
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

/* TẠO TABLE HoatDongLead */
CREATE TABLE HoatDongLead(
	MaHDLead					VARCHAR(10) NOT NULL PRIMARY KEY
	, MaLead					VARCHAR(10) NOT NULL
	, TenHDLead					NVARCHAR(100) NOT NULL
	, LoaiHDLead				NVARCHAR(30) NOT NULL
	, HDLeadDuocTaoBoi			NVARCHAR(20) NOT NULL
	, MaNVPhuTrachHDLead		VARCHAR(10) NOT NULL
	, TenNVPhuTrachHDLead		NVARCHAR(50) NOT NULL
	, MaEmailDenLead			VARCHAR(10)
	, TaoVaoLuc					DATETIME NOT NULL
)

/* TẠO TABLE NgheNghiep */
CREATE TABLE NgheNghiep(
	MaNgheNghiep				VARCHAR(10) NOT NULL PRIMARY KEY
	, TenNgheNghiep				NVARCHAR(100) NOT NULL
	, TrangThaiNgheNghiep		NVARCHAR(100) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE BaoGia */
CREATE TABLE BaoGia(
	MaBaoGia					VARCHAR(10) NOT NULL PRIMARY KEY
	, TenBaoGia					NVARCHAR(255) NOT NULL
	, MaLead					VARCHAR(10) NOT NULL
	, HoTenLead					NVARCHAR(70) NOT NULL
	, TongTienTruocGiam			FLOAT NOT NULL
	, MaGiamGia					VARCHAR(10) 
	, PhanTramGiamGia			INT 
	, TrangThaiBaoGia			NVARCHAR(30) NOT NULL
	, TongTien					FLOAT NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE ChiTietKhoaHocThuocBaoGia */
CREATE TABLE ChiTietKhoaHocThuocBaoGia(
	MaBaoGia		VARCHAR(10) NOT NULL 
	, MaKhoaHoc		VARCHAR(10) NOT NULL 
	, TenKhoaHoc	NVARCHAR(100) NOT NULL
	, GiangVien		NVARCHAR(20) NOT NULL
	, GiaTien		FLOAT NOT NULL

	CONSTRAINT PKChiTietKhoaHocThuocBaoGia PRIMARY KEY (MaBaoGia, MaKhoaHoc)
)

/* Use case 4 */
/* TẠO TABLE QuyDinhGiamGia */
CREATE TABLE QuyDinhGiamGia(
	MaQuyDinhGiamGia			VARCHAR(10) NOT NULL PRIMARY KEY
	, MoTaLoaiGiamGia			NVARCHAR(150) NOT NULL
	, SoLuongKhoaHocDangKy		INT NOT NULL
	, MaNgheNghiep				VARCHAR(10)  
	, TenNgheNghiep				NVARCHAR(100) 
	, NgayBatDau				DATE
	, NgayKetThuc				DATE
	-- tnha đổi 2 cột PhanTramGiamGiaMacDinh, PhanTramGiamGiaToiDa từ INT thành VARCHAR để hiển thị
	, PhanTramGiamGiaMacDinh	INT NOT NULL
	, PhanTramGiamGiaToiDa		INT NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE MaGiamGia */
CREATE TABLE MaGiamGia(
	MaGiamGia					VARCHAR(10) NOT NULL PRIMARY KEY
	, MoTaMaGiamGia				VARCHAR(30) NOT NULL
	, PhamViApDung				NVARCHAR(50) NOT NULL
	, PhanTramGiamGia			INT NOT NULL
	, TrangThaiMaGiamGia		NVARCHAR(30) NOT NULL
	, MaQuyDinhGiamGia			VARCHAR(10) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
)

/* TẠO TABLE ChiTietDoiTuongUuDai */
CREATE TABLE ChiTietDoiTuongUuDai(
	MaGiamGia		VARCHAR(10) NOT NULL 
	, MaLead		VARCHAR(10) NOT NULL 
	, DaApDung		NVARCHAR(20) NOT NULL
	CONSTRAINT PKChiTietDoiTuongUuDai PRIMARY KEY (MaGiamGia, MaLead)
)

/* Use case 5 */
/* TẠO TABLE KhachHang */
-- thay đổi tương tự Lead
CREATE TABLE KhachHang(
	MaKH						VARCHAR(10) NOT NULL PRIMARY KEY
	, HoTenKH					NVARCHAR(70) NOT NULL
	, GioiTinhKH				NVARCHAR(10) NOT NULL
	, NgaySinhKH				DATE
	, SoDienThoaiKH				CHAR(10) NOT NULL
	, EmailKH					VARCHAR(70) NOT NULL
	, MaNgheNghiep				VARCHAR(10) NOT NULL
	, TenNgheNghiep				NVARCHAR(50) NOT NULL
	, MaNVPhuTrachKH			VARCHAR(10) NOT NULL
	, TenNVPhuTrachKH			NVARCHAR(50) NOT NULL
	, TrangThaiKH				NVARCHAR(30) NOT NULL
	, LyDoTrangThaiKH			NVARCHAR(100)
	, GhiChuKH					NVARCHAR(100)
	, ChuyenDoiTuMaLead			VARCHAR(10)
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE HoatDongKH */
CREATE TABLE HoatDongKH(
	MaHDKH						VARCHAR(10) NOT NULL PRIMARY KEY
	, MaKH						VARCHAR(10) NOT NULL
	, TenHDKH					NVARCHAR(200) NOT NULL
	, LoaiHDKH					NVARCHAR(30) NOT NULL
	, HDKHDuocTaoBoi			NVARCHAR(30) NOT NULL
	, MaNVPhuTrachHDKH			VARCHAR(10) NOT NULL
	, TenNVPhuTrachHDKH			NVARCHAR(50) NOT NULL
	, MaEmailDenKH				VARCHAR(10)
	, TaoVaoLuc					DATETIME NOT NULL
)

/* Use case 6 */
/* TẠO TABLE KhoaHoc */
CREATE TABLE KhoaHoc(
	MaKhoaHoc					VARCHAR(10) NOT NULL PRIMARY KEY
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
	, MaLoaiKhoaHoc				VARCHAR(10) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL
)

/* TẠO TABLE LoaiKhoaHoc */
CREATE TABLE LoaiKhoaHoc(
	MaLoaiKhoaHoc				VARCHAR(10) NOT NULL PRIMARY KEY
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
	MaEmail						VARCHAR(10) NOT NULL PRIMARY KEY
	, TieuDeEmail				NVARCHAR(200) NOT NULL
	, NoiDungEmail				NTEXT NOT NULL
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

/* TẠO TABLE EmailMau */
CREATE TABLE EmailMau(
	MaEmailMau					VARCHAR(10) NOT NULL PRIMARY KEY
	, TieuDeEmailMau			NVARCHAR(200) NOT NULL
	, NoiDungEmailMau			NTEXT NOT NULL
	, MoTaEmailMau				NTEXT NOT NULL
	, TrangThaiEmailMau			NVARCHAR(30) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
	, ChinhSuaLanCuoiVaoLuc		DATETIME NOT NULL
	, ChinhSuaLanCuoiBoi		NVARCHAR(20) NOT NULL  
)

/* Use case 8 */
/* TẠO TABLE HoaDon */
CREATE TABLE HoaDon(
	MaHoaDon					VARCHAR(10) NOT NULL PRIMARY KEY
	, MoTaHoaDon				NVARCHAR(200) NOT NULL
	, TenKH						NVARCHAR(50) NOT NULL
	, ThoiDiemThanhToan			DATETIME NOT NULL
	, TongHoaDon				FLOAT NOT NULL
	, MaBaoGia					VARCHAR(10) NOT NULL
	, TaoVaoLuc					DATETIME NOT NULL
	, TaoBoi					NVARCHAR(20) NOT NULL
)

/* TẠO TABLE ChiTietKhoaHocThuocHoaDon */
CREATE TABLE ChiTietKhoaHocThuocHoaDon(
	MaHoaDon		VARCHAR(10) NOT NULL 
	, MaKhoaHoc		VARCHAR(10) NOT NULL 
	, TenKhoaHoc	NVARCHAR(100) NOT NULL
	, GiangVien		NVARCHAR(20) NOT NULL
	, GiaTien		FLOAT NOT NULL

	CONSTRAINT PKChiTietKhoaHocThuocHoaDon PRIMARY KEY (MaHoaDon, MaKhoaHoc)
)
