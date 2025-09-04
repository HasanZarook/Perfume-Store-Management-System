--trigger
--automatically updates the quantity in stock for a perfume in the Perfumes table whenever a new order item is added.
CREATE TRIGGER AfterInsertOrderItemUpdateStock
ON order_items
AFTER INSERT
AS
BEGIN
    DECLARE @perfume_id INT, @quantity INT;

    -- Get the newly inserted perfume_id and quantity
    SELECT @perfume_id = i.perfume_id, @quantity = i.quantity
    FROM INSERTED i;

    -- Update the quantity in stock in the Perfumes table
    UPDATE Perfumes
    SET quantity_in_stock = quantity_in_stock - @quantity
    WHERE perfume_id = @perfume_id;
END;