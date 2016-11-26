using NLog;
using System;
using System.Windows.Forms;

namespace RWD.Toolbox.Conversion.WinForm.ExceptionHelper
{
    public partial class ExceptionDisplay : Form
    {
        public event EventHandler<ReportClickEventArgs> ReportClicked;

        public bool ReportingEnabled { get; set; }

        public TreeNode RootNode { get; set; }

        public string ExceptionString { get; set; }

        public string ExceptionSource { get; set; }

        public string Title { get; set; }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            try
            {
                btnReport.Visible = ReportingEnabled;
                ResizeControls();
                if (RootNode != null)
                {
                    tre_ErrorMessages.Nodes.Add(RootNode);
                }
                else
                {
                    MessageBox.Show(ExceptionString, ExceptionSource, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorHandling.ErrorHandle.DisplayForm_Load()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayForm_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            int iTop = 0;
            try
            {
                if (ReportingEnabled)
                {
                    btnReport.Top = iTop;
                    btnReport.Left = 0;
                    btnReport.Width = ClientSize.Width;
                    iTop = btnReport.Bottom;
                }

                tre_ErrorMessages.Top = iTop;
                tre_ErrorMessages.Left = 0;
                tre_ErrorMessages.Width = ClientSize.Width;
                tre_ErrorMessages.Height = ClientSize.Height - iTop;

            }
            catch
            {
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportClicked?.Invoke(this, new ReportClickEventArgs(ExceptionString));
        }

        public ExceptionDisplay()
        {
            InitializeComponent();
            Resize += DisplayForm_Resize;
            Load += DisplayForm_Load;
        }

        public class ReportClickEventArgs : EventArgs
        {
            public string Message { get; private set; }

            public ReportClickEventArgs(string message)
            {
                Message = message;
            }
        }

    }
}
