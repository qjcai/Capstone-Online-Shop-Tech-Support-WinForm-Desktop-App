using Microsoft.Identity.Client;
using Microsoft.Identity.Client.NativeInterop;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.CompilerServices;
using WinFormsDesktopApp.Properties;
using Timer = System.Windows.Forms.Timer;

// TODO; Remember me check box
// TODO; Forget Password? function

namespace WinFormsDesktopApp
{
    partial class MainParentForm : Form
    {
        TicketsForm? Tickets;
        ReportsForm? Reports;
        private Timer? TimeoutTimer;
        private int RemainingSeconds;
        private int TimeLimit = 60;
        private AuthenticationResult? _Result;
        private IPublicClientApplication? _appp;

        // Delegate for mouse keyboard events
        public delegate void MouseKeyboardEvent();

        // Implementing IMessageFilter to handle global mouse keyboard events
        public class GlobalMouseHandler : IMessageFilter
        {
            // Constants for mouse and keyboard messages
            private const int MouseClick = 0x0201;
            private const int KeyDown = 0x0100;

            // Triggers when mouse or keyboard action occurs
            public event MouseKeyboardEvent? MouseKeyboardAction;
            #region IMessageFilter Members

            // Messages filtering to pick up mouse keyboard actions
            public bool PreFilterMessage(ref Message message)
            {
                if (message.Msg == MouseClick || message.Msg == KeyDown)
                {
                    if (MouseKeyboardAction != null)
                    {
                        MouseKeyboardAction();
                        Console.WriteLine("Mouse or Keyboard Clicked!");
                    }
                }
                // Return false here for continuation for filtering
                return false;
            }
            #endregion
        }

        public MainParentForm(AuthenticationResult result)
        {
            // Initializing for mouse keyboard handler
            GlobalMouseHandler gmh = new GlobalMouseHandler();
            gmh.MouseKeyboardAction += new MouseKeyboardEvent(gmh_TheMouseMoved);
            Application.AddMessageFilter(gmh);

            _Result = result;

            try
            {
                // Create instances of IPublicClientApplication
                var app = PublicClientApplicationBuilder.Create(ClientInformation.ClientId)
                    .WithRedirectUri(ClientInformation.RedirectUri)
                    .WithB2CAuthority("https://bitbuggy.b2clogin.com/tfp/bitbuggy.onmicrosoft.com/B2C_1_BitBuggyLogin")
                    .Build();

                // Initialize AuthService with instances of IPublicClientApplication
                _appp = app;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during initialization: {ex.Message}");
                // Handle initialization error appropriately
            }

            // How mouse keyboard is being handled
            void gmh_TheMouseMoved()
            {
                RemainingSeconds = TimeLimit;
                UpdateTimeCountLabel();
            }

            // UI inits
            InitializeComponent();

            // Show Tickets as the first entry page
            Tickets = new TicketsForm();
            Tickets.FormClosed += Tickets_FormClosed;
            Tickets.MdiParent = this;
            Tickets.Dock = DockStyle.Fill;
            Tickets.Show();

            // Time out functionality
            TimeoutTimer = new Timer();
            TimeoutTimer.Interval = 1000; // Timer interval set to 1 second (1000 milliseconds)
            TimeoutTimer.Tick += TimeoutTimer_Tick;
            TimeoutTimer.Start();

            RemainingSeconds = TimeLimit; // Initial timeout duration
            UpdateTimeCountLabel();
        }


        private void TimeoutTimer_Tick(object? sender, EventArgs e)
        {
            // Decrease by 1 second every interval
            RemainingSeconds--;
            //Console.WriteLine("Time left: " + RemainingSeconds);
            // When RemainingSecond reaches 0 return to login
            if (RemainingSeconds == 30)
            {
                DialogResult result = MessageBox.Show("You will be time out in 30 seconds for inactivity.", "Timeout", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    RemainingSeconds = TimeLimit;
                }
            }
            if (DialogResult == DialogResult.Cancel && RemainingSeconds == 60)
            {
                RemainingSeconds = 0;
            }
            if (RemainingSeconds <= 0)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
                if (RemainingSeconds == -1)
                {
                    MessageBox.Show("You timed out for inactivity.", "Timeout", MessageBoxButtons.OK);
                }
                if (RemainingSeconds == -2)
                {
                    TimeoutTimer.Stop();
                    Console.WriteLine("Time Stopped");
                    SignOutUserAsync();
                    Console.WriteLine("Signed out");
                }
            }
            else
            {
                UpdateTimeCountLabel();
            }
        }

        private void UpdateTimeCountLabel()
        {
            // Format remaining time into minutes and seconds
            TimeSpan remainingTime = TimeSpan.FromSeconds(RemainingSeconds);
            TimeCount.Text = $"Time left: {remainingTime}";
        }

        // Custom window dragging for the borderless window
        public Point mouseLocation;
        private void MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        // Exit button with secondary confirmation
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Windows control for resizing button
        private void ResizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState != FormWindowState.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        // Windows control for minimize button
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Menu expanding
        bool MenuExpand = true;

        private void MenuButton_Click(object sender, EventArgs e)
        {
            // Start expand timer
            MenuBarExpandTimer.Start();
        }

        private void MenuBarExpand_Tick(object sender, EventArgs e)
        {
            if (MenuExpand)
            {
                // If expand, minimize
                MenuContainer.Width -= 8; // Per tick
                //Console.WriteLine("Current Height: " + UserImage.Height + " Current Width: " + UserImage.Width);
                UserImage.Height -= 1; UserImage.Width -= 1;
                UserSeperator.Width -= 9;
                UserSeperator1.Width -= 9;
                if (MenuContainer.Width == MenuContainer.MinimumSize.Width)
                {
                    MenuExpand = false;
                    MenuBarExpandTimer.Stop();
                }
                MainFrameLogo.Image = null;

            }
            else
            {
                MenuContainer.Width += 12;
                //Console.WriteLine("Current Height: " + UserImage.Height + " Current Width: " + UserImage.Width);
                UserImage.Height += 1; UserImage.Width += 1;
                UserSeperator1.Width += 14;
                UserSeperator.Width += 14;
                if (MenuContainer.Width == MenuContainer.MaximumSize.Width)
                {
                    MenuExpand = true;
                    MenuBarExpandTimer.Stop();
                    MainFrameLogo.Image = Resources.logo;
                }
            }
        }

        private void TicketsButton_Click(object sender, EventArgs e)
        {
            if (Tickets == null)
            {
                if (Reports != null)
                {
                    Reports.Close();
                }

                Tickets = new TicketsForm();
                Tickets.FormClosed += Tickets_FormClosed;
                Tickets.MdiParent = this;
                Tickets.Dock = DockStyle.Fill;
                Tickets.Show();
            }
            else
            {
                Tickets.Activate();
            }
        }

        private void Tickets_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Tickets?.Dispose(); // Releaseing resource
            Tickets = null;
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            if (Reports == null)
            {
                if (Tickets != null)
                {
                    Tickets.Close();
                }
                Reports = new ReportsForm();
                Reports.FormClosed += Reports_FormClosed;
                Reports.MdiParent = this;
                Reports.Dock = DockStyle.Fill;
                Reports.Show();
            }
            else
            {
                Reports.Activate();
            }
        }

        private void Reports_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Reports?.Dispose(); // Releasing resources
            Reports = null;
        }

        private async Task SignOutUserAsync()
        {
            if (_Result != null)
            {
                // Get account identifier
                string accountId = _Result.Account.HomeAccountId.Identifier;

                // Get the account asynchronously
                Task<IAccount> accountTask = _appp.GetAccountAsync(accountId);
                IAccount account = await accountTask;

                // Remove the account asynchronously and set result to null AKA signing user out everything
                await _appp.RemoveAsync(account);
            }
             
            _Result = null;
        }

        private async void SignOutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await SignOutUserAsync();
                DialogResult = DialogResult.Cancel;
                this.Close();
                TimeoutTimer.Stop();

                if (_Result != null)
                {
                    // Check if the token has expired (assuming 'result' holds the authentication result)
                    if (_Result.ExpiresOn <= DateTimeOffset.UtcNow)
                    {
                        // Token has expired, user needs to re-authenticate
                        Console.WriteLine($"Authentication token has expired.");
                    }
                    else
                    {
                        // Token is valid, user is authenticated
                        Console.WriteLine($"User is authenticated. Expires on {_Result.ExpiresOn} | Time now {DateTimeOffset.UtcNow}");
                    }
                }
                else
                {
                    // No authentication token or result found, user is not signed in
                    Console.WriteLine("User is not signed in.");
                }

            }
        }

        private void MainParentForm_Load(object sender, EventArgs e)
        {
            //TODO; Get name from database instead of hardcode      -  4/11/24 Done
            //TODO; Get position from database instead of hardcode
            UserImage.Image = MakeRoundProfilePicture().ToImage();
            UserImage.Size = new Size(60, 60);
            PersonFirstNameLabel.Text = ClientInformation.FirstName;
            PersonLastNameLabel.Text = ClientInformation.LastName;
            PositionLabel.Text = "Tech Support Manager";
        }

        public MemoryStream MakeRoundProfilePicture()
        {
            var handler = new JwtSecurityTokenHandler();

            if (_Result != null)
            {
                // Reads the jwt token
                var jwtSecurityToken = handler.ReadJwtToken(_Result.AccessToken);
                // Gets the claims from the jwt token
                var claims = jwtSecurityToken.Claims;
                // Outputs the claims to the console
                foreach (var claim in claims)
                {
                    ClientInformation.FirstName = claim.Type == "given_name" ? claim.Value : ClientInformation.FirstName;
                    ClientInformation.LastName = claim.Type == "family_name" ? claim.Value : ClientInformation.LastName;
                }
            }

            // Get first letter of first and last
            var StringProfilePicture = string.Format("{0}{1}", ClientInformation.FirstName[0], ClientInformation.LastName[0]).ToUpper();

            //  BitMap creation
            var BitMap = new Bitmap(96, 96);
            // Set center
            var StringFormat = new StringFormat();
            StringFormat.Alignment = StringAlignment.Center;
            StringFormat.LineAlignment = StringAlignment.Center;
            // Font and graphic drawing
            var Font = new Font("Helvetica", 52, FontStyle.Bold, GraphicsUnit.Pixel);
            var Graphics = System.Drawing.Graphics.FromImage(BitMap);
            // Background to transparent
            Graphics.Clear(Color.Transparent);
            Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            using (Brush Brush = new SolidBrush(ColorTranslator.FromHtml("#38785E")))
            {
                Graphics.FillEllipse(Brush, new Rectangle(0, 0, 96, 96));
            }
            Graphics.DrawString(StringProfilePicture, Font, new SolidBrush(Color.WhiteSmoke), 49, 50, StringFormat);
            Graphics.Flush();

            // Store MemoryStream
            var MemoryStream = new MemoryStream();
            BitMap.Save(MemoryStream, ImageFormat.Png);
            return MemoryStream;
        }

    }
    public static class MemoryStreamExtensions
    {
        public static Image ToImage(this MemoryStream stream)
        {
            return Image.FromStream(stream);
        }
    }
}
