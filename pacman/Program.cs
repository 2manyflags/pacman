using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pacman
{
    class Program
    {
        static void Main()
        {
            char [,] map = new char[20,30];
            int counter=0;
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\DSU\\source\\repos\\map.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    map[counter,0] = line.Split(',').ToArray();
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            finally
            {
                Console.WriteLine("File read successfully");
            }
            Console.Read();
        }
    }
}
