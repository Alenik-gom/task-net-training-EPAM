using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rhombus : Parallelogram
    {
       
        public Rhombus(double side_a, double angle):base(side_a, side_a,angle)
        {
            nameShape = TypeShapes.Ромб;
}
    }
}
