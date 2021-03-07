using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes.Models
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            base.Width = width;
            base.Height = height;
        }

        public override double CalculateSurface()
        {
            return Height * Width / 2;
        }
    }
}
