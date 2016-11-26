
using System.Threading;
using System.Windows.Forms;

namespace RWD.Toolbox.Conversion.WinForm.ExceptionHelper
{
    /// <summary>
    /// Handles a thread (unhandled) exception.
    /// </summary>
    internal class ThreadExceptionHandler
    {
        /// <summary>
        /// Handles the thread exception.
        /// </summary>
        public void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                ExceptionHelperFactory factory = new ExceptionHelperFactory();
                var exceptionHelper = factory.CreateNewExceptionHelper();
                exceptionHelper.AllowManualReporting = true;
                exceptionHelper.IncludeInnerExceptions = true;
                var result = exceptionHelper.BuildExceptionString(e.Exception);
                exceptionHelper.DisplayExceptionToUser(e.Exception);

            }
            catch
            {
                // Fatal error, terminate program
                try
                {
                    MessageBox.Show("Fatal Error", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

    }
}
