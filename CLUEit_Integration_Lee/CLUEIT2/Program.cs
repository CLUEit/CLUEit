using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CLUEIT2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Diagnostics.Process hotkey = new System.Diagnostics.Process();
            hotkey.StartInfo.FileName = @"C:\Program Files\CLUEit\selected_text.exe";
            hotkey.Start();
            hotkey.WaitForExit();
            string text = Clipboard.GetText();
            Clipboard.Clear();
            string[] args = text.Split();
            System.Diagnostics.Process[] currentCLUEits = System.Diagnostics.Process.GetProcessesByName(
                    System.Diagnostics.Process.GetCurrentProcess().ProcessName);

            if (currentCLUEits.Length == 1)
            {
                //if this is the first instance:
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainWindow(args));
            }

            //otherwise, raise the event/send a message to the current instance

            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                string[] words = { "this is a new instance and the number of instances is ", currentCLUEits.Length.ToString() };
                Application.Run(new mainWindow(words));
            }
        }
    }
}
