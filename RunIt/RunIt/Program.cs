using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunIt
{
    class Program
    {
        static void Main(string[] args)
        {

            //Set a time-out value.
         
            //Get path to system folder.
            
            ProcessStartInfo pInfo = new ProcessStartInfo();

           
            //Set file name to open.
            pInfo.FileName = args.ElementAt(0);
            pInfo.Arguments = args.ElementAt(1);
            //Start the process.
            Process p = Process.Start(pInfo);
            //Wait for window to finish loading.
            //p.WaitForInputIdle();
            //Wait for the process to exit or time out.
          
            while (p.HasExited == false)
            {
                Console.WriteLine(DateTime.Now.Second);
                System.Threading.Thread.Sleep(1000);
            }
            //Check to see if the process is still running.
          

        }
    }
}
