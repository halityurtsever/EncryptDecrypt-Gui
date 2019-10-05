using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EncryptDecryptGUI
{
    public class CustomTextBox : TextBox
    {
        const int EM_SETWORDBREAKPROC = 0x00D0;

        delegate int EditWordBreakProc(string lpch, int ichCurrent, int cch, int code);

        [DllImport("User32.DLL")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        readonly EditWordBreakProc m_Callback = MyEditWordBreakProc;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!DesignMode)
            {
                SendMessage(Handle, EM_SETWORDBREAKPROC, IntPtr.Zero, Marshal.GetFunctionPointerForDelegate(m_Callback));
            }
        }

        static int MyEditWordBreakProc(string lpch, int ichCurrent, int cch, int code)
        {
            return 0;
        }
    }
}
