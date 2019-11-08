using System;

namespace Convert_fahrenheit_celsius
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in Celcius?");
            double tempFaren = double.Parse(Console.ReadLine());
            Console.WriteLine(TemperatureConverter(tempFaren));
            double tempCelc = TemperatureConverter(tempFaren);
            if (tempCelc >= 99)
            {
                Console.WriteLine("Dude you're sick!");
            }

        }

        public static double TemperatureConverter(double var)
        {
            double temp = (var * (1.8) + 32);
            return temp;
        }
    }
}
