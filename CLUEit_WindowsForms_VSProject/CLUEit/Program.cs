using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CLUEit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //string[] words = { "cosmonauty" };
            Application.Run(new mainWindow(args));
            //Application.Run(new mainWindow(words));
        }
    }
}
