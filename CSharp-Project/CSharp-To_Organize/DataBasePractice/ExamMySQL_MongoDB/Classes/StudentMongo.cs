using DataBaseOOP;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
namespace ExamMySQL_MongoDB.Classes
{
    public class StudentMongo
    {
        public static DataTable? MongoDBResultTable { get; set; }
        public object? Id { get; }
        public string? FirstName { get; }
        public string? LastName { get; }
        public string? Course { get; }

        public StudentMongo(object id, string? firstName, string? lastName, string? course) :this(firstName, lastName, course)
            => Id = id;
        

        public StudentMongo(string? firstName, string? lastName, string? course)
            => (FirstName, LastName, Course) = (firstName, lastName, course);


        public void InsertOne(MongoDb mongoDb)
        {
            mongoDb.SetCollection("Students");
                string? courses = "";
                var courseArrBson = new BsonArray();
                if (Course!=null) courses = Course.ToString();
                if (courses !=null)
                    foreach (string course in courses.Split(','))
                        courseArrBson.Add(new BsonDocument("CourseName", course.Trim()));
                BsonDocument document = new BsonDocument { { "FirstName", FirstName }, { "LastName", LastName } };
                if(courseArrBson.Count>0) document.Add("Course", courseArrBson);
                mongoDb.InsertOne(document);
        }

        public void DeleteOne(MongoDb mongoDb)
        {
            mongoDb.SetCollection("Students");
            FilterDefinitionBuilder<BsonDocument> builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filter = builder.Eq("_id", ObjectId.Parse(Id?.ToString()));
            mongoDb.DeleteOne(filter); 
        }

        public void UpdateOne(MongoDb mongoDb, StudentMongo updated)
        {
            mongoDb.SetCollection("Students");
            string? coursesUpdate = "";
            var courseArrBson = new BsonArray();
            if (updated.Course != null) coursesUpdate = updated.Course.ToString();
            if (coursesUpdate != null)
                foreach (string courseUpdate in coursesUpdate.Split(','))
                    courseArrBson.Add(new BsonDocument("CourseName", courseUpdate.Trim()));
            FilterDefinitionBuilder<BsonDocument> builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filter = builder.Eq("_id", ObjectId.Parse(Id?.ToString()));
            UpdateDefinition<BsonDocument> update = Builders<BsonDocument>
                .Update.Set("FirstName", updated.FirstName).Set("LastName", updated.LastName).Set("Course", courseArrBson) ;
            mongoDb.UpdateOne(filter, update);
        }

        public static void SetList_DataTable(MongoDb mongoDb)
        {
            mongoDb.SetCollection("Students");
            DataTable newStudentsDataTable = new DataTable();
            foreach (string colmn in new[]{ "clmId_MongoDB", "First Name", "Last Name", "Courses" }) //clmId_MongoDB is hidden
                newStudentsDataTable.Columns.Add(colmn);
            foreach (BsonDocument doc in mongoDb.FindAll())
                try 
                {
                    DataRow dataRow = newStudentsDataTable.NewRow();
                    foreach (var (key, value) in new[]{ ("clmId_MongoDB", "_id"), ("First Name", "FirstName"), ("Last Name", "LastName") })
                        dataRow[key] = doc.GetElement(value).Value;
                    string coursesString = "";
                    if (doc.Contains("Course"))
                        try
                        {
                            var courses = JsonConvert.DeserializeObject<List<CourseJson>>(doc.GetElement("Course").Value.ToString());
                            foreach (CourseJson course in courses)
                                coursesString += $"{course.CourseName}, ";
                            dataRow["Courses"] = coursesString;
                        }catch{ }
                    newStudentsDataTable.Rows.Add(dataRow);
                }
                catch { }
            MongoDBResultTable = newStudentsDataTable;
        }

    }
}
