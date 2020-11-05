using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversions");
            Console.WriteLine();

            var num1 = 0.0;
            var num2 = 32.0;
            var num3 = 100.0;
            var num4 = 212.0;

            var result1 = TempConverter.FahrenheitToCelsius(num4);
            var result2 = TempConverter.FahrenheitToCelsius(num2);
            var result3 = TempConverter.CelsiusToFahrenheit(num1);
            var result4 = TempConverter.CelsiusToFahrenheit(num3);

            Console.WriteLine("Critical test data points - coming and going");
            Console.Write("Boiling Point: ");
            Console.WriteLine($"{num4}F = {result1}C");
            Console.Write("Freezing Point: ");
            Console.WriteLine($"{num2}F = {result2}C");
            Console.Write("Freezing Point: ");
            Console.WriteLine($"{num1}C = {result3}F");
            Console.Write("Boiling Point: ");
            Console.WriteLine($"{num3}C = {result4}F");

            Console.Write("Enter a number in Fahrenheit to be converted to Celsius: ");
            var fNum = Convert.ToDouble(Console.ReadLine());
            var fCalc = TempConverter.FahrenheitToCelsius(fNum);
            Console.WriteLine($"{fCalc} degrees Celsius");
            Console.WriteLine();

            Console.Write("Enter a number in Celsius to be converted to Fahrenheit: ");
            var cNum = Convert.ToDouble(Console.ReadLine());
            var cCalc = TempConverter.CelsiusToFahrenheit(cNum);
            Console.WriteLine($"{cCalc} degrees Celsius");
            Console.WriteLine();

        }
    };
}
