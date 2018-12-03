using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace day_03
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
         int overlaps = 0;

         List<Rectangle> rects = new List<Rectangle>();

         foreach (string line in File.ReadAllLines("input.txt"))
         {
            string[] parts = line.Split(" ");

            Point location = new Point(int.Parse(parts[2].Trim(':').Split(",")[0]), int.Parse(parts[2].Trim(':').Split(",")[1]));
            Size size = new Size(int.Parse(parts[3].Split("x")[0]), int.Parse(parts[3].Split("x")[1]));

            Rectangle rect = new Rectangle(location, size);

            rects.Add(rect);
         }

         for (int x = rects.Min(p => p.Left); x < rects.Max(p => p.Right); x++)
         {
            for (int y = rects.Min(p => p.Top); y < rects.Max(p => p.Bottom); y++)
            {
               int intersections = 0;

               foreach (Rectangle r in rects)
               {
                  if (r.IntersectsWith(new Rectangle(x, y, 1, 1)))
                  {
                     intersections++;
                  }

                  if (intersections > 1)
                  {
                     overlaps++;
                     break;
                  }
               }
            }
         }

         Console.WriteLine(overlaps);
      }

      private static void part2()
      {
         List<(Rectangle, int id)> rects = new List<(Rectangle, int)>();

         foreach (string line in File.ReadAllLines("input.txt"))
         {
            string[] parts = line.Split(" ");

            int id = int.Parse(parts[0].Substring(1));
            Point location = new Point(int.Parse(parts[2].Trim(':').Split(",")[0]), int.Parse(parts[2].Trim(':').Split(",")[1]));
            Size size = new Size(int.Parse(parts[3].Split("x")[0]), int.Parse(parts[3].Split("x")[1]));

            Rectangle rect = new Rectangle(location, size);

            rects.Add((rect, id));
         }

         foreach ((Rectangle rect, int id) rOuter in rects)
         {
            bool intersection = false;
            foreach ((Rectangle rect, int id) rInner in rects)
            {
               if (rOuter.rect != rInner.rect && rInner.rect.IntersectsWith(rOuter.rect))
               {
                  intersection = true;
                  break;
               }
            }

            if (!intersection)
            {
               Console.WriteLine(rOuter.id);
               break;
            }
         }
      }
   }
}
