using NUnit.Framework;
using System.Xml;


namespace Exercise_05.XML
{
    public class CD_CatalogTests
    {
        [Test]
        public void Total_price ()
        {
            XmlDocument cdCatalog = new XmlDocument();
            cdCatalog.Load(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.XML//Exercise_05.XML//CD_Catalog.xml");
            XmlElement root_element = cdCatalog.DocumentElement;

            double totalPrice = 0;
            int numberOfCD = root_element.GetElementsByTagName("CD").Count;
            for (int i = 0; i < numberOfCD; i++)
            {
                XmlNode price = root_element.GetElementsByTagName("PRICE").Item(i);
                totalPrice += Double.Parse(price.InnerText);
            }
            totalPrice = Math.Round(totalPrice,2);
            Assert.That(totalPrice, Is.EqualTo(237.00));
        }
        [Test]
        public void CD_older_than_1987()
        {
            XmlDocument cdCatalog = new XmlDocument ();
            cdCatalog.Load(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.XML//Exercise_05.XML//CD_Catalog.xml");
            XmlElement root_element = cdCatalog.DocumentElement;

            double totalPrice = 0;
            int numberOfCD = root_element.GetElementsByTagName("CD").Count;
            for (int i = 0; i < numberOfCD; i++)
            {
                XmlNode yearOfCD = root_element.GetElementsByTagName("YEAR").Item(i);
                if (Int32.Parse(yearOfCD.InnerText) < 1987)
                {
                    XmlNode priceNow = root_element.GetElementsByTagName("PRICE").Item(i);
                    totalPrice += Double.Parse(priceNow.InnerText);
                }                
            }
            totalPrice = Math.Round(totalPrice, 2);
            Assert.That(totalPrice, Is.EqualTo(68.90));
        }
        [Test]
        public void CD_jast_from_USA()
        {
            XmlDocument cdCatalog = new XmlDocument();
            cdCatalog.Load(@"C://Users//Best_Mom//Desktop//Lessons_Zionet//DevOps//Course_AutomationAndDevOps//NUnit//Exercise_05.XML//Exercise_05.XML//CD_Catalog.xml");
            XmlElement root_element = cdCatalog.DocumentElement;

            List<string> newCatalog = new List<string>();
            int numberOfCD = root_element.GetElementsByTagName("CD").Count;
            for (int i = 0; i < numberOfCD; i++)
            {
                XmlNode country = root_element.GetElementsByTagName("COUNTRY").Item(i);
                if (country.InnerText == "USA")
                {
                    XmlNode title = root_element.GetElementsByTagName("TITLE").Item(i);
                    newCatalog.Add(title.InnerText);
                }
            }
            newCatalog.Sort();
            Assert.That(newCatalog[2], Is.EqualTo("Empire Burlesque"));
            Assert.That(newCatalog[3], Is.EqualTo("Greatest Hits"));
            Assert.That(newCatalog[6], Is.EqualTo("When a man loves a woman"));
            Assert.That(newCatalog[0], Is.EqualTo("1999 Grammy Nominees"));
            Assert.That(newCatalog[1], Is.EqualTo("Big Willie style"));
            Assert.That(newCatalog[4], Is.EqualTo("The dock of the bay"));
            Assert.That(newCatalog[5], Is.EqualTo("Unchain my heart"));
        }
    }
}
