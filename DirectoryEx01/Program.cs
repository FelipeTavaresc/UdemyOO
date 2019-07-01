using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(@"c:\temp\newfolder");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
