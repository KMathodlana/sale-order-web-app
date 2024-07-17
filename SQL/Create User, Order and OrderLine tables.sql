CREATE TABLE [Order] (
	OrderId INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    OrderNumber VARCHAR(10) NOT NULL,
	OrderType TINYINT NOT NULL,
	OrderStatus TINYINT NOT NULL,
	CustomerName VARCHAR(50) NOT NULL,
	CreatedDateTimeUtc DATETIME NOT NULL,
	CONSTRAINT AK_OrderNumber UNIQUE (OrderNumber),
	INDEX UQ_Order_UniqueOrder NONCLUSTERED (OrderId ASC, CreatedDateTimeUtc DESC, OrderNumber)
);

GO

CREATE TABLE [OrderLine] (
	OrderId INT NOT NULL,
	OrderLineId INT NOT NULL,
	ProductCode VARCHAR(10) NOT NULL,
	ProductType TINYINT NOT NULL,
	ProductPrice DECIMAL(10,2) NOT NULL,
	ProductSalePrice DECIMAL(10,2) NOT NULL,
	Quantity INT NOT NULL,
	CONSTRAINT FK_OrderLine_OrderId FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
	INDEX UQ_OrderLine_Order_OrderLine UNIQUE NONCLUSTERED (OrderId, OrderLineId)
);

GO 

INSERT 
INTO 
	[Order] (OrderNumber, OrderType, OrderStatus, CustomerName, CreatedDateTimeUtc)
VALUES
	('SO625144', 0, 0, 'KFC', '2018-03-08 13:52:21'),
	('SO625145', 0, 0, 'Nandos', '2018-03-09 08:56:21')

GO


DECLARE @OrderId AS INT = (SELECT OrderId FROM [Order] WHERE CustomerName = 'KFC')

INSERT 
INTO 
	[OrderLine] (OrderId, OrderLineId, ProductCode, ProductType, ProductPrice, ProductSalePrice, Quantity)
VALUES
	(@OrderId, 1, 'GSX837420', 1, 13.54, 84.49, 10),
	(@OrderId, 2, 'AVF697420', 0, 19.34, 105.99, 25)

GO

DECLARE @OrderId AS INT = (SELECT OrderId FROM [Order] WHERE CustomerName = 'Nandos')

INSERT 
INTO 
	[OrderLine] (OrderId, OrderLineId, ProductCode, ProductType, ProductPrice, ProductSalePrice, Quantity)
VALUES
	(@OrderId, 1, 'YTS786663', 1, 8.44, 49.22, 2),
	(@OrderId, 2, 'UYT485911', 2, 41.57, 250.45, 12),
	(@OrderId, 3, 'PLO879996', 0, 21.57, 65.45, 8)

GO