CREATE TABLE products(id INT PRIMARY KEY, name TEXT);
INSERT INTO products(id, name) VALUES 
(1, 'cabbage'), 
(2, 'apple'), 
(3, 'dumbell');

CREATE TABLE categories(id INT PRIMARY KEY, name TEXT);
INSERT INTO categories(id, name) VALUES 
(1, 'fruits'), 
(2, 'vegetables'), 
(3, 'vitamin-rich food');

CREATE TABLE product_category_relations(product_id INT, category_id INT);
INSERT INTO product_category_relations(product_id, category_id) VALUES 
(1, 2),
(1, 3),
(2, 1),
(2, 3);

SELECT 
  p.name, 
  c.name
FROM products p 
LEFT JOIN product_category_relations r
  ON p.id = r.product_id
LEFT JOIN categories c
  ON r.category_id = c.id