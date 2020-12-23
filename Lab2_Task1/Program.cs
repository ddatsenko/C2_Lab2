using System;

namespace Lab2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter two non-negative length parameters separated by Space: ");
            int[] array = new int[3];
            array = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            Rectangle firstRectangle = new Rectangle(array[0], array[1]);
            Console.ResetColor();
            Console.WriteLine(firstRectangle);
            Console.WriteLine(firstRectangle.PerimeterCalculation());
            Console.WriteLine(firstRectangle.AreaCalculation());

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nDemonstration of indexator's performance:");
            Console.ResetColor();
            Console.WriteLine(firstRectangle['a']);
            Console.WriteLine(firstRectangle['b']);

            Console.ReadKey();
        }
    }
}
