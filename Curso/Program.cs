using Curso.Enums;
using System;
using Curso.Entities;
using System.Globalization;
using System.Collections.Generic;
using Curso.Entities.Enums;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy):");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy):");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: checkOut date must be after check-in");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.updateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservatiom: " + reservation);
                }
            }
        }
    }
}

