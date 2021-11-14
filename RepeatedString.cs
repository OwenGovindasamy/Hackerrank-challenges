using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WebScraper
{
    class RepeatedString
    {
        /*
       s =  adsdsfgfgdghg
       n = 26
        output = adsdsfgfgdghgadsdsfgfgdghg
       return occurunces of 'a' = 2
         */


        /*
    * Complete the 'repeatedString' function below.
    *
    * The function is expected to return a LONG_INTEGER.
    * The function accepts following parameters:
    *  1. STRING s
    *  2. LONG_INTEGER n
    */

        public static long repeatedString(string s, long n)
        {
            int i;
            int v = 0;
            var cnt = s.Length;
            StringBuilder builder = new StringBuilder();
            long internalCount = 0;


            for (i = 0; i <= n; ++i)
            {
                internalCount = builder.Length;

                if ((long)Convert.ToDouble(builder.Length) < n)
                {
                    _ = (i == cnt) ? i = 0 : i;

                    _ = (s[i].ToString() == "a") ? v++ : v;

                    _ = (internalCount < n) ? builder.Append(s[i]) : builder;

                }
            }
            return (long)Convert.ToDouble(v);
        }

        //public static long repeatedString1(string s, long n)
        //{
        //    //int i;
        //    int v = 0;
        //    //var cnt = s.Length;
        //    string str = string.Empty;
        //    long internalCount = 0;
        //    StringBuilder builder = new StringBuilder();

        //    for(int i = 0; Convert.ToInt64(builder.Length) < Convert.ToInt64(n);i++)
        //    {
        //        builder.Append(s);
        //        internalCount = builder.Length;
        //    }
        //    for(int j = 0; j < builder.Length; j++)
        //    {
        //        if (builder[j].ToString() == "g") v++;
        //    }
        //    return (long)Convert.ToDouble(builder.Length);
        //}
    }
}

