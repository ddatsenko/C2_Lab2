using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            TTriangle triangle = new TTriangle(6, 8, 10);
            Console.WriteLine(triangle.ToString());
            Console.WriteLine("Perimeter = " + triangle.CalculatePerimeter(triangle));
            Console.WriteLine("Area = " + triangle.CalculateArea(triangle));
            Console.WriteLine("");
            TTriangle triangle1 = new TTriangle(3, 4, 5);
            Console.WriteLine(triangle1.ToString());
            Console.WriteLine("Perimeter =  " + triangle.CalculatePerimeter(triangle1));
            Console.WriteLine("Area = " + triangle.CalculateArea(triangle1));
            Console.WriteLine("");
            Console.WriteLine("Triangle equality check:");
            if (triangle.Equals(triangle, triangle1)) Console.WriteLine("Triangles are equal.");
            else Console.WriteLine("Triangles are not equal.");
            Console.WriteLine("");
            TTrianglePrizm prizm = new TTrianglePrizm(8, 15, 17, 10);
            Console.WriteLine(prizm.ToString());

            Console.WriteLine("The volume of the specified prizm = " + prizm.CalculateVolume(prizm));
            Console.ReadKey();
        }
    }
}
