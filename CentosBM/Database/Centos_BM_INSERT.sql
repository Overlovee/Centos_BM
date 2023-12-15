use CentosBM
go
INSERT INTO Categories (NameCategory) 
VALUES
	(N'Tôn Hoa Sen'),
	(N'Ống Thép Hoa Sen'),
	(N'Ống Nhựa Hoa Sen'),
	(N'Thép Xây Dựng'),
	(N'Gạch Ốp Lát');

-- Insert data into Suppliers
INSERT INTO Suppliers (SupplierName, Phone) 
VALUES
	(N'Công Ty TNHH Thương Mại Green Tech', '0902213695'),
	(N'Công Ty TNHH Tài Nguyên Đông Sơn', '0756489320'),
	(N'Công Ty TNHH Thương Mại Dịch Vụ Vận Tải Thảo Trang', '0789248651'),
	(N'Công Ty CP Sở Hữu Thiên Tân', '0982314568'),
	(N'Công Ty Cổ Phần SX & TM Nhất Tín', '0915287635');

-- Insert data into Products
INSERT INTO Products (ProductName, Description, Price, CategoryID, SupplierID) 
VALUES
	(N'Tôn lạnh màu đỏ MRL03 0.45mm', N'Ứng dụng công nghệ hàng đầu về sơn phủ trên nền hợp kim nhôm kẽm, có thể sơn hai mặt giống nhau nhằm tăng tính thẩm mỹ, đa dạng về màu sắc, độ bền cao.', 123750, 1, 1),
	(N'Tôn lạnh màu xanh BGL03 0.30mm ', N'Ứng dụng công nghệ hàng đầu về sơn phủ trên nền hợp kim nhôm kẽm, có thể sơn hai mặt giống nhau nhằm tăng tính thẩm mỹ, đa dạng về màu sắc, độ bền cao.', 89650, 1, 2),
	(N'Tôn lạnh màu trắng BWL01 0.5mm', N'Ứng dụng công nghệ hàng đầu về sơn phủ trên nền hợp kim nhôm kẽm, có thể sơn hai mặt giống nhau nhằm tăng tính thẩm mỹ, đa dạng về màu sắc, độ bền cao.', 135299, 1, 4),
	(N'Tôn cách nhiệt PU màu xám MDL01 16mm 0.45mm', N'Ứng dụng công nghệ hàng đầu về sơn phủ trên nền hợp kim nhôm kẽm, có thể sơn hai mặt giống nhau nhằm tăng tính thẩm mỹ, đa dạng về màu sắc, độ bền cao.', 184800, 1, 3),
	(N'Tôn cách nhiệt PU màu đỏ BRL01 16mm 0.50mm', N'Ứng dụng công nghệ hàng đầu về sơn phủ trên nền hợp kim nhôm kẽm, có thể sơn hai mặt giống nhau nhằm tăng tính thẩm mỹ, đa dạng về màu sắc, độ bền cao.', 195800, 1, 2),
	(N'Thép hộp mạ kẽm Z080: 13mmx26mmx6.0m', N'Được sản xuất qua các công đoạn: tẩy rỉ, cán nguội, ủ mềm, mạ kẽm, cắt băng, dán định hình.', 74762, 2, 1),
	(N'Thép hộp mạ kẽm Z120: 30mmx60mmx6.0m', N'Được sản xuất qua các công đoạn: tẩy rỉ, cán nguội, ủ mềm, mạ kẽm, cắt băng, dán định hình.', 303622, 2, 3),
	(N'Thép ống mạ kẽm Z080: 90mmx6.0m', N'Sản phẩm thép ống mạ kẽm trải qua quá trình sản xuất kỹ lưỡng và nghiêm ngặt, đảm bảo chất lượng.', 381928, 2, 2),
	(N'Thép ống mạ kẽm Z080: 60mmx6.0m', N'Sản phẩm thép ống mạ kẽm trải qua quá trình sản xuất kỹ lưỡng và nghiêm ngặt, đảm bảo chất lượng.', 257308, 2, 4),
	(N'Thép ống nhúng kẽm: 75.6mmx6.0m', N'Ống thép mạ kẽm nhúng nóng Hoa Sen là dòng sản phẩm mới được ứng dụng rộng rãi trong nhiều lĩnh vực như: Hệ thống phòng cháy, chữa cháy, hệ thống dẫn khí, giàn giáo, kết cấu xây dựng,... ', 574358, 2, 5),
	(N'Thép ống nhúng kẽm: 26.65mmx6.0m', N'Ống thép mạ kẽm nhúng nóng Hoa Sen là dòng sản phẩm mới được ứng dụng rộng rãi trong nhiều lĩnh vực như: Hệ thống phòng cháy, chữa cháy, hệ thống dẫn khí, giàn giáo, kết cấu xây dựng,... ', 192931, 2, 3),
	(N'Ống nhựa uPVC luồn dây điện: 16mmx1.4mmx2.92m', N'có khả năng chống cháy, cách điện, bảo vệ an toàn cho hệ thống điện dân dụng và công nghiệp, dễ dàng uốn cong và thi công lắp đặt.', 26175, 3, 1),
	(N'Ống nhựa uPVC nong dài 200mmx4.0m', N'được sử dụng rộng rãi trong các lĩnh vực như: cấp thoát nước dân dụng và công cộng, các công trình điện lực, viễn thông, bơm cát,...', 1211760, 3, 3),
	(N'Ống nhựa uPVC gân xoắn luồn dây điện: 20mmx50m', N'Sản phẩm có khả năng chống cháy, cách điện, bảo vệ an toàn cho hệ thống điện dân dụng và công nghiệp.', 297000, 3, 2),
	(N'Ống nhựa uPVC nong trơn 160mmx4.0m', N'được sử dụng rộng rãi trong các lĩnh vực như: cấp thoát nước dân dụng và công cộng, các công trình điện lực, viễn thông, bơm cát,...', 691200, 3, 4),
	(N'Ống nhựa HDPE 63mmx50m', N'ống nhựa HDPE đáp ứng được các yêu cầu cao trong lĩnh vực cấp thoát nước.', 2251800, 3, 5),
	(N'Ống nhựa PPR 1 lớp chỉ đỏ 25mmx4.0m', N'ống nhựa PPR chịu được nhiệt độ của nước lên đến 95oC và được sử dụng dẫn nước sinh hoạt, dẫn nước nóng trong các công trình xây dựng,…', 188784, 3, 4),
	(N'Ống nhựa PPR 2 lớp chỉ đỏ: 25mmx4.0m', N'ống nhựa PPR chịu được nhiệt độ của nước lên đến 95oC và được sử dụng dẫn nước sinh hoạt, dẫn nước nóng trong các công trình xây dựng,…', 238766, 3, 1),
	(N'Thép V đen Đại Việt', N'Có khả năng chống rung động mạnh, chịu được ảnh hưởng xấu của thời tiết.', 345352, 4, 1),
	(N'Thép V kẽm Quang Thắng', N'Bề mặt V nhẵn mịn đồng đều về độ mềm, khả năng chịu lực, chịu uốn cao.', 170075, 4, 4),
	(N'Thép la đen Tín Phát', N'Có khả năng chống rung động mạnh, chịu được ảnh hưởng xấu của thời tiết, kính thước đa dạng phù hợp với nhiều yếu tố khác nhau của công trình.', 47106 , 4, 5),
	(N'Gạch ốp tường granite LUSTRA INEMB0601200056: 600mmx1200mm', N'Sở hữu “3 TỐT”: Chống thấm hút TỐT - chống trầy xước TỐT - chịu lực TỐT.', 391392, 5, 5),
	(N'Gạch lát nền granite LUSTRA INDAL1001000016: 1000mmx1000mm', N'Sở hữu “3 TỐT”: Chống thấm hút TỐT - chống trầy xước TỐT - chịu lực TỐT.', 510840, 5, 1),
	(N'Gạch họa tiết cổ điển Omela OHS3030011 300mmx300mm', N'Công dụng: gạch trang trí ốp lát bếp, nhà tắm, ốp viền', 549990 , 5, 3),
	(N'Gạch bán sứ Omela 1624049G 1600mmx2400mm', N'Công nghệ sản xuất gạch tiên tiến tạo nên những sản phẩm gạch ốp lát dẫn đầu về kỹ thuật và xu hướng thiết kế.', 4537490 , 5, 5);

-- Insert data into Images
INSERT INTO Images (Url, ProductID) VALUES
('Tonlanhmaudo_MR03 0.45mm.jpg', 1),
('Tonlanhmauxanh_BGL03 0.30mm.jpg', 2),
('Tonlanhmautrang_BWL01 0.5mm.jpg', 3),
('ToncachnhienPUmauxam_MDL01_16mm_0.45mm.jpg', 4),
('ToncachnhienPUmaudo_BRL01_16mm_0.50mm.jpg', 5),
('Thephopmakemhoasen_z080_13x26x6.0m.jpg', 6),
('Thephopmakemhoasen_z120_30x60x6.0m.jpg', 7),
('Thepongmakem_z080_90x6.0m.jpg', 8),
('Thepongmakem_z080_60x6.0m.jpg', 9),
('Thepongnhungkem_75.6x6.0m.jpg', 10),
('Thepongnhungkem_26.65x6.0m.jpg', 11),
('OngnhuauPVCluondaydien_16x1.4x2.92m.jpg', 12),
('OngnhuauPVCnongdai_200x4.0m.jpg', 13),
('OngnhuauPVCganxoanluondaydien_20x50m.jpg', 14),
('OngnhuauPVCnongtron_160x4.0m.jpg', 15),
('OngnhuaHDPE_63x50m.jpg', 16),
('OngnhuaPPR1lopchido_25x4.0m.jpg', 17),
('OngnhuaPPR2lopchido_25x4.0m.jpg', 18),
('Thepvdendaiviet.jpg', 19),
('Thepvkemquangthang.jpg', 20),
('Thepladentinphat.jpg', 21),
('Gachlattuong.jpg', 22),
('Gachlatnen.jpg', 23),
('Gachtrangtri.jpg', 24),
('Gachtranhtham.jpg', 25);

-- Insert data into Customer
INSERT INTO Customer (FullName, Address, Phone) 
VALUES
	(N'Vương Kim Huy', N'816 Nguyễn Chí Thanh', '0963482153'),
	(N'Nguyễn Quốc Hoàng', N'123 Lê Trọng Tấn', '0165482365'),
	(N'Nguyễn Minh Sơn', N'107 Dương Đức Hiền', '0759842365'),
	(N'Trương Ngọc Dinh', N'256 Tân Kỳ Tân Quý', '0152845698'),
	(N'Trương Huy Thư', N'13 Cộng Hòa', '0212536498');

-- Insert data into Employees
INSERT INTO Employees (FirstName, LastName, Address, Phone, Position, Salary, empStatus) 
VALUES
	(N'Nguyễn', N'Thanh Hoàng', N'123 Chế Lan Viên', '0985236410', N'Nhân Viên', 5000000, N'Còn Làm Việc'),
	(N'Nguyễn', N'Minh Thư', N'17 Sơn Kì', '0425368192', 'Admin', 6000000, N'Còn Làm Việc'),
	(N'Vương', N'Kim Dinh', N'88 Nguyễn Cửu Đàm', '0325614789', 'Quản Lí', 7000000, N'Còn Làm Việc'),
	(N'Trần', N'Ngọc Huy', N'104 Cách Mạng Tháng 8', '098756231', 'Nhân Viên', 8000000, N'Còn Làm Việc'),
	(N'Trương', N'Ngọc Sơn', N'304/23 Tân Kỳ Tân Quý', '0125436985', 'Quản Lí', 9000000, N'Còn Làm Việc');

EXEC AddOrder
    @OrderDate = '2023-01-01',
    @TotalAmount = 247500,
    @CustomerID = 1,
    @EmployeeID = 1,
    @OrderStatus = N'Chưa thanh toán',
    @ShipmentStatus = N'Chờ giao hàng';
EXEC AddOrder
    @OrderDate = '2023-02-01',
    @TotalAmount = 89650,
    @CustomerID = 2,
    @EmployeeID = 1,
    @OrderStatus = N'Chưa thanh toán',
    @ShipmentStatus = N'Chờ giao hàng';
EXEC AddOrder
    @OrderDate = '2023-03-01',
    @TotalAmount = 405897,
    @CustomerID = 3,
    @EmployeeID = 4,
    @OrderStatus = N'Chưa thanh toán',
    @ShipmentStatus = N'Chờ giao hàng';
EXEC AddOrder
    @OrderDate = '2023-04-01',
    @TotalAmount = 369600,
    @CustomerID = 4,
    @EmployeeID = 4,
    @OrderStatus = N'Chưa thanh toán',
    @ShipmentStatus = N'Chờ giao hàng';
EXEC AddOrder
    @OrderDate = '2023-05-01',
    @TotalAmount = 195800,
    @CustomerID = 5,
    @EmployeeID = 4,
    @OrderStatus = N'Chưa thanh toán',
    @ShipmentStatus = N'Chờ giao hàng';
-- Insert data into Roles
INSERT INTO Roles (Name) 
VALUES
	(N'Admin'),
	(N'Quản Lí'),
	(N'Nhân Viên');

-- Insert data into Accounts
INSERT INTO Accounts (Username, Password, EmployeeID, RoleID) 
VALUES
	('Hoang13', 'hoangnguyen', 1, 3),
	('Minhthu25', 'minhthu2003', 2, 1),
	('Kimdinh30', 'kimdinh0702', 3, 2),
	('Ngochuy3010', 'huyngu36', 4, 3),
	('Ngocson2711', 'sontruong1', 5, 2);

-- Insert data into Order_Detail
INSERT INTO Order_Detail (OrderID, ProductID, Quantity, Price) 
VALUES
	('Order1', 1, 2, 123750),
	('Order2', 2, 1, 89650),
	('Order3', 3, 3, 135299),
	('Order4', 4, 2, 184800),
	('Order5', 5, 1, 195800);

-- Insert data into Permissions
INSERT INTO Permissions (Name) 
VALUES
	(N'Thêm'),
	(N'Xóa'),
	(N'Sửa');

-- Insert data into Permission_Detail
INSERT INTO Permission_Detail (RoleID, PermissionID) 
VALUES
	(1, 1),
	(1, 2),
	(1, 3),
	(2, 1),
	(2, 3),
	(3, 1);
