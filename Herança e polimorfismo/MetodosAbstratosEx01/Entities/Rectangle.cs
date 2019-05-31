using MetodosAbstratosEx01.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratosEx01.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double heitht, Color color) : base (color)
        {
            Width = width;
            Height = heitht;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
