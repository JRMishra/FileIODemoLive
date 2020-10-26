using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Json.Net;
using System.Xml.Serialization;

namespace fileIODemoLive
{
    class SerializationDemo
    {
        public static void BinarySerializationDemo()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\binser.txt";

            Demo demo = new Demo();
            demo.Id = 2;
            FileStream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, demo);
            stream.Close();
        }

        public static void BinaryDeserializationDemo()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\binser.txt";

            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo dserDemo = (Demo)formatter.Deserialize(stream);
            Console.WriteLine($"ID {dserDemo.Id}");
            stream.Close();
        }

        public static void JSONSerializationDemo()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Subham",
                Description = "Welcome to subham's json"
            };

            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }

        public static void JSONDeserializationDemo()
        {
            string json = "{ \"Name\":\"Subham\",\"Description\":\"Welcome to subham's json\"}";

        BlogSites bsObj2 = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj2.Name+"\n"+bsObj2.Description);
        }

        public static void XmlSerializedemo()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\xmlser.txt";

            XmlSerializer xmlser = new XmlSerializer(typeof(BlogSites));
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BlogSites blogSites = new BlogSites() 
            {
                Name = "Subham",
                Description = "Welcome to subham's json"
            };
            xmlser.Serialize(fileStream, blogSites);
            fileStream.Close();
        }

        public static void XmlDeSerializedemo()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\xmlser.txt";

            XmlSerializer xmlser = new XmlSerializer(typeof(BlogSites));
            FileStream fileStream = new FileStream(path, FileMode.Open);
            BlogSites blogSites = (BlogSites)xmlser.Deserialize(fileStream);
            Console.WriteLine(blogSites.Name+"\n"+blogSites.Description);
            fileStream.Close();
            
        }
    }
}
