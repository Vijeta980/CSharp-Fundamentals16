using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._09_FileHandling
{
    internal class FileStatic
    {
        public static void Run()
        {
            //var path = @"C:\Temp\test.txt";

            //if (File.Exists(path))
            //{
            //    var content = File.ReadAllText(path);
            //    Console.WriteLine(content); 
            //}
            //else
            //{
            //    File.WriteAllText(path, "File created by C#");
            //    Console.WriteLine("File Created");
            //}

            var directory = @"C:\Temp";
            var path = Path.Combine(directory, "text.txt");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (File.Exists(path))
            {
                var content=File.ReadAllText(path);
                Console.WriteLine(content);
            }
            else
            {
                File.WriteAllText(path, "File Created by C#");
                Console.WriteLine("File created");
            }
        }
    }
}
