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
        
        void Render();
    }
}