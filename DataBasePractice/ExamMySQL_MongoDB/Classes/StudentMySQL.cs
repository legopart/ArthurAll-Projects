using DataBaseOOP;
using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace ExamMySQL_MongoDB.Classes
{
    public class StudentMySQL
    {
        public static DataTable? MySQLResultTable;
        public object Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int? Age { get; }

        public StudentMySQL(object id, string? firstname, string? lastname, int? age) : this(firstname, lastname, age)
        {
            Id = id;
        }
        public StudentMySQL(string firstname, string lastname, int? age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }

        public void Insert(MySQL mySQL)
        {
            mySQL.Procedute("add");
            mySQL.SetParameter("_firstname", FirstName);
            mySQL.SetParameter("_lastname", LastName);
            mySQL.SetParameter("_age", Age);
            mySQL.ProceduteExecute();
        }


        public static void SetDataTable(MySQL mySQL)
        {
            DataTable newStudentTable = new DataTable();
            newStudentTable.Columns.Add("clmId_MySQL");    //hidden
            newStudentTable.Columns.Add("First Name");
            newStudentTable.Columns.Add("Last Name");
            newStudentTable.Columns.Add("Age");
            mySQL.Procedute("getstudents");

           // mySQL.Quary("SELECT * FROM school.students");
            using MySqlDataReader? results = mySQL.ProceduteExecuteMultyResults();
            //for 1 result: if (mdr.Read())
            while (results != null && results.Read())
            {
                try
                {
                    DataRow? dataRow = newStudentTable.NewRow();
                    dataRow["clmId_MySQL"] = results.GetValue("id");
                    dataRow["First Name"] = results.GetValue("firstname").ToString();
                    dataRow["Last Name"] = results.GetValue("lastname").ToString();
                    dataRow["Age"] = results.GetValue("Age").ToString();
                    newStudentTable.Rows.Add(dataRow);
                }
                catch (Exception) { };
            }

            MySQLResultTable = newStudentTable;
        }

    }
}
