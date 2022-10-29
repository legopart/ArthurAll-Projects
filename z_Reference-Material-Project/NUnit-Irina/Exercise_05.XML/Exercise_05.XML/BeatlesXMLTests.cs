using NUnit.Framework;
using System.Xml;

namespace Exercise_05.XML
{
    [TestFixture]
    public class BeatlesXMLTests
    {
        //public XmlDocument doc;

        [SetUp]
        public void Setup()
        {
            //XmlDocument doc = new XmlDocument();           
            //doc.Load(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.XML//Exercise_05.XML//Beatles.xml");
        }

        [Test]
        public void There_are_four_artists()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.XML//Exercise_05.XML//Beatles.xml");
            XmlElement root_element = doc.DocumentElement;

            int numOfArtists = doc.GetElementsByTagName("Artist").Count;
            Assert.That(numOfArtists, Is.EqualTo(4));
        }

        [Test]
        public void Two_are_dead_and_two_are_alive()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.XML//Exercise_05.XML//Beatles.xml");
            XmlElement root_element = doc.DocumentElement;
            int isDead = 0;
            int isAlive = 0;
            int numberOfArtists = root_element.GetElementsByTagName("Artist").Count;

            for (int i = 0; i < numberOfArtists; i++)
            {
                XmlNode isDeadOrAlive = root_element.GetElementsByTagName("IsAlive").Item(i); 
                string status = isDeadOrAlive.InnerText;
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
        public void Ringo_plays_drums()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.XML//Exercise_05.XML//Beatles.xml");
            XmlElement root_element = doc.DocumentElement;

            XmlNode playsRingo = root_element.GetElementsByTagName("Plays").Item(3);
            string isDrums = playsRingo.InnerText;
            Assert.That(isDrums, Is.EqualTo("Drums"));
        }

    }
}