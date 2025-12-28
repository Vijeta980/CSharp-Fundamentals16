using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals._09_FileHandling
{
    internal class FileInstance
    {
        public static void Run()
        {
            var fileInfo = new FileInfo("text.txt");

            //check if file exists
            if (!fileInfo.Exists)
            {
                using (var stream = fileInfo.Create())
                {
                    //file created
                }
                Console.WriteLine("File created");

            }
            if (fileInfo.Exists)
            {
                Console.WriteLine("File exists");
            }

            //Copy file
            fileInfo.CopyTo("copy.txt", true);

            //delete file
            //fileInfo.Delete();

            //properties
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.Extension);

            //Creation time
            Console.WriteLine(fileInfo.CreationTime);
        }
    }
}
