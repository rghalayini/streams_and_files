using System;
using System.IO;
using System.Text;

namespace Streams_and_files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the name of the text file you wish to open:");
            string filename = Console.ReadLine();

            StreamReader sr = new StreamReader(filename);

            string line;

            int counter = 1;
            StringBuilder sb = new StringBuilder();

            while ((line = sr.ReadLine()) != null)
            {
                var lineOutput = "Line " + counter++ + ": " + line + "\r\n";
                Console.WriteLine(lineOutput);

                sb.Append(lineOutput);
            }


            sr.Close();
            Console.WriteLine();
            Console.ReadLine();

            StreamWriter sw = File.AppendText("output.txt");
            sw.Write(sb);
            sw.Close();


        }
    }
}
