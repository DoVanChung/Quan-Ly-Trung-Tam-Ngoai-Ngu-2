USE [QuanLyTrungTamNgoaiNguV11]
GO
/****** Object:  StoredProcedure [dbo].[SelectLop]    Script Date: 12/8/2023 12:19:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectLop]
	@MaLop int 
as
begin
	select MaGiaoVien, MaNgoaiNgu from BangLop where MaLop = @MaLop;
end

select * from BangLop

create sequence lopSeq
	start with 0
	increment by 1;

Insert into BangLop
(
	MaLop, TenLop, MaGiaoVien, MaNgoaiNgu, Thoigian, ThongTinLop, GhiChu
)values 
(
		 1+ cast (next value for lopSeq as int),
		 N'Lớp dạy Anh Ngữ',
		 10000,
		 1,
		 N'Học Trong 2 Tháng',
		 N'Lớp Tốt',
		 N'Không có ghi chú'
)

delete from BangLop
 where MaLop = 98