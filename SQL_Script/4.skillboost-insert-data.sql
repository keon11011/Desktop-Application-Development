GO 
USE SkillBoost

/* INSERT DATA */
/*USE CASE 1*/
/* Bảng NhanVien */
INSERT INTO NhanVien
VALUES 
('STA000', N'Nguyễn Phương Thanh', N'Nữ', '1956-10-13', N'Quản lý', '0797979797', 'ngphthanh@gmail.com', N'Đang hoạt động', '2021-12-31 08:00:00', N'Hệ thống', '2021-12-31 09:00:00', 'STA000'),
('STA001', N'Nguyễn Ngọc Hoàng', N'Nam', '1990-05-15', N'Nhân viên', '0987123456', 'hoangnguyenngoc@gmail.com', N'Đang hoạt động', '2022-01-01 08:00:00', 'STA000', '2022-01-01 10:30:00', 'STA000'),
('STA002', N'Võ Anh Thư', N'Nữ', '1988-09-25', N'Nhân viên', '0908123456', 'anhthuvo@gmail.com', N'Đang hoạt động', '2022-01-02 09:15:00', 'STA000', '2022-01-02 14:45:00', 'STA000'),
('STA003', N'Trần Mỹ Hạnh', N'Nữ', '1995-11-10', N'Nhân viên', '0978123456', 'hanhmytran@gmail.com', N'Đang hoạt động', '2022-01-03 11:30:00', 'STA000', '2022-01-03 16:20:00', 'STA000'),
('STA004', N'Trương Minh Tiến', N'Nam', '1982-03-02', N'Nhân viên', '0918123456', 'minhtientruong@gmail.com', N'Đang hoạt động', '2022-01-04 13:45:00', 'STA000', '2022-01-04 18:10:00', 'STA000'),
('STA005', N'Nguyễn Đức Trung', N'Nam', '1993-07-20', N'Nhân viên', '0968123456', 'ductrungnguyen@gmail.com', N'Đang hoạt động', '2022-01-05 15:00:00', 'STA000', '2022-01-05 20:05:00', 'STA000'),
('STA006', N'Bùi Thị Thúy', N'Nữ', '1987-01-12', N'Nhân viên', '0958123456', 'thuythibui@gmail.com', N'Đang hoạt động', '2022-01-06 17:15:00', 'STA000', '2022-01-06 22:40:00', 'STA000'),
('STA007', N'Trần Thúy Hằng', N'Nữ', '1984-06-30', N'Nhân viên', '0948123456', 'hangthuytran@gmail.com', N'Đang hoạt động', '2022-01-07 19:30:00', 'STA000', '2022-01-07 20:00:00', 'STA000'),
('STA008', N'Bùi Bích Trâm', N'Nữ', '1999-12-05', N'Nhân viên', '0938123456', 'trambichbui@gmail.com', N'Đang hoạt động', '2022-01-08 21:45:00', 'STA000', '2022-01-08 14:15:00', 'STA000'),
('STA009', N'Trần Thanh Mai', N'Nữ', '1986-04-18', N'Nhân viên', '0928123456', 'maithanhtran@gmail.com', N'Đang hoạt động', '2022-01-09 23:59:00', 'STA000', '2022-02-09 08:50:00', 'STA000'),
('STA010', N'Huỳnh Nhã Thy', N'Nữ', '1991-08-08', N'Nhân viên', '0998123456', 'nhathythuynh@gmail.com', N'Đang hoạt động', '2022-01-10 02:30:00', 'STA000', '2022-01-10 16:30:00', 'STA000');
--SELECT * FROM NhanVien

/* Bảng TaiKhoan */

INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC000','ngphthanh@gmai.com','secretKey',N'Đang hoạt động','STA000','2021-12-21 8:00:00',N'Hệ thống','2021-12-31 8:00:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC001','hoangnguyenngoc@gmail.com','pass@123',N'Đang hoạt động','STA001','2022-01-01 8:00:00',N'Hệ thống','2022-01-01 8:00:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC002','anhthuvo@gmail.com','strongPwd',N'Đang hoạt động','STA002','2022-01-02 9:15:00',N'Hệ thống','2022-01-02 9:15:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC003','hanhmytran@gmail.com','mySecret',N'Đang hoạt động','STA003','2022-01-03 11:30:00',N'Hệ thống','2022-01-03 11:30:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC004','minhtientruong@gmail.com','p@ssw0rd',N'Đang hoạt động','STA004','2022-01-04 13:45:00',N'Hệ thống','2022-01-04 13:45:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC005','ductrungnguyen@gmail.com','secure123',N'Vô hiệu hóa','STA005','2022-01-05 15:00:00',N'Hệ thống','2022-01-05 15:00:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC006','thuythibui@gmail.com','12345pass',N'Đang hoạt động','STA006','2022-01-06 17:15:00',N'Hệ thống','2022-01-06 17:15:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC007','hangthuytran@gmail.com','secretPwd',N'Đang hoạt động','STA007','2022-01-07 19:30:00',N'Hệ thống','2022-01-07 19:30:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC008','trambichbui@gmail.com','password123',N'Vô hiệu hóa','STA008','2022-01-08 21:45:00',N'Hệ thống','2022-01-08 21:45:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC009','maithanhtran@gmail.com','secretPass',N'Đang hoạt động','STA009','2022-01-09 23:59:00',N'Hệ thống','2022-01-09 23:59:00',N'Hệ thống');
INSERT INTO TaiKhoan(MaTK,EmailTK,MatKhauTK,TrangThaiTK,MaNV,TaoVaoLuc,TaoBoi,ChinhSuaLanCuoiVaoLuc,ChinhSuaLanCuoiBoi) VALUES ('ACC010','nhathythuynh@gmail.com','pass2023',N'Đang hoạt động','STA010','2022-01-10 2:30:00',N'Hệ thống','2022-01-10 2:30:00',N'Hệ thống');

/* Bảng NgheNghiep */
INSERT INTO NgheNghiep
VALUES 
('OCU001', N'Nhiếp ảnh', N'Đang được đưa vào sử dụng', '2023-07-01 08:00:00', N'Hệ thống', '2023-07-01 08:00:00', N'Hệ thống'),
('OCU002', N'Phân tích dữ liệu', N'Đang được đưa vào sử dụng', '2023-06-02 09:15:00', N'Hệ thống', '2023-06-02 09:15:00', N'Hệ thống'),
('OCU003', N'Chuyên viên kinh doanh', N'Đang được đưa vào sử dụng', '2023-05-03 11:30:00', N'Hệ thống', '2023-05-03 11:30:00', N'Hệ thống'),
('OCU004', N'Giảng viên', N'Đang được đưa vào sử dụng', '2023-04-04 13:45:00', N'Hệ thống', '2023-04-04 13:45:00', N'Hệ thống'),
('OCU005', N'Học sinh - Sinh viên', N'Đang được đưa vào sử dụng', '2023-03-05 15:00:00', N'Hệ thống', '2023-03-05 15:00:00', N'Hệ thống'),
('OCU006', N'Bác sĩ', N'Đang được đưa vào sử dụng', '2023-02-06 17:15:00', N'Hệ thống', '2023-02-06 17:15:00', N'Hệ thống'),
('OCU007', N'Mua bán', N'Đang được đưa vào sử dụng', '2023-01-07 19:30:00', N'Hệ thống', '2023-01-07 19:30:00', N'Hệ thống'),
('OCU008', N'Nhà báo', N'Đang được đưa vào sử dụng', '2023-12-08 21:45:00', N'Hệ thống', '2023-12-08 21:45:00', N'Hệ thống'),
('OCU009', N'Nhân viên bất động sản', N'Đang được đưa vào sử dụng', '2023-11-09 23:59:00', N'Hệ thống', '2023-11-09 23:59:00', N'Hệ thống'),
('OCU010', N'Người kinh doanh', N'Đang được đưa vào sử dụng', '2023-10-10 02:30:00', N'Hệ thống', '2023-10-10 02:30:00', N'Hệ thống');
-- SELECT * FROM NgheNghiep

/*USE CASE 3*/
/* Bảng Lead */
INSERT INTO Lead
VALUES 
('LEA001', N'Ngô Thị Kim Cương', N'Nữ', '1991-06-30', '0777007007', 'kimcuongngothi@gmail.com', 'OCU001', N'Nhiếp ảnh', 'STA007', N'Trần Thúy Hằng', N'Đang tư vấn', NULL, N'LinkedIn', NULL, NULL, '2023-07-01 08:00:00', N'Hệ thống', '2023-07-01 10:30:00', 'STA007'),
('LEA002', N'Nguyễn Hoàng Minh', N'Nam', '1978-12-05', '0999888777', 'minhhoangnguyen@gmail.com', 'OCU002', N'Phân tích dữ liệu', 'STA004', N'Trương Minh Tiến', N'Chờ tư vấn', NULL, N'Website', NULL, NULL, '2023-06-02 09:15:00', N'Hệ thống', '2023-06-02 14:45:00', 'STA004'),
('LEA003', N'Nguyễn Thu Việc', N'Nữ', '1988-03-02', '0888777666', 'viecthunguyen@gmail.com', 'OCU003', N'Chuyên viên kinh doanh', 'STA002', N'Võ Anh Thư', N'Chờ tư vấn', NULL, N'Truyền miệng', NULL, NULL, '2023-05-03 11:30:00', N'Hệ thống', '2023-05-03 16:20:00', 'STA002'),
('LEA004', N'Lê Minh Quân', N'Nam', '1992-09-25', '0123456789', 'minhquanle@gmail.com', 'OCU004', N'Giảng viên', 'STA009', N'Trần Thanh Mai', N'Đang tư vấn', NULL, N'Facebook', NULL, NULL, '2023-04-04 13:45:00', N'Hệ thống', '2023-04-04 18:10:00', 'STA009'),
('LEA005', N'Dương Thùy Dương', N'Nữ', '2002-04-18', '0333222111', 'duongthuyduong@gmail.com', 'OCU005', N'Học sinh - Sinh viên', 'STA010', N'Huỳnh Nhã Thy', N'Ngừng theo dõi', NULL, N'Truyền miệng', NULL, NULL, '2023-03-05 15:00:00', N'Hệ thống', '2023-03-05 20:05:00', 'STA010'),
('LEA006', N'Phan Duy Trọng', N'Nam', '2003-05-15', '0987654321', 'trongphanduy@gmail.com', 'OCU005', N'Học sinh - Sinh viên', 'STA005', N'Nguyễn Đức Trung', N'Đã thanh toán', NULL, N'Facebook', NULL, NULL, '2023-02-06 17:15:00', N'Hệ thống', '2023-02-06 22:40:00', 'STA005'),
('LEA007', N'Trần Kim Ngọc', N'Nữ', '1985-10-11', '0909090909', 'ngockimtran@gmail.com', 'OCU006', N'Bác sĩ', 'STA001', N'Nguyễn Ngọc Hoàng', N'Đang tư vấn', NULL, N'Website', NULL, NULL, '2023-01-07 19:30:00', N'Hệ thống', '2023-01-08 09:25:00', 'STA001'),
('LEA008', N'Lâm Thy Nhã', N'Nữ', '1979-07-20', '0555666777', 'nhalamthy@gmail.com', 'OCU007', N'Mua bán', 'STA008', N'Bùi Bích Trâm', N'Chờ tư vấn', NULL, N'Linkedln', NULL, NULL, '2023-12-08 21:45:00', N'Hệ thống', '2023-12-09 14:15:00', 'STA008'),
('LEA009', N'Bùi Xuân Vĩ', N'Nam', '1982-01-12', '0444333222', 'vixuanbui@gmail.com', 'OCU008', N'Nhà báo', 'STA006', N'Bùi Thị Thúy', N'Đã thanh toán', NULL, N'Facebook', NULL, NULL, '2023-11-09 23:59:00', N'Hệ thống', '2023-11-10 08:50:00', 'STA006'),
('LEA010', N'Dương Bích Tuyền', N'Nữ', '1983-08-08', '0111222333', 'tuyenbichduong@gmail.com', 'OCU009', N'Nhân viên bất động sản', 'STA003', N'Trần Mỹ Hạnh', N'Ngừng theo dõi', NULL, N'Facebook', NULL, NULL, '2023-10-10 02:30:00', N'Hệ thống', '2023-10-10 16:30:00', 'STA003');
-- SELECT * FROM Lead

/* Bảng HoatDongLead */
INSERT INTO HoatDongLead
VALUES 
('LAC001', 'LEA001', N'Yêu cầu tư vấn đến Trần Thúy Hằng', N'Tư vấn', N'Lead', 'STA007', N'Trần Thúy Hằng', NULL, '2023-08-12 08:00:00'),
('LAC002', 'LEA002', N'Yêu cầu tư vấn đến Trương Minh Tiến', N'Tư vấn', N'Lead', 'STA004', N'Trương Minh Tiến', NULL, '2023-11-01 08:00:00'),
('LAC003', 'LEA003', N'Yêu cầu tư vấn đến Võ Anh Thư', N'Tư vấn', N'Lead', 'STA002', N'Võ Anh Thư', NULL, '2023-09-11 08:00:00'),
('LAC004', 'LEA004', N'Yêu cầu tư vấn đến Trần Thanh Mai', N'Tư vấn', N'Lead', 'STA009', N'Trần Thanh Mai', NULL, '2023-09-12 08:00:00'),
('LAC005', 'LEA005', N'Yêu cầu tư vấn đến Huỳnh Nhã Thy', N'Tư vấn', N'Lead', 'STA010', N'Huỳnh Nhã Thy', NULL, '2023-10-12 08:00:00'),
('LAC006', 'LEA006', N'Yêu cầu báo giá khóa học đến Nguyễn Đức Trung', N'Yêu cầu', N'Lead', 'STA005', N'Nguyễn Đức Trung', NULL, '2023-04-22 08:00:00'),
('LAC007', 'LEA007', N'Yêu cầu tư vấn đến Nguyễn Ngọc Hoàng', N'Tư vấn', N'Lead', 'STA001', N'Nguyễn Ngọc Hoàng', NULL, '2023-12-15 08:00:00'),
('LAC008', 'LEA008', N'Yêu cầu báo giá khóa học đến Bùi Bích Trâm', N'Yêu cầu', N'Lead', 'STA008', N'Bùi Bích Trâm', NULL, '2023-12-17 08:00:00'),
('LAC009', 'LEA009', N'Yêu cầu báo giá khóa học đến Bùi Thị Thúy', N'Yêu cầu', N'Lead', 'STA006', N'Bùi Thị Thúy', NULL, '2023-02-27 08:00:00'),
('LAC010', 'LEA010', N'Yêu cầu tư vấn đến Trần Mỹ Hạnh', N'Tư vấn', N'Lead', 'STA003', N'Trần Mỹ Hạnh', NULL, '2023-12-24 08:00:00');
-- SELECT * FROM HoatDongLead



/*USE CASE 2*/
/* Bảng YeuCauTuVan */ 
INSERT INTO YeuCauTuVan
VALUES 
('CON001', N'Nguyễn Thu Việc', '1988-03-02', 'viecthunguyen@gmail.com', '0888777666', NULL, N'Đã tiếp nhận', '2023-09-11 13:45:35', 'LEA003'),
('CON002', N'Nguyễn Hoàng Minh', '1978-12-05', 'minhhoangnguyen@gmail.com', '0999888777', NULL, N'Đã tiếp nhận', '2023-01-17 23:15:47', 'LEA002'),
('CON003', N'Phan Duy Trọng', '2003-05-15', 'trongphanduy@gmail.com', '0987654321', NULL, N'Đã tiếp nhận', '2023-01-22 01:51:15', 'LEA006'),
('CON004', N'Bùi Xuân Vĩ', '1982-01-12', 'vixuanbui@gmail.com', '0444333222', NULL, N'Đã tiếp nhận', '2023-01-08 01:20:08', 'LEA009');
--SELECT * FROM YeuCauTuVan

/*USE CASE 6*/

/* Bảng LoaiKhoaHoc */
INSERT INTO LoaiKhoaHoc
VALUES
    ('CID001', 'IT', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('CID002', 'PO', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('CID003', 'SQL', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('CID004', 'DATA', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống'),
    ('CID005', 'BI', N'Đang hoạt động', '2023-01-01 00:00:00', N'Hệ thống', '2023-01-01 00:00:00', N'Hệ thống');
-- SELECT * FROM LoaiKhoaHoc

/* Bảng KhoaHoc */
INSERT INTO KhoaHoc
VALUES
    ('CRS001', N'IT Business Analysis', N'Khóa học IT Business Analysis, học viên sẽ được giảng dạy các kỹ năng cơ bản và công cụ phân tích kinh doanh, bao gồm thu thập và phân tích yêu cầu, mô hình hóa quy trình kinh doanh, xác định và giải quyết vấn đề, và quản lý dự án. Họ sẽ tìm hiểu về các phương pháp và kỹ thuật phân tích yêu cầu, cách thực hiện các cuộc phỏng vấn và phân tích tài liệu, cùng với việc sử dụng các công cụ và phần mềm hỗ trợ như Microsoft Visio, Excel, và các hệ thống quản lý yêu cầu.', N'36 giờ', N'Ryan Nguyễn', N'Người mới', 42, 4000000, '2023-02-22', '2023-03-22', 4.5, N'Đang vận hành', 'CID001', '2023-01-14 01:04:10', N'Hệ Thống', '2023-01-15 06:38:49', N'Hệ Thống'),
    ('CRS002', N'Product Owner Master Class', N'Khóa học Product Owner Master Class là một chương trình đào tạo chuyên sâu dành cho những người muốn trở thành Product Owner chuyên nghiệp hoặc muốn nâng cao kỹ năng quản lý sản phẩm của mình. Khóa học này cung cấp kiến thức và công cụ cần thiết để thành công trong vai trò Product Owner trong một dự án phát triển phần mềm hoặc sản phẩm công nghệ.', N'54 giờ', N'Harry Phạm', N'Đã có kinh nghiệm', 41, 5400000, '2023-04-25', '2023-06-10', 4, N'Đang vận hành', 'CID002', '2023-02-23 14:32:22', N'Hệ Thống', '2023-02-27 11:57:47', N'Hệ Thống'),
    ('CRS003', N'SQL Advanced Class', N'Khóa học SQL Advanced Class là một khóa học đào tạo chuyên sâu nhằm cung cấp kiến thức và kỹ năng cao cấp về ngôn ngữ truy vấn SQL (Structured Query Language). Khóa học này dành cho những người đã có kiến thức cơ bản về SQL và muốn nâng cao khả năng của mình trong việc truy vấn, phân tích và quản lý cơ sở dữ liệu.', N'192 giờ', N'Jerry Bùi', N'Đã có kinh nghiệm', 31, 4914000, '2023-06-28', '2023-11-13', 4, N'Đang vận hành', 'CID003', '2023-05-30 12:15:47', N'Hệ Thống', '2023-06-12 11:26:18', N'Hệ Thống'),
    ('CRS004', N'Data Analysis', N'Khóa học Data Analysis là một chương trình đào tạo được thiết kế để giúp học viên nắm vững các kỹ năng và công cụ cần thiết để hiểu, phân tích và trích xuất thông tin từ dữ liệu. Khóa học này nhằm cung cấp kiến thức và kỹ năng cần thiết để học viên có thể làm việc với dữ liệu số, tạo ra thông tin hữu ích và đưa ra quyết định dựa trên dữ liệu.', N'144 giờ', N'Phil Phan', N'Người mới', 45, 4429000, '2023-10-05', '2024-01-05', 4.5, N'Đang vận hành', 'CID004', '2023-06-17 20:40:55', N'Hệ Thống', '2023-08-20 02:06:10', N'Hệ Thống'),
    ('CRS005', N'Business Intelligence', N'Khóa học Business Intelligence là một chương trình đào tạo nhằm cung cấp kiến thức và kỹ năng cần thiết để hiểu, phân tích và sử dụng thông tin kinh doanh để hỗ trợ quyết định và phát triển chiến lược kinh doanh.', N'36 giờ', N'Anh Tú', N'Người mới', 30, 5482000, '2023-12-15', '2024-01-15', 3.5, N'Đang vận hành', 'CID005', '2023-07-21 21:14:47', N'Hệ Thống', '2023-07-26 03:35:44', N'Hệ Thống'),
    ('CRS006', N'Excel Advanced Class', N'Khóa học Excel Advanced Class là một chương trình đào tạo nhằm cung cấp kiến thức và kỹ năng nâng cao về việc sử dụng Microsoft Excel, một trong những công cụ phổ biến nhất trong việc xử lý và phân tích dữ liệu.', N'48 giờ', N'Ngọc Thu', N'Chuyên gia', 33, 4704000, '2023-03-28', '2023-04-28', 4, N'Đang vận hành', 'CID004', '2023-02-04 17:32:25', N'Hệ Thống', '2023-02-04 17:32:25', N'Hệ Thống'),
    ('CRS007', N'Database Foundation Class', N'Khóa học Database Foundation Class là một chương trình đào tạo cung cấp kiến thức cơ bản về cơ sở dữ liệu và các khái niệm quan trọng liên quan đến quản lý dữ liệu.', N'180 giờ', N'Tony Lê', N'Người mới', 29, 5317000, '2023-05-22', '2023-07-22', 3, N'Vô hiệu hóa', 'CID004', '2023-03-16 18:04:40', N'Hệ Thống', '2023-03-16 18:04:40', N'Hệ Thống'),
    ('CRS008', N'Desktop Coding Class', N'Khóa học Desktop Coding Class là một chương trình đào tạo nhằm giúp học viên học cách phát triển ứng dụng máy tính bằng việc sử dụng các ngôn ngữ lập trình và công cụ phát triển phần mềm trên máy tính.', N'174 giờ', N'Jennie Huỳnh', N'Người mới', 35, 4370000, '2023-10-05', '2023-12-05', 3.5, N'Đang chiêu sinh', 'CID001', '2023-08-05 18:26:46', N'Hệ Thống', '2023-08-05 18:26:46', N'Hệ Thống'),
    ('CRS009', N'Python Advance Coding Class', N'Khóa học Python Advanced Coding Class là một chương trình đào tạo nhằm giúp học viên nâng cao kỹ năng lập trình Python và hiểu sâu về các khái niệm và kỹ thuật phức tạp trong ngôn ngữ này.', N'120 giờ', N'John Đặng', N'Đã có kinh nghiệm', 36, 4333000, '2023-11-20', '2024-03-20', 4, N'Đang vận hành', 'CID001', '2023-10-15 17:43:14', N'Hệ Thống', '2023-10-15 17:43:14', N'Hệ Thống'),
    ('CRS010', N'Business Data Engineer', N'Khóa học "Business Data Engineer" là một chương trình đào tạo nhằm trang bị học viên với kiến thức và kỹ năng cần thiết để trở thành một chuyên gia trong lĩnh vực kỹ thuật dữ liệu kinh doanh. Khóa học này tập trung vào các khía cạnh kỹ thuật và công nghệ liên quan đến quản lý, xử lý và phân tích dữ liệu trong môi trường doanh nghiệp.', N'240 giờ', N'Tuấn Vũ', N'Chuyên gia', 21, 5265000, '2023-12-11', '2024-05-11', 4.5, N'Đang vận hành', 'CID005', '2023-11-15 12:23:56', N'Hệ Thống', '2023-11-15 12:23:56', N'Hệ Thống');
-- SELECT * FROM KhoaHoc

/* Bảng ChiTietKhoaHocThuocYCTV */
INSERT INTO ChiTietKhoaHocThuocYeuCauTuVan
VALUES
('CON001', 'CRS002', N'Product Owner Master Class', N'Harry Phạm', 5400000),
('CON002', 'CRS003', N'SQL Advanced Class', N'Jerry Bùi', 4914000),
('CON003', 'CRS001', N'IT Business Analysis', N'Ryan Nguyễn', 4000000),
('CON004', 'CRS002', N'Product Owner Master Class', N'Harry Phạm', 5400000);
-- SELECT * FROM ChiTietKhoaHocThuocYeuCauTuVan

/*USE CASE 4*/
/* Bảng QuyDinhGiamGia */
INSERT INTO QuyDinhGiamGia
VALUES
('DIS001', N'Giảm giá cơ bản', 1, NULL, NULL, '2023-01-01', '2023-01-10', 0, 10, '2023-01-01 13:42:11', N'STA000', '2023-01-01 13:42:11', N'STA000'),
('DIS002', N'Giảm giá cho đối tượng ưu tiên', 1, 'OCU005', N'Học sinh - Sinh viên', '2023-03-22', '2023-03-22', 5, 15, '2023-03-22 18:55:04', N'STA000', '2023-03-22 18:55:04', N'STA000'),
('DIS003', N'Giảm giá cho đối tượng ưu tiên và ngày đặc biệt', 1, 'OCU005', N'Học sinh - Sinh viên', '2023-11-23', '2023-11-29', 10, 20, '2023-03-28 10:55:18', N'STA000', '2023-03-28 10:55:18', N'STA000'),
('DIS004', N'Giảm giá nâng cao', 2, NULL, NULL, '2023-01-22', '2023-01-22', 5, 15, '2023-01-22 16:01:33', N'STA000', '2023-01-22 16:01:33', N'STA000'),
('DIS005', N'Giảm giá cho khách hàng tiềm năng', 2, 'OCU005', N'Học sinh - Sinh viên', NULL, NULL, 10, 15, '2023-03-13 08:32:44', N'STA000', '2023-03-13 08:32:44', N'STA000'),
('DIS006', N'Giảm giá cho khách hàng tiềm năng và ngày đặc biệt', 2, 'OCU005', N'Học sinh - Sinh viên', '2023-11-23', '2023-11-29', 15, 15, '2023-02-04 20:37:15', N'STA000', '2023-02-04 20:37:15', N'STA000'),
('DIS007', N'Giảm giá cho khách hàng VIP', 3, NULL, NULL, NULL, NULL, 10, 20, '2023-01-04 18:57:40', N'STA000', '2023-01-04 18:57:40', N'STA000'),
('DIS008', N'Giảm giá ưu đãi thêm cho khách hàng VIP', 3, 'OCU005', N'Học sinh - Sinh viên', NULL, NULL, 15, 25, '2023-03-06 04:08:40', N'STA000', '2023-03-06 04:08:40', N'STA000'),
('DIS009', N'Giảm giá ưu đãi thêm cho khách hàng VIP và ngày đặc biệt', 3, 'OCU005', N'Học sinh - Sinh viên', '2023-11-23', '2023-11-29', 20, 30, '2023-03-31 09:14:21', N'STA000', '2023-03-31 09:14:21', N'STA000');
-- SELECT * FROM QuyDinhGiamGia

/* Bảng MaGiamGia */
INSERT INTO MaGiamGia 
VALUES
('DIC001', 'MUAGICUNGRE15', N'Cho cá nhân', 15, N'Khả dụng', 'DIS002', '2023-07-21 14:45:24', N'Hệ thống'),
('DIC002', 'HOCSINHSINHVIEN15', N'Cho nhóm', 10, N'Đang duyệt', 'DIS001', '2023-07-10 11:04:37', N'Hệ thống'),
('DIC003', 'NGAYPHUNU10', N'Cho cá nhân', 10, N'Khả dụng', 'DIS002', '2023-09-02 19:20:43', N'Hệ thống'),
('DIC004', 'NGAYNHAGIAOVIETNAM15', N'Cho cá nhân', 15, N'Khả dụng', 'DIS003', '2023-09-12 04:20:41', N'Hệ thống'),
('DIC005', 'NGAYSINHNHAT15', N'Cho cá nhân', 15, N'Khả dụng', 'DIS005', '2023-04-01 10:27:42', N'Hệ thống'),
('DIC006', 'CHAPCANHUOCMO5', N'Cho nhóm', 5, N'Khả dụng', 'DIS001', '2023-08-15 07:47:55', N'Hệ thống'),
('DIC007', 'BLACKFRIDAY20', N'Không giới hạn', 15, N'Hết hạn', 'DIS006', '2023-09-11 16:30:11', N'Hệ thống'),
('DIC008', 'WELCOME10', N'Cho nhóm', 10, N'Hết hạn', 'DIS001', '2023-11-02 05:25:32', N'Hệ thống'),
('DIC009', 'VIP20', N'Cho cá nhân', 20, N'Khả dụng', 'DIS003', '2023-05-18 08:21:16', N'Hệ thống'),
('DIC010', 'GIFT25', N'Không giới hạn', 25, N'Hết hạn', 'DIS009', '2023-04-21 06:41:30', N'Hệ thống');
-- SELECT * FROM MaGiamGia

/* Bảng ChiTietDoiTuongUuDai */
INSERT INTO ChiTietDoiTuongUuDai
VALUES
('DIC001', 'LEA006', N'Có'),
('DIC002', 'LEA007', N'Có'),
('DIC003', 'LEA009', N'Không'),
('DIC005', 'LEA004', N'Không'),
('DIC008', 'LEA003', N'Không');
-- SELECT * FROM ChiTietDoiTuongUuDai


/* Bảng BaoGia */
INSERT INTO BaoGia
VALUES
('QUO001', N'Báo giá cho khóa học online IT Business Analysis', 'LEA006', N'Phan Duy Trọng', 4000000, 'DIC001', 15, 3400000,
N'Đã thanh toán', '2023-04-30 10:51:08', N'Hệ thống', '2023-04-30 10:51:08', N'Hệ thống'),
('QUO002',  N'Báo giá cho khóa học online Product Owner Master Class', 'LEA009',  N'Bùi Xuân Vĩ', 5400000, NULL, NULL, 5400000,
N'Đã thanh toán', '2023-04-29 03:07:18', N'Hệ thống', '2023-04-29 03:07:18', N'Hệ thống'),
('QUO003', N'Báo giá cho khóa học online Product Owner Master Class', 'LEA003',  N'Nguyễn Thu Việc', 5400000, NULL, NULL, 5400000,
N'Chưa thanh toán', '2023-09-11 14:04:24', N'Hệ thống', '2023-09-11 14:04:24', N'Hệ thống'),
('QUO004', N'Báo giá cho khóa học online Business Intelligence', 'LEA004',  N'Lê Minh Quân', 5482000, 'DIC002', 10, 4933800,
N'Chưa thanh toán', '2023-09-15 17:56:52', N'Hệ thống', '2023-09-15 17:56:52', N'Hệ thống'),
('QUO005', N'Báo giá cho khóa học online Desktop Coding Class', 'LEA007',  N'Trần Kim Ngọc', 4370000, NULL, NULL, 4370000,
N'Đã hết hạn', '2023-02-23 10:43:42', N'Hệ thống', '2023-02-23 10:43:42', N'Hệ thống');
-- SELECT * FROM BaoGia

/* Bảng ChiTietKhoaHocThuocBaoGia */
INSERT INTO ChiTietKhoaHocThuocBaoGia
VALUES
('QUO001', 'CRS001', N'IT Business Analysis', N'Ryan Nguyễn', 4000000),
('QUO002', 'CRS002', N'Product Owner Master Class', N'Harry Phạm', 5400000),
('QUO003', 'CRS002', N'Product Owner Master Class', N'Harry Phạm', 5400000),
('QUO004', 'CRS005', N'Business Intelligence', N'Anh Tú', 5482000),
('QUO005', 'CRS008', N'Desktop Coding Class', N'Jennie Huỳnh', 4370000);
-- SELECT * FROM ChiTietKhoaHocThuocBaoGia

/*USE CASE 5*/
/* Bảng KhachHang */
INSERT INTO KhachHang 
VALUES
    ('CUS001', N'Phan Duy Trọng', N'Nam','2003-05-15', '0987654321', 'trongphanduy@gmail.com', 'OCU005', N'Học sinh - Sinh viên', 'STA005', N'Nguyễn Đức Trung', N'Đang hoạt động', NULL, NULL, 'LEA006', '2023-09-01 8:00:00', N'Hệ thống', '2023-09-01 10:30:00', 'STA005'),
    ('CUS002', N'Lê Minh Quân', N'Nam', '1992-09-25', '0123456789', 'minhquanle@gmail.com', 'OCU004', N'Giảng viên', 'STA009', N'Trần Thanh Mai', N'Đang hoạt động', NULL, NULL, 'LEA004', '2023-09-02 9:15:00', N'Hệ thống', '2023-09-02 14:45:00', 'STA009'),
    ('CUS003', N'Trần Kim Ngọc', N'Nữ', '1985-10-11', '0909090909', 'ngockimtran@gmai.com', 'OCU006', N'Bác sĩ', 'STA001', N'Nguyễn Ngọc Hoàng', N'Đang hoạt động', NULL, NULL, 'LEA007', '2023-09-03 11:30:00', N'Hệ thống', '2023-09-03 16:20:00', 'STA001'),
    ('CUS004', N'Nguyễn Thu Việc', N'Nữ', '1988-03-02', '0888777666', 'viecthunguyen@gmail.com', 'OCU003', N'Chuyên viên kinh doanh', 'STA002', N'Võ Anh Thư', N'Đang hoạt động', NULL, NULL, 'LEA003', '2023-09-04 13:45:00', N'Hệ thống', '2023-09-04 18:10:00', 'STA002'),
    ('CUS005', N'Bùi Xuân Vĩ ', N'Nam', '1982-01-12', '0444333222', 'vixuanbui@gmail.com', 'OCU008', N'Nhà báo', 'STA006', N'Bùi Thị Thúy', N'Đang hoạt động', NULL, NULL, 'LEA009', '2023-09-05 15:00:00', N'Hệ thống', '2023-09-05 20:05:00', 'STA006'),
    ('CUS006', N'Ngô Thị Kim Cương', N'Nữ', '1991-06-30', '0777007007', 'kimcuongngothi@gmail.com', 'OCU001', N'Nhiếp ảnh', 'STA007', N'Trần Thúy Hằng', N'Đang hoạt động', NULL, NULL, 'LEA001', '2023-09-06 17:15:00', N'Hệ thống', '2023-09-06 22:40:00', 'STA007'), 
    ('CUS007', N'Nguyễn Hoàng Minh', N'Nam', '1978-12-05', '0999888777', 'minhhoangnguyen@gmail.com', 'OCU002', N'Phân tích dữ liệu', 'STA004', N'Trương Minh Tiến', N'Đang hoạt động', NULL, NULL, 'LEA002', '2023-09-07 19:30:00', N'Hệ thống', '2023-09-07 9:25:00', 'STA004'),
    ('CUS008', N'Dương Bích Tuyền', N'Nữ', '1983-08-08', '0111222333', 'tuyenbichduong@gmail.com', 'OCU009', N'Nhân viên bất động sản', 'STA003', N'Trần Mỹ Hạnh', N'Đang hoạt động', NULL, NULL, 'LEA010', '2023-09-08 21:45:00', N'Hệ thống', '2023-09-08 14:15:00', 'STA003'),
	('CUS009', N'Nguyễn Hoàng Minh', N'Nam', '2003-02-24', '0909875081', 'minhcorgig@gmail.com', 'OCU009', N'Nhân viên bất động sản', 'STA003', N'Trần Mỹ Hạnh', N'Đang hoạt động', NULL, NULL, 'LEA002', '2023-09-08 21:45:00', N'Hệ thống', '2023-09-08 14:15:00', 'STA003');

-- SELECT * FROM KhachHang

/*USE CASE 8*/
/* Bảng HoaDon*/
-- Inserting data into HoaDon table
INSERT INTO HoaDon
VALUES
('INV001', N'Hóa đơn thanh toán khóa học Business Analyst của Phan Duy Trọng', N'Phan Duy Trọng', '2023-04-29 03:07:18', 3400000, 'QUO001', '2023-04-29 03:07:18', N'Hệ thống'),
('INV002', N'Hóa đơn thanh toán khóa học Product Owner Master Class của Bùi Xuân Vĩ', N'Bùi Xuân Vĩ', '2023-01-10 10:24:05', 5400000, 'QUO002', '2023-04-13 08:39:39', N'Hệ thống'),
('INV003', N'Hóa đơn thanh toán khóa học Product Owner Master Class của Bùi Xuân Vĩ', N'Nguyễn Thu Việc','2023-02-19 18:24:15', 5400000, 'QUO003', '2023-02-19 18:24:39', N'Hệ thống');
-- SELECT * FROM HoaDon

/* Bảng ChiTietKhoaHocThuocHoaDon */
INSERT INTO ChiTietKhoaHocThuocHoaDon
VALUES
    ('INV001', 'CRS001', N'IT Business Analysis', N'Ryan Nguyễn', 4000000),
    ('INV002', 'CRS002', N'Product Owner Master Class', N'Harry Phạm', 5400000),
    ('INV003', 'CRS002', N'Product Owner Master Class', N'Harry Phạm', 5400000);
-- SELECT * FROM ChiTietKhoaHocThuocHoaDon


/* Bảng HoatDongKH */
INSERT INTO HoatDongKH
VALUES 
    ('CA001', 'CUS001', N'Yêu cầu tư vấn khóa học đến Nguyễn Đức Trung', N'Tư vấn', N'Khách hàng', 'STA005', N'Nguyễn Đức Trung', NULL, '2023-12-01 8:00:00'),
    ('CA002', 'CUS002', N'Yêu cầu tư vấn khóa học Database Foundation Class đến Trần Thanh Mai', N'Tư vấn', N'Khách hàng', 'STA009', N'Trần Thanh Mai', NULL, '2023-12-02 8:00:00'),
    ('CA003', 'CUS003', N'Yêu cầu tư vấn khóa học Business Intelligence đến Nguyễn Ngọc Hoàng', N'Tư vấn', N'Khách hàng', 'STA001', N'Nguyễn Ngọc Hoàng', NULL, '2023-12-03 8:00:00'),
    ('CA004', 'CUS004', N'Yêu cầu tư vấn khóa học đến Võ Anh Thư', N'Tư vấn', N'Khách hàng', 'STA002', N'Võ Anh Thư', NULL, '2023-12-04 8:00:00'),
    ('CA005', 'CUS005', N'Yêu cầu tư vấn khóa học đến Bùi Thị Thúy', N'Tư vấn', N'Khách hàng', 'STA006', N'Bùi Thị Thúy', NULL, '2023-12-05 8:00:00'),
    ('CA006', 'CUS006', N'Yêu cầu tư vấn khóa học đến Trần Thúy Hằng', N'Tư vấn', N'Khách hàng', 'STA007', N'Trần Thúy Hằng', NULL, '2023-12-06 8:00:00'),
    ('CA007', 'CUS007', N'Yêu cầu tư vấn khóa học Desktop Coding Class đến Trương Minh Tiến', N'Tư vấn', N'Khách hàng', 'STA004', N'Trương Minh Tiến', NULL, '2023-12-07 8:00:00'),
    ('CA008', 'CUS008', N'Yêu cầu tư vấn khóa học Business Data Engineer đến Trần Mỹ Hạn', N'Tư vấn', N'Khách hàng', 'STA003', N'Trần Mỹ Hạnh', NULL, '2023-12-08 8:00:00');
-- SELECT * FROM HoatDongKH


/* Bảng EmailMau */
INSERT INTO EmailMau 
VALUES
('EMT001', N'Xác nhận yêu cầu tư vấn', N'Gửi thông tin xác nhận yêu cầu đã được tiếp nhận và thông tin của nhân viên tư vấn như tên, số điện thoại', 
N'Kính gửi bạn {{ten_lead}},

Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của tư vấn viên {{Lead PIC’s full name}}({{staff_phone_number}}) để được hỗ trợ nhanh nhất.

Trân trọng,
SKILLBOOST', N'Đang hoạt động', '2023-01-01 00:00:00', 'STA000', '2023-01-01 00:00:00', 'STA000'),
('EMT002', N'Báo giá khóa học', N'Gửi báo giá của khóa học bao gồm giá tiền gốc, VAT, số tiền phải trả, thông tin chi tiết khóa học', 
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
N'Đang hoạt động', '2023-01-01 00:00:00', 'STA000', '2023-02-03 18:43:46', 'STA000'),
('EMT003', N'Xác nhận thanh toán học phí', N'Gửi thông tin xác nhận học phí của khóa học mà học viên đăng ký đã được thanh toán thành công kèm theo thêm thông tin nhân viên hỗ trợ', 
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
N'Đang hoạt động', '2023-01-01 00:00:00', 'STA000', '2023-01-01 00:00:00', 'STA000'),


('EMT004', N'Thông báo đăng ký khóa học thành công', N'Gửi thông báo xác nhận khóa học đã được học viên đăng ký thành công', 
N'Kính gửi bạn {{ten_lead}},

Chúc mừng bạn đã đăng ký khóa học {{ten_khoa_hoc}} thành công tại SkillBoost!

Để tham gia khóa học, bạn vui lòng truy cập vào trang web của SkillBoost và đăng nhập bằng tài khoản của mình. Sau khi đăng nhập, bạn sẽ tìm thấy khóa học {{ten_khoa_hoc}} trong danh sách khóa học của mình. Bạn có thể bắt đầu học ngay lập tức.

Chúng tôi hy vọng bạn sẽ có một khóa học học tập hiệu quả và đạt được mục tiêu của mình. Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline {{ten_nhan_vien}} (Tư vấn viên {{nguoi_phu_trach_lead}}) nhé!

Trân trọng,
SKILLBOOST', 
N'Đang hoạt động', '2023-01-01 00:00:00', 'STA000', '2023-02-03 00:00:00', 'STA000');
--SELECT * FROM EmailMau

/*USE CASE 7*/
/* Bảng Email */
-- EML001
INSERT INTO Email
VALUES(
    'EML001', N'Báo giá khóa học',
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
    '2023-04-30 10:51:08', N'NguoiNhan', N'Đã gửi', NULL, 'QUO001', NULL, 'EMT002', '2023-04-30 10:51:08', N'Hệ thống', '2023-04-30 11:00:00', N'STA010');
-- EML002
INSERT INTO Email
VALUES (
    'EML002', N'Xác nhận thanh toán học phí',
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
    '2023-04-29 03:07:18', N'Phan Duy Trọng', N'Đã gửi', NULL, NULL, 'INV001', 'EMT003', '2023-04-29 03:07:18', N'Hệ thống', '2023-04-29 03:30:29', N'STA010');
-- EML003
INSERT INTO Email
VALUES (
    'EML003', N'Thông báo đăng ký khóa học thành công',
    N'Kính gửi bạn Phan Duy Trọng,

    Chúc mừng bạn đã đăng ký khóa học Become a Business Analyst thành công tại SkillBoost !

    Để tham gia khóa học, bạn vui lòng truy cập vào trang web của SkillBoost và đăng nhập bằng tài khoản của mình. Sau khi đăng nhập, bạn sẽ tìm thấy khóa học Become a Business Analystntrong danh sách khóa học của mình. Bạn có thể bắt đầu học ngay lập tức.

    Chúng tôi hy vọng bạn sẽ có một khóa học học tập hiệu quả và đạt được mục tiêu của mình. Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline 0998123456 (Tư vấn viên Thy) nhé!

    Trân trọng,
    SKILLBOOST',
    '2023-01-12 05:36:25', N'Phan Duy Trọng', N'Đã gửi', NULL, NULL, NULL, 'EMT004', '2023-01-12 05:36:25', N'Hệ thống', '2023-01-12 05:36:25', N'STA010');
-- EML004
INSERT INTO Email
VALUES (
    'EML004', N'Xác nhận thanh toán học phí',
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
    '2023-10-01 10:24:05', N'Bùi Xuân Vĩ', N'Đã gửi', NULL, NULL, 'INV002', 'EMT003', '2023-10-02 10:24:05', N'Hệ thống', '2023-10-02 10:24:05', N'STA009');
-- EML005
INSERT INTO Email
VALUES (
    'EML005', N'Thông báo đăng ký khóa học thành công',
    N'Kính gửi bạn Bùi Xuân Vĩ,

    Chúc mừng bạn đã đăng ký khóa học Product Owner Master Class thành công tại SkillBoost !

    Để tham gia khóa học, bạn vui lòng truy cập vào trang web của SkillBoost và đăng nhập bằng tài khoản của mình. Sau khi đăng nhập, bạn sẽ tìm thấy khóa học Become a Business Analystntrong danh sách khóa học của mình. Bạn có thể bắt đầu học ngay lập tức.

    Chúng tôi hy vọng bạn sẽ có một khóa học học tập hiệu quả và đạt được mục tiêu của mình. Nếu bạn có bất kỳ thắc mắc nào, vui lòng liên hệ với chúng tôi qua Email hoặc Hotline 0928123456 (Tư vấn viên Mai) nhé!

    Trân trọng,
    SKILLBOOST',
    '2023-04-13 08:39:39', N'Bùi Xuân Vĩ', N'Đã gửi', NULL, NULL, NULL, 'EMT004', '2023-01-13 08:39:39', N'Hệ thống', '2023-01-13 08:39:39', N'STA009');
-- EML006
INSERT INTO Email
VALUES (
    'EML006', N'Báo giá khóa học',
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
    '2023-02-28 18:38:44', N'Bùi Xuân Vĩ', N'Đã gửi', NULL, 'QUO002', NULL, 'EMT002', '2023-02-28 18:38:44', N'Hệ thống', '2023-02-28 19:00:25', N'STA009');
-- EML007
INSERT INTO Email
VALUES (
    'EML007', N'Xác nhận yêu cầu tư vấn',
    N'Kính gửi bạn Nguyễn Thu Việc,

    Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

    Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của Tư vấn viên Trâm (0938123456) để được hỗ trợ nhanh nhất.

    Trân trọng,
    SKILLBOOST',
    '2023-09-12 14:44:35', N'Nguyễn Thu Việc', N'Lên lịch', 'CON001', NULL, NULL, 'EMT001', '2023-09-11 13:45:35', N'Hệ thống', '2023-09-11 14:04:24', N'STA008');
-- EML008
INSERT INTO Email
VALUES (
    'EML008', N'Xác nhận yêu cầu tư vấn',
    N'Kính gửi bạn Phan Văn Trị,

    Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

    Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của Tư vấn viên Mai (0928123456) để được hỗ trợ nhanh nhất.

    Trân trọng,
    SKILLBOOST',
    '2023-11-15 10:52:43', N'Phan Văn Trị', N'Bản nháp', NULL, NULL, NULL, 'EMT001', '2023-11-15 10:52:43', N'Hệ thống', '2023-11-15 10:52:43', N'STA009');
-- EML009
INSERT INTO Email
VALUES (
    'EML009', N'Xác nhận yêu cầu tư vấn',
    N'Kính gửi bạn Nguyễn Hoàng Minh,

    Cảm ơn bạn đã liện hệ với SkillBoost. Thông tin của bạn đã được ghi nhận và chuyển cho đội ngũ tư vấn khách hàng của SkillBoost.

    Bạn vui lòng giữ điện thoại để được đội ngũ tư vấn gọi điện thoại trực tiếp tư vấn cho bạn. Hoặc bạn có thể kết nối trực tiếp với chúng tôi thông qua Zalo của Tư vấn viên Trâm (0938123456) để được hỗ trợ nhanh nhất.

    Trân trọng,
    SKILLBOOST',
    '2023-01-17 23:15:47', N'Nguyễn Hoàng Minh', N'Error', 'CON002', NULL, NULL, 'EMT001', '2023-01-17 23:15:47', N'Hệ thống', '2023-01-17 23:15:47', N'STA008');
--SELECT * FROM Email



