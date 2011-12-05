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
                //get selected text
                System.Diagnostics.Process hotkey = new System.Diagnostics.Process();
                hotkey.StartInfo.FileName = @"C:\Users\Lou\CLUEit\selected_text.exe";
                hotkey.Start();
                hotkey.WaitForExit();
                string text = Clipboard.GetText();
                Clipboard.Clear();
                string[] args = text.Split();
                //setup active window resizing
                //Globals.preferences = new Preferences();
                Globals.windowResizer = new Resize();
                Globals.windowResizer.saveActiveWindowSize();
                Globals.windowResizer.snapActiveWindowLeft();
                //start the form
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                mainWindow newForm = new mainWindow(args);
                newForm.Height = Globals.windowResizer.getHeight();
                newForm.Width = Globals.windowResizer.getWidth();
                newForm.Location = Globals.windowResizer.getCenterPoint();
                Application.Run(newForm);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            }




     //   static void check(object i)



     //   static int numPhrases = 1;
    }
}
