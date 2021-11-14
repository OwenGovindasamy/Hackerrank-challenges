using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebScraper
{
    class Result
    {

        public static long getMinCost(List<int> crew_id, List<int> job_id)
        {
            var ascendingCrew_id = crew_id.OrderBy(i => i);

            var ascendingJob_id = job_id.OrderBy(i => i);

            List<int> Sorted = new List<int>();

            foreach (var i in ascendingCrew_id)
            {
                foreach (var c in ascendingJob_id)
                {
                    var answer = i / c;
                    if (answer >= i && answer >= c)
                    Sorted.Add(answer);
                }
            }

            return Sorted.Count();
        }


    }
}
