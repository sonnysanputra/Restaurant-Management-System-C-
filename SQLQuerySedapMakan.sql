CREATE DATABASE Assignment_IOOP;
GO

USE Assignment_IOOP;
GO

CREATE TABLE Users (
    UserID         INT             IDENTITY(1,1) PRIMARY KEY,
    Username       NVARCHAR(50)    NOT NULL UNIQUE,
    Password       NVARCHAR(255)   NOT NULL,
    Role           NVARCHAR(20)    NOT NULL,
    Email          NVARCHAR(100)   NOT NULL UNIQUE,
    PhoneNumber    NVARCHAR(20),
    Name           NVARCHAR(100),
    EWalletBalance DECIMAL(10,2)   DEFAULT 0.00 NOT NULL
);

CREATE TABLE MenuItem (
    MenuItemID  INT             IDENTITY(1,1) PRIMARY KEY,
    Name        NVARCHAR(100)   NOT NULL UNIQUE,
    Category    NVARCHAR(50)    NOT NULL,
    Price       DECIMAL(10,2)   NOT NULL,
    IsAvailable BIT             DEFAULT 1 NOT NULL
);

CREATE TABLE Orders (
    OrderID     INT             IDENTITY(1,1) PRIMARY KEY,
    UserID      INT             NOT NULL,
    OrderDate   DATETIME        DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2)   NOT NULL,
    Status      NVARCHAR(50)    DEFAULT 'Pending',
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE OrderItems (
    OrderItemID INT             IDENTITY(1,1) PRIMARY KEY,
    OrderID     INT             NOT NULL,
    MenuItemID  INT             NOT NULL,
    Quantity    INT             NOT NULL,
    UnitPrice   DECIMAL(10,2)   NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (MenuItemID) REFERENCES MenuItem(MenuItemID)
);

CREATE TABLE EWalletTransactions (
    TransactionID   INT             IDENTITY(1,1) PRIMARY KEY,
    UserID          INT             NOT NULL,
    TransactionDate DATETIME        DEFAULT GETDATE(),
    Type            NVARCHAR(20)    NOT NULL,
    Amount          DECIMAL(10,2)   NOT NULL,
    Description     NVARCHAR(255),
    RelatedOrderID  INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (RelatedOrderID) REFERENCES Orders(OrderID)
);

CREATE TABLE Feedback (
    FeedbackID      INT             IDENTITY(1,1) PRIMARY KEY,
    UserID          INT             NOT NULL,
    OrderID         INT             NOT NULL,
    FeedbackDate    DATETIME        DEFAULT GETDATE(),
    Message         NVARCHAR(MAX)   NOT NULL,
    ManagerResponse NVARCHAR(MAX),
    ResponseDate    DATETIME,
    Status          NVARCHAR(20)    DEFAULT 'New',
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

CREATE TABLE RefundRequest (
    RefundID     INT             IDENTITY(1,1) PRIMARY KEY,
    UserID       INT             NOT NULL,
    OrderID      INT             NOT NULL,
    RequestDate  DATETIME        DEFAULT GETDATE(),
    Reason       NVARCHAR(MAX),
    Amount       DECIMAL(10,2)   NOT NULL,
    Status       NVARCHAR(20)    DEFAULT 'Pending',
    DecisionDate DATETIME,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

INSERT INTO Users (Username, Password, Role, Email, PhoneNumber, Name, EWalletBalance) VALUES
('Hilmimi', 'admin123', 'SystemAdmin', 'Hilmi@gmail.com', '6011223344', 'Hilmi', 200.00),
('Sonny', 'chef123', 'Chef', 'Sonny@gmail.com', '6011223345', 'Sonny', 200.00),
('Marcel', 'customer123', 'Customer', 'Marcel@gmail.com', '6011223346', 'Marcel', 200.00),
('Darren', 'manager123', 'Manager', 'Darren@gmail.com', '6011223347', 'Darren', 200.00);

INSERT INTO MenuItem (Name, Category, Price, IsAvailable)
VALUES
('Vegetable Salad', 'Vegetarian', 10.00, 1),
('Mushroom Stir Fry', 'Vegetarian', 11.50, 1),
('Spaghetti Carbonara', 'Italian', 14.00, 1),
('Lasagna', 'Italian', 16.00, 1),
('Chicken Burrito', 'Mexican', 13.00, 1),
('Beef Taco', 'Mexican', 12.00, 1),
('Lemon Tea', 'Drinks', 3.50, 1),
('Orange Juice', 'Drinks', 4.50, 1);

INSERT INTO Orders (UserID, OrderDate, TotalAmount, Status) VALUES
(3, GETDATE(), 25.50, 'Completed'),
(3, GETDATE(), 14.00, 'Completed'),
(3, GETDATE(), 13.00, 'In Progress'),
(3, GETDATE(), 12.00, 'In Progress'),
(3, GETDATE(), 18.00, 'Completed');

INSERT INTO OrderItems (OrderID, MenuItemID, Quantity, UnitPrice) VALUES
(1, 1, 1, 10.00),
(1, 7, 2, 3.50),
(2, 3, 1, 14.00),
(3, 5, 1, 13.00),
(4, 6, 1, 12.00);

INSERT INTO EWalletTransactions (UserID, Type, Amount, Description, RelatedOrderID) VALUES
(3, 'Top-Up', 100.00, 'Top-up via credit card', NULL),
(3, 'Payment', 25.50, 'Order #1 payment', 1),
(3, 'Payment', 14.00, 'Order #2 payment', 2),
(3, 'Payment', 13.00, 'Order #3 payment', 3),
(3, 'Refund', 12.00, 'Order #4 refund', 4);

INSERT INTO Feedback (UserID, OrderID, Message, ManagerResponse, ResponseDate, Status) VALUES
(3, 1, 'Great salad and drink combo!', 'Glad you enjoyed it!', GETDATE(), 'Replied'),
(3, 2, 'Carbonara was a bit salty.', 'We will improve the recipe.', GETDATE(), 'Replied'),
(3, 3, 'Still waiting for delivery...', NULL, NULL, 'New'),
(3, 4, 'Order was cancelled unexpectedly.', 'We apologize for the inconvenience.', GETDATE(), 'Replied'),
(3, 5, 'Great taste and packaging.', NULL, NULL, 'New');

INSERT INTO RefundRequest (UserID, OrderID, Reason, Amount, Status, DecisionDate) VALUES
(3, 4, 'Order cancelled by restaurant', 12.00, 'Approved', GETDATE()),
(3, 3, 'Delayed beyond acceptable time', 13.00, 'Pending', NULL),
(3, 2, 'Quality not as expected', 14.00, 'Rejected', GETDATE()),
(3, 1, 'Wrong drink served', 3.50, 'Approved', GETDATE()),
(3, 5, 'Incorrect packaging', 5.00, 'Pending', NULL);


Select * FROM Users
Select * From MenuItem
Select * FROM Orders
SELECT * FROM OrderItems
Select * FROM EWalletTransactions
Select * From Feedback
Select * From RefundRequest



