using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WebScraper
{
    class Valley
    {
        //needs to return the number of valleys
        //start 16:30
        /*
         [8]
         [UDDDUDUU]
         [ANSWER = 1]
        _/\      _
           \    /
            \/\/

         */
        public static int countingValleys(int n, string s)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    if (++sum == 0)
                    {
                        count++;
                    }
                }
                else sum--;
            }
            return count;
        }
    }
}
