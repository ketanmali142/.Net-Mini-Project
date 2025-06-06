-- SQL Stored Procedure for department filter
CREATE PROCEDURE GetEmployeesByDept
    @Dept NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Employees WHERE Department = @Dept
END