using MongoDB.Driver;
using ContactApp.Models;

namespace ContactApp.Models
{
    public class MongoDBClient
    {
        private readonly IMongoCollection<Contact> _contactCollection;
         public IMongoCollection<Contact> Contacts => _contactCollection;

        public MongoDBClient()
        {
        var client = new MongoClient();
        var database = client.GetDatabase("CONTACTDB");
        _contactCollection = database.GetCollection<Contact>("CONTACTS");
        }

        public void SaveContact(Contact contact)
        {
        _contactCollection.InsertOne(contact);
        }

    }
}
  // Add other methods as needed for querying, updating, deleting contacts, etc.
 //// Establish a connection to the MongoDB database
      //  var connectionString = "mongodb+svr://4985:rmilxoLbLd0vcajU@contactdb.9svgdqc.mongodb.net/"; // Replace with your actual connection string
        //var client = new MongoClient(connectionString);
        //var database = client.GetDatabase("CONTACTDB"); // Replace with your actual database name
        //var collection = database.GetCollection<BsonDocument>("CONTACTS"); // Replace with your actual collection name