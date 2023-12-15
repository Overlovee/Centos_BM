Create database CentosBM
use CentosBM
go
-- Tạo bảng Categories
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1),
    NameCategory NVARCHAR(255) NOT NULL
	CONSTRAINT PK_Categories PRIMARY KEY (CategoryID)
);

-- Tạo bảng Suppliers
CREATE TABLE Suppliers (
    SupplierID INT IDENTITY(1,1),
    SupplierName NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(20),
	CONSTRAINT PK_Suppliers PRIMARY KEY (SupplierID)

);

-- Tạo bảng Products
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    Price DECIMAL(18, 2) NOT NULL,
    CategoryID INT,
    SupplierID INT,
    QuantityInStock INT Default 0,
    isDiscontinued bit Default 1,
    Unit NVARCHAR(50) Default N'Cái',
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
);

-- Tạo bảng Images
CREATE TABLE Images (
    Image_ID INT IDENTITY(1,1),
    Url NVARCHAR(MAX),
	ProductID INT,
	CONSTRAINT PK_Images PRIMARY KEY (Image_ID),
	CONSTRAINT FK_Images_ProductID FOREIGN KEY (ProductID) REFERENCES Products(ProductID)

);
-- Tạo bảng Customer
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1),
    FullName NVARCHAR(255) NOT NULL,
    Address NVARCHAR(255),
    Phone NVARCHAR(20),
	CONSTRAINT PK_Customer PRIMARY KEY (CustomerID)
);

-- Tạo bảng Employees
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1),
    FirstName NVARCHAR(255) NOT NULL,
    LastName NVARCHAR(255) NOT NULL,
    Address NVARCHAR(255),
    Phone NVARCHAR(20),
    Position NVARCHAR(255),
    Salary DECIMAL(18, 2),
	empStatus nvarchar(50),
	CONSTRAINT PK_Employees PRIMARY KEY (EmployeeID)

);
-- Tạo bảng Orders
CREATE TABLE Orders (
	ID INT IDENTITY(1,1) NOT NULL,
	OrderID AS CAST((LEFT('Order' + RIGHT(CAST(ID AS VARCHAR(5)), 3),15)) AS VARCHAR(10)) PERSISTED NOT NULL,
    OrderDate DATE,
    TotalAmount DECIMAL(18, 2),
    CustomerID INT,
    EmployeeID INT,
	CustomerName NVARCHAR(255) NULL,
    CustomerPhoneNumber NVARCHAR(11),
	CustomerAddress NVARCHAR(255) Default N'Không',
	OrderStatus NVARCHAR(100) Default N'Chưa thanh toán',
	ShipmentStatus NVARCHAR(100) Default N'Chờ giao hàng',
	CONSTRAINT PK_Orders PRIMARY KEY (OrderID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Tạo bảng Roles
CREATE TABLE Roles (
    RoleID INT  IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL
);

-- Tạo bảng Accounts
CREATE TABLE Accounts (
    AccountID INT  IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    EmployeeID INT,
    RoleID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- Tạo bảng Order_Detail 
CREATE TABLE Order_Detail (
    OrderID VARCHAR(10),
    ProductID INT,
    Quantity INT,
    Price DECIMAL(18, 2),
    PRIMARY KEY (OrderID, ProductID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Tạo bảng Permissions
CREATE TABLE Permissions (
    PermissionID INT  IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL
);
-- Tạo bảng Permission_Detail
CREATE TABLE Permission_Detail (
    RoleID INT,
    PermissionID INT,
    PRIMARY KEY (RoleID, PermissionID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID),
    FOREIGN KEY (PermissionID) REFERENCES Permissions(PermissionID)
);
