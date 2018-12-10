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
            User user = new User();
            Ghost1 ghost1 = new Ghost1();
            Ghost2 ghost2 = new Ghost2();
            Ghost3 ghost3 = new Ghost3();
            Ghost4 ghost4 = new Ghost4();
            Console.Write("        Welcome to\n");
            Console.Write("     Ethan Masching's\n");
            Console.Write("         game of\n");
            Console.Write("         PACMAN!\n");
            Console.Write("    Use W A S D to move\n");
            Console.Write("     Press P to exit\n");
            int hor = 1;
            int ver = 1;
            int ghhor1 = 4;
            int ghver1 = 4;
            int ghhor2 = 10;
            int ghver2 = 12;
            int ghhor3 = 2;
            int ghver3 = 6;
            int ghhor4 = 8;
            int ghver4 = 22;
            int score = 0;
            bool onstar1 = false;
            bool onstar2 = false;
            bool onstar3 = false;
            bool onstar4 = false;
            bool onchar1 = false;
            bool onchar2 = false;
            bool onchar3 = false;
            bool onchar4 = false;
            char ghmove;
            var key= Console.ReadKey();
            Console.Write("\n\n\n\n\n\n\n\n");
            map[hor, ver] = 'O';
            map[ghhor1, ghver1] = '@';
            map[ghhor2, ghver2] = '@';
            map[ghhor3, ghver3] = '@';
            map[ghhor4, ghver4] = '@';
            while (key.Key != ConsoleKey.P)
            {
                if (user.isalive() == true)
                {
                    if (key.Key == ConsoleKey.W)
                    {
                        if (map[hor - 1, ver] != '#')
                        {
                            if (map[hor-1, ver] == ' ')
                                score=score+1;
                            map[hor, ver] = '*';
                            map[hor - 1, ver] = 'O';
                            hor--;
                        }
                    }
                    else if (key.Key == ConsoleKey.S)
                    {
                        if (map[hor + 1, ver] != '#')
                        {
                            if (map[hor+1, ver] == ' ')
                                score=score+1;
                            map[hor, ver] = '*';
                            map[hor + 1, ver] = 'O';
                            hor++;
                        }
                    }
                    else if (key.Key == ConsoleKey.A)
                    {
                        if (map[hor, ver - 1] != '#')
                        {
                            if (map[hor, ver-1] == ' ')
                                score=score+1;
                            map[hor, ver] = '*';
                            map[hor, ver - 1] = 'O';
                            ver--;
                        }
                    }
                    else if (key.Key == ConsoleKey.D)
                    {
                        if (map[hor, ver + 1] != '#')
                        {
                            if (map[hor, ver+1] == ' ')
                                score=score+1;
                            map[hor, ver] = '*';
                            map[hor, ver + 1] = 'O';
                            ver++;
                        }
                    }
                }
                else
                {
                    break;
                }
                if (ghost1.isalive() == true )
                {
                    ghmove = ghost1.move();
                    if (ghmove == 'W')
                    {
                        if (map[ghhor1 - 1, ghver1] != '#')
                        {
                            if (map[ghhor1 - 1, ghver1] == 'O')
                                user.kill();
                            if (map[ghhor1, ghver1] == 'O')
                                onchar1 = true;
                            else
                                onchar1 = false;
                            if (onstar1 == false)
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = ' ';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            else
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = '*';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            if (map[ghhor1 - 1, ghver1] == '*')
                                onstar1 = true;
                            else
                                onstar1 = false;
                            map[ghhor1 - 1, ghver1] = '@';
                            ghhor1--;
                        }
                    }
                    else if (ghmove == 'S')
                    {
                        if (map[ghhor1 + 1, ghver1] != '#')
                        {
                            if (map[ghhor1 + 1, ghver1] == 'O')
                                user.kill();
                            if (map[ghhor1, ghver1] == 'O')
                                onchar1 = true;
                            else
                                onchar1 = false;
                            if (onstar1==false)
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = ' ';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            else
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = '*';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            if (map[ghhor1 + 1, ghver1] == '*')
                                onstar1 = true;
                            else
                                onstar1 = false;
                            map[ghhor1 + 1, ghver1] = '@';
                            ghhor1++;
                        }
                    }
                    else if (ghmove == 'D')
                    {
                        if (map[ghhor1, ghver1 + 1] != '#')
                        {
                            if (map[ghhor1, ghver1 + 1] == 'O')
                                user.kill();
                            if (map[ghhor1, ghver1] == 'O')
                                onchar1 = true;
                            else
                                onchar1 = false;
                            if (onstar1 == false)
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = ' ';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            else
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = '*';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            if (map[ghhor1, ghver1 + 1] == '*')
                                onstar1 = true;
                            else
                                onstar1 = false;
                            map[ghhor1, ghver1 + 1] = '@';
                            ghver1++;
                        }
                    }
                    else
                    {
                        if (map[ghhor1, ghver1 - 1] != '#')
                        {
                            if (map[ghhor1, ghver1 -1] == 'O')
                                user.kill();
                            if (map[ghhor1, ghver1] == 'O')
                                onchar1 = true;
                            else
                                onchar1 = false;
                            if (onstar1==false)
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = ' ';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            else
                                if (onchar1 == false)
                                    map[ghhor1, ghver1] = '*';
                                else
                                    map[ghhor1, ghver1] = 'O';
                            if (map[ghhor1, ghver1 - 1] == '*')
                                onstar1 = true;
                            else
                                onstar1 = false;
                            map[ghhor1, ghver1 - 1] = '@';
                            ghver1--;
                        }
                    }
                }
                if (ghost2.isalive() == true)
                {
                    ghmove = ghost2.move();
                    if (ghmove == 'W')
                    {
                        if (map[ghhor2 - 1, ghver2] != '#')
                        {
                            if (map[ghhor2 - 1, ghver2] == 'O')
                                user.kill();
                            if (map[ghhor2, ghver2] == 'O')
                                onchar2 = true;
                            else
                                onchar2 = false;
                            if (onstar2 == false)
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = ' ';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            else
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = '*';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            if (map[ghhor2 - 1, ghver2] == '*')
                                onstar2 = true;
                            else
                                onstar2 = false;
                            map[ghhor2 - 1, ghver2] = '@';
                            ghhor2--;
                        }
                    }
                    else if (ghmove == 'S')
                    {
                        if (map[ghhor2 + 1, ghver2] != '#')
                        {
                            if (map[ghhor2 + 1, ghver2] == 'O')
                                user.kill();
                            if (map[ghhor2, ghver2] == 'O')
                                onchar2 = true;
                            else
                                onchar2 = false;
                            if (onstar2 == false)
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = ' ';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            else
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = '*';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            if (map[ghhor2 + 1, ghver2] == '*')
                                onstar2 = true;
                            else
                                onstar2 = false;
                            map[ghhor2 + 1, ghver2] = '@';
                            ghhor2++;
                        }
                    }
                    else if (ghmove == 'D')
                    {
                        if (map[ghhor2, ghver2 + 1] != '#')
                        {
                            if (map[ghhor2, ghver2 + 1] == 'O')
                                user.kill();
                            if (map[ghhor2, ghver2] == 'O')
                                onchar2 = true;
                            else
                                onchar2 = false;
                            if (onstar2 == false)
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = ' ';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            else
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = '*';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            if (map[ghhor2, ghver2 + 1] == '*')
                                onstar2 = true;
                            else
                                onstar2 = false;
                            map[ghhor2, ghver2 + 1] = '@';
                            ghver2++;
                        }
                    }
                    else
                    {
                        if (map[ghhor2, ghver2 - 1] != '#')
                        {
                            if (map[ghhor2, ghver2 - 1] == 'O')
                                user.kill();
                            if (map[ghhor2, ghver2] == 'O')
                                onchar2 = true;
                            else
                                onchar2 = false;
                            if (onstar2 == false)
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = ' ';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            else
                                if (onchar2 == false)
                                    map[ghhor2, ghver2] = '*';
                                else
                                    map[ghhor2, ghver2] = 'O';
                            if (map[ghhor2, ghver2 - 1] == '*')
                                onstar2 = true;
                            else
                                onstar2 = false;
                            map[ghhor2, ghver2 - 1] = '@';
                            ghver2--;
                        }
                    }
                }
                if (ghost3.isalive() == true)
                {
                    ghmove = ghost3.move();
                    if (ghmove == 'W')
                    {
                        if (map[ghhor3 - 1, ghver3] != '#')
                        {
                            if (map[ghhor3 - 1, ghver3] == 'O')
                                user.kill();
                            if (map[ghhor3, ghver3] == 'O')
                                onchar3 = true;
                            else
                                onchar3 = false;
                            if (onstar3 == false)
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = ' ';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            else
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = '*';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            if (map[ghhor3 - 1, ghver3] == '*')
                                onstar3 = true;
                            else
                                onstar3 = false;
                            map[ghhor3 - 1, ghver3] = '@';
                            ghhor3--;
                        }
                    }
                    else if (ghmove == 'S')
                    {
                        if (map[ghhor3 + 1, ghver3] != '#')
                        {
                            if (map[ghhor3 + 1, ghver3] == 'O')
                                user.kill();
                            if (map[ghhor3, ghver3] == 'O')
                                onchar3 = true;
                            else
                                onchar3 = false;
                            if (onstar3 == false)
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = ' ';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            else
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = '*';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            if (map[ghhor3 + 1, ghver3] == '*')
                                onstar3 = true;
                            else
                                onstar3 = false;
                            map[ghhor3 + 1, ghver3] = '@';
                            ghhor3++;
                        }
                    }
                    else if (ghmove == 'D')
                    {
                        if (map[ghhor3, ghver3 + 1] != '#')
                        {
                            if (map[ghhor3, ghver3 + 1] == 'O')
                                user.kill();
                            if (map[ghhor3, ghver3] == 'O')
                                onchar3 = true;
                            else
                                onchar3 = false;
                            if (onstar3 == false)
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = ' ';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            else
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = '*';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            if (map[ghhor3, ghver3 + 1] == '*')
                                onstar3 = true;
                            else
                                onstar3 = false;
                            map[ghhor3, ghver3 + 1] = '@';
                            ghver3++;
                        }
                    }
                    else
                    {
                        if (map[ghhor3, ghver3 - 1] != '#')
                        {
                            if (map[ghhor3, ghver3 - 1] == 'O')
                                user.kill();
                            if (map[ghhor3, ghver3] == 'O')
                                onchar3 = true;
                            else
                                onchar3 = false;
                            if (onstar3 == false)
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = ' ';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            else
                                if (onchar3 == false)
                                    map[ghhor3, ghver3] = '*';
                                else
                                    map[ghhor3, ghver3] = 'O';
                            if (map[ghhor3, ghver3 - 1] == '*')
                                onstar3 = true;
                            else
                                onstar3 = false;
                            map[ghhor3, ghver3 - 1] = '@';
                            ghver3--;
                        }
                    }
                }
                if (ghost4.isalive() == true)
                {
                    ghmove = ghost4.move();
                    if (ghmove == 'W')
                    {
                        if (map[ghhor4 - 1, ghver4] != '#')
                        {
                            if (map[ghhor4 - 1, ghver4] == 'O')
                                user.kill();
                            if (map[ghhor4, ghver4] == 'O')
                                onchar4 = true;
                            else
                                onchar4 = false;
                            if (onstar4 == false)
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = ' ';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            else
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = '*';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            if (map[ghhor4 - 1, ghver4] == '*')
                                onstar4 = true;
                            else
                                onstar4 = false;
                            map[ghhor4 - 1, ghver4] = '@';
                            ghhor4--;
                        }
                    }
                    else if (ghmove == 'S')
                    {
                        if (map[ghhor4 + 1, ghver4] != '#')
                        {
                            if (map[ghhor4 + 1, ghver4] == 'O')
                                user.kill();
                            if (map[ghhor4, ghver4] == 'O')
                                onchar4 = true;
                            else
                                onchar4 = false;
                            if (onstar4 == false)
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = ' ';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            else
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = '*';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            if (map[ghhor4 + 1, ghver4] == '*')
                                onstar4 = true;
                            else
                                onstar4 = false;
                            map[ghhor4 + 1, ghver4] = '@';
                            ghhor4++;
                        }
                    }
                    else if (ghmove == 'D')
                    {
                        if (map[ghhor4, ghver4 + 1] != '#')
                        {
                            if (map[ghhor4, ghver4 + 1] == 'O')
                                user.kill();
                            if (map[ghhor4, ghver4] == 'O')
                                onchar4 = true;
                            else
                                onchar4 = false;
                            if (onstar4 == false)
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = ' ';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            else
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = '*';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            if (map[ghhor4, ghver4 + 1] == '*')
                                onstar4 = true;
                            else
                                onstar4 = false;
                            map[ghhor4, ghver4 + 1] = '@';
                            ghver4++;
                        }
                    }
                    else
                    {
                        if (map[ghhor4, ghver4 - 1] != '#')
                        {
                            if (map[ghhor4, ghver4 - 1] == 'O')
                                user.kill();
                            if (map[ghhor4, ghver4] == 'O')
                                onchar4 = true;
                            else
                                onchar4 = false;
                            if (onstar4 == false)
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = ' ';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            else
                                if (onchar4 == false)
                                    map[ghhor4, ghver4] = '*';
                                else
                                    map[ghhor4, ghver4] = 'O';
                            if (map[ghhor4, ghver4 - 1] == '*')
                                onstar4 = true;
                            else
                                onstar4 = false;
                            map[ghhor4, ghver4 - 1] = '@';
                            ghver4--;
                        }
                    }
                }
                if (hor == ghhor1 && ver == ghver1)
                {
                    user.kill();
                    map[hor, ver] = '@';
                }
                if (hor == ghhor2 && ver == ghver2)
                {
                    user.kill();
                    map[hor, ver] = '@';
                }
                if (hor == ghhor3 && ver == ghver3)
                {
                    user.kill();
                    map[hor, ver] = '@';
                }
                if (hor == ghhor4 && ver == ghver4)
                {
                    user.kill();
                    map[hor, ver] = '@';
                }
                Console.Write("Score: " + score + "\n");
                for (x = 0; x < 20; x++)
                {
                    for (y = 0; y < 30; y++)
                    {
                        Console.Write(map[x, y]);
                    }
                    Console.Write("\n");
                }
                if (user.isalive() == false)
                {
                    Console.Write("Sorry, you've died. Game Over\n");
                    Console.Write("Your score is: " + score + "\n");
                }
                key = Console.ReadKey();
                Console.Write("\n\n\n\n\n\n\n\n");
            }
        }
    }
}
