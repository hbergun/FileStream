using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperation.WriteToFile("Ekleme"); 
            FileOperation.WriteToFile("Yaptım");
            Console.WriteLine("Successfully Written To File");
            Console.WriteLine(FileOperation.ReadFromFile());
            Console.WriteLine("Read From File Successfully");
            Console.ReadKey();

        }
    }
}
