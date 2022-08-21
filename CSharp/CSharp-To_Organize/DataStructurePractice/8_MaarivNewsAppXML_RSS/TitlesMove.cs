using System;
using System.Windows.Forms;
using System.Xml;

namespace MaarivNewsApp
{
    public partial class TitlesMove : Form
    {

        public static string site = @"https://www.maariv.co.il/Rss/RssFeedsMivzakiChadashot";
        public static XmlDocument Doc = new XmlDocument();
        public static XmlNodeList? List;
        public static int counter = 0;
        public static int listSize = 0;
        public TitlesMove()
        {
            InitializeComponent();
            Doc.Load(site);
            List = Doc.SelectNodes(@"//item/title");
            if (List != null && List?.Count > 0)
            {
                txtTitle.Text = List[0]?.InnerText.ToString();
                listSize = List.Count;
            }

        }
        private void Form1_Load(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (counter - 1 >= 0) txtTitle.Text = List?[--counter].InnerText.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (counter + 1 < listSize) txtTitle.Text = List?[++counter].InnerText.ToString();
        }
    }
}
