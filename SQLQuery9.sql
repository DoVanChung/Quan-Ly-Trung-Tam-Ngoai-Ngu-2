USE [QuanLyTrungTamNgoaiNguV12]
GO
/****** Object:  StoredProcedure [dbo].[SELECTALLGIAOVIEN]    Script Date: 12/8/2023 1:03:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SELECTALLGIAOVIEN]
	@tukhoa nvarchar(50)
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