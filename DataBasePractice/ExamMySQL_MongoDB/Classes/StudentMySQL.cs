using DataBaseOOP;
using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace ExamMySQL_MongoDB.Classes
{
    public class StudentMySQL
    {
        public static DataTable? MySQLResultTable;
        public object? Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int? Age { get; }

        public StudentMySQL(object id, string firstname, string lastname, int? age) : this(firstname, lastname, age)
            => Id = id;
        public StudentMySQL(string firstname, string lastname, int? age)
            => (FirstName, LastName, Age) = (firstname, lastname, age);

        public void Insert(MySQL mySQL)
        {
            mySQL.Procedute("add");
            foreach (var (key, value) in new[] { ("_firstname", FirstName), ("_lastname", LastName), ("_age", Age.ToString()) })
                mySQL.SetParameter(key, value);
            mySQL.ProceduteExecute();
        }

        public static void SetDataTable(MySQL mySQL)
        {
            DataTable newStudentTable = new DataTable();
            foreach (string culmn in new[]{ "clmId_MySQL", "First Name", "Last Name", "Age" })
                newStudentTable.Columns.Add(culmn);
            mySQL.Procedute("getstudents");
           // mySQL.Quary("SELECT * FROM school.students");
            using MySqlDataReader? results = mySQL.ProceduteExecuteMultyResults();
            while (results != null && results.Read()) //for 1 result: if (mdr.Read())
            {
                try
                {
                    DataRow? dataRow = newStudentTable.NewRow();
                    foreach (var (key, value) in new[] { ("clmId_MySQL", "id"), ("First Name", "firstname"), ("Last Name", "lastname"), ("Age", "Age") })
                        dataRow[key] = results.GetValue(value);
                    newStudentTable.Rows.Add(dataRow);
                } catch {};
            }
            MySQLResultTable = newStudentTable;
        }

    }
}
