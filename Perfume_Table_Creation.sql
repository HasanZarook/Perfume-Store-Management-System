-- Create Brands table
CREATE TABLE Brands (
    brand_id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    country_of_origin VARCHAR(255)
);

-- Create Perfumes table
CREATE TABLE Perfumes (
    perfume_id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    brand_id INT FOREIGN KEY REFERENCES Brands(brand_id),
    fragrance_family VARCHAR(50),
    price DECIMAL(10, 2),
    quantity_in_stock INT,
    description TEXT,
    image_url VARCHAR(255)
);

-- Create Customers table
CREATE TABLE Customers (
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    first_name VARCHAR(255),
    last_name VARCHAR(255),
    email VARCHAR(255),
    phone_number VARCHAR(20),
    address TEXT
);

-- Create Sales table
CREATE TABLE Sales (
    sale_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT FOREIGN KEY REFERENCES Customers(customer_id),
    sale_date DATE,
    total_amount DECIMAL(10, 2)
);

-- Create Sale_Items table
CREATE TABLE Sale_Items (
    sale_item_id INT PRIMARY KEY IDENTITY(1,1),
    sale_id INT FOREIGN KEY REFERENCES Sales(sale_id),
    perfume_id INT FOREIGN KEY REFERENCES Perfumes(perfume_id),
    quantity INT,
    unit_price DECIMAL(10, 2)
);
