using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            IView view = new ConsoleView();
            Presenter presenter = new Presenter(model, view);
            while (true)
            {                
                string output = string.Format("To change language:\n on CZ enter: setLanguage cz \n on EN enter: setLanguage en {0}", Environment.NewLine);
                output += string.Format("To change unit:\n on Fahrenheit enter: setUnit F \n on Celsia enter: setUnit C {0}", Environment.NewLine);
                output += string.Format("Command for presenter (x to exit): ");
                Console.Write(output);

                string command = Console.ReadLine();
                presenter.ParseCommand(command);
                Console.Write("\n");

            }
        }
    }
}
