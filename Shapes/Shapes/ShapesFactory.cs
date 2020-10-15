using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesFactory
    {
        public static Ishape getShape(string[] shape_parameters)
        {
            Ishape shape = null;
            try
            {
                TypeShapes typeShape = (TypeShapes)Enum.Parse(typeof(TypeShapes), shape_parameters[0]);
                switch (typeShape)
                {
                    case TypeShapes.Параллелограмм:
                        if (shape_parameters.Length == 4)
                            shape = new Parallelogram(Double.Parse(shape_parameters[1]), Double.Parse(shape_parameters[2]), Double.Parse(shape_parameters[3]));
                        break;
                    case TypeShapes.Ромб:
                        if (shape_parameters.Length == 3)
                            shape = new Rhombus(Double.Parse(shape_parameters[1]), Double.Parse(shape_parameters[2]));
                        break;
                    case TypeShapes.Прямоугольник:
                        if (shape_parameters.Length == 3)
                            shape = new Rectangle(Double.Parse(shape_parameters[1]), Double.Parse(shape_parameters[2]));
                        break;
                    case TypeShapes.Квадрат:
                        if (shape_parameters.Length == 2)
                            shape = new Square(Double.Parse(shape_parameters[1]));
                        break;
                    case TypeShapes.Круг:
                        if (shape_parameters.Length == 2)
                            shape = new Circle(Double.Parse(shape_parameters[1]));
                        break;
                    case TypeShapes.Треугольник:
                        if (shape_parameters.Length == 4)
                            shape = new Triangle(Double.Parse(shape_parameters[1]), Double.Parse(shape_parameters[2]), Double.Parse(shape_parameters[3]));
                        break;
                    case TypeShapes.Трапеция:
                        if (shape_parameters.Length == 6)
                            shape = new Trapeze(Double.Parse(shape_parameters[1]), Double.Parse(shape_parameters[2]), Double.Parse(shape_parameters[3]), Double.Parse(shape_parameters[4]), Double.Parse(shape_parameters[5]));
                        break;
                    default:
                        throw new ArgumentException("Wrong type" + typeShape);
                }
            }
            catch {
                Console.WriteLine("Некорректные данные в файле!");
                Console.ReadKey();
            }
            return shape;
        }
    }
}
