using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherConnectorLib;

namespace MVC_Example
{
    public class Model
    {
        public event ModelUpdatedDelegate ModelUpdated;
        public delegate void ModelUpdatedDelegate(WeatherData data);

        private string _city;

        public Model()
        {
            WeatherConnector.ApiKey = "1bdfdfbac52feb077781c6b5ccaa3b31";
        }

        internal void SetCity(string city)
        {
            this._city = city;
            if (ModelUpdated != null)
            {
                try
                {
                    ModelUpdated(WeatherConnector.GetWeatherForCity(city));
                }
                catch(NullReferenceException e)
                {

                }
            }
        }

        public WeatherData Weather
        {
            get
            {
                return WeatherConnector.GetWeatherForCity(_city);
            }
        }

 
    }
}
