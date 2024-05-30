namespace WinFormsDesktopApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gradient1 = new Gradient();
            InvalidLabel = new Label();
            pictureBox1 = new PictureBox();
            LogInButton = new Button();
            LoginHeaderPanel = new Panel();
            LoginFormMinimizeButton = new Button();
            LoginFormExitButton = new Button();
            LoginFormTitle = new Label();
            gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LoginHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gradient1
            // 
            gradient1.Angle = 90F;
            gradient1.BottomColor = Color.FromArgb(4, 37, 27);
            gradient1.Controls.Add(InvalidLabel);
            gradient1.Controls.Add(pictureBox1);
            gradient1.Controls.Add(LogInButton);
            gradient1.Controls.Add(LoginHeaderPanel);
            gradient1.Dock = DockStyle.Fill;
            gradient1.Location = new Point(0, 0);
            gradient1.Name = "gradient1";
            gradient1.Size = new Size(350, 400);
            gradient1.TabIndex = 0;
            gradient1.TopColor = Color.FromArgb(23, 84, 66);
            gradient1.Paint += gradient1_Paint;
            gradient1.MouseDown += mouseDown;
            gradient1.MouseMove += mouseMove;
            // 
            // InvalidLabel
            // 
            InvalidLabel.Anchor = AnchorStyles.None;
            InvalidLabel.AutoSize = true;
            InvalidLabel.BackColor = Color.Transparent;
            InvalidLabel.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvalidLabel.ForeColor = Color.IndianRed;
            InvalidLabel.Location = new Point(32, 375);
            InvalidLabel.Name = "InvalidLabel";
            InvalidLabel.Size = new Size(0, 15);
            InvalidLabel.TabIndex = 9;
            InvalidLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(114, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LogInButton
            // 
            LogInButton.FlatAppearance.BorderSize = 0;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.FromArgb(194, 162, 93);
            LogInButton.Location = new Point(125, 200);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(100, 38);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // LoginHeaderPanel
            // 
            LoginHeaderPanel.BackColor = Color.FromArgb(5, 52, 38);
            LoginHeaderPanel.Controls.Add(LoginFormMinimizeButton);
            LoginHeaderPanel.Controls.Add(LoginFormExitButton);
            LoginHeaderPanel.Controls.Add(LoginFormTitle);
            LoginHeaderPanel.Location = new Point(0, 0);
            LoginHeaderPanel.Name = "LoginHeaderPanel";
            LoginHeaderPanel.Size = new Size(350, 25);
            LoginHeaderPanel.TabIndex = 11;
            LoginHeaderPanel.MouseDown += mouseDown;
            LoginHeaderPanel.MouseMove += mouseMove;
            // 
            // LoginFormMinimizeButton
            // 
            LoginFormMinimizeButton.BackColor = Color.FromArgb(5, 52, 38);
            LoginFormMinimizeButton.FlatAppearance.BorderSize = 0;
            LoginFormMinimizeButton.FlatStyle = FlatStyle.Flat;
            LoginFormMinimizeButton.Font = new Font("Helvetica", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginFormMinimizeButton.Image = Properties.Resources.Minimize2;
            LoginFormMinimizeButton.Location = new Point(309, -11);
            LoginFormMinimizeButton.Name = "LoginFormMinimizeButton";
            LoginFormMinimizeButton.Size = new Size(15, 30);
            LoginFormMinimizeButton.TabIndex = 1;
            LoginFormMinimizeButton.TabStop = false;
            LoginFormMinimizeButton.UseVisualStyleBackColor = false;
            LoginFormMinimizeButton.Click += LoginFormMinimizeButton_Click;
            // 
            // LoginFormExitButton
            // 
            LoginFormExitButton.BackColor = Color.FromArgb(5, 52, 38);
            LoginFormExitButton.FlatAppearance.BorderSize = 0;
            LoginFormExitButton.FlatStyle = FlatStyle.Flat;
            LoginFormExitButton.Image = Properties.Resources.Close2;
            LoginFormExitButton.Location = new Point(330, 4);
            LoginFormExitButton.Name = "LoginFormExitButton";
            LoginFormExitButton.Size = new Size(15, 15);
            LoginFormExitButton.TabIndex = 0;
            LoginFormExitButton.TabStop = false;
            LoginFormExitButton.UseVisualStyleBackColor = false;
            LoginFormExitButton.Click += LoginExitButton_Click;
            // 
            // LoginFormTitle
            // 
            LoginFormTitle.BackColor = Color.Transparent;
            LoginFormTitle.Font = new Font("Helvetica", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginFormTitle.ForeColor = Color.FromArgb(194, 162, 93);
            LoginFormTitle.Location = new Point(3, 4);
            LoginFormTitle.Name = "LoginFormTitle";
            LoginFormTitle.Size = new Size(347, 15);
            LoginFormTitle.TabIndex = 10;
            LoginFormTitle.Text = "Ticket Dashboard Login";
            LoginFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            LoginFormTitle.MouseDown += mouseDown;
            LoginFormTitle.MouseMove += mouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 84, 66);
            ClientSize = new Size(350, 400);
            Controls.Add(gradient1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            gradient1.ResumeLayout(false);
            gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LoginHeaderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Gradient gradient1;
        private Button LoginFormMinimizeButton;
        private Button LoginFormExitButton;
        private Label ForgotPassword;
        private Label PasswordLabel;
        private Label EmailLabel;
        private Panel panel1;
        private Panel panel2;
        private Button LogInButton;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Label InvalidLabel;
        private Label LoginFormTitle;
        private Panel LoginHeaderPanel;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}