CREATE DATABASE test;

CREATE TABLE Product
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name VARCHAR(255)
);

CREATE TABLE Category
(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name VARCHAR(255)
);

CREATE TABLE ProductCategory
(
	ProductId INT,
	CategoryId INT,
	FOREIGN KEY(ProductId) REFERENCES Product(Id),
	FOREIGN KEY(CategoryId) REFERENCES Category(Id)
);

INSERT INTO Product(Name)
VALUES
('Product 1'),
('Product 2'),
('Product 3'),
('Product 4'),
('Product 5');

INSERT INTO Category(Name)
VALUES
('Category 1'),
('Category 2'),
('Category 3'),
('Category 4'),
('Category 5');


INSERT INTO ProductCategory(ProductId, CategoryId)
VALUES
(1, 1), (1, 2),
(2, 2), (2, 3), (2, 4),
(3, 1), (3, 3),
(4, 5);

SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN ProductCategory ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category ON Category.Id = ProductCategory.CategoryId