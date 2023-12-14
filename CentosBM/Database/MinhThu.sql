Create FUNCTION dbo.GetProductsByKeyword
(
    @Keyword NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT P.ProductID, ProductName, Description, Price, P.CategoryID, S.SupplierID, Url, C.NameCategory, S.SupplierName, P.QuantityInStock
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
    SELECT P.ProductID, ProductName, Description, Price, P.CategoryID, S.SupplierID, Url, C.NameCategory, S.SupplierName, P.QuantityInStock
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
    SELECT P.ProductID, ProductName, Description, Price, P.CategoryID, S.SupplierID, Url, C.NameCategory, S.SupplierName, P.QuantityInStock
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