using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using System.Linq;
using static System.Console;

namespace DataGrid
{
    public class XmlManager
    {
        //const string xmlFile = @"/home/alkk/tutorials/cSharp/dotnet/DataGrid/XmlSaveMe.xml";

        public void LoadXml(string xmlFile)
        {
            XDocument xDoc = XDocument.Load(xmlFile);
            WriteLine(xDoc);
        }

        public void CreateXml(string xmlFile)
        {
            XDocument xDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Dokument enthält Personen"),
                new XElement("Articles",
                    new XElement("Article",
                        new XElement("ArticleNumber", "666333"),
                        new XElement("GS", "05"),
                        new XElement("ID", "44")
                    )
                )
            );

            xDoc.Save(xmlFile);
        }

        public void CheckAndAdd(string xmlFile, string searchPattern)
        {
            XDocument xDoc = XDocument.Load(xmlFile);
            XElement root = XElement.Load(xmlFile);
            var elements = root.Elements(searchPattern);

            foreach(var item in elements)
            {
                if(item.Value == "05")
                    WriteLine(item);
            }
        }

        public void SearchForPatternGetParent(string xmlFile, string searchPattern)
        {
            XElement root = XElement.Load(xmlFile);
            XElement element = root.Descendants("Article")
                                .Where(pers => (string)pers == searchPattern)
                                .First();

            XElement parent = element.Parent;
            WriteLine($"Searchi for {searchPattern} finished. Results: ");
            WriteLine($"element: {element}");
            WriteLine($"parent: {parent}");
        }
    }
}