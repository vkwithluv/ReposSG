using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SteakManager.Controllers;

namespace SteakManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Controllers.SteakController.Run();

        }
    }
}
