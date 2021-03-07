﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes.Models
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateSurface();
    }
}
