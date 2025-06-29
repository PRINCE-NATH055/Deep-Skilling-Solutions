CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);


INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'iPhone 14', 'Electronics', 999.99),
(2, 'Samsung Galaxy S22', 'Electronics', 899.99),
(3, 'Google Pixel 7', 'Electronics', 899.99),
(4, 'Sony Headphones', 'Electronics', 199.99),
(5, 'Dell XPS 13', 'Computers', 1199.99),
(6, 'MacBook Air', 'Computers', 1199.99),
(7, 'Lenovo ThinkPad', 'Computers', 1099.99),
(8, 'Asus Zenbook', 'Computers', 999.99),
(9, 'Office Chair', 'Furniture', 149.99),
(10, 'Gaming Chair', 'Furniture', 299.99),
(11, 'Standing Desk', 'Furniture', 399.99);


SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
FROM Products;


-- Step-1 - Use ROW_NUMBER() to assign a unique rank within each category

SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (
        PARTITION BY Category 
        ORDER BY Price DESC
    ) AS RowNum
FROM Products;

-- Step-2 - Use RANK() and DENSE_RANK() to compare how ties are handled

SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (
        PARTITION BY Category 
        ORDER BY Price DESC
    ) AS RankNum,
    DENSE_RANK() OVER (
        PARTITION BY Category 
        ORDER BY Price DESC
    ) AS DenseRankNum
FROM Products;

-- Step-3 - Use PARTITION BY Category and ORDER BY Price DESC(Using RowNum)

WITH RankedProducts AS (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (
            PARTITION BY Category 
            ORDER BY Price DESC
        ) AS RowNum
    FROM Products
)
SELECT *
FROM RankedProducts
WHERE RowNum <= 3;






