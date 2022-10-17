using System;
using Curso.Enums;

namespace Curso
{
    class Order
    {
        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus status { get; set; }

        public override string ToString()
        {
            return id
                + ","
                + Moment
                + ","
                + status;
        }
    }
}
