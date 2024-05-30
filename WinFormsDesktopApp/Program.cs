using Microsoft.Identity.Client;
using WinFormsDesktopApp;

namespace WinFormsDesktopApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // While loop to keep alive when sign out or time out takes place
            while (true)
            {
                try
                {
                    ApplicationConfiguration.Initialize();
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                } catch{} // Just do nothing if is already Initialized

                // Login form as entry point here
                LoginForm LoginForm = new LoginForm();
                AuthenticationResult result = null;
                if (LoginForm.ShowDialog() == DialogResult.OK)
                {
                    result = LoginForm.AuthenticationResult;
                    LoginForm.Close(); // Making sure the form is closed to save on resources
                    Application.Run(new MainParentForm(result));
                } else
                {
                    break;
                }
            }
        }
    }
}