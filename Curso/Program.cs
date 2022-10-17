using Curso.Enums;
using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                id = 1080,
                Moment = DateTime.Now,
                status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}

