using MetodosAbstratosEx01.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratosEx01.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color) 
        {
            Color = Color;
        }
        public abstract double Area();
    }
}
