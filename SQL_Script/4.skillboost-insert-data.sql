GO 
USE SkillBoost

/* INSERT DATA */
/*USE CASE 1*/
/* Bảng NhanVien */
INSERT INTO NhanVien(HoTenNV, GioiTinhNV, NgaySinhNV, ChucVu, SoDienThoaiNV, EmailNV, TrangThaiNV, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES 
(N'Chưa tiếp nhận', N'Nam', NULL, N'Nhân viên', '0000000000', 'xxxxxxxxx@gmail.com', N'Đang hoạt động', '2021-12-31 08:00:00', N'Hệ thống', '2021-12-31 08:00:00', N'Hệ thống'),
(N'Nguyễn Phương Thanh', N'Nữ', '1956-10-13', N'Quản lý', '0797979797', 'ngphthanh@gmail.com', N'Đang hoạt động', '2021-12-31 08:00:00', N'Hệ thống', '2021-12-31 09:00:00', 'STA1'),
(N'Nguyễn Ngọc Hoàng', N'Nam', '1990-05-15', N'Nhân viên', '0987123456', 'hoangnguyenngoc@gmail.com', N'Đang hoạt động', '2022-01-01 08:00:00', 'STA1', '2022-01-01 10:30:00', 'STA1'),
(N'Võ Anh Thư', N'Nữ', '1988-09-25', N'Nhân viên', '0908123456', 'anhthuvo@gmail.com', N'Đang hoạt động', '2022-01-02 09:15:00', 'STA1', '2022-01-02 14:45:00', 'STA1'),
(N'Trần Mỹ Hạnh', N'Nữ', '1995-11-10', N'Nhân viên', '0978123456', 'hanhmytran@gmail.com', N'Đang hoạt động', '2022-01-03 11:30:00', 'STA1', '2022-01-03 16:20:00', 'STA1'),
(N'Trương Minh Tiến', N'Nam', '1982-03-02', N'Nhân viên', '0918123456', 'minhtientruong@gmail.com', N'Đang hoạt động', '2022-01-04 13:45:00', 'STA1', '2022-01-04 18:10:00', 'STA1'),
(N'Nguyễn Đức Trung', N'Nam', '1993-07-20', N'Nhân viên', '0968123456', 'ductrungnguyen@gmail.com', N'Đang hoạt động', '2022-01-05 15:00:00', 'STA1', '2022-01-05 20:05:00', 'STA1'),
(N'Bùi Thị Thúy', N'Nữ', '1987-01-12', N'Nhân viên', '0958123456', 'thuythibui@gmail.com', N'Đang hoạt động', '2022-01-06 17:15:00', 'STA1', '2022-01-06 22:40:00', 'STA1'),
(N'Trần Thúy Hằng', N'Nữ', '1984-06-30', N'Nhân viên', '0948123456', 'hangthuytran@gmail.com', N'Đang hoạt động', '2022-01-07 19:30:00', 'STA1', '2022-01-07 20:00:00', 'STA1'),
(N'Bùi Bích Trâm', N'Nữ', '1999-12-05', N'Nhân viên', '0938123456', 'trambichbui@gmail.com', N'Đang hoạt động', '2022-01-08 21:45:00', 'STA1', '2022-01-08 14:15:00', 'STA1'),
(N'Trần Thanh Mai', N'Nữ', '1986-04-18', N'Nhân viên', '0928123456', 'maithanhtran@gmail.com', N'Đang hoạt động', '2022-01-09 23:59:00', 'STA1', '2022-02-09 08:50:00', 'STA1'),
(N'Huỳnh Nhã Thy', N'Nữ', '1991-08-08', N'Nhân viên', '0998123456', 'nhathythuynh@gmail.com', N'Đang hoạt động', '2022-01-10 02:30:00', 'STA1', '2022-01-10 16:30:00', 'STA1');
GO
--SELECT * FROM NhanVien

/* Bảng TaiKhoan */
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ngphthanh@gmai.com','secretKey',N'Đang hoạt động','STA1','2021-12-21 8:00:00',N'Hệ thống','2021-12-31 8:00:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('hoangnguyenngoc@gmail.com','pass@123',N'Đang hoạt động','STA2','2022-01-01 8:00:00',N'Hệ thống','2022-01-01 8:00:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('anhthuvo@gmail.com','strongPwd',N'Đang hoạt động','STA3','2022-01-02 9:15:00',N'Hệ thống','2022-01-02 9:15:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('hanhmytran@gmail.com','mySecret',N'Đang hoạt động','STA4','2022-01-03 11:30:00',N'Hệ thống','2022-01-03 11:30:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('minhtientruong@gmail.com','p@ssw0rd',N'Đang hoạt động','STA5','2022-01-04 13:45:00',N'Hệ thống','2022-01-04 13:45:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ductrungnguyen@gmail.com','secure123',N'Vô hiệu hóa','STA6','2022-01-05 15:00:00',N'Hệ thống','2022-01-05 15:00:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('thuythibui@gmail.com','12345pass',N'Đang hoạt động','STA7','2022-01-06 17:15:00',N'Hệ thống','2022-01-06 17:15:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('hangthuytran@gmail.com','secretPwd',N'Đang hoạt động','STA8','2022-01-07 19:30:00',N'Hệ thống','2022-01-07 19:30:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('trambichbui@gmail.com','password123',N'Vô hiệu hóa','STA9','2022-01-08 21:45:00',N'Hệ thống','2022-01-08 21:45:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('maithanhtran@gmail.com','secretPass',N'Đang hoạt động','STA10','2022-01-09 23:59:00',N'Hệ thống','2022-01-09 23:59:00',N'Hệ thống');
INSERT INTO TaiKhoan(EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('nhathythuynh@gmail.com','pass2023',N'Đang hoạt động','STA11','2022-01-10 2:30:00',N'Hệ thống','2022-01-10 2:30:00',N'Hệ thống');
GO

/* Bảng NgheNghiep */
INSERT INTO NgheNghiep(TenNgheNghiep, TrangThaiNgheNghiep, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES 
(N'Nhiếp ảnh', N'Đang được đưa vào sử dụng', '2023-07-01 08:00:00', N'Hệ thống', '2023-07-01 08:00:00', N'Hệ thống'),
(N'Phân tích dữ liệu', N'Đang được đưa vào sử dụng', '2023-06-02 09:15:00', N'Hệ thống', '2023-06-02 09:15:00', N'Hệ thống'),
(N'Chuyên viên kinh doanh', N'Đang được đưa vào sử dụng', '2023-05-03 11:30:00', N'Hệ thống', '2023-05-03 11:30:00', N'Hệ thống'),
(N'Giảng viên', N'Đang được đưa vào sử dụng', '2023-04-04 13:45:00', N'Hệ thống', '2023-04-04 13:45:00', N'Hệ thống'),
(N'Học sinh - Sinh viên', N'Đang được đưa vào sử dụng', '2023-03-05 15:00:00', N'Hệ thống', '2023-03-05 15:00:00', N'Hệ thống'),
(N'Bác sĩ', N'Đang được đưa vào sử dụng', '2023-02-06 17:15:00', N'Hệ thống', '2023-02-06 17:15:00', N'Hệ thống'),
(N'Mua bán', N'Đang được đưa vào sử dụng', '2023-01-07 19:30:00', N'Hệ thống', '2023-01-07 19:30:00', N'Hệ thống'),
(N'Nhà báo', N'Đang được đưa vào sử dụng', '2023-12-08 21:45:00', N'Hệ thống', '2023-12-08 21:45:00', N'Hệ thống'),
(N'Nhân viên bất động sản', N'Đang được đưa vào sử dụng', '2023-11-09 23:59:00', N'Hệ thống', '2023-11-09 23:59:00', N'Hệ thống'),
(N'Người kinh doanh', N'Đang được đưa vào sử dụng', '2023-10-10 02:30:00', N'Hệ thống', '2023-10-10 02:30:00', N'Hệ thống'),
(N'', N'Đang được đưa vào sử dụng', '2023-12-10 02:30:00', N'Hệ thống', '2023-12-10 02:30:00', N'Hệ thống');

GO
-- SELECT * FROM NgheNghiep

/*USE CASE 3*/
/* Bảng Lead */
INSERT INTO Lead(HoTenLead, GioiTinhLead, NgaySinhLead, SoDienThoaiLead, EmailLead, MaNgheNghiep, TenNgheNghiep, MaNVPhuTrachLead, TenNVPhuTrachLead, TrangThaiLead, LyDoTrangThaiLead, NguonLead, GhiChuLead, LeadTuKHCu, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES 
(N'Ngô Thị Kim Cương', N'Nữ', '1991-06-30', '0777007007', 'kimcuongngothi@gmail.com', 'OCU1', N'Nhiếp ảnh', 'STA7', N'Bùi Thị Thúy', N'Đang tư vấn', NULL, N'LinkedIn', NULL, NULL, '2023-07-01 08:00:00', N'Hệ thống', '2023-07-01 10:30:00', 'STA7'),
(N'Nguyễn Hoàng Minh', N'Nam', '1978-12-05', '0999888777', 'minhhoangnguyen@gmail.com', 'OCU2', N'Phân tích dữ liệu', 'STA4', N'Trần Mỹ Hạnh', N'Chờ tư vấn', NULL, N'Website', NULL, NULL, '2023-06-02 09:15:00', N'Hệ thống', '2023-06-02 14:45:00', 'STA4'),
(N'Nguyễn Thu Việc', N'Nữ', '1988-03-02', '0888777666', 'viecthunguyen@gmail.com', 'OCU3', N'Chuyên viên kinh doanh', 'STA2', N'Nguyễn Ngọc Hoàng', N'Chờ tư vấn', NULL, N'Truyền miệng', NULL, NULL, '2023-05-03 11:30:00', N'Hệ thống', '2023-05-03 16:20:00', 'STA2'),
(N'Lê Minh Quân', N'Nam', '1992-09-25', '0123456789', 'minhquanle@gmail.com', 'OCU4', N'Giảng viên', 'STA9', N'Bùi Bích Trâm', N'Đang tư vấn', NULL, N'Facebook', NULL, NULL, '2023-04-04 13:45:00', N'Hệ thống', '2023-04-04 18:10:00', 'STA9'),
(N'Dương Thùy Dương', N'Nữ', '2002-04-18', '0333222111', 'duongthuyduong@gmail.com', 'OCU5', N'Học sinh - Sinh viên', 'STA10', N'Trần Thanh Mai', N'Ngừng theo dõi', NULL, N'Truyền miệng', NULL, NULL, '2023-03-05 15:00:00', N'Hệ thống', '2023-03-05 20:05:00', 'STA10'),
(N'Phan Duy Trọng', N'Nam', '2003-05-15', '0987654321', 'trongphanduy@gmail.com', 'OCU5', N'Học sinh - Sinh viên', 'STA5', N'Trương Minh Tiến', N'Đã thanh toán', NULL, N'Facebook', NULL, NULL, '2023-02-06 17:15:00', N'Hệ thống', '2023-02-06 22:40:00', 'STA5'),
(N'Trần Kim Ngọc', N'Nữ', '1985-10-11', '0909090909', 'ngockimtran@gmail.com', 'OCU6', N'Bác sĩ', 'STA11', N'Huỳnh Nhã Thy', N'Đang tư vấn', NULL, N'Website', NULL, NULL, '2023-01-07 19:30:00', N'Hệ thống', '2023-01-08 09:25:00', 'STA11'),
(N'Lâm Thy Nhã', N'Nữ', '1979-07-20', '0555666777', 'nhalamthy@gmail.com', 'OCU7', N'Mua bán', 'STA8', N'Trần Thúy Hằng', N'Chờ tư vấn', NULL, N'Linkedln', NULL, NULL, '2023-12-08 21:45:00', N'Hệ thống', '2023-12-09 14:15:00', 'STA8'),
(N'Bùi Xuân Vĩ', N'Nam', '1982-01-12', '0444333222', 'vixuanbui@gmail.com', 'OCU8', N'Nhà báo', 'STA6', N'Nguyễn Đức Trung', N'Đã thanh toán', NULL, N'Facebook', NULL, NULL, '2023-11-09 23:59:00', N'Hệ thống', '2023-11-10 08:50:00', 'STA6'),
(N'Dương Bích Tuyền', N'Nữ', '1983-08-08', '0111222333', 'tuyenbichduong@gmail.com', 'OCU9', N'Nhân viên bất động sản', 'STA3', N'Võ Anh Thư', N'Ngừng theo dõi', NULL, N'Facebook', NULL, NULL, '2023-10-10 02:30:00', N'Hệ thống', '2023-10-10 16:30:00', 'STA3');
GO
-- SELECT * FROM Lead

/* Bảng HoatDongLead */
INSERT INTO HoatDongLead(MaLead, TenHDLead, LoaiHDLead, HDLeadDuocTaoBoi, MaNVPhuTrachHDLead, TenNVPhuTrachHDLead, MaEmailDenLead, TaoVaoLuc)
VALUES 
('LEA1', N'Tạo yêu cầu tư vấn', N'Tư vấn', N'Lead', 'STA7', N'Bùi Thị Thúy', NULL, '2023-08-12 08:00:00'),
('LEA1', N'Trả lời tư vấn', N'Tư vấn', N'Lead', 'STA7', N'Bùi Thị Thúy', NULL, '2023-08-12 09:00:00'),
('LEA1', N'Gửi báo giá thành công', N'Báo giá', N'Hệ thống', 'STA7', N'Bùi Thị Thúy', NULL, '2023-08-12 10:00:00'),
('LEA1', N'Thanh toán thành công', N'Thanh toán', N'Hệ thống', 'STA7', N'Bùi Thị Thúy', NULL, '2023-08-12 10:01:00'),
('LEA1', N'Gửi email xác nhận thanh toán thành công', N'Email', N'Hệ thống', 'STA7', N'Bùi Thị Thúy', NULL, '2023-08-12 10:02:00'),
('LEA1', N'Chuyển đổi thành khách hàng thành công', N'Điều chỉnh trạng thái', N'Hệ thống', 'STA7', N'Bùi Thị Thúy', NULL, '2023-08-12 10:03:00'),
('LEA2', N'Tạo yêu cầu tư vấn', N'Tư vấn', N'Lead', 'STA4', N'Trần Mỹ Hạnh', NULL, '2023-11-01 08:00:00'),
('LEA3', N'Tạo yêu cầu tư vấn', N'Tư vấn', N'Lead', 'STA2', N'Nguyễn Ngọc Hoàng', NULL, '2023-09-11 08:00:00'),
('LEA4', N'Tạo yêu cầu tư vấn', N'Tư vấn', N'Lead', 'STA9', N'Bùi Bích Trâm', NULL, '2023-09-12 08:00:00'),
('LEA5', N'Tạo yêu cầu tư vấn', N'Tư vấn', N'Lead', 'STA10', N'Trần Thanh Mai', NULL, '2023-10-12 08:00:00'),
('LEA6', N'Tạo yêu cầu tư vấn', N'Yêu cầu', N'Lead', 'STA5', N'Trương Minh Tiến', NULL, '2023-04-22 08:00:00'),
('LEA7', N'Tạo yêu cầu tư vấn', N'Tư vấn', N'Lead', 'STA1', N'Nguyễn Phương Thanh', NULL, '2023-12-15 08:00:00'),
('LEA8', N'Tạo yêu cầu tư vấn', N'Yêu cầu', N'Lead', 'STA8', N'Trần Thúy Hằng', NULL, '2023-12-17 08:00:00'),
('LEA9', N'Tạo yêu cầu tư vấn', N'Yêu cầu', N'Lead', 'STA6', N'Nguyễn Đức Trung', NULL, '2023-02-27 08:00:00'),
('LEA10', N'Tạo yêu cầu tư vấn', N'Tư vấn', N'Lead', 'STA3', N'Võ Anh Thư', NULL, '2023-12-24 08:00:00'),
('LEA3', N'Gửi báo giá thành công', N'Báo giá', N'Hệ thống', 'STA2', N'Nguyễn Ngọc Hoàng', NULL, '2023-09-12 08:00:00'),
('LEA4', N'Gửi báo giá thành công', N'Báo giá', N'Hệ thống', 'STA9', N'Bùi Bích Trâm', NULL, '2023-09-13 08:00:00'),
('LEA5', N'Gửi báo giá thành công', N'Báo giá', N'Hệ thống', 'STA10', N'Trần Thanh Mai', NULL, '2023-10-13 08:00:00'),
('LEA4', N'Chuyển đổi thành khách hàng thành công', N'Điều chỉnh trạng thái', N'Hệ thống', 'STA9', N'Bùi Bích Trâm', NULL, '2023-09-14 08:00:00'),
('LEA5', N'Chuyển đổi thành khách hàng thành công', N'Điều chỉnh trạng thái', N'Hệ thống', 'STA10', N'Trần Thanh Mai', NULL, '2023-10-13 08:00:00');
GO
-- SELECT * FROM HoatDongLead



/*USE CASE 2*/
/* Bảng YeuCauTuVan */ 
INSERT INTO YeuCauTuVan(TenLeadYeuCau, NgaySinhLeadYeuCau, EmailLeadYeuCau, SDTLeadYeuCau, GhiChuYCTV, TrangThaiYCTV, TaoVaoLuc, TaoBoiLead)
VALUES 
(N'Nguyễn Thu Việc', '1988-03-02', 'viecthunguyen@gmail.com', '0888777666', NULL, N'Đã tiếp nhận', '2023-09-11 13:45:35', 'LEA3'),
(N'Nguyễn Hoàng Minh', '1978-12-05', 'minhhoangnguyen@gmail.com', '0999888777', NULL, N'Đã tiếp nhận', '2023-01-17 23:15:47', 'LEA2'),
(N'Phan Duy Trọng', '2003-05-15', 'trongphanduy@gmail.com', '0987654321', NULL, N'Đã tiếp nhận', '2023-01-22 01:51:15', 'LEA6'),
(N'Bùi Xuân Vĩ', '1982-01-12', 'vixuanbui@gmail.com', '0444333222', NULL, N'Đã tiếp nhận', '2023-01-08 01:20:08', 'LEA9');
GO
--SELECT * FROM YeuCauTuVan

/*USE CASE 6*/

/* Bảng LoaiKhoaHoc */
INSERT INTO LoaiKhoaHoc(TenLoaiKhoaHoc, TrangThaiLoaiKhoaHoc, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES
    ('IT', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('PO', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('SQL', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('DATA', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('BI', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống');
	GO
-- SELECT * FROM LoaiKhoaHoc

/* Bảng KhoaHoc */
INSERT INTO KhoaHoc(TenKhoaHoc, MoTaKhoaHoc, ThoiLuongKhoaHoc, GiangVien, MucDoKhoaHoc, SoLuongHocVienToiDa, GiaTien, NgayKhaiGiang, NgayBeGiang, DanhGiaKhoaHoc, TrangThaiKhoaHoc, MaLoaiKhoaHoc, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES
    (N'IT Business Analysis', N'Khóa học IT Business Analysis, học viên sẽ được giảng dạy các kỹ năng cơ bản và công cụ phân tích kinh doanh, bao gồm thu thập và phân tích yêu cầu, mô hình hóa quy trình kinh doanh, xác định và giải quyết vấn đề, và quản lý dự án. Họ sẽ tìm hiểu về các phương pháp và kỹ thuật phân tích yêu cầu, cách thực hiện các cuộc phỏng vấn và phân tích tài liệu, cùng với việc sử dụng các công cụ và phần mềm hỗ trợ như Microsoft Visio, Excel, và các hệ thống quản lý yêu cầu.', N'36 giờ', N'Ryan Nguyễn', N'Người mới', 42, 4000000, '2023-02-22', '2023-03-22', 4.5, N'Đang vận hành', 'CID1', '2023-01-14 01:04:10', N'Hệ Thống', '2023-01-15 06:38:49', N'Hệ Thống'),
    (N'Product Owner Master Class', N'Khóa học Product Owner Master Class là một chương trình đào tạo chuyên sâu dành cho những người muốn trở thành Product Owner chuyên nghiệp hoặc muốn nâng cao kỹ năng quản lý sản phẩm của mình. Khóa học này cung cấp kiến thức và công cụ cần thiết để thành công trong vai trò Product Owner trong một dự án phát triển phần mềm hoặc sản phẩm công nghệ.', N'54 giờ', N'Harry Phạm', N'Đã có kinh nghiệm', 41, 5400000, '2023-04-25', '2023-06-10', 4, N'Đang vận hành', 'CID2', '2023-02-23 14:32:22', N'Hệ Thống', '2023-02-27 11:57:47', N'Hệ Thống'),
    (N'SQL Advanced Class', N'Khóa học SQL Advanced Class là một khóa học đào tạo chuyên sâu nhằm cung cấp kiến thức và kỹ năng cao cấp về ngôn ngữ truy vấn SQL (Structured Query Language). Khóa học này dành cho những người đã có kiến thức cơ bản về SQL và muốn nâng cao khả năng của mình trong việc truy vấn, phân tích và quản lý cơ sở dữ liệu.', N'192 giờ', N'Jerry Bùi', N'Đã có kinh nghiệm', 31, 4914000, '2023-06-28', '2023-11-13', 4, N'Đang vận hành', 'CID3', '2023-05-30 12:15:47', N'Hệ Thống', '2023-06-12 11:26:18', N'Hệ Thống'),
    (N'Data Analysis', N'Khóa học Data Analysis là một chương trình đào tạo được thiết kế để giúp học viên nắm vững các kỹ năng và công cụ cần thiết để hiểu, phân tích và trích xuất thông tin từ dữ liệu. Khóa học này nhằm cung cấp kiến thức và kỹ năng cần thiết để học viên có thể làm việc với dữ liệu số, tạo ra thông tin hữu ích và đưa ra quyết định dựa trên dữ liệu.', N'144 giờ', N'Phil Phan', N'Người mới', 45, 4429000, '2023-10-05', '2024-01-05', 4.5, N'Đang vận hành', 'CID4', '2023-06-17 20:40:55', N'Hệ Thống', '2023-08-20 02:06:10', N'Hệ Thống'),
    (N'Business Intelligence', N'Khóa học Business Intelligence là một chương trình đào tạo nhằm cung cấp kiến thức và kỹ năng cần thiết để hiểu, phân tích và sử dụng thông tin kinh doanh để hỗ trợ quyết định và phát triển chiến lược kinh doanh.', N'36 giờ', N'Anh Tú', N'Người mới', 30, 5482000, '2023-12-15', '2024-01-15', 3.5, N'Đang vận hành', 'CID5', '2023-07-21 21:14:47', N'Hệ Thống', '2023-07-26 03:35:44', N'Hệ Thống'),
    (N'Excel Advanced Class', N'Khóa học Excel Advanced Class là một chương trình đào tạo nhằm cung cấp kiến thức và kỹ năng nâng cao về việc sử dụng Microsoft Excel, một trong những công cụ phổ biến nhất trong việc xử lý và phân tích dữ liệu.', N'48 giờ', N'Ngọc Thu', N'Chuyên gia', 33, 4704000, '2023-03-28', '2023-04-28', 4, N'Đang vận hành', 'CID4', '2023-02-04 17:32:25', N'Hệ Thống', '2023-02-04 17:32:25', N'Hệ Thống'),
    (N'Database Foundation Class', N'Khóa học Database Foundation Class là một chương trình đào tạo cung cấp kiến thức cơ bản về cơ sở dữ liệu và các khái niệm quan trọng liên quan đến quản lý dữ liệu.', N'180 giờ', N'Tony Lê', N'Người mới', 29, 5317000, '2023-05-22', '2023-07-22', 3, N'Vô hiệu hóa', 'CID4', '2023-03-16 18:04:40', N'Hệ Thống', '2023-03-16 18:04:40', N'Hệ Thống'),
    (N'Desktop Coding Class', N'Khóa học Desktop Coding Class là một chương trình đào tạo nhằm giúp học viên học cách phát triển ứng dụng máy tính bằng việc sử dụng các ngôn ngữ lập trình và công cụ phát triển phần mềm trên máy tính.', N'174 giờ', N'Jennie Huỳnh', N'Người mới', 35, 4370000, '2023-10-05', '2023-12-05', 3.5, N'Đang chiêu sinh', 'CID1', '2023-08-05 18:26:46', N'Hệ Thống', '2023-08-05 18:26:46', N'Hệ Thống'),
    (N'Python Advance Coding Class', N'Khóa học Python Advanced Coding Class là một chương trình đào tạo nhằm giúp học viên nâng cao kỹ năng lập trình Python và hiểu sâu về các khái niệm và kỹ thuật phức tạp trong ngôn ngữ này.', N'120 giờ', N'John Đặng', N'Đã có kinh nghiệm', 36, 4333000, '2023-11-20', '2024-03-20', 4, N'Đang vận hành', 'CID1', '2023-10-15 17:43:14', N'Hệ Thống', '2023-10-15 17:43:14', N'Hệ Thống'),
    (N'Business Data Engineer', N'Khóa học "Business Data Engineer" là một chương trình đào tạo nhằm trang bị học viên với kiến thức và kỹ năng cần thiết để trở thành một chuyên gia trong lĩnh vực kỹ thuật dữ liệu kinh doanh. Khóa học này tập trung vào các khía cạnh kỹ thuật và công nghệ liên quan đến quản lý, xử lý và phân tích dữ liệu trong môi trường doanh nghiệp.', N'240 giờ', N'Tuấn Vũ', N'Chuyên gia', 21, 5265000, '2023-12-11', '2024-05-11', 4.5, N'Đang vận hành', 'CID5', '2023-11-15 12:23:56', N'Hệ Thống', '2023-11-15 12:23:56', N'Hệ Thống');
GO
-- SELECT * FROM KhoaHoc

/* Bảng ChiTietKhoaHocThuocYCTV */
INSERT INTO ChiTietKhoaHocThuocYeuCauTuVan(MaTuVan, MaKhoaHoc, TenKhoaHoc, GiangVien, GiaTien)
VALUES
('CON1', 'CRS2', N'Product Owner Master Class', N'Harry Phạm', 5400000),
('CON2', 'CRS3', N'SQL Advanced Class', N'Jerry Bùi', 4914000),
('CON3', 'CRS1', N'IT Business Analysis', N'Ryan Nguyễn', 4000000),
('CON4', 'CRS2', N'Product Owner Master Class', N'Harry Phạm', 5400000);
GO
-- SELECT * FROM ChiTietKhoaHocThuocYeuCauTuVan

/*USE CASE 4*/
/* Bảng QuyDinhGiamGia */
INSERT INTO QuyDinhGiamGia(MoTaLoaiGiamGia, SoLuongKhoaHocDangKy, MaNgheNghiep, TenNgheNghiep, NgayBatDau, NgayKetThuc, PhanTramGiamGiaMacDinh, PhanTramGiamGiaToiDa, TaoVaoLuc, TaoBoi, TaoBoiNV, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES
(N'Giảm giá cơ bản', 1, NULL, NULL, '2023-01-01', '2023-01-10', 0, 10, '2023-01-01 13:42:11', N'STA1', N'Nguyễn Phương Thanh', '2023-01-01 13:42:11', N'STA1'),
(N'Giảm giá cho đối tượng ưu tiên', 1, 'OCU5', N'Học sinh - Sinh viên', '2023-03-22', '2023-03-22', 5, 15, '2023-03-22 18:55:04', N'STA1', N'Nguyễn Phương Thanh', '2023-03-22 18:55:04', N'STA1'),
(N'Giảm giá cho đối tượng ưu tiên và ngày đặc biệt', 1, 'OCU5', N'Học sinh - Sinh viên', '2023-11-23', '2023-11-29', 10, 20, '2023-03-28 10:55:18', N'STA1', N'Nguyễn Phương Thanh', '2023-03-28 10:55:18', N'STA1'),
(N'Giảm giá nâng cao', 2, NULL, NULL, '2023-01-22', '2023-01-22', 5, 15, '2023-01-22 16:01:33', N'STA1', N'Nguyễn Phương Thanh', '2023-01-22 16:01:33', N'STA1'),
(N'Giảm giá cho khách hàng tiềm năng', 2, 'OCU5', N'Học sinh - Sinh viên', NULL, NULL, 10, 15, '2023-03-13 08:32:44', N'STA1', N'Nguyễn Phương Thanh', '2023-03-13 08:32:44', N'STA1'),
(N'Giảm giá cho khách hàng tiềm năng và ngày đặc biệt', 2, 'OCU5', N'Học sinh - Sinh viên', '2023-11-23', '2023-11-29', 15, 15, '2023-02-04 20:37:15', N'STA1', N'Nguyễn Phương Thanh', '2023-02-04 20:37:15', N'STA1'),
(N'Giảm giá cho khách hàng VIP', 3, NULL, NULL, NULL, NULL, 10, 20, '2023-01-04 18:57:40', N'STA1', N'Nguyễn Phương Thanh', '2023-01-04 18:57:40', N'STA1'),
(N'Giảm giá ưu đãi thêm cho khách hàng VIP', 3, 'OCU5', N'Học sinh - Sinh viên', NULL, NULL, 15, 25, '2023-03-06 04:08:40', N'STA1', N'Nguyễn Phương Thanh', '2023-03-06 04:08:40', N'STA1'),
(N'Giảm giá ưu đãi thêm cho khách hàng VIP và ngày đặc biệt', 3, 'OCU5', N'Học sinh - Sinh viên', '2023-11-23', '2023-11-29', 20, 30, '2023-03-31 09:14:21', N'STA1', N'Nguyễn Phương Thanh', '2023-03-31 09:14:21', N'STA1');
GO
-- SELECT * FROM QuyDinhGiamGia

/* Bảng MaGiamGia */
INSERT INTO MaGiamGia(MoTaMaGiamGia, PhamViApDung, PhanTramGiamGia, TrangThaiMaGiamGia, MaQuyDinhGiamGia, TaoVaoLuc, TaoBoi)
VALUES
('MUAGICUNGRE15', N'Cho cá nhân', 15, N'Khả dụng', 'DIS2', '2023-07-21 14:45:24', N'Hệ thống'),
('HOCSINHSINHVIEN15', N'Cho nhóm', 10, N'Đang duyệt', 'DIS1', '2023-07-10 11:04:37', N'Hệ thống'),
('NGAYPHUNU10', N'Cho cá nhân', 10, N'Khả dụng', 'DIS2', '2023-09-02 19:20:43', N'Hệ thống'),
('NGAYNHAGIAOVIETNAM15', N'Cho cá nhân', 15, N'Khả dụng', 'DIS3', '2023-09-12 04:20:41', N'Hệ thống'),
('NGAYSINHNHAT15', N'Cho cá nhân', 15, N'Khả dụng', 'DIS5', '2023-04-01 10:27:42', N'Hệ thống'),
('CHAPCANHUOCMO5', N'Cho nhóm', 5, N'Khả dụng', 'DIS1', '2023-08-15 07:47:55', N'Hệ thống'),
('BLACKFRIDAY20', N'Không giới hạn', 15, N'Hết hạn', 'DIS6', '2023-09-11 16:30:11', N'Hệ thống'),
('WELCOME10', N'Cho nhóm', 10, N'Hết hạn', 'DIS1', '2023-11-02 05:25:32', N'Hệ thống'),
('VIP20', N'Cho cá nhân', 20, N'Khả dụng', 'DIS3', '2023-05-18 08:21:16', N'Hệ thống'),
('GIFT25', N'Không giới hạn', 25, N'Hết hạn', 'DIS9', '2023-04-21 06:41:30', N'Hệ thống');
GO
-- SELECT * FROM MaGiamGia

/* Bảng ChiTietDoiTuongUuDai */
INSERT INTO ChiTietDoiTuongUuDai(MaGiamGia, MaLead, DaApDung)
VALUES
('DIC1', 'LEA6', N'Có'),
('DIC2', 'LEA7', N'Có'),
('DIC3', 'LEA9', N'Không'),
('DIC5', 'LEA4', N'Không'),
('DIC8', 'LEA3', N'Không');
GO
-- SELECT * FROM ChiTietDoiTuongUuDai


/* Bảng BaoGia */
INSERT INTO BaoGia(TenBaoGia, MaLead, HoTenLead, TongTienTruocGiam, MaGiamGia, PhanTramGiamGia, TongTien, TrangThaiBaoGia, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES
(N'Báo giá cho khóa học online IT Business Analysis', 'LEA6', N'Phan Duy Trọng', 4000000, 'DIC1', 15, 3400000,
N'Đã thanh toán', '2023-04-30 10:51:08', N'Hệ thống', '2023-04-30 10:51:08', N'Hệ thống'),
(N'Báo giá cho khóa học online Product Owner Master Class', 'LEA9',  N'Bùi Xuân Vĩ', 5400000, NULL, NULL, 5400000,
N'Đã thanh toán', '2023-04-29 03:07:18', N'Hệ thống', '2023-04-29 03:07:18', N'Hệ thống'),
(N'Báo giá cho khóa học online Product Owner Master Class', 'LEA3',  N'Nguyễn Thu Việc', 5400000, NULL, NULL, 5400000,
N'Chưa thanh toán', '2023-09-11 14:04:24', N'Hệ thống', '2023-09-11 14:04:24', N'Hệ thống'),
(N'Báo giá cho khóa học online Business Intelligence', 'LEA4',  N'Lê Minh Quân', 5482000, 'DIC2', 10, 4933800,
N'Chưa thanh toán', '2023-09-15 17:56:52', N'Hệ thống', '2023-09-15 17:56:52', N'Hệ thống'),
(N'Báo giá cho khóa học online Desktop Coding Class', 'LEA7',  N'Trần Kim Ngọc', 4370000, NULL, NULL, 4370000,
N'Đã hết hạn', '2023-02-23 10:43:42', N'Hệ thống', '2023-02-23 10:43:42', N'Hệ thống');
GO
-- SELECT * FROM BaoGia

/* Bảng ChiTietKhoaHocThuocBaoGia */
INSERT INTO ChiTietKhoaHocThuocBaoGia(MaBaoGia, MaKhoaHoc, TenKhoaHoc, GiangVien, GiaTien)
VALUES
('QUO1', 'CRS1', N'IT Business Analysis', N'Ryan Nguyễn', 4000000),
('QUO2', 'CRS2', N'Product Owner Master Class', N'Harry Phạm', 5400000),
('QUO3', 'CRS2', N'Product Owner Master Class', N'Harry Phạm', 5400000),
('QUO4', 'CRS5', N'Business Intelligence', N'Anh Tú', 5482000),
('QUO5', 'CRS8', N'Desktop Coding Class', N'Jennie Huỳnh', 4370000);
GO
-- SELECT * FROM ChiTietKhoaHocThuocBaoGia

/*USE CASE 5*/
/* Bảng KhachHang */
INSERT INTO KhachHang (HoTenKH, GioiTinhKH, NgaySinhKH, SoDienThoaiKH, EmailKH, MaNgheNghiep, TenNgheNghiep, MaNVPhuTrachKH, TenNVPhuTrachKH, TrangThaiKH, LyDoTrangThaiKH, GhiChuKH, ChuyenDoiTuMaLead, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES
    (N'Phan Duy Trọng', N'Nam','2003-05-15', '0987654321', 'trongphanduy@gmail.com', 'OCU5', N'Học sinh - Sinh viên', 'STA5', N'Trương Minh Tiến', N'Đang hoạt động', NULL, NULL, 'LEA6', '2023-09-01 8:00:00', N'Hệ thống', '2023-09-01 10:30:00', 'STA5'),
    (N'Lê Minh Quân', N'Nam', '1992-09-25', '0123456789', 'minhquanle@gmail.com', 'OCU4', N'Giảng viên', 'STA9', N'Bùi Bích Trâm', N'Đang hoạt động', NULL, NULL, 'LEA4', '2023-09-02 9:15:00', N'Hệ thống', '2023-09-02 14:45:00', 'STA9'),
    (N'Trần Kim Ngọc', N'Nữ', '1985-10-11', '0909090909', 'ngockimtran@gmai.com', 'OCU6', N'Bác sĩ', 'STA11', N'Huỳnh Nhã Thy', N'Đang hoạt động', NULL, NULL, 'LEA7', '2023-09-03 11:30:00', N'Hệ thống', '2023-09-03 16:20:00', 'STA11'),
    (N'Nguyễn Thu Việc', N'Nữ', '1988-03-02', '0888777666', 'viecthunguyen@gmail.com', 'OCU3', N'Chuyên viên kinh doanh', 'STA2', N'Nguyễn Ngọc Hoàng', N'Đang hoạt động', NULL, NULL, 'LEA3', '2023-09-04 13:45:00', N'Hệ thống', '2023-09-04 18:10:00', 'STA2'),
    (N'Bùi Xuân Vĩ ', N'Nam', '1982-01-12', '0444333222', 'vixuanbui@gmail.com', 'OCU8', N'Nhà báo', 'STA6', N'Nguyễn Đức Trung', N'Đang hoạt động', NULL, NULL, 'LEA9', '2023-09-05 15:00:00', N'Hệ thống', '2023-09-05 20:05:00', 'STA6'),
    (N'Ngô Thị Kim Cương', N'Nữ', '1991-06-30', '0777007007', 'kimcuongngothi@gmail.com', 'OCU1', N'Nhiếp ảnh', 'STA7', N'Bùi Thị Thúy', N'Đang hoạt động', NULL, NULL, 'LEA1', '2023-09-06 17:15:00', N'Hệ thống', '2023-09-06 22:40:00', 'STA7'), 
    (N'Nguyễn Hoàng Minh', N'Nam', '1978-12-05', '0999888777', 'minhhoangnguyen@gmail.com', 'OCU2', N'Phân tích dữ liệu', 'STA4', N'Trần Mỹ Hạnh', N'Đang hoạt động', NULL, NULL, 'LEA2', '2023-09-07 19:30:00', N'Hệ thống', '2023-09-07 9:25:00', 'STA4'),
    (N'Dương Bích Tuyền', N'Nữ', '1983-08-08', '0111222333', 'tuyenbichduong@gmail.com', 'OCU9', N'Nhân viên bất động sản', 'STA3', N'Võ Anh Thư', N'Đang hoạt động', NULL, NULL, 'LEA10', '2023-09-08 21:45:00', N'Hệ thống', '2023-09-08 14:15:00', 'STA3');
GO
-- SELECT * FROM KhachHang

/*USE CASE 8*/
/* Bảng HoaDon*/
-- Inserting data into HoaDon table
INSERT INTO HoaDon(MoTaHoaDon, TenKH, ThoiDiemThanhToan, TongHoaDon, MaBaoGia, TaoVaoLuc, TaoBoi)
VALUES
(N'Hóa đơn thanh toán khóa học Business Analyst của Phan Duy Trọng', N'Phan Duy Trọng', '2023-04-29 03:07:18', 3400000, 'QUO1', '2023-04-29 03:07:18', N'Hệ thống'),
(N'Hóa đơn thanh toán khóa học Product Owner Master Class của Bùi Xuân Vĩ', N'Bùi Xuân Vĩ', '2023-01-10 10:24:05', 5400000, 'QUO2', '2023-04-13 08:39:39', N'Hệ thống'),
(N'Hóa đơn thanh toán khóa học Product Owner Master Class của Bùi Xuân Vĩ', N'Nguyễn Thu Việc','2023-02-19 18:24:15', 5400000, 'QUO3', '2023-02-19 18:24:39', N'Hệ thống');
GO
-- SELECT * FROM HoaDon

/* Bảng ChiTietKhoaHocThuocHoaDon */
INSERT INTO ChiTietKhoaHocThuocHoaDon(MaHoaDon, MaKhoaHoc, TenKhoaHoc, GiangVien, GiaTien)
VALUES
    ('INV1', 'CRS1', N'IT Business Analysis', N'Ryan Nguyễn', 4000000),
    ('INV2', 'CRS2', N'Product Owner Master Class', N'Harry Phạm', 5400000),
    ('INV3', 'CRS2', N'Product Owner Master Class', N'Harry Phạm', 5400000);
GO
-- SELECT * FROM ChiTietKhoaHocThuocHoaDon


/* Bảng HoatDongKH */
INSERT INTO HoatDongKH(MaKH, TenHDKH, LoaiHDKH, HDKHDuocTaoBoi, MaNVPhuTrachHDKH, TenNVPhuTrachHDKH, MaEmailDenKH, TaoVaoLuc)
VALUES 
    ('CUS1', N'Yêu cầu tư vấn khóa học đến Trương Minh Tiến', N'Tư vấn', N'Khách hàng', 'STA5', N'Trương Minh Tiến', NULL, '2023-12-01 8:00:00'),
    ('CUS2', N'Yêu cầu tư vấn khóa học Database Foundation Class đến Bùi Bích Trâm', N'Tư vấn', N'Khách hàng', 'STA9', N'Bùi Bích Trâm', NULL, '2023-12-02 8:00:00'),
    ('CUS3', N'Yêu cầu tư vấn khóa học Business Intelligence đến Huỳnh Nhã Thy', N'Tư vấn', N'Khách hàng', 'STA11', N'Huỳnh Nhã Thy', NULL, '2023-12-03 8:00:00'),
    ('CUS4', N'Yêu cầu tư vấn khóa học đến Nguyễn Ngọc Hoàng', N'Tư vấn', N'Khách hàng', 'STA2', N'Nguyễn Ngọc Hoàng', NULL, '2023-12-04 8:00:00'),
    ('CUS5', N'Yêu cầu tư vấn khóa học đến Nguyễn Đức Trung', N'Tư vấn', N'Khách hàng', 'STA6', N'Nguyễn Đức Trung', NULL, '2023-12-05 8:00:00'),
    ('CUS6', N'Yêu cầu tư vấn khóa học đến Bùi Thị Thúy', N'Tư vấn', N'Khách hàng', 'STA7', N'Bùi Thị Thúy', NULL, '2023-12-06 8:00:00'),
    ('CUS7', N'Yêu cầu tư vấn khóa học Desktop Coding Class đến Trần Mỹ Hạnh', N'Tư vấn', N'Khách hàng', 'STA4', N'Trần Mỹ Hạnh', NULL, '2023-12-07 8:00:00'),
    ('CUS8', N'Yêu cầu tư vấn khóa học Business Data Engineer đến Võ Anh Thư', N'Tư vấn', N'Khách hàng', 'STA3', N'Võ Anh Thư', NULL, '2023-12-08 8:00:00');
GO
-- SELECT * FROM HoatDongKH


/* Bảng EmailMau */
INSERT INTO EmailMau (TieuDeEmailMau, MoTaEmailMau, NoiDungEmailMau, TrangThaiEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES
(N'Xác nhận yêu cầu tư vấn', N'Gửi thông tin xác nhận yêu cầu đã được tiếp nhận và thông tin của nhân viên tư vấn như tên, số điện thoại', 
N'Kính gửi bạn {{ten_lead}},

Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của tư vấn viên {{Lead PIC’s full name}}({{staff_phone_number}}) để được hỗ trợ nhanh nhất.

Trân trọng,
SKILLBOOST', N'Đang hoạt động', '2023-01-01 00:00:00', 'STA1', '2023-01-01 00:00:00', 'STA1'),
(N'Báo giá khóa học', N'Gửi báo giá của khóa học bao gồm giá tiền gốc, VAT, số tiền phải trả, thông tin chi tiết khóa học', 
N'Kính gửi bạn {{ten_lead}},

Cảm ơn bạn đã quan tâm đến khoá học {{ten_khoa_hoc}} tại SkillBoost.

Khóa học của chúng tôi được thiết kế để giúp học viên phát triển các kỹ năng cần thiết để thành công trong lĩnh vực công nghệ. Chúng tôi cũng cung cấp các dịch vụ hỗ trợ học viên sau khi tốt nghiệp, giúp họ tìm kiếm việc làm phù hợp với năng lực. Bạn có thể xem thông tin chi tiết khoá học và trải nghiệm học thử tại trang web chính thức của SkillBoost: www.skillboost.vn

Chúng tôi xin gửi bạn báo giá khoá học và thông tin thanh toán dưới đây: 

Người đăng ký: {{ten_lead}}

Khoá học đăng ký: {{ten_khoa_hoc}}

Giảng viên: {{giang_vien}}

Giá tiền: {{hoc_phi}}

Tổng tiền khoá học: {{tongtien}}

Mã giảm giá: {{ma_giam_gia}}

Phần trăm giảm giá: {{phan_tram_giam_gia}}

Số tiền giảm giá: 

Tổng tiền cần thanh toán: 

Vui lòng truy cập website khoá học của chúng tôi, đăng nhập vào tài khoản của bạn và chọn khoá học để tiến hành thanh toán. Hoặc bạn có thể thanh toán ngay tại link đính kèm sau đây: Thanh toán khoá học

Cần hỗ trợ thêm về thông tin liên quan đến giá và chi tiết khoá học, bạn vui lòng phản hồi Email hoặc Hotline {{ten_nhan_vien}} (Tư vấn viên {{nguoi_phu_trach_lead}}) nhé!

Trân trọng,
SKILLBOOST', 
N'Đang hoạt động', '2023-01-01 00:00:00', 'STA1', '2023-02-03 18:43:46', 'STA1'),
(N'Xác nhận thanh toán học phí', N'Gửi thông tin xác nhận học phí của khóa học mà học viên đăng ký đã được thanh toán thành công kèm theo thêm thông tin nhân viên hỗ trợ', 
N'XÁC NHẬN THANH TOÁN

Kính gửi bạn {{ten_lead}},

Lời đầu tiên, chúng tôi xin cảm ơn bạn đã lựa chọn khoá học của SkillBoost Center, chúng tôi xin gửi bạn thông tin khoá học và biên nhận thanh toán học phí khoá học dưới đây:

Thông tin khoá học

Mã khoá học: {{ma_khoa_hoc}}

Tên khoá học: {{ten_khoa_hoc}}

Giảng viên: {{giang_vien}}

Hình thức học: Online

Thời gian học dự kiến: {{ngay_khai_giang}}

Biên nhận khoá học

Mã đơn hàng: {{ma_hoa_don}}

Học phí: {hoc_phi}}

Ưu đãi: {{ma_giam_gia}}

Thành tiền: 

Đã thanh toán

Cảm ơn bạn và hy vọng bạn có một trải nghiệm tuyệt vời với SkillBoost.  Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline {{ten_nhan_vien}} (Tư vấn viên {{nguoi_phu_trach_lead}}) nhé!

Trân trọng,
SKILLBOOST', 
N'Đang hoạt động', '2023-01-01 00:00:00', 'STA1', '2023-01-01 00:00:00', 'STA1'),


(N'Thông báo đăng ký khóa học thành công', N'Gửi thông báo xác nhận khóa học đã được học viên đăng ký thành công', 
N'Kính gửi bạn {{ten_lead}},

Chúc mừng bạn đã đăng ký khóa học {{ten_khoa_hoc}} thành công tại SkillBoost!

Để tham gia khóa học, bạn vui lòng truy cập vào trang web của SkillBoost và đăng nhập bằng tài khoản của mình. Sau khi đăng nhập, bạn sẽ tìm thấy khóa học {{ten_khoa_hoc}} trong danh sách khóa học của mình. Bạn có thể bắt đầu học ngay lập tức.

Chúng tôi hy vọng bạn sẽ có một khóa học học tập hiệu quả và đạt được mục tiêu của mình. Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline {{ten_nhan_vien}} (Tư vấn viên {{nguoi_phu_trach_lead}}) nhé!

Trân trọng,
SKILLBOOST', 
N'Đang hoạt động', '2023-01-01 00:00:00', 'STA1', '2023-02-03 00:00:00', 'STA1');
GO
--SELECT * FROM EmailMau

/*USE CASE 7*/
/* Bảng Email */
-- EML001
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES(
    N'Báo giá khóa học',
    N'Kính gửi bạn Phan Duy Trọng,

    Cảm ơn bạn đã quan tâm đến khoá học Become a Business Analyst Class tại SkillBoost.

    Khóa học của chúng tôi được thiết kế để giúp học viên phát triển các kỹ năng cần thiết để thành công trong lĩnh vực công nghệ. Chúng tôi cũng cung cấp các dịch vụ hỗ trợ học viên sau khi tốt nghiệp, giúp họ tìm kiếm việc làm phù hợp với năng lực. Bạn có thể xem thông tin chi tiết khoá học và trải nghiệm học thử tại trang web chính thức của SkillBoost: www.skillboost.vn

    Chúng tôi xin gửi bạn báo giá khoá học và thông tin thanh toán dưới đây: 

    Người đăng ký: Phan Duy Trọng

    Khoá học đăng ký: Become a Business Analyst

    Giảng viên: Ryan Nguyễn

    Giá tiền: 4.000.000đ

    Mã giảm giá: DIC001

    Phần trăm giảm giá: 15%',
    '2023-04-30 10:51:08', N'NguoiNhan', N'Đã gửi', NULL, 'QUO1', NULL, 'EMT2', '2023-04-30 10:51:08', N'Hệ thống', '2023-04-30 11:00:00', N'STA5');
-- EML002
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Xác nhận thanh toán học phí',
    N'XÁC NHẬN THANH TOÁN

    Kính gửi bạn Phan Duy Trọng

    Lời đầu tiên, chúng tôi xin cảm ơn bạn đã lựa chọn khoá học của SkillBoost , chúng tôi xin gửi bạn thông tin khoá học và biên nhận thanh toán học phí khoá học dưới đây:

    Thông tin khoá học

    Mã khoá học: CRS001

    Tên khoá học: Become a Business Analyst

    Giảng viên: Ryan Nguyễn

    Hình thức học: Online

    Thời gian học dự kiến: 32

    Biên nhận khoá học

    Mã đơn hàng: ID01468790

    Học phí: 4.000.000

    Ưu đãi: 600.000 (15%)

    Thành tiền: 3.600.000

    Đã thanh toán: 3.600.000

    Cảm ơn bạn và hy vọng bạn có một trải nghiệm tuyệt vời với SkillBoost . Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline 0998123456 (Tư vấn viên Thy) nhé!

    Trân trọng,
    SKILLBOOST',
    '2023-04-29 03:07:18', N'Phan Duy Trọng', N'Đã gửi', NULL, NULL, 'INV1', 'EMT3', '2023-04-29 03:07:18', N'Hệ thống', '2023-04-29 03:30:29', N'STA5');
-- EML003
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Thông báo đăng ký khóa học thành công',
    N'Kính gửi bạn Phan Duy Trọng,

    Chúc mừng bạn đã đăng ký khóa học Become a Business Analyst thành công tại SkillBoost !

    Để tham gia khóa học, bạn vui lòng truy cập vào trang web của SkillBoost và đăng nhập bằng tài khoản của mình. Sau khi đăng nhập, bạn sẽ tìm thấy khóa học Become a Business Analystntrong danh sách khóa học của mình. Bạn có thể bắt đầu học ngay lập tức.

    Chúng tôi hy vọng bạn sẽ có một khóa học học tập hiệu quả và đạt được mục tiêu của mình. Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline 0998123456 (Tư vấn viên Thy) nhé!

    Trân trọng,
    SKILLBOOST',
    '2023-01-12 05:36:25', N'Phan Duy Trọng', N'Đã gửi', NULL, NULL, NULL, 'EMT4', '2023-01-12 05:36:25', N'Hệ thống', '2023-01-12 05:36:25', N'STA5');
-- EML004
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Xác nhận thanh toán học phí',
    N'XÁC NHẬN THANH TOÁN

    Kính gửi bạn Bùi Xuân Vĩ

    Lời đầu tiên, chúng tôi xin cảm ơn bạn đã lựa chọn khoá học của SkillBoost , chúng tôi xin gửi bạn thông tin khoá học và biên nhận thanh toán học phí khoá học dưới đây:

    Thông tin khoá học

    Mã khoá học: CRS002

    Tên khoá học: Product Owner Master Class

    Giảng viên: Hary Phạm

    Hình thức học: Online

    Thời gian học dự kiến: 40

    Biên nhận khoá học

    Mã đơn hàng: ID01468791

    Học phí: 5.400.000đ

    Ưu đãi: 0%

    Thành tiền: 5.400.000đ

    Đã thanh toán: 5.400.000đ

    Cảm ơn bạn và hy vọng bạn có một trải nghiệm tuyệt vời với SkillBoost . Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline 0928123456 (Tư vấn viên Mai) nhé!

    Trân trọng,
    SKILLBOOST',
    '2023-10-01 10:24:05', N'Bùi Xuân Vĩ', N'Đã gửi', NULL, NULL, 'INV2', 'EMT3', '2023-10-02 10:24:05', N'Hệ thống', '2023-10-02 10:24:05', N'STA6');
-- EML005
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Thông báo đăng ký khóa học thành công',
    N'Kính gửi bạn Bùi Xuân Vĩ,

    Chúc mừng bạn đã đăng ký khóa học Product Owner Master Class thành công tại SkillBoost !

    Để tham gia khóa học, bạn vui lòng truy cập vào trang web của SkillBoost và đăng nhập bằng tài khoản của mình. Sau khi đăng nhập, bạn sẽ tìm thấy khóa học Become a Business Analystntrong danh sách khóa học của mình. Bạn có thể bắt đầu học ngay lập tức.

    Chúng tôi hy vọng bạn sẽ có một khóa học học tập hiệu quả và đạt được mục tiêu của mình. Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline 0928123456 (Tư vấn viên Mai) nhé!

    Trân trọng,
    SKILLBOOST',
    '2023-04-13 08:39:39', N'Bùi Xuân Vĩ', N'Đã gửi', NULL, NULL, NULL, 'EMT4', '2023-01-13 08:39:39', N'Hệ thống', '2023-01-13 08:39:39', N'STA6');
-- EML006
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Báo giá khóa học',
    N'Kính gửi bạn Bùi Xuân Vĩ,

    Cảm ơn bạn đã quan tâm đến khoá học Become a Business Analyst Class tại SkillBoost.

    Khóa học của chúng tôi được thiết kế để giúp học viên phát triển các kỹ năng cần thiết để thành công trong lĩnh vực công nghệ. Chúng tôi cũng cung cấp các dịch vụ hỗ trợ học viên sau khi tốt nghiệp, giúp họ tìm kiếm việc làm phù hợp với năng lực. Bạn có thể xem thông tin chi tiết khoá học và trải nghiệm học thử tại trang web chính thức của SkillBoost: www.skillboost.vn

    Chúng tôi xin gửi bạn báo giá khoá học và thông tin thanh toán dưới đây: 

    Người đăng ký: Bùi Xuân Vĩ

    Khoá học đăng ký: Product Owner Master Class

    Giảng viên: Hary Phạm

    Giá tiền: 5.400.000đ

    Mã giảm giá:

    Phần trăm giảm giá: 0%

    Số tiền giảm giá:

    Tổng tiền cần thanh toán: 5.400.000đ


    Thông tin mã giảm giá đã được liên kết với tài khoản của bạn. Vui lòng truy cập website khoá học của chúng tôi, đăng nhập vào tài khoản của bạn và nhập mã giảm giá trên ở trang thanh toán để có thể có được mức giá ưu đãi như thoả thuận. Hoặc bạn có thể thanh toán ngay tại link đính kèm sau đây: Thanh toán khoá học 

    Cần hỗ trợ thêm về thông tin liên quan đến giá và chi tiết khoá học, bạn vui lòng phản hồi Email hoặc Hotline 0928123456 (Tư vấn viên Mai) nhé!

    Trân trọng,
    SKILLBOOST',
    '2023-02-28 18:38:44', N'Bùi Xuân Vĩ', N'Đã gửi', NULL, 'QUO2', NULL, 'EMT2', '2023-02-28 18:38:44', N'Hệ thống', '2023-02-28 19:00:25', N'STA6');
-- EML007
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Xác nhận yêu cầu tư vấn',
    N'Kính gửi bạn Nguyễn Thu Việc,

    Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

    Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của Tư vấn viên Trâm (0938123456) để được hỗ trợ nhanh nhất.

    Trân trọng,
    SKILLBOOST',
    '2023-09-12 14:44:35', N'Nguyễn Thu Việc', N'Lên lịch', 'CON1', NULL, NULL, 'EMT1', '2023-09-11 13:45:35', N'Hệ thống', '2023-09-11 14:04:24', N'STA2');
-- EML008
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Xác nhận yêu cầu tư vấn',
    N'Kính gửi bạn Phan Văn Trị,

    Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

    Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của Tư vấn viên Mai (0928123456) để được hỗ trợ nhanh nhất.

    Trân trọng,
    SKILLBOOST',
    '2023-11-15 10:52:43', N'Phan Văn Trị', N'Bản nháp', NULL, NULL, NULL, 'EMT1', '2023-11-15 10:52:43', N'Hệ thống', '2023-11-15 10:52:43', N'STA9');
-- EML009
INSERT INTO Email(TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail, MaYCTV, MaBaoGia, MaHoaDon, MaEmailMau, TaoVaoLuc, TaoBoi, ChinhSuaLanCuoiVaoLuc, ChinhSuaLanCuoiBoi)
VALUES (
    N'Xác nhận yêu cầu tư vấn',
    N'Kính gửi bạn Nguyễn Hoàng Minh,

    Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

    Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của Tư vấn viên Trâm (0938123456) để được hỗ trợ nhanh nhất.

    Trân trọng,
    SKILLBOOST',
    '2023-01-17 23:15:47', N'Nguyễn Hoàng Minh', N'Error', 'CON2', NULL, NULL, 'EMT1', '2023-01-17 23:15:47', N'Hệ thống', '2023-01-17 23:15:47', N'STA4');
GO
--SELECT * FROM Email



