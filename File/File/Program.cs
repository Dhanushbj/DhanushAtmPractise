using System;
using System.IO;
using System.Text;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
           //string filePath = @"C:\Users\2000080634\Documents\Visual Studio 2019\filehandling\file1.txt";
            /* FileStream fileStream = new FileStream(filePath, FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("c# is OOPS language ");
            fileStream.Write(bdata, 0, bdata.Length);
            fileStream.Close();*/

           /* string contentFromFile;
            //read from file
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            using(StreamReader reader = new StreamReader(fileStream))
            {
                contentFromFile = reader.ReadToEnd();
            }
            Console.WriteLine(contentFromFile);*/

            string filePath = @"C:\Users\2000080634\Documents\Visual Studio 2019\filehandling\file2.txt";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create)) { }
           
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("enter the content to write in the file");
                string contentTowrite = Console.ReadLine();
                writer.Write(contentTowrite);
                writer.Flush();
            }
            

        }
    }
}
