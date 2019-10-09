using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherConnectorLib;

namespace MVC_Example
{
    public class View
    {
        public View(Model model)
        {
            model.ModelUpdated += ModelUpdated;
        }

        private void ModelUpdated(WeatherData weatherData)
        {
            string output = string.Format("Current weather for city {0}{1}", weatherData.City, Environment.NewLine);
            output += string.Format(" Temperature: {0}{1}", weatherData.Temp, Environment.NewLine);

            Console.Write(output);
        }
    }
}
