using System;

namespace e_olimp_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            number = Convert.ToInt32((Console.ReadLine())).ToString();
            Console.WriteLine($"{number[0]} {number[1]}");
        }
    }
}
