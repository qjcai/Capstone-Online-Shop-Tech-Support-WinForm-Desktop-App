namespace WinFormsDesktopApp
{
    partial class ViewTicketForm
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            contactEmailField = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ticketNameField = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            productIdField = new TextBox();
            label10 = new Label();
            ticketDescField = new TextBox();
            shipmentIdField = new TextBox();
            orderIdField = new TextBox();
            statusComboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            priorityComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileMenuButton = new ToolStripMenuItem();
            fileSaveMenuButton = new ToolStripMenuItem();
            fileExitMenuButton = new ToolStripMenuItem();
            replyMenuButton = new ToolStripMenuItem();
            replyAddMenuButton = new ToolStripMenuItem();
            replyViewMenuButton = new ToolStripMenuItem();
            fileDeleteMenuButton = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 109);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 33;
            label7.Text = "Ticket Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 109);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 31;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 75);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 28;
            label5.Text = "Ticket Priority";
            // 
            // contactEmailField
            // 
            contactEmailField.BorderStyle = BorderStyle.FixedSingle;
            contactEmailField.Location = new Point(441, 39);
            contactEmailField.Name = "contactEmailField";
            contactEmailField.Size = new Size(196, 27);
            contactEmailField.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 43);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 26;
            label4.Text = "Contact Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 22;
            label3.Text = "Ticket Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 20;
            label2.Text = "Ticket Category";
            // 
            // ticketNameField
            // 
            ticketNameField.BorderStyle = BorderStyle.FixedSingle;
            ticketNameField.Location = new Point(130, 39);
            ticketNameField.Name = "ticketNameField";
            ticketNameField.Size = new Size(196, 27);
            ticketNameField.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 18;
            label1.Text = "Ticket Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 104);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 41;
            label8.Text = "Shipment ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(684, 71);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 40;
            label9.Text = "Order ID";
            // 
            // productIdField
            // 
            productIdField.BorderStyle = BorderStyle.FixedSingle;
            productIdField.Location = new Point(756, 36);
            productIdField.Name = "productIdField";
            productIdField.Size = new Size(196, 27);
            productIdField.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(671, 41);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 38;
            label10.Text = "Product ID";
            // 
            // ticketDescField
            // 
            ticketDescField.BorderStyle = BorderStyle.FixedSingle;
            ticketDescField.Location = new Point(12, 183);
            ticketDescField.Multiline = true;
            ticketDescField.Name = "ticketDescField";
            ticketDescField.ScrollBars = ScrollBars.Vertical;
            ticketDescField.Size = new Size(940, 282);
            ticketDescField.TabIndex = 23;
            // 
            // shipmentIdField
            // 
            shipmentIdField.BorderStyle = BorderStyle.FixedSingle;
            shipmentIdField.Location = new Point(756, 103);
            shipmentIdField.Name = "shipmentIdField";
            shipmentIdField.Size = new Size(196, 27);
            shipmentIdField.TabIndex = 47;
            // 
            // orderIdField
            // 
            orderIdField.BorderStyle = BorderStyle.FixedSingle;
            orderIdField.Location = new Point(756, 69);
            orderIdField.Name = "orderIdField";
            orderIdField.Size = new Size(196, 27);
            orderIdField.TabIndex = 46;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FlatStyle = FlatStyle.System;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Open", "In Progress", "Waiting on Customer", "On Hold", "Closed" });
            statusComboBox.Location = new Point(130, 106);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(196, 28);
            statusComboBox.TabIndex = 52;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(441, 106);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(196, 27);
            dateTimePicker.TabIndex = 51;
            // 
            // priorityComboBox
            // 
            priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityComboBox.FlatStyle = FlatStyle.System;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            priorityComboBox.Location = new Point(441, 72);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(196, 28);
            priorityComboBox.TabIndex = 50;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FlatStyle = FlatStyle.System;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Complaints and Concerns", "INTERNAL - Technical Support", "Refunds and Returns", "Website Issue" });
            categoryComboBox.Location = new Point(130, 72);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(196, 28);
            categoryComboBox.Sorted = true;
            categoryComboBox.TabIndex = 49;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenuButton, replyMenuButton });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(965, 28);
            menuStrip1.TabIndex = 54;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuButton
            // 
            fileMenuButton.DropDownItems.AddRange(new ToolStripItem[] { fileSaveMenuButton, fileDeleteMenuButton, fileExitMenuButton });
            fileMenuButton.Name = "fileMenuButton";
            fileMenuButton.Size = new Size(46, 24);
            fileMenuButton.Text = "&File";
            // 
            // fileSaveMenuButton
            // 
            fileSaveMenuButton.Name = "fileSaveMenuButton";
            fileSaveMenuButton.ShortcutKeys = Keys.Control | Keys.S;
            fileSaveMenuButton.Size = new Size(224, 26);
            fileSaveMenuButton.Text = "&Save";
            fileSaveMenuButton.Click += fileSaveMenuButton_Click;
            // 
            // fileExitMenuButton
            // 
            fileExitMenuButton.Name = "fileExitMenuButton";
            fileExitMenuButton.ShortcutKeys = Keys.Control | Keys.Alt | Keys.E;
            fileExitMenuButton.Size = new Size(224, 26);
            fileExitMenuButton.Text = "&Exit";
            fileExitMenuButton.Click += fileExitMenuButton_Click;
            // 
            // replyMenuButton
            // 
            replyMenuButton.DropDownItems.AddRange(new ToolStripItem[] { replyAddMenuButton, replyViewMenuButton });
            replyMenuButton.Name = "replyMenuButton";
            replyMenuButton.Size = new Size(60, 24);
            replyMenuButton.Text = "&Reply";
            // 
            // replyAddMenuButton
            // 
            replyAddMenuButton.Name = "replyAddMenuButton";
            replyAddMenuButton.ShortcutKeys = Keys.Control | Keys.Alt | Keys.R;
            replyAddMenuButton.Size = new Size(257, 26);
            replyAddMenuButton.Text = "&Add Reply";
            replyAddMenuButton.Click += replyAddMenuButton_Click;
            // 
            // replyViewMenuButton
            // 
            replyViewMenuButton.Name = "replyViewMenuButton";
            replyViewMenuButton.ShortcutKeys = Keys.Control | Keys.Alt | Keys.A;
            replyViewMenuButton.Size = new Size(257, 26);
            replyViewMenuButton.Text = "&View Replies";
            replyViewMenuButton.Click += replyViewMenuButton_Click;
            // 
            // fileDeleteMenuButton
            // 
            fileDeleteMenuButton.Name = "fileDeleteMenuButton";
            fileDeleteMenuButton.Size = new Size(224, 26);
            fileDeleteMenuButton.Text = "Delete";
            fileDeleteMenuButton.Click += fileDeleteMenuButton_Click;
            // 
            // ViewTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 477);
            Controls.Add(statusComboBox);
            Controls.Add(dateTimePicker);
            Controls.Add(priorityComboBox);
            Controls.Add(categoryComboBox);
            Controls.Add(shipmentIdField);
            Controls.Add(orderIdField);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(productIdField);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(contactEmailField);
            Controls.Add(label4);
            Controls.Add(ticketDescField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ticketNameField);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ViewTicketForm";
            Text = "View Ticket Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox contactEmailField;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox ticketNameField;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private TextBox productIdField;
        private Label label10;
        private TextBox ticketDescField;
        private TextBox shipmentIdField;
        private TextBox orderIdField;
        private ComboBox statusComboBox;
        private DateTimePicker dateTimePicker;
        private ComboBox priorityComboBox;
        private ComboBox categoryComboBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenuButton;
        private ToolStripMenuItem fileSaveMenuButton;
        private ToolStripMenuItem fileExitMenuButton;
        private ToolStripMenuItem replyMenuButton;
        private ToolStripMenuItem replyAddMenuButton;
        private ToolStripMenuItem replyViewMenuButton;
        private ToolStripMenuItem fileDeleteMenuButton;
    }
}