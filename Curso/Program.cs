using System;
using Curso.Entities;
using System.Globalization;
using System.IO;
using Curso;
using Curso.Entities.Services;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Program antigo
            //try
            //{
            //    Console.Write("Room number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    Console.Write("Check-in date (dd/MM/yyyy):");
            //    DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy):");
            //    DateTime checkOut = DateTime.Parse(Console.ReadLine());



            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation:");
            //    Console.Write("Check-in date (dd/MM/yyyy):");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-Out date (dd/MM/yyyy):");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    reservation.updateDates(checkIn, checkOut);
            //    Console.WriteLine("Reservatiom: " + reservation);

            //}
            //catch (CannotUnloadAppDomainException e)
            //{
            //    Console.WriteLine("Error in reservation: " + e.Message);
            //}

            #endregion

            #region File/FileInfo/Exception
            //string path = @"c:\temp\myfolder\file1.txt";

            //Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            //Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            //Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            //Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            #endregion

            #region 
            // Console.WriteLine("Enter rental data");
            //Console.WriteLine("Car model: ");
            //string model = Console.ReadLine();
            // Console.WriteLine("Pickup (dd/mm/yyyy hh:ss): ");
            //DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy HH:mm", CultureInfo.InvariantCulture );
            //Console.WriteLine("Return (dd/mm/yyyy hh:ss): ");
            //DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy HH:mm", CultureInfo.InvariantCulture);

            //Console.WriteLine("Enter price per hour: ");
            //double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Enter price per Day: ");
            //double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            //RentalService rentalService = new RentalService(hour, day, new BrazilTaxService ());

            //rentalService.ProcessInvoce(carRental);

            //Console.WriteLine("Invoice: ");
            //Console.WriteLine(carRental.Invoice);

            #endregion
            //PrintService printService = new PrintService();

            //Console.Write("How many values? ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i=0; i<n; i++)
            {
                //  int x = int.Parse(Console.ReadLine());
                //printService.AddValue(x);
            }

            //printService.Print();
            //Console.WriteLine("First: " + printService .First ());
            #region 

            #endregion
            #region 

            // Client a = new Client { Name = "Maria", Email = " maria@gmail.com"};
            //Client b = new Client { Name = "Alex", Email = " alex@gmail.com"};

            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a == b);
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            #endregion
            #region 
            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            //SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            //SortedSet<int> c = new SortedSet<int>(a);
            //c.UnionWith(b);
            //printCollection(c);
            //{
            //  static void printCollection<T>(IEnumerable<T> collection)
            //{
            //  foreach (T obj in collection)
            //{
            //  Console.Write(obj + " ");
            //}
            //Console.WriteLine();
            //}
            //}

            #endregion
            #region
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmeil.com";
            cookies["phone"] = "9464546";
            cookies["phone"] = "9646986656";

            Console.WriteLine(cookies ["email"]);
            Console.WriteLine(cookies ["phone"]);

            cookies.Remove("email");

            if (cookies .ContainsKey("email"))
            {
                Console.WriteLine(cookies ["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }
            Console.WriteLine("size: cookies:");

            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair < string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            #endregion

        }
    }
}


