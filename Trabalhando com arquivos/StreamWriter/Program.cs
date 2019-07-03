using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string sourceTarget = @"c:\temp\file2.txt";
       
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(sourceTarget))
                {
                    foreach (string line in lines)
                    {

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
