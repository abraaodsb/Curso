using Curso.Enums;
using System;
using Curso.Entities;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}

