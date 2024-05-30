namespace WinFormsDesktopApp
{
    partial class NewTicketEditIDs
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
            orderIdField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            productIdField = new TextBox();
            label3 = new Label();
            shipmentIdField = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // orderIdField
            // 
            orderIdField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orderIdField.Location = new Point(124, 6);
            orderIdField.Name = "orderIdField";
            orderIdField.Size = new Size(236, 27);
            orderIdField.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Order ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(27, 42);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Product ID";
            // 
            // productIdField
            // 
            productIdField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            productIdField.Location = new Point(124, 39);
            productIdField.Name = "productIdField";
            productIdField.Size = new Size(236, 27);
            productIdField.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(27, 75);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "Shipment ID";
            // 
            // shipmentIdField
            // 
            shipmentIdField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            shipmentIdField.Location = new Point(124, 72);
            shipmentIdField.Name = "shipmentIdField";
            shipmentIdField.Size = new Size(236, 27);
            shipmentIdField.TabIndex = 4;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(12, 105);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(348, 29);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // NewTicketEditIDs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 139);
            Controls.Add(submitButton);
            Controls.Add(label3);
            Controls.Add(shipmentIdField);
            Controls.Add(label2);
            Controls.Add(productIdField);
            Controls.Add(label1);
            Controls.Add(orderIdField);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "NewTicketEditIDs";
            Text = "New Ticket - Edit IDs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox orderIdField;
        private Label label1;
        private Label label2;
        private TextBox productIdField;
        private Label label3;
        private TextBox shipmentIdField;
        private Button submitButton;
    }
}