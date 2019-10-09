using System;
using WeatherConnectorLib;

namespace MVP_Example
{
    public class Model
    {
        public event ModelUpdatedDelegate ModelUpdated;
        public delegate void ModelUpdatedDelegate(WeatherData data, string language, string unit);

        string _city;

        //default unit = Celsia
        string _unit = "°C";

        //default language = en
        string _language = "en";

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
                    ModelUpdated(WeatherConnector.GetWeatherForCity(city), _language, _unit);
                }
                catch (NullReferenceException)
                {

                }
            }
        }

        //Method which will set language chosen by user
        public void setLanguage(string language)
        {
            if (ModelUpdated != null)
            {
                if (language.Contains("cz"))
                {
                    _language = "cz";
                }
                else if (language.Contains("en"))
                {
                    _language = "en";
                }
            }
        }

        //Method which will set unit chosen by user
        public void setUnit(string unit)
        {
            if (ModelUpdated != null)
            {
                if (unit.Contains("C"))
                {
                    _unit = "°C";
                }
                else if (unit.Contains("F"))
                {
                    _unit = " F";
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
