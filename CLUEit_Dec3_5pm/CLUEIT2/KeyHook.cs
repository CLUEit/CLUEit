using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace CLUEIT2
{
    public class KeyHook
    {
        /* Member variables */
        protected static int Hook;
        protected static LowLevelKeyboardDelegate Delegate;
        protected static readonly object Lock = new object();
        protected static bool IsRegistered = false;

        /* DLL imports */
        [DllImport("user32")]
        private static extern int SetWindowsHookEx(int idHook, LowLevelKeyboardDelegate lpfn,
                int hmod, int dwThreadId);

        [DllImport("user32")]
        private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

        [DllImport("user32")]
        private static extern int UnhookWindowsHookEx(int hHook);

        /* Types & constants */
        protected delegate int LowLevelKeyboardDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);
        private const int HC_ACTION = 0;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WH_KEYBOARD_LL = 13;

        [StructLayout(LayoutKind.Sequential)]
        public struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        /* Methods */
        static private int LowLevelKeyboardHandler(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam)
        {
            if (nCode == HC_ACTION)
            {
                if (wParam == WM_KEYDOWN)
                {
                    System.Console.Out.WriteLine("Key Down: " + lParam.vkCode);
                    MessageBox.Show("Key Down: " + lParam.vkCode);
                }
                else if (wParam == WM_KEYUP)
                {
                    System.Console.Out.WriteLine("Key Up: " + lParam.vkCode);
                    MessageBox.Show("Key Up: " + lParam.vkCode);
                }
            }
            return CallNextHookEx(Hook, nCode, wParam, lParam);
        }

        public static bool RegisterHook()
        {
            lock (Lock)
            {
                if (IsRegistered)
                    return true;
                Delegate = LowLevelKeyboardHandler;
                Hook = SetWindowsHookEx(
                        WH_KEYBOARD_LL, Delegate,
                        Marshal.GetHINSTANCE(
                                System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0]
                        ).ToInt32(), 0
                );

                if (Hook != 0)
                    return IsRegistered = true;
                Delegate = null;
                return false;
            }
        }

        public static bool UnregisterHook()
        {
            lock (Lock)
            {
                return IsRegistered = (UnhookWindowsHookEx(Hook) != 0);
            }
        }
    }
}
