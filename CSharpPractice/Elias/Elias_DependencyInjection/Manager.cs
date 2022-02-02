using Elias_DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elias_DependencyInjection
{
    /// <summary>
    /// Singelton
    /// </summary>
    public class SudentDataManager
    {
        private static SudentDataManager _instance = null;

        private Dictionary<int,Student> _studentsDictionay = new Dictionary<int,Student>();
        /// <summary>
        /// O(n)
        /// </summary>
        private SudentDataManager()
        {
            // get from db
            List<Student> data = GetDataFromDB();

            // mapping the data (studnets) from data structuer list to dictionary
            if (data != null)
            {
                foreach (var student in data)
                {
                    _studentsDictionay[student.Id] = student;
                }
            }
        }

        /// <summary>
        /// Get data from SQL
        /// Dummy data
        /// </summary>
        /// <returns></returns>
        private List<Student> GetDataFromDB()
        {
            List<Student> dbData = new List<Student>();
            dbData.Add(new Student()
            {
                Name = "elias",
                Age = 32,
                Id = 201298411
            });
            dbData.Add(new Student()
            {
                Name = "ronaldo",
                Age = 34,
                Id = 655484
            });
            dbData.Add(new Student()
            {
                Name = "missi",
                Age = 35,
                Id = 545645646
            });
            return dbData;
        }

        /// <summary>
        /// O(1)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student GetStudentById(int id)
        {
            if (_studentsDictionay.ContainsKey(id))
            {
                return _studentsDictionay[id];
            }
            return null;
        }
        public string Name;
        public static SudentDataManager Instance()  //Dependency Injection
        {
            if (_instance == null)
            {
                _instance = new SudentDataManager();
                
            }
            return _instance;
        }
    }
}
