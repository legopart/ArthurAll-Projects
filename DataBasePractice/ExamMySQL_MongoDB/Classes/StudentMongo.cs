﻿using DataBaseOOP;
using MongoDB.Bson;
using MongoDB.Driver;
using Nancy.Json;
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
        public object? Course { get; }

        public StudentMongo(object id, string? firstName, string? lastName, object? course) :this(firstName, lastName, course)
            => Id = id;
        

        public StudentMongo(string? firstName, string? lastName, object? course)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
        }

        public void InsertOne(MongoDb mongoDb)
        {
            mongoDb.DBCollectionString = "Students";

                string? courses = Course?.ToString(); if (courses == null) courses = "";
                string[] oneCourseString = (courses).Split(',');
                var courseArrBson = new BsonArray();
                for (int i = 0; i < oneCourseString.Length; i++)
                    courseArrBson.Add(new BsonDocument("CourseName", oneCourseString[i].Trim()));
                BsonDocument document = new BsonDocument { { "FirstName", FirstName }, { "LastName", LastName } };
                document.Add("Course", courseArrBson);
                mongoDb.InsertOne(document);
        }

        public void DeleteOne(MongoDb mongoDb)
        {
            mongoDb.DBCollectionString = "Students";
            FilterDefinitionBuilder<BsonDocument> builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filter = builder.Eq("_id", ObjectId.Parse(Id?.ToString()));
            mongoDb.DeleteOne(filter); 
        }

        public void UpdateOne(MongoDb mongoDb, StudentMongo updated)
        {
            mongoDb.DBCollectionString = "Students";
            string? courses = updated.Course?.ToString(); if (courses == null) courses = "";
            string[]? oneCourseString = (courses).Split(',');
            var courseArrBson = new BsonArray();
            for (int i = 0; i < oneCourseString.Length; i++)
                courseArrBson.Add(new BsonDocument("CourseName", oneCourseString[i].Trim()));
            FilterDefinitionBuilder<BsonDocument> builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filter = builder.Eq("_id", ObjectId.Parse(Id?.ToString()));
            UpdateDefinition<BsonDocument> update = Builders<BsonDocument>
                .Update.Set("FirstName", updated.FirstName).Set("LastName", updated.LastName).Set("Course", courseArrBson) ;
            mongoDb.UpdateOne(filter, update);
        }

        public static void SetList_DataTable(MongoDb mongoDb)
        {
            mongoDb.DBCollectionString = "Students";
            DataTable newStudentsDataTable = new DataTable();
            newStudentsDataTable.Columns.Add("clmId_MongoDB");    //hidden
            newStudentsDataTable.Columns.Add("First Name") ;
            newStudentsDataTable.Columns.Add("Last Name");
            newStudentsDataTable.Columns.Add("Courses");
            foreach (BsonDocument doc in mongoDb.FindAll() ) 
                if(doc != null && doc.Contains("_id") && doc.Contains("FirstName") && doc.Contains("LastName") ) // && doc.Contains("_id") && doc.Contains("FirstName") && doc.Contains("LastName")
                {
                    DataRow dataRow = newStudentsDataTable.NewRow();
                    dataRow["clmId_MongoDB"] = doc[0];
                    dataRow["First Name"] = doc.GetElement("FirstName").Value.ToString();
                    dataRow["Last Name"] = doc.GetElement("LastName").Value.ToString();
                    string coursesString = "";
                    if (doc.Contains("Course"))
                    {
                        try
                        {
                            string json = doc.GetElement("Course").Value.ToJson().ToString();
                            JavaScriptSerializer js = new JavaScriptSerializer();
                            CourseJson[] courses = js.Deserialize<CourseJson[]>(json);
                            foreach (CourseJson course in courses)
                                if(course != null)
                                coursesString += $"{course.CourseName}, ";
                            dataRow["Courses"] = coursesString;
                        }catch (Exception) { }
                    }
                    newStudentsDataTable.Rows.Add(dataRow);
                }
            MongoDBResultTable = newStudentsDataTable;
        }

    }
}
