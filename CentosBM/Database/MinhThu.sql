use CentosBM
go

Create FUNCTION dbo.GetProductsByKeyword
(
    @Keyword NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT P.ProductID, ProductName, Description, Price, P.CategoryID, S.SupplierID, Url, C.NameCategory, S.SupplierName, P.QuantityInStock, P.Unit
    FROM Products P
    JOIN Images I ON P.ProductID = I.ProductID
    JOIN Categories C ON P.CategoryID = C.CategoryID
    JOIN Suppliers S ON P.SupplierID = S.SupplierID
    WHERE 
		(ProductName LIKE N'%' + @Keyword + '%'
       OR C.NameCategory LIKE N'%' + @Keyword + '%'
       OR S.SupplierName LIKE N'%' + @Keyword + '%')
	   And P.isDiscontinued = 1
);

SELECT * 
FROM dbo.GetProductsByKeyword(N'Tôn')
ORDER BY CategoryID ASC;


Create FUNCTION dbo.SearchProductsByPriceRange
(
	@CategoryKeyword NVARCHAR(100),
    @MinPrice DECIMAL(18, 2),
    @MaxPrice DECIMAL(18, 2)
)
RETURNS TABLE
AS
RETURN
(
    SELECT P.ProductID, ProductName, Description, Price, P.CategoryID, S.SupplierID, Url, C.NameCategory, S.SupplierName, P.QuantityInStock, P.Unit
    FROM Products P
    JOIN Images I ON P.ProductID = I.ProductID
    JOIN Categories C ON P.CategoryID = C.CategoryID
    JOIN Suppliers S ON P.SupplierID = S.SupplierID
    WHERE C.NameCategory like N'%' + @CategoryKeyword + '%' And
	(Price BETWEEN @MinPrice AND @MaxPrice)
	And P.isDiscontinued = 1
);

SELECT * 
FROM dbo.SearchProductsByPriceRange(N'Tôn Hoa Sen', 0, 200000)
ORDER BY Price DESC;

Create FUNCTION dbo.SearchProducts
(
    @CategoryKeyword NVARCHAR(100),
    @ProductKeyword NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT P.ProductID, ProductName, Description, Price, P.CategoryID, S.SupplierID, Url, C.NameCategory, S.SupplierName, P.QuantityInStock, P.Unit
    FROM Products P
    JOIN Images I ON P.ProductID = I.ProductID
    JOIN Categories C ON P.CategoryID = C.CategoryID
    JOIN Suppliers S ON P.SupplierID = S.SupplierID
    WHERE C.NameCategory LIKE N'%' + @CategoryKeyword + '%'
      AND (ProductName LIKE N'%' + @ProductKeyword + '%'
           OR C.NameCategory LIKE N'%' + @ProductKeyword + '%'
           OR S.SupplierName LIKE N'%' + @ProductKeyword + '%')
		   And P.isDiscontinued = 1
);

SELECT * 
FROM dbo.SearchProducts(N'Tôn Hoa Sen', N'Tôn lạnh')
ORDER BY Price DESC;



Create PROCEDURE UpdateProduct
    @ProductID INT,
    @ProductName NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @Price DECIMAL(18, 2),
    @CategoryID INT,
    @SupplierID INT,
    @QuantityInStock INT,
    @Unit NVARCHAR(50),
	@Url NVARCHAR(MAX)
AS
BEGIN
    UPDATE Products
    SET
        ProductName = ISNULL(@ProductName, ProductName),
        Description = ISNULL(@Description, Description),
        Price = ISNULL(@Price, Price),
        QuantityInStock = ISNULL(@QuantityInStock, QuantityInStock),
        CategoryID = ISNULL(@CategoryID, CategoryID),
        Unit = ISNULL(@Unit, Unit),
        SupplierID = ISNULL(@SupplierID, SupplierID)
    WHERE ProductID = @ProductID;

	Update Images
	Set Url = @Url
	Where ProductID = @ProductID;
END;

EXEC UpdateProduct
    @ProductID = 1,
    @ProductName = N'Tôn lạnh màu đỏ MRL03 0.45mm',
    @Description = N'Ứng dụng công nghệ hàng đầu về sơn phủ trên nền hợp kim nhôm kẽm, có thể sơn hai mặt giống nhau nhằm tăng tính thẩm mỹ, đa dạng về màu sắc, độ bền cao.',
    @Price = 123750.00,
    @CategoryID = 1,
    @SupplierID = 2,
    @QuantityInStock = 12,
    @Unit = N'Cái',
	@Url = N'Tonlanhmaudo_MR03 0.45mm.jpg';


CREATE PROCEDURE UpdateDiscontinuedStatus
    @ProductID INT,
    @isDiscontinued BIT
AS
BEGIN
    UPDATE Products
    SET isDiscontinued = @isDiscontinued
    WHERE ProductID = @ProductID;
END;

EXEC UpdateDiscontinuedStatus @ProductID = 1, @isDiscontinued = 0;

--
CREATE PROCEDURE InsertProduct
    @ProductName NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @Price DECIMAL(18, 2),
    @QuantityInStock Int,
    @Unit Nvarchar(50),
    @Url NVARCHAR(MAX),
    @CategoryID INT,
    @SupplierID INT
AS
BEGIN
    INSERT INTO Products (ProductName, Description, Price, CategoryID, SupplierID, QuantityInStock, Unit)
    VALUES (@ProductName, @Description, @Price, @CategoryID, @SupplierID, @QuantityInStock, @Unit);
	
	DECLARE @ProductID INT;
	SET @ProductID = dbo.FindLastInsertedProductID();

    INSERT INTO Images (Url, ProductID)
    VALUES (@Url, @ProductID);
END;

EXEC InsertProduct
    @ProductName = N'Tên Sản Phẩm',
    @Description = N'Mô tả sản phẩm',
    @Price = 99.99,
    @QuantityInStock = 1312,
    @Unit = N'Cái',
    @Url = N'img.png',
    @CategoryID = 1,
    @SupplierID = 2;

CREATE FUNCTION dbo.FindLastInsertedProductID()
RETURNS INT
AS
BEGIN
    DECLARE @ProductID INT;

    SELECT TOP 1 @ProductID = ProductID
    FROM Products
    ORDER BY ProductID DESC;

    RETURN @ProductID;
END;

SELECT dbo.FindLastInsertedProductID();