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
            char ch;
            int tchar = 0;
            int y=0;
            int x = 0;
            StreamReader reader;
            reader = new StreamReader("C:\\Users\\DSU\\source\\repos\\map.txt");
            while (!reader.EndOfStream)
            {
                ch = (char)reader.Read();
                Console.Write(ch);
                y++;
                if (y==30)
                {
                    x++;
                    y = 0;
                }
                map[x, y] = ch;
                tchar++;
            }
            reader.Close();
            Console.Read();
        }
    }
}
