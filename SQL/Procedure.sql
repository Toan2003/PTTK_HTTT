--DATABASE NHOM
USE PTTK
--PROCEDURE TAO DN MOI
GO
CREATE PROCEDURE ThemDoanhNghiep
	@tencty NVARCHAR(50),
	@mst CHAR(10),
	@diachi NVARCHAR(50),
	@email VARCHAR(50),
	@sdt CHAR(10),
	@nguoidaidien NVARCHAR(50),
	@username VARCHAR(20),
	@password VARCHAR(20),
	@trangthai NVARCHAR(20)
AS
BEGIN
	DECLARE @NextID INT = NEXT VALUE FOR SEQ_MADN;
	DECLARE @MADN CHAR(5) = CONCAT('DN', FORMAT(@NextID, '000'));

	BEGIN TRANSACTION;
		INSERT INTO DOANHNGHIEP(MADN, TENCTY, MASOTHUE, DIACHI, EMAIL, SDT, NGUOIDAIDIEN, USERNAME, PASSWORD, TRANGTHAI)
		VALUES (@MADN, @tencty, @mst, @diachi, @email, @sdt, @nguoidaidien, @username, @password, @trangthai)
	COMMIT TRANSACTION;
END

SELECT * FROM DOANHNGHIEP