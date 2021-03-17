--CREATE DATABASE PizzaBox-DB;

-- create tables
CREATE TABLE Crust(
CrustID INT PRIMARY KEY IDENTITY,
Crust varchar(50) NOT NULL,
Price float NOT NULL);

CREATE TABLE Size(
SizeID INT PRIMARY KEY IDENTITY,
Size varchar(50) NOT NULL,
Inches INT NOT NULL,
Price float NOT NULL);

CREATE TABLE Toppings(
ToppingID INT PRIMARY KEY IDENTITY,
Topping varchar(50) NOT NULL,
Price float NOT NULL);

CREATE TABLE Pizzas(
PizzaID INT PRIMARY KEY IDENTITY,
CrustID INT NOT NULL FOREIGN KEY REFERENCES Crust (CrustID) ON DELETE CASCADE,
SizeID INT NOT NULL FOREIGN KEY REFERENCES Size (SizeID) ON DELETE CASCADE,
TotalPrice float NOT NULL);

CREATE TABLE PizzaToppings(
PizzaID INT NOT NULL FOREIGN KEY REFERENCES Pizzas (PizzaID) ON DELETE CASCADE,
ToppingID INT NOT NULL FOREIGN KEY REFERENCES Toppings (ToppingID) ON DELETE CASCADE,
PRIMARY KEY (PizzaID, ToppingID));

CREATE TABLE Stores(
StoreID INT PRIMARY KEY IDENTITY,
Store varchar(50) NOT NULL,
StoreAddress varchar(50) NOT NULL);

CREATE TABLE Customers(
CustID INT PRIMARY KEY IDENTITY,
CustName varchar(50) NOT NULL);

CREATE TABLE Orders(
OrderID INT PRIMARY KEY IDENTITY,
Customer INT NOT NULL FOREIGN KEY REFERENCES Customers (CustID) ON DELETE CASCADE,
Store INT NOT NULL FOREIGN KEY REFERENCES Stores (StoreID) ON DELETE CASCADE);

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

