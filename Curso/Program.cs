using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}

