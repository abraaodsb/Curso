using System;
using System.Globalization;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-mm-dd", CultureInfo.InvariantCulture );

            DateTime d2 = DateTime.ParseExact("2000-08-15 13:05:58", "dd/mm/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

           

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            
        }
    }
}

