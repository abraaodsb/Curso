using System;
using System.Collections.Generic;
using System.Text;
using Curso.Entities.Exceptions;

namespace Curso.Entities
{
    class Reservation
    {
        public int RoonNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roonNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out date must be after check-in date");
            }

            RoonNumber = roonNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
         public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void  updateDates(DateTime checkIn, DateTime  checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException( "reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out date must be after check-in date");
            }

            CheckIn = checkIn;
            checkOut = checkOut;
            
        }
           
        public override string ToString()
        {
            return "Room"
                + RoonNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "nights";
        }
    }
}
