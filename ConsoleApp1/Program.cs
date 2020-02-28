using System;

namespace Lab1
{
    class Example
    {
        static void Main()
        {

            Console.WriteLine("Variant 20 - kub raznosti chisel ");
            Console.WriteLine("Vvedite 2 chisla: ");
            
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            double c = a - b;

            Console.WriteLine($"Raznica = {c}");

            double d = Math.Pow(c, 3);
            Console.WriteLine($"Kub raznosti chisel = {d}");

            
        
        }
    }
}
