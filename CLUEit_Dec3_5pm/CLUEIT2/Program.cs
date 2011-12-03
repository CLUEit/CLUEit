using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Messaging;
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
            
            System.Diagnostics.Process hotkey = new System.Diagnostics.Process();
            hotkey.StartInfo.FileName = @"C:\Program Files\CLUEit\selected_text.exe";
            hotkey.Start();
            hotkey.WaitForExit();
            string text = Clipboard.GetText();
            Clipboard.Clear();
            string[] args = text.Split();
            //here, always do

            //look for a process named CLUEit or CLUEit2.exe
            //(look up how to do this on msdn)

           // Lookup by name
               // check if Array returned is empty (meaning No such Process)


            //System.Diagnostics.Process[] currentCLUEits = System.Diagnostics.Process.GetProcessesByName("CLUEit2.exe");

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

                NewPhrase phrase = new NewPhrase(args);



                /*MessageQueue queue = null;
                string queueName = "mq";

                if (MessageQueue.Exists(queueName))
                {
                    queue = new MessageQueue(queueName);
                    queue.Send(string.Join<string>(" ", args));
                }
                else
                {
                    //queue = MessageQueue.Create(queueName, false);
                }


               // mq.Send(string.Join<string>(" ", args));*/
            }

            //REMEMBER: everytime you change code and rebuild, copy the exe to ProgramFiles/CLUEit
        }
    }
}
