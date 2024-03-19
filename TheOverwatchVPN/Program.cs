using System.Diagnostics;
using System.Security.Principal;

namespace TheOverwatchVPN
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsAdministrator())
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Window());
            }
            else
            {
                MessageBox.Show("Please open with admin. \n\n You do this by rightclicking the application and selecting \"Run with Administrator\"", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

        }
        static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

    }
}