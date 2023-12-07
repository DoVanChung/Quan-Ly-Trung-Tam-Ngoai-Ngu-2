USE [QuanLyTrungTamNgoaiNguV10]
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 12/7/2023 8:21:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[dangnhap]
	@loaitaikhoan varchar(20),
	@taikhoan varchar(20),
	@matkhau varchar(20)
as
begin
	if
		@loaitaikhoan = 'admin' 
		select * 
		from TaiKhoan
		where TenTaiKhoan = @taikhoan
		and MatKhau = @matkhau;
		else if
			@loaitaikhoan = 'gv' 
			select * 
			from BangGiaoVien
			where convert(varchar(50),MaGiaoVien) = @taikhoan
			and matkhau = @matkhau;
			else 
			select * 
			from BangHocVien
			where convert(varchar(50),MaHocVien) = @taikhoan
			and SoDienThoai = @matkhau;	
end;