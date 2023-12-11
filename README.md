# C# Task

## Requirements

```ps
.NET 8.0
Microsoft.NET.Test.Sdk 17.8.0
MSTest.TestAdapter 3.1.1
MSTest.TestFramework 3.1.1
```

## Explanations

```ps
- Юнит-тесты приложены отдельным проектом.
- Легкость добавления фигур реализованна через ООП, а именно - абстрактный класс.
- Проверка на прямоугольный треугольник встроена в класс Triangle.
```

# SQL Task

Для начала нужно конкретезировать базу данных, так как не имее смысла писать запрос к обстрактной бд.
 
## Create Database 

Представим таблицы Products, Category как простейшие, состоящие только из номера строки (с авто-инкрементом) и имени.

```ps
CREATE TABLE Products(
    id INT IDENTITY(1,1) PRIMARY KEY ,
    name VARCHAR(255) NOT NULL);

CREATE TABLE Category(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(255) NOT NULL);
```

Дальше создадим таблицу пар для продуктов и категорий.
Создадим так же условия очистки элементов таблицы.

```ps
CREATE TABLE ProductСategoryInterconnection(
    productId INT NOT NULL,
    categoryId INT NOT NULL,
    FOREIGN KEY(productId) REFERENCES Products(id) ON DELETE CASCADE,
    FOREIGN KEY(categoryId) REFERENCES Category(id) ON DELETE CASCADE);	
```

## Insert values into Database

Добавим данные для корректной работы запроса.

```ps
INSERT INTO Products(name) VALUES('Carrot'), ('Milk'), ('Apple'), ('Water'), ('Bread'), ('Sugar');
INSERT INTO Category(name) VALUES('Drink'), ('Food'), ('Cloth');
INSERT INTO ProductСategoryInterconnection(productId, categoryId) VALUES(1, 1), (1, 2), (2, 1), (3, 2), (3, 1), (4, 1), (5, 2);
```

## SQL Request

```ps
SELECT Products.name AS Product, Category.name AS Category FROM ProductСategoryInterconnection AS Interconnection
INNER JOIN Products ON Products.id = Interconnection.productId
INNER JOIN Category ON Category.id = Interconnection.categoryId
ORDER BY Product;
```
