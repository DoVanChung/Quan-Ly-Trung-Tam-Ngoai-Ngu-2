USE [QuanLyTrungTamNgoaiNguV11]
GO
/****** Object:  StoredProcedure [dbo].[ThemLopHoc]    Script Date: 12/8/2023 12:04:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ThemLopHoc]
	@MaNgoaiNgu int,
	@MaGiaoVien int
as
begin 
	insert into BangLop(MaLop, MaNgoaiNgu, MaGiaoVien)
	values(
		1+ cast (next value for lopSeq as int),
		@MaNgoaiNgu,
		@MaGiaoVien
		);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end

