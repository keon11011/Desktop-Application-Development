USE SkillBoost
GO

/*USE CASE 1*/
-- Foreign Key bảng TaiKhoan
ALTER TABLE TaiKhoan
ADD FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)

/* Use case 2 */
-- Foreign Key bảng YeuCauTuVan
ALTER TABLE YeuCauTuVan
ADD FOREIGN KEY(TaoBoiLead) REFERENCES Lead(MaLead)

-- Foreign Key bảng YeuCauTuVan
ALTER TABLE ChiTietKhoaHocThuocYeuCauTuVan
ADD FOREIGN KEY(MaTuVan) REFERENCES YeuCauTuVan(MaTuVan)
ALTER TABLE ChiTietKhoaHocThuocYeuCauTuVan
ADD FOREIGN KEY(MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)

/* Use case 3 */
-- Foreign Key bảng Lead
ALTER TABLE Lead
ADD FOREIGN KEY(MaNgheNghiep) REFERENCES NgheNghiep(MaNgheNghiep)
ALTER TABLE Lead
ADD FOREIGN KEY(MaNVPhuTrachLead) REFERENCES NhanVien(MaNV)
ALTER TABLE Lead
ADD FOREIGN KEY(LeadTuKHCu) REFERENCES KhachHang(MaKH)

-- Foreign Key bảng HoatDongLead
ALTER TABLE HoatDongLead
ADD FOREIGN KEY(MaLead) REFERENCES Lead(MaLead)
ALTER TABLE HoatDongLead
ADD FOREIGN KEY(MaNVPhuTrachHDLead) REFERENCES NhanVien(MaNV)
ALTER TABLE HoatDongLead
ADD FOREIGN KEY(MaEmailDenLead) REFERENCES Email(MaEmail)

-- Foreign Key bảng BaoGia
ALTER TABLE BaoGia
ADD FOREIGN KEY(MaLead) REFERENCES Lead(MaLead)
ALTER TABLE BaoGia
ADD FOREIGN KEY(MaGiamGia) REFERENCES MaGiamGia(MaGiamGia)

-- Foreign Key bảng ChiTietKhoaHocThuocBaoGia
ALTER TABLE ChiTietKhoaHocThuocBaoGia
ADD FOREIGN KEY(MaBaoGia) REFERENCES BaoGia(MaBaoGia)
ALTER TABLE ChiTietKhoaHocThuocBaoGia
ADD FOREIGN KEY(MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)

/* Use case 4 */
-- Foreign key cho bảng QuyDinhGiamGia
ALTER TABLE QuyDinhGiamGia
ADD FOREIGN KEY(MaNgheNghiep) REFERENCES NgheNghiep(MaNgheNghiep)

-- Foreign Key bảng MaGiamGia
ALTER TABLE MaGiamGia
ADD FOREIGN KEY(MaQuyDinhGiamGia) REFERENCES QuyDinhGiamGia(MaQuyDinhGiamGia)

-- Foreign Key bảng ChiTietDoiTuongUuDai
ALTER TABLE ChiTietDoiTuongUuDai
ADD FOREIGN KEY(MaGiamGia) REFERENCES MaGiamGia(MaGiamGia)
ALTER TABLE ChiTietDoiTuongUuDai
ADD FOREIGN KEY(MaLead) REFERENCES Lead(MaLead)

/* Use case 5 */
-- Foreign Key bảng KhachHang
ALTER TABLE KhachHang
ADD FOREIGN KEY(MaNgheNghiep) REFERENCES NgheNghiep(MaNgheNghiep)
ALTER TABLE KhachHang
ADD FOREIGN KEY(MaNVPhuTrachKH) REFERENCES NhanVien(MaNV)
ALTER TABLE KhachHang
ADD FOREIGN KEY(ChuyenDoiTuMaLead) REFERENCES Lead(MaLead)

-- Foreign Key bảng HoatDongKH
ALTER TABLE HoatDongKH
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
ALTER TABLE HoatDongKH
ADD FOREIGN KEY(MaNVPhuTrachHDKH) REFERENCES NhanVien(MaNV)
ALTER TABLE HoatDongKH
ADD FOREIGN KEY(MaEmailDenKH) REFERENCES Email(MaEmail)

/* Use case 6 */
-- Foreign Key bảng KhoaHoc
ALTER TABLE KhoaHoc
ADD FOREIGN KEY(MaLoaiKhoaHoc) REFERENCES LoaiKhoaHoc(MaLoaiKhoaHoc)

/* Use case 7 */
-- Foreign Key bảng Email
ALTER TABLE Email
ADD FOREIGN KEY(MaYCTV) REFERENCES YeuCauTuVan(MaTuVan)
ALTER TABLE Email
ADD FOREIGN KEY(MaBaoGia) REFERENCES BaoGia(MaBaoGia)
ALTER TABLE Email
ADD FOREIGN KEY(MaHoaDon) REFERENCES HoaDon(MaHoaDon)
ALTER TABLE Email
ADD FOREIGN KEY(MaEmailMau) REFERENCES EmailMau(MaEmailMau)

/* Use case 8 */
-- Foreign Key bảng HoaDon
ALTER TABLE HoaDon
ADD FOREIGN KEY(MaBaoGia) REFERENCES BaoGia(MaBaoGia)

-- Foreign Key bảng ChiTietKhoaHocThuocHoaDon
ALTER TABLE ChiTietKhoaHocThuocHoaDon
ADD FOREIGN KEY(MaHoaDon) REFERENCES HoaDon(MaHoaDon)
ALTER TABLE ChiTietKhoaHocThuocHoaDon
ADD FOREIGN KEY(MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)