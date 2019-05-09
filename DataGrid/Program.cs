using System;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataGrid
{
    class Program
    {
        public List<Article> LoadArticleList
        {
            get
            {
                var articleList = new List<Article>();

                articleList.Add(new Article()
                {
                    ArticleNumber = "123",
                    ID = 112,
                    GS = "01"

                });

                articleList.Add(new Article()
                {
                    ArticleNumber = "231",
                    ID = 232,
                    GS = "04"

                });

                articleList.Add(new Article()
                {
                    ArticleNumber = "523",
                    ID = 312,
                    GS = "08"
                });

                return articleList;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var articles = new List<Article>();

            articles.Add(new Article ()
            {
                 ArticleNumber = "123456",
                 GS = "01",
                 ID = 2,
                 LastEdit = DateTime.Now
            });

            articles.Add(new Article()
            {
                ArticleNumber = "654321",
                GS = "22",
                ID = 21,
                 LastEdit = DateTime.Now
            });

             articles.Add ( new Article(){
                ArticleNumber = "111444",
                ID = 123,
                GS="44"
            });

            articles.Add (new Article(){
                ArticleNumber = "422555",
                ID = 123,
                GS="44"
            });

            //SerialDeserialize.Serialize(newArticle);
            //var deserial1 = SerialDeserialize.Deserialize<Article>();
 
            string xmlFile = @"/home/alkk/tutorials/cSharp/dotnet/DataGrid/XmlSaveMe.xml";
            string xmlSaveList = @"/home/alkk/tutorials/cSharp/dotnet/DataGrid/XmlSaveList.xml";

            var xmlManager = new XmlManager();
            xmlManager.SearchForPatternGetParent(xmlSaveList, "123456");
            //xmlManager.CreateXml(xmlFile);
            //xmlManager.LoadXml(xmlFile);
            //xmlManager.CheckAndAdd(xmlFile, "Article");

            //SerialDeserialize.SerializeList(articles, xmlSaveList);
            //var newList = SerialDeserialize.DeserializeList<Article>(xmlSaveList);
        }
    }
}
