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
                Console.Write("Command for presenter (x to exit): ");
                string command = Console.ReadLine();
                presenter.ParseCommand(command);
            }
        }
    }
}
