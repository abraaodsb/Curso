using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000,10,15);

            DateTime d2 = new DateTime(2000,10,18);


            TimeSpan t = d2.Subtract(d1);

            Console.WriteLine(t);
        }
    }
}

