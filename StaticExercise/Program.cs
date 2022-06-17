using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class Program
    {

        public static class TempConverter
        {
            public static double FahrenheitToCelsius(double f) => (f - 32) * (5 / 9);
            public static double CelsiusToFahrenheit(double c) => c * (9 / 5) + 32;
        }

        static void Main(string[] args)
        {
            double temp;
            Console.WriteLine("Enter temperature in F: ");
            temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{temp} degrees F is equivalent to {TempConverter.FahrenheitToCelsius(temp)} degrees C.");
            Console.ReadKey(true);
            Console.WriteLine("\nNow enter a temperature in C: ");
            temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{temp} degrees C is equivalent to {TempConverter.CelsiusToFahrenheit(temp)} degrees F.");
            Console.ReadKey(true);
        }
    }
}