namespace WinFormsDesktopApp
{
    partial class NewTicketForm
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
            label1 = new Label();
            ticketNameField = new TextBox();
            label2 = new Label();
            categoryComboBox = new ComboBox();
            label3 = new Label();
            ticketDescField = new TextBox();
            cancelButton = new Button();
            createButton = new Button();
            contactEmailField = new TextBox();
            label4 = new Label();
            priorityComboBox = new ComboBox();
            label5 = new Label();
            updateIdsButton = new Button();
            label6 = new Label();
            dateTimePicker = new DateTimePicker();
            statusComboBox = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Ticket Name";
            // 
            // ticketNameField
            // 
            ticketNameField.BorderStyle = BorderStyle.FixedSingle;
            ticketNameField.Location = new Point(130, 12);
            ticketNameField.Name = "ticketNameField";
            ticketNameField.Size = new Size(196, 27);
            ticketNameField.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Ticket Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FlatStyle = FlatStyle.System;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Complaints and Concerns", "INTERNAL - Technical Support", "Refunds and Returns", "Website Issue" });
            categoryComboBox.Location = new Point(130, 45);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(196, 28);
            categoryComboBox.Sorted = true;
            categoryComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Ticket Description";
            // 
            // ticketDescField
            // 
            ticketDescField.BorderStyle = BorderStyle.FixedSingle;
            ticketDescField.Location = new Point(15, 151);
            ticketDescField.Multiline = true;
            ticketDescField.Name = "ticketDescField";
            ticketDescField.ScrollBars = ScrollBars.Vertical;
            ticketDescField.Size = new Size(910, 244);
            ticketDescField.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 401);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(190, 29);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            createButton.Location = new Point(735, 401);
            createButton.Name = "createButton";
            createButton.Size = new Size(190, 29);
            createButton.TabIndex = 7;
            createButton.Text = "Create Ticket";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // contactEmailField
            // 
            contactEmailField.BorderStyle = BorderStyle.FixedSingle;
            contactEmailField.Location = new Point(450, 12);
            contactEmailField.Name = "contactEmailField";
            contactEmailField.Size = new Size(196, 27);
            contactEmailField.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 15);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 8;
            label4.Text = "Contact Email";
            // 
            // priorityComboBox
            // 
            priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityComboBox.FlatStyle = FlatStyle.System;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            priorityComboBox.Location = new Point(450, 45);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(196, 28);
            priorityComboBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 48);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 10;
            label5.Text = "Ticket Priority";
            // 
            // updateIdsButton
            // 
            updateIdsButton.FlatStyle = FlatStyle.System;
            updateIdsButton.Location = new Point(699, 12);
            updateIdsButton.Name = "updateIdsButton";
            updateIdsButton.Size = new Size(226, 29);
            updateIdsButton.TabIndex = 12;
            updateIdsButton.Text = "Update IDs";
            updateIdsButton.UseVisualStyleBackColor = true;
            updateIdsButton.Click += updateIdsButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(652, 48);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 13;
            label6.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(699, 46);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(226, 27);
            dateTimePicker.TabIndex = 15;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FlatStyle = FlatStyle.System;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Open", "In Progress", "Waiting on Customer", "On Hold", "Closed" });
            statusComboBox.Location = new Point(130, 79);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(196, 28);
            statusComboBox.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 82);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 16;
            label7.Text = "Ticket Status";
            // 
            // NewTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 442);
            Controls.Add(statusComboBox);
            Controls.Add(label7);
            Controls.Add(dateTimePicker);
            Controls.Add(label6);
            Controls.Add(updateIdsButton);
            Controls.Add(priorityComboBox);
            Controls.Add(label5);
            Controls.Add(contactEmailField);
            Controls.Add(label4);
            Controls.Add(createButton);
            Controls.Add(cancelButton);
            Controls.Add(ticketDescField);
            Controls.Add(label3);
            Controls.Add(categoryComboBox);
            Controls.Add(label2);
            Controls.Add(ticketNameField);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NewTicketForm";
            Text = "New Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ticketNameField;
        private Label label2;
        private ComboBox categoryComboBox;
        private Label label3;
        private TextBox ticketDescField;
        private Button cancelButton;
        private Button createButton;
        private TextBox contactEmailField;
        private Label label4;
        private ComboBox priorityComboBox;
        private Label label5;
        private Button updateIdsButton;
        private Label label6;
        private DateTimePicker dateTimePicker;
        private ComboBox statusComboBox;
        private Label label7;
    }
}