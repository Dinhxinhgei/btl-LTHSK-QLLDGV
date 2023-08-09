use BTL01

ALTER Proc select_mon
@mamon as NVARCHAR(10) = NULL,
@tenmon as NVARCHAR(25) = NULL,
@sotin as int = NULL
AS
SELECT sMamon, sTenmon, iSotin
	FROM MON
	WHERE sMamon = ISNULL(@mamon, sMamon)
        AND sTenmon = ISNULL(@tenmon, sTenmon)
        AND iSotin = ISNULL(@sotin, iSotin)

exec select_mon


create or alter proc select_lichday
as
	select dNgayday, sCaday, sTengv, sMamon, sMalop, sMap, iSosv, sTrangthai, sGhichu
	from LICHDAY LD
	INNER JOIN GIANGVIEN GV ON LD.sMagv = GV.sMagv
	INNER JOIN MON M ON M.sMamon = LD.sMamon
	INNER JOIN LOP L ON L.sMalop = LD.sMalop;

exec select_lichday
--drop proc select_lichday
create or alter view vv_select_lichday
as
	select dNgayday, sCaday, LD.sMagv as sMagv, sTengv, LD.sMamon as sMamon, sTenmon, LD.sMalop as sMalop, sMap, iSosv, sTrangthai, sGhichu
	from LICHDAY LD
	INNER JOIN GIANGVIEN GV ON LD.sMagv = GV.sMagv
	INNER JOIN MON M ON M.sMamon = LD.sMamon
	INNER JOIN LOP L ON L.sMalop = LD.sMalop;

--**insert****************************************************************************************
CREATE PROC THEMMON
@MAMON NVARCHAR(30),
@TENMON NVARCHAR(30),
@SOTIN INT
AS
	IF EXISTS(SELECT sMamon FROM MON WHERE @MAMON=sMamon)
	BEGIN
		PRINT N'ĐÃ XẢY RA LỖI VUI LÒNG KIỂM TRA'
		RETURN 
	END
	ELSE
	BEGIN		
		INSERT INTO MON(sMamon,sTenmon,iSotin) VALUES (@MAMON,@Tenmon,@SOTIN)
		PRINT N'NHẬP THÀNH CÔNG'
	END

EXEC THEMMON 'haha','haha','5'

--them giang vien
CREATE PROC THEM_GIANGVIEN
@maGV NVARCHAR(10),
@tenGV NVARCHAR(25),
@gioiTinh NVARCHAR(10),
@ngaySinh Date,
@diaChi NVARCHAR(25),
@SDT NVARCHAR(10),
@chucVu NVARCHAR(20)
AS
	IF EXISTS(SELECT @maGV FROM GIANGVIEN WHERE @maGV=sMagv)
	BEGIN
		PRINT N'ĐÃ XẢY RA LỖI VUI LÒNG KIỂM TRA'
		RETURN 
	END
	ELSE
	BEGIN		
		INSERT INTO GIANGVIEN(sMagv,sTengv,sGioitinh, dNgaysinh, sDiachi, sSDT, sChucvu) 
		VALUES (@maGV, @tenGV, @gioiTinh, @ngaySinh, @diaChi, @SDT, @chucVu)
		PRINT N'NHẬP THÀNH CÔNG'
	END

EXEC THEM_GIANGVIEN '001', '001', 'Nam', '1998-1-1', N'Thanh Xuan', 0123456789, '001'

select*from LICHDAY;
select*from LOP;


--them LICHDAY
CREATE or alter proc themLichday
@ngayday Date,
@caday NVARCHAR(12),
@magv NVARCHAR(10),
@mamon NVARCHAR(10),
@malop NVARCHAR(20),
@map NVARCHAR(10),
@trangthai NVARCHAR(10),
@ghichu NVARCHAR(50)
AS
	--IF EXISTS(SELECT @ngayday, @caday, @map, @trangthai FROM vv_checktrung WHERE @ngayday=dNgayday and @caday=sCaday and @map = sMap and @trangthai=sTrangthai  )
	--	BEGIN
	--		PRINT N'Phòng ' + @map+' đã có lớp học trong ngày ' + @ngayday + ' rồi'
	--		RETURN 
	--	END
	--ELSE
		BEGIN		
			INSERT INTO LICHDAY(dNgayday, sCaday, sMagv, sMamon, sMalop, sMap, sTrangthai, sGhichu) 
			VALUES (@ngayday, @caday, @magv, @mamon, @malop, @map, @trangthai, @ghichu)
			PRINT N'NHẬP THÀNH CÔNG'
		END

exec themLichday @ngayday = '2021-9-8', @caday = N'Chiều', 
				@magv = 'GV1', @mamon = 'CSDL' , @malop = 'AACT7TWEB43', 
				@map = 'P24', @trangthai = N'Học' ,  @ghichu = N'Tuần 2';
create view vv_checktrung
as
	select dNgayday, sCaday, sTengv, sTenmon, LICHDAY.sMalop, LICHDAY.sMap, iSosv, sTrangthai, sGhichu 
        from LICHDAY 
        INNER JOIN GIANGVIEN ON LICHDAY.sMagv = GIANGVIEN.sMagv 
        INNER JOIN MON ON MON.sMamon = LICHDAY.sMamon 
        INNER JOIN LOP ON LOP.sMalop = LICHDAY.sMalop;

select * from vv_checktrung

select*from LICHDAY;

--them lop
CREATE PROC Them_LOP
@malop NVARCHAR(20),
@sosv INT
AS
	IF EXISTS(SELECT sMalop FROM LOP WHERE @malop = sMalop)
	BEGIN
		PRINT N'ĐÃ XẢY RA LỖI VUI LÒNG KIỂM TRA'
		RETURN 
	END
	ELSE
	BEGIN		
		INSERT INTO LOP(sMalop, iSosv) VALUES (@malop, @sosv)
		PRINT N'NHẬP THÀNH CÔNG'
	END

select*from LOP;

--**Update****************************************************************************************
--update mon
CREATE PROC update_mon
@MAMON NVARCHAR(30),
@TENMON NVARCHAR(30),
@SOTIN INT
AS
BEGIN
UPDATE MON 
	SET sTenmon= @Tenmon, iSotin = @SOTIN 
	WHERE sMamon =  @MAMON
END

--update lich day
			
CREATE proc UPDATE_Lichday
@ngayday Date,
@caday NVARCHAR(12),
@magv NVARCHAR(10),
@mamon NVARCHAR(10),
@malop NVARCHAR(20),
@map NVARCHAR(10),
@trangthai NVARCHAR(10),
@ghichu NVARCHAR(50)
AS
UPDATE LICHDAY 
	SET dNgayday	= @ngayday, 
		sCaday		= @caday ,
		sMagv		= @magv ,
		sMamon		= @mamon ,
		sMalop		= @malop ,
		sMap		= @map ,
		sTrangthai	= @trangthai ,
		sGhichu		= @ghichu
	WHERE	dNgayday= @ngayday 
	and		sCaday	= @caday 
	and		sMagv	= @magv 
	and		sMamon	= @mamon 
	and		sMalop	= @malop 
	and		sMap	= @map


--update lop

CREATE PROC UPDATE_LOP
@malop NVARCHAR(20),
@sosv int
AS
BEGIN
UPDATE LOP 
	SET iSosv = @sosv 
	WHERE sMalop =  @malop
END

--update giang viên

CREATE PROC UPDATE_GIANGVIEN
@maGV NVARCHAR(10),
@tenGV NVARCHAR(25),
@gioiTinh NVARCHAR(10),
@ngaySinh Date,
@diaChi NVARCHAR(25),
@SDT NVARCHAR(10),
@chucVu NVARCHAR(20)
AS
BEGIN
UPDATE GIANGVIEN 
	SET
	sMagv = @maGV,
	sTengv = @tenGV,
	sGioitinh = @gioiTinh,
	dNgaysinh = @ngaySinh,
	sDiachi = @diaChi,
	sSdt = @SDT,
	sChucvu = @chucVu
	WHERE sMagv =  @maGV
END

select*from GIANGVIEN;

--**delete****************************************************************************************************
--xoa mon
CREATE PROC delete_mon
@MAMON NVARCHAR(30)
AS
BEGIN
	DELETE FROM  MON 
	WHERE sMamon =  @MAMON
END
--drop proc deletes
--xoa giang vien
CREATE PROC DELETE_GV
@maGV NVARCHAR(10)
AS
BEGIN
	DELETE FROM  GIANGVIEN 
	WHERE sMagv =  @maGV
END

--xoa lop
CREATE PROC DELETE_LOP
@malop NVARCHAR(20)
AS
BEGIN
	DELETE FROM LOP 
	WHERE sMalop =  @malop
END

--**search********************************************************************************************************************

--bang giang vien
--tim kiem theo ten
CREATE OR ALTER   PROC [dbo].[TimKiem_Ten]
@Tengv NVARCHAR(30)

AS
BEGIN
	

	SELECT *
		FROM GIANGVIEN WHERE sTengv like  '%'+@Tengv+'%'
    END 
go
Exec TimKiem_Ten @Tengv=N'Nguyễn'
--tim kiếm theo tên và giới tính
CREATE OR ALTER   PROC [dbo].[TimKiem_All]
@Tengv NVARCHAR(30),
@Gioitinh nvarchar(10)

AS
BEGIN
	IF ( @Gioitinh =N'Nam')
	BEGIN 
		(SELECT *
		FROM GIANGVIEN WHERE sGioitinh =N'Nam'and sTengv like  '%'+@Tengv+'%' )
    END 
	IF(@Gioitinh =N'Nữ')
	BEGIN 
		(SELECT *
		FROM GIANGVIEN WHERE sGioitinh =N'Nữ'and sTengv like  '%'+@Tengv+'%' )
	END 
end
exec TimKiem_All @Tengv=N'l',@Gioitinh=N'Nam'
go
--tìm kiếm theo giới tính
CREATE OR ALTER   PROC [dbo].[TimKiem_Gioitinh]
@Gioitinh nvarchar(10)
AS
BEGIN
	
	IF ( @Gioitinh =N'Nam')
	BEGIN 
		(SELECT *
		FROM GIANGVIEN WHERE sGioitinh =N'Nam' )
    END 
	IF(@Gioitinh =N'Nữ')
	BEGIN 
		(SELECT *
		FROM GIANGVIEN WHERE sGioitinh =N'Nữ')
	END 
END
GO
--bang mon
--theo mamon
CREATE PROC search_mon
@MAMON as NVARCHAR(10) = NULL,
@TENMON as NVARCHAR(25) = NULL,
@SOTIN INT = NULL
AS
BEGIN
	select * FROM  MON 
	WHERE sMamon =  @MAMON and sTenmon = @TENMON and iSotin = @SOTIN
END

--theo tenmon
CREATE PROC search_tenmon
@TENMON NVARCHAR(30)
AS
BEGIN
	select * FROM  MON 
	WHERE sTenmon like  '%'+@TENMON+'%'
END

exec search_tenmon "cơ sở"

--theo ten va so tin
CREATE or alter PROC search_ten_st
@TENMON NVARCHAR(30),
@SOTIN int
AS
BEGIN
	select * FROM  MON 
	WHERE sTenmon like  '%'+@TENMON+'%' and iSotin = @SOTIN
END
--theo so tin
CREATE PROC search_sotin
@SOTIN int
AS
BEGIN
	select * FROM  MON 
	WHERE iSotin = @SOTIN
END

--search lop
CREATE PROC SEARCH_LOP
@malop NVARCHAR(20)
AS
BEGIN
	select * FROM  LOP 
	WHERE sMalop =  @malop
END
