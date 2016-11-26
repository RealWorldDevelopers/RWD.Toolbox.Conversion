using RWD.Toolbox.Conversion.WinForm.ExceptionHelper;
using System;
using System.Threading;
using System.Windows.Forms;

namespace RWD.Toolbox.Conversion.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // set unhandled thread exceptions handler
            ThreadExceptionHandler handler = new ThreadExceptionHandler();

            Application.ThreadException += new ThreadExceptionEventHandler(handler.Application_ThreadException);

            // Set the unhandled exception mode to force all Windows Forms errors
            // to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // begin app           
            Application.Run(new Display());
        }
    }
}
