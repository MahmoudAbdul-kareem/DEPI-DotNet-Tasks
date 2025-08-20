use StoreDB;

-- 1. Count the total number of products in the database.
select count(*) 
from production.products

-- 2. Find the average, minimum, and maximum price of all products.
select 
	avg(list_price) as Average,
	min(list_price) as Minimum,
	max(list_price) as maximum
from production.products;

-- 3. Count how many products are in each category.
select c.category_name, count(*) as category_count
from production.products  p
inner join production.categories c on p.category_id = c.category_id
group by c.category_id, c.category_name;

-- 4. Find the total number of orders for each store.
select s.store_name, count(*) as order_count
from sales.orders o join sales.stores s 
on o.store_id = s.store_id
group by s.store_id, s.store_name;

-- 5. Show customer first names in UPPERCASE and last names in lowercase for the first 10 customers.
select top 10 upper(first_name) FNAME, lower(last_name) lname
from sales.customers;

-- 6. Get the length of each product name. Show product name and its length for the first 10 products.
select top 10 product_name, len(product_name) as 'length'
from production.products;

-- 7. Format customer phone numbers to show only the area code (first 3 digits) for customers 1-15.
select top 15 left(phone, 3) as area_code
from sales.customers;

-- 8. Show the current date and extract the year and month from order dates for orders 1-10.
select top 10 
	getdate() as 'current_date', 
	year(order_date) as order_year, 
	month(order_date) as order_month
from sales.orders;

-- 9. Join products with their categories. Show product name and category name for first 10 products.
select top 10 
	p.product_name,
	c.category_name
from production.products p join production.categories c
on c.category_id = p.category_id;

-- 10. Join customers with their orders. Show customer name and order date for first 10 orders.
select top 10 
	c.first_name + ' ' + c.last_name as name,
	o.order_date
from sales.customers c
join sales.orders o
	on c.customer_id = o.customer_id
order by o.order_date;

-- 11. Show all products with their brand names, even if some products don't have brands. Include product name, brand name (show 'No Brand' if null).
select 
	p.product_name,
	coalesce(b.brand_name, 'No Brand') as brand
from production.products p
left join production.brands b
	on p.brand_id = b.brand_id;

-- 12. Find products that cost more than the average product price. Show product name and price.
select product_name, list_price
from production.products
where list_price > (
	select avg(list_price) 
	from production.products
);

-- 13. Find customers who have placed at least one order. Use a subquery with IN. Show customer_id and customer_name.
select 
	c.customer_id, 
	concat(c.first_name, ' ', c.last_name) as 'name'
from sales.customers c
where c.customer_id in (
	select o.customer_id
	from sales.orders o
);

-- 14. For each customer, show their name and total number of orders using a subquery in the SELECT clause.
select 
	concat(c.first_name, ' ', c.last_name) as 'name',
	(
		select count(*) 
		from sales.orders o
		where o.customer_id = c.customer_id
	) as order_count
from sales.customers c
order by order_count asc;

-- 15. Create a simple view called easy_product_list that shows product name, category name, and price. Then write a query to select all products from this view where price > 100.
go
create view easy_product_list
as
select 
	p.product_name,
	c.category_name,
	p.list_price
from production.products p 
join production.categories c
	on p.category_id = c.category_id;

go

select * 
from easy_product_list
where list_price > 100;

-- 16. Create a view called customer_info that shows customer ID, full name (first + last), email, and city and state combined. Then use this view to find all customers from California (CA).
go
create view customer_info
as 
select 
	customer_id,
	concat(first_name, ' ', last_name) as full_name,
	email,
	concat(city, ', ', state) AS location
from sales.customers;
go

select * 
from customer_info
where location like '%, CA';
go

-- 17. Find all products that cost between $50 and $200. Show product name and price, ordered by price from lowest to highest.
select 
	product_name, list_price
from production.products
where list_price between 50 and 200
order by list_price;

-- 18. Count how many customers live in each state. Show state and customer count, ordered by count from highest to lowest.
select 
	state,
	count(*) as customer_count
from sales.customers
group by state
order by customer_count desc;

-- 19. Find the most expensive product in each category. Show category name, product name, and price.
-- ??
-- ??
-- ??


-- 20. Show all stores and their cities, including the total number of orders from each store. Show store name, city, and order count.
-- ??
-- ??
-- ??



