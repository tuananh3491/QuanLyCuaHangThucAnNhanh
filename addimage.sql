UPDATE San_pham
SET Hinh_anh = 
    (SELECT  BulkColumn FROM OPENROWSET(BULK  N'D:\source\repos\test\WindowsFormsApp1\Resources\Cocacola.jpg', SINGLE_BLOB) AS x)
WHERE Ma_SP = N'100000002'