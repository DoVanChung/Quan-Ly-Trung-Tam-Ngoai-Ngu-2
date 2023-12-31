USE [QuanLyTrungTamNgoaiNguV11]
GO
/****** Object:  StoredProcedure [dbo].[SELECTALLLOP]    Script Date: 12/8/2023 12:39:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SELECTALLLOP]
	@tukhoa varchar(50)
AS
begin
	select 
		l.MaLop,
		g.HoTen,
		m.TenNgoaiNgu
	from BangLop l
	inner join BangGiaoVien g on l.MaGiaoVien = g.MaGiaoVien
	inner join BangNgoaiNgu m on l.MaNgoaiNgu = m.MaNgoaiNgu
	where lower(g.HoTen) like '%'+lower(@TuKhoa)+'%'
	or lower(m.TenNgoaiNgu) like '%'+lower(@TuKhoa)+'%';
end