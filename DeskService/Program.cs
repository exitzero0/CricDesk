using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DeskService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if(!DEBUG)
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ServiceManager() 
            };
            ServiceBase.Run(ServicesToRun);
#else
            ServiceManager myServ = new ServiceManager();
            myServ.TestFunction();
#endif
        }
    }
}
