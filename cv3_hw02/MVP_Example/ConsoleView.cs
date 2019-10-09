using System;

namespace MVP_Example
{
    internal class ConsoleView : IView
    {
        public string City { set; get; }
        public string Country { set; get; }
        public double Temp { set; get; }
        public double TempMax { set; get; }
        public double TempMin { set; get; }
        public double Humidity { set; get; }

        public void Render()
        {
            string output = string.Format("Current weather for city {0}, {1}{2}", City, Country, Environment.NewLine);
            output += string.Format("  Temperature is {0}, maximum {1}, minimum {2}. {3}", Temp, TempMax, TempMin, Environment.NewLine);
            output += string.Format("  Humidity is {0}%{1}", Humidity, Environment.NewLine);

            Console.Write(output);
        }
    }
}