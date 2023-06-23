// MongoDB Playground
// Use Ctrl+Space inside a snippet or a string literal to trigger completions.

// The current database to use.
use('CONTACTDB');

// Create a new document in the collection.
db.getCollection('CONTACTS').insertOne({
    ContactID: 1,
    Name: "Juan Del Pueblo",
    Phone: "1234567890",
    Fax: "9896543210",
    Email: "pueblo@example.com",
    Notes: "Work Partner",
    LastUpdateDate: ISODate("2023-06-21T00:00:00Z"),
    LastUpdateUserName: "Juan"
});

