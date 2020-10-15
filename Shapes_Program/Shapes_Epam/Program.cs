using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace Shapes_Epam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ishape> shapes = CreateShapesFromFile.CreateList(@"Shapes_example.txt");
            if (shapes.Count > 0)
            {
                /*
                for (int i = 0; i < shapes.Count; i++)
                {
                    Console.WriteLine(shapes[i].NameShape() + ", периметр: " + String.Format("{0:F3}", shapes[i].Perimeter()) + ", площадь: " + String.Format("{0:F3}", shapes[i].Square()));
                }*/
                Console.WriteLine("Среднее значение периметра фигур - " + String.Format("{0:F3} ", Calculations.perimeterAverage(shapes))); ;
                Console.WriteLine("Среднее значение площадей фигур - " + String.Format("{0:F3} ", Calculations.squareAverage(shapes)));
                Ishape shapeMax = Calculations.maxSquare(shapes);
                Console.WriteLine("Фигура наибольшей площади - " + shapeMax.NameShape() + " (площадь - " + String.Format("{0:F3}", shapeMax.Square()) + ")");
                Console.WriteLine("Тип фигуры с наибольшим значением среднего периметра - " + Calculations.typeShapeMaxAveragePerimeter(shapes));
            }
            else
                Console.WriteLine("Список не содержит элементов!");
            Console.ReadKey();
        }
    }
}
