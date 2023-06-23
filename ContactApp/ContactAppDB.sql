
CREATE TABLE Contacts (
    ContactID INT PRIMARY KEY,
    Name VARCHAR(50),
    Phone VARCHAR(10),
    Fax VARCHAR(10),
    eMail VARCHAR(50),
    Notes TEXT,
    LastUpdateDate DATETIME,
    LastUpdateUserName VARCHAR(20)
);
