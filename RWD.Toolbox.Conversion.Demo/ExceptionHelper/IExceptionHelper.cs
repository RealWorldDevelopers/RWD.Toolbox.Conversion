using NLog;
using System;
using System.Windows.Forms;

namespace RWD.Toolbox.Conversion.WinForm.ExceptionHelper
{
    public interface IExceptionHelper
    {
        bool AllowManualReporting { get; set; }
        bool Display { get; set; }
        string DisplayTitle { get; set; }
        bool IncludeInnerExceptions { get; set; }

        string BuildExceptionString(Exception e, string tab = "");
        TreeNode BuildExceptionTreeNode(Exception e);
        string BuildExceptionXml(Exception e, bool recurse = false);
        void DisplayExceptionToUser(Exception e);
        void LogException(Exception e, LogLevel level, string specialNotes= "No Special Notations");
        void LogString(string msg, LogLevel level);
    }
}