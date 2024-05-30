using Microsoft.Graph;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.Kiota.Abstractions.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WinFormsDesktopApp
{
    public partial class LoginForm : Form
    {
        private string LogInString = "";

        public AuthenticationResult AuthenticationResult { get; private set; }

        public LoginForm()
        {
            InitializeComponent();


            Load += new EventHandler(LoginForm_Load);

            //LoginWithMicrosoft().GetAwaiter().GetResult();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            //await LoginWithMicrosoft();
        }

        private IntPtr GetHandle()
        {
            IntPtr handle = this.Handle;
            return handle;
        }

        private async Task LoginWithMicrosoft()
        {
            if (AuthenticationResult != null)
            {
                Console.WriteLine("AU1: " + AuthenticationResult.AccessToken);
            }
            /// <summary>
            /// Function to connect to Microsoft B2C and authenticate the user through the Microsoft Identity Platform before the user can access the application.
            /// </summary>

            //string[] scopes = new string[] { "read" };

            // Token access scopes
            // TODO: Change from bitbuggy.dev to the proper domain, bitbuggy.onmicrosoft.com, once Azure catches up on changes to those scopes.
            string[] scopes = { "openid", "offline_access", "https://bitbuggy.dev/support/Ticket.Read", "https://bitbuggy.dev/support/Ticket.Write" };

            string client = ClientInformation.ClientId;

            // Create a public client application with the BitBuggyLogin B2C authority
            var app = PublicClientApplicationBuilder.Create(ClientInformation.ClientId)
                .WithRedirectUri(ClientInformation.RedirectUri)
                .WithB2CAuthority("https://bitbuggy.b2clogin.com/tfp/bitbuggy.onmicrosoft.com/B2C_1_BitBuggyLogin")
                .Build();

            // Create a public client application with the ResetPassword B2C authority
            var app2 = PublicClientApplicationBuilder.Create(ClientInformation.ClientId)
                .WithRedirectUri(ClientInformation.RedirectUri)
                .WithB2CAuthority("https://bitbuggy.b2clogin.com/tfp/bitbuggy.onmicrosoft.com/B2C_1_ResetPassword")
                .Build();

            var accounts = await app.GetAccountsAsync();

            AuthenticationResult? result = null;
            bool SignInSuccessful = false;

            try
            {
                // Attempt to get a token from the cache (or refresh it silently if needed)
                result = await app.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                  .ExecuteAsync();
            }
            catch (MsalUiRequiredException)
            {
                // No token found in the cache, prompt the user to sign in
                try
                {
                    try
                    {
                        // Prompt the user to sign in
                        result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
                    }
                    catch (MsalClientException)
                    {
                        result = null;
                        Console.WriteLine("Here");
                    }
                }
                catch (MsalServiceException)
                {
                    while (!SignInSuccessful)
                    {
                        try
                        {
                            // Prompt the user to reset their password
                            result = await app2.AcquireTokenInteractive(scopes).ExecuteAsync();

                            // If the password reset flow is completed successfully, set the flag to true
                            SignInSuccessful = true;
                        }
                        catch (MsalException ex)
                        {
                            // If the password reset flow is canceled or encounters an error,
                            // prompt the user to sign in again
                            if (ex.ErrorCode == "authentication_canceled")
                            {
                                // if user exit authentication
                                Console.WriteLine("User canceled authentication");
                                break;
                            }
                            Console.WriteLine($"Password reset flow failed: {ex.Message}");

                            try
                            {
                                // Prompt the user to sign in again
                                result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

                                // If sign in is successful, set the flag to true
                                SignInSuccessful = true;
                            }
                            catch (MsalException exx)
                            {
                                // If sign in fails again, the loop will continue, prompting the user to reset password again
                                Console.WriteLine(exx.ErrorCode);
                                if (exx.ErrorCode == "authentication_canceled")
                                {
                                    // if user exit authentication
                                    Console.WriteLine("User canceled authentication");
                                    break;
                                }
                            }
                        }
                    }

                }
                if (result != null)
                {
                    this.AuthenticationResult = result;
                    LogInString = "OK";
                }
            }
            /// ISSUE: There is a race condition somewhere here that causes the app to randomly crash when the user is authenticated.
            ///        When it happens, the api is unable to authenticate the user for around ~5 minutes.
            ///        As for where it specifically happens ¯\_(ツ)_/¯

            // Creates instance of jwt decoder
            var handler = new JwtSecurityTokenHandler();

            if (result != null)
            {
                // Reads the jwt token
                var jwtSecurityToken = handler.ReadJwtToken(result.AccessToken);

                // Gets the claims from the jwt token
                var claims = jwtSecurityToken.Claims;

                //TODO - Pass claims to the main form

                // Outputs the claims to the console
                foreach (var claim in claims)
                {
                    Console.WriteLine(claim.Type + ": " + claim.Value);
                }
            }
        }

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            if (AuthenticationResult != null)
            {
                Console.WriteLine("Already Login with Token: " + AuthenticationResult.AccessToken);
            }
            await LoginWithMicrosoft();

            if (LogInString == "OK")
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void LoginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginFormMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Custom window dragging for the borderless window
        public Point mouseLocation;
        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
