using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes.Models
{
    class Square : Shape
    {
        public Square(double height)
        {
            base.Height = height;
        }

        public override double CalculateSurface()
        {
            return Height * Height;
        }
    }
}
