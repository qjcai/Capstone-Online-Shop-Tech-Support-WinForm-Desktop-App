namespace WinFormsDesktopApp
{
    partial class ReplyToTicketForm
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
            messageField = new TextBox();
            cancelButton = new Button();
            sendButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Message";
            // 
            // messageField
            // 
            messageField.Location = new Point(12, 32);
            messageField.Multiline = true;
            messageField.Name = "messageField";
            messageField.Size = new Size(434, 336);
            messageField.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(48, 374);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(170, 29);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(241, 374);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(170, 29);
            sendButton.TabIndex = 3;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // ReplyToTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 409);
            Controls.Add(sendButton);
            Controls.Add(cancelButton);
            Controls.Add(messageField);
            Controls.Add(label1);
            Name = "ReplyToTicketForm";
            Text = "Reply To Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox messageField;
        private Button cancelButton;
        private Button sendButton;
    }
}