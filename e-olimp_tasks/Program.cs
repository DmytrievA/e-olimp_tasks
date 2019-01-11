using System;

namespace e_olimp_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, r1, r2, dist;
            string[] values = (Console.ReadLine()).Split(' ');
            x1 = Convert.ToDouble(values[0]);
            y1 = Convert.ToDouble(values[1]);
            r1 = Convert.ToDouble(values[2]);

            x2 = Convert.ToDouble(values[3]);
            y2 = Convert.ToDouble(values[4]);
            r2 = Convert.ToDouble(values[5]);

            dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            
            //полностью накладываются друг на друга
            if (dist == 0.0 && r1 == r2)
            {
                Console.WriteLine("-1");
            }
            else
            //одна точка если друг в друге или если не в друг друге
            if (dist + Math.Min(r1, r2) == Math.Max(r1, r2) || dist == (r1 + r2))
            {
                Console.WriteLine("1");
            } else
            if (dist > (r1 + r2) || dist + Math.Min(r1, r2) < Math.Max(r1, r2))
            {
                Console.WriteLine("0");
            } else
            if (dist < (r1 + r2))
            {
                Console.WriteLine("2");
            } 
            Console.ReadKey();
        }
    }
}
