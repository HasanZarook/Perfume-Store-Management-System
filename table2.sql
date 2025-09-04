use Perfume_store

-- Table 1: Orders
CREATE TABLE Orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT FOREIGN KEY REFERENCES Customers(customer_id),
    order_date DATETIME,
    total_amount DECIMAL(10, 2) -- Assuming a decimal type for total amount
);

-- Table 2: order_items
CREATE TABLE order_items (
    order_item_id INT IDENTITY(1,1) PRIMARY KEY,
    order_id INT FOREIGN KEY REFERENCES Orders(order_id),
    perfume_id INT FOREIGN KEY REFERENCES Perfumes(perfume_id),
    quantity INT
);
