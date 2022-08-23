using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1study
{
    public struct XMLPractice
    {
        public static void Run() 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"https://www.globes.co.il/webservice/rss/rssfeeder.asmx/FeederNode?iID=1225");


        //    string str = "<a><b value=\"adfad\">dafadf</b></a>";
        //    doc.LoadXml(str);

            var allAuthor = doc.ChildNodes[1].SelectNodes(@"//item/author");
            for (int i = 0; i < allAuthor.Count; i++)  //הדפס את כל הכתבות
            {
                XmlNode n = allAuthor[i];
                string title = n.InnerText;
            }

            var allTitles = doc.ChildNodes[1].SelectNodes(@"//item/title");
            for (int i = 0; i < allTitles.Count; i++)  //הדפס את כל הכתבות
            {
                XmlNode n = allTitles[i];
                string title = n.InnerText;
            }


            for (int i = 0; i < 8; i++)  //8 כתבות אחרונות
            {
                string title = doc.ChildNodes[1].ChildNodes[0].ChildNodes[9 + i].InnerText;
            }
            XmlDocument titleNomber2 = new XmlDocument();
            titleNomber2.LoadXml(doc.ChildNodes[1].ChildNodes[0].ChildNodes[10].OuterXml);
            Console.WriteLine(titleNomber2.InnerText);
        }
    }
}
