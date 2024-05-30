namespace WinFormsDesktopApp
{
    partial class MainParentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TransparentPictureBox tb;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel3 = new Panel();
            TimeCount = new Label();
            MenuButton = new Button();
            MinimizeButton = new Button();
            ResizeButton = new Button();
            CloseButton = new Button();
            label1 = new Label();
            MenuContainer = new Gradient();
            MainFrameLogo = new TransparentPictureBox();
            panel10 = new Panel();
            SignOutButton = new Button();
            panel1 = new Panel();
            UserSeperator1 = new Panel();
            UserSeperator = new Panel();
            PositionLabel = new Label();
            UserImage = new PictureBox();
            PersonLastNameLabel = new Label();
            PersonFirstNameLabel = new Label();
            panel2 = new Panel();
            TicketsButton = new Button();
            panel5 = new Panel();
            ReportsButton = new Button();
            MenuBarExpandTimer = new System.Windows.Forms.Timer(components);
            panel11 = new Panel();
            panel3.SuspendLayout();
            MenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainFrameLogo).BeginInit();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserImage).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 84, 66);
            panel3.Controls.Add(TimeCount);
            panel3.Controls.Add(MenuButton);
            panel3.Controls.Add(MinimizeButton);
            panel3.Controls.Add(ResizeButton);
            panel3.Controls.Add(CloseButton);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 44);
            panel3.TabIndex = 1;
            panel3.MouseDown += MouseDown;
            panel3.MouseMove += MouseMove;
            // 
            // TimeCount
            // 
            TimeCount.AutoSize = true;
            TimeCount.BackColor = Color.FromArgb(5, 52, 38);
            TimeCount.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeCount.ForeColor = Color.FromArgb(194, 162, 93);
            TimeCount.Location = new Point(200, 9);
            TimeCount.Name = "TimeCount";
            TimeCount.Size = new Size(0, 22);
            TimeCount.TabIndex = 8;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(5, 52, 38);
            MenuButton.Dock = DockStyle.Left;
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 62, 49);
            MenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 73, 57);
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Image = Properties.Resources.hamburger_menu_icon2;
            MenuButton.Location = new Point(0, 0);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(56, 44);
            MenuButton.TabIndex = 6;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(5, 52, 38);
            MinimizeButton.BackgroundImage = Properties.Resources.Minimize2;
            MinimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinimizeButton.Dock = DockStyle.Right;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimizeButton.ForeColor = SystemColors.Control;
            MinimizeButton.Location = new Point(1125, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Padding = new Padding(2, 0, 2, 0);
            MinimizeButton.Size = new Size(25, 44);
            MinimizeButton.TabIndex = 0;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // ResizeButton
            // 
            ResizeButton.BackColor = Color.FromArgb(5, 52, 38);
            ResizeButton.BackgroundImage = Properties.Resources.Resize2;
            ResizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            ResizeButton.Dock = DockStyle.Right;
            ResizeButton.FlatAppearance.BorderSize = 0;
            ResizeButton.FlatStyle = FlatStyle.Flat;
            ResizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResizeButton.ForeColor = SystemColors.Control;
            ResizeButton.Location = new Point(1150, 0);
            ResizeButton.Name = "ResizeButton";
            ResizeButton.Padding = new Padding(2, 0, 2, 0);
            ResizeButton.Size = new Size(25, 44);
            ResizeButton.TabIndex = 0;
            ResizeButton.UseVisualStyleBackColor = false;
            ResizeButton.Click += ResizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(5, 52, 38);
            CloseButton.BackgroundImage = Properties.Resources.Close2;
            CloseButton.BackgroundImageLayout = ImageLayout.Zoom;
            CloseButton.Dock = DockStyle.Right;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.ForeColor = SystemColors.Control;
            CloseButton.Location = new Point(1175, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new Padding(2, 0, 2, 0);
            CloseButton.Size = new Size(25, 44);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(5, 52, 38);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(194, 162, 93);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1200, 44);
            label1.TabIndex = 1;
            label1.Text = "BitBuggy Ticket Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += MouseDown;
            label1.MouseMove += MouseMove;
            // 
            // MenuContainer
            // 
            MenuContainer.Angle = 90F;
            MenuContainer.BackColor = Color.Transparent;
            MenuContainer.BottomColor = Color.FromArgb(5, 52, 38);
            MenuContainer.Controls.Add(MainFrameLogo);
            MenuContainer.Controls.Add(panel10);
            MenuContainer.Controls.Add(panel1);
            MenuContainer.Controls.Add(panel2);
            MenuContainer.Controls.Add(panel5);
            MenuContainer.Dock = DockStyle.Left;
            MenuContainer.Location = new Point(0, 44);
            MenuContainer.MaximumSize = new Size(200, 1080);
            MenuContainer.MinimumSize = new Size(49, 0);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(200, 656);
            MenuContainer.TabIndex = 0;
            MenuContainer.TopColor = Color.FromArgb(5, 52, 38);
            // 
            // MainFrameLogo
            // 
            MainFrameLogo.BackColor = Color.Transparent;
            MainFrameLogo.Dock = DockStyle.Bottom;
            MainFrameLogo.Image = Properties.Resources.logo;
            MainFrameLogo.Location = new Point(0, 466);
            MainFrameLogo.Name = "MainFrameLogo";
            MainFrameLogo.Size = new Size(200, 140);
            MainFrameLogo.TabIndex = 14;
            MainFrameLogo.TabStop = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(SignOutButton);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 606);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 50);
            panel10.TabIndex = 13;
            // 
            // SignOutButton
            // 
            SignOutButton.BackColor = Color.Transparent;
            SignOutButton.FlatAppearance.BorderSize = 0;
            SignOutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 62, 49);
            SignOutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 84, 66);
            SignOutButton.FlatStyle = FlatStyle.Flat;
            SignOutButton.Font = new Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignOutButton.ForeColor = Color.FromArgb(194, 162, 93);
            SignOutButton.Image = Properties.Resources.Signout_Button3;
            SignOutButton.Location = new Point(-176, -8);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Padding = new Padding(6, 0, 0, 0);
            SignOutButton.Size = new Size(395, 65);
            SignOutButton.TabIndex = 6;
            SignOutButton.Text = "                         Sign Out";
            SignOutButton.UseVisualStyleBackColor = false;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(UserSeperator1);
            panel1.Controls.Add(UserSeperator);
            panel1.Controls.Add(PositionLabel);
            panel1.Controls.Add(UserImage);
            panel1.Controls.Add(PersonLastNameLabel);
            panel1.Controls.Add(PersonFirstNameLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 153);
            panel1.TabIndex = 6;
            // 
            // UserSeperator1
            // 
            UserSeperator1.BackColor = Color.FromArgb(194, 162, 93);
            UserSeperator1.Location = new Point(10, 3);
            UserSeperator1.MaximumSize = new Size(171, 2);
            UserSeperator1.MinimumSize = new Size(0, 2);
            UserSeperator1.Name = "UserSeperator1";
            UserSeperator1.Size = new Size(171, 2);
            UserSeperator1.TabIndex = 9;
            // 
            // UserSeperator
            // 
            UserSeperator.BackColor = Color.FromArgb(194, 162, 93);
            UserSeperator.Location = new Point(10, 135);
            UserSeperator.MaximumSize = new Size(171, 2);
            UserSeperator.MinimumSize = new Size(0, 2);
            UserSeperator.Name = "UserSeperator";
            UserSeperator.Size = new Size(171, 2);
            UserSeperator.TabIndex = 9;
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Font = new Font("Helvetica", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PositionLabel.ForeColor = Color.FromArgb(194, 162, 93);
            PositionLabel.Location = new Point(68, 80);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(0, 14);
            PositionLabel.TabIndex = 8;
            // 
            // UserImage
            // 
            UserImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserImage.Location = new Point(4, 37);
            UserImage.MaximumSize = new Size(60, 60);
            UserImage.MinimumSize = new Size(36, 36);
            UserImage.Name = "UserImage";
            UserImage.Size = new Size(60, 60);
            UserImage.SizeMode = PictureBoxSizeMode.Zoom;
            UserImage.TabIndex = 0;
            UserImage.TabStop = false;
            // 
            // PersonLastNameLabel
            // 
            PersonLastNameLabel.AutoSize = true;
            PersonLastNameLabel.BackColor = Color.Transparent;
            PersonLastNameLabel.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonLastNameLabel.ForeColor = Color.FromArgb(194, 162, 93);
            PersonLastNameLabel.Location = new Point(68, 59);
            PersonLastNameLabel.Name = "PersonLastNameLabel";
            PersonLastNameLabel.Size = new Size(0, 19);
            PersonLastNameLabel.TabIndex = 8;
            // 
            // PersonFirstNameLabel
            // 
            PersonFirstNameLabel.AutoSize = true;
            PersonFirstNameLabel.BackColor = Color.Transparent;
            PersonFirstNameLabel.Font = new Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonFirstNameLabel.ForeColor = Color.FromArgb(194, 162, 93);
            PersonFirstNameLabel.Location = new Point(68, 40);
            PersonFirstNameLabel.Name = "PersonFirstNameLabel";
            PersonFirstNameLabel.Size = new Size(0, 19);
            PersonFirstNameLabel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(TicketsButton);
            panel2.Location = new Point(0, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 50);
            panel2.TabIndex = 7;
            // 
            // TicketsButton
            // 
            TicketsButton.BackColor = Color.FromArgb(5, 52, 38);
            TicketsButton.BackgroundImageLayout = ImageLayout.Zoom;
            TicketsButton.FlatAppearance.BorderSize = 0;
            TicketsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 62, 49);
            TicketsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 84, 66);
            TicketsButton.FlatStyle = FlatStyle.Flat;
            TicketsButton.Font = new Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TicketsButton.ForeColor = Color.FromArgb(194, 162, 93);
            TicketsButton.Image = Properties.Resources.Ticket_Button_Icon3;
            TicketsButton.Location = new Point(-176, -6);
            TicketsButton.Name = "TicketsButton";
            TicketsButton.Padding = new Padding(6, 0, 0, 0);
            TicketsButton.Size = new Size(395, 65);
            TicketsButton.TabIndex = 6;
            TicketsButton.Text = "                       Tickets";
            TicketsButton.UseVisualStyleBackColor = false;
            TicketsButton.Click += TicketsButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(ReportsButton);
            panel5.Location = new Point(0, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 50);
            panel5.TabIndex = 8;
            // 
            // ReportsButton
            // 
            ReportsButton.BackColor = Color.FromArgb(5, 52, 38);
            ReportsButton.BackgroundImageLayout = ImageLayout.Zoom;
            ReportsButton.FlatAppearance.BorderSize = 0;
            ReportsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 62, 49);
            ReportsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 84, 66);
            ReportsButton.FlatStyle = FlatStyle.Flat;
            ReportsButton.Font = new Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportsButton.ForeColor = Color.FromArgb(194, 162, 93);
            ReportsButton.Image = Properties.Resources.Reports_Button_Icon3;
            ReportsButton.Location = new Point(-176, -6);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Padding = new Padding(6, 0, 0, 0);
            ReportsButton.Size = new Size(395, 65);
            ReportsButton.TabIndex = 6;
            ReportsButton.Text = "                         Reports";
            ReportsButton.UseVisualStyleBackColor = false;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // MenuBarExpandTimer
            // 
            MenuBarExpandTimer.Interval = 15;
            MenuBarExpandTimer.Tick += MenuBarExpand_Tick;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(173, 141, 73);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(200, 44);
            panel11.Name = "panel11";
            panel11.Size = new Size(1000, 2);
            panel11.TabIndex = 6;
            // 
            // MainParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 84, 66);
            ClientSize = new Size(1200, 700);
            Controls.Add(panel11);
            Controls.Add(MenuContainer);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainParentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BitBuggy Ticket Dashboard";
            Load += MainParentForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            MenuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainFrameLogo).EndInit();
            panel10.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserImage).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        //private FlowLayoutPanel MenuContainer;
        private Gradient MenuContainer;
        private Button CloseButton;
        private Button MinimizeButton;
        private Button ResizeButton;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button TicketsButton;
        private Button LogOutButton;
        private Panel panel5;
        private Button ReportsButton;
        private Button SignOutButton;
        private Button MenuButton;
        private System.Windows.Forms.Timer MenuBarExpandTimer;
        private Panel panel11;
        private PictureBox UserImage;
        private Label PositionLabel;
        private Label PersonFirstNameLabel;
        private Panel UserSeperator;
        private Panel UserSeperator1;
        private Panel panel10;
        private Label TimeCount;
        private Label PersonLastNameLabel;
        private TransparentPictureBox MainFrameLogo;
    }
}
