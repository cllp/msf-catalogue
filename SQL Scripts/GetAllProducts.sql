SELECT Pr.ProductId, Pr.ProductName, Pf.ProductFile
FROM Product AS Pr, ProductFiles AS Pf
WHERE Pr.ProductId = Pf.ProductFile