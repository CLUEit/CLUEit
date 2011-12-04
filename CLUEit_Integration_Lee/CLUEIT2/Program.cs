using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

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
            try
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

                //  System.Threading.Timer timer;


                if (currentCLUEits.Length == 1)
                {
                    //if this is the first instance:
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    // Thread thread = new Thread(new ThreadStart(mainWindow.waitForNewPhrase));
                    //thread.Start();

                    //     timer = new System.Threading.Timer(check, null, 2000, 2000);


                    Application.Run(new mainWindow(args));

                    // timer.Dispose();
                }

                //otherwise, raise the event/send a message to the current instance

                //  else
                //  {
                //  Application.EnableVisualStyles();
                //  Application.SetCompatibleTextRenderingDefault(false);
                //  string[] words = { "this is a new instance and the number of instances is ", currentCLUEits.Length.ToString() };
                // Application.Run(new mainWindow(words));
                //}
            }

            catch (Exception e)
            {
            }


            }




     //   static void check(object i)



     //   static int numPhrases = 1;
    }
}
