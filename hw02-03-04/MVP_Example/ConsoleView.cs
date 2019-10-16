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
        //Celsia or fahrenheit
        public string Unit { set; get; }
        //Cz or en
        public string Language { set; get; }

        public void Render()
        {
            string output = "";
            if(Language == "en")
            {
                output = enText();
            }else if (Language == "cz")
            {
                output = czText();
            }

            Console.Write(output);
        }

        //method for english text
        private string enText()
        {
            string output = string.Format("Current weather for city {0}, {1}{2}", City, Country, Environment.NewLine);
            output += string.Format("  Temperature is {0}{1}, maximum {2}{3}, minimum {4}{5}. {6}", Temp, Unit, TempMax, Unit, TempMin, Unit, Environment.NewLine);
            output += string.Format("  Humidity is {0}%{1}", Humidity, Environment.NewLine);

            return output;
        }

        //method for czech text
        private string czText()
        {
            string output = string.Format("Dnešní počasí v městě {0}, {1}{2}", City, Country, Environment.NewLine);
            output += string.Format("  Teplota je {0}{1}, maximální {2}{3}, minimální {4}{5}. {6}", Temp, Unit, TempMax, Unit, TempMin, Unit, Environment.NewLine);
            output += string.Format("  Vlhkost je {0}%{1}", Humidity, Environment.NewLine);

            return output;
        }
    }
}