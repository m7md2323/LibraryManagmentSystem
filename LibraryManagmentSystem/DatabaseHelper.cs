using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    using MongoDB.Driver;

    public class DatabaseHelper
    {
        private static readonly string connectionString = "mongodb://localhost:27017"; // Change if needed
        private static readonly string databaseName = "HotelDB";

        private static IMongoDatabase database;

        static DatabaseHelper()
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
        }

        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return database.GetCollection<T>(collectionName);
        }
    }

}
