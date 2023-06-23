/* global use, db */
// MongoDB Playground
// Use Ctrl+Space inside a snippet or a string literal to trigger completions.

const database = 'CONTACTDB';
const collection = 'CONTACTS';

// Create a new database.
use(database);

// Create a new collection.
db.createCollection(collection);

db.collection.insertOne({
    ContactID: 1,
    Name: "Juan Del Pueblo",
    Phone: "1234567890",
    Fax: "9896543210",
    Email: "pueblo@example.com",
    Notes: "Work Partner",
    LastUpdateDate: ISODate("2023-06-21T00:00:00Z"),
    LastUpdateUserName: "Juan"
  })

  //const { MongoClient } = require('mongodb');
// The prototype form to create a collection:
/* db.createCollection( <name>,
  {
    capped: <boolean>,
    autoIndexId: <boolean>,
    size: <number>,
    max: <number>,
    storageEngine: <document>,
    validator: <document>,
    validationLevel: <string>,
    validationAction: <string>,
    indexOptionDefaults: <document>,
    viewOn: <string>,
    pipeline: <pipeline>,
    collation: <document>,
    writeConcern: <document>,
    timeseries: { // Added in MongoDB 5.0
      timeField: <string>, // required for time series collections
      metaField: <string>,
      granularity: <string>,
      bucketMaxSpanSeconds: <number>, // Added in MongoDB 6.3
      bucketRoundingSeconds: <number>, // Added in MongoDB 6.3
    },
    expireAfterSeconds: <number>,
    clusteredIndex: <document>, // Added in MongoDB 5.3
  }
)*/

// More information on the `createCollection` command can be found at:
// https://www.mongodb.com/docs/manual/reference/method/db.createCollection/
