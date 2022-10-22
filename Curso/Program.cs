using Curso.Enums;
using System;
using Curso.Entities;
using System.Globalization;
using System.Collections.Generic;
using Curso.Entities.Enums;
using Curso.Entities.Exceptions;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy):");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy):");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

            
            
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.updateDates(checkIn, checkOut);
                Console.WriteLine("Reservatiom: " + reservation);
                
            }
             catch (CannotUnloadAppDomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}

