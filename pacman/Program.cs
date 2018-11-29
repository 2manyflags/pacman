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
            int y=0;
            int x = 0;
            StreamReader reader;
            reader = new StreamReader("C:\\Users\\DSU\\source\\repos\\map.txt");
            while (!reader.EndOfStream)
            {
                ch = (char)reader.Read();
                map[x, y] = ch;
                if (ch == '#' || ch == ' ')
                {
                    if (x == 19 && y == 29)
                        break;
                    y++;
                    if (y == 30)
                    {
                        x++;
                        y = 0;
                    }
                }
            }
            reader.Close();
            Console.Write("        Welcome to\n");
            Console.Write("     Ethan Masching's\n");
            Console.Write("         game of\n");
            Console.Write("         PACMAN!\n");
            Console.Write("    Use W A S D to move\n");
            Console.Write("     Press P to exit\n");
            int hor = 1;
            int ver = 1;
            var key= Console.ReadKey();
            Console.Write("\n\n\n\n\n\n\n\n");
            map[hor, ver] = 'O';
            while (key.Key != ConsoleKey.P)
            {
                if (key.Key == ConsoleKey.W)
                {
                    if (map[hor-1, ver]==' ')
                    {
                        map[hor, ver] = ' ';
                        map[hor-1, ver] = 'O';
                        hor--;
                    }
                }
                else if (key.Key == ConsoleKey.S)
                {
                    if (map[hor+1, ver]==' ')
                    {
                        map[hor, ver] = ' ';
                        map[hor+1, ver] = 'O';
                        hor++;
                    }
                }
                else if (key.Key == ConsoleKey.A)
                {
                    if (map[hor, ver-1] == ' ')
                    {
                        map[hor, ver] = ' ';
                        map[hor, ver-1] = 'O';
                        ver--;
                    }
                }
                else if (key.Key == ConsoleKey.D)
                {
                    if (map[hor, ver+1] == ' ')
                    {
                        map[hor, ver] = ' ';
                        map[hor, ver+1] = 'O';
                        ver++;
                    }
                }
                for (x = 0; x < 20; x++)
                {
                    for (y = 0; y < 30; y++)
                    {
                        Console.Write(map[x, y]);
                    }
                    Console.Write("\n");
                }
                key = Console.ReadKey();
                Console.Write("\n\n\n\n\n\n\n\n\n");
            }
        }
    }
}
