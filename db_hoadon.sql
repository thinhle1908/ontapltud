﻿
CREATE DATABASE QLHD_DE1
GO
USE QLHD_DE1
GO
-- TAO BANG

CREATE TABLE KHACHHANG(MAKH CHAR(10) NOT NULL,TENKHANG NVARCHAR(30),NGAYSINH DATE, SODT CHAR(12), DIACHI NVARCHAR(30))
GO
CREATE TABLE HOADON(MAHD CHAR(10) NOT NULL, NGAYLAP DATE, SOLUONG INT, DONGIA FLOAT,Thanhtien float, MAKHANG CHAR(10))

GO
ALTER TABLE KHACHHANG 
ADD CONSTRAINT PK_kh PRIMARY KEY (MAKH)
GO
ALTER TABLE HOADON 
ADD CONSTRAINT PK_HD PRIMARY KEY (MAHD)
GO
ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_KH FOREIGN KEY (MAKHANG) REFERENCES KHACHHANG(MAKH)
go 
insert into KHACHHANG
values('kh001', N'Hang', '1/1/2000', '123456',N'123 vo van ngan')
go
insert into KHACHHANG
values('kh002', N'Lan', '1/1/2001', '123456',N'123 Dang van Bi')
go
insert into KHACHHANG
values('kh003', N'Diep', '2/2/1999', '1234987',N'33 Le Loi')

insert into HOADON
values ('HD001', '10/10/2023', 20, 20, 400, 'kh001')
--TAO STORE CHO CAC BANG 

--SP THÊM HÓA ĐƠN
CREATE PROC SP_THEMHOADON(
	@MAHD CHAR(10) , 
	@NGAYLAP DATE, 
	@SOLUONG INT, 
	@DONGIA FLOAT,
	@Thanhtien float, 
	@MAKHANG CHAR(10)
)
AS
INSERT INTO HOADON(MAHD,NGAYLAP,SOLUONG,DONGIA,ThanhTien,MAKHANG) VALUES(@MAHD, @NGAYLAP,@SOLUONG,@DONGIA,@ThanhTien,@MAKHANG)
GO

--SP XÓA HÓA ĐƠN
CREATE PROC SP_XOAHOADON(
	@MAHD CHAR(10)
)
AS
DELETE FROM HOADON
WHERE HOADON.MAHD = @MAHD
GO
-- SP SỬA HÓA ĐƠN

CREATE PROC SP_SUAHOADON(
	@MAHD CHAR(10) , 
	@NGAYLAP DATE, 
	@SOLUONG INT, 
	@DONGIA FLOAT,
	@Thanhtien float, 
	@MAKHANG CHAR(10)
)
AS 
UPDATE HOADON
SET NGAYLAP = @NGAYLAP , SOLUONG = @SOLUONG , DONGIA = @DONGIA , Thanhtien = @Thanhtien , MAKHANG = @MAKHANG
WHERE MAHD = @MAHD
GO

--SP TÌM HÓA ĐƠN THEO MÃ HÓA ĐƠN
CREATE PROC SP_TIMKIEMMAHD(
	@MAHD CHAR(10)
)
AS
SELECT * FROM HOADON
WHERE MAHD LIKE '%' + @MAHD + '%'
GO

--SP TÌM HÓA ĐƠN THEO MÃ KHÁCH HÀNG
CREATE PROC SP_TIMKIEMMAKHANG(
	@MAKHANG CHAR(10)
)
AS
SELECT * FROM HOADON
WHERE MAKHANG LIKE '%' + @MAKHANG + '%'
GO

--SP LẤY TẤT CẢ HÓA ĐƠN
CREATE PROC SP_LAYDSHOADON
AS 
SELECT * FROM HOADON
GO

--SP LẤY TẤT CẢ KHÁCH HÀNG

CREATE PROC SP_LAYDSKHACHHANG
AS
SELECT * FROM KHACHHANG
GO

