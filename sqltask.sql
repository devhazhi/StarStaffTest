SELECT DISTINCT cb.Name 
FROM 
ProductBuys pb  
INNER JOIN Customers c 
ON c.CustomerId == pb.CustomerId AND pb.ProductName="молоко" 
WHERE
c.CustomerId = 
	(SELECT TOP 1 pbuy.CustomerId 
		FROM ProductBuys pbuy 
		WHERE pbuy.ProductName = "сметана" AND pbuy.PurchaiseDatetime > DATEADD(month, -1, getutcdate())
	)
	