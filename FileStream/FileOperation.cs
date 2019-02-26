using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    public static class FileOperation
    {
        public static void WriteToFile(string text)
        {
            string path = @"C:\\Users\\HasanBerkErgun\\Desktop\\FolderTest\\test.txt";
            if(!File.Exists(path))
            {
                File.Create(path).Close();
                using (StreamWriter streamWriter = File.CreateText(path))
                    streamWriter.WriteLine(text);
               
            }
            else
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                    streamWriter.WriteLine(text);                
            }

        }

        public static string ReadFromFile()
        {
            string path = @"C:\\Users\\HasanBerkErgun\\Desktop\\FolderTest\\test.txt";
            string text = File.ReadAllText(path); //Or Use Other Method
            return text;
        }
    }
}
