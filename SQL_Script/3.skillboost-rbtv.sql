/* RBTV */
USE SkillBoost
GO

/* Use case 1 */
/* Bảng NhanVien : Từ RB1 đến RB9 */
/* Các RB đã có
	RB1. Thuộc tính MaNV của bảng NhanVien phải là duy nhất
	RB2. Các thuộc tính HoNV, TenNV, GioiTinhNV, ChucVu, SoDienThoaiNV, EmailNV, TrangthaiNV của bảng NhanVien không được để trống
*/
-- RB14. Thuộc tính EmailTK của bảng TaiKhoan cũng là thuộc tính EmailNV của bảng NhanVien
--CREATE TRIGGER ConstraintEmailTK ON TaiKhoan
--AFTER INSERT, UPDATE
--AS
--BEGIN
--    IF NOT EXISTS (
--        SELECT 1
--        FROM TaiKhoan t
--        JOIN NhanVien n ON t.EmailTK = n.EmailNV
--    )
--    BEGIN
--        PRINT 'Lỗi: EmailTK phải giống với EmailNV.';
--        ROLLBACK;
--    END
--END;

-- RB3. Thuộc tính GioiTinhNV của bảng NhanVien chỉ luôn có 2 giá trị “Nữ” và “Nam”
ALTER TABLE NhanVien
ADD CONSTRAINT ConstraintDOMGioiTinhNV CHECK (GioiTinhNV IN (N'Nam', N'Nữ'))

-- RB4. Thuộc tính ChucVu của bảng NhanVien chỉ luôn có 2 giá trị “Nhân viên” và “Quản lý”
ALTER TABLE NhanVien
ADD CONSTRAINT ConstraintDOMChucVu CHECK (ChucVu IN (N'Nhân viên', N'Quản lý'))

-- RB5. Tuổi của nhân viên phải lớn hơn hoặc bằng 18
ALTER TABLE NhanVien
ADD CONSTRAINT ConstraintTuoiNV CHECK (YEAR(GETDATE()) - YEAR(NgaySinhNV) >= 18)

-- RB6. Thuộc tính SoDienThoaiNV của bảng NhanVien phải là duy nhất
ALTER TABLE NhanVien
ADD CONSTRAINT ConstraintUniqueSDTNV UNIQUE(SoDienThoaiNV)

-- RB7. Thuộc tính SoDienThoaiNV của bảng NhanVien chỉ chứa các giá trị số 
ALTER TABLE NhanVien
ADD CONSTRAINT ConstraintSDTNV CHECK (SoDienThoaiNV NOT LIKE '%[^0-9]%')

-- RB8. Thuộc tính EmailNV của bảng NhanVien phải là duy nhất
ALTER TABLE NhanVien
ADD CONSTRAINT ConstraintUniqueEmailNV UNIQUE(EmailNV)

-- RB9. Thuộc tính TrangThaiNV của bảng NhanVien chỉ luôn có 3 giá trị “Đang hoạt động”, “Đang được kiểm tra” và “Không hoạt động”
ALTER TABLE NhanVien
ADD CONSTRAINT ConstraintDOMTrangThaiNV CHECK (TrangThaiNV IN (N'Đang hoạt động', N'Đang được kiểm tra', N'Không hoạt động'))

/* Bảng TaiKhoan : Từ RB10 đến RB14 */
/* Các RB đã có
	RB10. Thuộc tính MaTK của bảng TaiKhoan phải là duy nhất 
	RB11. Các thuộc tính EmailTK, MatKhauTK, MaHashTK, MaSaltTK, TrangThaiTK, MaNV của bảng TaiKhoan không được để trống
*/
-- RB12. Thuộc tính MatKhauTK của bảng TaiKhoan phải là duy nhất
--ALTER TABLE TaiKhoan
--ADD CONSTRAINT ConstraintUniqueMatKhauTK UNIQUE(MatKhauTK)

-- RB13. Thuộc tính TrangThaiTK của bảng TaiKhoan chỉ luôn có 3 giá trị “Đang hoạt động”, “Đang được kiểm tra” và “Vô hiệu hóa”
ALTER TABLE TaiKhoan
ADD CONSTRAINT ConstraintDOMTrangThaiTK CHECK (TrangThaiTK IN (N'Đang hoạt động', N'Đang được kiểm tra', N'Vô hiệu hóa'))

/* Use case 2*/
/* Bảng YeuCauTuVan : Từ RB15 đến RB20*/
/* Các RB đã có
	RB15. Thuộc tính MaTuVan của bảng YeuCauTuVan phải là duy nhất
	RB16. Các thuộc tính TenLeadYeuCau, EmailLeadYeuCau, SDTLeadYeuCau, TrangThaiYCTV, TrangThaiTK, MaNV của bảng YeuCauTuVan không được để trống
*/
-- RB17. Thuộc tính EmailLeadYeuCau của bảng YeuCauTuVan phải là duy nhất
--ALTER TABLE YeuCauTuVan
--ADD CONSTRAINT ConstraintUniqueEmailYCTV UNIQUE(EmailLeadYeuCau)

-- RB18. Thuộc tính SDTLeadYeuCau của bảng YeuCauTuVan phải là duy nhất
--ALTER TABLE YeuCauTuVan
--ADD CONSTRAINT ConstraintUniqueSDTYCTV UNIQUE(SDTLeadYeuCau)


-- RB19. Thuộc tính SDTLeadYeuCau của bảng YeuCauTuVan chỉ chứa các giá trị số
ALTER TABLE YeuCauTuVan
ADD CONSTRAINT ConstraintSDTYCTV CHECK (SDTLeadYeuCau NOT LIKE '%[^0-9]%')

-- RB20. Thuộc tính TrangThaiYCTV của bảng YeuCauTuVan chỉ luôn có 2 giá trị “Đã tiếp nhận” và “Chờ tiếp nhận”
ALTER TABLE YeuCauTuVan
ADD CONSTRAINT ConstraintDOMTrangThaiYCTV CHECK (TrangThaiYCTV IN (N'Đã tiếp nhận', N'Chờ tiếp nhận'))

/* Use case 3 */
/* Bảng Lead : Từ RB21 đến RB28 */
/* Các RB đã có
	RB21. Thuộc tính MaLead của bảng Lead phải là duy nhất
	RB22. Các thuộc tính HoLead, TenLead, GioiTinhLead, SoDienThoaiLead, EmailLead, NguoiPhuTrachLead, TrangThaiLead của bảng Lead  không được để trống
*/
-- R23. Thuộc tính GioiTinhLead của bảng Lead chỉ luôn có 2 giá trị “Nữ” và “Nam”
ALTER TABLE Lead
ADD CONSTRAINT ConstraintDOMGioiTinhLead CHECK (GioiTinhLead IN (N'Nam', N'Nữ'))

-- RB24. Tuổi của Lead phải lớn hơn hoặc bằng 15 
ALTER TABLE Lead
ADD CONSTRAINT ConstraintTuoiLead CHECK (YEAR(GETDATE()) - YEAR(NgaySinhLead) >= 15)

-- RB25. Thuộc tính SoDienThoaiLead là duy nhất
ALTER TABLE Lead
ADD CONSTRAINT ConstraintUniqueSDTLead UNIQUE(SoDienThoaiLead)

-- RB26. Thuộc tính SoDienThoaiLead của bảng Lead chỉ chứa các giá trị số 
ALTER TABLE Lead
ADD CONSTRAINT ConstraintSDTLead CHECK (SoDienThoaiLead NOT LIKE '%[^0-9]%')

-- RB27. Thuộc tính EmailLead của bảng Lead phải là duy nhất 
ALTER TABLE Lead
ADD CONSTRAINT ConstraintUniqueEmailLead UNIQUE(EmailLead)

-- RB28. Thuộc tính TrangThaiLead của bảng KhachHang chỉ luôn có 4 giá trị “Chờ tư vấn”, “Đang tư vấn”, “Ngừng theo dõi” và “Đã thanh toán”
ALTER TABLE Lead
ADD CONSTRAINT ConstraintDOMTrangThaiLead CHECK (TrangThaiLead IN (N'Chờ tư vấn', N'Đang tư vấn', N'Ngừng theo dõi', N'Đã thanh toán'))

/* Bảng HoatDongLead : Từ RB29 đến RB32 */
/* Các RB đã có
	RB29. Thuộc tính MaHDLead của bảng HoatDongLead phải là duy nhất 
	RB30. Các thuộc tính MaLead, TenHDLead, LoaiHDLead, HDLeadDuocTaoBoi, NguoiPhuTrachHDLead của bảng HoatDongLead không được để trống
*/
-- RB31. Thuộc tính LoaiHDLead của bảng HoatDongLead chỉ luôn có các giá trị sau đây: “Yêu cầu”, “Điều chỉnh trạng thái” , “Email”, “Tư vấn”,  “Báo giá”, “Mã giảm giá”, “Thông tin Lead”
ALTER TABLE HoatDongLead
ADD CONSTRAINT ConstraintDOMLoaiHDLead CHECK (LoaiHDLead IN (N'Yêu cầu', N'Điều chỉnh trạng thái', N'Email', N'Tư vấn', N'Báo giá', N'Mã giảm giá', N'Thông tin Lead'))

-- RB32. Thuộc tính HDLeadDuocTaoBoi của bảng HoatDongLead chỉ luôn có các giá trị sau đây: “Hệ thống”, “Lead”, Nhân viên (gồm MaNV của người phụ trách hoạt động Lead và MaNV của quản lý)
/*
ALTER TABLE HoatDongLead
ADD CONSTRAINT ConstraintDOMHDLeadDuocTaoBoi CHECK (LoaiHDLead IN (N'Hệ thống', N'Lead', Lead.NguoiPhuTrachHDLead, N'STA000'))
*/

/* Bảng BaoGia : Từ RB33 đến RB35 */
/* Các RB đã có
	RB33. Thuộc tính MaBaoGia của bảng BaoGia phải là duy nhất 
	RB34. Thuộc tính MaLead, MoTaBaoGia, TongTien và TrangThaiBaoGia của bảng BaoGia phải luôn có giá trị khác rỗng
*/
-- RB35. Thuộc tính TrangThaiBaoGia của bảng BaoGia chỉ luôn có 3 giá trị “Đã thanh toán”, “Chưa thanh toán” và “Đã hết hạn”
ALTER TABLE BaoGia
ADD CONSTRAINT ConstraintDOMTrangThaiBaoGia CHECK (TrangThaiBaoGia IN (N'Đã thanh toán', N'Chưa thanh toán', N'Đã hết hạn'))

/* Use case 4*/
/* Bảng QuyDinhGiamGia : Từ RB36 đến RB38 */
/* Các RB đã có
	RB36. Thuộc tính MaQuyDinhGiamGia của bảng QuyDinhGiamGia phải là duy nhất
	RB37. Thuộc tính MoTaLoaiGiamGia, SoLuongKhoaHocDangKy, PhanTramGiamGiaMacDinh và PhanTramGiamGiaToiDa phải luôn có giá trị khác rỗng
*/
-- R38. Thuộc tính NgayBatDau trong bảng QuyDinhGiamGia phải luôn bé hơn bằng NgayKetThuc
ALTER TABLE QuyDinhGiamGia
ADD CONSTRAINT ConstraintNgayBDNgayKT CHECK (NgayBatDau <= NgayKetThuc)

/* Bảng MaGiamGia : Từ RB39 đến RB42 */
/* Các RB đã có
	RB39. Thuộc tính MaGiamGia của bảng MaGiamGia phải là duy nhất
	RB40. Thuộc tính MoTaMaGiamGia, PhamViApDung, PhanTramGiamGia và TrangThaiMaGiamGia, MaQuyDinhGiamGia phải luôn có giá trị khác rỗng
*/
-- R41. Thuộc tính PhamViApDung của bảng MaGiamGia chỉ luôn có 3 giá trị “Cho cá nhân”, “Cho nhóm” và “Không giới hạn”
ALTER TABLE MaGiamGia
ADD CONSTRAINT ConstraintDOMPhamViApDung CHECK (PhamViApDung IN (N'Cho cá nhân', N'Cho nhóm', N'Không giới hạn'))

-- R42. Thuộc tính TrangThaiMaGiamGia của bảng MaGiamGia chỉ luôn có 3 giá trị “Khả dụng”, “Đang duyệt” và “Hết hạn”
ALTER TABLE MaGiamGia
ADD CONSTRAINT ConstraintDOMTrangThaiMaGiamGia CHECK (TrangThaiMaGiamGia IN (N'Khả dụng', N'Đang duyệt', N'Hết hạn'))

/* Use case 5 */
/* Bảng KhachHang : Từ RB43 đến RB50*/
/* Các RB đã có
	RB43. Thuộc tính MaKH của bảng KhachHang phải là duy nhất
	RB44. Các thuộc tính HoKH, TenKH, GioiTinhKH, SoDienThoaiKH, EmailKH, NguoiPhuTrachKH, TrangThaiKH của bảng KhachHang không được để trống
*/
-- R45. Thuộc tính GioiTinhKH của bảng KhachHang chỉ luôn có 2 giá trị “Nữ” và “Nam”
ALTER TABLE KhachHang
ADD CONSTRAINT ConstraintDOMGioiTinhKH CHECK (GioiTinhKH IN (N'Nam', N'Nữ'))

-- RB46. Tuổi của khách hàng phải lớn hơn hoặc bằng 15  
ALTER TABLE KhachHang
ADD CONSTRAINT ConstraintTuoiKH CHECK (YEAR(GETDATE()) - YEAR(NgaySinhKH) >= 15)

-- RB25. Thuộc tính SoDienThoaiKH là duy nhất
ALTER TABLE KhachHang
ADD CONSTRAINT ConstraintUniqueSDTKH UNIQUE(SoDienThoaiKH)

-- RB47. Thuộc tính SoDienThoaiKH của bảng KhachHang phải là duy nhất
ALTER TABLE KhachHang
ADD CONSTRAINT ConstraintSDTKH CHECK (SoDienThoaiKH NOT LIKE '%[^0-9]%')

-- RB49. Thuộc tính EmailKH phải là duy nhất
ALTER TABLE KhachHang
ADD CONSTRAINT ConstraintUniqueEmailKH UNIQUE(EmailKH)

-- RB50. Thuộc tính TrangThaiNV của bảng NhanVien chỉ luôn có 3 giá trị “Đang hoạt động”, “Đang được kiểm tra” và “Không hoạt động”
ALTER TABLE KhachHang
ADD CONSTRAINT ConstraintDOMTrangThaiKH CHECK (TrangThaiKH IN (N'Đang hoạt động', N'Đang được kiểm tra', N'Không hoạt động'))

/* Bảng HoatDongKH : Từ RB51 đến RB54 */
/* Các RB đã có
	RB51. Thuộc tính MaHDKH hàng phải là duy nhất  
	RB52. Các thuộc tính MaKH, TenHDKH, LoaiHDKH, HDKHDuocTaoBoi, NguoiPhuTrachHDKH của bảng HoatDongKH không được để trống
*/
-- RB53. Thuộc tính LoaiHDKH của bảng HoatDongKH chỉ luôn có các giá trị sau đây: “Tư vấn”, “Thông tin khách hàng”, “Điều chỉnh trạng thái”, “Email”
ALTER TABLE HoatDongKH
ADD CONSTRAINT ConstraintDOMLoaiHDKH CHECK (LoaiHDKH IN (N'Điều chỉnh trạng thái', N'Email', N'Tư vấn', N'Thông tin khách hàng'))

-- RB54. Thuộc tính HDLeadDuocTaoBoi của bảng HoatDongLead chỉ luôn có các giá trị sau đây: “Hệ thống”, “Lead”, Nhân viên (gồm MaNV của người phụ trách hoạt động Lead và MaNV của quản lý)
/*
ALTER TABLE HoatDongKH
ADD CONSTRAINT ConstraintDOMHDKHDuocTaoBoi CHECK (LoaiHDKH IN (N'Hệ thống', N'Lead', KH.NguoiPhuTrachHDKH, N'STA000'))
*/

/* Use case 6 */
/* Bảng KhoaHoc : Từ RB55 đến RB59*/
/* Các RB đã có
	RB55. Thuộc tính MaKhoaHoc của bảng KhoaHoc phải là duy nhất 
	RB56. Thuộc tính TenKhoaHoc, MoTaKhoaHoc, ThoiLuongKhoaHoc, GiangVien, MucDoKhoaHoc, SoLuongHocVienToiDa, HocPhi, NgayKhaiGiang, NgayBeGiang, DanhGiaKhoaHoc, TrangThaiKhoaHoc và MaLoaiKhoaHoc của bảng KhoaHoc luôn có giá trị khác rỗng
*/
-- RB57. Thuộc tính NgayKhaiGiang phải luôn bé hơn NgayBeGiang của bảng KhoaHoc
ALTER TABLE KhoaHoc
ADD CONSTRAINT ConstraintNgayKGNgayBG CHECK (NgayKhaiGiang <= NgayBeGiang)

-- RB58. Thuộc tính DanhGiaKhoaHoc trong bảng KhoaHoc chỉ từ 1 đến 5
ALTER TABLE KhoaHoc
ADD CONSTRAINT ConstraintDanhGiaKhoaHocRange CHECK (DanhGiaKhoaHoc >= 1 AND DanhGiaKhoaHoc <= 5)

-- RB59. TThuộc tính TrangThaiKhoaHoc của bảng KhoaHoc chỉ luôn có 3 giá trị “Đang vận hành”, “Đang chiêu sinh” và “Vô hiệu hóa”
ALTER TABLE KhoaHoc
ADD CONSTRAINT ConstraintDOMTrangThaiKhoaHoc CHECK (TrangThaiKhoaHoc IN (N'Đang vận hành', N'Đang chiêu sinh', N'Vô hiệu hóa'))

/* Bảng LoaiKhoaHoc : Từ RB60 đến RB62 */
/* Các RB đã có
	RB60. Thuộc tính MaLoaiKhoaHoc của bảng LoaiKhoaHoc phải là duy nhất
	RB61. Thuộc tính TenLoaiKhoaHoc và TrangThaiLoaiKhoaHoc phải có giá trị khác rỗng
*/
-- RB62. Thuộc tính TrangThaiLoaiKhoaHoc của bảng LoaiKhoaHoc chỉ luôn có 2 giá trị “Đang hoạt động” và “Vô hiệu hóa”
ALTER TABLE LoaiKhoaHoc
ADD CONSTRAINT ConstraintDOMTrangThaiLoaiKhoaHoc CHECK (TrangThaiLoaiKhoaHoc IN (N'Đang hoạt động', N'Vô hiệu hóa'))

/* Use case 7*/
/* Bảng Email : Từ RB63 đến RB65 */
/* Các RB đã có
	RB63. Thuộc tính MaEmail của bảng Email phải là duy nhất
	RB64. Thuộc tính TieuDeEmail, NoiDungEmail, LichGuiEmail, NguoiNhan, TrangThaiEmail và MaEmailMau phải luôn có giá trị khác rỗng
*/
-- RB65. Thuộc tính TrangThaiEmail của bảng Email chỉ luôn có 4 giá trị “Đã gửi”, “Lên lịch”, “Bản nháp” và “Error”
ALTER TABLE Email
ADD CONSTRAINT ConstraintDOMTrangThaiEmail CHECK (TrangThaiEmail IN (N'Đã gửi', N'Lên lịch', N'Bản nháp', N'Error'))

/* Bảng EmailMau : Từ RB66 đến RB68 */
/* Các RB đã có
	RB66. Thuộc tính MaEmailMau của bảng EmailMau phải là duy nhất
	RB67. Thuộc tính TieuDeEmailMau, MoTaEmailMau, NoiDungEmailMau và TrangThaiEmailMau luôn có giá trị khác rỗng
*/
-- RB68. Thuộc tính TrangThaiEmailMau của bảng EmailMau chỉ luôn có 2 giá trị “Đang hoạt động” và “Vô hiệu hóa”
ALTER TABLE EmailMau
ADD CONSTRAINT ConstraintDOMTrangThaiEmailMau CHECK (TrangThaiEmailMau IN (N'Đang hoạt động', N'Vô hiệu hóa'))

/* Use case 8 */
/* Bảng HoaDon : Từ RB69 đến RB70 */
/* Các RB đã có
	RB69. Thuộc tính MaHoaDon của bảng HoaDon phải là duy nhất
	RB70. Thuộc tính MaBaoGia, TenKH, ThoiDiemThanhToan, MoTaHoaDon và TongHoaDon của bảng HoaDon luôn có giá trị khác rỗng
*/
GO

CREATE TRIGGER TR_HASH_MK ON TaiKhoan
AFTER INSERT
AS
DECLARE @mk_tmp VARCHAR(50), @salt UNIQUEIDENTIFIER;
SELECT @mk_tmp = MatKhauTK, @salt = MaSaltTK
FROM inserted
UPDATE TaiKhoan 
SET MaHashTK = (HASHBYTES('SHA2_512', @mk_tmp + CAST(@salt AS NVARCHAR(36)))),
MatKhauTK = '###'
WHERE MaSaltTK = @salt

GO