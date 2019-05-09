using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace DataGrid
{
    public class SerialDeserialize
    {
        const string xmlSave = @"/home/alkk/tutorials/cSharp/dotnet/DataGrid/XmlSave.xml";
        const string xmlSaveList = @"/home/alkk/tutorials/cSharp/dotnet/DataGrid/XmlSaveList.xml";

        //public static void Serialize(object obj)
        public static void Serialize<T>(T obj)
        {
            FileStream stream;
            XmlSerializer serializer;
            stream = new FileStream(xmlSave, FileMode.Append);
            serializer = new XmlSerializer(typeof(T));

            serializer.Serialize(stream, obj);
            stream.Close();
            System.Console.WriteLine($"Serialization fin.");
        }

        public static T Deserialize<T>()
        {
            FileStream stream;
            XmlSerializer serializer;
            serializer = new XmlSerializer(typeof(T));

            stream = new FileStream(xmlSave, FileMode.Open);
            return (T)serializer.Deserialize(stream);
        }

        public static void SerializeList<T>(List<T> list, string xmlFile)
        {
            FileStream stream = new FileStream(xmlFile, FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            serializer.Serialize(stream, list);
            stream.Close();
            System.Console.WriteLine($"Serialize List to {xmlFile} finished.");
        }

        public static List<T> DeserializeList<T>(string xmlFile)
        {
            FileStream stream = new FileStream(xmlFile, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            List<T> list = (List<T>)serializer.Deserialize(stream);
            System.Console.WriteLine($"DeSerialize  finished: {xmlFile}");
            return list;
        }
    }
}