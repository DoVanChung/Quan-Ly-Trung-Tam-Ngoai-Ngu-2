--Tao co so du lieu
CREATE DATABASE QuanLyTrungTamNgoaiNguV10
USE QuanLyTrungTamNgoaiNguV10

CREATE TABLE TaiKhoan
(
	MaTaiKhoan NVARCHAR(10) PRIMARY KEY,
	TenTaiKhoan NVARCHAR(20) NOT NULL UNIQUE,
	MatKhau NVARCHAR(10) NOT NULL,
	VaiTro NVARCHAR(30) NOT NULL
)

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

CREATE TABLE BangNgoaiNgu 
(
	MaNgoaiNgu INT PRIMARY KEY,
	TenNgoaiNgu NVARCHAR(30) UNIQUE NOT NULL
)

CREATE TABLE BangLop
(
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(30) UNIQUE NOT NULL,
    MaGiaoVien INT NOT NULL REFERENCES BangGiaoVien(MaGiaoVien),
	MaNgoaiNgu INT NOT NULL REFERENCES BangNgoaiNgu(MaNgoaiNgu),
    ThoiGian NVARCHAR(50) NOT NULL,
    ThongTinLop NVARCHAR(1000) NOT NULL,
	GhiChu NVARCHAR(100)
)

--Tao sequence tu dong tang cho ma hoc vien
Select * from BangHocVien


create sequence hocvienSeq
	start with 10000
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
		 0+ cast (next value for hocvienSeq as int),
		 N'Đỗ Văn Chung',
		 '06-19-2003',
		 1,
		 N'Địa chỉ nhà của Chung',
		 0789736619
)
-- Xóa Học Viên              EXECUTE CẢ CÁI NÀY NỮA
create procedure deleteHV
	@MaHocVien int
AS
BEGIN
	DELETE from BangHocVien
	WHERE [MaHocVien] = @MaHocVien
END


-- tạo cái này để lấy toàn bộ học viên và sắp xếp tìm kiếm    EXECUTE LẠI CÁI NÀY VÀO SQL TRƯỚC NHA
CREATE PROCEDURE SELECTALLHOCVIEN 
	@tukhoa int
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
	where 
		lower(MaHocVien) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
		or lower(HoTen) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
		or lower(SoDienThoai) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
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

------
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

 




-- frm moi cua giao vien
--Tao sequence tu dong tang cho ma giao vien 
Select * from BangGiaoVien


create sequence giaovienSeq
	start with 10000
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
		 0+ cast (next value for giaovienSeq as int),
		 N'Đỗ Như Nhung',
		 '09-12-1999',
		 0,
		 N'Địa chỉ nhà của Nhung',
		 0123621182
)


-- Xóa Giáo Viên              EXECUTE CẢ CÁI NÀY NỮA
create procedure deleteGV
	@MaGiaoVien int
AS
BEGIN
	DELETE from BangGiaoVien
	WHERE [MaGiaoVien] = @MaGiaoVien
END


-- tạo cái này để lấy toàn bộ giáo viên và sắp xếp tìm kiếm    EXECUTE LẠI CÁI NÀY VÀO SQL TRƯỚC NHA
CREATE PROCEDURE SELECTALLGIAOVIEN
	@tukhoa int
AS
	select 
		MaGiaoVien,
		HoTen,
		CONVERT(varchar(10), NgaySinh, 103) as NgaySinh, --định dạng lại ngày sinh thanh dd//mm/yyyy
		case 
			when GioiTinh = 1 then 'Nam'
			else N'Nữ'
		end as GioiTinh,-- biểu diễn lại giới tính
		DiaChi,
		DienThoai
	from BangGiaoVien
	where 
		lower(MaGiaoVien) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
		or lower(HoTen) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
		or lower(DienThoai) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
GO;


--tạo stored procedure để thêm mới một GV vào bảng GiaoVien

CREATE PROCEDURE ThemMoiGV
	--Khai báo danh sách tham số truyền vào
	@HoTen nvarchar(15),
	@NgaySinh date,
	@GioiTinh tinyint,
	@DiaChi nvarchar(100),
	@DienThoai nvarchar(10)
AS
BEGIN
	--thêm dữ liệu mới
	INSERT INTO BangGiaoVien
	(
		MaGiaoVien,
		HoTen,
		NgaySinh,
		GioiTinh,
		DiaChi,
		DienThoai
	) 
	VALUES 
	(
	90+ cast (next value for giaovienSeq as int),
	@HoTen,
	@NgaySinh,
	@GioiTinh,
	@DiaChi,
	@DienThoai
	);
	--kiem tra xem insert da thanh cong hay chua
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END


create procedure updateGiaoVien
	@MaGiaoVien int,
	@HoTen nvarchar(15),
	@NgaySinh date,
	@GioiTinh tinyint,
	@DiaChi nvarchar(100),
	@DienThoai nvarchar(10)
AS
BEGIN
	update BangGiaoVien
	set 
		HoTen = @HoTen,
		NgaySinh = @NgaySinh,
		GioiTinh = @GioiTinh,
		DiaChi = @DiaChi,
		DienThoai = @DienThoai	
	where MaGiaoVien = @MaGiaoVien;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END


create procedure selectGV
	@MaGiaoVien int
AS
BEGIN
	Select
		HoTen, convert(varchar(10), NgaySinh,103) as NgaySinh,
		GioiTinh,
		DiaChi, DienThoai
	from BangGiaoVien
	where MaGiaoVien = @MaGiaoVien;
END 

select * from BangGiaoVien


--frm ngoai ngu
Select * from BangNgoaiNgu


create sequence NgoaiNguSeq
	start with 1
	increment by 1;

Insert into BangngoaiNgu
(
	MaNgoaiNgu,
	TenNgoaiNgu
)values 
(
		 0+ cast (next value for NgoaiNguSeq as int),
		 N'Anh Ngữ'
)



create procedure deleteNN
	@MaNgoaiNgu int
AS
BEGIN
	DELETE from BangNgoaiNgu
	WHERE [MaNgoaiNgu] = @MaNgoaiNgu
END



CREATE PROCEDURE SELECTALLNGOAINGU
	@tukhoa nvarchar(50)
AS
	select 
		MaNgoaiNgu,
		TenNgoaiNgu
	from BangNgoaiNgu
	where 
		lower(MaNgoaiNgu) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
		or lower(TenNgoaiNgu) like '%'+lower(RTRIM(LTRIM(@tukhoa))) + '%'
GO;




CREATE PROCEDURE ThemMoiNN
	@TenNgoaiNgu nvarchar(50)
AS
BEGIN
	INSERT INTO BangNgoaiNgu
	(
		MaNgoaiNgu,
		TenNgoaiNgu
	) 
	VALUES 
	(
	0+ cast (next value for NgoaiNguSeq as int),
	@TenNgoaiNgu
	);
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END


create procedure updateNgoaiNgu
	@MaNgoaiNgu int,
	@TenNgoaiNgu nvarchar(15)
AS
BEGIN
	update BangNgoaiNgu
	set 
		TenNgoaiNgu = @TenNgoaiNgu	
	where MangoaiNgu = @MaNgoaiNgu;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END


create procedure selectNN
	@MaNgoaiNgu int
AS
BEGIN
	Select
		TenNgoaiNgu
	from BangNgoaiNgu
	where MaNgoaiNgu = @MaNgoaiNgu;
END 



-- frm lop hoc 
select * from BangLop

CREATE PROCEDURE SELECTALLLOP
	@tukhoa varchar(50)
AS
begin
	select 
		1.MaLopHoc,
		g.HoTen,
		m.TenNgoaiNgu
	from BangLop l
	inner join BangGiaoVien g on l.MaGiaoVien = g.MaGiaoVien
	inner join BangNgoaiNgu m on l.MaNgoaiNgu = m.MaNgoaiNgu
	where lower(g.HoTen) like '%'+lower(@TuKhoa)+'%'
	or lower(m.TenNgoaiNgu) like '%'+lower(@TuKhoa)+'%';
end

-------
CREATE PROCEDURE ThemLopHoc
	@MaNgoaiNgu int,
	@MaGiaoVien int
as
begin 
	insert into BangLop(MaNgoaiNgu, MaGiaoVien)
	values(@MaNgoaiNgu, @MaGiaoVien)
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end

-------
CREATE PROCEDURE updateLop
	@MaLop int,
	@MaNgoaiNgu int,
	@MaGiaoVien int
as
begin
	update BangLop
	set MaGiaoVien = @MaGiaoVien,
		MaNgoaiNgu = @MaNgoaiNgu
	where MaLop = @MaLop;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end

-------
CREATE PROCEDURE SelectLop
	@MaLop int 
as
begin
	select MaGiaoVien, MaNgoaiNgu from BangLop where MaLop = @MaLop;
end


create sequence lopSeq
	start with 0
	increment by 1;

Insert into BangLop
(
	MaLop, TenLop, MaGiaoVien, MaNgoaiNgu, Thoigian, ThongTinLop, GhiChu
)values 
(
		 0+ cast (next value for lopSeq as int),
		 N'Lớp dạy Anh Ngữ',
		 10000,
		 1,
		 N'Học Trong 2 Tháng',
		 N'Lớp Tốt',
		 N'Không có ghi chú'
)

select * from BangLop

----------------------------------------- Tạo chức năng đăng nhập



alter table BangGiaoVien add matkhau varchar(50) default 123

create procedure dangnhap
	@loaitaikhoan varchar(20),
	@taikhoan varchar(20),
	@matkhau varchar(20)
as
begin
	if @loaitaikhoan = 'admin' 
		select * 
		from TaiKhoan 
		where TenTaiKhoan = @taikhoan
		and MatKhau = @matkhau
	else 
		@loaitaikhoan = 'gv' 
		select * 
		from BangGiaoVien
		where MaGiaoVien = @taikhoan
		and matkhau = @matkhau;		
end