SET ANSI_PADDING ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE DATABASE [PaymentOrderDb]
GO

USE [PaymentOrderDb]
GO

CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY(1,1),
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL,
    AmountPaid DECIMAL(18, 2) NOT NULL DEFAULT 0
);
GO

CREATE TABLE MoneyArrivals (
    ArrivalId INT PRIMARY KEY IDENTITY(1,1),
    ArrivalDate DATETIME NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL,
    RemainingAmount DECIMAL(18, 2) NOT NULL
);
GO

CREATE TABLE Payments (
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT NOT NULL,
    ArrivalId INT NOT NULL,
    PaymentAmount DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    FOREIGN KEY (ArrivalId) REFERENCES MoneyArrivals(ArrivalId)
);
GO

CREATE OR ALTER TRIGGER [dbo].[trg_UpdateOrderAndMoneyArrival]
ON [dbo].[Payments]
AFTER INSERT
AS
BEGIN
††† SET NOCOUNT ON;

††† DECLARE @ValidCount INT = 0;
††† DECLARE @ErrorMessage NVARCHAR(255);
††† 
††† DECLARE @OrderID INT, @ArrivalID INT, @PaymentAmount DECIMAL(18, 2);
††† 
††† DECLARE db_cursor CURSOR FOR
††† SELECT OrderID, ArrivalID, PaymentAmount
††† FROM inserted;

††† OPEN db_cursor;
††† FETCH NEXT FROM db_cursor INTO @OrderID, @ArrivalID, @PaymentAmount;

††† WHILE @@FETCH_STATUS = 0
††† BEGIN
††††††† DECLARE @PaymentDifference DECIMAL(18, 2);
††††††† SET @PaymentDifference = (SELECT TotalAmount - AmountPaid FROM Orders WHERE OrderID = @OrderID);

††††††† IF @PaymentAmount <= 0 
††††††† BEGIN
††††††††††† SET @ErrorMessage = 'Œ¯Ë·Í‡: —ÛÏÏ‡ ÔÎ‡ÚÂÊ‡ ‰ÓÎÊÌ‡ ·˚Ú¸ ÔÓÎÓÊËÚÂÎ¸ÌÓÈ ‰Îˇ OrderID: ' + CAST(@OrderID AS NVARCHAR);
††††††††††† RAISERROR(@ErrorMessage, 16, 1);
††††††††††† ROLLBACK TRANSACTION;
††††††††††† RETURN;
††††††† END
††††††† ELSE IF @PaymentDifference <= 0
††††††† BEGIN
††††††††††† SET @ErrorMessage = 'Œ¯Ë·Í‡: œÓÎÌÓÔ‡‚Ì‡ˇ ÒÛÏÏ‡ ÛÊÂ ‚˚ÔÎ‡˜ÂÌ‡ ‰Îˇ OrderID: ' + CAST(@OrderID AS NVARCHAR);
††††††††††† RAISERROR(@ErrorMessage, 16, 1);
††††††††††† ROLLBACK TRANSACTION;
††††††††††† RETURN;
††††††† END
††††††† ELSE IF @PaymentAmount > @PaymentDifference
††††††† BEGIN
††††††††††† SET @ErrorMessage = 'Œ¯Ë·Í‡: —ÛÏÏ‡ ÔÎ‡ÚÂÊ‡ ÔÂ‚˚¯‡ÂÚ ‰ÓÔÛÒÚËÏÛ˛ ‰Îˇ OrderID: ' + CAST(@OrderID AS NVARCHAR);
††††††††††† RAISERROR(@ErrorMessage, 16, 1);
††††††††††† ROLLBACK TRANSACTION;
††††††††††† RETURN;
††††††† END
††††††† ELSE IF @PaymentAmount > (SELECT RemainingAmount FROM MoneyArrivals WHERE ArrivalID = @ArrivalID)
††††††† BEGIN
††††††††††† SET @ErrorMessage = 'Œ¯Ë·Í‡: ÕÂ‰ÓÒÚ‡ÚÓ˜ÌÓ ÒÂ‰ÒÚ‚ ‰Îˇ ArrivalID: ' + CAST(@ArrivalID AS NVARCHAR);
††††††††††† RAISERROR(@ErrorMessage, 16, 1);
††††††††††† ROLLBACK TRANSACTION;
††††††††††† RETURN;
††††††† END
††††††† ELSE
††††††† BEGIN
††††††††††† UPDATE Orders
††††††††††† SET AmountPaid = AmountPaid + @PaymentAmount
††††††††††† WHERE OrderID = @OrderID;

††††††††††† UPDATE MoneyArrivals
††††††††††† SET RemainingAmount = RemainingAmount - @PaymentAmount
††††††††††† WHERE ArrivalID = @ArrivalID;

††††††††††† SET @ValidCount = @ValidCount + 1;
††††††† END

††††††† FETCH NEXT FROM db_cursor INTO @OrderID, @ArrivalID, @PaymentAmount;
††† END

††† CLOSE db_cursor;
††† DEALLOCATE db_cursor;

††† PRINT ' ÓÎË˜ÂÒÚ‚Ó ‚‡ÎË‰Ì˚ı ÔÎ‡ÚÂÊÂÈ: ' + CAST(@ValidCount AS NVARCHAR);
END;
GO
