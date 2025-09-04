-- Step 1: Create roles/groups for security in the database
USE Perfume_store;
GO

-- Create AdminRole
CREATE ROLE AdminRole;
GO

-- Create UserRole
CREATE ROLE UserRole;
GO

-- Step 2: Modify access for those roles/groups
-- Grant AdminRole full control over Perfumes, Brands, Sales, and Customers tables
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Perfumes TO AdminRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Brands TO AdminRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Sales TO AdminRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Customers TO AdminRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Sale_Items TO AdminRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Orders TO AdminRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.order_items TO AdminRole;
GO

-- Grant UserRole read-only access to Perfumes and Brands tables
GRANT SELECT ON dbo.Perfumes TO UserRole;
GRANT SELECT ON dbo.Brands TO UserRole;
GO

-- Step 3: Create two new database users
CREATE LOGIN User_Admin WITH PASSWORD = 'User_Admin'; 
CREATE LOGIN User_Normal WITH PASSWORD = 'User_Normal';  
GO

-- Step 4: Add each user to the appropriate role/group
USE Perfume_store;
GO

-- Add User_Admin to AdminRole
CREATE USER User_Admin FOR LOGIN User_Admin;
ALTER ROLE AdminRole ADD MEMBER User_Admin;
GO

-- Add User_Normal to UserRole
CREATE USER User_Normal FOR LOGIN User_Normal;
ALTER ROLE UserRole ADD MEMBER User_Normal;
GO
