using System;
using System.Collections.Generic;
using System.IO;

namespace Day_01_Part2
{
   class Program
   {
      static void Main(string[] args)
      {
         HashSet<int> freqs = new HashSet<int>();

         int freq = 0;

         freqs.Add(freq);

         bool found = false;
         while (!found)
         {
            foreach (string line in File.ReadLines("input.txt"))
            {
               freq += int.Parse(line);

               if (freqs.Contains(freq))
               {
                  Console.WriteLine(freq);
                  found = true;
                  break;
               }
               else
               {
                  freqs.Add(freq);
               }
            }
         }

         Console.Read();
      }
   }
}
