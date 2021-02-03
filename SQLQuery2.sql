--Select
--Select ContactName Adı, CompanyName Şirket, City Şehir from Customers

--Select * from Customers Where City='London'

--Select * from Customers Where Customers.ContactName like '_a%'

--Select * from Products  where CategoryID=1

--Select * from Products where CategoryID=3 or UnitPrice>=10

--Select * from Products Where categoryId=1 Order By UnitPrice desc

--Select Count(*) as ToplamKayıt from Products

--Select CategoryId,count(*) as KategoriKayıtSayısı from Products 
--Where UNitPrice>20 group by CategoryId having count(*)<10
--Select Products.ProductId, Products.ProductName, Products.UnitPrice, Categories.CategoryName
--from Products inner join Categories on Products.CategoryID=Categories.CategoryID


--Select * from Products p left join [Order Details] od on p.ProductID=od.ProductID

Select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null



 