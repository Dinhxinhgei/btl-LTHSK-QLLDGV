CREATE DATABASE BTL01

go
USE BTL01
go

select*from LICHDAY;

CREATE TABLE GIANGVIEN
(
	sMagv nvarchar(10) not null,
	sTengv nvarchar(25) not null,
	sGioitinh nvarchar(10),
	dNgaysinh date,
	sDiachi nvarchar(25),
	sSdt nvarchar(10),
	sChucvu nvarchar(20),
	CONSTRAINT pk_GV PRIMARY KEY(sMaGV),
	CONSTRAINT ck_Gioitinh CHECK (sGioitinh = N'Nam' OR sGioitinh = N'Nữ')
);

CREATE TABLE MON
(
	sMamon nvarchar(10) not null,
	sTenmon nvarchar(25) not null,
	iSotin int,
	CONSTRAINT pk_MON PRIMARY KEY(sMamon),
	CONSTRAINT ck_Sotin CHECK(iSotin > = 0)
);
GO
CREATE TABLE LOP
(
	sMalop nvarchar(20) not null,
	iSosv int,
	CONSTRAINT pk_LOP PRIMARY KEY(sMalop),
	CONSTRAINT ck_Sosv check(iSoSv > 0 or iSosv is null)
);

CREATE TABLE PHONG
(
	sMap nvarchar(10) not null,
	sChucnang nvarchar(25),
	CONSTRAINT pk_PHONG PRIMARY KEY (sMap)
);

CREATE TABLE THOIGIAN
(
	dNgayday date not null ,
	sCaday nvarchar(12) not null,
	sGhichu nvarchar(50),
	CONSTRAINT pk_THOIGIAN PRIMARY KEY(dNgayday, sCaday)
)

CREATE TABLE LICHDAY
(
	dNgayday date not null,
	sCaday nvarchar(12) not null,
	sMagv nvarchar(10) not null,
	sMamon nvarchar(10) not null,
	sMalop nvarchar(20) not null,
	sMap nvarchar(10) not null,
	sTrangthai nvarchar(10),
	sGhichu nvarchar(50),
	CONSTRAINT pk_LICHDAY PRIMARY KEY(dNgayday, sMagv, sMamon, sMalop, sMap),
	CONSTRAINT ck_Trangthai CHECK (sTrangthai = N'Nghỉ' or sTrangthai = N'Học'),
	CONSTRAINT fk_LICHDAY_THOIGIAN FOREIGN KEY (dNgayday, sCaday) REFERENCES THOIGIAN(dNgayday, sCaday),
	CONSTRAINT fk_LICHDAY_GIANGVIEN FOREIGN KEY (sMagv) REFERENCES GIANGVIEN(sMagv),
	CONSTRAINT fk_LICHDAY_MON FOREIGN KEY (sMamon) REFERENCES MON(sMamon),
	CONSTRAINT fk_LICHDAY_LOP FOREIGN KEY (sMalop) REFERENCES LOP(sMalop),
	CONSTRAINT fk_LICHDAY_PHONG FOREIGN KEY (sMap) REFERENCES PHONG(sMap)
);

--delete from LICHDAY;