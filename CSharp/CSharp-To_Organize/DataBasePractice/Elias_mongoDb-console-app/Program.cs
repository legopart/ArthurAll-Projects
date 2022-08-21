using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace mongoDb_console_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //elias console basic app
                try
                {
                    Console.WriteLine("Welcome to my first Mongodb example");

                    // or use a connection string
                    var MongoClientConnection = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");

                    var database = MongoClientConnection.GetDatabase("flights");

                    var passengersCollection = database.GetCollection<BsonDocument>("passengers");




                    var documents = passengersCollection.Find(new BsonDocument());

                    Console.WriteLine("flight list");
                    foreach (var doc in documents.ToListAsync().Result)
                    {
                        Console.WriteLine(doc);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error!!!");
                }
            }
            }
    }
}
