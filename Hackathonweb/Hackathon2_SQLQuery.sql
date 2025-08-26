CREATE TABLE EmpManager (
    id INT PRIMARY KEY,
    EmpName VARCHAR(100),
    Salary DECIMAL(18,2),
    managerid INT
);
INSERT INTO EmpManager(id,EmpName,Salary,managerid)VALUES(1,'Supritha',55000,2);
INSERT INTO EmpManager(id,EmpName,Salary,managerid)VALUES(2,'Jane',40000,3);
INSERT INTO EmpManager(id,EmpName,Salary,managerid)VALUES(3,'John',99000,2);
INSERT INTO EmpManager(id,EmpName,Salary,managerid)VALUES(4,'Aane',45000,2);
INSERT INTO EmpManager(id,EmpName,Salary,managerid)VALUES(5,'Kevin',60000,1);

SELECT e.EmpName AS EmployeeName, m.EmpName AS ManagerName
FROM EmpManager e
LEFT JOIN EmpManager m ON e.managerid = m.id
ORDER BY e.EmpName ASC;