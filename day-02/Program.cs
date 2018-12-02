using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace day_02
{
   class Program
   {
      static void Main(string[] args)
      {
         part1();
         part2();

         Console.Read();
      }

      private static void part1()
      {
         long twoTimes = 0;
         long threeTimes = 0;

         foreach (string line in File.ReadAllLines("input.txt"))
         {
            List<int> counts = line.ToCharArray().GroupBy(c => c).Select(grp => grp.Count()).ToList();

            if (counts.Contains(2))
            {
               twoTimes++;
            }

            if (counts.Contains(3))
            {
               threeTimes++;
            }
         }

         Console.WriteLine(twoTimes * threeTimes);
      }

      private static void part2()
      {
         List<List<char>> ids = new List<List<char>>();

         string similarId = null;
         foreach (string line in File.ReadAllLines("input.txt"))
         {
            if ((similarId = CheckSimilar(line.ToList(), ids)) != null)
            {
               break;
            }
            else
            {
               ids.Add(line.ToList());
            }
         }

         Console.WriteLine(similarId);
      }

      private static string CheckSimilar(List<char> currentId, List<List<char>> ids)
      {
         string ret = null;
         foreach (List<char> id in ids)
         {
            string tmp = "";
            int diff = 0;

            for (int i = 0; i < id.Count; i++)
            {
               if (id[i] != currentId[i])
                  diff++;
               else
                  tmp += id[i];

               if (diff > 1)
                  break;
            }

            if (diff == 1)
            {
               ret = tmp;
               break;
            }
         }

         return ret;
      }
   }
}
