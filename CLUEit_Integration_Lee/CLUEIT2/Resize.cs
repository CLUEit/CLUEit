using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CLUEIT2
{
    struct WINDOWPLACEMENT
    {
        public int length;
        public int flags;
        public int showCmd;
        public System.Drawing.Point ptMinPosition;
        public System.Drawing.Point ptMaxPosition;
        public System.Drawing.Rectangle rcNormalPosition;
    }


    public class Resize
    {
        //MEMBERS:
        //screen size information
        static Rectangle screensize;
        //active window handle
        IntPtr activeHandle;
        //active window info
        WINDOWPLACEMENT activeRestore;

        //consts for windowplacement struct
        const int SW_HIDE = 0;
        const int SW_SHOWNORMAL = 1;
        const int SW_SHOWMINIMIZED = 2;
        const int SW_SHOWMAXIMIZED = 3;
        const int SW_SHOWNOACTIVATE = 4;
        const int SW_SHOW = 5;
        const int SW_MINIMIZE = 6;
        const int SW_SHOWMINNOACTIVE = 7;
        const int SW_SHOWNA = 8;
        const int SW_RESTORE = 9;

        //METHODS:

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        //constructor gets information about screen size
        public Resize()
        {
            screensize = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            activeHandle = GetForegroundWindow();
        }
        //save the current size of the active window
        public void saveActiveWindowSize()
        {
            activeRestore = new WINDOWPLACEMENT();
            activeRestore.length = Marshal.SizeOf(activeRestore);
            if (!GetWindowPlacement(activeHandle, ref activeRestore))
            {
                throw new Exception("GetWindowPlacement failed to get active window restore information");
            }

        }
        //restore the saved size of the active window
        public void restoreActiveWindowSize()
        {
            System.Diagnostics.Process resize = new System.Diagnostics.Process();
            resize.StartInfo.FileName = @"C:\Program Files\CLUEit\resize.exe";
            resize.StartInfo.Arguments = activeHandle.ToString() + " 0 0 " + screensize.Width + " " + screensize.Height;
            resize.Start();
            resize.WaitForExit();
        }

        //snap the active window to the left
        public void snapActiveWindowLeft()
        {
            System.Diagnostics.Process resize = new System.Diagnostics.Process();
            resize.StartInfo.FileName = @"C:\Program Files\CLUEit\resize.exe";
            int coord = 0;
            int width = screensize.Width / 2;
            int height = screensize.Height;
            resize.StartInfo.Arguments = activeHandle.ToString() + " " + coord.ToString() + " " + coord.ToString() + " " + width.ToString()
                + " " + height.ToString();
            resize.Start();
            resize.WaitForExit();
        }

        //returns the height of the screen
        public int getHeight()
        {
            return screensize.Height;
        }

        //returns half the width of the screen
        public int getWidth()
        {
            return screensize.Width / 2;
        }

        //returns a point representing the top center of the screen
        public System.Drawing.Point getCenterPoint()
        {
            return new System.Drawing.Point(screensize.Width / 2, 0);
        }


    }
}
