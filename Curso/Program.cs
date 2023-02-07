using System;
using Curso.Entities;
using System.Globalization;
using System.IO;
using Curso;
using Curso.Entities.Services;

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
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            #endregion

            #region 
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/mm/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy HH:mm", CultureInfo.InvariantCulture );
            Console.WriteLine("Return (dd/mm/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per Day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService ());

            rentalService.ProcessInvoce(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);

            #endregion
        }
    }
}


