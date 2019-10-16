using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Uživatel používá controler, controler manipuluje s modelem, model updati, view, uživatel vidí view 
 * */

namespace MVC_Example
{
    class Program
    {

        static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View(model);
            Controller controller = new Controller(model);
            while (true)
            {
                Console.Write("Command for controller (x to exit): ");
                string command = Console.ReadLine();
                controller.ParseCommand(command);
            }
        }
    }
}
