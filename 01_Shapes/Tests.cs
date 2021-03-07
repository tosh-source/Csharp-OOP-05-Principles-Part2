using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Shapes.Models;

namespace _01_Shapes
{
    class Tests
    {
        static void Main(string[] args)
        {
            Shape[] shapes = 
            {
                new Square(18),       //S = 324
                new Rectangle(9, 4),  //S = 36
                new Triangle(9, 4)    //S = 18
            };

            foreach (var currentShape in shapes)
            {
                Console.WriteLine(currentShape.CalculateSurface());
            }
        }
    }
}

//Microsoft Docs ('virtual' methods & references + example) ->  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual
