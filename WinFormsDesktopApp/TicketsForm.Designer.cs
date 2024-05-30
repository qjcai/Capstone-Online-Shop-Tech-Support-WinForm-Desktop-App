namespace WinFormsDesktopApp
{
    partial class TicketsForm
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
            ticketsLayoutPanel = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newTicketToolStripMenuItem = new ToolStripMenuItem();
            refreshTicketsListToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ticketsLayoutPanel
            // 
            ticketsLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ticketsLayoutPanel.AutoScroll = true;
            ticketsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ticketsLayoutPanel.Location = new Point(12, 64);
            ticketsLayoutPanel.Name = "ticketsLayoutPanel";
            ticketsLayoutPanel.Size = new Size(890, 524);
            ticketsLayoutPanel.TabIndex = 0;
            ticketsLayoutPanel.WrapContents = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newTicketToolStripMenuItem, refreshTicketsListToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newTicketToolStripMenuItem
            // 
            newTicketToolStripMenuItem.Name = "newTicketToolStripMenuItem";
            newTicketToolStripMenuItem.Size = new Size(224, 26);
            newTicketToolStripMenuItem.Text = "New Ticket";
            newTicketToolStripMenuItem.Click += newTicketToolStripMenuItem_Click;
            // 
            // refreshTicketsListToolStripMenuItem
            // 
            refreshTicketsListToolStripMenuItem.Name = "refreshTicketsListToolStripMenuItem";
            refreshTicketsListToolStripMenuItem.Size = new Size(224, 26);
            refreshTicketsListToolStripMenuItem.Text = "Refresh Tickets List";
            refreshTicketsListToolStripMenuItem.Click += refreshTicketsListToolStripMenuItem_Click;
            // 
            // TicketsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(914, 600);
            Controls.Add(ticketsLayoutPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicketsForm";
            Text = "Form2";
            Load += TicketsForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel ticketsLayoutPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newTicketToolStripMenuItem;
        private ToolStripMenuItem refreshTicketsListToolStripMenuItem;
    }
}