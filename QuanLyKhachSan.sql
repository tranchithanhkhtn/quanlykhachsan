CREATE DATABASE QuanLyKhachSan

GO
USE QuanLyKhachSan

-- =================== TABLE =======================================
-- Thông Tin Tài Khoản
CREATE TABLE ACCOUNT (
	MaTK varchar(10) not null,
	TenTK varchar(100) UNIQUE,
	MatKhau varchar(50),
	LoaiTK nvarchar(20),
	
	CONSTRAINT PK_ACCOUNT PRIMARY KEY (MaTK)
)

-- Thông Tin NHÂN VIÊN
CREATE TABLE NHANVIEN (
	MaNV varchar(10) not null,
	TenNV nvarchar(50),
	SDT varchar(11),
	GTinh nvarchar(6),
	DiaChi nvarchar(150),
	MaTK varchar(10),
	NVQL varchar(10),
	NgSinh date,
	AnhDaiDien image

	CONSTRAINT PK_NHANVIEN PRIMARY KEY (MaNV)
)


-- Thông Tin ADMIN
CREATE TABLE QUANTRIVIEN(
	MaADMIN varchar(10) not null,
	TenADMIN nvarchar(50),
	SDT varchar(11),
	GTinh nvarchar(6),
	DiaChi nvarchar(150),

	MaTK varchar(10),
	CONSTRAINT PK_QUANTRIVIEN PRIMARY KEY (MaADMIN)
)


-- Thông Tin THỰC ĐƠN
CREATE TABLE FOODLIST
(
	ID varchar(5) not null,
	Loai nvarchar(10),
	TenTP nvarchar(50),
	GiaThanh float,
	HinhAnh image,
	SoLuong int,
	TrangThai nvarchar(10)

	CONSTRAINT PK_FOODLIST PRIMARY KEY (ID)
)

-- Thông Tin HÓA ĐƠN THỨC ĂN
CREATE TABLE BILLFOOD
(
	IDBill int identity(1,1),
	MaKH varchar(10),
	ID varchar(5),
	TenTP nvarchar(50),
	SoLuong int,
	GiaThanh float,
	TongTien float

	CONSTRAINT PK_BILLFOOD PRIMARY KEY (IDBill , MaKH, ID)
)

-- Thông Tin KHÁCH HÀNG
CREATE TABLE KHACHHANG
(
	MaKH varchar(10) not null,
	SoCMND varchar(15),
	TenKH nvarchar(50),
	NgSinh date,
	DiaChiTT nvarchar(100)

	CONSTRAINT PK_KHACHHANG PRIMARY KEY (MaKH)
)
-- Thông Tin PHÒNG Khách Sạn
CREATE TABLE PHONG
(
	MaPhong varchar(10) not null,
	LoaiPhong varchar(5),
	DonGia int,
	TinhTrang nvarchar(15),
	ThongTin nvarchar(1000),
	HinhAnh1 image,
	HinhAnh2 image,
	HinhAnh3 image,
	HinhAnh4 image,

	CONSTRAINT PK_PHONG PRIMARY KEY (MaPhong)
)

-- Thông Tin PHIẾU THUÊ và CHI TIẾT PHIẾU THUÊ
-- ===========================================
CREATE TABLE PHIEUTHUE
(
	MaPT varchar(10) not null,
	MaKH varchar(10),
	GioThue varchar(15),
	NgayThue date,
	NgayTra date

	CONSTRAINT PK_PHIEUTHUE PRIMARY KEY (MaPT)
)

CREATE TABLE CT_PHIEUTHUE
(
	MaPhong varchar(10),
	MaPT varchar(10),
	SoNgayThue int,
	_Status nvarchar(20)

	CONSTRAINT PK_CT_PHIEUTHUE PRIMARY KEY (MaPhong, MaPT)
)
-- ===========================================
-- Thông Tin PHIẾU TRẢ và CHI TIẾT PHIẾU TRẢ
-- ===========================================
CREATE TABLE PHIEUTRA
(
	MaPTra varchar(10) not null,
	MaPT varchar(10),
	NgayTra Date

	CONSTRAINT PK_PHIEUTRA PRIMARY KEY (MaPTra)
)

CREATE TABLE CT_PHIEUTRA
(
	MaPhong varchar(10),
	MaPTra varchar(10),
	SoNgayThue int,
	SoTienPhaiTra float,
	Discount nvarchar(20),

	CONSTRAINT PK_CT_PHIEUTRA PRIMARY KEY (MaPhong, MaPTra)
)
-- ===========================================
-- Tạo Bảng Chứa PHIẾU GIA HẠN
CREATE TABLE GIAHAN
(
	MaPhieuGH varchar(10) not null,
	MaPT varchar(10),
	SoNgayGH int,
	NgayGH date
	
	CONSTRAINT PK_GIAHAN PRIMARY KEY (MaPhieuGH)
)


-- =================== END TABLE =============================================
-- =================== RÀNG BUỘC FOREIGN KEY =================================
-- Khóa ngoại table(NHANVIEN) ->  table(ACCOUNT) và table(NHANVIEN) ->  table(NHANVIEN)
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_ACCOUNT_NV
   FOREIGN KEY (MaTK)
   REFERENCES ACCOUNT (MaTK)

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NVQL_NV
   FOREIGN KEY (NVQL)
   REFERENCES NHANVIEN (MANV)

-- Khóa ngoại table(QUANTRIVIEN) ->  table(ACCOUNT)
   ALTER TABLE QUANTRIVIEN
ADD CONSTRAINT FK_ACCOUNT_ADMIN
   FOREIGN KEY (MaTK)
   REFERENCES ACCOUNT (MaTK)

-- Khóa ngoại table(BILLFOOD) ->  table(FOODLIST)
ALTER TABLE BILLFOOD
 ADD CONSTRAINT FK_FOODLIST_BILL
   FOREIGN KEY (ID)
   REFERENCES FOODLIST(ID)

ALTER TABLE BILLFOOD
 ADD CONSTRAINT FK_FOODLIST_KHACHHANG
   FOREIGN KEY (MaKH)
   REFERENCES KHACHHANG(MaKH)

-- Khóa ngoại table(PHIEUTHUE) -> table(KHACHHANG)
ALTER TABLE PHIEUTHUE
 ADD CONSTRAINT FK_PHIEUTHUE_KHACHHANG
   FOREIGN KEY (MaKH)
   REFERENCES KHACHHANG (MaKH)

-- Khóa ngoại table(CT_PHIEUTHUE) -> table(PHONG) và table(CT_PHIEUTHUE) -> table(PHIEUTHUE)
ALTER TABLE CT_PHIEUTHUE
 ADD CONSTRAINT FK_CT_PHIEUTHUE_PHONG
   FOREIGN KEY (MaPhong)
   REFERENCES PHONG (MaPhong)

ALTER TABLE CT_PHIEUTHUE
 ADD CONSTRAINT FK_CT_PHIEUTHUE_PHIEUTHUE
   FOREIGN KEY (MaPT)
   REFERENCES PHIEUTHUE(MaPT)

-- Khóa ngoại table(PHIEUTRA) -> table(PHIEUTHUE)
ALTER TABLE PHIEUTRA
 ADD CONSTRAINT FK_PHIEUTRA_PHIEUTHUE
   FOREIGN KEY (MaPT)
   REFERENCES PHIEUTHUE (MaPT)

-- Khóa ngoại table(CT_PHIEUTRA) -> table(PHONG) và table(CT_PHIEUTRA) -> table(PHIEUTRA)
ALTER TABLE CT_PHIEUTRA
 ADD CONSTRAINT FK_CT_PHIEUTRA_PHONG
   FOREIGN KEY (MaPhong)
   REFERENCES PHONG (MaPhong)

ALTER TABLE CT_PHIEUTRA
 ADD CONSTRAINT FK_CT_PHIEUTRA_PHIEUTRA
   FOREIGN KEY (MaPTra)
   REFERENCES PHIEUTRA(MaPTra)

-- Khóa ngoại table(GIAHAN) -> table(PHIEUTHUE)
ALTER TABLE GIAHAN
 ADD CONSTRAINT FK_GIAHAN_PHIEUTHUE
   FOREIGN KEY (MaPT)
   REFERENCES PHIEUTHUE(MaPT)

GO
-- =================== END FOREIGN KEY ========================================
-- =================== STORED PROCEDURE AND FUNCTION ========================================
-- *** Stored Procedure tạo mã tự tăng. =====================================================
-- Mã NHANVIEN tự tăng --> STORED PROC
CREATE 
--ALTER
PROC USP_ascending_NV
@MaNV varchar(10) OUT
AS
BEGIN
	SET @MaNV = 'NV0001'
	DECLARE @i int  = 1
	WHILE exists(select * from NHANVIEN where MaNV = @MaNV)
	BEGIN
		SET @MaNV = 'NV' + REPLICATE('0', 4 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
		SET @i = @i + 1
	END
END
GO

-- Mã KHACHHANG tự tăng --> FUNCTION
CREATE 
--ALTER
FUNCTION UF_AUTO_MAKH()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MaKH varchar(10)
	SET @MaKH = 'KH0001'
	DECLARE @i int  = 2
	WHILE exists(select * from KHACHHANG where MaKH = @MaKH)
	BEGIN
		SET @MaKH = 'KH' + REPLICATE('0', 4 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
		SET @i = @i + 1
	END
	RETURN @MaKH
END
GO

-- Mã PHIEUTHUE tự tăng --> STORED PROC
CREATE 
--ALTER
PROC USP_AUTO_MAPHIEU
@MaPT varchar(10) OUT
AS
BEGIN
	SET @MaPT = 'PT0001'
	DECLARE @i int  = 1
	WHILE exists(select * from PHIEUTHUE where MaPT = @MaPT)
	BEGIN
		SET @MaPT = 'PT' + REPLICATE('0', 4 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
		SET @i = @i + 1
	END
END
GO

-- Mã PHIEUTRA tự tăng --> FUNCTION
GO
CREATE 
--ALTER
FUNCTION UF_AUTO_MAPHIEUTRA()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MaPTra varchar(10)
	SET @MaPTra = 'PTra0001'
	DECLARE @i int = 2
	WHILE exists(select * from PHIEUTRA where MaPTra = @MaPTra)
	BEGIN
		SET @MaPTra = 'PTra' + REPLICATE('0', 4 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
		SET @i = @i + 1
	END
	RETURN @MaPTra
END
GO

-- Mã PHIEUGIAHANG tự tăng --> FUNCTION
CREATE 
--ALTER
FUNCTION UF_AUTO_PHIEUGH()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @MaPhieuGH varchar(10)
	SET @MaPhieuGH = 'PGH0001'
	DECLARE @i int  = 2
	WHILE exists(select * from GIAHAN where MaPhieuGH = @MaPhieuGH)
	BEGIN
		SET @MaPhieuGH = 'PGH' + REPLICATE('0', 4 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
		SET @i = @i + 1
	END
	RETURN @MaPhieuGH
END
GO

-- ===========================================================================================================
-- *** Stored Procedure chức năng. ===========================================================================
-- Lấy Thông Tin Thực Đơn -- STORED PROC
CREATE
--ALTER
PROC USP_GetFoodList
AS
BEGIN
	select * from FOODLIST
END
GO

-- Thêm Hóa Đơn Thanh Toán Thức Ăn -- STORED PROC
CREATE PROC USP_InsertBillFood
@ID varchar(5),
@TenTP nvarchar(50),
@SoLuong int,
@GiaThanh float,
@TongTien float
AS
BEGIN
	INSERT INTO BILLFOOD VALUES (@ID, @TenTP, @SoLuong, @GiaThanh, @TongTien)
END
GO

-- Thêm Tài Khoản vào table(ACCOUNT) -- STORED PROC
CREATE
--ALTER
PROC USP_INSERT_ACCOUNT
@MaTK varchar(10),
@TenTK varchar(100),
@MatKhau varchar(50),
@LoaiTK nvarchar(20)
AS
BEGIN
	IF exists(select * from ACCOUNT where TenTK = @TenTK)
	BEGIN
		PRINT N'Email Của Bạn Đã Tồn Tại!'
	END
	ELSE
	BEGIN
		INSERT INTO ACCOUNT VALUES (@MaTK, @TenTK, @MatKhau, @LoaiTK)
	END
END
GO

-- Thêm Thông Tin Nhân Viên vào table(NHANVIEN) -- STORED PROC
CREATE
--ALTER
PROC USP_INSERT_NHANVIEN
@MaTK varchar(10),
@TenNV nvarchar(50),
@SDT varchar(11),
@GTinh nvarchar(6),
@DiaChi nvarchar(150),
@NgaySinh date
AS
BEGIN
	INSERT INTO NHANVIEN VALUES (@MaTK, @TenNV, @SDT, @GTinh, @DiaChi, @MaTK, null , @NgaySinh , null)
END
GO

-- Thêm Thông Tin Phòng vào table(PHONG) -- STORED PROC
CREATE
--ALTER
PROC USP_INSERT_PHONG
@MaPhong varchar(10),
@LoaiPhong nvarchar(50),
@DonGia varchar(11),
@ThongTin nvarchar(1000),
@Hinh1 image,
@Hinh2 image,
@Hinh3 image,
@Hinh4 image
AS
BEGIN
	INSERT INTO PHONG VALUES (@MaPhong, @LoaiPhong, @DonGia, N'Chưa Thuê', @ThongTin, @Hinh1, @Hinh2, @Hinh3, @Hinh4)
END
GO

-- Sửa Thông Tin Phòng trong table(PHONG) -- STORED PROC
CREATE 
--ALTER
PROC USP_UPDATE_PHONG
@MaPhong varchar(10),
@LoaiPhong nvarchar(50),
@DonGia varchar(11),
@ThongTin nvarchar(1000),
@Hinh1 image,
@Hinh2 image,
@Hinh3 image,
@Hinh4 image
AS
BEGIN
	UPDATE PHONG
	SET LoaiPhong = @LoaiPhong, DonGia = @DonGia, ThongTin = @ThongTin,
	HinhAnh1 = @Hinh1, HinhAnh2 = @Hinh2, HinhAnh3 = @Hinh3, HinhAnh4 = @Hinh4
	WHERE MaPhong = @MaPhong
END
GO

-- Thêm Thông Tin Khách Hàng vào table(KHACHHANG) -- STORED PROC
CREATE
--ALTER
PROC USP_INSERT_KHACHHANG
@SoCMND varchar(15),
@TenKH nvarchar(50),
@NgSinh date,
@DiaChiTT nvarchar(100)
AS
BEGIN
	INSERT INTO KHACHHANG VALUES (dbo.UF_AUTO_MAKH(), @SoCMND, @TenKH, @NgSinh, @DiaChiTT)
END
GO

-- Thêm Thông Tin Phiếu Thuê và Chi Tiết Phiếu Thuê vào table(PHIEUTHUE) & table(CT_PHIEUTHUE) -- STORED PROC
CREATE
--ALTER
PROC USP_INSERT_PHIEUTHUE_CTPT
@MaPT varchar(10),
@SoCMND varchar(15),
@GioThue varchar(15),
@NgayThue date,
@MaPhong varchar(10),
@SoNgayThue int,
@NgayTra date
AS
BEGIN
	DECLARE @MaKH varchar(10)
	SELECT @MaKH = MaKH from KHACHHANG where SoCMND = @SoCMND
	INSERT INTO PHIEUTHUE VALUES (@MaPT , @NgayThue, @MaKH , @GioThue, @NgayTra)
	INSERT INTO CT_PHIEUTHUE VALUES (@MaPhong, @MaPT, @SoNgayThue, '')
END
GO

-- Thêm Thông Tin Phiếu Trả và Chi Tiết Phiếu Trả vào table(PHIEUTRA) & table(CT_PHIEUTRA) -- STORED PROC
CREATE
--ALTER
PROC USP_INSERT_PHIEUTRA_CTPT
@MaPT varchar(10),
@NgayTra varchar(20),
@MaPhong varchar(10),
@SoNgayThue int,
@SoTienPhaiTra varchar(30),
@Discount nvarchar(20)
AS
BEGIN
	DECLARE @MaPTra varchar(10) = dbo.UF_AUTO_MAPHIEUTRA();
	INSERT INTO PHIEUTRA VALUES (@MaPTra, @MaPT, @NgayTra)
	INSERT INTO CT_PHIEUTRA VALUES (@MaPhong, @MaPTra, @SoNgayThue, @SoTienPhaiTra, @Discount)
END
GO

-- Thêm Thông Tin Phiếu Gia Hạn vào table(GIAHAN) -- STORED PROC
CREATE
--ALTER
PROC USP_INSERT_PHIEUGH
@MaPT varchar(10),
@SoNgayGH int,
@NgayGH date
AS
BEGIN
	INSERT INTO GIAHAN VALUES (dbo.UF_AUTO_PHIEUGH(), @MaPT, @SoNgayGH, @NgayGH)
END
GO

-- Select Thông Tin Phiếu Thuê trong table(PHIEUTHUE) 
CREATE 
--ALTER
PROC USP_LOADRentList
AS
BEGIN
	select kh.MaKH, kh.TenKH, kh.SoCMND, ct_pt.MaPhong, pt.NgayThue,ct_pt.SoNgayThue from PHIEUTHUE pt join CT_PHIEUTHUE ct_pt on pt.MaPT = ct_pt.MaPT join KHACHHANG kh on pt.MaKH = kh.MaKH 
	where pt.MaPT not in (select MaPT from PHIEUTRA) and TenKH like N'%%'
END
GO

-- Thống Kê Doanh Thu Giữa 2 Ngày -- INPUT Đưa Vào -- STORED PROC
GO
CREATE 
-- ALTER 
PROC USP_DOANHTHU_DATHUE
@fromday date,
@today date
AS
BEGIN
	select MaPhong, NgayTra, SoTienPhaiTra, Discount 
	from PHIEUTRA pt join CT_PHIEUTRA ctptr on pt.MaPTra = ctptr.MaPTra
	where NgayTra >= @fromday and NgayTra <= @today
END
GO

-- Xuất Hóa Đơn Thông Tin Dịch Vụ Của KH -- STORED PROC
CREATE 
-- ALTER 
PROC USP_HOADON_PHONG
@MaPT varchar(10)
AS
BEGIN
	select pt.MaPT, pt.NgayThue, pt.NgayTra, ctpt.SoNgayThue, p.MaPhong, p.LoaiPhong, p.DonGia
	from PHIEUTHUE pt join CT_PHIEUTHUE ctpt on pt.MaPT = ctpt.MaPT
	join PHONG p on ctpt.MaPhong = p.MaPhong
	where pt.MaPT = @MaPT
END
GO

-- Xuất Hóa Đơn Thông Tin Dịch Vụ Thức ăn Của KH -- STORED PROC
CREATE 
-- ALTER 
PROC USP_HOADON_FOODS
@MaKH varchar(10)
AS
BEGIN
	select ID,TenTP, SUM(SoLuong) AS N'NumberofProducts', GiaThanh,SUM(TongTien) AS N'TotalPrice' from BILLFOOD where MaKH = @MaKH
	group by ID,TenTP, GiaThanh
END
GO
-- Xuất Hóa Đơn Thông Tin Gia Hạn -- STORED PROC
CREATE 
-- ALTER 
PROC USP_HOADON_GIAHAN
@MaPT varchar(10)
AS
BEGIN
	select NgayGH, SoNgayGH from GIAHAN where MaPT = @MaPT
END
GO

-- Xuất Hóa Đơn Thông Tin KH -- STORED PROC
CREATE 
-- ALTER 
PROC USP_HOADON_KHACHHANG
@MaKH varchar(10)
AS
BEGIN
	select * from KHACHHANG where MaKH = @MaKH
END
GO

-- UPDATE ACCOUNT -- STORED PROC
CREATE 
-- ALTER 
PROC USP_UPDATE_TAIKHOAN
@manv varchar(10),
@email varchar(50),
@hoten nvarchar(50),
@sdt varchar(15),
@gioitinh nvarchar(10),
@diachi nvarchar(200),
@loaiTK nvarchar(20),
@ngaysinh date
AS
BEGIN
	UPDATE ACCOUNT
	SET TenTK = @email, LoaiTK = @loaiTK
	WHERE MaTK = @manv

	UPDATE NHANVIEN
	SET TenNV = @hoten, SDT = @sdt, GTinh = @gioitinh, DiaChi = @diachi, NgSinh = @ngaysinh
	WHERE MaNV = @manv
END
GO

-- UPDATE NHANVIEN QUẢN LÝ -- STORED PROC
CREATE 
-- ALTER 
PROC USP_UPDATE_NHANVIEN
@MaNV varchar(10)
AS
DECLARE CUR CURSOR FOR (select nv.MaNV from NHANVIEN nv join ACCOUNT ac on nv.MaTK = ac.MaTK Where ac.LoaiTK = N'Nhân Viên' and nv.NVQL = @MaNV)
OPEN CUR
DECLARE @NVQL varchar(10)
FETCH NEXT FROM CUR INTO @MaNV
WHILE @@FETCH_STATUS = 0
BEGIN
	SET @NVQL = null
	UPDATE NHANVIEN SET NVQL = @NVQL WHERE MaNV = @MaNV
	FETCH NEXT FROM CUR INTO @MaNV
END
CLOSE CUR
DEALLOCATE CUR
GO

-- Trigger update SL sản phẩm 
CREATE
--ALTER
 TRIGGER UTR_FOODLIST
ON FOODLIST
FOR INSERT, UPDATE --> ĐÃ THÊM VÀO BẢNG DT -> ĐIỀU KIỆN KIỂM LÀ ĐK VI PHẠM
AS
BEGIN
	IF UPDATE(SoLuong)
		IF EXISTS(SELECT * FROM inserted I WHERE SoLuong = 0)
		BEGIN
			--XỬ LÝ
			--CÁCH 1: DÙNG TRUY VẤN
			UPDATE FOODLIST
			SET TrangThai = N'Hết hàng'
			FROM inserted I
			WHERE I.SoLuong = 0 and I.ID = FOODLIST.ID
		END
END
GO
CREATE
--ALTER
 TRIGGER UTR_FOODLIST_False
ON FOODLIST
FOR INSERT, UPDATE --> ĐÃ THÊM VÀO BẢNG DT -> ĐIỀU KIỆN KIỂM LÀ ĐK VI PHẠM
AS
BEGIN
	IF UPDATE(SoLuong)
		IF EXISTS(SELECT * FROM inserted I WHERE SoLuong > 0)
		BEGIN
			--XỬ LÝ
			--CÁCH 1: DÙNG TRUY VẤN
			UPDATE FOODLIST
			SET TrangThai = N'Còn hàng'
			FROM inserted I
			WHERE I.SoLuong > 0 and I.ID = FOODLIST.ID
		END
END
GO
-- Insert BILLFOODS -- STORED PROC
CREATE 
-- ALTER 
PROC USP_INSERT_BILLFOODS
@MaKH varchar(10),
@ID varchar(7),
@TenTP nvarchar(50),
@SoLuong int,
@GiaThanh float,
@TongTien float
AS
	INSERT INTO BILLFOOD VALUES (@MaKH , @ID , @TenTP, @SoLuong, @GiaThanh, @TongTien)
GO

-- Insert FOODLIST -- STORED PROC
CREATE 
-- ALTER 
PROC USP_INSERT_FOODLIST
@Loai varchar(15),
@TenTP nvarchar(50),
@GiaThanh float,
@SoLuong int,
@HinhAnh image
AS
	DECLARE @ID varchar(10)
	DECLARE @i int  = 2
	IF (@Loai = 'Drinks')
	BEGIN
		SET @ID = 'D001'
		WHILE exists(select * from FOODLIST where ID = @ID)
		BEGIN
			SET @ID = 'D' + REPLICATE('0', 3 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
			SET @i = @i + 1
		END
	END
	ELSE IF (@Loai = 'Foods')
	BEGIN
		SET @ID = 'F001'
		WHILE exists(select * from FOODLIST where ID = @ID)
		BEGIN
			SET @ID = 'F' + REPLICATE('0', 3 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
			SET @i = @i + 1
		END
	END
	ELSE IF (@Loai = 'Snack')
	BEGIN
		SET @ID = 'S001'
		WHILE exists(select * from FOODLIST where ID = @ID)
		BEGIN
			SET @ID = 'S' + REPLICATE('0', 3 - len(CAST(@i as varchar(4)))) + CAST(@i as varchar(4))
			SET @i = @i + 1
		END
	END
	ELSE IF (@Loai = 'Milk Tea')
	BEGIN
		SET @ID = 'MT001'
		WHILE exists(select * from FOODLIST where ID = @ID)
		BEGIN
			SET @ID = 'MT' + REPLICATE('0', 3 - len(CAST(@i as varchar(3)))) + CAST(@i as varchar(3))
			SET @i = @i + 1
		END
	END
	INSERT INTO FOODLIST VALUES (@ID, @Loai, @TenTP, @GiaThanh, @HinhAnh, @SoLuong, null)
GO
select * from FOODLIST
-- update FOODLIST -- STORED PROC
CREATE 
-- ALTER 
PROC USP_UPDATE_FOODLIST
@ID varchar(10),
@Loai varchar(50),
@TenTP nvarchar(50),
@GiaThanh float,
@SoLuong int,
@HinhAnh image
AS
	UPDATE FOODLIST SET Loai = @Loai, TenTP = @TenTP, GiaThanh = @GiaThanh, SoLuong = @SoLuong, HinhAnh = @HinhAnh where ID = @ID
GO

select * from KHACHHANG
-- =================== END STORED PROCEDURE =====================================