using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.IO;

namespace Exercise_05.JSON
{
    [TestFixture]
    internal class BeatlesJSONTests
    {
        private JToken jsonBeatles;

        [SetUp]
        public void Setup()
        {
            using (var sr = new StreamReader(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.JSON//Exercise_05.JSON//Beatles.json"))
            {
                var reader = new JsonTextReader(sr);
                jsonBeatles = JObject.Load(reader);
            }
        }

        [Test]
        public void There_are_four_artists()
        {
            JObject json = JObject.Parse(jsonBeatles.ToString());
            JArray jsonArtists = (JArray)json["Beatles"]["Artists"];

            Assert.That(jsonArtists.Count, Is.EqualTo(4));
        }

        [Test]
        public void two_are_dead_and_two_are_alive()
        {           
            JObject json = JObject.Parse(jsonBeatles.ToString());
            var jsonData = json["Beatles"];

            int isDead = 0;
            int isAlive = 0;      
            
            int numberOfArtists = ((JArray)jsonData["Artists"]).Count;
            for (int i = 0; i < numberOfArtists; i++)
            {
                var isDeadOrAlive = jsonData["Artists"][i];
                string status = (string)isDeadOrAlive["IsAlive"];
                if (status == "Yes")
                {
                    isDead++;
                }
                else isAlive++;
            }

            Assert.That(isDead, Is.EqualTo(2));
            Assert.That(isAlive, Is.EqualTo(2));
        }

        [Test]
        public void ringo_plays_drums()
        {
            JObject json = JObject.Parse(jsonBeatles.ToString());
            var jsonData = json["Beatles"];
            var playsRingo = jsonData["Artists"][3];
            string isDrums = (string)playsRingo["Plays"];

            Assert.That(isDrums, Is.EqualTo("Drums"));
        }

    }
}