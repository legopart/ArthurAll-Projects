using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Data;
using System.Windows.Forms;

namespace winform_flights
{
    public struct DatabaseAccess
    {

        // Database connect to the collection
        private static MongoClient MongoClientConnection = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");
        private static IMongoDatabase database = MongoClientConnection.GetDatabase("flights");
        private static IMongoCollection<BsonDocument> passengersDBCollection = database.GetCollection<BsonDocument>("passengers");

        public static Passanger getCorrentRow(DataGridView dgrdPassengers)
        {
            DataGridViewRow currentRow = dgrdPassengers.CurrentRow;
            Passanger passanger = new Passanger();
            passanger.name = currentRow.Cells[0].Value;
            passanger.age = currentRow.Cells[1].Value;
            return passanger;
        }

        public static bool DB_UpdateData(Passanger find, Passanger value)   //vvvvv
        {
            try
            {
                string name = (string)(find.name);
                int age = Int32.Parse((string)find.age);
                FilterDefinitionBuilder<BsonDocument> builder = Builders<BsonDocument>.Filter;
                FilterDefinition<BsonDocument> filter = builder.Eq("name", name) & builder.Eq("age", age);
                string nameUpdade = (string)(value.name);
                int ageUpdade = Int32.Parse((string)value.age);
                UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set("name", nameUpdade).Set("age", ageUpdade);
                passengersDBCollection.UpdateOne(filter, update);
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public static bool DB_SaveData(Passanger value)         //vvvvv
        {
            try
            {
                Console.WriteLine("Write Data");
                string name = ( (string)(value.name) );
                int age = int.Parse( ( (string)(value.age) ) );
                BsonDocument document = new BsonDocument
                    { { "name", name }, { "age",age}};
                passengersDBCollection.InsertOne(document);
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public static bool DB_DeleteData(Passanger passengerToDelete)   //vvvvv
        {
            try
            {
                string name = (string)(passengerToDelete.name);
                int age = Int32.Parse( (string) passengerToDelete.age );
                FilterDefinitionBuilder<BsonDocument> builder = Builders<BsonDocument>.Filter;
                FilterDefinition<BsonDocument> filter = builder.Eq("name", name) & builder.Eq("age", age);
                passengersDBCollection.DeleteOne(filter);
                //passengersDBCollection.DeleteMany(filter); // לחזור על DeleteMany
                return true;
            }
            catch (Exception ex) { }
            return false;
        }

        public static DataTable DB_GetData(DataTable tableMySQL)   //vvvvv
        {
            DataTable table=new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("age");
            try
            {
                IFindFluent<BsonDocument, BsonDocument> documents = passengersDBCollection.Find(new BsonDocument());
                foreach (BsonDocument document in documents.ToListAsync().Result)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["name"] = document[1].ToString();
                    dataRow["age"] = document[2].ToString();
                    table.Rows.Add(dataRow);
                }
            }
            catch { }
            table.AcceptChanges();
            return table;
        }

    }
}
