--Tao co so du lieu
CREATE DATABASE QuanLyTrungTamNgoaiNguV7
USE QuanLyTrungTamNgoaiNguV7


CREATE TABLE BangGiaoVien
(
    MaGiaoVien INT PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh TINYINT NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(10) NOT NULL UNIQUE
)

CREATE TABLE BangHocVien
(
    MaHocVien INT PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh TINYINT NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(10) NOT NULL UNIQUE
)

CREATE TABLE BangLop
(
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(30) UNIQUE NOT NULL,
    MaGiaoVien INT NOT NULL REFERENCES BangGiaoVien(MaGiaoVien),
	MaHocVien INT NOT NULL REFERENCES BANGHOCVIEN(MaHocVien),
    ThoiGian NVARCHAR(50) NOT NULL,
    GhiChu NVARCHAR(100)
)

--Tao sequence tu dong tang cho ma hoc vien
Select * from BangHocVien
create sequence hocvienSeq
	start with 1000
	increment by 1;

Insert into BangHocVien
(
	MaHocVien,
	HoTen,
	NgaySinh,
	GioiTinh,
	DiaChi,
	SoDienThoai
)values 
(
		 90+ cast (next value for hocvienSeq as int),
		 N'Đỗ Văn Chung',
		 '06-19-2003',
		 1,
		 N'Địa chỉ nhà của Chung',
		 0789736619
)

CREATE PROCEDURE SELECTALLHOCVIEN -- tạo cái này để lấy toàn bộ học viên
AS
	select 
		MaHocVien,
		HoTen,
		CONVERT(varchar(10), NgaySinh, 103) as NgaySinh, --định dạng lại ngày sinh thanh dd//mm/yyyy
		case 
			when GioiTinh = 1 then 'Nam'
			else N'Nữ'
		end as GioiTinh,-- biểu diễn lại giới tính
		DiaChi,
		SoDienThoai
	from BangHocVien
GO;

exec SELECTALLHOCVIEN

--tạo stored procedure để thêm mới một hv vào bảng HocVien
CREATE PROCEDURE ThemMoiHV
	--Khai báo danh sách tham số truyền vào
	@HoTen nvarchar(15),
	@NgaySinh date,
	@GioiTinh tinyint,
	@DiaChi nvarchar(100),
	@SoDienThoai nvarchar(10)
AS
BEGIN
	--thêm dữ liệu mới
	INSERT INTO BangHocVien
	(
		MaHocVien,
		HoTen,
		NgaySinh,
		GioiTinh,
		DiaChi,
		SoDienThoai
	) 
	VALUES 
	(
	90+ cast (next value for hocvienSeq as int),
	@HoTen,
	@NgaySinh,
	@GioiTinh,
	@DiaChi,
	@SoDienThoai
	);
	--kiem tra xem insert da thanh cong hay chua
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END
exec ThemMoiHV N'Cao Hoàng Hải', '01-02-2003', 1, N'Địa chỉ nhà của Hải', 0123367281

create procedure updateHocVien
	@MaHocVien int,
	@HoTen nvarchar(15),
	@NgaySinh date,
	@GioiTinh tinyint,
	@DiaChi nvarchar(100),
	@SoDienThoai nvarchar(10)
AS
BEGIN
	update BangHocVien
	set 
		HoTen = @HoTen,
		NgaySinh = @NgaySinh,
		GioiTinh = @GioiTinh,
		DiaChi = @DiaChi,
		SoDienThoai = @SoDienThoai	
	where MaHocVien = @MaHocVien;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

-- tạo procedure để select thông tin chi tiết của một học viên
create procedure selectHV
	@MaHocVien int
AS
BEGIN
	Select
		HoTen, convert(varchar(10), NgaySinh,103) as NgaySinh,
		GioiTinh,
		DiaChi, SoDienThoai
	from BangHocVien
	where MaHocVien = @MaHocVien;
END 
 
--Tao sequence tu dong tang cho ma giao vien 
Select * from BangGiaoVien
create sequence giaovienSeq
	start with 1000
	increment by 1;

Insert into BangGiaoVien
(
	MaGiaoVien,
	HoTen,
	NgaySinh,
	GioiTinh,
	DiaChi,
	DienThoai
)values 
(
		 10+ cast (next value for giaovienSeq as int),
		 N'Đỗ Như Nhung',
		 '09-12-1999',
		 0,
		 N'Địa chỉ nhà của Nhung',
		 0123621182
)

