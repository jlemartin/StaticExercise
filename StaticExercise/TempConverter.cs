using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double fTemp)
        {
            return (fTemp - 32) / 1.8;
        }

        public static double CelsiusToFahrenheit(double cTemp)
        {
            return ((cTemp / 5) * 9) + 32;
        }

    }
}
