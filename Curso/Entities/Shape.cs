﻿using System;
using System.Collections.Generic;
using System.Text;
using Curso.Entities.Enums;

namespace Curso.Entities
{
     abstract  class Shape
    {
        public Color Color { get; set; }

       
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
