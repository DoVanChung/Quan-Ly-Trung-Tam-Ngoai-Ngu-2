create procedure selectLop
	@MaLop int
as
begin
	select MaGiaoVien, MaNgoaiNgu from BangLop where MaLop = @MaLop;
end