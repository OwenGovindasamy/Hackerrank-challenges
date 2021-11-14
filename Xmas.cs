using System;
using System.Collections.Generic;
using System.Text;

namespace WebScraper
{
    class Xmas
    {
        //TODO  REFACTOR CODE 
        public static void ChristmasTree()
        {
            int counter = 0;

            for (int i = 0; i <= counter; i++)
            {
                for (int a = 0; a <= 7; a++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");

                for (int j = 0; j <= 2; j++)
                {
                    if (j == 0)
                    {
                        for (int p = 0; p < 7; p++)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("*");
                }

                Console.WriteLine(" ");

                for (int j = 0; j <= 4; j++)
                {
                    if (j == 0)
                    {
                        for (int p = 0; p < 6; p++)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("*");
                }

                Console.WriteLine(" ");

                for (int j = 0; j <= 6; j++)
                {
                    if (j == 0)
                    {
                        for (int p = 0; p < 5; p++)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("*");
                }

                Console.WriteLine(" ");

                for (int a = 0; a <= 7; a++)
                {
                    Console.Write(" ");
                }

                for(int y = 0; y < 3; y++)
                {
                    if(y == 0)
                    {
                        Console.WriteLine("*");
                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
