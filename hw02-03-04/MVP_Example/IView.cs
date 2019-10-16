namespace MVP_Example
{
    public interface IView
    {
        string City { set; }
        string Country { set; }
        double Temp { set; }
        double TempMax { set; }
        double TempMin { set; }
        double Humidity { set; }
        //Celsia or fahrenheit
        string Unit { set;  }
        //Cz or en
        string Language { set; }

        void Render();
    }
}