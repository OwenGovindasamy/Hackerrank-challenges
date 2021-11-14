using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WebScraper
{
    class SockMerchant
    {
        //int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

        public static int sockMerchant(int n, int[] ar)
        {

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (ar[i] != 0) 
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (ar[i] == ar[j])
                        {
                            count++;
                            ar[j] = 0;
                            break;
                        }
                    }
                }
            }

            return count;

        }

    }
}
