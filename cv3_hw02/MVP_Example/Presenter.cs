using System;
using WeatherConnectorLib;

namespace MVP_Example
{

    /**  passive view
     * 
     **/
    internal class Presenter
    {
        private Model _model;
        private IView _view;

        public Presenter(Model model, IView view)
        {
            _model = model;
            //When model is changed
            _model.ModelUpdated += ModelUpdated;
            _view = view;
        }

        internal void ParseCommand(string command)
        {
            if (command.ToLower() == "x")
            {
                Environment.Exit(0);
            } 
            else if (command.ToLower().Contains("setlanguage")){
                _model.setLanguage(command);
            }
            else if (command.ToLower().Contains("setunit"))
            {
                _model.setUnit(command);
            }
            else
            {
                //update model
                _model.SetCity(command);
                

            }
        }

        //update GUI when model is changed
        private void ModelUpdated(WeatherData weatherData, string language, string unit)
        {
            _view.City = weatherData.City;
            _view.Country = weatherData.Country;
            _view.Humidity = weatherData.Humidity;
            if (unit == " F")
            {
                _view.Temp = (weatherData.Temp * 9) / 5 + 32;
                _view.TempMax = (weatherData.TempMax * 9) / 5 + 32;
                _view.TempMin = (weatherData.TempMin * 9) / 5 + 32;
            }
            else
            {
                _view.Temp = weatherData.Temp;
                _view.TempMax = weatherData.TempMax;
                _view.TempMin = weatherData.TempMin;
            }

            _view.Language = language;
            _view.Unit = unit;

            _view.Render();
        }
    }
}
 