SELECT ProductName, CategoryName 
	FROM Products
	LEFT JOIN ProductCategories ON Products.Id = ProductCategories.ProductId
    LEFT JOIN Category ON Category.Id = ProductCategories.CategoryId