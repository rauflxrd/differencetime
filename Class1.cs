using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceTime
{
    internal class Class1
    {
        internal static string DifferenceTime(string time1, string time2, string time3)
        {
            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

            int h3 = int.Parse(time3.Substring(0, 2));
            int m3 = int.Parse(time3.Substring(3, 2));
            int s3 = int.Parse(time3.Substring(6, 2));

            if (m1 < m2)
                m3 = 60 - (m2 - m1);
            if (h2 >= h1)
                h3 = h2 - h1;
            if (h2 < h1)
                h3 = 12 - (h1 - h2);
            string result = ($"{h3}:{m3}:{s3}");
            return result;
        }
    }
}
