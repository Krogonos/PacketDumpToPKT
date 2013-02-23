using System;
using System.IO;

namespace PacketDumpToPKT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get all PacketDump.xxxxxx files from current directory 
            string[] filePaths = Array.FindAll(Directory.GetFiles(Directory.GetCurrentDirectory(), "PacketDump.*"), x => !x.EndsWith(".pkt"));

            foreach (var filePath in filePaths)
            {
                Console.WriteLine("Parsing {0} ...", Path.GetFileName(filePath));
                Parser.ParseFile(filePath);
            }

            Console.WriteLine("\n Parsed all files, press a key to exit...");
            Console.ReadLine();

        }
    }
}
