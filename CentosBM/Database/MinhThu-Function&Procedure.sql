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


Create PROCEDURE AddOrder
    @OrderDate DATE,
    @TotalAmount DECIMAL(18, 2),
    @CustomerID INT,
    @EmployeeID INT,
	@OrderStatus NVARCHAR(100),
	@ShipmentStatus NVARCHAR(100)
AS
BEGIN
    DECLARE @CustomerName NVARCHAR(255);
    DECLARE @CustomerAddress NVARCHAR(255);
    DECLARE @CustomerPhoneNumber NVARCHAR(11);
	DECLARE @OrderID VARCHAR(10);

    SELECT @CustomerName = FullName, @CustomerPhoneNumber = Phone, @CustomerAddress = Address
    FROM Customer
    WHERE CustomerID = @CustomerID;

    INSERT INTO Orders (OrderDate, TotalAmount, CustomerID, EmployeeID, CustomerName, CustomerPhoneNumber)
    VALUES (@OrderDate, @TotalAmount, @CustomerID, @EmployeeID, @CustomerName, @CustomerPhoneNumber);
	
	SELECT @OrderID = OrderID
    FROM Orders
    WHERE ID = SCOPE_IDENTITY();

    IF (@OrderStatus IS NOT NULL Or @OrderStatus Not like N'')
		BEGIN
			UPDATE Orders
			SET
				OrderStatus = COALESCE(@OrderStatus, OrderStatus)
			WHERE OrderID = @OrderID;
		END

	IF(@ShipmentStatus IS NOT NULL Or @OrderStatus Not like N'')
		BEGIN
			UPDATE Orders
			SET
				ShipmentStatus = COALESCE(@ShipmentStatus, ShipmentStatus)
			WHERE OrderID = @OrderID;
		END
END;

EXEC AddOrder
    @OrderDate = '2023-12-14',
    @TotalAmount = 150.99,
    @CustomerID = 1,
    @EmployeeID = 1,
    @OrderStatus = N'Đã thanh toán',
    @ShipmentStatus = N'Đã giao hàng';

Create PROCEDURE AddOrderForRetailCustomer
    @OrderDate DATE,
    @TotalAmount DECIMAL(18, 2),
    @EmployeeID INT,
	@CustomerName NVARCHAR(255),
    @CustomerPhoneNumber NVARCHAR(11),
	@CustomerAddress NVARCHAR(255),
	@OrderStatus NVARCHAR(100),
	@ShipmentStatus NVARCHAR(100)
AS
BEGIN
	DECLARE @OrderID VARCHAR(10);

    INSERT INTO Orders (OrderDate, TotalAmount, EmployeeID, CustomerName, CustomerPhoneNumber, CustomerAddress)
    VALUES (@OrderDate, @TotalAmount, @EmployeeID, @CustomerName, @CustomerPhoneNumber, @CustomerAddress);
	
	SELECT @OrderID = OrderID
    FROM Orders
    WHERE ID = SCOPE_IDENTITY();

	IF (@OrderStatus IS NOT NULL Or @OrderStatus Not like N'')
		BEGIN
			UPDATE Orders
			SET
				OrderStatus = COALESCE(@OrderStatus, OrderStatus)
			WHERE OrderID = @OrderID;
		END

	IF(@ShipmentStatus IS NOT NULL Or @OrderStatus Not like N'')
		BEGIN
			UPDATE Orders
			SET
				ShipmentStatus = COALESCE(@ShipmentStatus, ShipmentStatus)
			WHERE OrderID = @OrderID;
		END
END;

EXEC AddOrderForRetailCustomer
    @OrderDate = '2023-12-15',
    @TotalAmount = 99.99,
    @EmployeeID = 2,
    @CustomerName = N'Minh Thư',
    @CustomerPhoneNumber = '091231234',
    @CustomerAddress = N'Hcm',
    @OrderStatus = N'Đã thanh toán',
    @ShipmentStatus = N'Đã giao hàng';


CREATE FUNCTION GetLastInsertedOrderID()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @LastOrderID VARCHAR(10);

    -- Lấy OrderID của đơn đặt hàng mới nhất
    SELECT TOP 1 @LastOrderID = OrderID
    FROM Orders
    ORDER BY ID DESC;

    RETURN @LastOrderID;
END;
Select dbo.GetLastInsertedOrderID();

CREATE PROCEDURE AddOrderDetail
    @OrderID VARCHAR(10),
    @ProductID INT,
    @Quantity INT,
    @Price DECIMAL(18, 2)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Orders WHERE OrderID = @OrderID)
    BEGIN
        IF EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
        BEGIN
            INSERT INTO Order_Detail (OrderID, ProductID, Quantity, Price)
            VALUES (@OrderID, @ProductID, @Quantity, @Price);

        END
    END
END;
EXEC AddOrderDetail
    @OrderID = 'ABC123',
    @ProductID = 1,
    @Quantity = 5,
    @Price = 29.99;

--
CREATE PROCEDURE AddCustomer
    @FullName NVARCHAR(255),
    @Address NVARCHAR(255),
    @Phone NVARCHAR(20)
AS
BEGIN
    INSERT INTO Customer (FullName, Address, Phone)
    VALUES (@FullName, @Address, @Phone);
END;

EXEC AddCustomer
    @FullName = N'Tên Khách Hàng',
    @Address = N'Địa chỉ khách hàng',
    @Phone = N'Số điện thoại khách hàng';


CREATE FUNCTION GetLastInsertedCustomerID()
RETURNS INT
AS
BEGIN
    DECLARE @LastCustomerID INT;

    SELECT TOP 1 @LastCustomerID = CustomerID
    FROM Customer
    ORDER BY CustomerID DESC;

    RETURN @LastCustomerID;
END;
Select dbo.GetLastInsertedCustomerID();


Select *
from Orders O 
where (O.OrderStatus like N'Chưa thanh toán' Or O.ShipmentStatus like N'Chưa thanh toán')
And (O.CustomerName like N'%Nguyễn%' Or O.CustomerPhoneNumber like N'%Nguyễn%')