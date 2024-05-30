namespace WinFormsDesktopApp
{
    partial class TicketUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ticketNameLabel = new Label();
            ticketDescLabel = new Label();
            ticketMiscLabel = new Label();
            SuspendLayout();
            // 
            // ticketNameLabel
            // 
            ticketNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ticketNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ticketNameLabel.Location = new Point(0, 2);
            ticketNameLabel.Name = "ticketNameLabel";
            ticketNameLabel.Size = new Size(324, 23);
            ticketNameLabel.TabIndex = 0;
            ticketNameLabel.Text = "Ticket Name";
            ticketNameLabel.Click += ticketNameLabel_Click;
            // 
            // ticketDescLabel
            // 
            ticketDescLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ticketDescLabel.Location = new Point(3, 25);
            ticketDescLabel.Name = "ticketDescLabel";
            ticketDescLabel.Size = new Size(483, 69);
            ticketDescLabel.TabIndex = 1;
            ticketDescLabel.Text = "Ticket Description";
            ticketDescLabel.Click += ticketNameLabel_Click;
            // 
            // ticketMiscLabel
            // 
            ticketMiscLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ticketMiscLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ticketMiscLabel.Location = new Point(0, 94);
            ticketMiscLabel.Name = "ticketMiscLabel";
            ticketMiscLabel.Size = new Size(486, 15);
            ticketMiscLabel.TabIndex = 0;
            ticketMiscLabel.Text = "Ticket Misc Information";
            ticketMiscLabel.Click += ticketNameLabel_Click;
            // 
            // TicketUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ticketMiscLabel);
            Controls.Add(ticketNameLabel);
            Controls.Add(ticketDescLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TicketUserControl";
            Size = new Size(486, 109);
            Click += ticketNameLabel_Click;
            ResumeLayout(false);
        }

        #endregion
        private Label ticketNameLabel;
        private Label ticketDescLabel;
        private Label ticketMiscLabel;
        private Label ticketPriorityLabel;
    }
}
