--stored procedure
--updating the stock quantity in the Perfumes table based on the items sold in a sale.
CREATE PROCEDURE UpdateStockAfterSale
    @sale_id INT
AS
BEGIN
    UPDATE Perfumes
    SET quantity_in_stock = quantity_in_stock - ISNULL(si.quantity, 0)
    FROM Sale_Items si
    INNER JOIN Perfumes p ON si.perfume_id = p.perfume_id
    WHERE si.sale_id = @sale_id;
END;


