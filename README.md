# Вопрос №1
Разместите код на Github и приложите ссылку. Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.
Задание:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

# Вопрос №2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
По возможности — положите ответ рядом с кодом из первого вопроса.

## Ответ на второй вопрос => 
### процесс создания БД
```SQL
CREATE TABLE Products
(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(max) NOT NULL
);

CREATE TABLE Category
(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(max) NOT NULL
);

CREATE TABLE Prod_To_Category
(
products_id INT NOT NULL,
category_id INT NOT NULL,
FOREIGN KEY(products_id) REFERENCES Products(id) ON DELETE CASCADE,
FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE CASCADE
);

CREATE UNIQUE INDEX prod_cat ON ProdCat(products_id, category_id);
```
### Заполняем бд
```SQL 
INSERT INTO Products VALUES('Пижама'), ('Тапочки'), ('Отвертка');
INSERT INTO Category VALUES('Домашняя одежда'), ('Инструмент');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 2);
```
### Запрос
```SQL
SELECT p.name AS Product, c.name AS Category 
FROM Products AS p
LEFT JOIN Prod_To_Category AS pc ON p.id = pc.products_id
INNER JOIN Category AS c ON c.id = pc.category_id
ORDER BY Product;
```
 
