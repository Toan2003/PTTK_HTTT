USE master
GO
IF DB_ID('PTTK') IS NOT NULL
	DROP DATABASE PTTK
GO --KẾT THÚC KHỐI LỆNH Ở TRÊN
CREATE DATABASE PTTK
GO
USE PTTK 

SET DATEFORMAT dmy; 

CREATE TABLE CHINHANH 
(
    MACN CHAR(5),
    TENCN NVARCHAR(50),
    DIACHI NVARCHAR(100),
    SDT CHAR(10)

    CONSTRAINT PK_CN
    PRIMARY KEY(MACN)
)

INSERT INTO CHINHANH (MACN, TENCN, DIACHI, SDT) VALUES ('CN001', N'CHI NHÁNH A', N'NGUYỄN VĂN CỪ','0123456789')
GO

CREATE TABLE QUIDINH
(
    MAQD CHAR(5),
    PHANLOAI VARCHAR(5),
    NOIDUNG NVARCHAR(50),
    SOSANH NVARCHAR(50),
    MACN CHAR(5)

    CONSTRAINT PK_CD
    PRIMARY KEY(MAQD),
    CONSTRAINT FK_CD_CN
    FOREIGN KEY(MACN)
    REFERENCES CHINHANH(MACN)
)

INSERT INTO QUIDINH (MAQD, PHANLOAI, NOIDUNG, SOSANH, MACN) VALUES ('QD001', 'DV', NULL, NULL, 'CN001')

CREATE TABLE NHANVIEN
(
    MANV CHAR(5),
    HOTEN NVARCHAR(50),
    PHAI NVARCHAR(3),
    NGAYSINH DATE,
    DIACHI NVARCHAR(100),
    MACN CHAR(5),
    VAITRO VARCHAR(10),

    CONSTRAINT PK_NV
    PRIMARY KEY(MANV),
    CONSTRAINT CK_NV_PHAI
    CHECK (PHAI = 'NAM' OR PHAI = N'NỮ'),
    CONSTRAINT FK_NV_CN
    FOREIGN KEY(MACN)
    REFERENCES CHINHANH(MACN)
)

INSERT INTO NHANVIEN(MANV,HOTEN, PHAI,NGAYSINH, DIACHI, MACN, VAITRO) 

VALUES ('NV001',N'NGUYỄN VĂN A', 'NAM','6/5/1990',N'NGUYỄN VĂN CỪ', 'CN001','NVTIEPNHAN')

CREATE TABLE DOANHNGHIEP
(
	MADN CHAR(5),
	TENCTY NVARCHAR(50),
	MASOTHUE CHAR(10),
	DIACHI NVARCHAR(50),
	EMAIL VARCHAR(50),
	SDT CHAR(10),
	NGUOIDAIDIEN NVARCHAR(50),
	USERNAME VARCHAR(20),
	PASSWORD VARCHAR(20),
	TRANGTHAI NVARCHAR(20),

	CONSTRAINT PK_DN
	PRIMARY KEY (MADN)
)

INSERT INTO DOANHNGHIEP(MADN, TENCTY, MASOTHUE, DIACHI, EMAIL, SDT, NGUOIDAIDIEN, USERNAME, PASSWORD, TRANGTHAI)
VALUES ('DN001', N'CÔNG TY ABC', '8899888899', N'NGUYỄN VĂN CỪ', 'ABCCTY@GMAIL.COM','0123456788',N'NGUYỄN VĂN C', 'ABCUSERNAME', '123456', N'ĐÃ DUYỆT');

CREATE TABLE DICHVU
(
	MADV CHAR(5),
	TENDICHVU NVARCHAR(50),
	GIATIEN FLOAT,

	CONSTRAINT PK_DV
	PRIMARY KEY (MADV)
)

INSERT INTO DICHVU(MADV, TENDICHVU, GIATIEN) 
VALUES ('DV001', N'TRANG MẠNG' , 2000)
INSERT INTO DICHVU(MADV, TENDICHVU, GIATIEN)
VALUES ('DV002', N'BANNER QUẢNG CÁO', 3000)
INSERT INTO DICHVU(MADV, TENDICHVU, GIATIEN)
VALUES ('DV003', N'BÁO GIẤY', 1000)

CREATE TABLE PHIEUDANGTUYEN
(
	MAPDT CHAR(6),
	THOIGIANBD DATE,
	VITRIUNGTUYEN NVARCHAR(20),
	THONGTINYEUCAU NVARCHAR(200),
	THOIGIANKT DATE,
	PHEDUYET NVARCHAR(20),
	HINHTHUCTT NVARCHAR(20),
	TRANGTHAITT NVARCHAR(20),
	MADN CHAR(5),
	MADV CHAR(5),

	CONSTRAINT PK_PDT
	PRIMARY KEY (MAPDT),
	CONSTRAINT FK_PDT_DV
	FOREIGN KEY (MADV) REFERENCES DICHVU(MADV),
	
	CONSTRAINT FK_PDT_DN
	FOREIGN KEY (MADN)
	REFERENCES DOANHNGHIEP(MADN)
)


INSERT INTO PHIEUDANGTUYEN (MAPDT, THOIGIANBD, VITRIUNGTUYEN, THONGTINYEUCAU, THOIGIANKT, PHEDUYET, HINHTHUCTT,TRANGTHAITT,MADN,MADV)
VALUES ('PDT001', '1/1/2024', N'KẾ TOÁN', N'TỐT NGHIỆP ĐẠI HỌC', '20/1/2024', N'ĐÃ DUYỆT',NULL,NULL, 'DN001','DV002')

CREATE TABLE BAIDANGTUYEN
(
	MABD CHAR(5),
	NOIDUNG NVARCHAR(2000),
	MAPDT CHAR(6)

	CONSTRAINT PK_BDT
	PRIMARY KEY(MABD),
	CONSTRAINT FK_BDT_PDT FOREIGN KEY (MAPDT) REFERENCES PHIEUDANGTUYEN(MAPDT)
)

INSERT INTO BAIDANGTUYEN(MABD, NOIDUNG, MAPDT) 
VALUES ('BD001', N'CÔNG TY ABC ĐANG TUYỂN NHÂN VIÊN VỊ TRÍ KẾ TOÁN - YÊU CẦU: TỐT NGHIỆP ĐẠI HỌC', 'PDT001')

CREATE TABLE CHINHSACHKHUYENMAI
(
	MACS CHAR(5),
	NOIDUNG NVARCHAR(2000),
	MANV CHAR(5)

	CONSTRAINT PK_CSKM
	PRIMARY KEY (MACS),
	CONSTRAINT FK_CSKM_NV
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)

INSERT INTO CHINHSACHKHUYENMAI(MACS, NOIDUNG, MANV)
VALUES ('CS001', N'GIẢM GIÁ 10%', 'NV001')

CREATE TABLE DANHSACHGIAHANHOPDONG
(
	MADS CHAR(5),
	NGAYLAP DATE,
	MANV CHAR(5),

	CONSTRAINT PK_DSGHHD
	PRIMARY KEY(MADS),
	CONSTRAINT FK_DSGHHD_NV
	FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
)
INSERT INTO DANHSACHGIAHANHOPDONG(MADS, NGAYLAP, MANV)
VALUES ('DS001', '4/4/2024', 'NV001')

CREATE TABLE CHITIETDANHSACH
(
	MADS CHAR(5),
	MADN CHAR(5),
	MACS CHAR(5),

	CONSTRAINT PK_CTDS
	PRIMARY KEY (MADN,MADS),
	CONSTRAINT FK_CTDS_CSKM
	FOREIGN KEY (MACS) REFERENCES CHINHSACHKHUYENMAI(MACS),
	CONSTRAINT FK_CTDS_DN
	FOREIGN KEY (MADN) REFERENCES DOANHNGHIEP,
	CONSTRAINT FK_CTDS_DS
	FOREIGN KEY (MADS) REFERENCES DANHSACHGIAHANHOPDONG
)

INSERT INTO CHITIETDANHSACH(MADS, MADN, MACS)
VALUES ('DS001', 'DN001', 'CS001')

CREATE TABLE UNGVIEN
(
	MAUV CHAR(5),
	HOTEN NVARCHAR(20),
	SDT CHAR(10),
	EMAIL VARCHAR(20),
	DIACHI NVARCHAR(50),

	CONSTRAINT PK_UV
	PRIMARY KEY (MAUV)
)

INSERT INTO UNGVIEN(MAUV, HOTEN, SDT, EMAIL, DIACHI)
VALUES ('UV001', N'TRẦN THỊ D', '0112345678','TRANTHID@GMAIL.COM', N'NGUYỄN VĂN CỪ')

CREATE TABLE HOSOUNGTUYEN
(
	MAHS CHAR(5),
	DOUUTIEN INT,
	TRANGTHAI NVARCHAR(20)

	CONSTRAINT PK_HSUT
	PRIMARY KEY (MAHS)
)
INSERT INTO HOSOUNGTUYEN(MAHS, DOUUTIEN, TRANGTHAI)
VALUES ('HS001', NULL, NULL)

CREATE TABLE CHITIETUNGTUYEN
(
	MAPDT CHAR(6),
	MAUV CHAR(5),
	TRANGTHAIXETDUYET NVARCHAR(20),
	MAHS CHAR(5),

	CONSTRAINT PK_CTUT
	PRIMARY KEY (MAPDT, MAUV),
	CONSTRAINT FK_CTUT_PDT
	FOREIGN KEY (MAPDT) REFERENCES PHIEUDANGTUYEN,
	CONSTRAINT FK_CTUT_UV
	FOREIGN KEY (MAUV) REFERENCES UNGVIEN,
	CONSTRAINT FK_CTUT_HSUT
	FOREIGN KEY (MAHS) REFERENCES HOSOUNGTUYEN(MAHS)
)

INSERT INTO CHITIETUNGTUYEN(MAPDT, MAUV, TRANGTHAIXETDUYET, MAHS)
VALUES ('PDT001', 'UV001', NULL, 'HS001')

CREATE TABLE PHIEUTHU
(
	MAPT CHAR(5),
	NGAYLAP DATE,
	PHUONGANTT NVARCHAR(20),
	MAPDT CHAR(6),
	MANV CHAR(5),

	CONSTRAINT PK_PT
	PRIMARY KEY (MAPT),
	CONSTRAINT FK_PT_PDT
	FOREIGN KEY (MAPDT) REFERENCES PHIEUDANGTUYEN,
	CONSTRAINT FK_PT_NV
	FOREIGN KEY (MANV) REFERENCES NHANVIEN
)

INSERT INTO PHIEUTHU (MAPT, NGAYLAP, PHUONGANTT, MAPDT, MANV)
VALUES ('PT001', '20/12/2023', NULL , 'PDT001', 'NV001')

CREATE TABLE LICHTRAGOP
(
	MALICH CHAR(5),
	NGAYHEN DATE,
	TRANGTHAI NVARCHAR(20),
	MAPDT CHAR(6),
	
	CONSTRAINT PK_LTG
	PRIMARY KEY (MALICH),
	CONSTRAINT FK_LTG_PDT
	FOREIGN KEY(MAPDT) REFERENCES PHIEUDANGTUYEN
)
INSERT INTO LICHTRAGOP (MALICH, NGAYHEN, TRANGTHAI, MAPDT)
VALUES ('TG001','30/12/2023', NULL, 'PDT001')


CREATE TABLE HOADON
(
    MAHD CHAR(5),
    MAPDT CHAR(6),
    TONGTIEN FLOAT,
    HINHTHUCTT CHAR(2),
    NGAYLAP DATE,
    MANV CHAR(5),
    
    CONSTRAINT PK_HD
    PRIMARY KEY(MAHD),
    CONSTRAINT HD_MAPHIEUDK_UNIQUE
    UNIQUE(MAPDT),
    CONSTRAINT FK_HD_PDK
    FOREIGN KEY(MAPDT)
    REFERENCES PHIEUDANGTUYEN,
    CONSTRAINT FK_HD_NV
    FOREIGN KEY(MANV)
    REFERENCES NHANVIEN(MANV)
)

INSERT INTO HOADON(MAHD,MAPDT, TONGTIEN, HINHTHUCTT, NGAYLAP, MANV)
VALUES ('HD001', 'PDT001', 2000, NULL, NULL, 'NV001')
GO
-- INSERT VALUES
---- CHI NHANH
--INSERT INTO VALUES ('CN1', 'Chi nhánh 1', '123 Đường 1', '0123456789')
---- QUI DINH
--INSERT INTO VALUES ('QD001', 'TT', 'Tổng tiền phải từ 100 trở lên mới được trả góp', '100', 'CN1'),
---- NHAN VIEN
--INSERT INTO VALUES ('NV001', 'Nguyễn Văn A', 'NAM', '1999-01-01', '123 Đường 1', 'CN1', 'NV'),
--INSERT INTO VALUES ('NV002', 'Nguyễn Văn B', 'NAM', '1999-01-01', '123 Đường 1', 'CN1', 'NV')

