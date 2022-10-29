using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Exercise_05.JSON
{
    [TestFixture]
    internal class FilmsJSONTests
    {
        private JToken jsonFilms;

        [SetUp]
        public void Setup()
        {
            using (var sr = new StreamReader(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.JSON//Exercise_05.JSON//films.json"))
            {
                var reader = new JsonTextReader(sr);
                jsonFilms = JArray.Load(reader);
            }
        }
        [Test]
        public void There_are_items_bilingual()
        {
            JArray json = JArray.Parse(jsonFilms.ToString());

            List<string> isBilingual = new List<string>();
            int countOfFilms = json.Count;

            for (int i = 0; i < countOfFilms; i++)
            {
                var jsonData = json[i];
                string language = (string)jsonData["Language"];
                if (language.Contains(","))
                {

                    isBilingual.Add((string)jsonData["Title"]);
                }
            }
            int count = isBilingual.Count;

            Assert.That(count, Is.EqualTo(6));  
        }
        [Test]
        public void There_are_items_crime_genre()
        {
            JArray json = JArray.Parse(jsonFilms.ToString());

            List<string> isCrime = new List<string>();
            int countOfFilms = json.Count;

            for (int i = 0; i < countOfFilms; i++)
            {
                var jsonData = json[i];
                string crim = (string)jsonData["Genre"];

                if (crim.Contains("Crime"))
                {
                    isCrime.Add((string)jsonData["Title"]);
                }
            }
            int count = isCrime.Count;

            Assert.That(count, Is.EqualTo(6));
        }
        [Test]
        public void There_are_all_main_actors()
        {
            JArray json = JArray.Parse(jsonFilms.ToString());

            List <string> mainActors = new List<string>();
            int countOfFilms = json.Count;

            for (int i = 0; i < countOfFilms; i++)
            {
                var jsonData = json[i];
                int year = Int32.Parse(((string)jsonData["Year"]).Substring(0,3));

                if(year < 2010)
                {
                    mainActors.Add((string)jsonData["Actors"]);
                }
            }
            int count = mainActors.Count;

            Assert.That(count, Is.EqualTo(16));
        }
        [Test]
        public void There_are_average_IMDB_rating()
        {
            JArray json = JArray.Parse(jsonFilms.ToString());

            double rating = 0;
            int count = 0;
            int countOfFilms = json.Count;

            for (int i = 0; i < countOfFilms; i++)
            {
                var jsonData = json[i];
                string imdbVotes = (string)jsonData["imdbVotes"] != "N/A" ? ((string)jsonData["imdbVotes"]).Replace(",","") : "0";

                if (Int32.Parse(imdbVotes) > 200000)
                {
                    rating += (double)jsonData["imdbRating"];
                    count++;
                }
            }
            double avgOfRating= Math.Round(rating / count,1);

            Assert.That(avgOfRating, Is.EqualTo(8.3));
        }
    }
}