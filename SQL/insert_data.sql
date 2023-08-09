use BTL01
INSERT INTO GIANGVIEN 
VALUES
	('GV1', N'Nguyễn Thị Tâm'       , N'Nữ' , '1985-8-7', N'Hà Nội'   , '0835271890', N'Giảng Viên'     ),
	('GV2', N'Lê Hữu Dũng'			, N'Nam', '1980-8-16', N'Thái Bình', '0927184638', N'Phó Trưởng Khoa'),
	('GV3', N'Trịnh Thị Xuân'		, N'Nữ' , '1984-2-2', N'Bắc Ninh' , '0926183828', N'Giảng Viên'     ),
	('GV4', N'Nguyễn Thành Huy'		, N'Nam', '1982-9-21', N'Hà Nam'   , '0926381912', N'Giảng Viên'     ),
	('GV5', N'Thái Thanh Tùng'		, N'Nam', '1972-3-21', N'Hà Nội'   , '0292819381', N'Trưởng Khoa'    ),
	('GV6', N'Nguyễn Thị Quỳnh Như'	, N'Nữ',  '1984-9-21', N'Huế'      , '0908081979', N'Giảng Viên'     ),
	('GV7', N'Nguyễn Đức Tuấn'		, N'Nam', '1984-8-25', N'Hà Nội'   , '0902260781', N'Giảng Viên'     ),
	('GV8', N'Nguyễn Thị Thuý Lan'	, N'Nữ',  '1974-9-12', N'Hà Nội'   , '0989080074', N'Giảng Viên'     ),
	('GV9', N'Trần Tiến Dũng'	    , N'Nam', '1980-7-11', N'Hà Nội'   , '0989080074', N'Giảng Viên'     ),
	('GV10', N'Lương Minh Hạnh'		, N'Nữ',  '1980-6-15', N'Hà Nội'   , '0926381000', N'Giảng Viên'     );
	


INSERT INTO MON 
VALUES

	('SQL'  , N'Hệ quản trị Cơ sở dữ liệu' , 4),
	('CSDL' , N'Cơ sở dữ liệu'             , 4),	
	('MTT'  , N'Mạng truyền thông'         , 3),
	('HDT'  , N'Lập trình hướng đối tượng' , 4),
	('WEB'  , N'Lập trình web cơ bản'      , 4),
	('TA'   , N'Tiếng anh chuyên ngành'	   , 3),
	('MNM'  , N'Mã nguồn mở'              , 3),
	('TT'   , N'Tư tưởng Hồ Chí Minh'	   , 3);
	GO

INSERT INTO LOP(sMalop, iSosv) 
VALUES
	
	('AAST2TSQL21', 30),
	('AACT2LTA22', 31),
	('AAST3DWEB23', 32),
	('AACT3DMNM24', 33),
	('AAST4XCSDL24', 31),
	('AAST5HTT41', 35),
	('AACT5HMTT41', 40),
	('AACT6NHDT42', 80),
	('AACT7TWEB43', 66),
	('AAST6LTA22', 75),
	('AAST7LTA22', 44),
	('AAST6DSQL23', 70);

UPDATE LOP
set iSosv = 31
where sMalop = 'AACT2LTA22';
select*from LOP

INSERT INTO PHONG 
VALUES
	
	('P21', N'Lý thuyết'  ),
	('P22', N'Lý thuyết'  ),
	('P23', N'Lý thuyết'  ),
	('P24', N'Lý thuyết'  ),
	('P31', N'Thực hành'  ),
	('P32', N'Thực hành'  ),
	('P33', N'Thực hành'  ),
	('P41', N'Lý thuyết'  ),
	('P42', N'Lý thuyết'  ),
	('P43', N'Lý thuyết'  ),
	('P51', N'Lý thuyết'  ),
	('P52', N'Lý thuyết'  );

INSERT INTO THOIGIAN(dNgayday,sCaday)
VALUES

--tuần 1
	('2021-9-6',N'Sáng'),
	('2021-9-6',N'Chiều'),
	('2021-9-7',N'Sáng'),
	('2021-9-7',N'Chiều'),
	('2021-9-8',N'Sáng'),
	('2021-9-9',N'Sáng'),
	('2021-9-9',N'Chiều'),
	('2021-9-10',N'Chiều'),
	('2021-9-11',N'Chiều'),
	--TA  côc Lan có 3 lịch dạy trên tuần,LHD có lịch dạy 2 môn khác nhau trên tuần 1
	('2021-9-10',N'Sáng'),
	('2021-9-11',N'Sáng'),

--tuần 2
	('2021-9-13',N'Sáng'),
	('2021-9-13',N'Chiều'),
	('2021-9-14',N'Sáng'),
	('2021-9-14',N'Chiều'),
	('2021-9-15',N'Sáng'),
	('2021-9-16',N'Sáng'),
	('2021-9-16',N'Chiều'),
	('2021-9-17',N'Chiều'),
	('2021-9-18',N'Chiều'),
	--TA  côc Lan có 3 lịch dạy trên tuần,LHD có lịch dạy 2 môn khác nhau trên tuần 2
	('2021-9-17',N'Sáng'),
	('2021-9-18',N'Sáng');

INSERT INTO THOIGIAN(dNgayday,sCaday)
VALUES
	('2021-9-8',N'Chiều'),
	('2021-9-15',N'Chiều');


	INSERT INTO LICHDAY VALUES
--tuần 1
	('2021-9-6',N'Sáng', 'GV1', 'SQL' , 'AAST2TSQL21', 'P21', N'Học', ''),
	('2021-9-6',N'Chiều', 'GV2', 'WEB', 'AAST3DWEB23', 'P23', N'Học' , ''),
	('2021-9-7',N'Sáng', 'GV3', 'CSDL' , 'AAST4XCSDL24', 'P24', N'Học' , ''),
	('2021-9-7',N'Chiều', 'GV4', 'MTT' , 'AACT5HMTT41', 'P41', N'Học' , ''),
	('2021-9-8',N'Sáng', 'GV6', 'HDT' , 'AACT6NHDT42', 'P42', N'Học' , ''),
	('2021-9-9',N'Sáng', 'GV7', 'WEB' , 'AACT7TWEB43', 'P43', N'Học' , ''),
	('2021-9-9',N'Chiều', 'GV8', 'TA' , 'AACT2LTA22', 'P22', N'Học' , ''),
	('2021-9-10',N'Chiều', 'GV9', 'MNM' , 'AACT3DMNM24', 'P24', N'Học' , ''),
	('2021-9-11',N'Chiều', 'GV10', 'TT' , 'AAST5HTT41', 'P41', N'Nghỉ' , ''),

	--TA  côc Lan có 3 lịch dạy trên tuần,LHD có lịch dạy 2 môn khác nhau trên tuần 1
	('2021-9-10',N'Sáng', 'GV8', 'TA' , 'AAST6LTA22', 'P22', N'Học' , ''),
	('2021-9-11',N'Sáng', 'GV8', 'TA' , 'AAST6LTA22', 'P22', N'Học' , ''),
	('2021-9-10',N'Sáng', 'GV2', 'SQL', 'AAST6DSQL23', 'P23', N'Học' , ''),

--tuần 2
	('2021-9-13',N'Sáng', 'GV1', 'SQL' , 'AAST2TSQL21', 'P21', N'Học', N'Tuần 2'),
	('2021-9-13',N'Chiều', 'GV2', 'WEB', 'AAST3DWEB23', 'P23', N'Học' ,  N'Tuần 2'),
	('2021-9-14',N'Sáng', 'GV3', 'CSDL' , 'AAST4XCSDL24', 'P24', N'Học' ,  N'Tuần 2'),
	('2021-9-14',N'Chiều', 'GV4', 'MTT' , 'AACT5HMTT41', 'P41', N'Học' ,  N'Tuần 2'),
	('2021-9-15',N'Sáng', 'GV6', 'HDT' , 'AACT6NHDT42', 'P42', N'Học' ,  N'Tuần 2'),
	('2021-9-16',N'Sáng', 'GV7', 'WEB' , 'AACT7TWEB43', 'P43', N'Học' ,  N'Tuần 2'),
	('2021-9-16',N'Chiều', 'GV8', 'TA' , 'AACT2LTA22', 'P22', N'Học' ,  N'Tuần 2'),
	('2021-9-17',N'Chiều', 'GV9', 'MNM' , 'AACT3DMNM24', 'P24', N'Học' ,  N'Tuần 2'),
	('2021-9-18',N'Chiều', 'GV10', 'TT' , 'AAST5HTT41', 'P41', N'Nghỉ' ,  N'Tuần 2'),

	--TA  côc Lan có 3 lịch dạy trên tuần,LHD có lịch dạy 2 môn khác nhau trên tuần 
	('2021-9-17',N'Sáng', 'GV8', 'TA' , 'AAST6LTA22', 'P22', N'Học' ,  N'Tuần 2'),
	('2021-9-18',N'Sáng', 'GV8', 'TA' , 'AAST6LTA22', 'P22', N'Học' ,  N'Tuần 2'),
	('2021-9-17',N'Sáng', 'GV2', 'SQL', 'AAST6DSQL23', 'P23', N'Học' ,  N'Tuần 2');



	INSERT INTO LICHDAY VALUES
	
	('2021-9-6',N'Sáng', 'GV10', 'SQL' , 'AAST2TSQL21', 'P21', N'Học', ''),
	('2021-9-6',N'Chiều', 'GV9', 'WEB', 'AAST3DWEB23', 'P23', N'Học' , ''),
	('2021-9-7',N'Sáng', 'GV8', 'CSDL' , 'AAST4XCSDL24', 'P24', N'Học' , ''),
	('2021-9-7',N'Chiều', 'GV7', 'MTT' , 'AACT5HMTT41', 'P41', N'Học' , ''),
	('2021-9-8',N'Sáng', 'GV3', 'HDT' , 'AACT6NHDT42', 'P42', N'Học' , ''),
	('2021-9-9',N'Sáng', 'GV5', 'WEB' , 'AACT7TWEB43', 'P43', N'Học' , ''),
	('2021-9-9',N'Chiều', 'GV4', 'TA' , 'AACT2LTA22', 'P22', N'Học' , ''),
	('2021-9-10',N'Chiều', 'GV3', 'MNM' , 'AACT3DMNM24', 'P24', N'Học' , ''),
	('2021-9-11',N'Chiều', 'GV2', 'TT' , 'AAST5HTT41', 'P41', N'Nghỉ' , '');



	INSERT INTO LICHDAY VALUES
	
	('2021-9-6',N'Sáng', 'GV3', 'MNM' , 'AAST2TSQL21', 'P21', N'Học', '')

delete from LICHDAY 
where dNgayday='2021-9-6' 
and sCaday=N'Sáng'
and sMagv='GV3' 
and sMamon='MNM' 
and sMalop='AAST2TSQL21' 
and sMap='P21'

select* from LICHDAY

create Table tbl_user
(
	sMa nvarchar(10) not null,
	dThoigian datetime not null 
)

insert into tbl_user
values ('admin', '2022-04-04')
select*from tbl_user