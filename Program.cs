using System;
using System.Collections.Generic;
using System.IO;

namespace WebScraper
{
    class Program
    {
        public static void Main(string[] args)
        {
            RepeatedString.repeatedString("aba", 10);
            //Xmas.ChristmasTree();
            TextWriter textWriter = new StreamWriter(@"C:\Users\Dean\Desktop\StreamWriter.txt", true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Valley.countingValleys(steps, path);

            textWriter.WriteLine(result);
            
            textWriter.Flush();
            textWriter.Close();
        }
} 
}
