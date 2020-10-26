using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace fileIODemoLive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //FileExists();
            //ReadAllLines();
            //ReadAllText();
            //FileCopy();
            //ReadFileFromStreamReader();

            //SerializationDemo.BinarySerializationDemo();
            //SerializationDemo.BinaryDeserializationDemo();

            //SerializationDemo.JSONSerializationDemo();
            //SerializationDemo.JSONDeserializationDemo();

            //SerializationDemo.XmlSerializedemo();
            SerializationDemo.XmlDeSerializedemo();
        }

        public static void FileExists()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\test.txt";
            if(File.Exists(path))
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File doesn't Exist");
        }

        public static void ReadAllLines()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\test.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }

        public static void ReadAllText()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\test.txt";
            if (File.Exists(path))
            {
                string texts = File.ReadAllText(path);
                Console.WriteLine(texts);
            }
            else
            {
                Console.WriteLine("File absent");
            }
        }

        public static void FileCopy()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\test.txt";
            string copyPath = @"C:\Users\user\source\repos\fileIODemoLive\example.txt";

            File.Copy(path, copyPath);
        }

        public static void DeleteFile()
        {
            
            string copyPath = @"C:\Users\user\source\repos\fileIODemoLive\example.txt";
            if (File.Exists(copyPath))
            {
                File.Delete(copyPath);
            }
        }

        public static void ReadFileFromStreamReader()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\test.txt";
            if (File.Exists(path))
            {
                using(StreamReader stream = File.OpenText(path))
                {
                    String fileData = "";
                    while((fileData=stream.ReadLine())!=null)
                    {
                        Console.WriteLine(fileData);
                    }
                }

            }
            else
            {
                Console.WriteLine("File absent");
            }
        }

        public static void WriteFileFromStreamWriter()
        {
            string path = @"C:\Users\user\source\repos\fileIODemoLive\test.txt";
            if (File.Exists(path))
            {
                using (StreamWriter stream = File.AppendText(path))
                {
                    stream.WriteLine("Another line in file");
                    stream.Flush();
                }
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("File absent");
            }
        }


    }
}
