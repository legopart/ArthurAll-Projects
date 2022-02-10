using DataBaseOOP;
using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace MySQL_MongoDB_Cars_StudentsNet4_7.Classes
{
    public class Car
    {
        public static DataTable MySQLResultTable;
        public object Id { get; }
        public string Type { get; }
        public string Description { get; }
        public string SubDescription { get; }
        public string Model { get; }
        public int? Price { get; }

        public Car(object id, string type, string description, string subDescription, string model, int? price) : this(type, description, subDescription, model, price)
        {
            Id = id;
        }
        public Car(string type, string description, string subDescription, string model, int? price)
        {
            Type = type;
            Description = description;
            SubDescription = subDescription;
            Model = model;
            Price = price;
        }

        public void Insert(MySQL mySQL)
        {
            mySQL.Procedure("InsertCar");
            mySQL.SetParameter("_type", Type);
            mySQL.SetParameter("_description", Description);
            mySQL.SetParameter("_subDescription", SubDescription);
            mySQL.SetParameter("_model", Model);
            mySQL.SetParameter("_price", Price);
            mySQL.ProceduteExecute();
            ////Query Example
            //mySQL.Quary("INSERT INTO cars (Type, Description, SubDescription, Model, Price) VALUES (@type, @description, @subdescription, @model, @price)");
            //mySQL.SetParameter("@type", Type);
            //mySQL.SetParameter("@description", Description);
            //mySQL.SetParameter("@subdescription", SubDescription);
            //mySQL.SetParameter("@model", Model);
            //mySQL.SetParameter("@price", Price);
            //mySQL.QuaryExecute();
        }

        public void Delete(MySQL mySQL)
        {
            mySQL.Procedure("DeleteCar");
            mySQL.SetParameter("_id", Id);
            mySQL.ProceduteExecute();
            ////Query Example
            //mySQL.Quary("DELETE FROM cars WHERE idCars=@id");
            //mySQL.SetParameter("@id", Id);
            //mySQL.QuaryExecute();
        }

        public void Update(MySQL mySQL, Car updated)
        {
            mySQL.Procedure("UpdateCar");
            mySQL.SetParameter("_id", Id);
            mySQL.SetParameter("_type", updated.Type);
            mySQL.SetParameter("_description", updated.Description);
            mySQL.SetParameter("_subDescription", updated.SubDescription);
            mySQL.SetParameter("_model", updated.Model);
            mySQL.SetParameter("_price", updated.Price);
            mySQL.ProceduteExecute();
            ////Query Example
            //mySQL.Quary($@"UPDATE cars SET Type = '{updated.Type}', Description = '{updated.Description}', SubDescription = '{updated.SubDescription}', Model = '{updated.Model}', Price = {updated.Price} WHERE idCars={Id}");
            //mySQL.QuaryExecute();
        }
        public static void SetDataTable(MySQL mySQL)
        {
            DataTable newCarDataTable = new DataTable();
            newCarDataTable.Columns.Add("clmId_MySQL");    //hidden
            newCarDataTable.Columns.Add("Type");
            newCarDataTable.Columns.Add("Description");
            newCarDataTable.Columns.Add("Sub Desc");
            newCarDataTable.Columns.Add("Model");
            newCarDataTable.Columns.Add("Price");
            mySQL.Quary("SELECT * FROM cars");
            MySqlDataReader results = mySQL.GetQueryMultyResults();
            //for 1 result: if (mdr.Read())
            while (results != null && results.Read())
            {
                try
                {
                    DataRow dataRow = newCarDataTable.NewRow();
                    string str = results.GetString("idCars");
                    dataRow["clmId_MySQL"] = str;
                    dataRow["Type"] = results.GetString("Type");
                    dataRow["Description"] = results.GetString("Description");
                    dataRow["Sub Desc"] = results.GetString("SubDescription");
                    dataRow["Model"] = results.GetString("Model");
                    dataRow["Price"] = results.GetInt32("Price");
                    newCarDataTable.Rows.Add(dataRow);
                }
                catch (Exception) { };
            }

            MySQLResultTable = newCarDataTable;
        }
        public static void PrintSelect_AllRows(MySQL mySQL, string stmQuary) { mySQL.Quary(stmQuary); PrintSelect_AllRows(mySQL); }
        public static void PrintSelect_AllRows(MySQL mySQL)
        {
                mySQL.Quary("SELECT * FROM cars");
                MySqlDataReader results = mySQL.GetQueryMultyResults();
                while (results != null && results.Read())
                    Console.WriteLine($"{results.GetInt32(0)} {results.GetString(1)} {results.GetInt32(2)}");
        }
        public override string ToString() => $"Car: {Type}, {Price}";
    }
}
