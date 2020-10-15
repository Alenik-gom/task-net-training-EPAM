using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Parallelogram
    {
       public Rectangle(double side_a, double side_b) :base(side_a, side_b, 90) {
            nameShape = TypeShapes.Прямоугольник;
        }
       
    }
}
