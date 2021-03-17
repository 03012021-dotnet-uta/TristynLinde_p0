--CREATE DATABASE PizzaBox-DB;

-- create tables
CREATE TABLE Toppings(
ToppingID INT PRIMARY KEY IDENTITY,
Topping varchar(50) NOT NULL,
Price float NOT NULL);

CREATE TABLE Pizzas(
PizzaID INT PRIMARY KEY IDENTITY,
Crust varchar(50) NOT NULL,
Size varchar(50) NOT NULL,
TotalPrice float NOT NULL);

CREATE TABLE PizzaToppings(
PizzaID INT NOT NULL FOREIGN KEY REFERENCES Pizzas (PizzaID) ON DELETE CASCADE,
ToppingID INT NOT NULL FOREIGN KEY REFERENCES Toppings (ToppingID) ON DELETE CASCADE,
PRIMARY KEY (PizzaID, ToppingID));

CREATE TABLE Orders(
OrderID INT PRIMARY KEY IDENTITY,
Customer varchar(50) NOT NULL,
Store varchar(50) NOT NULL);

CREATE TABLE OrderedPizzas(
OrderID INT NOT NULL FOREIGN KEY REFERENCES Orders (OrderID) ON DELETE CASCADE,
PizzaID INT NOT NULL FOREIGN KEY REFERENCES Pizzas (PizzaID) ON DELETE CASCADE);

-- populate tables
INSERT INTO Toppings (Topping, Price)
VALUES ('Pepperoni', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Tomatos', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Onions', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Canadian Bacon', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Olives', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Italian Sausage', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Mushrooms', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Pineapple', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Extra Cheese', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Chicken', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Spinach', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Broccoli', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Bell Peppers', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Basil', 1);
INSERT INTO Toppings (Topping, Price)
VALUES ('Ricotta Cheese', 1);

