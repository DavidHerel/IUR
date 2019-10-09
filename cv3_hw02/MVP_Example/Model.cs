using System;
using WeatherConnectorLib;

namespace MVP_Example
{
    public class Model
    {
        public event ModelUpdatedDelegate ModelUpdated;
        public delegate void ModelUpdatedDelegate(WeatherData data);

        string _city;
        
        public Model()
        {
            WeatherConnector.ApiKey = "1bdfdfbac52feb077781c6b5ccaa3b31";
        }

        public void SetCity(string city)
        {
            this._city = city;
            if (ModelUpdated != null)
            {
                try
                {
                    ModelUpdated(WeatherConnector.GetWeatherForCity(city));
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        /**
         * Return Weather object of current city
         * */
        public WeatherData Weather
        {
            get
            {
                return WeatherConnector.GetWeatherForCity(_city);
            }
        }

    }
}
